using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLMHX
{
    public partial class FrmTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connection = new SqlConnection();
        private BindingSource BdsTKGV = new BindingSource();
        private BindingSource BdsTKSV = new BindingSource();
        public FrmTaoLogin()
        {
            InitializeComponent();
        }

        private void FrmTaoLogin_Load(object sender, EventArgs e)
        {
           
            if (Program.conn.State != ConnectionState.Open)
            {
                Program.conn.Open();
            }
            Dictionary<string, string> BindChucVu = new Dictionary<string, string>();
            if (Program.mGroup == "ADMIN")
            {
                BindChucVu.Add("GiamSat", "Giảng Viên(giám sát)");
                BindChucVu.Add("DoiTruong", "Đội Trưởng/ Đội Phó");
                BindChucVu.Add("SinhVien", "Sinh Viên");
            }
            else if (Program.mGroup == "GiamSat")
            {
                BindChucVu.Add("SinhVien", "Sinh Viên");
            }
            comboBox1.DataSource = new BindingSource(BindChucVu, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboBox1.SelectedIndex = 0;
            label8.Text = "";
            if(label8.Text=="System.Data.DataRowView")
            {
                label8.Text = "";
            }
            // Load lúc đầu
            if (comboBox1.SelectedValue == "DoiTruong" || comboBox1.SelectedValue == "GiamSat")
            {

                string strCmd1 = "select * from v_dsTaoLoginGV order by HoTen";
                SqlCommand cmd1 = new SqlCommand(strCmd1, Program.conn);
                SqlDataAdapter da1 = new SqlDataAdapter(strCmd1, Program.conn);
                DataTable ds1 = new DataTable();
                da1.Fill(ds1);
                cmd1.ExecuteNonQuery();

                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox2.DataSource = ds1;
                comboBox2.DisplayMember = "HoTen";
                comboBox2.ValueMember = "IdGV";
                comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedValue == "SinhVien")
            {
                string strCmd2 = "select * from v_dsTaoLoginSV order by HoTen";
                SqlCommand cmd2 = new SqlCommand(strCmd2, Program.conn);
                SqlDataAdapter da2 = new SqlDataAdapter(strCmd2, Program.conn);
                DataTable ds2 = new DataTable();
                da2.Fill(ds2);
                cmd2.ExecuteNonQuery();
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox2.DataSource = ds2;
                comboBox2.DisplayMember = "HoTen";
                comboBox2.ValueMember = "MSSV";
                comboBox2.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label8.Text == "System.Data.DataRowView")
            {
                label8.Text = "";
            }
            if (comboBox1.SelectedValue == "DoiTruong" || comboBox1.SelectedValue=="GiamSat")
            {
                
                string strCmd1 = "select * from v_dsTaoLoginGV order by HoTen";
                SqlCommand cmd1 = new SqlCommand(strCmd1, Program.conn);
                SqlDataAdapter da1 = new SqlDataAdapter(strCmd1, Program.conn);
                DataTable ds1 = new DataTable();
                da1.Fill(ds1);
                cmd1.ExecuteNonQuery();
               
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox2.DataSource = ds1;
                comboBox2.DisplayMember = "HoTen";
                comboBox2.ValueMember = "IdGV";
                comboBox2.Enabled = true;
            }
            else if( comboBox1.SelectedValue == "SinhVien") 
            {
                string strCmd2 = "select * from v_dsTaoLoginSV order by HoTen";
                SqlCommand cmd2 = new SqlCommand(strCmd2, Program.conn);
                SqlDataAdapter da2 = new SqlDataAdapter(strCmd2, Program.conn);
                DataTable ds2 = new DataTable();
                da2.Fill(ds2);
                cmd2.ExecuteNonQuery();
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox2.DataSource = ds2;
                comboBox2.DisplayMember = "HoTen";
                comboBox2.ValueMember = "MSSV";
                comboBox2.Enabled = true;   
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String role = "";
            String password = "";
            String userName = "";
            String loginName = "";
            // Get role
            role = comboBox1.SelectedValue.ToString();
            // Get password
            password = textEdit2.Text;
            // Get loginName 
            loginName=textEdit1.Text;
            // Get userName
            userName=comboBox2.SelectedValue.ToString().Trim();
            // Call sp to create Login
         
            try
            {
                int sqlsp=Program.ExecSqlNonQuery("EXEC SP_TAOLOGIN '" + loginName + "','" + password + "','" + userName + "','" + role + "'", Program.connstr);
                if (sqlsp == 1) {
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo tài khoản thất bại" + ex.ToString(),"Thông báo");
            }
            
            }


        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit2.Text == textEdit3.Text)
            {
                validateLabel.Text = "";
            }
            if (textEdit2.Text != textEdit3.Text)
            {
                validateLabel.Text = "Password không trùng!";
            }
        }
        //can chinh sua
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit2.Text == textEdit3.Text)
            {
                validateLabel.Text = "";
            }
            if (textEdit2.Text != textEdit3.Text)
            {
                validateLabel.Text = "Password không trùng!";
            }
            setBtnSubmitLoginVisibility();
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {
            setBtnSubmitLoginVisibility();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            setBtnSubmitLoginVisibility();

        }
        private void setBtnSubmitLoginVisibility()
        {
            if(string.IsNullOrWhiteSpace(textEdit1.Text) == false && 
                string.IsNullOrWhiteSpace(textEdit2.Text) == false &&
                string.IsNullOrWhiteSpace(textEdit3.Text) == false &&
                textEdit2.Text == textEdit3.Text
                )
            {
                btnSubmitLogin.Enabled = true;
            }
            else
            {
                btnSubmitLogin.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox2.SelectedValue.ToString();
            if (label8.Text == "System.Data.DataRowView")
            {
                label8.Text = "";
            }
        }

        private void validateLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}