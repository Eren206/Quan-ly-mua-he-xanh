
namespace QLMHX
{
    partial class frmThemCVChoAp
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
            System.Windows.Forms.Label ngayBDLabel;
            System.Windows.Forms.Label ngayKTLabel;
            this.deNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.deNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.cmbAp = new System.Windows.Forms.ComboBox();
            this.apBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSthemCVchoAp = new QLMHX.DSthemCVchoAp();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCV = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.apTableAdapter = new QLMHX.DSthemCVchoApTableAdapters.ApTableAdapter();
            this.tableAdapterManager1 = new QLMHX.DSthemCVchoApTableAdapters.TableAdapterManager();
            ngayBDLabel = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSthemCVchoAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Location = new System.Drawing.Point(48, 215);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(76, 20);
            ngayBDLabel.TabIndex = 1;
            ngayBDLabel.Text = "Ngay BD:";
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Location = new System.Drawing.Point(387, 215);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(72, 20);
            ngayKTLabel.TabIndex = 2;
            ngayKTLabel.Text = "Ngay KT:";
            // 
            // deNgayBD
            // 
            this.deNgayBD.EditValue = null;
            this.deNgayBD.Location = new System.Drawing.Point(130, 212);
            this.deNgayBD.Name = "deNgayBD";
            this.deNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBD.Size = new System.Drawing.Size(181, 28);
            this.deNgayBD.TabIndex = 2;
            // 
            // deNgayKT
            // 
            this.deNgayKT.EditValue = null;
            this.deNgayKT.Location = new System.Drawing.Point(465, 212);
            this.deNgayKT.Name = "deNgayKT";
            this.deNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKT.Size = new System.Drawing.Size(192, 28);
            this.deNgayKT.TabIndex = 3;
            // 
            // cmbAp
            // 
            this.cmbAp.DataSource = this.apBindingSource;
            this.cmbAp.DisplayMember = "Ten";
            this.cmbAp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAp.FormattingEnabled = true;
            this.cmbAp.Location = new System.Drawing.Point(214, 131);
            this.cmbAp.Name = "cmbAp";
            this.cmbAp.Size = new System.Drawing.Size(199, 28);
            this.cmbAp.TabIndex = 5;
            this.cmbAp.ValueMember = "idap";
            // 
            // apBindingSource
            // 
            this.apBindingSource.DataMember = "Ap";
            this.apBindingSource.DataSource = this.dSthemCVchoAp;
            // 
            // dSthemCVchoAp
            // 
            this.dSthemCVchoAp.DataSetName = "DSthemCVchoAp";
            this.dSthemCVchoAp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn ấp:";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(214, 48);
            this.txtCV.Name = "txtCV";
            this.txtCV.Properties.ReadOnly = true;
            this.txtCV.Size = new System.Drawing.Size(199, 28);
            this.txtCV.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(485, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CongViecTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CTCVTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLMHX.DSthemCVchoApTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmThemCVChoAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAp);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(this.deNgayKT);
            this.Controls.Add(ngayBDLabel);
            this.Controls.Add(this.deNgayBD);
            this.Name = "frmThemCVChoAp";
            this.Text = "frmThemCVChoAp";
            this.Load += new System.EventHandler(this.frmThemCVChoAp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSthemCVchoAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit deNgayBD;
        private DevExpress.XtraEditors.DateEdit deNgayKT;
        private System.Windows.Forms.ComboBox cmbAp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtCV;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DSthemCVchoAp dSthemCVchoAp;
        private System.Windows.Forms.BindingSource apBindingSource;
        private DSthemCVchoApTableAdapters.ApTableAdapter apTableAdapter;
        private DSthemCVchoApTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}