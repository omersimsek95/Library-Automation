namespace LibraryAutomation
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBook = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSetting = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonManage = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonHomePage,
            this.barButtonUser,
            this.barButtonBook,
            this.barButtonBorrow,
            this.barButtonSetting,
            this.barButtonManage});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1344, 150);
            // 
            // barButtonHomePage
            // 
            this.barButtonHomePage.Caption = "ANA SAYFA";
            this.barButtonHomePage.Id = 1;
            this.barButtonHomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonHomePage.ImageOptions.Image")));
            this.barButtonHomePage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonHomePage.ImageOptions.LargeImage")));
            this.barButtonHomePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonHomePage.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonHomePage.Name = "barButtonHomePage";
            this.barButtonHomePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHomePage_ItemClick);
            // 
            // barButtonUser
            // 
            this.barButtonUser.Caption = "ÜYELER";
            this.barButtonUser.Id = 2;
            this.barButtonUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonUser.ImageOptions.Image")));
            this.barButtonUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonUser.ImageOptions.LargeImage")));
            this.barButtonUser.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonUser.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonUser.Name = "barButtonUser";
            this.barButtonUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUser_ItemClick);
            // 
            // barButtonBook
            // 
            this.barButtonBook.Caption = "KİTAPLAR";
            this.barButtonBook.Id = 3;
            this.barButtonBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonBook.ImageOptions.Image")));
            this.barButtonBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonBook.ImageOptions.LargeImage")));
            this.barButtonBook.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonBook.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonBook.Name = "barButtonBook";
            this.barButtonBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBook_ItemClick);
            // 
            // barButtonBorrow
            // 
            this.barButtonBorrow.Caption = "EMANETLER";
            this.barButtonBorrow.Id = 4;
            this.barButtonBorrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonBorrow.ImageOptions.Image")));
            this.barButtonBorrow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonBorrow.ImageOptions.LargeImage")));
            this.barButtonBorrow.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonBorrow.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonBorrow.Name = "barButtonBorrow";
            this.barButtonBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBorrow_ItemClick);
            // 
            // barButtonSetting
            // 
            this.barButtonSetting.Caption = "AYARLAR";
            this.barButtonSetting.Id = 5;
            this.barButtonSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSetting.ImageOptions.Image")));
            this.barButtonSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSetting.ImageOptions.LargeImage")));
            this.barButtonSetting.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonSetting.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonSetting.Name = "barButtonSetting";
            this.barButtonSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSetting_ItemClick);
            // 
            // barButtonManage
            // 
            this.barButtonManage.Caption = "YÖNETİM";
            this.barButtonManage.Id = 6;
            this.barButtonManage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonManage.ImageOptions.Image")));
            this.barButtonManage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonManage.ImageOptions.LargeImage")));
            this.barButtonManage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonManage.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonManage.Name = "barButtonManage";
            this.barButtonManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonManage_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphane Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonBook);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonBorrow);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonManage);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Seçenekler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonHomePage;
        private DevExpress.XtraBars.BarButtonItem barButtonUser;
        private DevExpress.XtraBars.BarButtonItem barButtonBook;
        private DevExpress.XtraBars.BarButtonItem barButtonBorrow;
        private DevExpress.XtraBars.BarButtonItem barButtonSetting;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonManage;
    }
}

