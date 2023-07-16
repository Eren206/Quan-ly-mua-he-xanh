using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class UserGuide : DevExpress.XtraEditors.XtraForm
    {
        private int flag = 0;
        public UserGuide()
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
        private void UserGuide_Load(object sender, EventArgs e)
        {
            textEdit1.Focus();
            setSubmitButtonVisible();
        }
        private void setSubmitButtonVisible()
        {
            if(string.IsNullOrWhiteSpace(textEdit1.Text) == false && flag!=0 )
            {
                simpleButton1.Enabled = true;
            }
            else { simpleButton1.Enabled = false; }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            setSubmitButtonVisible();
        }

        private void textEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            setSubmitButtonVisible();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Hide();
            Form form = isActive(typeof(Login), Application.OpenForms);
            form?.Close();
            Login lFrm = new Login();
            lFrm.ShowDialog();
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Program.servernameTest=textEdit1.Text;
            if (Program.KetNoiTest() == 1) {
                MessageBox.Show("Tồn tại CSDL tương ứng trên SQl server" + Program.servernameTest, "Thông báo");
                flag = 1; 
                Program.servername=Program.servernameTest;
                File.WriteAllText(Application.UserAppDataPath+"\\"+"MHXServerName.txt",Program.servername);
            }
            setSubmitButtonVisible();
        }
    }
}