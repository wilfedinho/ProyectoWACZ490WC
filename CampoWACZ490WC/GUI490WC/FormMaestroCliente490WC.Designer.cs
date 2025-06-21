namespace GUI490WC
{
    partial class FormMaestroCliente490WC
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
            this.dgvCliente490WC = new System.Windows.Forms.DataGridView();
            this.DNI_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTRELLAS_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN_ESTRELLA = new System.Windows.Forms.DataGridViewImageColumn();
            this.LABEL_NOMBRE_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_APELLIDO_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_DNI_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.TB_DNI490WC = new System.Windows.Forms.TextBox();
            this.TB_APELLIDO490WC = new System.Windows.Forms.TextBox();
            this.TB_NOMBRE490WC = new System.Windows.Forms.TextBox();
            this.BT_ALTA_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_BAJA_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_MODIFICAR_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_APLICAR490WC = new System.Windows.Forms.Button();
            this.BT_SALIR490WC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_CREDITO490WC = new System.Windows.Forms.RadioButton();
            this.RB_DEBITO490WC = new System.Windows.Forms.RadioButton();
            this.labelEmail490WC = new System.Windows.Forms.Label();
            this.TB_EMAIL490WC = new System.Windows.Forms.TextBox();
            this.labelFechaEmision490WC = new System.Windows.Forms.Label();
            this.TB_FECHAEMISION490WC = new System.Windows.Forms.TextBox();
            this.labelCelular490WC = new System.Windows.Forms.Label();
            this.TB_CELULAR490WC = new System.Windows.Forms.TextBox();
            this.labelCodigoSeguridad490WC = new System.Windows.Forms.Label();
            this.TB_CODIGOSEGURIDAD490WC = new System.Windows.Forms.TextBox();
            this.labelDireccion490WC = new System.Windows.Forms.Label();
            this.TB_TITULAR490WC = new System.Windows.Forms.TextBox();
            this.labelApellidoTitular490WC = new System.Windows.Forms.Label();
            this.TB_APELLIDOTITULAR490WC = new System.Windows.Forms.TextBox();
            this.TB_ESTRELLASCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente490WC
            // 
            this.dgvCliente490WC.AllowUserToAddRows = false;
            this.dgvCliente490WC.AllowUserToDeleteRows = false;
            this.dgvCliente490WC.AllowUserToResizeColumns = false;
            this.dgvCliente490WC.AllowUserToResizeRows = false;
            this.dgvCliente490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI_CLIENTE,
            this.NOMBRE_CLIENTE,
            this.APELLIDO_CLIENTE,
            this.ESTRELLAS_CLIENTE,
            this.IMAGEN_ESTRELLA});
            this.dgvCliente490WC.Location = new System.Drawing.Point(12, 12);
            this.dgvCliente490WC.MultiSelect = false;
            this.dgvCliente490WC.Name = "dgvCliente490WC";
            this.dgvCliente490WC.ReadOnly = true;
            this.dgvCliente490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente490WC.Size = new System.Drawing.Size(759, 316);
            this.dgvCliente490WC.TabIndex = 1;
            // 
            // DNI_CLIENTE
            // 
            this.DNI_CLIENTE.HeaderText = "DNI";
            this.DNI_CLIENTE.Name = "DNI_CLIENTE";
            this.DNI_CLIENTE.ReadOnly = true;
            // 
            // NOMBRE_CLIENTE
            // 
            this.NOMBRE_CLIENTE.HeaderText = "Nombre";
            this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.ReadOnly = true;
            // 
            // APELLIDO_CLIENTE
            // 
            this.APELLIDO_CLIENTE.HeaderText = "Apellido";
            this.APELLIDO_CLIENTE.Name = "APELLIDO_CLIENTE";
            this.APELLIDO_CLIENTE.ReadOnly = true;
            // 
            // ESTRELLAS_CLIENTE
            // 
            this.ESTRELLAS_CLIENTE.HeaderText = "Estrellas";
            this.ESTRELLAS_CLIENTE.Name = "ESTRELLAS_CLIENTE";
            this.ESTRELLAS_CLIENTE.ReadOnly = true;
            // 
            // IMAGEN_ESTRELLA
            // 
            this.IMAGEN_ESTRELLA.HeaderText = "";
            this.IMAGEN_ESTRELLA.Image = global::GUI490WC.Properties.Resources.Estrella_Mario;
            this.IMAGEN_ESTRELLA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGEN_ESTRELLA.Name = "IMAGEN_ESTRELLA";
            this.IMAGEN_ESTRELLA.ReadOnly = true;
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(12, 340);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Name = "LABEL_NOMBRE_ABM_USUARIO490WC";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Size = new System.Drawing.Size(77, 20);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TabIndex = 29;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Text = "Nombre";
            // 
            // LABEL_APELLIDO_ABM_USUARIO490WC
            // 
            this.LABEL_APELLIDO_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Location = new System.Drawing.Point(12, 460);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Name = "LABEL_APELLIDO_ABM_USUARIO490WC";
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Size = new System.Drawing.Size(79, 20);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.TabIndex = 28;
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Text = "Apellido";
            // 
            // LABEL_DNI_ABM_USUARIO490WC
            // 
            this.LABEL_DNI_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_DNI_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DNI_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DNI_ABM_USUARIO490WC.Location = new System.Drawing.Point(12, 402);
            this.LABEL_DNI_ABM_USUARIO490WC.Name = "LABEL_DNI_ABM_USUARIO490WC";
            this.LABEL_DNI_ABM_USUARIO490WC.Size = new System.Drawing.Size(40, 20);
            this.LABEL_DNI_ABM_USUARIO490WC.TabIndex = 27;
            this.LABEL_DNI_ABM_USUARIO490WC.Text = "DNI";
            // 
            // TB_DNI490WC
            // 
            this.TB_DNI490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DNI490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DNI490WC.Location = new System.Drawing.Point(16, 424);
            this.TB_DNI490WC.Name = "TB_DNI490WC";
            this.TB_DNI490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_DNI490WC.TabIndex = 26;
            // 
            // TB_APELLIDO490WC
            // 
            this.TB_APELLIDO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_APELLIDO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_APELLIDO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_APELLIDO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_APELLIDO490WC.Location = new System.Drawing.Point(16, 483);
            this.TB_APELLIDO490WC.Name = "TB_APELLIDO490WC";
            this.TB_APELLIDO490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_APELLIDO490WC.TabIndex = 25;
            // 
            // TB_NOMBRE490WC
            // 
            this.TB_NOMBRE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_NOMBRE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NOMBRE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_NOMBRE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_NOMBRE490WC.Location = new System.Drawing.Point(16, 363);
            this.TB_NOMBRE490WC.Name = "TB_NOMBRE490WC";
            this.TB_NOMBRE490WC.Size = new System.Drawing.Size(175, 27);
            this.TB_NOMBRE490WC.TabIndex = 24;
            // 
            // BT_ALTA_USUARIO490WC
            // 
            this.BT_ALTA_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ALTA_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ALTA_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ALTA_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ALTA_USUARIO490WC.Location = new System.Drawing.Point(783, 16);
            this.BT_ALTA_USUARIO490WC.Name = "BT_ALTA_USUARIO490WC";
            this.BT_ALTA_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_ALTA_USUARIO490WC.TabIndex = 30;
            this.BT_ALTA_USUARIO490WC.Text = "Alta";
            this.BT_ALTA_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_ALTA_USUARIO490WC.Click += new System.EventHandler(this.BT_ALTA_USUARIO490WC_Click);
            // 
            // BT_BAJA_USUARIO490WC
            // 
            this.BT_BAJA_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BAJA_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BAJA_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BAJA_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BAJA_USUARIO490WC.Location = new System.Drawing.Point(783, 69);
            this.BT_BAJA_USUARIO490WC.Name = "BT_BAJA_USUARIO490WC";
            this.BT_BAJA_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_BAJA_USUARIO490WC.TabIndex = 31;
            this.BT_BAJA_USUARIO490WC.Text = "Baja";
            this.BT_BAJA_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_BAJA_USUARIO490WC.Click += new System.EventHandler(this.BT_BAJA_USUARIO490WC_Click);
            // 
            // BT_MODIFICAR_USUARIO490WC
            // 
            this.BT_MODIFICAR_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_MODIFICAR_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MODIFICAR_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_MODIFICAR_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_MODIFICAR_USUARIO490WC.Location = new System.Drawing.Point(783, 122);
            this.BT_MODIFICAR_USUARIO490WC.Name = "BT_MODIFICAR_USUARIO490WC";
            this.BT_MODIFICAR_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_MODIFICAR_USUARIO490WC.TabIndex = 32;
            this.BT_MODIFICAR_USUARIO490WC.Text = "Modificar";
            this.BT_MODIFICAR_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_MODIFICAR_USUARIO490WC.Click += new System.EventHandler(this.BT_MODIFICAR_USUARIO490WC_Click);
            // 
            // BT_CANCELAR490WC
            // 
            this.BT_CANCELAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(783, 228);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_CANCELAR490WC.TabIndex = 33;
            this.BT_CANCELAR490WC.Text = "Cancelar";
            this.BT_CANCELAR490WC.UseVisualStyleBackColor = false;
            this.BT_CANCELAR490WC.Click += new System.EventHandler(this.BT_CANCELAR490WC_Click);
            // 
            // BT_APLICAR490WC
            // 
            this.BT_APLICAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_APLICAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_APLICAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_APLICAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_APLICAR490WC.Location = new System.Drawing.Point(783, 175);
            this.BT_APLICAR490WC.Name = "BT_APLICAR490WC";
            this.BT_APLICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_APLICAR490WC.TabIndex = 34;
            this.BT_APLICAR490WC.Text = "Aplicar";
            this.BT_APLICAR490WC.UseVisualStyleBackColor = false;
            this.BT_APLICAR490WC.Click += new System.EventHandler(this.BT_APLICAR490WC_Click);
            // 
            // BT_SALIR490WC
            // 
            this.BT_SALIR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_SALIR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_SALIR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_SALIR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_SALIR490WC.Location = new System.Drawing.Point(783, 281);
            this.BT_SALIR490WC.Name = "BT_SALIR490WC";
            this.BT_SALIR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_SALIR490WC.TabIndex = 35;
            this.BT_SALIR490WC.Text = "Salir";
            this.BT_SALIR490WC.UseVisualStyleBackColor = false;
            this.BT_SALIR490WC.Click += new System.EventHandler(this.BT_SALIR490WC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(832, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipo Tarjeta";
            // 
            // RB_CREDITO490WC
            // 
            this.RB_CREDITO490WC.AutoSize = true;
            this.RB_CREDITO490WC.Checked = true;
            this.RB_CREDITO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RB_CREDITO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RB_CREDITO490WC.Location = new System.Drawing.Point(836, 384);
            this.RB_CREDITO490WC.Name = "RB_CREDITO490WC";
            this.RB_CREDITO490WC.Size = new System.Drawing.Size(90, 24);
            this.RB_CREDITO490WC.TabIndex = 37;
            this.RB_CREDITO490WC.TabStop = true;
            this.RB_CREDITO490WC.Text = "Credito";
            this.RB_CREDITO490WC.UseVisualStyleBackColor = true;
            // 
            // RB_DEBITO490WC
            // 
            this.RB_DEBITO490WC.AutoSize = true;
            this.RB_DEBITO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RB_DEBITO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RB_DEBITO490WC.Location = new System.Drawing.Point(836, 425);
            this.RB_DEBITO490WC.Name = "RB_DEBITO490WC";
            this.RB_DEBITO490WC.Size = new System.Drawing.Size(83, 24);
            this.RB_DEBITO490WC.TabIndex = 38;
            this.RB_DEBITO490WC.Text = "Debito";
            this.RB_DEBITO490WC.UseVisualStyleBackColor = true;
            // 
            // labelEmail490WC
            // 
            this.labelEmail490WC.AutoSize = true;
            this.labelEmail490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelEmail490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelEmail490WC.Location = new System.Drawing.Point(262, 340);
            this.labelEmail490WC.Name = "labelEmail490WC";
            this.labelEmail490WC.Size = new System.Drawing.Size(56, 20);
            this.labelEmail490WC.TabIndex = 40;
            this.labelEmail490WC.Text = "Email";
            // 
            // TB_EMAIL490WC
            // 
            this.TB_EMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_EMAIL490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_EMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_EMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_EMAIL490WC.Location = new System.Drawing.Point(266, 363);
            this.TB_EMAIL490WC.Name = "TB_EMAIL490WC";
            this.TB_EMAIL490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_EMAIL490WC.TabIndex = 39;
            // 
            // labelFechaEmision490WC
            // 
            this.labelFechaEmision490WC.AutoSize = true;
            this.labelFechaEmision490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelFechaEmision490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelFechaEmision490WC.Location = new System.Drawing.Point(548, 340);
            this.labelFechaEmision490WC.Name = "labelFechaEmision490WC";
            this.labelFechaEmision490WC.Size = new System.Drawing.Size(158, 20);
            this.labelFechaEmision490WC.TabIndex = 42;
            this.labelFechaEmision490WC.Text = "Fecha de Emision";
            // 
            // TB_FECHAEMISION490WC
            // 
            this.TB_FECHAEMISION490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_FECHAEMISION490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_FECHAEMISION490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_FECHAEMISION490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_FECHAEMISION490WC.Location = new System.Drawing.Point(552, 363);
            this.TB_FECHAEMISION490WC.Name = "TB_FECHAEMISION490WC";
            this.TB_FECHAEMISION490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_FECHAEMISION490WC.TabIndex = 41;
            // 
            // labelCelular490WC
            // 
            this.labelCelular490WC.AutoSize = true;
            this.labelCelular490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCelular490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCelular490WC.Location = new System.Drawing.Point(262, 401);
            this.labelCelular490WC.Name = "labelCelular490WC";
            this.labelCelular490WC.Size = new System.Drawing.Size(68, 20);
            this.labelCelular490WC.TabIndex = 44;
            this.labelCelular490WC.Text = "Celular";
            // 
            // TB_CELULAR490WC
            // 
            this.TB_CELULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_CELULAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CELULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_CELULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_CELULAR490WC.Location = new System.Drawing.Point(266, 424);
            this.TB_CELULAR490WC.Name = "TB_CELULAR490WC";
            this.TB_CELULAR490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_CELULAR490WC.TabIndex = 43;
            // 
            // labelCodigoSeguridad490WC
            // 
            this.labelCodigoSeguridad490WC.AutoSize = true;
            this.labelCodigoSeguridad490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCodigoSeguridad490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCodigoSeguridad490WC.Location = new System.Drawing.Point(548, 402);
            this.labelCodigoSeguridad490WC.Name = "labelCodigoSeguridad490WC";
            this.labelCodigoSeguridad490WC.Size = new System.Drawing.Size(187, 20);
            this.labelCodigoSeguridad490WC.TabIndex = 46;
            this.labelCodigoSeguridad490WC.Text = "Codigo de Seguridad";
            // 
            // TB_CODIGOSEGURIDAD490WC
            // 
            this.TB_CODIGOSEGURIDAD490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_CODIGOSEGURIDAD490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CODIGOSEGURIDAD490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_CODIGOSEGURIDAD490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_CODIGOSEGURIDAD490WC.Location = new System.Drawing.Point(552, 425);
            this.TB_CODIGOSEGURIDAD490WC.Name = "TB_CODIGOSEGURIDAD490WC";
            this.TB_CODIGOSEGURIDAD490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_CODIGOSEGURIDAD490WC.TabIndex = 45;
            // 
            // labelDireccion490WC
            // 
            this.labelDireccion490WC.AutoSize = true;
            this.labelDireccion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelDireccion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelDireccion490WC.Location = new System.Drawing.Point(262, 460);
            this.labelDireccion490WC.Name = "labelDireccion490WC";
            this.labelDireccion490WC.Size = new System.Drawing.Size(89, 20);
            this.labelDireccion490WC.TabIndex = 48;
            this.labelDireccion490WC.Text = "Direccion";
            // 
            // TB_TITULAR490WC
            // 
            this.TB_TITULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_TITULAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_TITULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_TITULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_TITULAR490WC.Location = new System.Drawing.Point(266, 483);
            this.TB_TITULAR490WC.Name = "TB_TITULAR490WC";
            this.TB_TITULAR490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_TITULAR490WC.TabIndex = 47;
            // 
            // labelApellidoTitular490WC
            // 
            this.labelApellidoTitular490WC.AutoSize = true;
            this.labelApellidoTitular490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelApellidoTitular490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelApellidoTitular490WC.Location = new System.Drawing.Point(548, 460);
            this.labelApellidoTitular490WC.Name = "labelApellidoTitular490WC";
            this.labelApellidoTitular490WC.Size = new System.Drawing.Size(139, 20);
            this.labelApellidoTitular490WC.TabIndex = 50;
            this.labelApellidoTitular490WC.Text = "Apellido Titular";
            // 
            // TB_APELLIDOTITULAR490WC
            // 
            this.TB_APELLIDOTITULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_APELLIDOTITULAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_APELLIDOTITULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_APELLIDOTITULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_APELLIDOTITULAR490WC.Location = new System.Drawing.Point(552, 483);
            this.TB_APELLIDOTITULAR490WC.Name = "TB_APELLIDOTITULAR490WC";
            this.TB_APELLIDOTITULAR490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_APELLIDOTITULAR490WC.TabIndex = 49;
            // 
            // TB_ESTRELLASCLIENTE490WC
            // 
            this.TB_ESTRELLASCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_ESTRELLASCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ESTRELLASCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_ESTRELLASCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_ESTRELLASCLIENTE490WC.Location = new System.Drawing.Point(783, 483);
            this.TB_ESTRELLASCLIENTE490WC.Name = "TB_ESTRELLASCLIENTE490WC";
            this.TB_ESTRELLASCLIENTE490WC.Size = new System.Drawing.Size(184, 27);
            this.TB_ESTRELLASCLIENTE490WC.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(779, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Estrellas Cliente";
            // 
            // FormMaestroCliente490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(983, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ESTRELLASCLIENTE490WC);
            this.Controls.Add(this.labelApellidoTitular490WC);
            this.Controls.Add(this.TB_APELLIDOTITULAR490WC);
            this.Controls.Add(this.labelDireccion490WC);
            this.Controls.Add(this.TB_TITULAR490WC);
            this.Controls.Add(this.labelCodigoSeguridad490WC);
            this.Controls.Add(this.TB_CODIGOSEGURIDAD490WC);
            this.Controls.Add(this.labelCelular490WC);
            this.Controls.Add(this.TB_CELULAR490WC);
            this.Controls.Add(this.labelFechaEmision490WC);
            this.Controls.Add(this.TB_FECHAEMISION490WC);
            this.Controls.Add(this.labelEmail490WC);
            this.Controls.Add(this.TB_EMAIL490WC);
            this.Controls.Add(this.RB_DEBITO490WC);
            this.Controls.Add(this.RB_CREDITO490WC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_SALIR490WC);
            this.Controls.Add(this.BT_APLICAR490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.BT_MODIFICAR_USUARIO490WC);
            this.Controls.Add(this.BT_BAJA_USUARIO490WC);
            this.Controls.Add(this.BT_ALTA_USUARIO490WC);
            this.Controls.Add(this.LABEL_NOMBRE_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_APELLIDO_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_DNI_ABM_USUARIO490WC);
            this.Controls.Add(this.TB_DNI490WC);
            this.Controls.Add(this.TB_APELLIDO490WC);
            this.Controls.Add(this.TB_NOMBRE490WC);
            this.Controls.Add(this.dgvCliente490WC);
            this.Name = "FormMaestroCliente490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaestroCliente490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMaestroCliente490WC_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente490WC;
        private System.Windows.Forms.Label LABEL_NOMBRE_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_APELLIDO_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_DNI_ABM_USUARIO490WC;
        private System.Windows.Forms.TextBox TB_DNI490WC;
        private System.Windows.Forms.TextBox TB_APELLIDO490WC;
        private System.Windows.Forms.TextBox TB_NOMBRE490WC;
        private System.Windows.Forms.Button BT_ALTA_USUARIO490WC;
        private System.Windows.Forms.Button BT_BAJA_USUARIO490WC;
        private System.Windows.Forms.Button BT_MODIFICAR_USUARIO490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_APLICAR490WC;
        private System.Windows.Forms.Button BT_SALIR490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_CREDITO490WC;
        private System.Windows.Forms.RadioButton RB_DEBITO490WC;
        private System.Windows.Forms.Label labelEmail490WC;
        private System.Windows.Forms.TextBox TB_EMAIL490WC;
        private System.Windows.Forms.Label labelFechaEmision490WC;
        private System.Windows.Forms.TextBox TB_FECHAEMISION490WC;
        private System.Windows.Forms.Label labelCelular490WC;
        private System.Windows.Forms.TextBox TB_CELULAR490WC;
        private System.Windows.Forms.Label labelCodigoSeguridad490WC;
        private System.Windows.Forms.TextBox TB_CODIGOSEGURIDAD490WC;
        private System.Windows.Forms.Label labelDireccion490WC;
        private System.Windows.Forms.TextBox TB_TITULAR490WC;
        private System.Windows.Forms.Label labelApellidoTitular490WC;
        private System.Windows.Forms.TextBox TB_APELLIDOTITULAR490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTRELLAS_CLIENTE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN_ESTRELLA;
        private System.Windows.Forms.TextBox TB_ESTRELLASCLIENTE490WC;
        private System.Windows.Forms.Label label2;
    }
}