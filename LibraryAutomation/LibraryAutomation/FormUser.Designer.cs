namespace LibraryAutomation
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonResetPass = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.textMail = new DevExpress.XtraEditors.TextEdit();
            this.textPhone = new DevExpress.XtraEditors.TextEdit();
            this.textStdNo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStdNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 506);
            this.gridControl1.TabIndex = 999;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonRefresh);
            this.groupControl1.Controls.Add(this.simpleButtonResetPass);
            this.groupControl1.Controls.Add(this.simpleButtonClear);
            this.groupControl1.Controls.Add(this.simpleButtonDelete);
            this.groupControl1.Controls.Add(this.simpleButtonUpdate);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textNameSurname);
            this.groupControl1.Controls.Add(this.textMail);
            this.groupControl1.Controls.Add(this.textPhone);
            this.groupControl1.Controls.Add(this.textStdNo);
            this.groupControl1.Location = new System.Drawing.Point(1050, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(282, 506);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButtonResetPass
            // 
            this.simpleButtonResetPass.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonResetPass.Appearance.Options.UseFont = true;
            this.simpleButtonResetPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonResetPass.ImageOptions.Image")));
            this.simpleButtonResetPass.Location = new System.Drawing.Point(124, 307);
            this.simpleButtonResetPass.Name = "simpleButtonResetPass";
            this.simpleButtonResetPass.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonResetPass.TabIndex = 999;
            this.simpleButtonResetPass.TabStop = false;
            this.simpleButtonResetPass.Text = "PAROLA";
            this.simpleButtonResetPass.Click += new System.EventHandler(this.simpleButtonResetPass_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonClear.Appearance.Options.UseFont = true;
            this.simpleButtonClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonClear.ImageOptions.Image")));
            this.simpleButtonClear.Location = new System.Drawing.Point(124, 266);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonClear.TabIndex = 999;
            this.simpleButtonClear.TabStop = false;
            this.simpleButtonClear.Text = "TEMİZLE";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonDelete.Appearance.Options.UseFont = true;
            this.simpleButtonDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDelete.ImageOptions.Image")));
            this.simpleButtonDelete.Location = new System.Drawing.Point(124, 225);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonDelete.TabIndex = 999;
            this.simpleButtonDelete.TabStop = false;
            this.simpleButtonDelete.Text = "SİL";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonUpdate.Appearance.Options.UseFont = true;
            this.simpleButtonUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUpdate.ImageOptions.Image")));
            this.simpleButtonUpdate.Location = new System.Drawing.Point(124, 184);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonUpdate.TabIndex = 999;
            this.simpleButtonUpdate.TabStop = false;
            this.simpleButtonUpdate.Text = "GÜNCELLE";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSave.Appearance.Options.UseFont = true;
            this.simpleButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSave.ImageOptions.Image")));
            this.simpleButtonSave.Location = new System.Drawing.Point(124, 143);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonSave.TabIndex = 999;
            this.simpleButtonSave.TabStop = false;
            this.simpleButtonSave.Text = "KAYDET";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(37, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 18);
            this.labelControl7.TabIndex = 999;
            this.labelControl7.Text = "AD SOYAD:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 18);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "MAIL:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "TELEFON:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "ÖĞR. NO:";
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(124, 53);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameSurname.Properties.Appearance.Options.UseFont = true;
            this.textNameSurname.Size = new System.Drawing.Size(139, 24);
            this.textNameSurname.TabIndex = 1;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(124, 83);
            this.textMail.Name = "textMail";
            this.textMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMail.Properties.Appearance.Options.UseFont = true;
            this.textMail.Size = new System.Drawing.Size(139, 24);
            this.textMail.TabIndex = 2;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(124, 113);
            this.textPhone.Name = "textPhone";
            this.textPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Properties.Appearance.Options.UseFont = true;
            this.textPhone.Size = new System.Drawing.Size(139, 24);
            this.textPhone.TabIndex = 3;
            // 
            // textStdNo
            // 
            this.textStdNo.Location = new System.Drawing.Point(124, 23);
            this.textStdNo.Name = "textStdNo";
            this.textStdNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStdNo.Properties.Appearance.Options.UseFont = true;
            this.textStdNo.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textStdNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textStdNo.Size = new System.Drawing.Size(139, 24);
            this.textStdNo.TabIndex = 0;
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRefresh.ImageOptions.Image")));
            this.simpleButtonRefresh.Location = new System.Drawing.Point(124, 348);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonRefresh.TabIndex = 999;
            this.simpleButtonRefresh.TabStop = false;
            this.simpleButtonRefresh.Text = "YENİLE";
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStdNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textNameSurname;
        private DevExpress.XtraEditors.TextEdit textMail;
        private DevExpress.XtraEditors.TextEdit textPhone;
        private DevExpress.XtraEditors.TextEdit textStdNo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonResetPass;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefresh;
    }
}