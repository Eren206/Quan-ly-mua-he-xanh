using DevExpress.XtraEditors;
using QLMHX.QuanLyDSnewTableAdapters;
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
    public partial class FrmNhomGV : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;

        string cmd = "select IdXa, Ten from Xa where IdXa not in (select IdXa from NhomGV where IdXa IS NOT NULL)";
        DataTable dt1 = new DataTable();
        BindingSource bs = new BindingSource();

        public FrmNhomGV()
        {
            InitializeComponent();
        }

        private void nhomGVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomGVBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.quanLyDSnew);

        }

        private void FrmNhomGV_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SinhVien")
            {
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
                button1.Enabled = false;    
                BtnXoaTV.Enabled = false;  
            }
            quanLyDSnew.EnforceConstraints = false;
            
            nhomGVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.nhomGVTableAdapter1.Fill(this.quanLyDSnew.NhomGV);
            pCCVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pCCVTableAdapter.Fill(this.quanLyDSnew.PCCV);
            gvChildTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gvChildTableAdapter.Fill(this.quanLyDSnew.GiangVien);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
            da1.Fill(dt1);

            Program.conn.Close();
            bs.DataSource = dt1;

            comboBox1.DataSource = bs;
            comboBox1.ValueMember = "IdXa";
            comboBox1.DisplayMember = "Ten";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            txtXa.Text = comboBox1.SelectedValue.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Không còn xã nào để tạo nhóm quản lý!", "Thông báo");
                return;
            }

            nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
            
            dangThemMoi = true;
            nhomGVGridControl.Enabled = false;
            comboBox1.Visible = true;
            groupControl2.Enabled = false;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            nhomGVBindingSource1.AddNew();
            comboBox1.SelectedIndex = 0;
            txtXa.Text = comboBox1.SelectedValue.ToString();

            string sql = "SELECT MAX(idNhom) FROM NhomGV";
            SqlCommand command = new SqlCommand(sql, Program.conn);
            string tmp = string.Empty;

            try
            {
                Program.conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    tmp = result.ToString();

                    txtId.Text = (int.Parse(tmp) + 1).ToString();
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Program.conn.Close();

                txtId.Text = "1";
                txtTen.Text = "Nhóm " + txtId.Text;

                return;
            }

            txtTen.Text = "Nhóm " + txtId.Text;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (nhomGVBindingSource1.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa", "Thông báo");
                return;
            }
            
            if (gvChildBindingSource.Count != 0 || pCCVBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm GV này đã có thành viên hoặc đã tiến hành sắp xếp công việc, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa nhóm GV " + txtTen.Text + " (Id: " + txtId.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = nhomGVBindingSource1.Position;

                    nhomGVBindingSource1.RemoveCurrent();

                    nhomGVTableAdapter1.Connection.ConnectionString = Program.connstr;
                    nhomGVTableAdapter1.Update(quanLyDSnew.NhomGV);

                    MessageBox.Show("Xóa nhóm GV thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa nhóm GV thất bại!", "Thông báo");
                    nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
                    nhomGVBindingSource1.Position = vitri;
                    return;
                }

                DataTable dt2 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
                da1.Fill(dt2);

                Program.conn.Close();
                bs.DataSource = dt2;

                comboBox1.DataSource = bs;
                comboBox1.ValueMember = "IdXa";
                comboBox1.DisplayMember = "Ten";
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Không còn xã nào khả dụng!", "Thông báo");
                return;
            }

            if (pCCVBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm GV này đã tiến hành sắp xếp công việc, không thể sửa thông tin xã!", "Thông báo");
                return;
            }

            if (gvChildBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm GV này đã có giảng viên!", "Chú ý");
            }

            comboBox1.Visible = true;
            txtXa.Text = comboBox1.SelectedValue.ToString();

            vitri = nhomGVBindingSource1.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            if (txtXa.Text.Trim() == "")
            {
                comboBox1.Visible = true;
                comboBox1.SelectedValue = int.Parse(txtXa.Text);
            }

            nhomGVGridControl.Enabled = false;
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            string txt = "Lưu thông tin nhóm GV vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    nhomGVBindingSource1.EndEdit();
                    nhomGVTableAdapter1.Update(quanLyDSnew.NhomGV);

                    nhomGVGridControl.Enabled = true;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;
                    comboBox1.Visible = false;
                    groupControl2.Enabled = true;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
                    }
                    else
                    {
                        nhomGVBindingSource1.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
                    da1.Fill(dt2);

                    Program.conn.Close();
                    bs.DataSource = dt2;

                    comboBox1.DataSource = bs;
                    comboBox1.ValueMember = "IdXa";
                    comboBox1.DisplayMember = "Ten";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thông tin thất bại!\n" + ex.Message, "Thông báo");
                    return;
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && BtnThem.Enabled == false)
            {
                nhomGVBindingSource1.CancelEdit();
                nhomGVBindingSource1.Position = vitri;
                nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);

                dangThemMoi = false;
            }
            else
            {
                nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
                nhomGVBindingSource1.Position = vitri;
            }

            nhomGVGridControl.Enabled = true;
            comboBox1.Visible = false;
            groupControl2.Enabled = true;

            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
        }

        private Form isActive(Type ftype, FormCollection forms)
        {
            foreach (Form f in forms)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(SubNhomGV), Application.OpenForms);
            form?.Close();
            SubNhomGV fdc = new SubNhomGV();
            fdc.ShowDialog();

            Program.nhom = txtId.Text;
            nhomGVTableAdapter1.Fill(quanLyDSnew.NhomGV);
            gvChildTableAdapter.Fill(quanLyDSnew.GiangVien);

        }

        private void txtId_EditValueChanged(object sender, EventArgs e)
        {
            Program.nhom = txtId.Text;
        }

        private void BtnXoaTV_Click(object sender, EventArgs e)
        {
            if (gvChildBindingSource.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa", "Thông báo");
                return;
            }
            
            string txt = "Tiến hành xóa giảng viên " + txtHo.Text + " " + txtTenGV.Text + " (Id: " + txtMAGV.Text.Trim() + ") ra khỏi " + txtTen.Text.ToLower() + "?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            int rowHandle = gridView2.GetSelectedRows()[0];
            Console.WriteLine(gridView2.GetRowCellValue(rowHandle, "IdGV"));

            gridView2.SetRowCellValue(rowHandle, "ChucVu", null);
            gridView2.SetRowCellValue(rowHandle, "IdNhomGV", null);

            try
            {
                gvChildBindingSource.EndEdit();
                gvChildTableAdapter.Update(quanLyDSnew.GiangVien);

                MessageBox.Show("Xóa giảng viên thành công!", "Thông báo");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa giảng viên thất bại!\n" + ex.Message, "Thông báo");
                return;
            }
        }
    }
}