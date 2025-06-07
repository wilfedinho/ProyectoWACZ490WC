namespace GUI490WC
{
    partial class FormAplicarBeneficios490WC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBeneficio490WC = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaCodigoBeneficio490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecioEstrella490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagenEstrella = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaCantidadBeneficioReclamado490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescuentoAplicar490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficio490WC
            // 
            this.dgvBeneficio490WC.AllowUserToAddRows = false;
            this.dgvBeneficio490WC.AllowUserToDeleteRows = false;
            this.dgvBeneficio490WC.AllowUserToResizeColumns = false;
            this.dgvBeneficio490WC.AllowUserToResizeRows = false;
            this.dgvBeneficio490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeneficio490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficio490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigoBeneficio490WC,
            this.ColumnaNombre490WC,
            this.ColumnaPrecioEstrella490WC,
            this.ColumnImagenEstrella,
            this.ColumnaCantidadBeneficioReclamado490WC,
            this.ColumnaDescuentoAplicar490WC});
            this.dgvBeneficio490WC.Location = new System.Drawing.Point(497, 26);
            this.dgvBeneficio490WC.MultiSelect = false;
            this.dgvBeneficio490WC.Name = "dgvBeneficio490WC";
            this.dgvBeneficio490WC.ReadOnly = true;
            this.dgvBeneficio490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficio490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficio490WC.Size = new System.Drawing.Size(558, 362);
            this.dgvBeneficio490WC.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI490WC.Properties.Resources.Estrella_Mario;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 262;
            // 
            // ColumnaCodigoBeneficio490WC
            // 
            this.ColumnaCodigoBeneficio490WC.HeaderText = "Column1";
            this.ColumnaCodigoBeneficio490WC.Name = "ColumnaCodigoBeneficio490WC";
            this.ColumnaCodigoBeneficio490WC.ReadOnly = true;
            this.ColumnaCodigoBeneficio490WC.Visible = false;
            // 
            // ColumnaNombre490WC
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnaNombre490WC.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnaNombre490WC.HeaderText = "Nombre";
            this.ColumnaNombre490WC.Name = "ColumnaNombre490WC";
            this.ColumnaNombre490WC.ReadOnly = true;
            // 
            // ColumnaPrecioEstrella490WC
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold);
            this.ColumnaPrecioEstrella490WC.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnaPrecioEstrella490WC.HeaderText = "Precio";
            this.ColumnaPrecioEstrella490WC.Name = "ColumnaPrecioEstrella490WC";
            this.ColumnaPrecioEstrella490WC.ReadOnly = true;
            // 
            // ColumnImagenEstrella
            // 
            this.ColumnImagenEstrella.HeaderText = "";
            this.ColumnImagenEstrella.Image = global::GUI490WC.Properties.Resources.Estrella_Mario;
            this.ColumnImagenEstrella.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImagenEstrella.Name = "ColumnImagenEstrella";
            this.ColumnImagenEstrella.ReadOnly = true;
            // 
            // ColumnaCantidadBeneficioReclamado490WC
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold);
            this.ColumnaCantidadBeneficioReclamado490WC.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnaCantidadBeneficioReclamado490WC.HeaderText = "Cantidad de Reclamados";
            this.ColumnaCantidadBeneficioReclamado490WC.Name = "ColumnaCantidadBeneficioReclamado490WC";
            this.ColumnaCantidadBeneficioReclamado490WC.ReadOnly = true;
            // 
            // ColumnaDescuentoAplicar490WC
            // 
            this.ColumnaDescuentoAplicar490WC.HeaderText = "Column1";
            this.ColumnaDescuentoAplicar490WC.Name = "ColumnaDescuentoAplicar490WC";
            this.ColumnaDescuentoAplicar490WC.ReadOnly = true;
            this.ColumnaDescuentoAplicar490WC.Visible = false;
            // 
            // FormAplicarBeneficios490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 484);
            this.Controls.Add(this.dgvBeneficio490WC);
            this.Name = "FormAplicarBeneficios490WC";
            this.Text = "FormAplicarBeneficios490WC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficio490WC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigoBeneficio490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecioEstrella490WC;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImagenEstrella;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidadBeneficioReclamado490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescuentoAplicar490WC;
    }
}