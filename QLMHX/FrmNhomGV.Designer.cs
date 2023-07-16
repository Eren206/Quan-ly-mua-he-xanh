namespace QLMHX
{
    partial class FrmNhomGV
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
            System.Windows.Forms.Label idNhomLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label idXaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhomGV));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtXa = new DevExpress.XtraEditors.TextEdit();
            this.nhomGVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDSnew = new QLMHX.QuanLyDSnew();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.nhomGVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenGV = new DevExpress.XtraEditors.TextEdit();
            this.gvChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.BtnXoaTV = new System.Windows.Forms.Button();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomGVTableAdapter1 = new QLMHX.QuanLyDSnewTableAdapters.NhomGVTableAdapter();
            this.tableAdapterManager1 = new QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager();
            this.pCCVTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.PCCVTableAdapter();
            this.pCCVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvChildTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.GiangVienTableAdapter();
            idNhomLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            idXaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomGVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomGVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCCVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idNhomLabel
            // 
            idNhomLabel.AutoSize = true;
            idNhomLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNhomLabel.Location = new System.Drawing.Point(39, 458);
            idNhomLabel.Name = "idNhomLabel";
            idNhomLabel.Size = new System.Drawing.Size(79, 21);
            idNhomLabel.TabIndex = 1;
            idNhomLabel.Text = "Id Nhom:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(39, 555);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 3;
            tenLabel.Text = "Ten:";
            // 
            // idXaLabel
            // 
            idXaLabel.AutoSize = true;
            idXaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idXaLabel.Location = new System.Drawing.Point(344, 555);
            idXaLabel.Name = "idXaLabel";
            idXaLabel.Size = new System.Drawing.Size(55, 21);
            idXaLabel.TabIndex = 5;
            idXaLabel.Text = "Id Xa:";
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
            this.groupAction.Size = new System.Drawing.Size(1926, 69);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(idXaLabel);
            this.groupControl1.Controls.Add(this.txtXa);
            this.groupControl1.Controls.Add(tenLabel);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(idNhomLabel);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.nhomGVGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(654, 799);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Data";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 615);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtXa
            // 
            this.txtXa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomGVBindingSource1, "IdXa", true));
            this.txtXa.Enabled = false;
            this.txtXa.Location = new System.Drawing.Point(348, 579);
            this.txtXa.Name = "txtXa";
            this.txtXa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXa.Properties.Appearance.Options.UseFont = true;
            this.txtXa.Size = new System.Drawing.Size(253, 30);
            this.txtXa.TabIndex = 6;
            // 
            // nhomGVBindingSource1
            // 
            this.nhomGVBindingSource1.DataMember = "NhomGV";
            this.nhomGVBindingSource1.DataSource = this.quanLyDSnew;
            // 
            // quanLyDSnew
            // 
            this.quanLyDSnew.DataSetName = "QuanLyDSnew";
            this.quanLyDSnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomGVBindingSource1, "Ten", true));
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(43, 579);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(256, 32);
            this.txtTen.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomGVBindingSource1, "IdNhom", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(43, 482);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(125, 30);
            this.txtId.TabIndex = 2;
            this.txtId.EditValueChanged += new System.EventHandler(this.txtId_EditValueChanged);
            // 
            // nhomGVGridControl
            // 
            this.nhomGVGridControl.DataSource = this.nhomGVBindingSource1;
            this.nhomGVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhomGVGridControl.Location = new System.Drawing.Point(2, 28);
            this.nhomGVGridControl.MainView = this.gridView1;
            this.nhomGVGridControl.Name = "nhomGVGridControl";
            this.nhomGVGridControl.Size = new System.Drawing.Size(650, 374);
            this.nhomGVGridControl.TabIndex = 0;
            this.nhomGVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNhom,
            this.colTen,
            this.colIdXa});
            this.gridView1.GridControl = this.nhomGVGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIdNhom
            // 
            this.colIdNhom.FieldName = "IdNhom";
            this.colIdNhom.MinWidth = 25;
            this.colIdNhom.Name = "colIdNhom";
            this.colIdNhom.Visible = true;
            this.colIdNhom.VisibleIndex = 0;
            this.colIdNhom.Width = 108;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 440;
            // 
            // colIdXa
            // 
            this.colIdXa.FieldName = "IdXa";
            this.colIdXa.MinWidth = 25;
            this.colIdXa.Name = "colIdXa";
            this.colIdXa.Visible = true;
            this.colIdXa.VisibleIndex = 2;
            this.colIdXa.Width = 74;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1061, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quản Lý Thành Viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTenGV);
            this.groupControl2.Controls.Add(this.txtHo);
            this.groupControl2.Controls.Add(this.txtMAGV);
            this.groupControl2.Controls.Add(this.BtnXoaTV);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.giangVienGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(654, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1272, 799);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "List";
            // 
            // txtTenGV
            // 
            this.txtTenGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvChildBindingSource, "Ten", true));
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Location = new System.Drawing.Point(33, 481);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(212, 22);
            this.txtTenGV.TabIndex = 12;
            // 
            // gvChildBindingSource
            // 
            this.gvChildBindingSource.DataMember = "FK__GiangVien__IdNho__1EA48E88";
            this.gvChildBindingSource.DataSource = this.nhomGVBindingSource1;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvChildBindingSource, "Ho", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(33, 453);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(125, 22);
            this.txtHo.TabIndex = 11;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvChildBindingSource, "IdGV", true));
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Location = new System.Drawing.Point(33, 425);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(92, 22);
            this.txtMAGV.TabIndex = 10;
            // 
            // BtnXoaTV
            // 
            this.BtnXoaTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnXoaTV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaTV.Location = new System.Drawing.Point(856, 413);
            this.BtnXoaTV.Name = "BtnXoaTV";
            this.BtnXoaTV.Size = new System.Drawing.Size(199, 40);
            this.BtnXoaTV.TabIndex = 9;
            this.BtnXoaTV.Text = "Xóa Thành Viên";
            this.BtnXoaTV.UseVisualStyleBackColor = false;
            this.BtnXoaTV.Click += new System.EventHandler(this.BtnXoaTV_Click);
            // 
            // giangVienGridControl
            // 
            this.giangVienGridControl.DataSource = this.gvChildBindingSource;
            this.giangVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giangVienGridControl.Location = new System.Drawing.Point(2, 28);
            this.giangVienGridControl.MainView = this.gridView2;
            this.giangVienGridControl.Name = "giangVienGridControl";
            this.giangVienGridControl.Size = new System.Drawing.Size(1268, 374);
            this.giangVienGridControl.TabIndex = 0;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGV,
            this.colHo,
            this.colTen1,
            this.colSDT,
            this.colEmail,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomGV});
            this.gridView2.GridControl = this.giangVienGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colIdGV
            // 
            this.colIdGV.FieldName = "IdGV";
            this.colIdGV.MinWidth = 25;
            this.colIdGV.Name = "colIdGV";
            this.colIdGV.Visible = true;
            this.colIdGV.VisibleIndex = 0;
            this.colIdGV.Width = 94;
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
            // colTen1
            // 
            this.colTen1.FieldName = "Ten";
            this.colTen1.MinWidth = 25;
            this.colTen1.Name = "colTen1";
            this.colTen1.Visible = true;
            this.colTen1.VisibleIndex = 2;
            this.colTen1.Width = 94;
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
            this.colEmail.Width = 94;
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
            // colIdNhomGV
            // 
            this.colIdNhomGV.FieldName = "IdNhomGV";
            this.colIdNhomGV.MinWidth = 25;
            this.colIdNhomGV.Name = "colIdNhomGV";
            this.colIdNhomGV.Visible = true;
            this.colIdNhomGV.VisibleIndex = 7;
            this.colIdNhomGV.Width = 94;
            // 
            // nhomGVTableAdapter1
            // 
            this.nhomGVTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.GiangVienTableAdapter = null;
            this.tableAdapterManager1.NhomGVTableAdapter = this.nhomGVTableAdapter1;
            this.tableAdapterManager1.NhomSVTableAdapter = null;
            this.tableAdapterManager1.PCCVTableAdapter = this.pCCVTableAdapter;
            this.tableAdapterManager1.SinhVienTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pCCVTableAdapter
            // 
            this.pCCVTableAdapter.ClearBeforeFill = true;
            // 
            // pCCVBindingSource
            // 
            this.pCCVBindingSource.DataMember = "FK__PCCV__IdNhomGV__0A9D95DB";
            this.pCCVBindingSource.DataSource = this.nhomGVBindingSource1;
            // 
            // gvChildTableAdapter
            // 
            this.gvChildTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhomGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1926, 868);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmNhomGV";
            this.Text = "FrmNhomGV";
            this.Load += new System.EventHandler(this.FrmNhomGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomGVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomGVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCCVBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private QuanLyDSnew quanLyDSnew;
        private System.Windows.Forms.BindingSource nhomGVBindingSource1;
        private QuanLyDSnewTableAdapters.NhomGVTableAdapter nhomGVTableAdapter1;
        private QuanLyDSnewTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl nhomGVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdXa;
        private DevExpress.XtraEditors.TextEdit txtXa;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.TextEdit txtId;
        private QuanLyDSnewTableAdapters.PCCVTableAdapter pCCVTableAdapter;
        private System.Windows.Forms.BindingSource pCCVBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gvChildBindingSource;
        private QuanLyDSnewTableAdapters.GiangVienTableAdapter gvChildTableAdapter;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomGV;
        private System.Windows.Forms.Button BtnXoaTV;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.TextEdit txtTenGV;
        private DevExpress.XtraEditors.TextEdit txtHo;
    }
}