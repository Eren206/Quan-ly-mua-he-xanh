using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class FrmXa : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection = new SqlConnection();
        private BindingSource BdsDiaBan = new BindingSource();
        private BindingSource BdsPhuongXa = new BindingSource();

        int vitri = 0;
        bool dangThemMoi = false;

        private int ConnectToDMHCQG()
        {
            if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            try
            {
                connection.ConnectionString = Program.connstrPublisher;
                connection.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void GetPhuongXa(String cmd)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connection);
            da.Fill(dt);


            connection.Close();
            BdsPhuongXa.DataSource = dt;

            comboBox2.DataBindings.Clear();

            comboBox2.DataSource = BdsPhuongXa;
            comboBox2.DisplayMember = "Ten";
            comboBox2.ValueMember = "Id";
        }

        public FrmXa()
        {
            InitializeComponent();
        }

        private void xaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diaBanDataSet);
        }

        private void FrmXa_Load(object sender, EventArgs e)
        {
            diaBanDataSet.EnforceConstraints = false;

            xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.diaBanDataSet.Xa);
            apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.diaBanDataSet.Ap);

            string cmd = "Select IdDB, Ten From DiaBan";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connstr);
            da.Fill(dt);

            Program.conn.Close();
            BdsDiaBan.DataSource = dt;

            comboBox1.DataBindings.Clear();

            comboBox1.DataSource = BdsDiaBan;
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "IdDB";

            if (Program.mGroup == "SinhVien" || Program.mGroup == "GiamSat")
            {
                BtnThem.Enabled = false;

                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ConnectToDMHCQG() == 0) return;
            GetPhuongXa("Select Id, Ten from PhuongXa WHERE IdQuanHuyen = " + comboBox1.SelectedValue.ToString());

            txtTen.Text = comboBox2.Text;
            txtDiaBan.Text = comboBox1.SelectedValue.ToString();
            comboBox2.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Text = comboBox2.Text;
            txtId.Text = comboBox2.SelectedValue.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            dangThemMoi = true;
            groupControl1.Enabled = false;

            BtnXoa.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            comboBox1.Visible = comboBox2.Visible = label1.Visible = true;

            groupControl1.Enabled = false;
            groupControl2.Enabled = true;

            xaBindingSource.AddNew();
            txtTen.Text = comboBox2.Text;

            if (comboBox2.Items.Count != 0)
            {
                txtId.Text = comboBox2.SelectedValue.ToString();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (xaBindingSource.Count == 0)
            {
                MessageBox.Show("Không còn phường/xã nào để xóa!", "Thông báo");
                return;
            }

            if (apBindingSource.Count != 0)
            {
                MessageBox.Show("Xã này đã có KP/Ấp được chọn trong chiến dịch, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa " + txtTen.Text.Trim() + " (Id: " + txtId.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = xaBindingSource.Position;

                    xaBindingSource.RemoveCurrent();

                    xaTableAdapter.Connection.ConnectionString = Program.connstr;
                    xaTableAdapter.Update(diaBanDataSet.Xa);

                    MessageBox.Show("Xóa phường/xã thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa phường/xã thất bại!", "Thông báo");
                    xaTableAdapter.Fill(diaBanDataSet.Xa);
                    xaBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtDiaBan.Text.Trim() == "" || txtId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel);
                return;

            }

            string txt = "Lưu thông tin phường/xã vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    xaBindingSource.EndEdit();
                    xaTableAdapter.Update(diaBanDataSet.Xa);

                    groupControl1.Enabled = true;
                    groupControl2.Enabled = false;

                    BtnXoa.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;

                    comboBox1.Visible = comboBox2.Visible = label1.Visible = false;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        xaTableAdapter.Fill(diaBanDataSet.Xa);
                    }
                    else
                    {
                        xaBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");
                }
                catch (Exception ex)
                {
                    string err = ex.Message;

                    if (ex.Message.Contains("duplicate"))
                    {
                        err = "Trong DB đã có xã này!";
                    }

                    MessageBox.Show("Lưu thông tin thất bại!\n" + err, "Thông báo");
                    return;
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && BtnThem.Enabled == false)
            {
                xaBindingSource.CancelEdit();
                xaTableAdapter.Fill(diaBanDataSet.Xa);
                xaBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                xaTableAdapter.Fill(diaBanDataSet.Xa);
                xaBindingSource.Position = vitri;
            }

            groupControl1.Enabled = true;
            groupControl2.Enabled = false;

            comboBox1.Visible = comboBox2.Visible = label1.Visible = false;

            BtnXoa.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            xaTableAdapter.Fill(diaBanDataSet.Xa);
        }
    }
}