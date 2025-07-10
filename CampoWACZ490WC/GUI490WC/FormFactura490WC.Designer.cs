namespace GUI490WC
{
    partial class FormFactura490WC
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
            this.BT_IMPRIMIRFACTURA490WC = new System.Windows.Forms.Button();
            this.dgvFactura490WC = new System.Windows.Forms.DataGridView();
            this.ColumnaNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNITitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaIDBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_IMPRIMIRFACTURA490WC
            // 
            this.BT_IMPRIMIRFACTURA490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_IMPRIMIRFACTURA490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_IMPRIMIRFACTURA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_IMPRIMIRFACTURA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_IMPRIMIRFACTURA490WC.Location = new System.Drawing.Point(78, 325);
            this.BT_IMPRIMIRFACTURA490WC.Name = "BT_IMPRIMIRFACTURA490WC";
            this.BT_IMPRIMIRFACTURA490WC.Size = new System.Drawing.Size(371, 40);
            this.BT_IMPRIMIRFACTURA490WC.TabIndex = 55;
            this.BT_IMPRIMIRFACTURA490WC.Text = "Imprimir Factura";
            this.BT_IMPRIMIRFACTURA490WC.UseVisualStyleBackColor = false;
            this.BT_IMPRIMIRFACTURA490WC.Click += new System.EventHandler(this.BT_IMPRIMIRFACTURA490WC_Click);
            // 
            // dgvFactura490WC
            // 
            this.dgvFactura490WC.AllowUserToAddRows = false;
            this.dgvFactura490WC.AllowUserToDeleteRows = false;
            this.dgvFactura490WC.AllowUserToResizeColumns = false;
            this.dgvFactura490WC.AllowUserToResizeRows = false;
            this.dgvFactura490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNumeroFactura,
            this.ColumnaDNITitular,
            this.ColumnaIDBoleto});
            this.dgvFactura490WC.Location = new System.Drawing.Point(78, 12);
            this.dgvFactura490WC.MultiSelect = false;
            this.dgvFactura490WC.Name = "dgvFactura490WC";
            this.dgvFactura490WC.ReadOnly = true;
            this.dgvFactura490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFactura490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactura490WC.Size = new System.Drawing.Size(371, 293);
            this.dgvFactura490WC.TabIndex = 58;
            // 
            // ColumnaNumeroFactura
            // 
            this.ColumnaNumeroFactura.HeaderText = "Numero Factura";
            this.ColumnaNumeroFactura.Name = "ColumnaNumeroFactura";
            this.ColumnaNumeroFactura.ReadOnly = true;
            // 
            // ColumnaDNITitular
            // 
            this.ColumnaDNITitular.HeaderText = "DNI Titular";
            this.ColumnaDNITitular.Name = "ColumnaDNITitular";
            this.ColumnaDNITitular.ReadOnly = true;
            // 
            // ColumnaIDBoleto
            // 
            this.ColumnaIDBoleto.HeaderText = "Numero Boleto";
            this.ColumnaIDBoleto.Name = "ColumnaIDBoleto";
            this.ColumnaIDBoleto.ReadOnly = true;
            // 
            // FormFactura490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.dgvFactura490WC);
            this.Controls.Add(this.BT_IMPRIMIRFACTURA490WC);
            this.Name = "FormFactura490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFactura490WC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura490WC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_IMPRIMIRFACTURA490WC;
        private System.Windows.Forms.DataGridView dgvFactura490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDNITitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIDBoleto;
    }
}