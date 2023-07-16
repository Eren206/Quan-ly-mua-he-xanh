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
    public partial class FrmAp : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;

        public FrmAp()
        {
            InitializeComponent();
        }

        private void diaBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diaBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diaBanDataSet);

        }

        private void FrmAp_Load(object sender, EventArgs e)
        {
            diaBanDataSet.EnforceConstraints = false;

            diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.diaBanTableAdapter.Fill(this.diaBanDataSet.DiaBan);
            xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.diaBanDataSet.Xa);
            apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.diaBanDataSet.Ap);
            nhaDanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDanTableAdapter.Fill(this.diaBanDataSet.NhaDan);

            if (Program.mGroup == "SinhVien" || Program.mGroup == "GiamSat")
            {
                BtnThem.Enabled = false;
                BtnSua.Enabled=false;
                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
            }
        }

        public string ConvertToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '/')
            {
                input = input.Substring(0, input.Length - 1);
            }

            string[] words = input.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    if (words[i][words[i].Length - 1] == ' ' || words[i][words[i].Length - 1] == '/')
                    {
                        words[i] = words[i].Remove(words[i].Length - 1);
                    }

                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }

            return string.Join(" ", words);
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

            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            groupControl3.Enabled = true;

            apBindingSource.AddNew();
            txtXa.Text = shadow.Text;

            string sql = "SELECT MAX(idAp) FROM Ap";
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
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo");
                Console.WriteLine(ex.Message);
                Program.conn.Close();

                return;
            }

            labelTen.Text = "Không được bỏ trống!";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (nhaDanBindingSource.Count != 0)
            {
                MessageBox.Show("Khu phố/Ấp này đã có điểm cư trú, không thể xóa!", "Thông báo");
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
                    vitri = apBindingSource.Position;

                    apBindingSource.RemoveCurrent();

                    apTableAdapter.Connection.ConnectionString = Program.connstr;
                    apTableAdapter.Update(diaBanDataSet.Ap);

                    MessageBox.Show("Xóa KP/Ấp thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa KP/Ấp thất bại!", "Thông báo");
                    nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
                    nhaDanBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (nhaDanBindingSource.Count != 0)
            {
                MessageBox.Show("Khu phố/Ấp này đã có điểm cư trú, không thể sửa!", "Thông báo");
                return;
            }

            vitri = apBindingSource.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            groupControl3.Enabled = true;
            txtTen.Focus();
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (labelTen.Text != "" || labelXa.Text != "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            txtTen.Text = ConvertToTitleCase(txtTen.Text);

            string txt = "Lưu thông tin KP/Ấp vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    apBindingSource.EndEdit();
                    apTableAdapter.Update(diaBanDataSet.Ap);

                    groupControl1.Enabled = false;
                    groupControl2.Enabled = true;
                    groupControl3.Enabled = false;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        apTableAdapter.Fill(diaBanDataSet.Ap);
                    }
                    else
                    {
                        apBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");

                }
                catch (Exception ex)
                {
                    string err = ex.Message;

                    if (ex.Message.Contains("UC_"))
                    {
                        err = "Trong xã đã có KP/Ấp này!";
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
                apBindingSource.CancelEdit();
                apTableAdapter.Fill(diaBanDataSet.Ap);
                apBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                apTableAdapter.Fill(diaBanDataSet.Ap);
                apBindingSource.Position = vitri;
            }

            groupControl1.Enabled = false;
            groupControl2.Enabled = true;
            groupControl3.Enabled = false;

            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            apTableAdapter.Fill(diaBanDataSet.Ap);
        }

        private void txtXa_EditValueChanged(object sender, EventArgs e)
        {
            if (txtXa.Text.Length == 0)
            {
                labelXa.Text = "Không được bỏ trống";
            }
            else
            {
                labelXa.Text = "";
            }
        }

        private void shadow_EditValueChanged(object sender, EventArgs e)
        {
            txtXa.Text = shadow.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Substring(0, 20);
                textBox.Select(20, 0);
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
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
    }
}