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
            this.dgvBitacora490WC = new System.Windows.Forms.DataGridView();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCriticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_Usuario490WC = new System.Windows.Forms.ComboBox();
            this.CB_Modulo490WC = new System.Windows.Forms.ComboBox();
            this.CB_Descripcion490WC = new System.Windows.Forms.ComboBox();
            this.CB_Criticidad490WC = new System.Windows.Forms.ComboBox();
            this.BT_Filtrar490WC = new System.Windows.Forms.Button();
            this.BT_LimpiarFiltros490WC = new System.Windows.Forms.Button();
            this.monthCalendarFechaInicio490WC = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarFechaFin490WC = new System.Windows.Forms.MonthCalendar();
            this.checkBoxFecha490WC = new System.Windows.Forms.CheckBox();
            this.labelFechaFin490WC = new System.Windows.Forms.Label();
            this.labelFechaInicio490WC = new System.Windows.Forms.Label();
            this.labelCBUsuario490WC = new System.Windows.Forms.Label();
            this.labelCBModulo490WC = new System.Windows.Forms.Label();
            this.labelCBDescripcion490WC = new System.Windows.Forms.Label();
            this.labelCBCriticidad490WC = new System.Windows.Forms.Label();
            this.labelUsuario490WC = new System.Windows.Forms.Label();
            this.labelNombre490WC = new System.Windows.Forms.Label();
            this.labelApellido490WC = new System.Windows.Forms.Label();
            this.labelDNI490WC = new System.Windows.Forms.Label();
            this.BT_IMPRIMIR490WC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacora490WC
            // 
            this.dgvBitacora490WC.AllowUserToAddRows = false;
            this.dgvBitacora490WC.AllowUserToDeleteRows = false;
            this.dgvBitacora490WC.AllowUserToResizeColumns = false;
            this.dgvBitacora490WC.AllowUserToResizeRows = false;
            this.dgvBitacora490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsuario,
            this.ColumnFecha,
            this.ColumnaHora,
            this.ColumnaModulo,
            this.ColumnaDescripcion,
            this.ColumnaCriticidad});
            this.dgvBitacora490WC.Location = new System.Drawing.Point(12, 12);
            this.dgvBitacora490WC.MultiSelect = false;
            this.dgvBitacora490WC.Name = "dgvBitacora490WC";
            this.dgvBitacora490WC.ReadOnly = true;
            this.dgvBitacora490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBitacora490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora490WC.Size = new System.Drawing.Size(950, 219);
            this.dgvBitacora490WC.TabIndex = 1;
            this.dgvBitacora490WC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBitacora_CellMouseClick);
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
            // CB_Usuario490WC
            // 
            this.CB_Usuario490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Usuario490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Usuario490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Usuario490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Usuario490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Usuario490WC.FormattingEnabled = true;
            this.CB_Usuario490WC.Location = new System.Drawing.Point(327, 267);
            this.CB_Usuario490WC.Name = "CB_Usuario490WC";
            this.CB_Usuario490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_Usuario490WC.TabIndex = 93;
            // 
            // CB_Modulo490WC
            // 
            this.CB_Modulo490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Modulo490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Modulo490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Modulo490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Modulo490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Modulo490WC.FormattingEnabled = true;
            this.CB_Modulo490WC.Location = new System.Drawing.Point(327, 335);
            this.CB_Modulo490WC.Name = "CB_Modulo490WC";
            this.CB_Modulo490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_Modulo490WC.TabIndex = 94;
            this.CB_Modulo490WC.SelectedIndexChanged += new System.EventHandler(this.CB_Modulo490WC_SelectedIndexChanged);
            // 
            // CB_Descripcion490WC
            // 
            this.CB_Descripcion490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Descripcion490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Descripcion490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Descripcion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Descripcion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Descripcion490WC.FormattingEnabled = true;
            this.CB_Descripcion490WC.Location = new System.Drawing.Point(327, 399);
            this.CB_Descripcion490WC.Name = "CB_Descripcion490WC";
            this.CB_Descripcion490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_Descripcion490WC.TabIndex = 95;
            // 
            // CB_Criticidad490WC
            // 
            this.CB_Criticidad490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Criticidad490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Criticidad490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Criticidad490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Criticidad490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Criticidad490WC.FormattingEnabled = true;
            this.CB_Criticidad490WC.Location = new System.Drawing.Point(327, 461);
            this.CB_Criticidad490WC.Name = "CB_Criticidad490WC";
            this.CB_Criticidad490WC.Size = new System.Drawing.Size(165, 27);
            this.CB_Criticidad490WC.TabIndex = 96;
            // 
            // BT_Filtrar490WC
            // 
            this.BT_Filtrar490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_Filtrar490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Filtrar490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_Filtrar490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_Filtrar490WC.Location = new System.Drawing.Point(529, 452);
            this.BT_Filtrar490WC.Name = "BT_Filtrar490WC";
            this.BT_Filtrar490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_Filtrar490WC.TabIndex = 97;
            this.BT_Filtrar490WC.Text = "Filtrar";
            this.BT_Filtrar490WC.UseVisualStyleBackColor = false;
            this.BT_Filtrar490WC.Click += new System.EventHandler(this.BT_Filtrar_Click);
            // 
            // BT_LimpiarFiltros490WC
            // 
            this.BT_LimpiarFiltros490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_LimpiarFiltros490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LimpiarFiltros490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_LimpiarFiltros490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_LimpiarFiltros490WC.Location = new System.Drawing.Point(678, 452);
            this.BT_LimpiarFiltros490WC.Name = "BT_LimpiarFiltros490WC";
            this.BT_LimpiarFiltros490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_LimpiarFiltros490WC.TabIndex = 98;
            this.BT_LimpiarFiltros490WC.Text = "Limpiar Filtros";
            this.BT_LimpiarFiltros490WC.UseVisualStyleBackColor = false;
            this.BT_LimpiarFiltros490WC.Click += new System.EventHandler(this.BT_LimpiarFiltros_Click);
            // 
            // monthCalendarFechaInicio490WC
            // 
            this.monthCalendarFechaInicio490WC.Location = new System.Drawing.Point(540, 280);
            this.monthCalendarFechaInicio490WC.MaxSelectionCount = 1;
            this.monthCalendarFechaInicio490WC.Name = "monthCalendarFechaInicio490WC";
            this.monthCalendarFechaInicio490WC.ShowToday = false;
            this.monthCalendarFechaInicio490WC.TabIndex = 99;
            // 
            // monthCalendarFechaFin490WC
            // 
            this.monthCalendarFechaFin490WC.Location = new System.Drawing.Point(770, 280);
            this.monthCalendarFechaFin490WC.MaxSelectionCount = 1;
            this.monthCalendarFechaFin490WC.Name = "monthCalendarFechaFin490WC";
            this.monthCalendarFechaFin490WC.ShowToday = false;
            this.monthCalendarFechaFin490WC.TabIndex = 100;
            // 
            // checkBoxFecha490WC
            // 
            this.checkBoxFecha490WC.AutoSize = true;
            this.checkBoxFecha490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.checkBoxFecha490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.checkBoxFecha490WC.Location = new System.Drawing.Point(698, 237);
            this.checkBoxFecha490WC.Name = "checkBoxFecha490WC";
            this.checkBoxFecha490WC.Size = new System.Drawing.Size(145, 24);
            this.checkBoxFecha490WC.TabIndex = 101;
            this.checkBoxFecha490WC.Text = "Incluir Fecha?";
            this.checkBoxFecha490WC.UseVisualStyleBackColor = true;
            this.checkBoxFecha490WC.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // labelFechaFin490WC
            // 
            this.labelFechaFin490WC.AutoSize = true;
            this.labelFechaFin490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaFin490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaFin490WC.Location = new System.Drawing.Point(823, 257);
            this.labelFechaFin490WC.Name = "labelFechaFin490WC";
            this.labelFechaFin490WC.Size = new System.Drawing.Size(89, 20);
            this.labelFechaFin490WC.TabIndex = 102;
            this.labelFechaFin490WC.Text = "Fecha Fin";
            // 
            // labelFechaInicio490WC
            // 
            this.labelFechaInicio490WC.AutoSize = true;
            this.labelFechaInicio490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaInicio490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaInicio490WC.Location = new System.Drawing.Point(582, 257);
            this.labelFechaInicio490WC.Name = "labelFechaInicio490WC";
            this.labelFechaInicio490WC.Size = new System.Drawing.Size(111, 20);
            this.labelFechaInicio490WC.TabIndex = 103;
            this.labelFechaInicio490WC.Text = "Fecha Inicio";
            // 
            // labelCBUsuario490WC
            // 
            this.labelCBUsuario490WC.AutoSize = true;
            this.labelCBUsuario490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBUsuario490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBUsuario490WC.Location = new System.Drawing.Point(323, 244);
            this.labelCBUsuario490WC.Name = "labelCBUsuario490WC";
            this.labelCBUsuario490WC.Size = new System.Drawing.Size(74, 20);
            this.labelCBUsuario490WC.TabIndex = 104;
            this.labelCBUsuario490WC.Text = "Usuario";
            // 
            // labelCBModulo490WC
            // 
            this.labelCBModulo490WC.AutoSize = true;
            this.labelCBModulo490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBModulo490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBModulo490WC.Location = new System.Drawing.Point(323, 312);
            this.labelCBModulo490WC.Name = "labelCBModulo490WC";
            this.labelCBModulo490WC.Size = new System.Drawing.Size(73, 20);
            this.labelCBModulo490WC.TabIndex = 105;
            this.labelCBModulo490WC.Text = "Módulo";
            // 
            // labelCBDescripcion490WC
            // 
            this.labelCBDescripcion490WC.AutoSize = true;
            this.labelCBDescripcion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBDescripcion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBDescripcion490WC.Location = new System.Drawing.Point(323, 374);
            this.labelCBDescripcion490WC.Name = "labelCBDescripcion490WC";
            this.labelCBDescripcion490WC.Size = new System.Drawing.Size(110, 20);
            this.labelCBDescripcion490WC.TabIndex = 106;
            this.labelCBDescripcion490WC.Text = "Descripción";
            // 
            // labelCBCriticidad490WC
            // 
            this.labelCBCriticidad490WC.AutoSize = true;
            this.labelCBCriticidad490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCBCriticidad490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCBCriticidad490WC.Location = new System.Drawing.Point(323, 438);
            this.labelCBCriticidad490WC.Name = "labelCBCriticidad490WC";
            this.labelCBCriticidad490WC.Size = new System.Drawing.Size(92, 20);
            this.labelCBCriticidad490WC.TabIndex = 107;
            this.labelCBCriticidad490WC.Text = "Criticidad";
            // 
            // labelUsuario490WC
            // 
            this.labelUsuario490WC.AutoSize = true;
            this.labelUsuario490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelUsuario490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelUsuario490WC.Location = new System.Drawing.Point(12, 267);
            this.labelUsuario490WC.Name = "labelUsuario490WC";
            this.labelUsuario490WC.Size = new System.Drawing.Size(94, 20);
            this.labelUsuario490WC.TabIndex = 108;
            this.labelUsuario490WC.Text = "Username";
            // 
            // labelNombre490WC
            // 
            this.labelNombre490WC.AutoSize = true;
            this.labelNombre490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelNombre490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelNombre490WC.Location = new System.Drawing.Point(12, 312);
            this.labelNombre490WC.Name = "labelNombre490WC";
            this.labelNombre490WC.Size = new System.Drawing.Size(77, 20);
            this.labelNombre490WC.TabIndex = 109;
            this.labelNombre490WC.Text = "Nombre";
            // 
            // labelApellido490WC
            // 
            this.labelApellido490WC.AutoSize = true;
            this.labelApellido490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelApellido490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelApellido490WC.Location = new System.Drawing.Point(12, 359);
            this.labelApellido490WC.Name = "labelApellido490WC";
            this.labelApellido490WC.Size = new System.Drawing.Size(79, 20);
            this.labelApellido490WC.TabIndex = 110;
            this.labelApellido490WC.Text = "Apellido";
            // 
            // labelDNI490WC
            // 
            this.labelDNI490WC.AutoSize = true;
            this.labelDNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelDNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelDNI490WC.Location = new System.Drawing.Point(12, 406);
            this.labelDNI490WC.Name = "labelDNI490WC";
            this.labelDNI490WC.Size = new System.Drawing.Size(40, 20);
            this.labelDNI490WC.TabIndex = 111;
            this.labelDNI490WC.Text = "DNI";
            // 
            // BT_IMPRIMIR490WC
            // 
            this.BT_IMPRIMIR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_IMPRIMIR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_IMPRIMIR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_IMPRIMIR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_IMPRIMIR490WC.Location = new System.Drawing.Point(827, 452);
            this.BT_IMPRIMIR490WC.Name = "BT_IMPRIMIR490WC";
            this.BT_IMPRIMIR490WC.Size = new System.Drawing.Size(143, 43);
            this.BT_IMPRIMIR490WC.TabIndex = 112;
            this.BT_IMPRIMIR490WC.Text = "Imprimir";
            this.BT_IMPRIMIR490WC.UseVisualStyleBackColor = false;
            this.BT_IMPRIMIR490WC.Click += new System.EventHandler(this.BT_IMPRIMIR490WC_Click);
            // 
            // FormBitacoraDeEventos490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(980, 505);
            this.Controls.Add(this.BT_IMPRIMIR490WC);
            this.Controls.Add(this.labelDNI490WC);
            this.Controls.Add(this.labelApellido490WC);
            this.Controls.Add(this.labelNombre490WC);
            this.Controls.Add(this.labelUsuario490WC);
            this.Controls.Add(this.labelCBCriticidad490WC);
            this.Controls.Add(this.labelCBDescripcion490WC);
            this.Controls.Add(this.labelCBModulo490WC);
            this.Controls.Add(this.labelCBUsuario490WC);
            this.Controls.Add(this.labelFechaInicio490WC);
            this.Controls.Add(this.labelFechaFin490WC);
            this.Controls.Add(this.checkBoxFecha490WC);
            this.Controls.Add(this.monthCalendarFechaFin490WC);
            this.Controls.Add(this.monthCalendarFechaInicio490WC);
            this.Controls.Add(this.BT_LimpiarFiltros490WC);
            this.Controls.Add(this.BT_Filtrar490WC);
            this.Controls.Add(this.CB_Criticidad490WC);
            this.Controls.Add(this.CB_Descripcion490WC);
            this.Controls.Add(this.CB_Modulo490WC);
            this.Controls.Add(this.CB_Usuario490WC);
            this.Controls.Add(this.dgvBitacora490WC);
            this.Name = "FormBitacoraDeEventos490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBitacoraDeEventos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBitacoraDeEventos490WC_FormClosed);
            this.Load += new System.EventHandler(this.FormBitacoraDeEventos490WC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora490WC;
        private System.Windows.Forms.ComboBox CB_Usuario490WC;
        private System.Windows.Forms.ComboBox CB_Modulo490WC;
        private System.Windows.Forms.ComboBox CB_Descripcion490WC;
        private System.Windows.Forms.ComboBox CB_Criticidad490WC;
        private System.Windows.Forms.Button BT_Filtrar490WC;
        private System.Windows.Forms.Button BT_LimpiarFiltros490WC;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaInicio490WC;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaFin490WC;
        private System.Windows.Forms.CheckBox checkBoxFecha490WC;
        private System.Windows.Forms.Label labelFechaFin490WC;
        private System.Windows.Forms.Label labelFechaInicio490WC;
        private System.Windows.Forms.Label labelCBUsuario490WC;
        private System.Windows.Forms.Label labelCBModulo490WC;
        private System.Windows.Forms.Label labelCBDescripcion490WC;
        private System.Windows.Forms.Label labelCBCriticidad490WC;
        private System.Windows.Forms.Label labelUsuario490WC;
        private System.Windows.Forms.Label labelNombre490WC;
        private System.Windows.Forms.Label labelApellido490WC;
        private System.Windows.Forms.Label labelDNI490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCriticidad;
        private System.Windows.Forms.Button BT_IMPRIMIR490WC;
    }
}