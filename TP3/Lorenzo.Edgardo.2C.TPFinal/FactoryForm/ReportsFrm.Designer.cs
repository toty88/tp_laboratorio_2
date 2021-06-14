
namespace FactoryForm
{
    partial class ReportsFrm
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
            this.rtbProducts = new System.Windows.Forms.RichTextBox();
            this.btnListProducts = new FontAwesome.Sharp.IconButton();
            this.btnSaveToXML = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFIileName = new System.Windows.Forms.TextBox();
            this.txtDefaultFileName = new System.Windows.Forms.TextBox();
            this.lblDefaultFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbProducts
            // 
            this.rtbProducts.Location = new System.Drawing.Point(12, 124);
            this.rtbProducts.Name = "rtbProducts";
            this.rtbProducts.Size = new System.Drawing.Size(300, 326);
            this.rtbProducts.TabIndex = 0;
            this.rtbProducts.Text = "";
            // 
            // btnListProducts
            // 
            this.btnListProducts.FlatAppearance.BorderSize = 0;
            this.btnListProducts.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListProducts.IconColor = System.Drawing.Color.Black;
            this.btnListProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListProducts.Location = new System.Drawing.Point(12, 12);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(90, 59);
            this.btnListProducts.TabIndex = 10;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.FlatAppearance.BorderSize = 0;
            this.btnSaveToXML.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveToXML.IconColor = System.Drawing.Color.Black;
            this.btnSaveToXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveToXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveToXML.Location = new System.Drawing.Point(117, 12);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(90, 59);
            this.btnSaveToXML.TabIndex = 11;
            this.btnSaveToXML.Text = "Save to XML";
            this.btnSaveToXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveToXML.UseVisualStyleBackColor = true;
            this.btnSaveToXML.Click += new System.EventHandler(this.btnSaveToXML_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(222, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 59);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Main Menu";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 101);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 13);
            this.lblFileName.TabIndex = 13;
            this.lblFileName.Text = "New File Name";
            // 
            // txtFIileName
            // 
            this.txtFIileName.Location = new System.Drawing.Point(108, 98);
            this.txtFIileName.Name = "txtFIileName";
            this.txtFIileName.Size = new System.Drawing.Size(99, 20);
            this.txtFIileName.TabIndex = 14;
            // 
            // txtDefaultFileName
            // 
            this.txtDefaultFileName.Location = new System.Drawing.Point(108, 77);
            this.txtDefaultFileName.Name = "txtDefaultFileName";
            this.txtDefaultFileName.Size = new System.Drawing.Size(99, 20);
            this.txtDefaultFileName.TabIndex = 16;
            this.txtDefaultFileName.Text = "Products.xml";
            // 
            // lblDefaultFileName
            // 
            this.lblDefaultFileName.AutoSize = true;
            this.lblDefaultFileName.Location = new System.Drawing.Point(13, 80);
            this.lblDefaultFileName.Name = "lblDefaultFileName";
            this.lblDefaultFileName.Size = new System.Drawing.Size(91, 13);
            this.lblDefaultFileName.TabIndex = 15;
            this.lblDefaultFileName.Text = "Default File Name";
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 457);
            this.Controls.Add(this.txtDefaultFileName);
            this.Controls.Add(this.lblDefaultFileName);
            this.Controls.Add(this.txtFIileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.rtbProducts);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 496);
            this.Name = "ReportsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProducts;
        private FontAwesome.Sharp.IconButton btnListProducts;
        private FontAwesome.Sharp.IconButton btnSaveToXML;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFIileName;
        private System.Windows.Forms.TextBox txtDefaultFileName;
        private System.Windows.Forms.Label lblDefaultFileName;
    }
}