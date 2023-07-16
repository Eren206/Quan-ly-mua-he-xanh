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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDS);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SinhVien" || Program.mGroup == "GiamSat" || Program.mGroup == "DoiTruong")
            {
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
            }
            quanLyDS.EnforceConstraints = false;
            khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            khoaTableAdapter.Fill(quanLyDS.Khoa);
            giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
            giangVienTableAdapter.Fill(quanLyDS.GiangVien);
            sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            sinhVienTableAdapter.Fill(quanLyDS.SinhVien);
        }

        private void khoaGridControl_Click(object sender, EventArgs e)
        {

        }

        private void tenTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 40)
            {
                textBox.Text = textBox.Text.Substring(0, 40);
                textBox.Select(40, 0);
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

        private void tenTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tenTextBox_Leave(object sender, EventArgs e)
        {
            if (labelTen.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtTen.Text.Length != 0) labelTen.Text = "";
                else labelTen.Text = "Không được để trống!";
            }

            txtTen.Text = txtTen.Text.Trim();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            dangThemMoi = true;
            groupControl1.Enabled = false;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            string sql = "SELECT MAX(idKhoa) FROM Khoa";
            SqlCommand command = new SqlCommand(sql, Program.conn);
            string tmp = string.Empty;

            try
            {
                Program.conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    tmp = result.ToString();

                    txtKhoa.Text = (int.Parse(tmp) + 1).ToString();
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo");
                Console.WriteLine(ex.Message);

                Program.conn.Close();

                return;
            }

            txtTen.Text = "";
            txtTen.Enabled = true;
            labelTen.Text = "Không được bỏ trống!";
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && BtnThem.Enabled == false)
            {
                khoaBindingSource.CancelEdit();
                khoaBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                khoaTableAdapter.Fill(quanLyDS.Khoa);
                khoaBindingSource.Position = vitri;
            }

            groupControl1.Enabled = true;

            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;

            txtTen.Enabled = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            vitri = khoaBindingSource.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            groupControl1.Enabled = false;
            txtTen.Enabled = true;
            txtTen.Focus();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            khoaTableAdapter.Fill(this.quanLyDS.Khoa);
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

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (labelTen.Text != "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            txtTen.Text = ConvertToTitleCase(txtTen.Text);

            string txt = "Lưu thông tin khoa vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (dangThemMoi == true)
                    {
                        string sql = "INSERT INTO Khoa (IdKhoa, Ten) VALUES (@IdKhoa, @Ten)";
                        SqlCommand command = new SqlCommand(sql, Program.conn);
                        command.Parameters.AddWithValue("@IdKhoa", txtKhoa.Text);
                        command.Parameters.AddWithValue("@Ten", txtTen.Text);

                        Program.conn.Open();
                        command.ExecuteNonQuery();
                        Program.conn.Close();
                    }
                    else
                    {
                        khoaBindingSource.EndEdit();
                        khoaTableAdapter.Update(quanLyDS.Khoa);
                    }
                    groupControl1.Enabled = true;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        khoaTableAdapter.Fill(quanLyDS.Khoa);
                    }
                    else
                    {
                        khoaBindingSource.ResetCurrentItem();
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

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Count != 0 || giangVienBindingSource.Count != 0)
            {
                MessageBox.Show("Khoa này đã có ít nhất 01 giảng viên/sinh viên, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa khoa " + txtTen.Text + " (" + txtKhoa.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = khoaBindingSource.Position;

                    khoaBindingSource.RemoveCurrent();

                    khoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    khoaTableAdapter.Update(quanLyDS.Khoa);

                    MessageBox.Show("Xóa khoa thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa khoa thất bại!", "Thông báo");
                    khoaTableAdapter.Fill(quanLyDS.Khoa);
                    khoaBindingSource.Position = vitri;
                    return;
                }
            }
        }
    }
}