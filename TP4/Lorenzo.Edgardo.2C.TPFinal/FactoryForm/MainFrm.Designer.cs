
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
            this.picBMainFrm = new System.Windows.Forms.PictureBox();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnBuild = new FontAwesome.Sharp.IconButton();
            this.btnWarehouse = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
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
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnStock.IconColor = System.Drawing.Color.Black;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.Location = new System.Drawing.Point(127, 271);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(109, 64);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.FlatAppearance.BorderSize = 0;
            this.btnBuild.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnBuild.IconColor = System.Drawing.Color.Black;
            this.btnBuild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuild.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuild.Location = new System.Drawing.Point(242, 271);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(109, 64);
            this.btnBuild.TabIndex = 7;
            this.btnBuild.Text = "Build";
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnWarehouse.IconColor = System.Drawing.Color.Black;
            this.btnWarehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWarehouse.Location = new System.Drawing.Point(12, 271);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(109, 64);
            this.btnWarehouse.TabIndex = 8;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnReports.IconColor = System.Drawing.Color.Black;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(357, 271);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(109, 64);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(472, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 64);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnStock);
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
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnBuild;
        private FontAwesome.Sharp.IconButton btnWarehouse;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

