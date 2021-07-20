
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
            this.btnGuardarBase = new System.Windows.Forms.Button();
            this.btnTraerDeBase = new System.Windows.Forms.Button();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.btnCargarDeXML = new System.Windows.Forms.Button();
            this.btnVolerMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFromDB
            // 
            this.rtbFromDB.Location = new System.Drawing.Point(19, 120);
            this.rtbFromDB.Name = "rtbFromDB";
            this.rtbFromDB.ReadOnly = true;
            this.rtbFromDB.Size = new System.Drawing.Size(225, 325);
            this.rtbFromDB.TabIndex = 0;
            this.rtbFromDB.Text = "";
            // 
            // rtbFromXML
            // 
            this.rtbFromXML.Location = new System.Drawing.Point(268, 120);
            this.rtbFromXML.Name = "rtbFromXML";
            this.rtbFromXML.ReadOnly = true;
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
            this.lblDBProducts.Size = new System.Drawing.Size(205, 16);
            this.lblDBProducts.TabIndex = 22;
            this.lblDBProducts.Text = "Productos Guardados en BD";
            // 
            // lblXMLProducts
            // 
            this.lblXMLProducts.AutoSize = true;
            this.lblXMLProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblXMLProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblXMLProducts.Location = new System.Drawing.Point(265, 77);
            this.lblXMLProducts.Name = "lblXMLProducts";
            this.lblXMLProducts.Size = new System.Drawing.Size(213, 16);
            this.lblXMLProducts.TabIndex = 23;
            this.lblXMLProducts.Text = "Productos Guardados en XML";
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
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ultimo Producto Enviado a BD:";
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(499, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(164, 150);
            this.lblModel.TabIndex = 29;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(499, 199);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(173, 36);
            this.lblTotalCount.TabIndex = 30;
            this.lblTotalCount.Text = "Cantidad Total de Productos Enviados a BD:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(505, 235);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 25);
            this.lblCount.TabIndex = 31;
            // 
            // btnGuardarBase
            // 
            this.btnGuardarBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBase.Location = new System.Drawing.Point(19, 13);
            this.btnGuardarBase.Name = "btnGuardarBase";
            this.btnGuardarBase.Size = new System.Drawing.Size(90, 58);
            this.btnGuardarBase.TabIndex = 32;
            this.btnGuardarBase.Text = "Guardar en Base de Datos\r\n";
            this.btnGuardarBase.UseVisualStyleBackColor = true;
            this.btnGuardarBase.Click += new System.EventHandler(this.btnGuardarEnBase_Click);
            // 
            // btnTraerDeBase
            // 
            this.btnTraerDeBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerDeBase.Location = new System.Drawing.Point(115, 12);
            this.btnTraerDeBase.Name = "btnTraerDeBase";
            this.btnTraerDeBase.Size = new System.Drawing.Size(90, 58);
            this.btnTraerDeBase.TabIndex = 33;
            this.btnTraerDeBase.Text = "Consultar Base de Datos";
            this.btnTraerDeBase.UseVisualStyleBackColor = true;
            this.btnTraerDeBase.Click += new System.EventHandler(this.btnConsultarBase_Click);
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarXML.Location = new System.Drawing.Point(211, 12);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(90, 58);
            this.btnGuardarXML.TabIndex = 34;
            this.btnGuardarXML.Text = "Guardar en XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // btnCargarDeXML
            // 
            this.btnCargarDeXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDeXML.Location = new System.Drawing.Point(307, 12);
            this.btnCargarDeXML.Name = "btnCargarDeXML";
            this.btnCargarDeXML.Size = new System.Drawing.Size(90, 58);
            this.btnCargarDeXML.TabIndex = 35;
            this.btnCargarDeXML.Text = "Cargar desde XML";
            this.btnCargarDeXML.UseVisualStyleBackColor = true;
            this.btnCargarDeXML.Click += new System.EventHandler(this.btnCargarDeXML_Click);
            // 
            // btnVolerMenuPrincipal
            // 
            this.btnVolerMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolerMenuPrincipal.Location = new System.Drawing.Point(403, 12);
            this.btnVolerMenuPrincipal.Name = "btnVolerMenuPrincipal";
            this.btnVolerMenuPrincipal.Size = new System.Drawing.Size(90, 58);
            this.btnVolerMenuPrincipal.TabIndex = 36;
            this.btnVolerMenuPrincipal.Text = "Volver al Menu Principal";
            this.btnVolerMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolerMenuPrincipal.Click += new System.EventHandler(this.btnVolerMenuPrincipal_Click);
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.btnVolerMenuPrincipal);
            this.Controls.Add(this.btnCargarDeXML);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnTraerDeBase);
            this.Controls.Add(this.btnGuardarBase);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbKeyboards);
            this.Controls.Add(this.rdbNotebooks);
            this.Controls.Add(this.lblXMLProducts);
            this.Controls.Add(this.lblDBProducts);
            this.Controls.Add(this.rtbFromXML);
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
        private System.Windows.Forms.Button btnGuardarBase;
        private System.Windows.Forms.Button btnTraerDeBase;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.Button btnCargarDeXML;
        private System.Windows.Forms.Button btnVolerMenuPrincipal;
    }
}