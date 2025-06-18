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
            this.ColumnaCodigoBeneficio490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadBeneficioReclamado490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecioEstrella490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagenEstrella = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaDescuentoAplicar490WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TB_NOMBRE490WC = new System.Windows.Forms.TextBox();
            this.TB_APELLIDO490WC = new System.Windows.Forms.TextBox();
            this.TB_DNI490WC = new System.Windows.Forms.TextBox();
            this.LABEL_NOMBRE490WC = new System.Windows.Forms.Label();
            this.LABEL_APELLIDO490WC = new System.Windows.Forms.Label();
            this.LABEL_DNI490WC = new System.Windows.Forms.Label();
            this.BT_BUSCARCLIENTE490WC = new System.Windows.Forms.Button();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_CANJEARBENEFICIO490WC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBINFOCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.TBBENEFICIOCLIENTE490WC = new System.Windows.Forms.TextBox();
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
            this.ColumnaCantidadBeneficioReclamado490WC,
            this.ColumnaPrecioEstrella490WC,
            this.ColumnImagenEstrella,
            this.ColumnaDescuentoAplicar490WC});
            this.dgvBeneficio490WC.Location = new System.Drawing.Point(595, 12);
            this.dgvBeneficio490WC.MultiSelect = false;
            this.dgvBeneficio490WC.Name = "dgvBeneficio490WC";
            this.dgvBeneficio490WC.ReadOnly = true;
            this.dgvBeneficio490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficio490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficio490WC.Size = new System.Drawing.Size(528, 341);
            this.dgvBeneficio490WC.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnaNombre490WC.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnaNombre490WC.HeaderText = "Nombre";
            this.ColumnaNombre490WC.Name = "ColumnaNombre490WC";
            this.ColumnaNombre490WC.ReadOnly = true;
            // 
            // ColumnaCantidadBeneficioReclamado490WC
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold);
            this.ColumnaCantidadBeneficioReclamado490WC.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnaCantidadBeneficioReclamado490WC.HeaderText = "Cantidad de Reclamados";
            this.ColumnaCantidadBeneficioReclamado490WC.Name = "ColumnaCantidadBeneficioReclamado490WC";
            this.ColumnaCantidadBeneficioReclamado490WC.ReadOnly = true;
            // 
            // ColumnaPrecioEstrella490WC
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.75258F, System.Drawing.FontStyle.Bold);
            this.ColumnaPrecioEstrella490WC.DefaultCellStyle = dataGridViewCellStyle3;
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
            // ColumnaDescuentoAplicar490WC
            // 
            this.ColumnaDescuentoAplicar490WC.HeaderText = "Column1";
            this.ColumnaDescuentoAplicar490WC.Name = "ColumnaDescuentoAplicar490WC";
            this.ColumnaDescuentoAplicar490WC.ReadOnly = true;
            this.ColumnaDescuentoAplicar490WC.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI490WC.Properties.Resources.Estrella_Mario;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 262;
            // 
            // TB_NOMBRE490WC
            // 
            this.TB_NOMBRE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_NOMBRE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NOMBRE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_NOMBRE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_NOMBRE490WC.Location = new System.Drawing.Point(12, 260);
            this.TB_NOMBRE490WC.Name = "TB_NOMBRE490WC";
            this.TB_NOMBRE490WC.Size = new System.Drawing.Size(169, 27);
            this.TB_NOMBRE490WC.TabIndex = 15;
            // 
            // TB_APELLIDO490WC
            // 
            this.TB_APELLIDO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_APELLIDO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_APELLIDO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_APELLIDO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_APELLIDO490WC.Location = new System.Drawing.Point(212, 260);
            this.TB_APELLIDO490WC.Name = "TB_APELLIDO490WC";
            this.TB_APELLIDO490WC.Size = new System.Drawing.Size(169, 27);
            this.TB_APELLIDO490WC.TabIndex = 16;
            // 
            // TB_DNI490WC
            // 
            this.TB_DNI490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DNI490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DNI490WC.Location = new System.Drawing.Point(405, 260);
            this.TB_DNI490WC.Name = "TB_DNI490WC";
            this.TB_DNI490WC.Size = new System.Drawing.Size(169, 27);
            this.TB_DNI490WC.TabIndex = 17;
            // 
            // LABEL_NOMBRE490WC
            // 
            this.LABEL_NOMBRE490WC.AutoSize = true;
            this.LABEL_NOMBRE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE490WC.Location = new System.Drawing.Point(61, 237);
            this.LABEL_NOMBRE490WC.Name = "LABEL_NOMBRE490WC";
            this.LABEL_NOMBRE490WC.Size = new System.Drawing.Size(77, 20);
            this.LABEL_NOMBRE490WC.TabIndex = 24;
            this.LABEL_NOMBRE490WC.Text = "Nombre";
            // 
            // LABEL_APELLIDO490WC
            // 
            this.LABEL_APELLIDO490WC.AutoSize = true;
            this.LABEL_APELLIDO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_APELLIDO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_APELLIDO490WC.Location = new System.Drawing.Point(259, 237);
            this.LABEL_APELLIDO490WC.Name = "LABEL_APELLIDO490WC";
            this.LABEL_APELLIDO490WC.Size = new System.Drawing.Size(79, 20);
            this.LABEL_APELLIDO490WC.TabIndex = 25;
            this.LABEL_APELLIDO490WC.Text = "Apellido";
            // 
            // LABEL_DNI490WC
            // 
            this.LABEL_DNI490WC.AutoSize = true;
            this.LABEL_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DNI490WC.Location = new System.Drawing.Point(473, 237);
            this.LABEL_DNI490WC.Name = "LABEL_DNI490WC";
            this.LABEL_DNI490WC.Size = new System.Drawing.Size(40, 20);
            this.LABEL_DNI490WC.TabIndex = 26;
            this.LABEL_DNI490WC.Text = "DNI";
            // 
            // BT_BUSCARCLIENTE490WC
            // 
            this.BT_BUSCARCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BUSCARCLIENTE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BUSCARCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BUSCARCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BUSCARCLIENTE490WC.Location = new System.Drawing.Point(12, 306);
            this.BT_BUSCARCLIENTE490WC.Name = "BT_BUSCARCLIENTE490WC";
            this.BT_BUSCARCLIENTE490WC.Size = new System.Drawing.Size(169, 47);
            this.BT_BUSCARCLIENTE490WC.TabIndex = 27;
            this.BT_BUSCARCLIENTE490WC.Text = "Buscar Cliente";
            this.BT_BUSCARCLIENTE490WC.UseVisualStyleBackColor = false;
            this.BT_BUSCARCLIENTE490WC.Click += new System.EventHandler(this.BT_BUSCARCLIENTE490WC_Click);
            // 
            // BT_CANCELAR490WC
            // 
            this.BT_CANCELAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(405, 306);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(169, 47);
            this.BT_CANCELAR490WC.TabIndex = 28;
            this.BT_CANCELAR490WC.Text = "Cancelar";
            this.BT_CANCELAR490WC.UseVisualStyleBackColor = false;
            this.BT_CANCELAR490WC.Click += new System.EventHandler(this.BT_CANCELAR490WC_Click);
            // 
            // BT_CANJEARBENEFICIO490WC
            // 
            this.BT_CANJEARBENEFICIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANJEARBENEFICIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANJEARBENEFICIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANJEARBENEFICIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANJEARBENEFICIO490WC.Location = new System.Drawing.Point(212, 306);
            this.BT_CANJEARBENEFICIO490WC.Name = "BT_CANJEARBENEFICIO490WC";
            this.BT_CANJEARBENEFICIO490WC.Size = new System.Drawing.Size(169, 47);
            this.BT_CANJEARBENEFICIO490WC.TabIndex = 29;
            this.BT_CANJEARBENEFICIO490WC.Text = "Canjear Beneficio";
            this.BT_CANJEARBENEFICIO490WC.UseVisualStyleBackColor = false;
            this.BT_CANJEARBENEFICIO490WC.Click += new System.EventHandler(this.BT_CANJEARBENEFICIO490WC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Datos Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(364, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Beneficios del Cliente";
            // 
            // TBINFOCLIENTE490WC
            // 
            this.TBINFOCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TBINFOCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBINFOCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TBINFOCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TBINFOCLIENTE490WC.Location = new System.Drawing.Point(12, 35);
            this.TBINFOCLIENTE490WC.Multiline = true;
            this.TBINFOCLIENTE490WC.Name = "TBINFOCLIENTE490WC";
            this.TBINFOCLIENTE490WC.ReadOnly = true;
            this.TBINFOCLIENTE490WC.Size = new System.Drawing.Size(310, 173);
            this.TBINFOCLIENTE490WC.TabIndex = 34;
            // 
            // TBBENEFICIOCLIENTE490WC
            // 
            this.TBBENEFICIOCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TBBENEFICIOCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBENEFICIOCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TBBENEFICIOCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TBBENEFICIOCLIENTE490WC.Location = new System.Drawing.Point(368, 35);
            this.TBBENEFICIOCLIENTE490WC.Multiline = true;
            this.TBBENEFICIOCLIENTE490WC.Name = "TBBENEFICIOCLIENTE490WC";
            this.TBBENEFICIOCLIENTE490WC.ReadOnly = true;
            this.TBBENEFICIOCLIENTE490WC.Size = new System.Drawing.Size(206, 173);
            this.TBBENEFICIOCLIENTE490WC.TabIndex = 35;
            // 
            // FormAplicarBeneficios490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1135, 377);
            this.Controls.Add(this.TBBENEFICIOCLIENTE490WC);
            this.Controls.Add(this.TBINFOCLIENTE490WC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_CANJEARBENEFICIO490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.BT_BUSCARCLIENTE490WC);
            this.Controls.Add(this.LABEL_DNI490WC);
            this.Controls.Add(this.LABEL_APELLIDO490WC);
            this.Controls.Add(this.LABEL_NOMBRE490WC);
            this.Controls.Add(this.TB_DNI490WC);
            this.Controls.Add(this.TB_APELLIDO490WC);
            this.Controls.Add(this.TB_NOMBRE490WC);
            this.Controls.Add(this.dgvBeneficio490WC);
            this.Name = "FormAplicarBeneficios490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAplicarBeneficios490WC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficio490WC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigoBeneficio490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidadBeneficioReclamado490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecioEstrella490WC;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImagenEstrella;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescuentoAplicar490WC;
        private System.Windows.Forms.TextBox TB_NOMBRE490WC;
        private System.Windows.Forms.TextBox TB_APELLIDO490WC;
        private System.Windows.Forms.TextBox TB_DNI490WC;
        private System.Windows.Forms.Label LABEL_NOMBRE490WC;
        private System.Windows.Forms.Label LABEL_APELLIDO490WC;
        private System.Windows.Forms.Label LABEL_DNI490WC;
        private System.Windows.Forms.Button BT_BUSCARCLIENTE490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_CANJEARBENEFICIO490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBINFOCLIENTE490WC;
        private System.Windows.Forms.TextBox TBBENEFICIOCLIENTE490WC;
    }
}