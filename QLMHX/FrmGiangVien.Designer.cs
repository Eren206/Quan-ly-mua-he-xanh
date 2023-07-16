namespace QLMHX
{
    partial class FrmGiangVien
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
            System.Windows.Forms.Label idGVLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label labelIDK;
            System.Windows.Forms.Label idNhomGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiangVien));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.quanLyDS = new QLMHX.QuanLyDS();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new QLMHX.QuanLyDSTableAdapters.GiangVienTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.idKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.labelHo = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            idGVLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            labelIDK = new System.Windows.Forms.Label();
            idNhomGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKhoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idGVLabel
            // 
            idGVLabel.AutoSize = true;
            idGVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idGVLabel.Location = new System.Drawing.Point(42, 80);
            idGVLabel.Name = "idGVLabel";
            idGVLabel.Size = new System.Drawing.Size(57, 21);
            idGVLabel.TabIndex = 11;
            idGVLabel.Text = "Id GV:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(42, 172);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(36, 21);
            hoLabel.TabIndex = 12;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(368, 172);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 13;
            tenLabel.Text = "Ten:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(42, 278);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(47, 21);
            sDTLabel.TabIndex = 14;
            sDTLabel.Text = "SĐT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(205, 278);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 21);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // labelIDK
            // 
            labelIDK.AutoSize = true;
            labelIDK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelIDK.Location = new System.Drawing.Point(638, 172);
            labelIDK.Name = "labelIDK";
            labelIDK.Size = new System.Drawing.Size(73, 21);
            labelIDK.TabIndex = 16;
            labelIDK.Text = "Id Khoa:";
            // 
            // idNhomGVLabel
            // 
            idNhomGVLabel.AutoSize = true;
            idNhomGVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNhomGVLabel.Location = new System.Drawing.Point(638, 278);
            idNhomGVLabel.Name = "idNhomGVLabel";
            idNhomGVLabel.Size = new System.Drawing.Size(105, 21);
            idNhomGVLabel.TabIndex = 17;
            idNhomGVLabel.Text = "Id Nhom GV:";
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
            this.groupAction.TabIndex = 10;
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
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.quanLyDS;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = this.giangVienTableAdapter;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.giangVienGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1918, 361);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Data";
            // 
            // giangVienGridControl
            // 
            this.giangVienGridControl.DataSource = this.giangVienBindingSource;
            this.giangVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giangVienGridControl.Location = new System.Drawing.Point(2, 28);
            this.giangVienGridControl.MainView = this.gridView1;
            this.giangVienGridControl.Name = "giangVienGridControl";
            this.giangVienGridControl.Size = new System.Drawing.Size(1914, 331);
            this.giangVienGridControl.TabIndex = 0;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGV,
            this.colHo,
            this.colTen,
            this.colSDT,
            this.colEmail,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomGV});
            this.gridView1.GridControl = this.giangVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIdGV
            // 
            this.colIdGV.FieldName = "IdGV";
            this.colIdGV.MinWidth = 25;
            this.colIdGV.Name = "colIdGV";
            this.colIdGV.Visible = true;
            this.colIdGV.VisibleIndex = 0;
            this.colIdGV.Width = 123;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 250;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 250;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 250;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 334;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 5;
            this.colChucVu.Width = 223;
            // 
            // colIdKhoa
            // 
            this.colIdKhoa.FieldName = "IdKhoa";
            this.colIdKhoa.MinWidth = 25;
            this.colIdKhoa.Name = "colIdKhoa";
            this.colIdKhoa.Visible = true;
            this.colIdKhoa.VisibleIndex = 6;
            this.colIdKhoa.Width = 223;
            // 
            // colIdNhomGV
            // 
            this.colIdNhomGV.FieldName = "IdNhomGV";
            this.colIdNhomGV.MinWidth = 25;
            this.colIdNhomGV.Name = "colIdNhomGV";
            this.colIdNhomGV.Visible = true;
            this.colIdNhomGV.VisibleIndex = 7;
            this.colIdNhomGV.Width = 233;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "IdGV", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(46, 104);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(125, 30);
            this.txtId.TabIndex = 12;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource, "Ho", true));
            this.txtHo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(46, 196);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(320, 32);
            this.txtHo.TabIndex = 13;
            this.txtHo.TextChanged += new System.EventHandler(this.hoTextBox_TextChanged);
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoTextBox_KeyPress);
            this.txtHo.Leave += new System.EventHandler(this.hoTextBox_Leave);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource, "Ten", true));
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(372, 196);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 32);
            this.txtTen.TabIndex = 14;
            this.txtTen.TextChanged += new System.EventHandler(this.tenTextBox_TextChanged);
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenTextBox_KeyPress);
            this.txtTen.Leave += new System.EventHandler(this.tenTextBox_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(46, 302);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtSDT.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtSDT.Properties.MaskSettings.Set("mask", "(0)[0-9]{9}");
            this.txtSDT.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtSDT.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtSDT.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtSDT.Size = new System.Drawing.Size(157, 30);
            this.txtSDT.TabIndex = 15;
            this.txtSDT.EditValueChanged += new System.EventHandler(this.sDTTextEdit_EditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(209, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtEmail.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtEmail.Properties.MaskSettings.Set("mask", "[a-zA-Z0-9]*(@ptithcm[.]edu[.]vn)");
            this.txtEmail.Properties.MaskSettings.Set("allowBlankInput", false);
            this.txtEmail.Properties.MaskSettings.Set("isAutoComplete", true);
            this.txtEmail.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtEmail.Size = new System.Drawing.Size(351, 30);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.emailTextEdit_EditValueChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // idKhoaTextEdit
            // 
            this.idKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "IdKhoa", true));
            this.idKhoaTextEdit.Enabled = false;
            this.idKhoaTextEdit.Location = new System.Drawing.Point(642, 198);
            this.idKhoaTextEdit.Name = "idKhoaTextEdit";
            this.idKhoaTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idKhoaTextEdit.Properties.Appearance.Options.UseFont = true;
            this.idKhoaTextEdit.Size = new System.Drawing.Size(227, 30);
            this.idKhoaTextEdit.TabIndex = 17;
            this.idKhoaTextEdit.EditValueChanged += new System.EventHandler(this.idKhoaTextEdit_EditValueChanged);
            // 
            // txtNhom
            // 
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "IdNhomGV", true));
            this.txtNhom.Enabled = false;
            this.txtNhom.Location = new System.Drawing.Point(642, 302);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhom.Properties.Appearance.Options.UseFont = true;
            this.txtNhom.Size = new System.Drawing.Size(101, 30);
            this.txtNhom.TabIndex = 18;
            // 
            // labelHo
            // 
            this.labelHo.AutoSize = true;
            this.labelHo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHo.ForeColor = System.Drawing.Color.Red;
            this.labelHo.Location = new System.Drawing.Point(43, 231);
            this.labelHo.Name = "labelHo";
            this.labelHo.Size = new System.Drawing.Size(0, 16);
            this.labelHo.TabIndex = 19;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Red;
            this.labelTen.Location = new System.Drawing.Point(349, 231);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(0, 16);
            this.labelTen.TabIndex = 20;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.comboBox1);
            this.groupControl3.Controls.Add(this.labelEmail);
            this.groupControl3.Controls.Add(this.labelSDT);
            this.groupControl3.Controls.Add(this.labelTen);
            this.groupControl3.Controls.Add(this.labelHo);
            this.groupControl3.Controls.Add(idNhomGVLabel);
            this.groupControl3.Controls.Add(this.txtNhom);
            this.groupControl3.Controls.Add(labelIDK);
            this.groupControl3.Controls.Add(this.idKhoaTextEdit);
            this.groupControl3.Controls.Add(emailLabel);
            this.groupControl3.Controls.Add(this.txtEmail);
            this.groupControl3.Controls.Add(sDTLabel);
            this.groupControl3.Controls.Add(this.txtSDT);
            this.groupControl3.Controls.Add(tenLabel);
            this.groupControl3.Controls.Add(this.txtTen);
            this.groupControl3.Controls.Add(hoLabel);
            this.groupControl3.Controls.Add(this.txtHo);
            this.groupControl3.Controls.Add(idGVLabel);
            this.groupControl3.Controls.Add(this.txtId);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Enabled = false;
            this.groupControl3.Location = new System.Drawing.Point(0, 430);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1918, 430);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "Input";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(642, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 32);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(206, 335);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "label1";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.Red;
            this.labelSDT.Location = new System.Drawing.Point(43, 335);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(41, 16);
            this.labelSDT.TabIndex = 21;
            this.labelSDT.Text = "label1";
            // 
            // FrmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 860);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmGiangVien";
            this.Text = "FrmGiangVien";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyDSTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private QuanLyDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit idKhoaTextEdit;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private System.Windows.Forms.Label labelHo;
        private System.Windows.Forms.Label labelTen;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomGV;
    }
}