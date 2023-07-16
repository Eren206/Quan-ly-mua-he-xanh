namespace QLMHX
{
    partial class frmKhoa
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
            System.Windows.Forms.Label idKhoaLabel;
            System.Windows.Forms.Label tenLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.khoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDS = new QLMHX.QuanLyDS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoaTableAdapter = new QLMHX.QuanLyDSTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSTableAdapters.TableAdapterManager();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLMHX.QuanLyDSTableAdapters.SinhVienTableAdapter();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new QLMHX.QuanLyDSTableAdapters.GiangVienTableAdapter();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            idKhoaLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idKhoaLabel
            // 
            idKhoaLabel.AutoSize = true;
            idKhoaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idKhoaLabel.Location = new System.Drawing.Point(70, 484);
            idKhoaLabel.Name = "idKhoaLabel";
            idKhoaLabel.Size = new System.Drawing.Size(73, 21);
            idKhoaLabel.TabIndex = 13;
            idKhoaLabel.Text = "Id Khoa:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(70, 569);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Ten:";
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.BtnSua);
            this.groupAction.Controls.Add(this.BtnReload);
            this.groupAction.Controls.Add(this.BtnUndo);
            this.groupAction.Controls.Add(this.BtnGhi);
            this.groupAction.Controls.Add(this.BtnXoa);
            this.groupAction.Controls.Add(this.BtnThem);
            this.groupAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAction.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupAction.Location = new System.Drawing.Point(0, 0);
            this.groupAction.Name = "groupAction";
            this.groupAction.Size = new System.Drawing.Size(1918, 69);
            this.groupAction.TabIndex = 12;
            this.groupAction.Text = "Action";
            // 
            // BtnSua
            // 
            this.BtnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSua.ImageOptions.SvgImage")));
            this.BtnSua.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnSua.Location = new System.Drawing.Point(205, 31);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(94, 29);
            this.BtnSua.TabIndex = 9;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnReload.ImageOptions.SvgImage")));
            this.BtnReload.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnReload.Location = new System.Drawing.Point(505, 31);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(94, 29);
            this.BtnReload.TabIndex = 6;
            this.BtnReload.Text = "Reload";
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Enabled = false;
            this.BtnUndo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUndo.ImageOptions.SvgImage")));
            this.BtnUndo.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnUndo.Location = new System.Drawing.Point(405, 31);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(94, 29);
            this.BtnUndo.TabIndex = 5;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnGhi
            // 
            this.BtnGhi.Enabled = false;
            this.BtnGhi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGhi.ImageOptions.SvgImage")));
            this.BtnGhi.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnGhi.Location = new System.Drawing.Point(305, 31);
            this.BtnGhi.Name = "BtnGhi";
            this.BtnGhi.Size = new System.Drawing.Size(94, 29);
            this.BtnGhi.TabIndex = 4;
            this.BtnGhi.Text = "Ghi";
            this.BtnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoa.ImageOptions.SvgImage")));
            this.BtnXoa.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnXoa.Location = new System.Drawing.Point(105, 31);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(94, 29);
            this.BtnXoa.TabIndex = 3;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThem.ImageOptions.SvgImage")));
            this.BtnThem.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnThem.Location = new System.Drawing.Point(5, 31);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(94, 29);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.khoaGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1918, 365);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "groupControl1";
            // 
            // khoaGridControl
            // 
            this.khoaGridControl.DataSource = this.khoaBindingSource;
            this.khoaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoaGridControl.Location = new System.Drawing.Point(2, 28);
            this.khoaGridControl.MainView = this.gridView1;
            this.khoaGridControl.Name = "khoaGridControl";
            this.khoaGridControl.Size = new System.Drawing.Size(1914, 335);
            this.khoaGridControl.TabIndex = 0;
            this.khoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.quanLyDS;
            // 
            // quanLyDS
            // 
            this.quanLyDS.DataSetName = "QuanLyDS";
            this.quanLyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdKhoa,
            this.colTen});
            this.gridView1.GridControl = this.khoaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIdKhoa
            // 
            this.colIdKhoa.FieldName = "IdKhoa";
            this.colIdKhoa.MinWidth = 25;
            this.colIdKhoa.Name = "colIdKhoa";
            this.colIdKhoa.Visible = true;
            this.colIdKhoa.VisibleIndex = 0;
            this.colIdKhoa.Width = 175;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 1711;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "Ten", true));
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(74, 593);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(325, 32);
            this.txtTen.TabIndex = 15;
            this.txtTen.TextChanged += new System.EventHandler(this.tenTextBox_TextChanged);
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenTextBox_KeyPress);
            this.txtTen.Leave += new System.EventHandler(this.tenTextBox_Leave);
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Red;
            this.labelTen.Location = new System.Drawing.Point(74, 632);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(41, 16);
            this.labelTen.TabIndex = 16;
            this.labelTen.Text = "label1";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "FK__SinhVien__IdKhoa__4E88ABD4";
            this.sinhVienBindingSource.DataSource = this.khoaBindingSource;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "FK__GiangVien__IdKho__6E01572D";
            this.giangVienBindingSource.DataSource = this.khoaBindingSource;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // txtKhoa
            // 
            this.txtKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "IdKhoa", true));
            this.txtKhoa.Enabled = false;
            this.txtKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(74, 508);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(125, 32);
            this.txtKhoa.TabIndex = 17;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1040);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(idKhoaLabel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "frmKhoa";
            this.Text = "FrmKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupAction;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnReload;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnGhi;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private QuanLyDS quanLyDS;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLyDSTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private QuanLyDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanLyDSTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyDSTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.TextBox txtKhoa;
    }
}