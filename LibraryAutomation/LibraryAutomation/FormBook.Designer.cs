namespace LibraryAutomation
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.textPublisher = new DevExpress.XtraEditors.TextEdit();
            this.textYear = new DevExpress.XtraEditors.TextEdit();
            this.textISBN = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.numericUpDownStatus = new System.Windows.Forms.NumericUpDown();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.numericUpDownAvailability = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textAuthor = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonClear.Appearance.Options.UseFont = true;
            this.simpleButtonClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonClear.ImageOptions.Image")));
            this.simpleButtonClear.Location = new System.Drawing.Point(124, 387);
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
            this.simpleButtonDelete.Location = new System.Drawing.Point(124, 346);
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
            this.simpleButtonUpdate.Location = new System.Drawing.Point(124, 305);
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
            this.simpleButtonSave.Location = new System.Drawing.Point(124, 264);
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
            this.labelControl7.Text = "KİTAP ADI:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(37, 86);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 18);
            this.labelControl6.TabIndex = 999;
            this.labelControl6.Text = "YAYINEVİ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 146);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 18);
            this.labelControl5.TabIndex = 999;
            this.labelControl5.Text = "YIL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 18);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "STOK:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "ISBN:";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(124, 53);
            this.textTitle.Name = "textTitle";
            this.textTitle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Properties.Appearance.Options.UseFont = true;
            this.textTitle.Size = new System.Drawing.Size(139, 24);
            this.textTitle.TabIndex = 1;
            // 
            // textPublisher
            // 
            this.textPublisher.Location = new System.Drawing.Point(124, 83);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPublisher.Properties.Appearance.Options.UseFont = true;
            this.textPublisher.Size = new System.Drawing.Size(139, 24);
            this.textPublisher.TabIndex = 2;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(124, 143);
            this.textYear.Name = "textYear";
            this.textYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYear.Properties.Appearance.Options.UseFont = true;
            this.textYear.Size = new System.Drawing.Size(139, 24);
            this.textYear.TabIndex = 4;
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(124, 23);
            this.textISBN.Name = "textISBN";
            this.textISBN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textISBN.Properties.Appearance.Options.UseFont = true;
            this.textISBN.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textISBN.Size = new System.Drawing.Size(139, 24);
            this.textISBN.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonRefresh);
            this.groupControl1.Controls.Add(this.numericUpDownStatus);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.comboBoxCategory);
            this.groupControl1.Controls.Add(this.numericUpDownAvailability);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textAuthor);
            this.groupControl1.Controls.Add(this.simpleButtonClear);
            this.groupControl1.Controls.Add(this.simpleButtonDelete);
            this.groupControl1.Controls.Add(this.simpleButtonUpdate);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textTitle);
            this.groupControl1.Controls.Add(this.textPublisher);
            this.groupControl1.Controls.Add(this.textYear);
            this.groupControl1.Controls.Add(this.textISBN);
            this.groupControl1.Location = new System.Drawing.Point(1050, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(282, 506);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRefresh.ImageOptions.Image")));
            this.simpleButtonRefresh.Location = new System.Drawing.Point(124, 428);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.Size = new System.Drawing.Size(139, 35);
            this.simpleButtonRefresh.TabIndex = 999;
            this.simpleButtonRefresh.TabStop = false;
            this.simpleButtonRefresh.Text = "YENİLE";
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // numericUpDownStatus
            // 
            this.numericUpDownStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStatus.Location = new System.Drawing.Point(124, 173);
            this.numericUpDownStatus.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStatus.Name = "numericUpDownStatus";
            this.numericUpDownStatus.Size = new System.Drawing.Size(139, 26);
            this.numericUpDownStatus.TabIndex = 5;
            this.numericUpDownStatus.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(37, 175);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 18);
            this.labelControl8.TabIndex = 999;
            this.labelControl8.Text = "DURUM:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "KATEGORİ:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.EditValue = "";
            this.comboBoxCategory.Location = new System.Drawing.Point(124, 113);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.Properties.Appearance.Options.UseFont = true;
            this.comboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxCategory.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // numericUpDownAvailability
            // 
            this.numericUpDownAvailability.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAvailability.Location = new System.Drawing.Point(124, 205);
            this.numericUpDownAvailability.Name = "numericUpDownAvailability";
            this.numericUpDownAvailability.Size = new System.Drawing.Size(139, 26);
            this.numericUpDownAvailability.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 237);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "YAZAR:";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(124, 234);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAuthor.Properties.Appearance.Options.UseFont = true;
            this.textAuthor.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textAuthor.Size = new System.Drawing.Size(139, 24);
            this.textAuthor.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 506);
            this.gridControl1.TabIndex = 999;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBook";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textTitle;
        private DevExpress.XtraEditors.TextEdit textPublisher;
        private DevExpress.XtraEditors.TextEdit textYear;
        private DevExpress.XtraEditors.TextEdit textISBN;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownAvailability;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownStatus;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefresh;
    }
}