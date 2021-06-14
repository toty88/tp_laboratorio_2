
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rtbProducts
            // 
            this.rtbProducts.Location = new System.Drawing.Point(12, 77);
            this.rtbProducts.Name = "rtbProducts";
            this.rtbProducts.Size = new System.Drawing.Size(309, 373);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 457);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.rtbProducts);
            this.Name = "ReportsFrm";
            this.Text = "ReportsFrm";
            this.Load += new System.EventHandler(this.ReportsFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProducts;
        private FontAwesome.Sharp.IconButton btnListProducts;
        private FontAwesome.Sharp.IconButton btnSaveToXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}