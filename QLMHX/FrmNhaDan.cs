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
    public partial class FrmNhaDan : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;

        public FrmNhaDan()
        {
            InitializeComponent();
        }

        private void diaBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diaBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diaBanDataSet);

        }

        private void FrmNhaDan_Load(object sender, EventArgs e)
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
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
                BtnReload.Enabled = false;
            }
        }

        private void apGridControl_Click(object sender, EventArgs e)
        {

        }

        private void diaBanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.diaBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diaBanDataSet);

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

            nhaDanBindingSource.AddNew();
            txtAp.Text = shadow.Text;
            txtTrangThai.Text = "0";

            string sql = "SELECT MAX(idNha) FROM NhaDan";
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
            labelSDT.Text = "Không được bỏ trống!";
            labelSoNha.Text = "Không được bỏ trống!";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtTrangThai.Text != "0")
            {
                MessageBox.Show("Ngôi nhà này đã có nhóm SV cư trú, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa nhà địa chỉ số " + txtSoNha.Text + " của chủ hộ " + txtChuho.Text + " (Id: " + txtId.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = nhaDanBindingSource.Position;

                    nhaDanBindingSource.RemoveCurrent();

                    nhaDanTableAdapter.Connection.ConnectionString = Program.connstr;
                    nhaDanTableAdapter.Update(diaBanDataSet.NhaDan);

                    MessageBox.Show("Xóa nơi cư trú thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa nơi cư trú thất bại!", "Thông báo");
                    nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
                    nhaDanBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            vitri = nhaDanBindingSource.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            groupControl3.Enabled = true;
            txtSoNha.Focus();
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (labelSoNha.Text != "" || labelTen.Text != "" || labelSDT.Text != "" || labelAp.Text != "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            txtSoNha.Text = ConvertToTitleCase(txtSoNha.Text);
            txtChuho.Text = ConvertToTitleCase(txtChuho.Text);

            string txt = "Lưu thông tin nơi cư trú vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    nhaDanBindingSource.EndEdit();
                    nhaDanTableAdapter.Update(diaBanDataSet.NhaDan);

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
                        nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
                    }
                    else
                    {
                        nhaDanBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");

                }
                catch (Exception ex)
                {
                    string err = ex.Message;

                    if (ex.Message.Contains("UC_"))
                    {
                        err = "Trong KP/Ấp đã có địa chỉ cư trú này!";
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
                nhaDanBindingSource.CancelEdit();
                nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
                nhaDanBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
                nhaDanBindingSource.Position = vitri;
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
            nhaDanTableAdapter.Fill(diaBanDataSet.NhaDan);
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

        private void txtSoNha_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoNha.Text.Length == 0)
            {
                labelSoNha.Text = "Không được bỏ trống";
            }
            else
            {
                labelSoNha.Text = "";
            }
        }

        private void shadow_EditValueChanged_1(object sender, EventArgs e)
        {
            txtAp.Text = shadow.Text;
        }

        private void txtChuho_TextChanged_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 50)
            {
                textBox.Text = textBox.Text.Substring(0, 50);
                textBox.Select(50, 0);
            }

            if (string.IsNullOrWhiteSpace(txtChuho.Text))
            {
                labelTen.Text = "Không được để trống!";
            }
            else
            {
                labelTen.Text = "";
            }
        }

        private void txtChuho_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtChuho_Leave_1(object sender, EventArgs e)
        {
            if (labelTen.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtChuho.Text.Length != 0) labelTen.Text = "";
                else labelTen.Text = "Không được để trống!";
            }
        }

        private void txtAp_EditValueChanged(object sender, EventArgs e)
        {
            if (txtAp.Text == "")
            {
                labelAp.Text = "Không được bỏ trống!";
            }
            else
            {
                labelAp.Text = "";
            }
        }
    }
}