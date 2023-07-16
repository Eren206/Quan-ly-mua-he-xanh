namespace QLMHX
{
    partial class FrmSinhVien
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
            System.Windows.Forms.Label mSSVLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idKhoaLabel;
            System.Windows.Forms.Label idNhomSVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.quanLyDS = new QLMHX.QuanLyDS();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLMHX.QuanLyDSTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSTableAdapters.TableAdapterManager();
            this.khenThuongTableAdapter = new QLMHX.QuanLyDSTableAdapters.KhenThuongTableAdapter();
            this.khenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sinhVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMSSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.idKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelHo = new System.Windows.Forms.Label();
            mSSVLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idKhoaLabel = new System.Windows.Forms.Label();
            idNhomSVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKhoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSSVLabel
            // 
            mSSVLabel.AutoSize = true;
            mSSVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mSSVLabel.Location = new System.Drawing.Point(42, 80);
            mSSVLabel.Name = "mSSVLabel";
            mSSVLabel.Size = new System.Drawing.Size(57, 21);
            mSSVLabel.TabIndex = 12;
            mSSVLabel.Text = "MSSV:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(42, 172);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(36, 21);
            hoLabel.TabIndex = 13;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(368, 172);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Ten:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(42, 278);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(47, 21);
            sDTLabel.TabIndex = 15;
            sDTLabel.Text = "SDT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(205, 278);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 21);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // idKhoaLabel
            // 
            idKhoaLabel.AutoSize = true;
            idKhoaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idKhoaLabel.Location = new System.Drawing.Point(638, 172);
            idKhoaLabel.Name = "idKhoaLabel";
            idKhoaLabel.Size = new System.Drawing.Size(73, 21);
            idKhoaLabel.TabIndex = 17;
            idKhoaLabel.Text = "Id Khoa:";
            // 
            // idNhomSVLabel
            // 
            idNhomSVLabel.AutoSize = true;
            idNhomSVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNhomSVLabel.Location = new System.Drawing.Point(638, 278);
            idNhomSVLabel.Name = "idNhomSVLabel";
            idNhomSVLabel.Size = new System.Drawing.Size(103, 21);
            idNhomSVLabel.TabIndex = 18;
            idNhomSVLabel.Text = "Id Nhom SV:";
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
            this.groupAction.TabIndex = 11;
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
            // quanLyDS
            // 
            this.quanLyDS.DataSetName = "QuanLyDS";
            this.quanLyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanLyDS;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = this.khenThuongTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // khenThuongBindingSource
            // 
            this.khenThuongBindingSource.DataMember = "FK__KhenThuong__MSSV__68487DD7";
            this.khenThuongBindingSource.DataSource = this.sinhVienBindingSource;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sinhVienGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1918, 361);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Data";
            // 
            // sinhVienGridControl
            // 
            this.sinhVienGridControl.DataSource = this.sinhVienBindingSource;
            this.sinhVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhVienGridControl.Location = new System.Drawing.Point(2, 28);
            this.sinhVienGridControl.MainView = this.gridView1;
            this.sinhVienGridControl.Name = "sinhVienGridControl";
            this.sinhVienGridControl.Size = new System.Drawing.Size(1914, 331);
            this.sinhVienGridControl.TabIndex = 0;
            this.sinhVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colSDT,
            this.colEmail,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomSV});
            this.gridView1.GridControl = this.sinhVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMSSV
            // 
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.MinWidth = 25;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 0;
            this.colMSSV.Width = 190;
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
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 310;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 5;
            this.colChucVu.Width = 94;
            // 
            // colIdKhoa
            // 
            this.colIdKhoa.FieldName = "IdKhoa";
            this.colIdKhoa.MinWidth = 25;
            this.colIdKhoa.Name = "colIdKhoa";
            this.colIdKhoa.Visible = true;
            this.colIdKhoa.VisibleIndex = 6;
            this.colIdKhoa.Width = 94;
            // 
            // colIdNhomSV
            // 
            this.colIdNhomSV.FieldName = "IdNhomSV";
            this.colIdNhomSV.MinWidth = 25;
            this.colIdNhomSV.Name = "colIdNhomSV";
            this.colIdNhomSV.Visible = true;
            this.colIdNhomSV.VisibleIndex = 7;
            this.colIdNhomSV.Width = 94;
            // 
            // txtMSSV
            // 
            this.txtMSSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "MSSV", true));
            this.txtMSSV.Location = new System.Drawing.Point(46, 104);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Properties.Appearance.Options.UseFont = true;
            this.txtMSSV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMSSV.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMSSV.Properties.MaskSettings.Set("mask", "N[0-9]{2}[a-zA-Z]{4}[0-9]{3}");
            this.txtMSSV.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtMSSV.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtMSSV.Size = new System.Drawing.Size(157, 30);
            this.txtMSSV.TabIndex = 13;
            this.txtMSSV.EditValueChanged += new System.EventHandler(this.txtMSSV_EditValueChanged);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ho", true));
            this.txtHo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(46, 196);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(320, 32);
            this.txtHo.TabIndex = 14;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            this.txtHo.Leave += new System.EventHandler(this.txtHo_Leave);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ten", true));
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(372, 196);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 32);
            this.txtTen.TabIndex = 15;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(46, 302);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtSDT.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtSDT.Properties.MaskSettings.Set("mask", "(0)[0-9]{9}");
            this.txtSDT.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtSDT.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtSDT.Size = new System.Drawing.Size(157, 30);
            this.txtSDT.TabIndex = 16;
            this.txtSDT.EditValueChanged += new System.EventHandler(this.txtSDT_EditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "Email", true));
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(209, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(351, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // idKhoaTextEdit
            // 
            this.idKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "IdKhoa", true));
            this.idKhoaTextEdit.Enabled = false;
            this.idKhoaTextEdit.Location = new System.Drawing.Point(642, 196);
            this.idKhoaTextEdit.Name = "idKhoaTextEdit";
            this.idKhoaTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idKhoaTextEdit.Properties.Appearance.Options.UseFont = true;
            this.idKhoaTextEdit.Size = new System.Drawing.Size(227, 30);
            this.idKhoaTextEdit.TabIndex = 18;
            this.idKhoaTextEdit.EditValueChanged += new System.EventHandler(this.idKhoaTextEdit_EditValueChanged);
            // 
            // txtNhom
            // 
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "IdNhomSV", true));
            this.txtNhom.Enabled = false;
            this.txtNhom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhom.Location = new System.Drawing.Point(642, 302);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(107, 32);
            this.txtNhom.TabIndex = 19;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.comboBox1);
            this.groupControl3.Controls.Add(this.labelMSSV);
            this.groupControl3.Controls.Add(this.labelSDT);
            this.groupControl3.Controls.Add(this.labelTen);
            this.groupControl3.Controls.Add(this.labelHo);
            this.groupControl3.Controls.Add(this.txtEmail);
            this.groupControl3.Controls.Add(idNhomSVLabel);
            this.groupControl3.Controls.Add(this.txtMSSV);
            this.groupControl3.Controls.Add(this.txtNhom);
            this.groupControl3.Controls.Add(mSSVLabel);
            this.groupControl3.Controls.Add(idKhoaLabel);
            this.groupControl3.Controls.Add(this.txtHo);
            this.groupControl3.Controls.Add(this.idKhoaTextEdit);
            this.groupControl3.Controls.Add(hoLabel);
            this.groupControl3.Controls.Add(emailLabel);
            this.groupControl3.Controls.Add(this.txtTen);
            this.groupControl3.Controls.Add(tenLabel);
            this.groupControl3.Controls.Add(sDTLabel);
            this.groupControl3.Controls.Add(this.txtSDT);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Enabled = false;
            this.groupControl3.Location = new System.Drawing.Point(0, 430);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1918, 430);
            this.groupControl3.TabIndex = 20;
            this.groupControl3.Text = "Input";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(642, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 32);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSSV.ForeColor = System.Drawing.Color.Red;
            this.labelMSSV.Location = new System.Drawing.Point(43, 137);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(41, 16);
            this.labelMSSV.TabIndex = 23;
            this.labelMSSV.Text = "label1";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.Red;
            this.labelSDT.Location = new System.Drawing.Point(43, 335);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(41, 16);
            this.labelSDT.TabIndex = 22;
            this.labelSDT.Text = "label3";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Red;
            this.labelTen.Location = new System.Drawing.Point(369, 231);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(41, 16);
            this.labelTen.TabIndex = 21;
            this.labelTen.Text = "label2";
            // 
            // labelHo
            // 
            this.labelHo.AutoSize = true;
            this.labelHo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHo.ForeColor = System.Drawing.Color.Red;
            this.labelHo.Location = new System.Drawing.Point(43, 231);
            this.labelHo.Name = "labelHo";
            this.labelHo.Size = new System.Drawing.Size(41, 16);
            this.labelHo.TabIndex = 20;
            this.labelHo.Text = "label1";
            // 
            // FrmSinhVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 860);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSinhVien";
            this.Text = "z";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupAction;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnReload;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnGhi;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private QuanLyDS quanLyDS;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanLyDSTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QuanLyDSTableAdapters.TableAdapterManager tableAdapterManager;
        private QuanLyDSTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
        private System.Windows.Forms.BindingSource khenThuongBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl sinhVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomSV;
        private DevExpress.XtraEditors.TextEdit txtMSSV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit idKhoaTextEdit;
        private System.Windows.Forms.TextBox txtNhom;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelHo;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}