using DevExpress.XtraEditors;
using QLMHX.QuanLyDSTableAdapters;
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
    public partial class FrmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;

        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDS);

        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SinhVien")
            {
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
            }
            quanLyDS.EnforceConstraints = false;

            sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.quanLyDS.SinhVien);
            khenThuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khenThuongTableAdapter.Fill(this.quanLyDS.KhenThuong);

            comboBox1.DataSource = Program.bindingSource;
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "IdKhoa";
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDS);

        }

        private void idKhoaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Substring(0, 20);
                textBox.Select(20, 0);
            }

            if (string.IsNullOrWhiteSpace(txtHo.Text))
            {
                labelHo.Text = "Không được để trống!";
            }
            else
            {
                labelHo.Text = "";
            }
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                labelHo.Text = "Chỉ nhận ký tự alphabet!";
            }

            if (e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void txtHo_Leave(object sender, EventArgs e)
        {
            if (labelHo.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtHo.Text.Length != 0) labelHo.Text = "";
                else labelHo.Text = "Không được để trống!";
            }

            txtHo.Text = txtHo.Text.Trim();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 30)
            {
                textBox.Text = textBox.Text.Substring(0, 30);
                textBox.Select(30, 0);
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                labelTen.Text = "Không được để trống!";
            }
            else
            {
                labelTen.Text = "";
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                labelTen.Text = "Chỉ nhận ký tự alphabet!";
            }

            if (e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (labelTen.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtTen.Text.Length != 0) labelTen.Text = "";
                else labelTen.Text = "Không được để trống!";
            }
        }

        public string ConvertToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            if (input[input.Length - 1] == ' ')
            {
                input = input.Substring(0, input.Length - 1);
            }

            string[] words = input.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }

            return string.Join(" ", words);
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length == 0)
            {
                labelSDT.Text = "Không được bỏ trống";
            }
            else
            {
                labelSDT.Text = "";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
            
            dangThemMoi = true;
            groupControl1.Enabled = false;

            comboBox1.Visible = true;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            sinhVienBindingSource.AddNew();
            comboBox1.SelectedIndex = 0;
            idKhoaTextEdit.Text = comboBox1.SelectedValue.ToString(); comboBox1.SelectedIndex = 0;

            groupControl3.Enabled = true;

            labelHo.Text = "Không được bỏ trống!";
            labelTen.Text = "Không được bỏ trống!";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (khenThuongBindingSource.Count != 0)
            {
                MessageBox.Show("Sinh viên này đã được khen thưởng, không thể xóa!", "Thông báo");
                return;
            }
            
            if (txtNhom.Text.Length != 0)
            {
                MessageBox.Show("Sinh viên này đã tham gia vào 01 nhóm, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa sinh viên " + txtHo.Text + " " + txtTen.Text + " (MSSV: " + txtMSSV.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = sinhVienBindingSource.Position;

                    sinhVienBindingSource.RemoveCurrent();

                    sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    sinhVienTableAdapter.Update(quanLyDS.SinhVien);

                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa giảng viên thất bại!", "Thông báo");
                    sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
                    sinhVienBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            vitri = sinhVienBindingSource.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            if (txtNhom.Text.Trim() == "")
            {
                comboBox1.Visible = true;
                comboBox1.SelectedValue = int.Parse(idKhoaTextEdit.Text);
            }

            groupControl1.Enabled = false;
            groupControl3.Enabled = true;
            txtHo.Focus();
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (labelHo.Text != "" || labelTen.Text != "" || labelSDT.Text != "" || labelMSSV.Text != "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            txtMSSV.Text = txtMSSV.Text.ToLower().Trim();
            txtHo.Text = ConvertToTitleCase(txtHo.Text);
            txtTen.Text = ConvertToTitleCase(txtTen.Text);
            txtEmail.Text = txtMSSV.Text + "@student.ptithcm.edu.vn";
            txtMSSV.Text = txtMSSV.Text.ToUpper().Trim();

            string txt = "Lưu thông tin sinh viên vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    sinhVienBindingSource.EndEdit();
                    sinhVienTableAdapter.Update(quanLyDS.SinhVien);

                    groupControl1.Enabled = true;
                    groupControl3.Enabled = false;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;
                    comboBox1.Visible = false;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
                    }
                    else
                    {
                        sinhVienBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");
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
                sinhVienBindingSource.CancelEdit();
                sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
                sinhVienBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
                sinhVienBindingSource.Position = vitri;
            }

            groupControl1.Enabled = true;
            groupControl3.Enabled = false;
            comboBox1.Visible = false;

            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            idKhoaTextEdit.Text = comboBox1.SelectedValue.ToString();
        }

        private void txtMSSV_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                labelMSSV.Text = "";
            }
            else
            {
                labelMSSV.Text = "Không được bỏ trống!";
            }
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}