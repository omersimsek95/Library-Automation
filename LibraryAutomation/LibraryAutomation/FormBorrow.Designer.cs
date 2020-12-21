namespace LibraryAutomation
{
    partial class FormBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrow));
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchLookUpStdNo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonLendRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLendGive = new DevExpress.XtraEditors.SimpleButton();
            this.textLendISBN = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStatus = new System.Windows.Forms.NumericUpDown();
            this.textBorrowISBN = new DevExpress.XtraEditors.TextEdit();
            this.textBorrowDueDate = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonBorrowRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBorrowReturn = new DevExpress.XtraEditors.SimpleButton();
            this.textBorrowRecordID = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonRequestRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.textRequestIssueDate = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonRequestIgnore = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRequestAccept = new DevExpress.XtraEditors.SimpleButton();
            this.textRequestISBN = new DevExpress.XtraEditors.TextEdit();
            this.textRequestStdNo = new DevExpress.XtraEditors.TextEdit();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStdNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLendISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowRecordID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRequestIssueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequestISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequestStdNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(13, 13);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(1319, 506);
            this.xtraTabControl2.TabIndex = 999;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6});
            this.xtraTabControl2.TabStop = false;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.groupControl1);
            this.xtraTabPage4.Controls.Add(this.gridControl1);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1317, 462);
            this.xtraTabPage4.Text = "Kitap Ver";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.searchLookUpStdNo);
            this.groupControl1.Controls.Add(this.simpleButtonLendRefresh);
            this.groupControl1.Controls.Add(this.simpleButtonLendGive);
            this.groupControl1.Controls.Add(this.textLendISBN);
            this.groupControl1.Location = new System.Drawing.Point(1025, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(289, 456);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "groupControl1";
            // 
            // searchLookUpStdNo
            // 
            this.searchLookUpStdNo.Location = new System.Drawing.Point(65, 132);
            this.searchLookUpStdNo.Name = "searchLookUpStdNo";
            this.searchLookUpStdNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpStdNo.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpStdNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpStdNo.Properties.NullText = "Öğrenci seçiniz:";
            this.searchLookUpStdNo.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpStdNo.Size = new System.Drawing.Size(189, 26);
            this.searchLookUpStdNo.TabIndex = 999;
            this.searchLookUpStdNo.TabStop = false;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButtonLendRefresh
            // 
            this.simpleButtonLendRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonLendRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonLendRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLendRefresh.ImageOptions.Image")));
            this.simpleButtonLendRefresh.Location = new System.Drawing.Point(65, 285);
            this.simpleButtonLendRefresh.Name = "simpleButtonLendRefresh";
            this.simpleButtonLendRefresh.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonLendRefresh.TabIndex = 999;
            this.simpleButtonLendRefresh.TabStop = false;
            this.simpleButtonLendRefresh.Text = "YENİLE";
            this.simpleButtonLendRefresh.Click += new System.EventHandler(this.simpleButtonLendRefresh_Click);
            // 
            // simpleButtonLendGive
            // 
            this.simpleButtonLendGive.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonLendGive.Appearance.Options.UseFont = true;
            this.simpleButtonLendGive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLendGive.ImageOptions.Image")));
            this.simpleButtonLendGive.Location = new System.Drawing.Point(65, 211);
            this.simpleButtonLendGive.Name = "simpleButtonLendGive";
            this.simpleButtonLendGive.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonLendGive.TabIndex = 999;
            this.simpleButtonLendGive.TabStop = false;
            this.simpleButtonLendGive.Text = "KİTAP VER";
            this.simpleButtonLendGive.Click += new System.EventHandler(this.simpleButtonLendGive_Click);
            // 
            // textLendISBN
            // 
            this.textLendISBN.Location = new System.Drawing.Point(146, 5);
            this.textLendISBN.Name = "textLendISBN";
            this.textLendISBN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLendISBN.Properties.Appearance.Options.UseFont = true;
            this.textLendISBN.Properties.ReadOnly = true;
            this.textLendISBN.Size = new System.Drawing.Size(138, 24);
            this.textLendISBN.TabIndex = 999;
            this.textLendISBN.TabStop = false;
            this.textLendISBN.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1016, 456);
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
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.groupControl2);
            this.xtraTabPage5.Controls.Add(this.gridControl2);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1317, 462);
            this.xtraTabPage5.Text = "Kitap Al";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.numericUpDownStatus);
            this.groupControl2.Controls.Add(this.textBorrowISBN);
            this.groupControl2.Controls.Add(this.textBorrowDueDate);
            this.groupControl2.Controls.Add(this.simpleButtonBorrowRefresh);
            this.groupControl2.Controls.Add(this.simpleButtonBorrowReturn);
            this.groupControl2.Controls.Add(this.textBorrowRecordID);
            this.groupControl2.Location = new System.Drawing.Point(1025, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(289, 456);
            this.groupControl2.TabIndex = 999;
            this.groupControl2.Text = "groupControl2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 999;
            this.label1.Text = "DURUM:";
            // 
            // numericUpDownStatus
            // 
            this.numericUpDownStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStatus.Location = new System.Drawing.Point(137, 132);
            this.numericUpDownStatus.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStatus.Name = "numericUpDownStatus";
            this.numericUpDownStatus.Size = new System.Drawing.Size(117, 27);
            this.numericUpDownStatus.TabIndex = 999;
            this.numericUpDownStatus.TabStop = false;
            // 
            // textBorrowISBN
            // 
            this.textBorrowISBN.Location = new System.Drawing.Point(146, 65);
            this.textBorrowISBN.Name = "textBorrowISBN";
            this.textBorrowISBN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBorrowISBN.Properties.Appearance.Options.UseFont = true;
            this.textBorrowISBN.Properties.ReadOnly = true;
            this.textBorrowISBN.Size = new System.Drawing.Size(138, 24);
            this.textBorrowISBN.TabIndex = 999;
            this.textBorrowISBN.TabStop = false;
            this.textBorrowISBN.Visible = false;
            // 
            // textBorrowDueDate
            // 
            this.textBorrowDueDate.Location = new System.Drawing.Point(146, 35);
            this.textBorrowDueDate.Name = "textBorrowDueDate";
            this.textBorrowDueDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBorrowDueDate.Properties.Appearance.Options.UseFont = true;
            this.textBorrowDueDate.Properties.ReadOnly = true;
            this.textBorrowDueDate.Size = new System.Drawing.Size(138, 24);
            this.textBorrowDueDate.TabIndex = 999;
            this.textBorrowDueDate.TabStop = false;
            this.textBorrowDueDate.Visible = false;
            // 
            // simpleButtonBorrowRefresh
            // 
            this.simpleButtonBorrowRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonBorrowRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonBorrowRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBorrowRefresh.ImageOptions.Image")));
            this.simpleButtonBorrowRefresh.Location = new System.Drawing.Point(65, 285);
            this.simpleButtonBorrowRefresh.Name = "simpleButtonBorrowRefresh";
            this.simpleButtonBorrowRefresh.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonBorrowRefresh.TabIndex = 999;
            this.simpleButtonBorrowRefresh.TabStop = false;
            this.simpleButtonBorrowRefresh.Text = "YENİLE";
            this.simpleButtonBorrowRefresh.Click += new System.EventHandler(this.simpleButtonBorrowRefresh_Click);
            // 
            // simpleButtonBorrowReturn
            // 
            this.simpleButtonBorrowReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonBorrowReturn.Appearance.Options.UseFont = true;
            this.simpleButtonBorrowReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBorrowReturn.ImageOptions.Image")));
            this.simpleButtonBorrowReturn.Location = new System.Drawing.Point(65, 211);
            this.simpleButtonBorrowReturn.Name = "simpleButtonBorrowReturn";
            this.simpleButtonBorrowReturn.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonBorrowReturn.TabIndex = 999;
            this.simpleButtonBorrowReturn.TabStop = false;
            this.simpleButtonBorrowReturn.Text = "ONAYLA";
            this.simpleButtonBorrowReturn.Click += new System.EventHandler(this.simpleButtonBorrowReturn_Click);
            // 
            // textBorrowRecordID
            // 
            this.textBorrowRecordID.Location = new System.Drawing.Point(146, 5);
            this.textBorrowRecordID.Name = "textBorrowRecordID";
            this.textBorrowRecordID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBorrowRecordID.Properties.Appearance.Options.UseFont = true;
            this.textBorrowRecordID.Properties.ReadOnly = true;
            this.textBorrowRecordID.Size = new System.Drawing.Size(138, 24);
            this.textBorrowRecordID.TabIndex = 999;
            this.textBorrowRecordID.TabStop = false;
            this.textBorrowRecordID.Visible = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1016, 456);
            this.gridControl2.TabIndex = 999;
            this.gridControl2.TabStop = false;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.groupControl3);
            this.xtraTabPage6.Controls.Add(this.gridControl3);
            this.xtraTabPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage6.ImageOptions.Image")));
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(1317, 462);
            this.xtraTabPage6.Text = "İstekler";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButtonRequestRefresh);
            this.groupControl3.Controls.Add(this.textRequestIssueDate);
            this.groupControl3.Controls.Add(this.simpleButtonRequestIgnore);
            this.groupControl3.Controls.Add(this.simpleButtonRequestAccept);
            this.groupControl3.Controls.Add(this.textRequestISBN);
            this.groupControl3.Controls.Add(this.textRequestStdNo);
            this.groupControl3.Location = new System.Drawing.Point(1025, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(289, 456);
            this.groupControl3.TabIndex = 999;
            this.groupControl3.Text = "groupControl3";
            // 
            // simpleButtonRequestRefresh
            // 
            this.simpleButtonRequestRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRequestRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonRequestRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRequestRefresh.ImageOptions.Image")));
            this.simpleButtonRequestRefresh.Location = new System.Drawing.Point(65, 285);
            this.simpleButtonRequestRefresh.Name = "simpleButtonRequestRefresh";
            this.simpleButtonRequestRefresh.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonRequestRefresh.TabIndex = 999;
            this.simpleButtonRequestRefresh.TabStop = false;
            this.simpleButtonRequestRefresh.Text = "YENİLE";
            this.simpleButtonRequestRefresh.Click += new System.EventHandler(this.simpleButtonRequestRefresh_Click);
            // 
            // textRequestIssueDate
            // 
            this.textRequestIssueDate.Location = new System.Drawing.Point(146, 5);
            this.textRequestIssueDate.Name = "textRequestIssueDate";
            this.textRequestIssueDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRequestIssueDate.Properties.Appearance.Options.UseFont = true;
            this.textRequestIssueDate.Properties.ReadOnly = true;
            this.textRequestIssueDate.Size = new System.Drawing.Size(138, 24);
            this.textRequestIssueDate.TabIndex = 999;
            this.textRequestIssueDate.TabStop = false;
            this.textRequestIssueDate.Visible = false;
            // 
            // simpleButtonRequestIgnore
            // 
            this.simpleButtonRequestIgnore.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRequestIgnore.Appearance.Options.UseFont = true;
            this.simpleButtonRequestIgnore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRequestIgnore.ImageOptions.Image")));
            this.simpleButtonRequestIgnore.Location = new System.Drawing.Point(65, 211);
            this.simpleButtonRequestIgnore.Name = "simpleButtonRequestIgnore";
            this.simpleButtonRequestIgnore.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonRequestIgnore.TabIndex = 999;
            this.simpleButtonRequestIgnore.TabStop = false;
            this.simpleButtonRequestIgnore.Text = "REDDET";
            this.simpleButtonRequestIgnore.Click += new System.EventHandler(this.simpleButtonRequestIgnore_Click);
            // 
            // simpleButtonRequestAccept
            // 
            this.simpleButtonRequestAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRequestAccept.Appearance.Options.UseFont = true;
            this.simpleButtonRequestAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRequestAccept.ImageOptions.Image")));
            this.simpleButtonRequestAccept.Location = new System.Drawing.Point(65, 134);
            this.simpleButtonRequestAccept.Name = "simpleButtonRequestAccept";
            this.simpleButtonRequestAccept.Size = new System.Drawing.Size(189, 47);
            this.simpleButtonRequestAccept.TabIndex = 999;
            this.simpleButtonRequestAccept.TabStop = false;
            this.simpleButtonRequestAccept.Text = "ONAYLA";
            this.simpleButtonRequestAccept.Click += new System.EventHandler(this.simpleButtonRequestAccept_Click);
            // 
            // textRequestISBN
            // 
            this.textRequestISBN.Location = new System.Drawing.Point(146, 65);
            this.textRequestISBN.Name = "textRequestISBN";
            this.textRequestISBN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRequestISBN.Properties.Appearance.Options.UseFont = true;
            this.textRequestISBN.Properties.ReadOnly = true;
            this.textRequestISBN.Size = new System.Drawing.Size(138, 24);
            this.textRequestISBN.TabIndex = 999;
            this.textRequestISBN.TabStop = false;
            this.textRequestISBN.Visible = false;
            // 
            // textRequestStdNo
            // 
            this.textRequestStdNo.Location = new System.Drawing.Point(146, 35);
            this.textRequestStdNo.Name = "textRequestStdNo";
            this.textRequestStdNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRequestStdNo.Properties.Appearance.Options.UseFont = true;
            this.textRequestStdNo.Properties.ReadOnly = true;
            this.textRequestStdNo.Size = new System.Drawing.Size(138, 24);
            this.textRequestStdNo.TabIndex = 999;
            this.textRequestStdNo.TabStop = false;
            this.textRequestStdNo.Visible = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(3, 3);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1016, 456);
            this.gridControl3.TabIndex = 999;
            this.gridControl3.TabStop = false;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // FormBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.xtraTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBorrow";
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.FormBarrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpStdNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLendISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBorrowRecordID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textRequestIssueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequestISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRequestStdNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textRequestISBN;
        private DevExpress.XtraEditors.TextEdit textRequestStdNo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRequestAccept;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRequestIgnore;
        private DevExpress.XtraEditors.TextEdit textRequestIssueDate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRequestRefresh;
        private DevExpress.XtraEditors.TextEdit textBorrowRecordID;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBorrowRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBorrowReturn;
        private DevExpress.XtraEditors.TextEdit textBorrowDueDate;
        private DevExpress.XtraEditors.TextEdit textBorrowISBN;
        private DevExpress.XtraEditors.TextEdit textLendISBN;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLendGive;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLendRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStatus;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpStdNo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}