namespace GUI490WC
{
    partial class FormBitacoraCambiosBeneficio490WC
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
            this.BT_Activar490WC = new System.Windows.Forms.Button();
            this.labelCBDescripcion490WC = new System.Windows.Forms.Label();
            this.labelCBUsuario490WC = new System.Windows.Forms.Label();
            this.labelFechaInicio490WC = new System.Windows.Forms.Label();
            this.labelFechaFin490WC = new System.Windows.Forms.Label();
            this.checkBoxFecha490WC = new System.Windows.Forms.CheckBox();
            this.monthCalendarFechaFin490WC = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarFechaInicio490WC = new System.Windows.Forms.MonthCalendar();
            this.BT_LimpiarFiltros490WC = new System.Windows.Forms.Button();
            this.BT_Filtrar490WC = new System.Windows.Forms.Button();
            this.CB_CodigoBeneficio490WC = new System.Windows.Forms.ComboBox();
            this.CB_NombreBeneficio490WC = new System.Windows.Forms.ComboBox();
            this.dgvBeneficio490WC = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadReclamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescuentoAplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Activar490WC
            // 
            this.BT_Activar490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_Activar490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Activar490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_Activar490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_Activar490WC.Location = new System.Drawing.Point(819, 439);
            this.BT_Activar490WC.Name = "BT_Activar490WC";
            this.BT_Activar490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_Activar490WC.TabIndex = 128;
            this.BT_Activar490WC.Text = "Activar";
            this.BT_Activar490WC.UseVisualStyleBackColor = false;
            // 
            // labelCBDescripcion490WC
            // 
            this.labelCBDescripcion490WC.AutoSize = true;
            this.labelCBDescripcion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBDescripcion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBDescripcion490WC.Location = new System.Drawing.Point(10, 353);
            this.labelCBDescripcion490WC.Name = "labelCBDescripcion490WC";
            this.labelCBDescripcion490WC.Size = new System.Drawing.Size(153, 20);
            this.labelCBDescripcion490WC.TabIndex = 126;
            this.labelCBDescripcion490WC.Text = "Codigo Beneficio";
            // 
            // labelCBUsuario490WC
            // 
            this.labelCBUsuario490WC.AutoSize = true;
            this.labelCBUsuario490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBUsuario490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBUsuario490WC.Location = new System.Drawing.Point(10, 425);
            this.labelCBUsuario490WC.Name = "labelCBUsuario490WC";
            this.labelCBUsuario490WC.Size = new System.Drawing.Size(77, 20);
            this.labelCBUsuario490WC.TabIndex = 124;
            this.labelCBUsuario490WC.Text = "Nombre";
            // 
            // labelFechaInicio490WC
            // 
            this.labelFechaInicio490WC.AutoSize = true;
            this.labelFechaInicio490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaInicio490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaInicio490WC.Location = new System.Drawing.Point(322, 297);
            this.labelFechaInicio490WC.Name = "labelFechaInicio490WC";
            this.labelFechaInicio490WC.Size = new System.Drawing.Size(111, 20);
            this.labelFechaInicio490WC.TabIndex = 123;
            this.labelFechaInicio490WC.Text = "Fecha Inicio";
            // 
            // labelFechaFin490WC
            // 
            this.labelFechaFin490WC.AutoSize = true;
            this.labelFechaFin490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaFin490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaFin490WC.Location = new System.Drawing.Point(595, 297);
            this.labelFechaFin490WC.Name = "labelFechaFin490WC";
            this.labelFechaFin490WC.Size = new System.Drawing.Size(89, 20);
            this.labelFechaFin490WC.TabIndex = 122;
            this.labelFechaFin490WC.Text = "Fecha Fin";
            // 
            // checkBoxFecha490WC
            // 
            this.checkBoxFecha490WC.AutoSize = true;
            this.checkBoxFecha490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.checkBoxFecha490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.checkBoxFecha490WC.Location = new System.Drawing.Point(18, 320);
            this.checkBoxFecha490WC.Name = "checkBoxFecha490WC";
            this.checkBoxFecha490WC.Size = new System.Drawing.Size(145, 24);
            this.checkBoxFecha490WC.TabIndex = 121;
            this.checkBoxFecha490WC.Text = "Incluir Fecha?";
            this.checkBoxFecha490WC.UseVisualStyleBackColor = true;
            // 
            // monthCalendarFechaFin490WC
            // 
            this.monthCalendarFechaFin490WC.Location = new System.Drawing.Point(542, 320);
            this.monthCalendarFechaFin490WC.MaxSelectionCount = 1;
            this.monthCalendarFechaFin490WC.Name = "monthCalendarFechaFin490WC";
            this.monthCalendarFechaFin490WC.ShowToday = false;
            this.monthCalendarFechaFin490WC.TabIndex = 120;
            // 
            // monthCalendarFechaInicio490WC
            // 
            this.monthCalendarFechaInicio490WC.Location = new System.Drawing.Point(281, 320);
            this.monthCalendarFechaInicio490WC.MaxSelectionCount = 1;
            this.monthCalendarFechaInicio490WC.Name = "monthCalendarFechaInicio490WC";
            this.monthCalendarFechaInicio490WC.ShowToday = false;
            this.monthCalendarFechaInicio490WC.TabIndex = 119;
            // 
            // BT_LimpiarFiltros490WC
            // 
            this.BT_LimpiarFiltros490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_LimpiarFiltros490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LimpiarFiltros490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_LimpiarFiltros490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_LimpiarFiltros490WC.Location = new System.Drawing.Point(819, 378);
            this.BT_LimpiarFiltros490WC.Name = "BT_LimpiarFiltros490WC";
            this.BT_LimpiarFiltros490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_LimpiarFiltros490WC.TabIndex = 118;
            this.BT_LimpiarFiltros490WC.Text = "Limpiar Filtros";
            this.BT_LimpiarFiltros490WC.UseVisualStyleBackColor = false;
            // 
            // BT_Filtrar490WC
            // 
            this.BT_Filtrar490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_Filtrar490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Filtrar490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_Filtrar490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_Filtrar490WC.Location = new System.Drawing.Point(819, 311);
            this.BT_Filtrar490WC.Name = "BT_Filtrar490WC";
            this.BT_Filtrar490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_Filtrar490WC.TabIndex = 117;
            this.BT_Filtrar490WC.Text = "Filtrar";
            this.BT_Filtrar490WC.UseVisualStyleBackColor = false;
            // 
            // CB_CodigoBeneficio490WC
            // 
            this.CB_CodigoBeneficio490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_CodigoBeneficio490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CodigoBeneficio490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_CodigoBeneficio490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_CodigoBeneficio490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_CodigoBeneficio490WC.FormattingEnabled = true;
            this.CB_CodigoBeneficio490WC.Location = new System.Drawing.Point(14, 378);
            this.CB_CodigoBeneficio490WC.Name = "CB_CodigoBeneficio490WC";
            this.CB_CodigoBeneficio490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_CodigoBeneficio490WC.TabIndex = 115;
            // 
            // CB_NombreBeneficio490WC
            // 
            this.CB_NombreBeneficio490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_NombreBeneficio490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NombreBeneficio490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_NombreBeneficio490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_NombreBeneficio490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_NombreBeneficio490WC.FormattingEnabled = true;
            this.CB_NombreBeneficio490WC.Location = new System.Drawing.Point(14, 448);
            this.CB_NombreBeneficio490WC.Name = "CB_NombreBeneficio490WC";
            this.CB_NombreBeneficio490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_NombreBeneficio490WC.TabIndex = 113;
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
            this.ColumnaFecha,
            this.ColumnaHora,
            this.ColumnaNombre,
            this.ColumnaCantidadReclamado,
            this.ColumnaDescuentoAplicar,
            this.ColumnaPrecio,
            this.ColumnaActivo});
            this.dgvBeneficio490WC.Location = new System.Drawing.Point(18, 12);
            this.dgvBeneficio490WC.MultiSelect = false;
            this.dgvBeneficio490WC.Name = "dgvBeneficio490WC";
            this.dgvBeneficio490WC.ReadOnly = true;
            this.dgvBeneficio490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficio490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficio490WC.Size = new System.Drawing.Size(944, 272);
            this.dgvBeneficio490WC.TabIndex = 129;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Codigo Beneficio";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.ReadOnly = true;
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.Name = "ColumnaFecha";
            this.ColumnaFecha.ReadOnly = true;
            // 
            // ColumnaHora
            // 
            this.ColumnaHora.HeaderText = "Hora";
            this.ColumnaHora.Name = "ColumnaHora";
            this.ColumnaHora.ReadOnly = true;
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
            // ColumnaActivo
            // 
            this.ColumnaActivo.HeaderText = "Activo";
            this.ColumnaActivo.Name = "ColumnaActivo";
            this.ColumnaActivo.ReadOnly = true;
            // 
            // FormBitacoraCambiosBeneficio490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(980, 505);
            this.Controls.Add(this.dgvBeneficio490WC);
            this.Controls.Add(this.BT_Activar490WC);
            this.Controls.Add(this.labelCBDescripcion490WC);
            this.Controls.Add(this.labelCBUsuario490WC);
            this.Controls.Add(this.labelFechaInicio490WC);
            this.Controls.Add(this.labelFechaFin490WC);
            this.Controls.Add(this.checkBoxFecha490WC);
            this.Controls.Add(this.monthCalendarFechaFin490WC);
            this.Controls.Add(this.monthCalendarFechaInicio490WC);
            this.Controls.Add(this.BT_LimpiarFiltros490WC);
            this.Controls.Add(this.BT_Filtrar490WC);
            this.Controls.Add(this.CB_CodigoBeneficio490WC);
            this.Controls.Add(this.CB_NombreBeneficio490WC);
            this.Name = "FormBitacoraCambiosBeneficio490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBitacoraCambiosBeneficio490WC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficio490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Activar490WC;
        private System.Windows.Forms.Label labelCBDescripcion490WC;
        private System.Windows.Forms.Label labelCBUsuario490WC;
        private System.Windows.Forms.Label labelFechaInicio490WC;
        private System.Windows.Forms.Label labelFechaFin490WC;
        private System.Windows.Forms.CheckBox checkBoxFecha490WC;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaFin490WC;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaInicio490WC;
        private System.Windows.Forms.Button BT_LimpiarFiltros490WC;
        private System.Windows.Forms.Button BT_Filtrar490WC;
        private System.Windows.Forms.ComboBox CB_CodigoBeneficio490WC;
        private System.Windows.Forms.ComboBox CB_NombreBeneficio490WC;
        private System.Windows.Forms.DataGridView dgvBeneficio490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidadReclamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescuentoAplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaActivo;
    }
}