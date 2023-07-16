namespace QLMHX
{
    partial class FrmAp
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
            System.Windows.Forms.Label idApLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label idXaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAp));
            this.diaBanDataSet = new QLMHX.DiaBanDataSet();
            this.diaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaBanTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.DiaBanTableAdapter();
            this.tableAdapterManager = new QLMHX.DiaBanDataSetTableAdapters.TableAdapterManager();
            this.apTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.ApTableAdapter();
            this.xaTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.XaTableAdapter();
            this.xaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaBanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.apGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdXa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.shadow = new DevExpress.XtraEditors.TextEdit();
            this.txtXa = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelTen = new System.Windows.Forms.Label();
            this.nhaDanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaDanTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.NhaDanTableAdapter();
            this.labelXa = new System.Windows.Forms.Label();
            idApLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            idXaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaDanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idApLabel
            // 
            idApLabel.AutoSize = true;
            idApLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idApLabel.Location = new System.Drawing.Point(982, 44);
            idApLabel.Name = "idApLabel";
            idApLabel.Size = new System.Drawing.Size(56, 21);
            idApLabel.TabIndex = 0;
            idApLabel.Text = "Id Ap:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(982, 149);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 2;
            tenLabel.Text = "Ten:";
            // 
            // idXaLabel
            // 
            idXaLabel.AutoSize = true;
            idXaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idXaLabel.Location = new System.Drawing.Point(1182, 44);
            idXaLabel.Name = "idXaLabel";
            idXaLabel.Size = new System.Drawing.Size(55, 21);
            idXaLabel.TabIndex = 4;
            idXaLabel.Text = "Id Xa:";
            // 
            // diaBanDataSet
            // 
            this.diaBanDataSet.DataSetName = "DiaBanDataSet";
            this.diaBanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diaBanBindingSource
            // 
            this.diaBanBindingSource.DataMember = "DiaBan";
            this.diaBanBindingSource.DataSource = this.diaBanDataSet;
            // 
            // diaBanTableAdapter
            // 
            this.diaBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = this.apTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiaBanTableAdapter = this.diaBanTableAdapter;
            this.tableAdapterManager.NhaDanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.DiaBanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // xaBindingSource
            // 
            this.xaBindingSource.DataMember = "FK__Xa__IdDB__5EBF139D";
            this.xaBindingSource.DataSource = this.diaBanBindingSource;
            // 
            // apBindingSource
            // 
            this.apBindingSource.DataMember = "Ap";
            this.apBindingSource.DataSource = this.diaBanDataSet;
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
            this.BtnSua.Location = new System.Drawing.Point(1098, 35);
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
            this.BtnReload.Location = new System.Drawing.Point(1398, 35);
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
            this.BtnUndo.Location = new System.Drawing.Point(1298, 35);
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
            this.BtnGhi.Location = new System.Drawing.Point(1198, 35);
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
            this.BtnXoa.Location = new System.Drawing.Point(998, 35);
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
            this.BtnThem.Location = new System.Drawing.Point(898, 35);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(94, 29);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.xaGridControl);
            this.groupControl1.Controls.Add(this.diaBanGridControl);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(12, 75);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 427);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Assist";
            // 
            // xaGridControl
            // 
            this.xaGridControl.DataSource = this.xaBindingSource;
            this.xaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xaGridControl.Location = new System.Drawing.Point(331, 28);
            this.xaGridControl.MainView = this.gridView2;
            this.xaGridControl.Name = "xaGridControl";
            this.xaGridControl.Size = new System.Drawing.Size(547, 397);
            this.xaGridControl.TabIndex = 1;
            this.xaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdXa,
            this.colTen1});
            this.gridView2.GridControl = this.xaGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colIdXa
            // 
            this.colIdXa.FieldName = "IdXa";
            this.colIdXa.MinWidth = 25;
            this.colIdXa.Name = "colIdXa";
            this.colIdXa.Visible = true;
            this.colIdXa.VisibleIndex = 1;
            this.colIdXa.Width = 103;
            // 
            // colTen1
            // 
            this.colTen1.FieldName = "Ten";
            this.colTen1.MinWidth = 25;
            this.colTen1.Name = "colTen1";
            this.colTen1.Visible = true;
            this.colTen1.VisibleIndex = 0;
            this.colTen1.Width = 450;
            // 
            // diaBanGridControl
            // 
            this.diaBanGridControl.DataSource = this.diaBanBindingSource;
            this.diaBanGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.diaBanGridControl.Location = new System.Drawing.Point(2, 28);
            this.diaBanGridControl.MainView = this.gridView1;
            this.diaBanGridControl.Name = "diaBanGridControl";
            this.diaBanGridControl.Size = new System.Drawing.Size(329, 397);
            this.diaBanGridControl.TabIndex = 0;
            this.diaBanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen});
            this.gridView1.GridControl = this.diaBanGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 0;
            this.colTen.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.apGridControl);
            this.groupControl2.Location = new System.Drawing.Point(898, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1008, 427);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Data";
            // 
            // apGridControl
            // 
            this.apGridControl.DataSource = this.apBindingSource;
            this.apGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apGridControl.Location = new System.Drawing.Point(2, 28);
            this.apGridControl.MainView = this.gridView3;
            this.apGridControl.Name = "apGridControl";
            this.apGridControl.Size = new System.Drawing.Size(1004, 397);
            this.apGridControl.TabIndex = 0;
            this.apGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAp,
            this.colTen2,
            this.colIdXa1});
            this.gridView3.GridControl = this.apGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            // 
            // colIdAp
            // 
            this.colIdAp.FieldName = "IdAp";
            this.colIdAp.MinWidth = 25;
            this.colIdAp.Name = "colIdAp";
            this.colIdAp.Visible = true;
            this.colIdAp.VisibleIndex = 0;
            this.colIdAp.Width = 94;
            // 
            // colTen2
            // 
            this.colTen2.FieldName = "Ten";
            this.colTen2.MinWidth = 25;
            this.colTen2.Name = "colTen2";
            this.colTen2.Visible = true;
            this.colTen2.VisibleIndex = 1;
            this.colTen2.Width = 94;
            // 
            // colIdXa1
            // 
            this.colIdXa1.FieldName = "IdXa";
            this.colIdXa1.MinWidth = 25;
            this.colIdXa1.Name = "colIdXa1";
            this.colIdXa1.Visible = true;
            this.colIdXa1.VisibleIndex = 2;
            this.colIdXa1.Width = 94;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelXa);
            this.groupControl3.Controls.Add(this.labelTen);
            this.groupControl3.Controls.Add(this.txtXa);
            this.groupControl3.Controls.Add(this.shadow);
            this.groupControl3.Controls.Add(idXaLabel);
            this.groupControl3.Controls.Add(tenLabel);
            this.groupControl3.Controls.Add(this.txtTen);
            this.groupControl3.Controls.Add(idApLabel);
            this.groupControl3.Controls.Add(this.txtId);
            this.groupControl3.Enabled = false;
            this.groupControl3.Location = new System.Drawing.Point(12, 508);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1894, 349);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Input";
            // 
            // shadow
            // 
            this.shadow.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xaBindingSource, "IdXa", true));
            this.shadow.Location = new System.Drawing.Point(1186, 68);
            this.shadow.Name = "shadow";
            this.shadow.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadow.Properties.Appearance.Options.UseFont = true;
            this.shadow.Size = new System.Drawing.Size(125, 30);
            this.shadow.TabIndex = 7;
            this.shadow.EditValueChanged += new System.EventHandler(this.shadow_EditValueChanged);
            // 
            // txtXa
            // 
            this.txtXa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.apBindingSource, "IdXa", true));
            this.txtXa.Enabled = false;
            this.txtXa.Location = new System.Drawing.Point(1186, 68);
            this.txtXa.Name = "txtXa";
            this.txtXa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXa.Properties.Appearance.Options.UseFont = true;
            this.txtXa.Size = new System.Drawing.Size(125, 30);
            this.txtXa.TabIndex = 5;
            this.txtXa.EditValueChanged += new System.EventHandler(this.txtXa_EditValueChanged);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apBindingSource, "Ten", true));
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(986, 173);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(194, 32);
            this.txtTen.TabIndex = 3;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.apBindingSource, "IdAp", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(986, 68);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(125, 30);
            this.txtId.TabIndex = 1;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Red;
            this.labelTen.Location = new System.Drawing.Point(983, 208);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(41, 16);
            this.labelTen.TabIndex = 38;
            this.labelTen.Text = "label1";
            // 
            // nhaDanBindingSource
            // 
            this.nhaDanBindingSource.DataMember = "FK__NhaDan__IdAp__656C112C";
            this.nhaDanBindingSource.DataSource = this.apBindingSource;
            // 
            // nhaDanTableAdapter
            // 
            this.nhaDanTableAdapter.ClearBeforeFill = true;
            // 
            // labelXa
            // 
            this.labelXa.AutoSize = true;
            this.labelXa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXa.ForeColor = System.Drawing.Color.Red;
            this.labelXa.Location = new System.Drawing.Point(1183, 101);
            this.labelXa.Name = "labelXa";
            this.labelXa.Size = new System.Drawing.Size(41, 16);
            this.labelXa.TabIndex = 39;
            this.labelXa.Text = "label1";
            // 
            // FrmAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1918, 869);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmAp";
            this.Text = "FrmAp";
            this.Load += new System.EventHandler(this.FrmAp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diaBanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaDanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DiaBanDataSet diaBanDataSet;
        private System.Windows.Forms.BindingSource diaBanBindingSource;
        private DiaBanDataSetTableAdapters.DiaBanTableAdapter diaBanTableAdapter;
        private DiaBanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DiaBanDataSetTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource xaBindingSource;
        private DiaBanDataSetTableAdapters.ApTableAdapter apTableAdapter;
        private System.Windows.Forms.BindingSource apBindingSource;
        private DevExpress.XtraEditors.GroupControl groupAction;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnReload;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnGhi;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl xaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl diaBanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private DevExpress.XtraGrid.GridControl apGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTen2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdXa1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit shadow;
        private DevExpress.XtraEditors.TextEdit txtXa;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.BindingSource nhaDanBindingSource;
        private DiaBanDataSetTableAdapters.NhaDanTableAdapter nhaDanTableAdapter;
        private System.Windows.Forms.Label labelXa;
    }
}