using DevExpress.Utils.CommonDialogs;
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
using System.Xml.Linq;

namespace QLMHX
{
    public partial class FrmBackupRestore : DevExpress.XtraEditors.XtraForm
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
            fullBackupCheck.Checked=true;
            label4.Enabled = false;
            textBox1.Enabled = false;
            BtnDifRestore.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string selectedFileName = "";
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Backup File(*.bak)|*.bak|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;
            }
            pathText.Text = selectedFileName;
        }

        // button restore
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            String restoreFileName = "";
            int sqlSp;
            if (string.IsNullOrWhiteSpace(pathText.Text))
            {
                MessageBox.Show("Vui lòng chọn file Fullbackup !", "Thông báo"); return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) && checkBox1.Checked)
            {
                MessageBox.Show("Vui lòng chọn file Fullbackup !", "Thông báo"); return;
            }
            if (checkBox1.Checked)
            {
                //gọi sp differential restore
                restoreFileName = pathText.Text;
                sqlSp = Program.ExecSqlNonQuery("EXEC sp_differentialrestore '" + restoreFileName + "','" + textBox1.Text + "'", Program.connstr);
            }
            else
            {
                //gọi sp full restore
                restoreFileName = pathText.Text;
                sqlSp = Program.ExecSqlNonQuery("EXEC sp_fullrestore '" + restoreFileName + "'", Program.connstr);

            }
            // Thông báo trạng thái restore
            if (sqlSp == 1)
            {
                string script = "Restore sussesful!";
                MessageBox.Show(script + sqlSp, "Notification!");
                return;
            }
            else
            {
                string script = "Restore did not success! ";
                MessageBox.Show(script + "Error code:" + sqlSp, "Warning");
                return;
              
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        //button backup
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //biến kiểm tra xem sp có chạy thành công hay k
            int sqlSp = 0;
            //đường dẫn của folder lưu file(final)
            String folderStr = selectedFolderName.Text;
            //tên của file backup(final)
            String backupName = backupFileName.Text;
            //biến flag loại backup (true tương ứng FULLBACKUP)
            bool backupType = fullBackupCheck.Checked;
            if (string.IsNullOrWhiteSpace(folderStr))
            {
                string script = "Folder Field Is Required";
                MessageBox.Show(script,"Warning");
                return;
            }
            if (backupType == true)
            {
                
                sqlSp = Program.ExecSqlNonQuery("EXEC MUAHEXANH.dbo.sp_fullbackup '" + folderStr + "','" +backupName + "'", Program.connstr);
            }
            else if(backupType == false)
            {
              
                sqlSp = Program.ExecSqlNonQuery("EXEC MUAHEXANH.dbo.sp_differentialbackup '" + folderStr + "','" + backupName + "'", Program.connstr);
            }
            if (sqlSp == 1)
            {
                string script = "Backup sussesful!";
                MessageBox.Show(script + sqlSp, "Notification!");
                return;
            }
            else
            {
                string script = "Backup did not success! ";
                MessageBox.Show(script + "Error code:" + sqlSp, "Warning");
                return;
               
            }
        }

        //button Chọn folder
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Chọn thư mục lưu file backup";
            folderBrowser.RootFolder=Environment.SpecialFolder.MyComputer;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {   
                // tên folder được chọn
                selectedFolderName.Text = folderBrowser.SelectedPath;
            }
        }

        private void selectedFolderName_TextChanged(object sender, EventArgs e)
        {

        }

        //Button tự động tạo tên 
        private void autoGenerateButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            today = DateTime.Now;
            String backupName="";  
            if (fullBackupCheck.Checked)
            {
                backupName = "DB_MUAHEXANH_" + today.ToString("yyyyMMdd_hhmmss") + "_FULLBAK";
            }
            else if(diffBackupCheck.Checked)
                backupName = "DB_MUAHEXANH_" + today.ToString("yyyyMMdd_hhmmss") + "_DIFFBAK";
            backupFileName.Text = backupName;
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string selectedFileName = "";
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Backup File(*.bak;*.dif)|*.bak;*.dif|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;
            }
            textBox1.Text = selectedFileName;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Enabled = true;
                textBox1.Enabled=true;
                BtnDifRestore.Enabled=true;
                    
            }
            else
            {
                label4.Enabled = false;
                textBox1.Enabled = false;
                BtnDifRestore.Enabled = false;

            }
            
        }

        private void pathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBackupRestore_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> BindNgay = new Dictionary<int, string>();
            BindNgay.Add(1, "Chủ Nhật");
            BindNgay.Add(2, "Thứ Hai");
            BindNgay.Add(4, "Thứ Ba");
            BindNgay.Add(8, "Thứ Tư");
            BindNgay.Add(16, "Thứ Năm");
            BindNgay.Add(32, "Thứ Sáu");
            BindNgay.Add(64, "Thứ Bảy");
            cmbNgay.DataSource = new BindingSource(BindNgay, null);
            cmbNgay.DisplayMember = "Value";
            cmbNgay.ValueMember = "Key";
            radioButton1.Checked = true;
            cmbNgay.Enabled = false;
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Chọn thư mục lưu file backup";
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // tên folder được chọn
                textBox2.Text = folderBrowser.SelectedPath;
            }
        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {
            String backupName = "";
            backupName = timeEdit1.Text;
            backupName = "DB_MUAHEXANH_yyyyMMdd" + timeEdit1.Time.ToString("HHmm")+ "_AUTO.bak";
            textEdit1.Text = backupName;
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            string folderStr = textBox2.Text;
            string time = timeEdit1.Time.ToString("HHmm");
            int day;
            if (string.IsNullOrWhiteSpace(folderStr))
            {
                string script = "Folder Field Is Required";
                MessageBox.Show(script, "Warning");
                return;
            }
            int sqlSp;
            if (radioButton1.Checked == true)
            {
                sqlSp = Program.ExecSqlNonQuery("EXEC master.dbo.sp_DAILYBACKUP '" + folderStr + "','" + time + "'", Program.connstr);
                if (sqlSp == 1)
                {
                    string script = "Hẹn giờ Backup thành công!";
                    MessageBox.Show(script + sqlSp, "Notification!");
                    return;
                }
                else
                {
                    string script = "Hẹn giờ Backup thất bại! ";
                    MessageBox.Show(script + "Error code:" + sqlSp, "Warning");
                    return;

                }
            }
            else {
                day= Int32.Parse(cmbNgay.SelectedValue.ToString());
                sqlSp = Program.ExecSqlNonQuery("EXEC master.dbo.sp_WEEKLYBACKUP '" + folderStr + "','" + time + "'" +","+day, Program.connstr);
                if (sqlSp == 1)
                {
                    string script = "Hẹn giờ Backup thành công!";
                    MessageBox.Show(script + sqlSp, "Notification!");
                    return;
                }
                else
                {
                    string script = "Hẹn giờ Backup thất bại! ";
                    MessageBox.Show(script + "Error code:" + sqlSp, "Warning");
                    return;

                }
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch1.IsOn)
            {
                panelControl3.SendToBack();
                panelControl2.BringToFront();
            }
            else
            {
                panelControl2.SendToBack();
                panelControl3.BringToFront();
            }
        }

        private void cmbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbNgay.Enabled = false;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fullBackupCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbNgay.Enabled = true;
        }
    }
}