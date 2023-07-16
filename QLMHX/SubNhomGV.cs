using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
using static DevExpress.Utils.Svg.CommonSvgImages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLMHX
{

    public partial class SubNhomGV : DevExpress.XtraEditors.XtraForm
    {
        bool HoanTatClick = false;
        List<ListItem> items = new List<ListItem>();
        
        public class ListItem
        {
            public string DisplayText { get; set; }
            public int Value { get; set; }
        }

        public SubNhomGV()
        {
            InitializeComponent();
        }

        private void giangVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giangVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDSnew);
        }

        private void SubNhomGV_Load(object sender, EventArgs e)
        {
            quanLyDSnew.EnforceConstraints = false;
            
            giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangVienTableAdapter.Fill(this.quanLyDSnew.GiangVien);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string txt = "Lưu thông tin thành viên vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int rowHandle;
                    int targetId = (int)CmbDT.SelectedValue;

                    if (targetId != 0)
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object idNhomGV = gridView1.GetRowCellValue(i, "IdNhomGV");
                            if (idNhomGV != null && idNhomGV.ToString().Trim() == Program.nhom)
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
                            object idGvValue = gridView1.GetRowCellValue(i, "IdGV");
                            if (idGvValue != null && idGvValue.ToString().Trim() == targetId.ToString())
                            {
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
                            object idNhomGV = gridView1.GetRowCellValue(i, "IdNhomGV");
                            if (idNhomGV != null && idNhomGV.ToString().Trim() == Program.nhom)
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

                    targetId = (int)CmbDP.SelectedValue;

                    if (targetId != 0)
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object idNhomGV = gridView1.GetRowCellValue(i, "IdNhomGV");
                            if (idNhomGV != null && idNhomGV.ToString().Trim() == Program.nhom)
                            {
                                rowHandle = gridView1.GetRowHandle(i);
                                if ((string)gridView1.GetRowCellValue(rowHandle, "ChucVu").ToString() == "Đội Phó")
                                {
                                    gridView1.SetRowCellValue(rowHandle, "ChucVu", null);
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object idGvValue = gridView1.GetRowCellValue(i, "IdGV");
                            if (idGvValue != null && idGvValue.ToString().Trim() == targetId.ToString())
                            {
                                rowHandle = gridView1.GetRowHandle(i);
                                gridView1.SetRowCellValue(rowHandle, "ChucVu", "Đội Phó");
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            object idNhomGV = gridView1.GetRowCellValue(i, "IdNhomGV");
                            if (idNhomGV != null && idNhomGV.ToString().Trim() == Program.nhom)
                            {
                                rowHandle = gridView1.GetRowHandle(i);
                                if ((string)gridView1.GetRowCellValue(rowHandle, "ChucVu").ToString() == "Đội Phó")
                                {
                                    gridView1.SetRowCellValue(rowHandle, "ChucVu", null);
                                    break;
                                }
                            }
                        }
                    }

                    giangVienBindingSource.EndEdit();
                    giangVienTableAdapter.Update(quanLyDSnew.GiangVien);


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!HoanTatClick)
            {
                GridView gridView = gridView1;

                int[] selectedRows = gridView.GetSelectedRows();
                int[] selectedChucVu = { 0, 0 };
                String hoten = string.Empty;
                String id = string.Empty;
                string nhom = string.Empty;

                if (selectedRows.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên!", "Thông báo");
                    return;
                }

                if (selectedRows.Length > 4)
                {
                    MessageBox.Show("Mỗi nhóm GV chỉ có tối đa 4 người!\nVui lòng chọn lại!", "Thông báo");
                    return;
                }

                items.Clear();
                items.Add(new ListItem {DisplayText = "<none>", Value = 0});

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    nhom = (string)gridView.GetRowCellValue(i, "IdNhomGV").ToString();

                    if (nhom == Program.nhom)
                    {
                        gridView.SetRowCellValue(i, "IdNhomGV", "");
                        continue;
                    }

                    if (nhom != "")
                        continue;
                }

                foreach (int row in selectedRows)
                {
                    gridView.SetRowCellValue(row, "IdNhomGV", Program.nhom);
                    id = gridView.GetRowCellValue(row, "IdGV").ToString();
                    hoten = gridView.GetRowCellValue(row, "Ho").ToString() + " " + gridView.GetRowCellValue(row, "Ten").ToString();

                    Console.WriteLine(row + " " + (string)gridView.GetRowCellValue(row, "ChucVu").ToString());
                    
                    if ((string)gridView.GetRowCellValue(row, "ChucVu").ToString() == "Đội Trưởng")
                    {
                        selectedChucVu[0] = int.Parse(id);
                    }
                    else if ((string)gridView.GetRowCellValue(row, "ChucVu").ToString() == "Đội Phó")
                    {
                        selectedChucVu[1] = int.Parse(id);
                    }
                    items.Add(new ListItem { DisplayText = hoten, Value = int.Parse(id)});
                }

                List<ListItem> itemsCopy1 = new List<ListItem>(items);
                List<ListItem> itemsCopy2 = new List<ListItem>(items);
                
                CmbDT.DataBindings.Clear();
                CmbDP.DataBindings.Clear();

                CmbDT.DataSource = itemsCopy1;
                CmbDT.DisplayMember = "DisplayText";
                CmbDT.ValueMember = "Value";

                CmbDP.DataSource = itemsCopy2;
                CmbDP.DisplayMember = "DisplayText";
                CmbDP.ValueMember = "Value";

                CmbDT.SelectedValue = selectedChucVu[0];
                CmbDP.SelectedValue = selectedChucVu[1];

                int rowHandle;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    object idNhomGV = gridView1.GetRowCellValue(i, "IdNhomGV");
                    if (idNhomGV != null && idNhomGV.ToString().Trim() == "")
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

                giangVienGridControl.Enabled = false;
                groupControl1.Enabled = true;
            }
            else
            {
                HoanTatClick = false;
                btnHTCL.BackColor = Color.FromArgb(192, 255, 192);
                btnHTCL.Text = "Hoàn Tất";

                giangVienGridControl.Enabled = true;
                groupControl1.Enabled = false;
            }
        }

        private void CmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDT.SelectedIndex == CmbDP.SelectedIndex)
            {
                if (CmbDT.SelectedIndex == 0) return;
                else
                {
                    btnXacNhan.Enabled = false;
                }
            } 
            else
            {
                btnXacNhan.Enabled = true;
            }
        }

        private void CmbDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDT.SelectedIndex == CmbDP.SelectedIndex)
            {
                if (CmbDP.SelectedIndex == 0) return;
                else
                {
                    btnXacNhan.Enabled = false;
                }
            }
            else
            {
                btnXacNhan.Enabled = true;
            }
        }

        private void giangVienGridControl_Click_1(object sender, EventArgs e)
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

            if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdNhomGV"]).ToString().Trim() != "")
            {
                if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdNhomGV"]).ToString().Trim() != Program.nhom)
                    (e as DXMouseEventArgs).Handled = true;
            }

            if ((string)view.GetRowCellValue(hitInfo.RowHandle, view.Columns["IdKhoa"]).ToString() != Program.khoa)
                (e as DXMouseEventArgs).Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            giangVienGridControl.Enabled = true;
            btnHTCL.Enabled = true;

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                object cellValue = gridView1.GetRowCellValue(i, "IdNhomGV");
                if (cellValue != null && (string)cellValue.ToString() == Program.nhom)
                {
                    gridView1.SelectRow(i);
                }
            }
        }
    }
}