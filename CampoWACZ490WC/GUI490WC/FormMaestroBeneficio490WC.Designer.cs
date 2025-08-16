namespace GUI490WC
{
    partial class FormMaestroBeneficio490WC
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
            this.BT_SALIR490WC = new System.Windows.Forms.Button();
            this.BT_APLICAR490WC = new System.Windows.Forms.Button();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_MODIFICAR490WC = new System.Windows.Forms.Button();
            this.BT_BAJA490WC = new System.Windows.Forms.Button();
            this.BT_ALTA490WC = new System.Windows.Forms.Button();
            this.dgvBeneficio490WC = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadReclamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescuentoAplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.LABEL_NOMBRE_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.TB_NOMBRE490WC = new System.Windows.Forms.TextBox();
            this.LABEL_PRECIO490WC = new System.Windows.Forms.Label();
            this.TB_PRECIO490WC = new System.Windows.Forms.TextBox();
            this.LABEL_VECESRECLAMADO490WC = new System.Windows.Forms.Label();
            this.TB_VECESRECLAMADO490WC = new System.Windows.Forms.TextBox();
            this.LABEL_DESCUENTOAPLICAR490WC = new System.Windows.Forms.Label();
            this.TB_DESCUENTOAPLICAR490WC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_SALIR490WC
            // 
            this.BT_SALIR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_SALIR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_SALIR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_SALIR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_SALIR490WC.Location = new System.Drawing.Point(954, 281);
            this.BT_SALIR490WC.Name = "BT_SALIR490WC";
            this.BT_SALIR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_SALIR490WC.TabIndex = 41;
            this.BT_SALIR490WC.Text = "Salir";
            this.BT_SALIR490WC.UseVisualStyleBackColor = false;
            this.BT_SALIR490WC.Click += new System.EventHandler(this.BT_SALIR490WC_Click);
            // 
            // BT_APLICAR490WC
            // 
            this.BT_APLICAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_APLICAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_APLICAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_APLICAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_APLICAR490WC.Location = new System.Drawing.Point(954, 175);
            this.BT_APLICAR490WC.Name = "BT_APLICAR490WC";
            this.BT_APLICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_APLICAR490WC.TabIndex = 40;
            this.BT_APLICAR490WC.Text = "Aplicar";
            this.BT_APLICAR490WC.UseVisualStyleBackColor = false;
            this.BT_APLICAR490WC.Click += new System.EventHandler(this.BT_APLICAR490WC_Click);
            // 
            // BT_CANCELAR490WC
            // 
            this.BT_CANCELAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(954, 228);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_CANCELAR490WC.TabIndex = 39;
            this.BT_CANCELAR490WC.Text = "Cancelar";
            this.BT_CANCELAR490WC.UseVisualStyleBackColor = false;
            this.BT_CANCELAR490WC.Click += new System.EventHandler(this.BT_CANCELAR490WC_Click);
            // 
            // BT_MODIFICAR490WC
            // 
            this.BT_MODIFICAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_MODIFICAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MODIFICAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_MODIFICAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_MODIFICAR490WC.Location = new System.Drawing.Point(954, 122);
            this.BT_MODIFICAR490WC.Name = "BT_MODIFICAR490WC";
            this.BT_MODIFICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_MODIFICAR490WC.TabIndex = 38;
            this.BT_MODIFICAR490WC.Text = "Modificar";
            this.BT_MODIFICAR490WC.UseVisualStyleBackColor = false;
            this.BT_MODIFICAR490WC.Click += new System.EventHandler(this.BT_MODIFICAR490WC_Click);
            // 
            // BT_BAJA490WC
            // 
            this.BT_BAJA490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BAJA490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BAJA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BAJA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BAJA490WC.Location = new System.Drawing.Point(954, 69);
            this.BT_BAJA490WC.Name = "BT_BAJA490WC";
            this.BT_BAJA490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_BAJA490WC.TabIndex = 37;
            this.BT_BAJA490WC.Text = "Baja";
            this.BT_BAJA490WC.UseVisualStyleBackColor = false;
            this.BT_BAJA490WC.Click += new System.EventHandler(this.BT_BAJA490WC_Click);
            // 
            // BT_ALTA490WC
            // 
            this.BT_ALTA490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ALTA490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ALTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ALTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ALTA490WC.Location = new System.Drawing.Point(954, 16);
            this.BT_ALTA490WC.Name = "BT_ALTA490WC";
            this.BT_ALTA490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_ALTA490WC.TabIndex = 36;
            this.BT_ALTA490WC.Text = "Alta";
            this.BT_ALTA490WC.UseVisualStyleBackColor = false;
            this.BT_ALTA490WC.Click += new System.EventHandler(this.BT_ALTA490WC_Click);
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
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaCantidadReclamado,
            this.ColumnaDescuentoAplicar,
            this.ColumnaPrecio,
            this.ColumnaImagen});
            this.dgvBeneficio490WC.Location = new System.Drawing.Point(12, 16);
            this.dgvBeneficio490WC.MultiSelect = false;
            this.dgvBeneficio490WC.Name = "dgvBeneficio490WC";
            this.dgvBeneficio490WC.ReadOnly = true;
            this.dgvBeneficio490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficio490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficio490WC.Size = new System.Drawing.Size(923, 259);
            this.dgvBeneficio490WC.TabIndex = 42;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Column1";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.ReadOnly = true;
            this.ColumnaCodigo.Visible = false;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaCantidadReclamado
            // 
            this.ColumnaCantidadReclamado.HeaderText = "Veces Reclamado";
            this.ColumnaCantidadReclamado.Name = "ColumnaCantidadReclamado";
            this.ColumnaCantidadReclamado.ReadOnly = true;
            // 
            // ColumnaDescuentoAplicar
            // 
            this.ColumnaDescuentoAplicar.HeaderText = "Porcentaje de Descuento";
            this.ColumnaDescuentoAplicar.Name = "ColumnaDescuentoAplicar";
            this.ColumnaDescuentoAplicar.ReadOnly = true;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.ReadOnly = true;
            // 
            // ColumnaImagen
            // 
            this.ColumnaImagen.HeaderText = "";
            this.ColumnaImagen.Image = global::GUI490WC.Properties.Resources.Estrella_Mario;
            this.ColumnaImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnaImagen.Name = "ColumnaImagen";
            this.ColumnaImagen.ReadOnly = true;
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(8, 278);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Name = "LABEL_NOMBRE_ABM_USUARIO490WC";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Size = new System.Drawing.Size(77, 20);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TabIndex = 44;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Text = "Nombre";
            // 
            // TB_NOMBRE490WC
            // 
            this.TB_NOMBRE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_NOMBRE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NOMBRE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_NOMBRE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_NOMBRE490WC.Location = new System.Drawing.Point(12, 301);
            this.TB_NOMBRE490WC.Name = "TB_NOMBRE490WC";
            this.TB_NOMBRE490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_NOMBRE490WC.TabIndex = 43;
            // 
            // LABEL_PRECIO490WC
            // 
            this.LABEL_PRECIO490WC.AutoSize = true;
            this.LABEL_PRECIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_PRECIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_PRECIO490WC.Location = new System.Drawing.Point(240, 278);
            this.LABEL_PRECIO490WC.Name = "LABEL_PRECIO490WC";
            this.LABEL_PRECIO490WC.Size = new System.Drawing.Size(64, 20);
            this.LABEL_PRECIO490WC.TabIndex = 46;
            this.LABEL_PRECIO490WC.Text = "Precio";
            // 
            // TB_PRECIO490WC
            // 
            this.TB_PRECIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PRECIO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PRECIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PRECIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PRECIO490WC.Location = new System.Drawing.Point(244, 301);
            this.TB_PRECIO490WC.Name = "TB_PRECIO490WC";
            this.TB_PRECIO490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_PRECIO490WC.TabIndex = 45;
            // 
            // LABEL_VECESRECLAMADO490WC
            // 
            this.LABEL_VECESRECLAMADO490WC.AutoSize = true;
            this.LABEL_VECESRECLAMADO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_VECESRECLAMADO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_VECESRECLAMADO490WC.Location = new System.Drawing.Point(492, 278);
            this.LABEL_VECESRECLAMADO490WC.Name = "LABEL_VECESRECLAMADO490WC";
            this.LABEL_VECESRECLAMADO490WC.Size = new System.Drawing.Size(160, 20);
            this.LABEL_VECESRECLAMADO490WC.TabIndex = 48;
            this.LABEL_VECESRECLAMADO490WC.Text = "Veces Reclamado";
            // 
            // TB_VECESRECLAMADO490WC
            // 
            this.TB_VECESRECLAMADO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_VECESRECLAMADO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_VECESRECLAMADO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_VECESRECLAMADO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_VECESRECLAMADO490WC.Location = new System.Drawing.Point(496, 301);
            this.TB_VECESRECLAMADO490WC.Name = "TB_VECESRECLAMADO490WC";
            this.TB_VECESRECLAMADO490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_VECESRECLAMADO490WC.TabIndex = 47;
            // 
            // LABEL_DESCUENTOAPLICAR490WC
            // 
            this.LABEL_DESCUENTOAPLICAR490WC.AutoSize = true;
            this.LABEL_DESCUENTOAPLICAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DESCUENTOAPLICAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DESCUENTOAPLICAR490WC.Location = new System.Drawing.Point(756, 278);
            this.LABEL_DESCUENTOAPLICAR490WC.Name = "LABEL_DESCUENTOAPLICAR490WC";
            this.LABEL_DESCUENTOAPLICAR490WC.Size = new System.Drawing.Size(164, 20);
            this.LABEL_DESCUENTOAPLICAR490WC.TabIndex = 50;
            this.LABEL_DESCUENTOAPLICAR490WC.Text = "Descuento Aplicar";
            // 
            // TB_DESCUENTOAPLICAR490WC
            // 
            this.TB_DESCUENTOAPLICAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DESCUENTOAPLICAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DESCUENTOAPLICAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DESCUENTOAPLICAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DESCUENTOAPLICAR490WC.Location = new System.Drawing.Point(760, 301);
            this.TB_DESCUENTOAPLICAR490WC.Name = "TB_DESCUENTOAPLICAR490WC";
            this.TB_DESCUENTOAPLICAR490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_DESCUENTOAPLICAR490WC.TabIndex = 49;
            // 
            // FormMaestroBeneficio490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1150, 348);
            this.Controls.Add(this.LABEL_DESCUENTOAPLICAR490WC);
            this.Controls.Add(this.TB_DESCUENTOAPLICAR490WC);
            this.Controls.Add(this.LABEL_VECESRECLAMADO490WC);
            this.Controls.Add(this.TB_VECESRECLAMADO490WC);
            this.Controls.Add(this.LABEL_PRECIO490WC);
            this.Controls.Add(this.TB_PRECIO490WC);
            this.Controls.Add(this.LABEL_NOMBRE_ABM_USUARIO490WC);
            this.Controls.Add(this.TB_NOMBRE490WC);
            this.Controls.Add(this.dgvBeneficio490WC);
            this.Controls.Add(this.BT_SALIR490WC);
            this.Controls.Add(this.BT_APLICAR490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.BT_MODIFICAR490WC);
            this.Controls.Add(this.BT_BAJA490WC);
            this.Controls.Add(this.BT_ALTA490WC);
            this.Name = "FormMaestroBeneficio490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaestroBeneficio490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMaestroBeneficio490WC_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_SALIR490WC;
        private System.Windows.Forms.Button BT_APLICAR490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_MODIFICAR490WC;
        private System.Windows.Forms.Button BT_BAJA490WC;
        private System.Windows.Forms.Button BT_ALTA490WC;
        private System.Windows.Forms.DataGridView dgvBeneficio490WC;
        private System.Windows.Forms.Label LABEL_NOMBRE_ABM_USUARIO490WC;
        private System.Windows.Forms.TextBox TB_NOMBRE490WC;
        private System.Windows.Forms.Label LABEL_PRECIO490WC;
        private System.Windows.Forms.TextBox TB_PRECIO490WC;
        private System.Windows.Forms.Label LABEL_VECESRECLAMADO490WC;
        private System.Windows.Forms.TextBox TB_VECESRECLAMADO490WC;
        private System.Windows.Forms.Label LABEL_DESCUENTOAPLICAR490WC;
        private System.Windows.Forms.TextBox TB_DESCUENTOAPLICAR490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidadReclamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescuentoAplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewImageColumn ColumnaImagen;
    }
}