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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLMHX
{
    public partial class FrmNhomSV : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;
        string tmp = string.Empty;

        string cmd = "EXEC MUAHEXANH.dbo.SP_NHADAN '" + Program.magv +  "'";
        DataTable dt1 = new DataTable();
        BindingSource bs = new BindingSource();

        public FrmNhomSV()
        {
            InitializeComponent();
        }

        private void nhomSVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomSVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDSnew);

        }

        private void FrmNhomSV_Load(object sender, EventArgs e)
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

            sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.quanLyDSnew.SinhVien);
            nhomSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomSVTableAdapter.Fill(this.quanLyDSnew.NhomSV);
            pCCVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pCCVTableAdapter.Fill(this.quanLyDSnew.PCCV);


            SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
            da1.Fill(dt1);

            Program.conn.Close();
            bs.DataSource = dt1;

            comboBox1.DataSource = bs;
            comboBox1.ValueMember = "IdNha";
            comboBox1.DisplayMember = "ThongTin";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            txtNha.Text = comboBox1.SelectedValue.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Không còn nhà dân nào trong khu vực để tạo nhóm!", "Thông báo");
                return;
            }

            nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);

            dangThemMoi = true;
            nhomSVGridControl.Enabled = false;
            comboBox1.Visible = true;
            groupControl2.Enabled = false;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            nhomSVBindingSource.AddNew();
            comboBox1.SelectedIndex = 0;
            txtTen.Text = comboBox1.SelectedValue.ToString();
            txtNha.Text = comboBox1.SelectedValue.ToString();

            string sql = "SELECT MAX(idNhom) FROM NhomSV";
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
            if (nhomSVBindingSource.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa", "Thông báo");
                return;
            }

            if (sinhVienBindingSource.Count != 0 || pCCVBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm SV này đã có thành viên hoặc đã được sắp xếp công việc, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa nhóm SV " + txtTen.Text + " (Id: " + txtId.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = nhomSVBindingSource.Position;

                    string IdNhaDan = (string)gridView1.GetRowCellValue(vitri, "IdNha").ToString();

                    nhomSVBindingSource.RemoveCurrent();
                    nhomSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    nhomSVTableAdapter.Update(quanLyDSnew.NhomSV);

                    if (IdNhaDan != "")
                    {
                        string sql = "UPDATE NhaDan SET TrangThai = 0 WHERE IdNha = @id";
                        SqlCommand cmd = new SqlCommand(sql, Program.conn);

                        cmd.Parameters.AddWithValue("@id", IdNhaDan);
                        try
                        {
                            Program.conn.Open();
                            cmd.ExecuteNonQuery();
                            Program.conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("FAIL! " + ex, "Thông báo");
                        }
                    }


                    MessageBox.Show("Xóa nhóm GV thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa nhóm GV thất bại!", "Thông báo");
                    nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);
                    nhomSVBindingSource.Position = vitri;
                    return;
                }

                DataTable dt2 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
                da1.Fill(dt2);

                Program.conn.Close();
                bs.DataSource = dt2;

                comboBox1.DataBindings.Clear();

                comboBox1.DataSource = bs;
                comboBox1.ValueMember = "IdNha";
                comboBox1.DisplayMember = "ThongTin";
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Không còn nhà dân nào khả dụng!", "Thông báo");
                return;
            }

            if (pCCVBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm SV này đã được sắp xếp công việc, không thể sửa thông tin cư trú!", "Thông báo");
                return;
            }

            if (sinhVienBindingSource.Count != 0)
            {
                MessageBox.Show("Nhóm SV này đã có sinh viên!", "Chú ý");
            }

            comboBox1.Visible = true;
            txtNha.Text = comboBox1.SelectedValue.ToString();

            vitri = nhomSVBindingSource.Position;

            tmp = (string)gridView1.GetRowCellValue(vitri, "IdNha").ToString();

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            if (txtTen.Text.Trim() == "")
            {
                comboBox1.Visible = true;
                comboBox1.SelectedValue = int.Parse(txtTen.Text);
            }

            nhomSVGridControl.Enabled = false;
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            string txt = "Lưu thông tin nhóm SV vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    nhomSVBindingSource.EndEdit();
                    nhomSVTableAdapter.Update(quanLyDSnew.NhomSV);

                    nhomSVGridControl.Enabled = true;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;
                    comboBox1.Visible = false;
                    groupControl2.Enabled = true;

                    vitri = nhomSVBindingSource.Position;
                    string IdNhaDan = (string)gridView1.GetRowCellValue(vitri, "IdNha").ToString();

                    string sql = "UPDATE NhaDan SET TrangThai = 1 WHERE IdNha = @id";
                    string sql1 = "UPDATE NhaDan SET TrangThai = 0 WHERE IdNha = @id";
                    
                    SqlCommand cmd1 = new SqlCommand(sql, Program.conn);
                    SqlCommand cmd2 = new SqlCommand(sql1, Program.conn);

                    cmd1.Parameters.AddWithValue("@id", IdNhaDan);
                    cmd2.Parameters.AddWithValue("@id", tmp);

                    try
                    {
                        Program.conn.Open();
                        cmd1.ExecuteNonQuery();
                        Program.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("FAIL! " + ex, "Thông báo");
                        Program.conn.Close();
                    }

                    try
                    {
                        Program.conn.Open();
                        cmd2.ExecuteNonQuery();
                        Program.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("FAIL1! " + ex, "Thông báo");
                        Program.conn.Close();
                    }

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);
                    }
                    else
                    {
                        nhomSVBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd, Program.conn);
                    da1.Fill(dt2);

                    Program.conn.Close();
                    bs.DataSource = dt2;

                    comboBox1.DataBindings.Clear();

                    comboBox1.DataSource = bs;
                    comboBox1.ValueMember = "IdNha";
                    comboBox1.DisplayMember = "ThongTin";
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
                nhomSVBindingSource.CancelEdit();
                nhomSVBindingSource.Position = vitri;
                nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);

                dangThemMoi = false;
            }
            else
            {
                nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);
                nhomSVBindingSource.Position = vitri;
            }

            nhomSVGridControl.Enabled = true;
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
            nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);
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
            Form form = isActive(typeof(SubNhomSV), Application.OpenForms);
            form?.Close();
            SubNhomSV fdc = new SubNhomSV();
            fdc.ShowDialog();

            Program.nhom = txtId.Text;
            nhomSVTableAdapter.Fill(quanLyDSnew.NhomSV);
            sinhVienTableAdapter.Fill(quanLyDSnew.SinhVien);
        }

        private void txtId_EditValueChanged(object sender, EventArgs e)
        {
            Program.nhom = txtId.Text;
        }

        private void BtnXoaTV_Click(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa", "Thông báo");
                return;
            }

            string txt = "Tiến hành xóa sinh viên " + txtHo.Text + " " + txtTenSV.Text + " (Id: " + txtMASV.Text.Trim() + ") ra khỏi " + txtTen.Text.ToLower() + "?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            int rowHandle = gridView2.GetSelectedRows()[0];

            gridView2.SetRowCellValue(rowHandle, "ChucVu", null);
            gridView2.SetRowCellValue(rowHandle, "IdNhomSV", null);

            try
            {
                sinhVienBindingSource.EndEdit();
                sinhVienTableAdapter.Update(quanLyDSnew.SinhVien);

                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa sinh viên thất bại!\n" + ex.Message, "Thông báo");
                return;
            }
        }
    }
}