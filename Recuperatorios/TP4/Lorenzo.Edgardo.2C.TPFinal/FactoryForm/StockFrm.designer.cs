
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
            this.picBStockFrm = new System.Windows.Forms.PictureBox();
            this.btnVolerMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAgregarStockInsumosTeclados = new System.Windows.Forms.Button();
            this.btnAgregarStockInsumosNotebooks = new System.Windows.Forms.Button();
            this.btnAgregarStockInsumosProductos = new System.Windows.Forms.Button();
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
            // picBStockFrm
            // 
            this.picBStockFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBStockFrm.Location = new System.Drawing.Point(0, 0);
            this.picBStockFrm.Name = "picBStockFrm";
            this.picBStockFrm.Size = new System.Drawing.Size(633, 425);
            this.picBStockFrm.TabIndex = 9;
            this.picBStockFrm.TabStop = false;
            // 
            // btnVolerMenuPrincipal
            // 
            this.btnVolerMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolerMenuPrincipal.Location = new System.Drawing.Point(477, 214);
            this.btnVolerMenuPrincipal.Name = "btnVolerMenuPrincipal";
            this.btnVolerMenuPrincipal.Size = new System.Drawing.Size(144, 58);
            this.btnVolerMenuPrincipal.TabIndex = 37;
            this.btnVolerMenuPrincipal.Text = "Volver al Menu Principal";
            this.btnVolerMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolerMenuPrincipal.Click += new System.EventHandler(this.btnVolerMenuPrincipal_Click);
            // 
            // btnAgregarStockInsumosTeclados
            // 
            this.btnAgregarStockInsumosTeclados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarStockInsumosTeclados.Location = new System.Drawing.Point(477, 22);
            this.btnAgregarStockInsumosTeclados.Name = "btnAgregarStockInsumosTeclados";
            this.btnAgregarStockInsumosTeclados.Size = new System.Drawing.Size(144, 58);
            this.btnAgregarStockInsumosTeclados.TabIndex = 38;
            this.btnAgregarStockInsumosTeclados.Text = "Agregar Insumos para Teclados";
            this.btnAgregarStockInsumosTeclados.UseVisualStyleBackColor = true;
            this.btnAgregarStockInsumosTeclados.Click += new System.EventHandler(this.btnAgregarStockInsumosTeclados_Click);
            // 
            // btnAgregarStockInsumosNotebooks
            // 
            this.btnAgregarStockInsumosNotebooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarStockInsumosNotebooks.Location = new System.Drawing.Point(477, 86);
            this.btnAgregarStockInsumosNotebooks.Name = "btnAgregarStockInsumosNotebooks";
            this.btnAgregarStockInsumosNotebooks.Size = new System.Drawing.Size(144, 58);
            this.btnAgregarStockInsumosNotebooks.TabIndex = 39;
            this.btnAgregarStockInsumosNotebooks.Text = "Agregar Insumos para Notebooks";
            this.btnAgregarStockInsumosNotebooks.UseVisualStyleBackColor = true;
            this.btnAgregarStockInsumosNotebooks.Click += new System.EventHandler(this.btnAgregarStockInsumosNotebooks_Click);
            // 
            // btnAgregarStockInsumosProductos
            // 
            this.btnAgregarStockInsumosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarStockInsumosProductos.Location = new System.Drawing.Point(477, 150);
            this.btnAgregarStockInsumosProductos.Name = "btnAgregarStockInsumosProductos";
            this.btnAgregarStockInsumosProductos.Size = new System.Drawing.Size(144, 58);
            this.btnAgregarStockInsumosProductos.TabIndex = 40;
            this.btnAgregarStockInsumosProductos.Text = "Agregar Insumos para todos los Productos";
            this.btnAgregarStockInsumosProductos.UseVisualStyleBackColor = true;
            this.btnAgregarStockInsumosProductos.Click += new System.EventHandler(this.btnAgregarStockInsumosProductos_Click);
            // 
            // StockFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.btnAgregarStockInsumosProductos);
            this.Controls.Add(this.btnAgregarStockInsumosNotebooks);
            this.Controls.Add(this.btnAgregarStockInsumosTeclados);
            this.Controls.Add(this.btnVolerMenuPrincipal);
            this.Controls.Add(this.chartStock);
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
        private System.Windows.Forms.PictureBox picBStockFrm;
        private System.Windows.Forms.Button btnVolerMenuPrincipal;
        private System.Windows.Forms.Button btnAgregarStockInsumosTeclados;
        private System.Windows.Forms.Button btnAgregarStockInsumosNotebooks;
        private System.Windows.Forms.Button btnAgregarStockInsumosProductos;
    }
}