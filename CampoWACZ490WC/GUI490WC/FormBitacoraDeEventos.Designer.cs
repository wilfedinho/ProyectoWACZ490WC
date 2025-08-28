namespace GUI490WC
{
    partial class FormBitacoraDeEventos490WC
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
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCriticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_Usuario = new System.Windows.Forms.ComboBox();
            this.CB_Modulo = new System.Windows.Forms.ComboBox();
            this.CB_Descripcion = new System.Windows.Forms.ComboBox();
            this.CB_Criticidad = new System.Windows.Forms.ComboBox();
            this.BT_Filtrar = new System.Windows.Forms.Button();
            this.BT_LimpiarFiltros = new System.Windows.Forms.Button();
            this.monthCalendarFechaInicio = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarFechaFin = new System.Windows.Forms.MonthCalendar();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelCBUsuario = new System.Windows.Forms.Label();
            this.labelCBModulo = new System.Windows.Forms.Label();
            this.labelCBDescripcion = new System.Windows.Forms.Label();
            this.labelCBCriticidad = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsuario,
            this.ColumnFecha,
            this.ColumnaHora,
            this.ColumnaModulo,
            this.ColumnaDescripcion,
            this.ColumnaCriticidad});
            this.dgvBitacora.Location = new System.Drawing.Point(12, 12);
            this.dgvBitacora.MultiSelect = false;
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(950, 219);
            this.dgvBitacora.TabIndex = 1;
            this.dgvBitacora.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBitacora_CellMouseClick);
            // 
            // ColumnUsuario
            // 
            this.ColumnUsuario.HeaderText = "Usuario";
            this.ColumnUsuario.Name = "ColumnUsuario";
            this.ColumnUsuario.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnaHora
            // 
            this.ColumnaHora.HeaderText = "Hora";
            this.ColumnaHora.Name = "ColumnaHora";
            this.ColumnaHora.ReadOnly = true;
            // 
            // ColumnaModulo
            // 
            this.ColumnaModulo.HeaderText = "Modulo";
            this.ColumnaModulo.Name = "ColumnaModulo";
            this.ColumnaModulo.ReadOnly = true;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            this.ColumnaDescripcion.ReadOnly = true;
            // 
            // ColumnaCriticidad
            // 
            this.ColumnaCriticidad.HeaderText = "Criticidad";
            this.ColumnaCriticidad.Name = "ColumnaCriticidad";
            this.ColumnaCriticidad.ReadOnly = true;
            // 
            // CB_Usuario
            // 
            this.CB_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Usuario.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Usuario.FormattingEnabled = true;
            this.CB_Usuario.Location = new System.Drawing.Point(327, 267);
            this.CB_Usuario.Name = "CB_Usuario";
            this.CB_Usuario.Size = new System.Drawing.Size(165, 27);
            this.CB_Usuario.TabIndex = 93;
            // 
            // CB_Modulo
            // 
            this.CB_Modulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Modulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Modulo.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Modulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Modulo.FormattingEnabled = true;
            this.CB_Modulo.Location = new System.Drawing.Point(327, 335);
            this.CB_Modulo.Name = "CB_Modulo";
            this.CB_Modulo.Size = new System.Drawing.Size(165, 27);
            this.CB_Modulo.TabIndex = 94;
            // 
            // CB_Descripcion
            // 
            this.CB_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Descripcion.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Descripcion.FormattingEnabled = true;
            this.CB_Descripcion.Location = new System.Drawing.Point(327, 399);
            this.CB_Descripcion.Name = "CB_Descripcion";
            this.CB_Descripcion.Size = new System.Drawing.Size(165, 27);
            this.CB_Descripcion.TabIndex = 95;
            // 
            // CB_Criticidad
            // 
            this.CB_Criticidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Criticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Criticidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Criticidad.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Criticidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Criticidad.FormattingEnabled = true;
            this.CB_Criticidad.Location = new System.Drawing.Point(327, 461);
            this.CB_Criticidad.Name = "CB_Criticidad";
            this.CB_Criticidad.Size = new System.Drawing.Size(165, 27);
            this.CB_Criticidad.TabIndex = 96;
            // 
            // BT_Filtrar
            // 
            this.BT_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Filtrar.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_Filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_Filtrar.Location = new System.Drawing.Point(560, 452);
            this.BT_Filtrar.Name = "BT_Filtrar";
            this.BT_Filtrar.Size = new System.Drawing.Size(192, 43);
            this.BT_Filtrar.TabIndex = 97;
            this.BT_Filtrar.Text = "Filtrar";
            this.BT_Filtrar.UseVisualStyleBackColor = false;
            this.BT_Filtrar.Click += new System.EventHandler(this.BT_Filtrar_Click);
            // 
            // BT_LimpiarFiltros
            // 
            this.BT_LimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_LimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LimpiarFiltros.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_LimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_LimpiarFiltros.Location = new System.Drawing.Point(770, 454);
            this.BT_LimpiarFiltros.Name = "BT_LimpiarFiltros";
            this.BT_LimpiarFiltros.Size = new System.Drawing.Size(192, 39);
            this.BT_LimpiarFiltros.TabIndex = 98;
            this.BT_LimpiarFiltros.Text = "Limpiar Filtros";
            this.BT_LimpiarFiltros.UseVisualStyleBackColor = false;
            this.BT_LimpiarFiltros.Click += new System.EventHandler(this.BT_LimpiarFiltros_Click);
            // 
            // monthCalendarFechaInicio
            // 
            this.monthCalendarFechaInicio.Location = new System.Drawing.Point(560, 280);
            this.monthCalendarFechaInicio.MaxSelectionCount = 1;
            this.monthCalendarFechaInicio.Name = "monthCalendarFechaInicio";
            this.monthCalendarFechaInicio.ShowToday = false;
            this.monthCalendarFechaInicio.TabIndex = 99;
            // 
            // monthCalendarFechaFin
            // 
            this.monthCalendarFechaFin.Location = new System.Drawing.Point(770, 280);
            this.monthCalendarFechaFin.MaxSelectionCount = 1;
            this.monthCalendarFechaFin.Name = "monthCalendarFechaFin";
            this.monthCalendarFechaFin.ShowToday = false;
            this.monthCalendarFechaFin.TabIndex = 100;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.checkBoxFecha.Location = new System.Drawing.Point(698, 237);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(145, 24);
            this.checkBoxFecha.TabIndex = 101;
            this.checkBoxFecha.Text = "Incluir Fecha?";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaFin.Location = new System.Drawing.Point(823, 257);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(89, 20);
            this.labelFechaFin.TabIndex = 102;
            this.labelFechaFin.Text = "Fecha Fin";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaInicio.Location = new System.Drawing.Point(602, 257);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(111, 20);
            this.labelFechaInicio.TabIndex = 103;
            this.labelFechaInicio.Text = "Fecha Inicio";
            // 
            // labelCBUsuario
            // 
            this.labelCBUsuario.AutoSize = true;
            this.labelCBUsuario.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBUsuario.Location = new System.Drawing.Point(323, 244);
            this.labelCBUsuario.Name = "labelCBUsuario";
            this.labelCBUsuario.Size = new System.Drawing.Size(74, 20);
            this.labelCBUsuario.TabIndex = 104;
            this.labelCBUsuario.Text = "Usuario";
            // 
            // labelCBModulo
            // 
            this.labelCBModulo.AutoSize = true;
            this.labelCBModulo.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBModulo.Location = new System.Drawing.Point(323, 312);
            this.labelCBModulo.Name = "labelCBModulo";
            this.labelCBModulo.Size = new System.Drawing.Size(73, 20);
            this.labelCBModulo.TabIndex = 105;
            this.labelCBModulo.Text = "Módulo";
            // 
            // labelCBDescripcion
            // 
            this.labelCBDescripcion.AutoSize = true;
            this.labelCBDescripcion.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBDescripcion.Location = new System.Drawing.Point(323, 374);
            this.labelCBDescripcion.Name = "labelCBDescripcion";
            this.labelCBDescripcion.Size = new System.Drawing.Size(110, 20);
            this.labelCBDescripcion.TabIndex = 106;
            this.labelCBDescripcion.Text = "Descripción";
            // 
            // labelCBCriticidad
            // 
            this.labelCBCriticidad.AutoSize = true;
            this.labelCBCriticidad.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBCriticidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBCriticidad.Location = new System.Drawing.Point(323, 438);
            this.labelCBCriticidad.Name = "labelCBCriticidad";
            this.labelCBCriticidad.Size = new System.Drawing.Size(92, 20);
            this.labelCBCriticidad.TabIndex = 107;
            this.labelCBCriticidad.Text = "Criticidad";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelUsuario.Location = new System.Drawing.Point(12, 267);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(94, 20);
            this.labelUsuario.TabIndex = 108;
            this.labelUsuario.Text = "Username";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelNombre.Location = new System.Drawing.Point(12, 312);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 20);
            this.labelNombre.TabIndex = 109;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelApellido.Location = new System.Drawing.Point(12, 359);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(79, 20);
            this.labelApellido.TabIndex = 110;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelDNI.Location = new System.Drawing.Point(12, 406);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(40, 20);
            this.labelDNI.TabIndex = 111;
            this.labelDNI.Text = "DNI";
            // 
            // FormBitacoraDeEventos490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(980, 505);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelCBCriticidad);
            this.Controls.Add(this.labelCBDescripcion);
            this.Controls.Add(this.labelCBModulo);
            this.Controls.Add(this.labelCBUsuario);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.monthCalendarFechaFin);
            this.Controls.Add(this.monthCalendarFechaInicio);
            this.Controls.Add(this.BT_LimpiarFiltros);
            this.Controls.Add(this.BT_Filtrar);
            this.Controls.Add(this.CB_Criticidad);
            this.Controls.Add(this.CB_Descripcion);
            this.Controls.Add(this.CB_Modulo);
            this.Controls.Add(this.CB_Usuario);
            this.Controls.Add(this.dgvBitacora);
            this.Name = "FormBitacoraDeEventos490WC";
            this.Text = "FormBitacoraDeEventos";
            this.Load += new System.EventHandler(this.FormBitacoraDeEventos490WC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.ComboBox CB_Usuario;
        private System.Windows.Forms.ComboBox CB_Modulo;
        private System.Windows.Forms.ComboBox CB_Descripcion;
        private System.Windows.Forms.ComboBox CB_Criticidad;
        private System.Windows.Forms.Button BT_Filtrar;
        private System.Windows.Forms.Button BT_LimpiarFiltros;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaInicio;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaFin;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelCBUsuario;
        private System.Windows.Forms.Label labelCBModulo;
        private System.Windows.Forms.Label labelCBDescripcion;
        private System.Windows.Forms.Label labelCBCriticidad;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCriticidad;
    }
}