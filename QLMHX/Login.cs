using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private Form isActive(Type ftype, FormCollection forms)
        {
            foreach (Form f in forms)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (labelUsername.Text.Length != 0 || labelPassword.Text.Length != 0)
            {
                MessageBox.Show("Vui lòng nhập đủ username và password!", "Thông báo");
                return;
            }

            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;

            Program.usernameDN = txtUsername.Text;
            Program.passwordDN = txtPassword.Text;

            if (Program.KetNoi() == 1)
            {
                string sql = "EXEC MUAHEXANH.dbo.SP_DANGNHAP_GV '" + Program.mlogin + "'";
                SqlCommand command = new SqlCommand(sql, Program.conn);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            Program.mGroup = reader.GetString(2);
                            Program.mHoten = reader.GetString(1);
                            Program.magv = reader.GetString(0);
                        }
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {

                    Program.conn.Close();
                }

            }
            else return;

            Console.WriteLine(Program.magv);

            Hide();

            if (Program.mGroup == "SinhVien")
            {
                Form form = isActive(typeof(SinhVien), Application.OpenForms);
                form?.Close();
                //test
                MainForm mf = new MainForm();
                mf.ShowDialog();
                //

                //SinhVien kh = new SinhVien();
                //kh.ShowDialog();
            }
            else
            {
                Form form = isActive(typeof(MainForm), Application.OpenForms);
                form?.Close();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }

            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 50)
            {
                textBox.Text = textBox.Text.Substring(0, 50);
                textBox.Select(50, 0);
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                labelUsername.Text = "Chưa nhập username!";
            }
            else
            {
                labelUsername.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 10)
            {
                textBox.Text = textBox.Text.Substring(0, 10);
                textBox.Select(10, 0);
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                labelPassword.Text = "Chưa nhập password!";
            }
            else
            {
                labelPassword.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                labelUsername.Text = "Chỉ nhận ký tự alphabet hoặc ký tự số!";
            }

            if (e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                labelPassword.Text = "Chỉ nhận ký tự số!";
            }

            if (e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (labelUsername.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtUsername.Text.Length != 0) labelUsername.Text = "";
                else labelUsername.Text = "Chưa nhập username!";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
            if (labelPassword.Text == "Chỉ nhận ký tự số!")
            {
                if (txtPassword.Text.Length != 0) labelPassword.Text = "";
                else labelPassword.Text = "Chưa nhập password!";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
