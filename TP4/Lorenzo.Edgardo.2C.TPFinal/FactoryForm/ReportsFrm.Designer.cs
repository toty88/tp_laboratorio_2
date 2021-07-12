
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
            this.rtbFromDB = new System.Windows.Forms.RichTextBox();
            this.btnSaveToXML = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnLoadDB = new FontAwesome.Sharp.IconButton();
            this.btnSaveToDB = new FontAwesome.Sharp.IconButton();
            this.btnLoadFromXML = new FontAwesome.Sharp.IconButton();
            this.rtbFromXML = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblDBProducts = new System.Windows.Forms.Label();
            this.lblXMLProducts = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rdbNotebooks = new System.Windows.Forms.RadioButton();
            this.rdbKeyboards = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbFromDB
            // 
            this.rtbFromDB.Location = new System.Drawing.Point(19, 120);
            this.rtbFromDB.Name = "rtbFromDB";
            this.rtbFromDB.Size = new System.Drawing.Size(225, 325);
            this.rtbFromDB.TabIndex = 0;
            this.rtbFromDB.Text = "";
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.FlatAppearance.BorderSize = 0;
            this.btnSaveToXML.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveToXML.IconColor = System.Drawing.Color.Black;
            this.btnSaveToXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveToXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveToXML.Location = new System.Drawing.Point(211, 12);
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
            this.btnBack.Location = new System.Drawing.Point(403, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 59);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Main Menu";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.FlatAppearance.BorderSize = 0;
            this.btnLoadDB.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLoadDB.IconColor = System.Drawing.Color.Black;
            this.btnLoadDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadDB.Location = new System.Drawing.Point(115, 12);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(90, 59);
            this.btnLoadDB.TabIndex = 18;
            this.btnLoadDB.Text = "Load from DB";
            this.btnLoadDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.FlatAppearance.BorderSize = 0;
            this.btnSaveToDB.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveToDB.IconColor = System.Drawing.Color.Black;
            this.btnSaveToDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveToDB.Location = new System.Drawing.Point(19, 12);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(90, 59);
            this.btnSaveToDB.TabIndex = 19;
            this.btnSaveToDB.Text = "Save to DB";
            this.btnSaveToDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnLoadFromXML
            // 
            this.btnLoadFromXML.FlatAppearance.BorderSize = 0;
            this.btnLoadFromXML.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLoadFromXML.IconColor = System.Drawing.Color.Black;
            this.btnLoadFromXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFromXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadFromXML.Location = new System.Drawing.Point(307, 12);
            this.btnLoadFromXML.Name = "btnLoadFromXML";
            this.btnLoadFromXML.Size = new System.Drawing.Size(90, 59);
            this.btnLoadFromXML.TabIndex = 20;
            this.btnLoadFromXML.Text = "Load from XML";
            this.btnLoadFromXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadFromXML.UseVisualStyleBackColor = true;
            this.btnLoadFromXML.Click += new System.EventHandler(this.btnLoadFromXML_Click);
            // 
            // rtbFromXML
            // 
            this.rtbFromXML.Location = new System.Drawing.Point(268, 120);
            this.rtbFromXML.Name = "rtbFromXML";
            this.rtbFromXML.Size = new System.Drawing.Size(225, 325);
            this.rtbFromXML.TabIndex = 0;
            this.rtbFromXML.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblDBProducts
            // 
            this.lblDBProducts.AutoSize = true;
            this.lblDBProducts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDBProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDBProducts.Location = new System.Drawing.Point(16, 77);
            this.lblDBProducts.Name = "lblDBProducts";
            this.lblDBProducts.Size = new System.Drawing.Size(150, 16);
            this.lblDBProducts.TabIndex = 22;
            this.lblDBProducts.Text = "Products store at DB";
            // 
            // lblXMLProducts
            // 
            this.lblXMLProducts.AutoSize = true;
            this.lblXMLProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblXMLProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblXMLProducts.Location = new System.Drawing.Point(265, 77);
            this.lblXMLProducts.Name = "lblXMLProducts";
            this.lblXMLProducts.Size = new System.Drawing.Size(158, 16);
            this.lblXMLProducts.TabIndex = 23;
            this.lblXMLProducts.Text = "Products store at XML";
            // 
            // rdbNotebooks
            // 
            this.rdbNotebooks.AutoSize = true;
            this.rdbNotebooks.Location = new System.Drawing.Point(18, 97);
            this.rdbNotebooks.Name = "rdbNotebooks";
            this.rdbNotebooks.Size = new System.Drawing.Size(107, 17);
            this.rdbNotebooks.TabIndex = 24;
            this.rdbNotebooks.TabStop = true;
            this.rdbNotebooks.Text = "Notebooks Table";
            this.rdbNotebooks.UseVisualStyleBackColor = true;
            // 
            // rdbKeyboards
            // 
            this.rdbKeyboards.AutoSize = true;
            this.rdbKeyboards.Location = new System.Drawing.Point(129, 97);
            this.rdbKeyboards.Name = "rdbKeyboards";
            this.rdbKeyboards.Size = new System.Drawing.Size(105, 17);
            this.rdbKeyboards.TabIndex = 25;
            this.rdbKeyboards.TabStop = true;
            this.rdbKeyboards.Text = "Keyboards Table";
            this.rdbKeyboards.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Last Product Sent";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(499, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 17);
            this.lblModel.TabIndex = 29;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(499, 78);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(152, 16);
            this.lblTotalCount.TabIndex = 30;
            this.lblTotalCount.Text = "Total Products Sent to DB";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(505, 132);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 24);
            this.lblCount.TabIndex = 31;
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbKeyboards);
            this.Controls.Add(this.rdbNotebooks);
            this.Controls.Add(this.lblXMLProducts);
            this.Controls.Add(this.lblDBProducts);
            this.Controls.Add(this.rtbFromXML);
            this.Controls.Add(this.btnLoadFromXML);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.rtbFromDB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 496);
            this.Name = "ReportsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFromDB;
        private FontAwesome.Sharp.IconButton btnSaveToXML;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnLoadDB;
        private FontAwesome.Sharp.IconButton btnSaveToDB;
        private FontAwesome.Sharp.IconButton btnLoadFromXML;
        private System.Windows.Forms.RichTextBox rtbFromXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblDBProducts;
        private System.Windows.Forms.Label lblXMLProducts;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton rdbNotebooks;
        private System.Windows.Forms.RadioButton rdbKeyboards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblCount;
    }
}