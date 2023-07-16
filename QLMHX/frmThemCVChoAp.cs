using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class frmThemCVChoAp : Form
    {
        int idcv;
        public frmThemCVChoAp()
        {
            InitializeComponent();
        }

        public frmThemCVChoAp(int idCV, string tenCV)
        {
            InitializeComponent();
            txtCV.Text = tenCV;
            idcv = idCV;

        }


        private void frmThemCVChoAp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSthemCVchoAp.Ap' table. You can move, or remove it, as needed.
            this.apTableAdapter.Fill(this.dSthemCVchoAp.Ap);
            // TODO: This line of code loads data into the 'mUAHEXANHDataSet1.CTCV' table. You can move, or remove it, as needed.


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (deNgayBD.Text.Trim() == "")
            {
                MessageBox.Show("VUi lòng chọn ngày bắt đầu", "", MessageBoxButtons.OK);
                deNgayBD.Focus();
                return;
            }
            if (deNgayKT.Text.Trim() == "")
            {
                MessageBox.Show("VUi lòng chọn ngày kết thúc", "", MessageBoxButtons.OK);
                deNgayKT.Focus();
                return;
            }

            try
            {
                string cmd = "INSERT INTO CTCV VALUES(1,'" + deNgayBD.Text + "','" + deNgayKT.Text + "'," + idcv.ToString() + "," + cmbAp.SelectedValue.ToString() + ")";
                Console.WriteLine(cmd);
                int themCTCV = Program.ExecSqlNonQuery(cmd, Program.connstr);
                if (themCTCV == 0)
                {
                    MessageBox.Show("Lỗi thêm công việc cho ấp! Vui lòng thử lại", "", MessageBoxButtons.OK);

                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Lỗi thêm công việc cho ấp! Vui lòng thử lại", "", MessageBoxButtons.OK);

                return;
            }
            MessageBox.Show("Thêm công việc cho ấp thành công!", "", MessageBoxButtons.OK);
            this.Close();
        }
    }
}