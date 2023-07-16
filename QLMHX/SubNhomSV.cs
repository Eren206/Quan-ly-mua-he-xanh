using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class SubNhomSV : DevExpress.XtraEditors.XtraForm
    {
        bool HoanTatClick = false;
        List<ListItem> items = new List<ListItem>();

        public class ListItem
        {
            public string DisplayText { get; set; }
            public string Value { get; set; }
        }

        public SubNhomSV()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDSnew);

        }

        private void SubNhomSV_Load(object sender, EventArgs e)
        {
            quanLyDSnew.EnforceConstraints = false;

            sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.quanLyDSnew.SinhVien);
        }

        private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDSnew);

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string txt = "Lưu thông tin thành viên vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int rowHandle;
                    string targetId = CmbDT.SelectedValue.ToString();

                    Console.WriteLine(targetId);

                    if (targetId != "0")
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object IdNhomSV = gridView1.GetRowCellValue(i, "IdNhomSV");
                            if (IdNhomSV != null && IdNhomSV.ToString().Trim() == Program.nhom)
                            {
                                rowHandle = gridView1.GetRowHandle(i);
                                if ((string)gridView1.GetRowCellValue(rowHandle, "ChucVu").ToString() == "Đội Trưởng")
                                {
                                    gridView1.SetRowCellValue(rowHandle, "ChucVu", null);
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object MSSVValue = gridView1.GetRowCellValue(i, "MSSV");
                            if (MSSVValue != null && MSSVValue.ToString().Equals(targetId))
                            {
                                Console.WriteLine("-" + MSSVValue.ToString());
                                
                                rowHandle = gridView1.GetRowHandle(i);
                                gridView1.SetRowCellValue(rowHandle, "ChucVu", "Đội Trưởng");
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object IdNhomSV = gridView1.GetRowCellValue(i, "IdNhomSV");
                            if (IdNhomSV != null && IdNhomSV.ToString().Trim() == Program.nhom)
                            {
                                rowHandle = gridView1.GetRowHandle(i);
                                if ((string)gridView1.GetRowCellValue(rowHandle, "ChucVu").ToString() == "Đội Trưởng")
                                {
                                    gridView1.SetRowCellValue(rowHandle, "ChucVu", null);
                                    break;
                                }
                            }
                        }
                    }

                    sinhVienBindingSource.EndEdit();
                    sinhVienTableAdapter.Update(quanLyDSnew.SinhVien);


                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thông tin thất bại!\n" + ex.Message, "Thông báo");
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHTCL_Click(object sender, EventArgs e)
        {
            if (!HoanTatClick)
            {
                GridView gridView = gridView1;

                int[] selectedRows = gridView.GetSelectedRows();
                string selectedChucVu = string.Empty;
                String hoten = string.Empty;
                String id = string.Empty;
                string nhom = string.Empty;

                if (selectedRows.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo");
                    return;
                }

                if (selectedRows.Length > 4)
                {
                    MessageBox.Show("Mỗi nhóm SV chỉ có tối đa 6 người!\nVui lòng chọn lại!", "Thông báo");
                    return;
                }

                items.Clear();
                items.Add(new ListItem { DisplayText = "<none>", Value = "0" });

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    nhom = (string)gridView.GetRowCellValue(i, "IdNhomSV").ToString();

                    if (nhom == Program.nhom)
                    {
                        gridView.SetRowCellValue(i, "IdNhomSV", "");
                        continue;
                    }

                    if (nhom != "")
                        continue;
                }

                foreach (int row in selectedRows)
                {
                    gridView.SetRowCellValue(row, "IdNhomSV", Program.nhom);
                    id = gridView.GetRowCellValue(row, "MSSV").ToString();
                    hoten = gridView.GetRowCellValue(row, "Ho").ToString() + " " + gridView.GetRowCellValue(row, "Ten").ToString();

                    Console.WriteLine(row + " " + (string)gridView.GetRowCellValue(row, "ChucVu").ToString());

                    if ((string)gridView.GetRowCellValue(row, "ChucVu").ToString() == "Đội Trưởng")
                    {
                        selectedChucVu = id;
                    }
                    items.Add(new ListItem { DisplayText = hoten, Value = id });
                }

                List<ListItem> itemsCopy1 = new List<ListItem>(items);

                CmbDT.DataBindings.Clear();

                CmbDT.DataSource = itemsCopy1;
                CmbDT.DisplayMember = "DisplayText";
                CmbDT.ValueMember = "Value";

                CmbDT.SelectedValue = selectedChucVu;

                int rowHandle;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    object IdNhomSV = gridView1.GetRowCellValue(i, "IdNhomSV");
                    if (IdNhomSV != null && IdNhomSV.ToString().Trim() == "")
                    {
                        rowHandle = gridView1.GetRowHandle(i);
                        if ((string)gridView1.GetRowCellValue(rowHandle, "ChucVu").ToString() != "")
                        {
                            gridView1.SetRowCellValue(rowHandle, "ChucVu", null);
                        }
                    }
                }

                HoanTatClick = true;
                btnHTCL.BackColor = Color.FromArgb(255, 192, 192);
                btnHTCL.Text = "Hoàn Tác";

                sinhVienGridControl.Enabled = false;
                groupControl1.Enabled = true;
            }
            else
            {
                HoanTatClick = false;
                btnHTCL.BackColor = Color.FromArgb(192, 255, 192);
                btnHTCL.Text = "Hoàn Tất";

                sinhVienGridControl.Enabled = true;
                groupControl1.Enabled = false;
            }
        }

        private void CmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var view = sender as GridView;
            var hitInfo = view.CalcHitInfo(e.Location);

            if (hitInfo.Column?.FieldName != "DX$CheckboxSelectorColumn")
                return;

            if (hitInfo.InColumn)
                (e as DXMouseEventArgs).Handled = true;

            if (!hitInfo.InRowCell)
                return;

            if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdNhomSV"]).ToString().Trim() != "")
            {
                if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdNhomSV"]).ToString().Trim() != Program.nhom)
                    (e as DXMouseEventArgs).Handled = true;
            }

            if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdKhoa"]).ToString() != Program.khoa)
                (e as DXMouseEventArgs).Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            sinhVienGridControl.Enabled = true;
            btnHTCL.Enabled = true;

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                object cellValue = gridView1.GetRowCellValue(i, "IdNhomSV");
                if (cellValue != null && (string)cellValue.ToString() == Program.nhom)
                {
                    gridView1.SelectRow(i);
                }
            }
        }
    }
}