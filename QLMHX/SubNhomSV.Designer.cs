namespace QLMHX
{
    partial class SubNhomSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.quanLyDSnew = new QLMHX.QuanLyDSnew();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager();
            this.sinhVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHTCL = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDT = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanLyDSnew
            // 
            this.quanLyDSnew.DataSetName = "QuanLyDSnew";
            this.quanLyDSnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanLyDSnew;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhVienGridControl
            // 
            this.sinhVienGridControl.DataSource = this.sinhVienBindingSource;
            this.sinhVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sinhVienGridControl.Enabled = false;
            this.sinhVienGridControl.Location = new System.Drawing.Point(0, 0);
            this.sinhVienGridControl.MainView = this.gridView1;
            this.sinhVienGridControl.Name = "sinhVienGridControl";
            this.sinhVienGridControl.Size = new System.Drawing.Size(1278, 304);
            this.sinhVienGridControl.TabIndex = 1;
            this.sinhVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomSV});
            this.gridView1.GridControl = this.sinhVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colMSSV
            // 
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.MinWidth = 25;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 0;
            this.colMSSV.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 3;
            this.colChucVu.Width = 94;
            // 
            // colIdKhoa
            // 
            this.colIdKhoa.FieldName = "IdKhoa";
            this.colIdKhoa.MinWidth = 25;
            this.colIdKhoa.Name = "colIdKhoa";
            this.colIdKhoa.Visible = true;
            this.colIdKhoa.VisibleIndex = 4;
            this.colIdKhoa.Width = 94;
            // 
            // colIdNhomSV
            // 
            this.colIdNhomSV.FieldName = "IdNhomSV";
            this.colIdNhomSV.MinWidth = 25;
            this.colIdNhomSV.Name = "colIdNhomSV";
            this.colIdNhomSV.Visible = true;
            this.colIdNhomSV.VisibleIndex = 5;
            this.colIdNhomSV.Width = 94;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHTCL
            // 
            this.btnHTCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHTCL.Enabled = false;
            this.btnHTCL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTCL.Location = new System.Drawing.Point(1026, 310);
            this.btnHTCL.Name = "btnHTCL";
            this.btnHTCL.Size = new System.Drawing.Size(240, 38);
            this.btnHTCL.TabIndex = 18;
            this.btnHTCL.Text = "Hoàn Tất";
            this.btnHTCL.UseVisualStyleBackColor = false;
            this.btnHTCL.Click += new System.EventHandler(this.btnHTCL_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.CmbDT);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(0, 354);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1278, 328);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Phân Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lựa chọn đội trưởng";
            // 
            // CmbDT
            // 
            this.CmbDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDT.FormattingEnabled = true;
            this.CmbDT.Location = new System.Drawing.Point(120, 113);
            this.CmbDT.Name = "CmbDT";
            this.CmbDT.Size = new System.Drawing.Size(364, 32);
            this.CmbDT.TabIndex = 21;
            this.CmbDT.SelectedIndexChanged += new System.EventHandler(this.CmbDT_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1149, 276);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 38);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(1026, 276);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(117, 38);
            this.btnXacNhan.TabIndex = 23;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // SubNhomSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHTCL);
            this.Controls.Add(this.sinhVienGridControl);
            this.Name = "SubNhomSV";
            this.Text = "SubNhomSV";
            this.Load += new System.EventHandler(this.SubNhomSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyDSnew quanLyDSnew;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanLyDSnewTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QuanLyDSnewTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sinhVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHTCL;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}