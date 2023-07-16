using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class FrmCV : Form
    {
        private bool dangThem;
        private bool ghiThanhCong = false;
        public FrmCV()
        {
            InitializeComponent();
        }
        private void FrmCV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mUAHEXANHDataSet1.CTCV' table. You can move, or remove it, as needed.
            
            mUAHEXANHDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'mUAHEXANHDataSet1.CongViec' table. You can move, or remove it, as needed.
            this.congViecTableAdapter.Fill(this.mUAHEXANHDataSet1.CongViec);
            this.cTCVTableAdapter.Fill(this.mUAHEXANHDataSet1.CTCV);
            int macv = int.Parse(((DataRowView)congViecBindingSource[congViecBindingSource.Position])["IDCV"].ToString());
           // this.sp_lay_ctcv_theomacvTableAdapter.Fill(this.mUAHEXANHDataSet1.sp_lay_ctcv_theomacv, macv);
            dgvCV.ContextMenuStrip = contextMenuStrip1;
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
            pnlTHEMCV.Enabled = false;
            this.khoiLuongSpinEdit.Properties.MinValue = 1;
            this.khoiLuongSpinEdit.Properties.MaxValue = decimal.MaxValue;
            this.thoiGianSpinEdit.Properties.MinValue = 1;
            this.thoiGianSpinEdit.Properties.MaxValue = decimal.MaxValue;

            if(Program.mGroup== "GiamSat")
            {
                BtnXoa.Enabled = false;
                BtnSua.Enabled = false;
                BtnThem.Enabled = false;
                BtnReload.Enabled = false;
                BtnUndo.Enabled = false;
                BtnGhi.Enabled = false;
            }    
        }
                              
        private void BtnSua_Click(object sender, EventArgs e)
        {
            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;
            dangThem = false;
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
                                 
            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;
            pnlTHEMCV.Enabled = true;
            congViecBindingSource.AddNew();
            
            idCVSpinEdit.Value = 0;
            dangThem = true;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            BtnXoa.Enabled = true;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = false;
            //    pnlTHEMCV.Enabled = true;

            if (cTCVBindingSource.Count>0)
            {
                MessageBox.Show("Công việc này đã được phân công nên không thể xóa!", "Thông báo");
                return;
            }    
            else
            {

                string txt = "Tiến hành xóa công việc " + tenTextEdit.Text + "ra khỏi DB?";
                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    congViecBindingSource.RemoveCurrent();
                    congViecBindingSource.EndEdit();
                    this.congViecTableAdapter.Update(mUAHEXANHDataSet1.CongViec);
                    MessageBox.Show("Xóa công việc thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa công việc thất bại!", "Thông báo");

                    congViecTableAdapter.Fill(mUAHEXANHDataSet1.CongViec);
                    
                    return;
                }
            }
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (tenTextEdit.Text == "" || thoiGianSpinEdit.Text == "" || khoiLuongSpinEdit.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }
   
            try
            {
                congViecBindingSource.EndEdit();
                //cap nhat lai du lieu sau khi nhap them cong viec
                this.congViecTableAdapter.Update(mUAHEXANHDataSet1.CongViec);
            }
            catch(Exception ex)
            {
                ghiThanhCong = false;
                MessageBox.Show("Lưu thông tin thất bại!\n" + ex.Message, "Thông báo");
                return;
            }
            ghiThanhCong = true;
            MessageBox.Show("Ghi thông tin thành công!\n","", MessageBoxButtons.OK);
            this.congViecTableAdapter.Fill(mUAHEXANHDataSet1.CongViec);
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
            pnlTHEMCV.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
           
            congViecTableAdapter.Fill(mUAHEXANHDataSet1.CongViec);
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if(dangThem==true && BtnThem.Enabled == false)
            {
                congViecBindingSource.CancelEdit();
                congViecTableAdapter.Fill(mUAHEXANHDataSet1.CongViec);
          //      congViecBindingSource.Position = vitri;

                dangThem = false;
            }
            else
            {
                congViecTableAdapter.Fill(mUAHEXANHDataSet1.CongViec);
             //   congViecBindingSource.Position = vitri;
            }
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void btnThemChoAp_Click(object sender, EventArgs e)
        {
            int macv = int.Parse(((DataRowView)congViecBindingSource[congViecBindingSource.Position])["IDCV"].ToString());
            string ten = ((DataRowView)congViecBindingSource[congViecBindingSource.Position])["Ten"].ToString();
            frmThemCVChoAp f = new frmThemCVChoAp(macv, ten);
            f.ShowDialog();
        }

        

        private void dgvCV_SelectionChanged(object sender, EventArgs e)
        {
            if (!ghiThanhCong)
            {
                int macv = int.Parse(((DataRowView)congViecBindingSource[congViecBindingSource.Position])["IDCV"].ToString());
                //this.sp_lay_ctcv_theomacvTableAdapter.Fill(this.mUAHEXANHDataSet1.sp_lay_ctcv_theomacv, macv);
            }
            
        }

        private void idCVSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
