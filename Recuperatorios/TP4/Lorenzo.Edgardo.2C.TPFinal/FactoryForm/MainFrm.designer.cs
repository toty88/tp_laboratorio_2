
namespace FactoryForm
{
    partial class MainFrm
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
            this.picBMainFrm = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConstruirProductos = new System.Windows.Forms.Button();
            this.btnVerCargarStock = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBMainFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // picBMainFrm
            // 
            this.picBMainFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBMainFrm.Location = new System.Drawing.Point(0, 0);
            this.picBMainFrm.Name = "picBMainFrm";
            this.picBMainFrm.Size = new System.Drawing.Size(594, 347);
            this.picBMainFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMainFrm.TabIndex = 3;
            this.picBMainFrm.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(472, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 64);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(357, 271);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(109, 64);
            this.btnReportes.TabIndex = 39;
            this.btnReportes.Text = "REPORTES (BD & XML)";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConstruirProductos
            // 
            this.btnConstruirProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstruirProductos.Location = new System.Drawing.Point(242, 271);
            this.btnConstruirProductos.Name = "btnConstruirProductos";
            this.btnConstruirProductos.Size = new System.Drawing.Size(109, 64);
            this.btnConstruirProductos.TabIndex = 40;
            this.btnConstruirProductos.Text = "CONSTRUIR PRODUCTOS";
            this.btnConstruirProductos.UseVisualStyleBackColor = true;
            this.btnConstruirProductos.Click += new System.EventHandler(this.btnConstruirProductos_Click);
            // 
            // btnVerCargarStock
            // 
            this.btnVerCargarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCargarStock.Location = new System.Drawing.Point(127, 271);
            this.btnVerCargarStock.Name = "btnVerCargarStock";
            this.btnVerCargarStock.Size = new System.Drawing.Size(109, 64);
            this.btnVerCargarStock.TabIndex = 41;
            this.btnVerCargarStock.Text = "VER/CARGAR STOCK";
            this.btnVerCargarStock.UseVisualStyleBackColor = true;
            this.btnVerCargarStock.Click += new System.EventHandler(this.btnVerCargarStock_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(12, 271);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(109, 64);
            this.btnDeposito.TabIndex = 42;
            this.btnDeposito.Text = "DEPOSITO";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(90, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(417, 35);
            this.lblTitle.TabIndex = 43;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 347);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnVerCargarStock);
            this.Controls.Add(this.btnConstruirProductos);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picBMainFrm);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyboard & Notebook INC";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBMainFrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBMainFrm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnConstruirProductos;
        private System.Windows.Forms.Button btnVerCargarStock;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

