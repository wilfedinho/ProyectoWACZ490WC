namespace GUI490WC
{
    partial class ControlModalidadIDA490WC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBoleto490WC = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPartidaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaLlegadaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClaseBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPesoEquipajePermitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumeroAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABEL_FECHALLEGADA_IDA490WC = new System.Windows.Forms.Label();
            this.LABEL_FECHAPARTIDA_IDA490WC = new System.Windows.Forms.Label();
            this.calendarioFECHALLEGADA_IDA490WC = new System.Windows.Forms.MonthCalendar();
            this.calendarioFECHAPARTIDA_IDA490WC = new System.Windows.Forms.MonthCalendar();
            this.BT_LIMPIARFILTROS490WC = new System.Windows.Forms.Button();
            this.BT_FILTRAR490WC = new System.Windows.Forms.Button();
            this.LABEL_ORIGEN490WC = new System.Windows.Forms.Label();
            this.LABEL_DESTINO490WC = new System.Windows.Forms.Label();
            this.CB_CLASEBOLETO490WC = new System.Windows.Forms.ComboBox();
            this.LABEL_CLASEBOLETO490WC = new System.Windows.Forms.Label();
            this.CB_DESTINO490WC = new System.Windows.Forms.ComboBox();
            this.CB_ORIGEN490WC = new System.Windows.Forms.ComboBox();
            this.checkBoxINCLUIRFECHA490WC = new System.Windows.Forms.CheckBox();
            this.LABEL_PRECIO490WC = new System.Windows.Forms.Label();
            this.TB_PRECIODESDE490WC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PRECIOHASTA490WC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PESO490WC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleto490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoleto490WC
            // 
            this.dgvBoleto490WC.AllowUserToAddRows = false;
            this.dgvBoleto490WC.AllowUserToDeleteRows = false;
            this.dgvBoleto490WC.AllowUserToResizeColumns = false;
            this.dgvBoleto490WC.AllowUserToResizeRows = false;
            this.dgvBoleto490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoleto490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoleto490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaModalidad,
            this.ColumnaOrigen,
            this.ColumnaDestino,
            this.ColumnaFechaPartidaIDA,
            this.ColumnaFechaLlegadaIDA,
            this.ColumnaClaseBoleto,
            this.ColumnaPesoEquipajePermitido,
            this.ColumnaPrecio,
            this.ColumnaNumeroAsiento});
            this.dgvBoleto490WC.Location = new System.Drawing.Point(3, 3);
            this.dgvBoleto490WC.MultiSelect = false;
            this.dgvBoleto490WC.Name = "dgvBoleto490WC";
            this.dgvBoleto490WC.ReadOnly = true;
            this.dgvBoleto490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBoleto490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoleto490WC.Size = new System.Drawing.Size(1000, 311);
            this.dgvBoleto490WC.TabIndex = 2;
            this.dgvBoleto490WC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBoleto490WC_CellMouseClick);
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "Column1";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            this.ColumnaID.Visible = false;
            // 
            // ColumnaModalidad
            // 
            this.ColumnaModalidad.HeaderText = "Modalidad";
            this.ColumnaModalidad.Name = "ColumnaModalidad";
            this.ColumnaModalidad.ReadOnly = true;
            // 
            // ColumnaOrigen
            // 
            this.ColumnaOrigen.HeaderText = "Origen";
            this.ColumnaOrigen.Name = "ColumnaOrigen";
            this.ColumnaOrigen.ReadOnly = true;
            // 
            // ColumnaDestino
            // 
            this.ColumnaDestino.HeaderText = "Destino";
            this.ColumnaDestino.Name = "ColumnaDestino";
            this.ColumnaDestino.ReadOnly = true;
            // 
            // ColumnaFechaPartidaIDA
            // 
            this.ColumnaFechaPartidaIDA.HeaderText = "FechaPartida IDA";
            this.ColumnaFechaPartidaIDA.Name = "ColumnaFechaPartidaIDA";
            this.ColumnaFechaPartidaIDA.ReadOnly = true;
            // 
            // ColumnaFechaLlegadaIDA
            // 
            this.ColumnaFechaLlegadaIDA.HeaderText = "FechaLlegada IDA";
            this.ColumnaFechaLlegadaIDA.Name = "ColumnaFechaLlegadaIDA";
            this.ColumnaFechaLlegadaIDA.ReadOnly = true;
            // 
            // ColumnaClaseBoleto
            // 
            this.ColumnaClaseBoleto.HeaderText = "Clase Boleto";
            this.ColumnaClaseBoleto.Name = "ColumnaClaseBoleto";
            this.ColumnaClaseBoleto.ReadOnly = true;
            // 
            // ColumnaPesoEquipajePermitido
            // 
            this.ColumnaPesoEquipajePermitido.HeaderText = "Peso Equipaje Permitido";
            this.ColumnaPesoEquipajePermitido.Name = "ColumnaPesoEquipajePermitido";
            this.ColumnaPesoEquipajePermitido.ReadOnly = true;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.ReadOnly = true;
            // 
            // ColumnaNumeroAsiento
            // 
            this.ColumnaNumeroAsiento.HeaderText = "Numero Asiento";
            this.ColumnaNumeroAsiento.Name = "ColumnaNumeroAsiento";
            this.ColumnaNumeroAsiento.ReadOnly = true;
            // 
            // LABEL_FECHALLEGADA_IDA490WC
            // 
            this.LABEL_FECHALLEGADA_IDA490WC.AutoSize = true;
            this.LABEL_FECHALLEGADA_IDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHALLEGADA_IDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHALLEGADA_IDA490WC.Location = new System.Drawing.Point(613, 328);
            this.LABEL_FECHALLEGADA_IDA490WC.Name = "LABEL_FECHALLEGADA_IDA490WC";
            this.LABEL_FECHALLEGADA_IDA490WC.Size = new System.Drawing.Size(166, 20);
            this.LABEL_FECHALLEGADA_IDA490WC.TabIndex = 60;
            this.LABEL_FECHALLEGADA_IDA490WC.Text = "Fecha Llegada IDA";
            // 
            // LABEL_FECHAPARTIDA_IDA490WC
            // 
            this.LABEL_FECHAPARTIDA_IDA490WC.AutoSize = true;
            this.LABEL_FECHAPARTIDA_IDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHAPARTIDA_IDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHAPARTIDA_IDA490WC.Location = new System.Drawing.Point(376, 328);
            this.LABEL_FECHAPARTIDA_IDA490WC.Name = "LABEL_FECHAPARTIDA_IDA490WC";
            this.LABEL_FECHAPARTIDA_IDA490WC.Size = new System.Drawing.Size(161, 20);
            this.LABEL_FECHAPARTIDA_IDA490WC.TabIndex = 59;
            this.LABEL_FECHAPARTIDA_IDA490WC.Text = "Fecha Partida IDA";
            // 
            // calendarioFECHALLEGADA_IDA490WC
            // 
            this.calendarioFECHALLEGADA_IDA490WC.Location = new System.Drawing.Point(580, 364);
            this.calendarioFECHALLEGADA_IDA490WC.MaxSelectionCount = 1;
            this.calendarioFECHALLEGADA_IDA490WC.Name = "calendarioFECHALLEGADA_IDA490WC";
            this.calendarioFECHALLEGADA_IDA490WC.TabIndex = 58;
            // 
            // calendarioFECHAPARTIDA_IDA490WC
            // 
            this.calendarioFECHAPARTIDA_IDA490WC.Location = new System.Drawing.Point(345, 364);
            this.calendarioFECHAPARTIDA_IDA490WC.MaxSelectionCount = 1;
            this.calendarioFECHAPARTIDA_IDA490WC.Name = "calendarioFECHAPARTIDA_IDA490WC";
            this.calendarioFECHAPARTIDA_IDA490WC.TabIndex = 57;
            // 
            // BT_LIMPIARFILTROS490WC
            // 
            this.BT_LIMPIARFILTROS490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_LIMPIARFILTROS490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LIMPIARFILTROS490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_LIMPIARFILTROS490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_LIMPIARFILTROS490WC.Location = new System.Drawing.Point(819, 420);
            this.BT_LIMPIARFILTROS490WC.Name = "BT_LIMPIARFILTROS490WC";
            this.BT_LIMPIARFILTROS490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_LIMPIARFILTROS490WC.TabIndex = 62;
            this.BT_LIMPIARFILTROS490WC.Text = "Limpiar Filtros";
            this.BT_LIMPIARFILTROS490WC.UseVisualStyleBackColor = false;
            this.BT_LIMPIARFILTROS490WC.Click += new System.EventHandler(this.BT_LIMPIARFILTROS490WC_Click);
            // 
            // BT_FILTRAR490WC
            // 
            this.BT_FILTRAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_FILTRAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_FILTRAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_FILTRAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_FILTRAR490WC.Location = new System.Drawing.Point(819, 367);
            this.BT_FILTRAR490WC.Name = "BT_FILTRAR490WC";
            this.BT_FILTRAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_FILTRAR490WC.TabIndex = 61;
            this.BT_FILTRAR490WC.Text = "Filtrar";
            this.BT_FILTRAR490WC.UseVisualStyleBackColor = false;
            this.BT_FILTRAR490WC.Click += new System.EventHandler(this.BT_FILTRAR490WC_Click);
            // 
            // LABEL_ORIGEN490WC
            // 
            this.LABEL_ORIGEN490WC.AutoSize = true;
            this.LABEL_ORIGEN490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_ORIGEN490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_ORIGEN490WC.Location = new System.Drawing.Point(14, 328);
            this.LABEL_ORIGEN490WC.Name = "LABEL_ORIGEN490WC";
            this.LABEL_ORIGEN490WC.Size = new System.Drawing.Size(65, 20);
            this.LABEL_ORIGEN490WC.TabIndex = 64;
            this.LABEL_ORIGEN490WC.Text = "Origen";
            // 
            // LABEL_DESTINO490WC
            // 
            this.LABEL_DESTINO490WC.AutoSize = true;
            this.LABEL_DESTINO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DESTINO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DESTINO490WC.Location = new System.Drawing.Point(14, 394);
            this.LABEL_DESTINO490WC.Name = "LABEL_DESTINO490WC";
            this.LABEL_DESTINO490WC.Size = new System.Drawing.Size(74, 20);
            this.LABEL_DESTINO490WC.TabIndex = 65;
            this.LABEL_DESTINO490WC.Text = "Destino";
            // 
            // CB_CLASEBOLETO490WC
            // 
            this.CB_CLASEBOLETO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_CLASEBOLETO490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CLASEBOLETO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_CLASEBOLETO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_CLASEBOLETO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_CLASEBOLETO490WC.FormattingEnabled = true;
            this.CB_CLASEBOLETO490WC.Items.AddRange(new object[] {
            "Turista",
            "Ejecutiva",
            "Primera Clase"});
            this.CB_CLASEBOLETO490WC.Location = new System.Drawing.Point(18, 495);
            this.CB_CLASEBOLETO490WC.Name = "CB_CLASEBOLETO490WC";
            this.CB_CLASEBOLETO490WC.Size = new System.Drawing.Size(146, 27);
            this.CB_CLASEBOLETO490WC.TabIndex = 66;
            // 
            // LABEL_CLASEBOLETO490WC
            // 
            this.LABEL_CLASEBOLETO490WC.AutoSize = true;
            this.LABEL_CLASEBOLETO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_CLASEBOLETO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_CLASEBOLETO490WC.Location = new System.Drawing.Point(14, 467);
            this.LABEL_CLASEBOLETO490WC.Name = "LABEL_CLASEBOLETO490WC";
            this.LABEL_CLASEBOLETO490WC.Size = new System.Drawing.Size(117, 20);
            this.LABEL_CLASEBOLETO490WC.TabIndex = 67;
            this.LABEL_CLASEBOLETO490WC.Text = "Clase Boleto";
            // 
            // CB_DESTINO490WC
            // 
            this.CB_DESTINO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_DESTINO490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DESTINO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_DESTINO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_DESTINO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_DESTINO490WC.FormattingEnabled = true;
            this.CB_DESTINO490WC.Items.AddRange(new object[] {
            "Turista",
            "Ejecutiva",
            "Primera Clase"});
            this.CB_DESTINO490WC.Location = new System.Drawing.Point(18, 420);
            this.CB_DESTINO490WC.Name = "CB_DESTINO490WC";
            this.CB_DESTINO490WC.Size = new System.Drawing.Size(146, 27);
            this.CB_DESTINO490WC.TabIndex = 68;
            // 
            // CB_ORIGEN490WC
            // 
            this.CB_ORIGEN490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_ORIGEN490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ORIGEN490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_ORIGEN490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_ORIGEN490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_ORIGEN490WC.FormattingEnabled = true;
            this.CB_ORIGEN490WC.Items.AddRange(new object[] {
            "Turista",
            "Ejecutiva",
            "Primera Clase"});
            this.CB_ORIGEN490WC.Location = new System.Drawing.Point(18, 351);
            this.CB_ORIGEN490WC.Name = "CB_ORIGEN490WC";
            this.CB_ORIGEN490WC.Size = new System.Drawing.Size(146, 27);
            this.CB_ORIGEN490WC.TabIndex = 69;
            // 
            // checkBoxINCLUIRFECHA490WC
            // 
            this.checkBoxINCLUIRFECHA490WC.AutoSize = true;
            this.checkBoxINCLUIRFECHA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.checkBoxINCLUIRFECHA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.checkBoxINCLUIRFECHA490WC.Location = new System.Drawing.Point(833, 322);
            this.checkBoxINCLUIRFECHA490WC.Name = "checkBoxINCLUIRFECHA490WC";
            this.checkBoxINCLUIRFECHA490WC.Size = new System.Drawing.Size(155, 24);
            this.checkBoxINCLUIRFECHA490WC.TabIndex = 70;
            this.checkBoxINCLUIRFECHA490WC.Text = "Incluir Fechas?";
            this.checkBoxINCLUIRFECHA490WC.UseVisualStyleBackColor = true;
            this.checkBoxINCLUIRFECHA490WC.CheckedChanged += new System.EventHandler(this.checkBoxINCLUIRFECHA490WC_CheckedChanged);
            // 
            // LABEL_PRECIO490WC
            // 
            this.LABEL_PRECIO490WC.AutoSize = true;
            this.LABEL_PRECIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_PRECIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_PRECIO490WC.Location = new System.Drawing.Point(176, 326);
            this.LABEL_PRECIO490WC.Name = "LABEL_PRECIO490WC";
            this.LABEL_PRECIO490WC.Size = new System.Drawing.Size(122, 20);
            this.LABEL_PRECIO490WC.TabIndex = 72;
            this.LABEL_PRECIO490WC.Text = "Precio Desde";
            // 
            // TB_PRECIODESDE490WC
            // 
            this.TB_PRECIODESDE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PRECIODESDE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PRECIODESDE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PRECIODESDE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PRECIODESDE490WC.Location = new System.Drawing.Point(180, 352);
            this.TB_PRECIODESDE490WC.Name = "TB_PRECIODESDE490WC";
            this.TB_PRECIODESDE490WC.Size = new System.Drawing.Size(137, 27);
            this.TB_PRECIODESDE490WC.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(176, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Precio Hasta";
            // 
            // TB_PRECIOHASTA490WC
            // 
            this.TB_PRECIOHASTA490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PRECIOHASTA490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PRECIOHASTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PRECIOHASTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PRECIOHASTA490WC.Location = new System.Drawing.Point(180, 420);
            this.TB_PRECIOHASTA490WC.Name = "TB_PRECIOHASTA490WC";
            this.TB_PRECIOHASTA490WC.Size = new System.Drawing.Size(137, 27);
            this.TB_PRECIOHASTA490WC.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(176, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Peso Permitido";
            // 
            // TB_PESO490WC
            // 
            this.TB_PESO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PESO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PESO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PESO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PESO490WC.Location = new System.Drawing.Point(180, 495);
            this.TB_PESO490WC.Name = "TB_PESO490WC";
            this.TB_PESO490WC.Size = new System.Drawing.Size(137, 27);
            this.TB_PESO490WC.TabIndex = 75;
            // 
            // ControlModalidadIDA490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_PESO490WC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_PRECIOHASTA490WC);
            this.Controls.Add(this.LABEL_PRECIO490WC);
            this.Controls.Add(this.TB_PRECIODESDE490WC);
            this.Controls.Add(this.checkBoxINCLUIRFECHA490WC);
            this.Controls.Add(this.CB_ORIGEN490WC);
            this.Controls.Add(this.CB_DESTINO490WC);
            this.Controls.Add(this.LABEL_CLASEBOLETO490WC);
            this.Controls.Add(this.CB_CLASEBOLETO490WC);
            this.Controls.Add(this.LABEL_DESTINO490WC);
            this.Controls.Add(this.LABEL_ORIGEN490WC);
            this.Controls.Add(this.BT_LIMPIARFILTROS490WC);
            this.Controls.Add(this.BT_FILTRAR490WC);
            this.Controls.Add(this.LABEL_FECHALLEGADA_IDA490WC);
            this.Controls.Add(this.LABEL_FECHAPARTIDA_IDA490WC);
            this.Controls.Add(this.calendarioFECHALLEGADA_IDA490WC);
            this.Controls.Add(this.calendarioFECHAPARTIDA_IDA490WC);
            this.Controls.Add(this.dgvBoleto490WC);
            this.Name = "ControlModalidadIDA490WC";
            this.Size = new System.Drawing.Size(1010, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleto490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoleto490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPartidaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaLlegadaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClaseBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPesoEquipajePermitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumeroAsiento;
        private System.Windows.Forms.Label LABEL_FECHALLEGADA_IDA490WC;
        private System.Windows.Forms.Label LABEL_FECHAPARTIDA_IDA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHALLEGADA_IDA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHAPARTIDA_IDA490WC;
        private System.Windows.Forms.Button BT_LIMPIARFILTROS490WC;
        private System.Windows.Forms.Button BT_FILTRAR490WC;
        private System.Windows.Forms.Label LABEL_ORIGEN490WC;
        private System.Windows.Forms.Label LABEL_DESTINO490WC;
        private System.Windows.Forms.ComboBox CB_CLASEBOLETO490WC;
        private System.Windows.Forms.Label LABEL_CLASEBOLETO490WC;
        private System.Windows.Forms.ComboBox CB_DESTINO490WC;
        private System.Windows.Forms.ComboBox CB_ORIGEN490WC;
        private System.Windows.Forms.CheckBox checkBoxINCLUIRFECHA490WC;
        private System.Windows.Forms.Label LABEL_PRECIO490WC;
        private System.Windows.Forms.TextBox TB_PRECIODESDE490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PRECIOHASTA490WC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PESO490WC;
    }
}
