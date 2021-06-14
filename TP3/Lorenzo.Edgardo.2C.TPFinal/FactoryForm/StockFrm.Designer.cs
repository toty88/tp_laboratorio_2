
namespace FactoryForm
{
    partial class StockFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadKeyboardStock = new FontAwesome.Sharp.IconButton();
            this.btnLoadNotebookStock = new FontAwesome.Sharp.IconButton();
            this.btnLoadAll = new FontAwesome.Sharp.IconButton();
            this.picBStockFrm = new System.Windows.Forms.PictureBox();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBStockFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStock
            // 
            this.chartStock.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea1);
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(0, 0);
            this.chartStock.Name = "chartStock";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.chartStock.Series.Add(series1);
            this.chartStock.Size = new System.Drawing.Size(471, 425);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // btnLoadKeyboardStock
            // 
            this.btnLoadKeyboardStock.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.btnLoadKeyboardStock.IconColor = System.Drawing.Color.Black;
            this.btnLoadKeyboardStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadKeyboardStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadKeyboardStock.Location = new System.Drawing.Point(477, 12);
            this.btnLoadKeyboardStock.Name = "btnLoadKeyboardStock";
            this.btnLoadKeyboardStock.Size = new System.Drawing.Size(144, 68);
            this.btnLoadKeyboardStock.TabIndex = 6;
            this.btnLoadKeyboardStock.Text = "Add Stock";
            this.btnLoadKeyboardStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadKeyboardStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadKeyboardStock.UseVisualStyleBackColor = true;
            this.btnLoadKeyboardStock.Click += new System.EventHandler(this.btnLoadKeyboardStock_Click);
            // 
            // btnLoadNotebookStock
            // 
            this.btnLoadNotebookStock.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnLoadNotebookStock.IconColor = System.Drawing.Color.Black;
            this.btnLoadNotebookStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadNotebookStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadNotebookStock.Location = new System.Drawing.Point(477, 86);
            this.btnLoadNotebookStock.Name = "btnLoadNotebookStock";
            this.btnLoadNotebookStock.Size = new System.Drawing.Size(144, 68);
            this.btnLoadNotebookStock.TabIndex = 7;
            this.btnLoadNotebookStock.Text = "Add Stock";
            this.btnLoadNotebookStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadNotebookStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadNotebookStock.UseVisualStyleBackColor = true;
            this.btnLoadNotebookStock.Click += new System.EventHandler(this.btnLoadNotebookStock_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnLoadAll.IconColor = System.Drawing.Color.Black;
            this.btnLoadAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadAll.Location = new System.Drawing.Point(477, 160);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(144, 68);
            this.btnLoadAll.TabIndex = 8;
            this.btnLoadAll.Text = "Add All Stock";
            this.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // picBStockFrm
            // 
            this.picBStockFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBStockFrm.Location = new System.Drawing.Point(0, 0);
            this.picBStockFrm.Name = "picBStockFrm";
            this.picBStockFrm.Size = new System.Drawing.Size(633, 425);
            this.picBStockFrm.TabIndex = 9;
            this.picBStockFrm.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(477, 234);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 64);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StockFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartStock);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnLoadNotebookStock);
            this.Controls.Add(this.btnLoadKeyboardStock);
            this.Controls.Add(this.picBStockFrm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 464);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(649, 464);
            this.Name = "StockFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Information";
            this.Load += new System.EventHandler(this.StockFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBStockFrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private FontAwesome.Sharp.IconButton btnLoadKeyboardStock;
        private FontAwesome.Sharp.IconButton btnLoadNotebookStock;
        private FontAwesome.Sharp.IconButton btnLoadAll;
        private System.Windows.Forms.PictureBox picBStockFrm;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}