namespace QLMHX
{
    partial class FrmNhomSV
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
            System.Windows.Forms.Label idNhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhomSV));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNha = new DevExpress.XtraEditors.TextEdit();
            this.nhomSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDSnew = new QLMHX.QuanLyDSnew();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.nhomSVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.BtnXoaTV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sinhVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNhomSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomSVTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.NhomSVTableAdapter();
            this.tableAdapterManager = new QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager();
            this.sinhVienTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.SinhVienTableAdapter();
            this.pCCVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCCVTableAdapter = new QLMHX.QuanLyDSnewTableAdapters.PCCVTableAdapter();
            idNhomLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            idNhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).BeginInit();
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
            // idNhaLabel
            // 
            idNhaLabel.AutoSize = true;
            idNhaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNhaLabel.Location = new System.Drawing.Point(234, 555);
            idNhaLabel.Name = "idNhaLabel";
            idNhaLabel.Size = new System.Drawing.Size(65, 21);
            idNhaLabel.TabIndex = 5;
            idNhaLabel.Text = "Id Nha:";
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
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(idNhaLabel);
            this.groupControl1.Controls.Add(this.txtNha);
            this.groupControl1.Controls.Add(tenLabel);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(idNhomLabel);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.nhomSVGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(651, 791);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 615);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNha
            // 
            this.txtNha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomSVBindingSource, "IdNha", true));
            this.txtNha.Enabled = false;
            this.txtNha.Location = new System.Drawing.Point(238, 579);
            this.txtNha.Name = "txtNha";
            this.txtNha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNha.Properties.Appearance.Options.UseFont = true;
            this.txtNha.Size = new System.Drawing.Size(367, 30);
            this.txtNha.TabIndex = 6;
            // 
            // nhomSVBindingSource
            // 
            this.nhomSVBindingSource.DataMember = "NhomSV";
            this.nhomSVBindingSource.DataSource = this.quanLyDSnew;
            // 
            // quanLyDSnew
            // 
            this.quanLyDSnew.DataSetName = "QuanLyDSnew";
            this.quanLyDSnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomSVBindingSource, "Ten", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(43, 579);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(125, 30);
            this.txtTen.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomSVBindingSource, "IdNhom", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(43, 482);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(125, 30);
            this.txtId.TabIndex = 2;
            this.txtId.EditValueChanged += new System.EventHandler(this.txtId_EditValueChanged);
            // 
            // nhomSVGridControl
            // 
            this.nhomSVGridControl.DataSource = this.nhomSVBindingSource;
            this.nhomSVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhomSVGridControl.Location = new System.Drawing.Point(2, 28);
            this.nhomSVGridControl.MainView = this.gridView1;
            this.nhomSVGridControl.Name = "nhomSVGridControl";
            this.nhomSVGridControl.Size = new System.Drawing.Size(647, 374);
            this.nhomSVGridControl.TabIndex = 0;
            this.nhomSVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNhom,
            this.colTen,
            this.colIdNha});
            this.gridView1.GridControl = this.nhomSVGridControl;
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
            this.colIdNhom.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 94;
            // 
            // colIdNha
            // 
            this.colIdNha.FieldName = "IdNha";
            this.colIdNha.MinWidth = 25;
            this.colIdNha.Name = "colIdNha";
            this.colIdNha.Visible = true;
            this.colIdNha.VisibleIndex = 2;
            this.colIdNha.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTenSV);
            this.groupControl2.Controls.Add(this.txtHo);
            this.groupControl2.Controls.Add(this.txtMASV);
            this.groupControl2.Controls.Add(this.BtnXoaTV);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.sinhVienGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(651, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1275, 791);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "groupControl2";
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "Ten", true));
            this.txtTenSV.Enabled = false;
            this.txtTenSV.Location = new System.Drawing.Point(33, 481);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(292, 22);
            this.txtTenSV.TabIndex = 14;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "FK__SinhVien__IdNhom__7C4F7684";
            this.sinhVienBindingSource.DataSource = this.nhomSVBindingSource;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "Ho", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(33, 453);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(125, 22);
            this.txtHo.TabIndex = 13;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhVienBindingSource, "MSSV", true));
            this.txtMASV.Enabled = false;
            this.txtMASV.Location = new System.Drawing.Point(33, 425);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(157, 22);
            this.txtMASV.TabIndex = 12;
            // 
            // BtnXoaTV
            // 
            this.BtnXoaTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnXoaTV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaTV.Location = new System.Drawing.Point(851, 408);
            this.BtnXoaTV.Name = "BtnXoaTV";
            this.BtnXoaTV.Size = new System.Drawing.Size(199, 40);
            this.BtnXoaTV.TabIndex = 11;
            this.BtnXoaTV.Text = "Xóa Thành Viên";
            this.BtnXoaTV.UseVisualStyleBackColor = false;
            this.BtnXoaTV.Click += new System.EventHandler(this.BtnXoaTV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1056, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quản Lý Thành Viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sinhVienGridControl
            // 
            this.sinhVienGridControl.DataSource = this.sinhVienBindingSource;
            this.sinhVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sinhVienGridControl.Location = new System.Drawing.Point(2, 28);
            this.sinhVienGridControl.MainView = this.gridView2;
            this.sinhVienGridControl.Name = "sinhVienGridControl";
            this.sinhVienGridControl.Size = new System.Drawing.Size(1271, 374);
            this.sinhVienGridControl.TabIndex = 0;
            this.sinhVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen1,
            this.colSDT,
            this.colEmail,
            this.colChucVu,
            this.colIdKhoa,
            this.colIdNhomSV});
            this.gridView2.GridControl = this.sinhVienGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
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
            // colIdNhomSV
            // 
            this.colIdNhomSV.FieldName = "IdNhomSV";
            this.colIdNhomSV.MinWidth = 25;
            this.colIdNhomSV.Name = "colIdNhomSV";
            this.colIdNhomSV.Visible = true;
            this.colIdNhomSV.VisibleIndex = 7;
            this.colIdNhomSV.Width = 94;
            // 
            // nhomSVTableAdapter
            // 
            this.nhomSVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = this.nhomSVTableAdapter;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLMHX.QuanLyDSnewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // pCCVBindingSource
            // 
            this.pCCVBindingSource.DataMember = "FK__PCCV__IdNhomSV__09A971A2";
            this.pCCVBindingSource.DataSource = this.nhomSVBindingSource;
            // 
            // pCCVTableAdapter
            // 
            this.pCCVTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhomSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1926, 860);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmNhomSV";
            this.Text = "FrmNhomSV";
            this.Load += new System.EventHandler(this.FrmNhomSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDSnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienGridControl)).EndInit();
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
        private System.Windows.Forms.BindingSource nhomSVBindingSource;
        private QuanLyDSnewTableAdapters.NhomSVTableAdapter nhomSVTableAdapter;
        private QuanLyDSnewTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhomSVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyDSnewTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DevExpress.XtraGrid.GridControl sinhVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button BtnXoaTV;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNha;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomSV;
        private DevExpress.XtraEditors.TextEdit txtNha;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource pCCVBindingSource;
        private QuanLyDSnewTableAdapters.PCCVTableAdapter pCCVTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMASV;
    }
}