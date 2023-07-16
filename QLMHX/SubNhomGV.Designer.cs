namespace QLMHX
{
    partial class SubNhomGV
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
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.GiangVienTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHTCL = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDT = new System.Windows.Forms.ComboBox();
            this.CmbDP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
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
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.quanLyDSnew;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = this.giangVienTableAdapter;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giangVienGridControl
            // 
            this.giangVienGridControl.DataSource = this.giangVienBindingSource;
            this.giangVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giangVienGridControl.Enabled = false;
            this.giangVienGridControl.Location = new System.Drawing.Point(0, 0);
            this.giangVienGridControl.MainView = this.gridView1;
            this.giangVienGridControl.Name = "giangVienGridControl";
            this.giangVienGridControl.Size = new System.Drawing.Size(1286, 304);
            this.giangVienGridControl.TabIndex = 1;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.giangVienGridControl.Click += new System.EventHandler(this.giangVienGridControl_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGV,
            this.colHo,
            this.colTen,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomGV});
            this.gridView1.GridControl = this.giangVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colIdGV
            // 
            this.colIdGV.FieldName = "IdGV";
            this.colIdGV.MinWidth = 25;
            this.colIdGV.Name = "colIdGV";
            this.colIdGV.Visible = true;
            this.colIdGV.VisibleIndex = 1;
            this.colIdGV.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 2;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            this.colTen.Width = 94;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 4;
            this.colChucVu.Width = 94;
            // 
            // colIdKhoa
            // 
            this.colIdKhoa.FieldName = "IdKhoa";
            this.colIdKhoa.MinWidth = 25;
            this.colIdKhoa.Name = "colIdKhoa";
            this.colIdKhoa.Visible = true;
            this.colIdKhoa.VisibleIndex = 5;
            this.colIdKhoa.Width = 94;
            // 
            // colIdNhomGV
            // 
            this.colIdNhomGV.FieldName = "IdNhomGV";
            this.colIdNhomGV.MinWidth = 25;
            this.colIdNhomGV.Name = "colIdNhomGV";
            this.colIdNhomGV.Visible = true;
            this.colIdNhomGV.VisibleIndex = 6;
            this.colIdNhomGV.Width = 94;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(1026, 275);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(117, 38);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1149, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 38);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHTCL
            // 
            this.btnHTCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHTCL.Enabled = false;
            this.btnHTCL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTCL.Location = new System.Drawing.Point(1026, 310);
            this.btnHTCL.Name = "btnHTCL";
            this.btnHTCL.Size = new System.Drawing.Size(240, 38);
            this.btnHTCL.TabIndex = 14;
            this.btnHTCL.Text = "Hoàn Tất";
            this.btnHTCL.UseVisualStyleBackColor = false;
            this.btnHTCL.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.CmbDT);
            this.groupControl1.Controls.Add(this.CmbDP);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(0, 355);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1286, 333);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Phân Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(490, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lựa chọn đội phó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lựa chọn đội trưởng";
            // 
            // CmbDT
            // 
            this.CmbDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDT.FormattingEnabled = true;
            this.CmbDT.Location = new System.Drawing.Point(120, 111);
            this.CmbDT.Name = "CmbDT";
            this.CmbDT.Size = new System.Drawing.Size(364, 32);
            this.CmbDT.TabIndex = 15;
            this.CmbDT.SelectedIndexChanged += new System.EventHandler(this.CmbDT_SelectedIndexChanged);
            // 
            // CmbDP
            // 
            this.CmbDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDP.FormattingEnabled = true;
            this.CmbDP.Location = new System.Drawing.Point(490, 111);
            this.CmbDP.Name = "CmbDP";
            this.CmbDP.Size = new System.Drawing.Size(364, 32);
            this.CmbDP.TabIndex = 14;
            this.CmbDP.SelectedIndexChanged += new System.EventHandler(this.CmbDP_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SubNhomGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnHTCL);
            this.Controls.Add(this.giangVienGridControl);
            this.Name = "SubNhomGV";
            this.Text = "SubNhomGV";
            this.Load += new System.EventHandler(this.SubNhomGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyDSnew quanLyDSnew;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyDSnewTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private QuanLyDSnewTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomGV;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHTCL;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox CmbDT;
        private System.Windows.Forms.ComboBox CmbDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}