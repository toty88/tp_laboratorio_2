
namespace FactoryForm
{
    partial class WarehouseFrm
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
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.keyboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyboardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mechanicalKeyboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolerMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalKeyboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Keyboard",
            "Notebook"});
            this.cmbProduct.Location = new System.Drawing.Point(12, 49);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(13, 13);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(299, 24);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Choose Product to see Information";
            // 
            // keyboardBindingSource
            // 
            this.keyboardBindingSource.DataSource = typeof(EntidadesCore.Keyboard);
            // 
            // notebookBindingSource
            // 
            this.notebookBindingSource.DataSource = typeof(EntidadesCore.Notebook);
            // 
            // keyboardBindingSource1
            // 
            this.keyboardBindingSource1.DataSource = typeof(EntidadesCore.Keyboard);
            // 
            // mechanicalKeyboardBindingSource
            // 
            this.mechanicalKeyboardBindingSource.DataSource = typeof(EntidadesCore.MechanicalKeyboard);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnVolerMenuPrincipal
            // 
            this.btnVolerMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolerMenuPrincipal.Location = new System.Drawing.Point(765, 12);
            this.btnVolerMenuPrincipal.Name = "btnVolerMenuPrincipal";
            this.btnVolerMenuPrincipal.Size = new System.Drawing.Size(90, 58);
            this.btnVolerMenuPrincipal.TabIndex = 37;
            this.btnVolerMenuPrincipal.Text = "Volver al Menu Principal";
            this.btnVolerMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolerMenuPrincipal.Click += new System.EventHandler(this.btnVolerMenuPrincipal_Click);
            // 
            // WarehouseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 258);
            this.Controls.Add(this.btnVolerMenuPrincipal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(883, 297);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(883, 297);
            this.Name = "WarehouseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.WarehouseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalKeyboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.BindingSource keyboardBindingSource;
        private System.Windows.Forms.BindingSource notebookBindingSource;
        private System.Windows.Forms.BindingSource keyboardBindingSource1;
        private System.Windows.Forms.BindingSource mechanicalKeyboardBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolerMenuPrincipal;
    }
}