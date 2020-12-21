namespace LibraryAutomation
{
    partial class FormHomePage
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView2 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.chartMaxDue = new DevExpress.XtraCharts.ChartControl();
            this.chartMaxHistory = new DevExpress.XtraCharts.ChartControl();
            this.chartCountCategory = new DevExpress.XtraCharts.ChartControl();
            this.chartMaxBorrow = new DevExpress.XtraCharts.ChartControl();
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMaxDue
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMaxDue.Diagram = xyDiagram1;
            this.chartMaxDue.Legend.Name = "Default Legend";
            this.chartMaxDue.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartMaxDue.Location = new System.Drawing.Point(13, 13);
            this.chartMaxDue.Name = "chartMaxDue";
            series1.Name = "Series 1";
            this.chartMaxDue.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartMaxDue.Size = new System.Drawing.Size(640, 236);
            this.chartMaxDue.TabIndex = 999;
            this.chartMaxDue.TabStop = false;
            chartTitle1.Text = "En Çok Ceza Yiyenler (TOP 10)";
            this.chartMaxDue.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // chartMaxHistory
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMaxHistory.Diagram = xyDiagram2;
            this.chartMaxHistory.Legend.Name = "Default Legend";
            this.chartMaxHistory.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartMaxHistory.Location = new System.Drawing.Point(13, 283);
            this.chartMaxHistory.Name = "chartMaxHistory";
            series2.Name = "Series 1";
            this.chartMaxHistory.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartMaxHistory.Size = new System.Drawing.Size(640, 236);
            this.chartMaxHistory.TabIndex = 999;
            this.chartMaxHistory.TabStop = false;
            chartTitle2.Text = "En Çok Kitap Geçmişi Olanlar (TOP 10)";
            this.chartMaxHistory.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // chartCountCategory
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            simpleDiagram3D1.ZoomPercent = 150;
            this.chartCountCategory.Diagram = simpleDiagram3D1;
            this.chartCountCategory.Legend.Name = "Default Legend";
            this.chartCountCategory.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartCountCategory.Location = new System.Drawing.Point(692, 13);
            this.chartCountCategory.Name = "chartCountCategory";
            series3.LegendTextPattern = "{A}";
            series3.Name = "Series 1";
            series3.View = doughnut3DSeriesView1;
            this.chartCountCategory.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartCountCategory.Size = new System.Drawing.Size(640, 236);
            this.chartCountCategory.TabIndex = 999;
            this.chartCountCategory.TabStop = false;
            chartTitle3.Text = "En Çok Kitap Çeşitliliği Olan Kategoriler (TOP 10)";
            this.chartCountCategory.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // chartMaxBorrow
            // 
            simpleDiagram3D2.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            simpleDiagram3D2.ZoomPercent = 150;
            this.chartMaxBorrow.Diagram = simpleDiagram3D2;
            this.chartMaxBorrow.Legend.Name = "Default Legend";
            this.chartMaxBorrow.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartMaxBorrow.Location = new System.Drawing.Point(692, 283);
            this.chartMaxBorrow.Name = "chartMaxBorrow";
            series4.LegendTextPattern = "{A}";
            series4.Name = "Series 1";
            series4.View = doughnut3DSeriesView2;
            this.chartMaxBorrow.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartMaxBorrow.Size = new System.Drawing.Size(640, 236);
            this.chartMaxBorrow.TabIndex = 999;
            this.chartMaxBorrow.TabStop = false;
            chartTitle4.Text = "En Çok Alınıp Verilen Kitaplar (TOP 10)";
            this.chartMaxBorrow.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRefresh.ImageOptions.Image")));
            this.simpleButtonRefresh.Location = new System.Drawing.Point(655, 248);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.Size = new System.Drawing.Size(35, 35);
            this.simpleButtonRefresh.TabIndex = 999;
            this.simpleButtonRefresh.TabStop = false;
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.simpleButtonRefresh);
            this.Controls.Add(this.chartMaxBorrow);
            this.Controls.Add(this.chartCountCategory);
            this.Controls.Add(this.chartMaxHistory);
            this.Controls.Add(this.chartMaxDue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomePage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartMaxDue;
        private DevExpress.XtraCharts.ChartControl chartMaxHistory;
        private DevExpress.XtraCharts.ChartControl chartCountCategory;
        private DevExpress.XtraCharts.ChartControl chartMaxBorrow;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefresh;
    }
}