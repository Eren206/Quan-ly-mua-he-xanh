namespace QLMHX
{
    partial class FrmXa
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
            System.Windows.Forms.Label idXaLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label idDBLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXa));
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xaGridControl = new DevExpress.XtraGrid.GridControl();
            this.xaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaBanDataSet = new QLMHX.DiaBanDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.xaTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.XaTableAdapter();
            this.tableAdapterManager = new QLMHX.DiaBanDataSetTableAdapters.TableAdapterManager();
            this.apTableAdapter = new QLMHX.DiaBanDataSetTableAdapters.ApTableAdapter();
            this.apBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idXaLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            idDBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idXaLabel
            // 
            idXaLabel.AutoSize = true;
            idXaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idXaLabel.Location = new System.Drawing.Point(161, 64);
            idXaLabel.Name = "idXaLabel";
            idXaLabel.Size = new System.Drawing.Size(55, 21);
            idXaLabel.TabIndex = 8;
            idXaLabel.Text = "Id Xa:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(454, 61);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(44, 21);
            tenLabel.TabIndex = 9;
            tenLabel.Text = "Ten:";
            // 
            // idDBLabel
            // 
            idDBLabel.AutoSize = true;
            idDBLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDBLabel.Location = new System.Drawing.Point(868, 61);
            idDBLabel.Name = "idDBLabel";
            idDBLabel.Size = new System.Drawing.Size(58, 21);
            idDBLabel.TabIndex = 10;
            idDBLabel.Text = "Id DB:";
            // 
            // groupAction
            // 
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
            this.groupAction.TabIndex = 13;
            this.groupAction.Text = "Action";
            // 
            // BtnReload
            // 
            this.BtnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnReload.ImageOptions.SvgImage")));
            this.BtnReload.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnReload.Location = new System.Drawing.Point(404, 31);
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
            this.BtnUndo.Location = new System.Drawing.Point(304, 31);
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
            this.BtnGhi.Location = new System.Drawing.Point(204, 31);
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
            this.groupControl1.Controls.Add(this.xaGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1918, 349);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Data";
            // 
            // xaGridControl
            // 
            this.xaGridControl.DataSource = this.xaBindingSource;
            this.xaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xaGridControl.Location = new System.Drawing.Point(2, 28);
            this.xaGridControl.MainView = this.gridView1;
            this.xaGridControl.Name = "xaGridControl";
            this.xaGridControl.Size = new System.Drawing.Size(1914, 319);
            this.xaGridControl.TabIndex = 0;
            this.xaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xaBindingSource
            // 
            this.xaBindingSource.DataMember = "Xa";
            this.xaBindingSource.DataSource = this.diaBanDataSet;
            // 
            // diaBanDataSet
            // 
            this.diaBanDataSet.DataSetName = "DiaBanDataSet";
            this.diaBanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdXa,
            this.colTen,
            this.colIdDB});
            this.gridView1.GridControl = this.xaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIdXa
            // 
            this.colIdXa.FieldName = "IdXa";
            this.colIdXa.MinWidth = 25;
            this.colIdXa.Name = "colIdXa";
            this.colIdXa.Visible = true;
            this.colIdXa.VisibleIndex = 0;
            this.colIdXa.Width = 193;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 1239;
            // 
            // colIdDB
            // 
            this.colIdDB.FieldName = "IdDB";
            this.colIdDB.MinWidth = 25;
            this.colIdDB.Name = "colIdDB";
            this.colIdDB.Visible = true;
            this.colIdDB.VisibleIndex = 2;
            this.colIdDB.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.comboBox2);
            this.groupControl2.Controls.Add(idDBLabel);
            this.groupControl2.Controls.Add(this.txtDiaBan);
            this.groupControl2.Controls.Add(tenLabel);
            this.groupControl2.Controls.Add(this.txtTen);
            this.groupControl2.Controls.Add(idXaLabel);
            this.groupControl2.Controls.Add(this.txtId);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.comboBox1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Enabled = false;
            this.groupControl2.Location = new System.Drawing.Point(0, 418);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1918, 442);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Input";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(458, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(296, 32);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtDiaBan
            // 
            this.txtDiaBan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xaBindingSource, "IdDB", true));
            this.txtDiaBan.Enabled = false;
            this.txtDiaBan.Location = new System.Drawing.Point(872, 85);
            this.txtDiaBan.Name = "txtDiaBan";
            this.txtDiaBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtDiaBan.Size = new System.Drawing.Size(125, 30);
            this.txtDiaBan.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xaBindingSource, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(458, 87);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(296, 30);
            this.txtTen.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xaBindingSource, "IdXa", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(165, 85);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(101, 30);
            this.txtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quận, Huyện";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = this.apTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiaBanTableAdapter = null;
            this.tableAdapterManager.NhaDanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.DiaBanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // apBindingSource
            // 
            this.apBindingSource.DataMember = "FK__Ap__IdXa__619B8048";
            this.apBindingSource.DataSource = this.xaBindingSource;
            // 
            // FrmXa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 860);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmXa";
            this.Text = "FrmXa";
            this.Load += new System.EventHandler(this.FrmXa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupAction;
        private DevExpress.XtraEditors.SimpleButton BtnReload;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnGhi;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DiaBanDataSet diaBanDataSet;
        private System.Windows.Forms.BindingSource xaBindingSource;
        private DiaBanDataSetTableAdapters.XaTableAdapter xaTableAdapter;
        private DiaBanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl xaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdXa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDB;
        private DiaBanDataSetTableAdapters.ApTableAdapter apTableAdapter;
        private System.Windows.Forms.BindingSource apBindingSource;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtDiaBan;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}