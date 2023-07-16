using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "ADMIN")
            {
                btnNhomGV.Enabled = false;
                btnNhomSV.Enabled = false;
            }
            if (Program.mGroup == "SinhVien")
            {
                btnLSTK.Enabled = false;
                btnLSGD.Enabled = false;
                simpleButton5.Enabled= false;
                btnNhomGV.Enabled= false;
                btnNhomSV.Enabled= false;
            }
            if (Program.mGroup == "GiamSat" || Program.mGroup == "DoiTruong")
            {
                btnLSGD.Enabled = false;
            }
            Text = Program.mHoten + " - " + Program.mGroup;
            
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            string cmd = "SELECT * FROM Khoa";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);

            Program.conn.Close();
            Program.bindingSource.DataSource = dt;

            string sql = "SELECT IdKhoa FROM GiangVien WHERE IdGV = '" + Program.magv + "'";
            SqlCommand command = new SqlCommand(sql, Program.conn);
            string tmp = string.Empty;

            try
            {
                Program.conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    tmp = result.ToString();

                    Program.khoa = tmp;
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Program.conn.Close();

                return;
            }

            Console.WriteLine(Program.khoa);
        }

        private Form isActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }

            return null;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmGiangVien));
            if (form == null)
            {
                FrmGiangVien f = new FrmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmSinhVien));
            if (form == null)
            {
                FrmSinhVien f = new FrmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void BtnKhoa_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(frmKhoa));
            if (form == null)
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhomGV_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhomGV));
            if (form == null)
            {
                FrmNhomGV f = new FrmNhomGV();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhomSV_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhomSV));
            if (form == null)
            {
                FrmNhomSV f = new FrmNhomSV();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnDiaBan_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmDiaBan));
            if (form == null)
            {
                FrmDiaBan f = new FrmDiaBan();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhaDan_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhaDan));
            if (form == null)
            {
                FrmNhaDan f = new FrmNhaDan();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnCuTru_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmAp));
            if (form == null)
            {
                FrmAp f = new FrmAp();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();

            Program.conn.Close();

            Login loginForm = new Login();

            loginForm.ShowDialog();
        }

        private void btnLSTK_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmTaoLogin));
            if (form == null)
            {
                FrmTaoLogin f = new FrmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnLSGD_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmBackupRestore));
            if (form == null)
            {
                FrmBackupRestore f = new FrmBackupRestore();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {   ThongKeViec data= new ThongKeViec();
            ReportPrintTool print = new ReportPrintTool(data);
            print.ShowPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmXa));
            if (form == null)
            {
                FrmXa f = new FrmXa();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void groupDiaDiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmCongViec));
            if (form == null)
            {
                FrmCongViec f = new FrmCongViec();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmCV));
            if (form == null)
            {
                FrmCV f = new FrmCV();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            GhiNhanKhenThuong data = new GhiNhanKhenThuong();
            ReportPrintTool print = new ReportPrintTool(data);
            print.ShowPreview();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sẽ hiển thị UserGuide vào lần khởi động chương trình sau !", "Thông báo");
            File.Delete("UserGuideShown");
        }
    }
}