using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class FrmDiaBan : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection = new SqlConnection();
        private BindingSource BdsTinhTP = new BindingSource();
        private BindingSource BdsDiaBan = new BindingSource();

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

        private void GetTinhTP(String cmd)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connection);
            da.Fill(dt);


            connection.Close();
            BdsTinhTP.DataSource = dt;

            comboBox1.DataBindings.Clear();

            comboBox1.DataSource = BdsTinhTP;
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "Id";
        }

        private void GetDiaBan(String cmd)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connection);
            da.Fill(dt);


            connection.Close();
            BdsDiaBan.DataSource = dt;

            comboBox2.DataBindings.Clear();

            comboBox2.DataSource = BdsDiaBan;
            comboBox2.DisplayMember = "Ten";
            comboBox2.ValueMember = "Id";
        }

        public FrmDiaBan()
        {
            InitializeComponent();
        }

        private void diaBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diaBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diaBanDataSet);
        }

        private void FrmDiaBan_Load(object sender, EventArgs e)
        {
            diaBanDataSet.EnforceConstraints = false;

            diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.diaBanTableAdapter.Fill(this.diaBanDataSet.DiaBan);
            xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.diaBanDataSet.Xa);

            if (ConnectToDMHCQG() == 0) return;
            GetTinhTP("Select * from TinhTP");

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
            GetDiaBan("Select Id, Ten from QuanHuyen WHERE IdTinhTP = " + comboBox1.SelectedValue.ToString());

            txtTen.Text = comboBox2.Text;
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


            diaBanBindingSource.AddNew();
            txtTen.Text = comboBox2.Text;

            if (comboBox2.Items.Count != 0)
            {
                txtId.Text = comboBox2.SelectedValue.ToString();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (diaBanBindingSource.Count == 0)
            {
                MessageBox.Show("Không còn địa bàn nào để xóa!", "Thông báo");
                return;
            }

            if (xaBindingSource.Count != 0)
            {
                MessageBox.Show("Địa bàn này đã có xã được chọn trong chiến dịch, không thể xóa!", "Thông báo");
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
                    vitri = diaBanBindingSource.Position;

                    diaBanBindingSource.RemoveCurrent();

                    diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
                    diaBanTableAdapter.Update(diaBanDataSet.DiaBan);

                    MessageBox.Show("Xóa địa bàn thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa địa bàn thất bại!", "Thông báo");
                    diaBanTableAdapter.Fill(diaBanDataSet.DiaBan);
                    diaBanBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            string txt = "Lưu thông tin địa bàn vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    diaBanBindingSource.EndEdit();
                    diaBanTableAdapter.Update(diaBanDataSet.DiaBan);

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
                        diaBanTableAdapter.Fill(diaBanDataSet.DiaBan);
                    }
                    else
                    {
                        diaBanBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");
                }
                catch (Exception ex)
                {
                    string err = ex.Message;

                    if (ex.Message.Contains("duplicate"))
                    {
                        err = "Trong DB đã có địa bàn này!";
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
                diaBanBindingSource.CancelEdit();
                diaBanTableAdapter.Fill(diaBanDataSet.DiaBan);
                diaBanBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                diaBanTableAdapter.Fill(diaBanDataSet.DiaBan);
                diaBanBindingSource.Position = vitri;
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
            diaBanTableAdapter.Fill(diaBanDataSet.DiaBan);
        }
    }
}