namespace GUI490WC
{
    partial class FormMaestroBoleto490WC
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
            this.dgvBoleto490WC = new System.Windows.Forms.DataGridView();
            this.LABEL_ORIGEN490WC = new System.Windows.Forms.Label();
            this.TB_ORIGEN490WC = new System.Windows.Forms.TextBox();
            this.LABEL_DESTINO490WC = new System.Windows.Forms.Label();
            this.TB_DESTINO490WC = new System.Windows.Forms.TextBox();
            this.LABEL_PESOEQUIPAJE490WC = new System.Windows.Forms.Label();
            this.TB_PESOEQUIPAJE490WC = new System.Windows.Forms.TextBox();
            this.LABEL_PRECIO490WC = new System.Windows.Forms.Label();
            this.TB_PRECIO490WC = new System.Windows.Forms.TextBox();
            this.LABEL_CLASEBOLETO490WC = new System.Windows.Forms.Label();
            this.CB_CLASEBOLETO490WC = new System.Windows.Forms.ComboBox();
            this.BT_SALIR490WC = new System.Windows.Forms.Button();
            this.BT_APLICAR490WC = new System.Windows.Forms.Button();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_MODIFICAR490WC = new System.Windows.Forms.Button();
            this.BT_BAJA490WC = new System.Windows.Forms.Button();
            this.BT_ALTA490WC = new System.Windows.Forms.Button();
            this.calendarioFECHAPARTIDA_IDA490WC = new System.Windows.Forms.MonthCalendar();
            this.calendarioFECHALLEGADA_IDA490WC = new System.Windows.Forms.MonthCalendar();
            this.calendarioFECHALLEGADA_VUELTA490WC = new System.Windows.Forms.MonthCalendar();
            this.calendarioFECHAPARTIDA_VUELTA490WC = new System.Windows.Forms.MonthCalendar();
            this.LABEL_MODALIDAD490WC = new System.Windows.Forms.Label();
            this.RBIDA490WC = new System.Windows.Forms.RadioButton();
            this.RBIDAVUELTA490WC = new System.Windows.Forms.RadioButton();
            this.LABEL_FECHAPARTIDA_IDA490WC = new System.Windows.Forms.Label();
            this.LABEL_FECHALLEGADA_IDA490WC = new System.Windows.Forms.Label();
            this.LABEL_FECHAPARTIDA_VUELTA490WC = new System.Windows.Forms.Label();
            this.LABEL_FECHALLEGADA_VUELTA490WC = new System.Windows.Forms.Label();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPartidaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaLlegadaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPartidaVUELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaLlegadaVUELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClaseBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPesoEquipajePermitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColumnaOrigen,
            this.ColumnaDestino,
            this.ColumnaFechaPartidaIDA,
            this.ColumnaFechaLlegadaIDA,
            this.ColumnaFechaPartidaVUELTA,
            this.ColumnaFechaLlegadaVUELTA,
            this.ColumnaClaseBoleto,
            this.ColumnaPesoEquipajePermitido,
            this.ColumnaPrecio});
            this.dgvBoleto490WC.Location = new System.Drawing.Point(12, 12);
            this.dgvBoleto490WC.MultiSelect = false;
            this.dgvBoleto490WC.Name = "dgvBoleto490WC";
            this.dgvBoleto490WC.ReadOnly = true;
            this.dgvBoleto490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBoleto490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoleto490WC.Size = new System.Drawing.Size(1104, 312);
            this.dgvBoleto490WC.TabIndex = 1;
            // 
            // LABEL_ORIGEN490WC
            // 
            this.LABEL_ORIGEN490WC.AutoSize = true;
            this.LABEL_ORIGEN490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_ORIGEN490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_ORIGEN490WC.Location = new System.Drawing.Point(22, 366);
            this.LABEL_ORIGEN490WC.Name = "LABEL_ORIGEN490WC";
            this.LABEL_ORIGEN490WC.Size = new System.Drawing.Size(65, 20);
            this.LABEL_ORIGEN490WC.TabIndex = 25;
            this.LABEL_ORIGEN490WC.Text = "Origen";
            // 
            // TB_ORIGEN490WC
            // 
            this.TB_ORIGEN490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_ORIGEN490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ORIGEN490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_ORIGEN490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_ORIGEN490WC.Location = new System.Drawing.Point(159, 367);
            this.TB_ORIGEN490WC.Name = "TB_ORIGEN490WC";
            this.TB_ORIGEN490WC.Size = new System.Drawing.Size(174, 27);
            this.TB_ORIGEN490WC.TabIndex = 24;
            // 
            // LABEL_DESTINO490WC
            // 
            this.LABEL_DESTINO490WC.AutoSize = true;
            this.LABEL_DESTINO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DESTINO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DESTINO490WC.Location = new System.Drawing.Point(22, 410);
            this.LABEL_DESTINO490WC.Name = "LABEL_DESTINO490WC";
            this.LABEL_DESTINO490WC.Size = new System.Drawing.Size(74, 20);
            this.LABEL_DESTINO490WC.TabIndex = 27;
            this.LABEL_DESTINO490WC.Text = "Destino";
            // 
            // TB_DESTINO490WC
            // 
            this.TB_DESTINO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DESTINO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DESTINO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DESTINO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DESTINO490WC.Location = new System.Drawing.Point(159, 411);
            this.TB_DESTINO490WC.Name = "TB_DESTINO490WC";
            this.TB_DESTINO490WC.Size = new System.Drawing.Size(174, 27);
            this.TB_DESTINO490WC.TabIndex = 26;
            // 
            // LABEL_PESOEQUIPAJE490WC
            // 
            this.LABEL_PESOEQUIPAJE490WC.AutoSize = true;
            this.LABEL_PESOEQUIPAJE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_PESOEQUIPAJE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_PESOEQUIPAJE490WC.Location = new System.Drawing.Point(22, 452);
            this.LABEL_PESOEQUIPAJE490WC.Name = "LABEL_PESOEQUIPAJE490WC";
            this.LABEL_PESOEQUIPAJE490WC.Size = new System.Drawing.Size(130, 20);
            this.LABEL_PESOEQUIPAJE490WC.TabIndex = 29;
            this.LABEL_PESOEQUIPAJE490WC.Text = "Peso Equipaje";
            // 
            // TB_PESOEQUIPAJE490WC
            // 
            this.TB_PESOEQUIPAJE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PESOEQUIPAJE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PESOEQUIPAJE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PESOEQUIPAJE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PESOEQUIPAJE490WC.Location = new System.Drawing.Point(159, 453);
            this.TB_PESOEQUIPAJE490WC.Name = "TB_PESOEQUIPAJE490WC";
            this.TB_PESOEQUIPAJE490WC.Size = new System.Drawing.Size(174, 27);
            this.TB_PESOEQUIPAJE490WC.TabIndex = 28;
            // 
            // LABEL_PRECIO490WC
            // 
            this.LABEL_PRECIO490WC.AutoSize = true;
            this.LABEL_PRECIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_PRECIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_PRECIO490WC.Location = new System.Drawing.Point(22, 496);
            this.LABEL_PRECIO490WC.Name = "LABEL_PRECIO490WC";
            this.LABEL_PRECIO490WC.Size = new System.Drawing.Size(64, 20);
            this.LABEL_PRECIO490WC.TabIndex = 31;
            this.LABEL_PRECIO490WC.Text = "Precio";
            // 
            // TB_PRECIO490WC
            // 
            this.TB_PRECIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_PRECIO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PRECIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_PRECIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_PRECIO490WC.Location = new System.Drawing.Point(159, 497);
            this.TB_PRECIO490WC.Name = "TB_PRECIO490WC";
            this.TB_PRECIO490WC.Size = new System.Drawing.Size(174, 27);
            this.TB_PRECIO490WC.TabIndex = 30;
            // 
            // LABEL_CLASEBOLETO490WC
            // 
            this.LABEL_CLASEBOLETO490WC.AutoSize = true;
            this.LABEL_CLASEBOLETO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_CLASEBOLETO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_CLASEBOLETO490WC.Location = new System.Drawing.Point(22, 540);
            this.LABEL_CLASEBOLETO490WC.Name = "LABEL_CLASEBOLETO490WC";
            this.LABEL_CLASEBOLETO490WC.Size = new System.Drawing.Size(117, 20);
            this.LABEL_CLASEBOLETO490WC.TabIndex = 33;
            this.LABEL_CLASEBOLETO490WC.Text = "Clase Boleto";
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
            this.CB_CLASEBOLETO490WC.Location = new System.Drawing.Point(159, 537);
            this.CB_CLASEBOLETO490WC.Name = "CB_CLASEBOLETO490WC";
            this.CB_CLASEBOLETO490WC.Size = new System.Drawing.Size(174, 27);
            this.CB_CLASEBOLETO490WC.TabIndex = 34;
            // 
            // BT_SALIR490WC
            // 
            this.BT_SALIR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_SALIR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_SALIR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_SALIR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_SALIR490WC.Location = new System.Drawing.Point(1134, 278);
            this.BT_SALIR490WC.Name = "BT_SALIR490WC";
            this.BT_SALIR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_SALIR490WC.TabIndex = 47;
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
            this.BT_APLICAR490WC.Location = new System.Drawing.Point(1134, 172);
            this.BT_APLICAR490WC.Name = "BT_APLICAR490WC";
            this.BT_APLICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_APLICAR490WC.TabIndex = 46;
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
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(1134, 225);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_CANCELAR490WC.TabIndex = 45;
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
            this.BT_MODIFICAR490WC.Location = new System.Drawing.Point(1134, 119);
            this.BT_MODIFICAR490WC.Name = "BT_MODIFICAR490WC";
            this.BT_MODIFICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_MODIFICAR490WC.TabIndex = 44;
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
            this.BT_BAJA490WC.Location = new System.Drawing.Point(1134, 66);
            this.BT_BAJA490WC.Name = "BT_BAJA490WC";
            this.BT_BAJA490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_BAJA490WC.TabIndex = 43;
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
            this.BT_ALTA490WC.Location = new System.Drawing.Point(1134, 13);
            this.BT_ALTA490WC.Name = "BT_ALTA490WC";
            this.BT_ALTA490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_ALTA490WC.TabIndex = 42;
            this.BT_ALTA490WC.Text = "Alta";
            this.BT_ALTA490WC.UseVisualStyleBackColor = false;
            this.BT_ALTA490WC.Click += new System.EventHandler(this.BT_ALTA490WC_Click);
            // 
            // calendarioFECHAPARTIDA_IDA490WC
            // 
            this.calendarioFECHAPARTIDA_IDA490WC.Location = new System.Drawing.Point(353, 402);
            this.calendarioFECHAPARTIDA_IDA490WC.MaxSelectionCount = 1;
            this.calendarioFECHAPARTIDA_IDA490WC.Name = "calendarioFECHAPARTIDA_IDA490WC";
            this.calendarioFECHAPARTIDA_IDA490WC.TabIndex = 48;
            // 
            // calendarioFECHALLEGADA_IDA490WC
            // 
            this.calendarioFECHALLEGADA_IDA490WC.Location = new System.Drawing.Point(598, 402);
            this.calendarioFECHALLEGADA_IDA490WC.MaxSelectionCount = 1;
            this.calendarioFECHALLEGADA_IDA490WC.Name = "calendarioFECHALLEGADA_IDA490WC";
            this.calendarioFECHALLEGADA_IDA490WC.TabIndex = 49;
            // 
            // calendarioFECHALLEGADA_VUELTA490WC
            // 
            this.calendarioFECHALLEGADA_VUELTA490WC.Location = new System.Drawing.Point(1088, 402);
            this.calendarioFECHALLEGADA_VUELTA490WC.MaxSelectionCount = 1;
            this.calendarioFECHALLEGADA_VUELTA490WC.Name = "calendarioFECHALLEGADA_VUELTA490WC";
            this.calendarioFECHALLEGADA_VUELTA490WC.TabIndex = 50;
            // 
            // calendarioFECHAPARTIDA_VUELTA490WC
            // 
            this.calendarioFECHAPARTIDA_VUELTA490WC.Location = new System.Drawing.Point(843, 402);
            this.calendarioFECHAPARTIDA_VUELTA490WC.MaxSelectionCount = 1;
            this.calendarioFECHAPARTIDA_VUELTA490WC.Name = "calendarioFECHAPARTIDA_VUELTA490WC";
            this.calendarioFECHAPARTIDA_VUELTA490WC.TabIndex = 51;
            // 
            // LABEL_MODALIDAD490WC
            // 
            this.LABEL_MODALIDAD490WC.AutoSize = true;
            this.LABEL_MODALIDAD490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_MODALIDAD490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_MODALIDAD490WC.Location = new System.Drawing.Point(22, 337);
            this.LABEL_MODALIDAD490WC.Name = "LABEL_MODALIDAD490WC";
            this.LABEL_MODALIDAD490WC.Size = new System.Drawing.Size(99, 20);
            this.LABEL_MODALIDAD490WC.TabIndex = 52;
            this.LABEL_MODALIDAD490WC.Text = "Modalidad";
            // 
            // RBIDA490WC
            // 
            this.RBIDA490WC.AutoSize = true;
            this.RBIDA490WC.Checked = true;
            this.RBIDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RBIDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RBIDA490WC.Location = new System.Drawing.Point(159, 337);
            this.RBIDA490WC.Name = "RBIDA490WC";
            this.RBIDA490WC.Size = new System.Drawing.Size(57, 24);
            this.RBIDA490WC.TabIndex = 53;
            this.RBIDA490WC.TabStop = true;
            this.RBIDA490WC.Text = "IDA";
            this.RBIDA490WC.UseVisualStyleBackColor = true;
            // 
            // RBIDAVUELTA490WC
            // 
            this.RBIDAVUELTA490WC.AutoSize = true;
            this.RBIDAVUELTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RBIDAVUELTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RBIDAVUELTA490WC.Location = new System.Drawing.Point(233, 337);
            this.RBIDAVUELTA490WC.Name = "RBIDAVUELTA490WC";
            this.RBIDAVUELTA490WC.Size = new System.Drawing.Size(133, 24);
            this.RBIDAVUELTA490WC.TabIndex = 54;
            this.RBIDAVUELTA490WC.Text = "IDA -VUELTA";
            this.RBIDAVUELTA490WC.UseVisualStyleBackColor = true;
            // 
            // LABEL_FECHAPARTIDA_IDA490WC
            // 
            this.LABEL_FECHAPARTIDA_IDA490WC.AutoSize = true;
            this.LABEL_FECHAPARTIDA_IDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHAPARTIDA_IDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHAPARTIDA_IDA490WC.Location = new System.Drawing.Point(384, 366);
            this.LABEL_FECHAPARTIDA_IDA490WC.Name = "LABEL_FECHAPARTIDA_IDA490WC";
            this.LABEL_FECHAPARTIDA_IDA490WC.Size = new System.Drawing.Size(161, 20);
            this.LABEL_FECHAPARTIDA_IDA490WC.TabIndex = 55;
            this.LABEL_FECHAPARTIDA_IDA490WC.Text = "Fecha Partida IDA";
            // 
            // LABEL_FECHALLEGADA_IDA490WC
            // 
            this.LABEL_FECHALLEGADA_IDA490WC.AutoSize = true;
            this.LABEL_FECHALLEGADA_IDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHALLEGADA_IDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHALLEGADA_IDA490WC.Location = new System.Drawing.Point(631, 366);
            this.LABEL_FECHALLEGADA_IDA490WC.Name = "LABEL_FECHALLEGADA_IDA490WC";
            this.LABEL_FECHALLEGADA_IDA490WC.Size = new System.Drawing.Size(166, 20);
            this.LABEL_FECHALLEGADA_IDA490WC.TabIndex = 56;
            this.LABEL_FECHALLEGADA_IDA490WC.Text = "Fecha Llegada IDA";
            // 
            // LABEL_FECHAPARTIDA_VUELTA490WC
            // 
            this.LABEL_FECHAPARTIDA_VUELTA490WC.AutoSize = true;
            this.LABEL_FECHAPARTIDA_VUELTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHAPARTIDA_VUELTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHAPARTIDA_VUELTA490WC.Location = new System.Drawing.Point(860, 366);
            this.LABEL_FECHAPARTIDA_VUELTA490WC.Name = "LABEL_FECHAPARTIDA_VUELTA490WC";
            this.LABEL_FECHAPARTIDA_VUELTA490WC.Size = new System.Drawing.Size(196, 20);
            this.LABEL_FECHAPARTIDA_VUELTA490WC.TabIndex = 57;
            this.LABEL_FECHAPARTIDA_VUELTA490WC.Text = "Fecha Partida VUELTA";
            // 
            // LABEL_FECHALLEGADA_VUELTA490WC
            // 
            this.LABEL_FECHALLEGADA_VUELTA490WC.AutoSize = true;
            this.LABEL_FECHALLEGADA_VUELTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_FECHALLEGADA_VUELTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_FECHALLEGADA_VUELTA490WC.Location = new System.Drawing.Point(1107, 366);
            this.LABEL_FECHALLEGADA_VUELTA490WC.Name = "LABEL_FECHALLEGADA_VUELTA490WC";
            this.LABEL_FECHALLEGADA_VUELTA490WC.Size = new System.Drawing.Size(201, 20);
            this.LABEL_FECHALLEGADA_VUELTA490WC.TabIndex = 58;
            this.LABEL_FECHALLEGADA_VUELTA490WC.Text = "Fecha Llegada VUELTA";
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "Column1";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            this.ColumnaID.Visible = false;
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
            // ColumnaFechaPartidaVUELTA
            // 
            this.ColumnaFechaPartidaVUELTA.HeaderText = "FechaPartida VUELTA";
            this.ColumnaFechaPartidaVUELTA.Name = "ColumnaFechaPartidaVUELTA";
            this.ColumnaFechaPartidaVUELTA.ReadOnly = true;
            // 
            // ColumnaFechaLlegadaVUELTA
            // 
            this.ColumnaFechaLlegadaVUELTA.HeaderText = "FechaLlegada VUELTA";
            this.ColumnaFechaLlegadaVUELTA.Name = "ColumnaFechaLlegadaVUELTA";
            this.ColumnaFechaLlegadaVUELTA.ReadOnly = true;
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
            // FormMaestroBoleto490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1330, 575);
            this.Controls.Add(this.LABEL_FECHALLEGADA_VUELTA490WC);
            this.Controls.Add(this.LABEL_FECHAPARTIDA_VUELTA490WC);
            this.Controls.Add(this.LABEL_FECHALLEGADA_IDA490WC);
            this.Controls.Add(this.LABEL_FECHAPARTIDA_IDA490WC);
            this.Controls.Add(this.RBIDAVUELTA490WC);
            this.Controls.Add(this.RBIDA490WC);
            this.Controls.Add(this.LABEL_MODALIDAD490WC);
            this.Controls.Add(this.calendarioFECHAPARTIDA_VUELTA490WC);
            this.Controls.Add(this.calendarioFECHALLEGADA_VUELTA490WC);
            this.Controls.Add(this.calendarioFECHALLEGADA_IDA490WC);
            this.Controls.Add(this.calendarioFECHAPARTIDA_IDA490WC);
            this.Controls.Add(this.BT_SALIR490WC);
            this.Controls.Add(this.BT_APLICAR490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.BT_MODIFICAR490WC);
            this.Controls.Add(this.BT_BAJA490WC);
            this.Controls.Add(this.BT_ALTA490WC);
            this.Controls.Add(this.CB_CLASEBOLETO490WC);
            this.Controls.Add(this.LABEL_CLASEBOLETO490WC);
            this.Controls.Add(this.LABEL_PRECIO490WC);
            this.Controls.Add(this.TB_PRECIO490WC);
            this.Controls.Add(this.LABEL_PESOEQUIPAJE490WC);
            this.Controls.Add(this.TB_PESOEQUIPAJE490WC);
            this.Controls.Add(this.LABEL_DESTINO490WC);
            this.Controls.Add(this.TB_DESTINO490WC);
            this.Controls.Add(this.LABEL_ORIGEN490WC);
            this.Controls.Add(this.TB_ORIGEN490WC);
            this.Controls.Add(this.dgvBoleto490WC);
            this.Name = "FormMaestroBoleto490WC";
            this.Text = "FormMaestroBoleto490WC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleto490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoleto490WC;
        private System.Windows.Forms.Label LABEL_ORIGEN490WC;
        private System.Windows.Forms.TextBox TB_ORIGEN490WC;
        private System.Windows.Forms.Label LABEL_DESTINO490WC;
        private System.Windows.Forms.TextBox TB_DESTINO490WC;
        private System.Windows.Forms.Label LABEL_PESOEQUIPAJE490WC;
        private System.Windows.Forms.TextBox TB_PESOEQUIPAJE490WC;
        private System.Windows.Forms.Label LABEL_PRECIO490WC;
        private System.Windows.Forms.TextBox TB_PRECIO490WC;
        private System.Windows.Forms.Label LABEL_CLASEBOLETO490WC;
        private System.Windows.Forms.ComboBox CB_CLASEBOLETO490WC;
        private System.Windows.Forms.Button BT_SALIR490WC;
        private System.Windows.Forms.Button BT_APLICAR490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_MODIFICAR490WC;
        private System.Windows.Forms.Button BT_BAJA490WC;
        private System.Windows.Forms.Button BT_ALTA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHAPARTIDA_IDA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHALLEGADA_IDA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHALLEGADA_VUELTA490WC;
        private System.Windows.Forms.MonthCalendar calendarioFECHAPARTIDA_VUELTA490WC;
        private System.Windows.Forms.Label LABEL_MODALIDAD490WC;
        private System.Windows.Forms.RadioButton RBIDA490WC;
        private System.Windows.Forms.RadioButton RBIDAVUELTA490WC;
        private System.Windows.Forms.Label LABEL_FECHAPARTIDA_IDA490WC;
        private System.Windows.Forms.Label LABEL_FECHALLEGADA_IDA490WC;
        private System.Windows.Forms.Label LABEL_FECHAPARTIDA_VUELTA490WC;
        private System.Windows.Forms.Label LABEL_FECHALLEGADA_VUELTA490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPartidaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaLlegadaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPartidaVUELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaLlegadaVUELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClaseBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPesoEquipajePermitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
    }
}