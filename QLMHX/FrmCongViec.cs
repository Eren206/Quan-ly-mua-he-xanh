using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;



namespace QLMHX
{
    public partial class FrmCongViec : Form
    {
        private string idxa;
        
        public FrmCongViec()
        {
            InitializeComponent();
        }

        private void FrmCongViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHANCONGCONGVIEC.CongViec' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'pHANCONGCONGVIEC.CongViec' table. You can move, or remove it, as needed.
            pHANCONGCONGVIEC.EnforceConstraints = false;

            this.congViecTableAdapter.Fill(this.pHANCONGCONGVIEC.CongViec);
            this.sp_lay_tenxa_tendiabanTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_tenxa_tendiaban, Program.magv);
            this.sp_lay_xa_dia_banTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_xa_dia_ban, Program.magv, int.Parse( cmbCongViec.SelectedValue.ToString()));
            /*DateTime ngaybd = DateTime.Parse(((DataRowView)sp_lay_xa_dia_banBindingSource[sp_lay_xa_dia_banBindingSource.Position])["NGAYBD"].ToString());
            DateTime ngaykt = DateTime.Parse(((DataRowView)sp_lay_xa_dia_banBindingSource[sp_lay_xa_dia_banBindingSource.Position])["NGAYKT"].ToString());
            Console.WriteLine("ngaybd " + ngaybd.ToString());
            Console.WriteLine("ngaykt " + ngaykt.ToString());
            deNGAY.MinDate = ngaybd;
            deNGAY.MaxDate = ngaykt;*/
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
            if (cmbBuoi.Text.Trim() == "")
            {
                MessageBox.Show("Buổi không để trống, vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbBuoi.Focus();
                return;
            }
       
            idxa = ((DataRowView)sp_lay_tenxa_tendiabanBindingSource[0])["IDXA"].ToString();
            try
            {
                this.sp_lay_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text);
                this.sp_lay_chua_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_chua_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text, int.Parse(idxa));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                deNGAY.Focus();
                return;
            }
            dgvNHOMCOVIEC.ContextMenuStrip = contextMenuStrip1;
            dgvNHOMCHUACOVIEC.ContextMenuStrip = contextMenuStrip2;
   
        }
   
        private void cmbCongViec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_xa_dia_banTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_xa_dia_ban, Program.magv, int.Parse(cmbCongViec.SelectedValue.ToString()));
            if (sp_lay_xa_dia_banBindingSource.Count == 0)
            {
                MessageBox.Show("Công việc chưa phân cho ấp này, Vui lòng chọn công việc khác!", "", MessageBoxButtons.OK);
                cmbCongViec.Focus();
                btnXem.Enabled = false;
                return;
            }
            else
            {
                btnXem.Enabled = true;
            }
        }
        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(textKL.Value == bdsCOVIEC.Count)
            {
                MessageBox.Show("Công việc này đã phân công đủ nhóm trong ngày này! Vui lòng phân vào ngày khác!", "", MessageBoxButtons.OK);
                deNGAY.Focus();
                return;
            }    
            DataRowView lineChuaCoViec = (DataRowView)bdsCHUACOVIEC[bdsCHUACOVIEC.Position];
            DataRow rowChuaCoViec = lineChuaCoViec.Row;
            string idNhom = rowChuaCoViec["IdNhom"].ToString();
            string ten = rowChuaCoViec["Ten"].ToString();
            string soNha = rowChuaCoViec["SoNha"].ToString();
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string sql = "INSERT INTO PCCV(Ngay,Buoi,idCT,idNhomSV) VALUES ('" + deNGAY.Value.ToString("yyyy-MM-dd")
                     + "', N'" + cmbBuoi.Text + "'," + cmbAp.SelectedValue.ToString() + "," + idNhom + ")";
                // MessageBox.Show(sql);
                Program.ExecSqlNonQuery(sql, Program.connstr);

                
            }
            this.sp_lay_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text);
            this.sp_lay_chua_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_chua_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text, int.Parse(idxa));
        }

        private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataRowView lineCoViec = (DataRowView)bdsCOVIEC[bdsCOVIEC.Position];
            DataRow rowCoViec = lineCoViec.Row;
            string idNhom = rowCoViec["IdNhom"].ToString();
      
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhóm đã phân công này không ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string sql = "DELETE FROM PCCV WHERE Ngay ='" + deNGAY.Value.ToString("yyyy-MM-dd")
                     + "' AND Buoi = N'" + cmbBuoi.Text + "' AND idCT=" + cmbAp.SelectedValue.ToString() + "AND idNhomSV =" + idNhom;
                // MessageBox.Show(sql);
                Program.ExecSqlNonQuery(sql, Program.connstr);
           
            }
            this.sp_lay_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text);
            this.sp_lay_chua_pccv_theo_idct_ngay_buoiTableAdapter.Fill(this.pHANCONGCONGVIEC.sp_lay_chua_pccv_theo_idct_ngay_buoi, int.Parse(cmbAp.SelectedValue.ToString()), deNGAY.Value, cmbBuoi.Text, int.Parse(idxa));
        }

        private void cmbAp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*DateTime ngaybd = DateTime.Parse(((DataRowView)sp_lay_xa_dia_banBindingSource[sp_lay_xa_dia_banBindingSource.Position])["NGAYBD"].ToString());
            DateTime ngaykt = DateTime.Parse(((DataRowView)sp_lay_xa_dia_banBindingSource[sp_lay_xa_dia_banBindingSource.Position])["NGAYKT"].ToString());
            Console.WriteLine("ngaybd " + ngaybd.ToString());
            Console.WriteLine("ngaykt " + ngaykt.ToString());
            deNGAY.MinDate = ngaybd;
            deNGAY.MaxDate = ngaykt;*/
        }

        private void tenXaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
