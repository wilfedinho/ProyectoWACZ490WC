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
            this.labelDireccion490WC = new System.Windows.Forms.Label();
            this.TB_DIRECCION490WC = new System.Windows.Forms.TextBox();
            this.TB_ESTRELLASCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.LABEL_ESTRELLASCLIENTE490WC = new System.Windows.Forms.Label();
            this.listboxCelularesCliente490WC = new System.Windows.Forms.ListBox();
            this.BT_ELIMINARCELULAR490WC = new System.Windows.Forms.Button();
            this.BT_AGREGARCELULAR490WC = new System.Windows.Forms.Button();
            this.labelCelularCliente490WC = new System.Windows.Forms.Label();
            this.LABEL_EMAILSDELCLIENTE490WC = new System.Windows.Forms.Label();
            this.BT_ELIMINAREMAIL490WC = new System.Windows.Forms.Button();
            this.BT_AGREGAREMAIL490WC = new System.Windows.Forms.Button();
            this.listboxEmailsCliente490WC = new System.Windows.Forms.ListBox();
            this.TB_CELULAR490WC = new System.Windows.Forms.TextBox();
            this.TB_EMAIL490WC = new System.Windows.Forms.TextBox();
            this.BT_Activar490WC = new System.Windows.Forms.Button();
            this.PrevisualizadorXML490WC = new System.Windows.Forms.TextBox();
            this.BT_MODOSERIALIZAR490WC = new System.Windows.Forms.Button();
            this.BT_ACEPTARSERIALIZAR490WC = new System.Windows.Forms.Button();
            this.BT_CANCELARSERIALIZAR490WC = new System.Windows.Forms.Button();
            this.BT_DesSerializar490WC = new System.Windows.Forms.Button();
            this.BT_LIMPIARDESERIALIZAR490WC = new System.Windows.Forms.Button();
            this.DNI_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCelulares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTRELLAS_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN_ESTRELLA = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.columnaDireccion,
            this.columnaEmail,
            this.columnaCelulares,
            this.ESTRELLAS_CLIENTE,
            this.IMAGEN_ESTRELLA});
            this.dgvCliente490WC.Location = new System.Drawing.Point(12, 12);
            this.dgvCliente490WC.MultiSelect = false;
            this.dgvCliente490WC.Name = "dgvCliente490WC";
            this.dgvCliente490WC.ReadOnly = true;
            this.dgvCliente490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente490WC.Size = new System.Drawing.Size(1394, 316);
            this.dgvCliente490WC.TabIndex = 1;
            this.dgvCliente490WC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente490WC_CellMouseClick);
            this.dgvCliente490WC.SelectionChanged += new System.EventHandler(this.dgvCliente490WC_SelectionChanged);
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(8, 352);
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
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Location = new System.Drawing.Point(8, 472);
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
            this.LABEL_DNI_ABM_USUARIO490WC.Location = new System.Drawing.Point(8, 414);
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
            this.TB_DNI490WC.Location = new System.Drawing.Point(12, 436);
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
            this.TB_APELLIDO490WC.Location = new System.Drawing.Point(12, 495);
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
            this.TB_NOMBRE490WC.Location = new System.Drawing.Point(12, 375);
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
            this.BT_ALTA_USUARIO490WC.Location = new System.Drawing.Point(1032, 359);
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
            this.BT_BAJA_USUARIO490WC.Location = new System.Drawing.Point(1032, 412);
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
            this.BT_MODIFICAR_USUARIO490WC.Location = new System.Drawing.Point(1032, 465);
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
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(1222, 412);
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
            this.BT_APLICAR490WC.Location = new System.Drawing.Point(1222, 359);
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
            this.BT_SALIR490WC.Location = new System.Drawing.Point(1222, 465);
            this.BT_SALIR490WC.Name = "BT_SALIR490WC";
            this.BT_SALIR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_SALIR490WC.TabIndex = 35;
            this.BT_SALIR490WC.Text = "Salir";
            this.BT_SALIR490WC.UseVisualStyleBackColor = false;
            this.BT_SALIR490WC.Click += new System.EventHandler(this.BT_SALIR490WC_Click);
            // 
            // labelDireccion490WC
            // 
            this.labelDireccion490WC.AutoSize = true;
            this.labelDireccion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelDireccion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelDireccion490WC.Location = new System.Drawing.Point(222, 360);
            this.labelDireccion490WC.Name = "labelDireccion490WC";
            this.labelDireccion490WC.Size = new System.Drawing.Size(89, 20);
            this.labelDireccion490WC.TabIndex = 48;
            this.labelDireccion490WC.Text = "Direccion";
            // 
            // TB_DIRECCION490WC
            // 
            this.TB_DIRECCION490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DIRECCION490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DIRECCION490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DIRECCION490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DIRECCION490WC.Location = new System.Drawing.Point(226, 383);
            this.TB_DIRECCION490WC.Name = "TB_DIRECCION490WC";
            this.TB_DIRECCION490WC.Size = new System.Drawing.Size(184, 27);
            this.TB_DIRECCION490WC.TabIndex = 47;
            // 
            // TB_ESTRELLASCLIENTE490WC
            // 
            this.TB_ESTRELLASCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_ESTRELLASCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ESTRELLASCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_ESTRELLASCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_ESTRELLASCLIENTE490WC.Location = new System.Drawing.Point(226, 444);
            this.TB_ESTRELLASCLIENTE490WC.Name = "TB_ESTRELLASCLIENTE490WC";
            this.TB_ESTRELLASCLIENTE490WC.Size = new System.Drawing.Size(184, 27);
            this.TB_ESTRELLASCLIENTE490WC.TabIndex = 51;
            // 
            // LABEL_ESTRELLASCLIENTE490WC
            // 
            this.LABEL_ESTRELLASCLIENTE490WC.AutoSize = true;
            this.LABEL_ESTRELLASCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_ESTRELLASCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_ESTRELLASCLIENTE490WC.Location = new System.Drawing.Point(222, 421);
            this.LABEL_ESTRELLASCLIENTE490WC.Name = "LABEL_ESTRELLASCLIENTE490WC";
            this.LABEL_ESTRELLASCLIENTE490WC.Size = new System.Drawing.Size(148, 20);
            this.LABEL_ESTRELLASCLIENTE490WC.TabIndex = 52;
            this.LABEL_ESTRELLASCLIENTE490WC.Text = "Estrellas Cliente";
            // 
            // listboxCelularesCliente490WC
            // 
            this.listboxCelularesCliente490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.listboxCelularesCliente490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxCelularesCliente490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.listboxCelularesCliente490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.listboxCelularesCliente490WC.FormattingEnabled = true;
            this.listboxCelularesCliente490WC.ItemHeight = 19;
            this.listboxCelularesCliente490WC.Location = new System.Drawing.Point(479, 360);
            this.listboxCelularesCliente490WC.Name = "listboxCelularesCliente490WC";
            this.listboxCelularesCliente490WC.Size = new System.Drawing.Size(250, 97);
            this.listboxCelularesCliente490WC.TabIndex = 53;
            // 
            // BT_ELIMINARCELULAR490WC
            // 
            this.BT_ELIMINARCELULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ELIMINARCELULAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ELIMINARCELULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ELIMINARCELULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ELIMINARCELULAR490WC.Location = new System.Drawing.Point(621, 492);
            this.BT_ELIMINARCELULAR490WC.Name = "BT_ELIMINARCELULAR490WC";
            this.BT_ELIMINARCELULAR490WC.Size = new System.Drawing.Size(108, 38);
            this.BT_ELIMINARCELULAR490WC.TabIndex = 55;
            this.BT_ELIMINARCELULAR490WC.Text = "Eliminar";
            this.BT_ELIMINARCELULAR490WC.UseVisualStyleBackColor = false;
            this.BT_ELIMINARCELULAR490WC.Click += new System.EventHandler(this.BT_ELIMINARCELULAR490WC_Click);
            // 
            // BT_AGREGARCELULAR490WC
            // 
            this.BT_AGREGARCELULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_AGREGARCELULAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AGREGARCELULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_AGREGARCELULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_AGREGARCELULAR490WC.Location = new System.Drawing.Point(479, 492);
            this.BT_AGREGARCELULAR490WC.Name = "BT_AGREGARCELULAR490WC";
            this.BT_AGREGARCELULAR490WC.Size = new System.Drawing.Size(108, 38);
            this.BT_AGREGARCELULAR490WC.TabIndex = 54;
            this.BT_AGREGARCELULAR490WC.Text = "Agregar";
            this.BT_AGREGARCELULAR490WC.UseVisualStyleBackColor = false;
            this.BT_AGREGARCELULAR490WC.Click += new System.EventHandler(this.BT_AGREGARCELULAR490WC_Click);
            // 
            // labelCelularCliente490WC
            // 
            this.labelCelularCliente490WC.AutoSize = true;
            this.labelCelularCliente490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelCelularCliente490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelCelularCliente490WC.Location = new System.Drawing.Point(509, 337);
            this.labelCelularCliente490WC.Name = "labelCelularCliente490WC";
            this.labelCelularCliente490WC.Size = new System.Drawing.Size(184, 20);
            this.labelCelularCliente490WC.TabIndex = 56;
            this.labelCelularCliente490WC.Text = "Celulares Del Cliente";
            // 
            // LABEL_EMAILSDELCLIENTE490WC
            // 
            this.LABEL_EMAILSDELCLIENTE490WC.AutoSize = true;
            this.LABEL_EMAILSDELCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_EMAILSDELCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_EMAILSDELCLIENTE490WC.Location = new System.Drawing.Point(794, 337);
            this.LABEL_EMAILSDELCLIENTE490WC.Name = "LABEL_EMAILSDELCLIENTE490WC";
            this.LABEL_EMAILSDELCLIENTE490WC.Size = new System.Drawing.Size(167, 20);
            this.LABEL_EMAILSDELCLIENTE490WC.TabIndex = 60;
            this.LABEL_EMAILSDELCLIENTE490WC.Text = "Emails  Del Cliente";
            // 
            // BT_ELIMINAREMAIL490WC
            // 
            this.BT_ELIMINAREMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ELIMINAREMAIL490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ELIMINAREMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ELIMINAREMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ELIMINAREMAIL490WC.Location = new System.Drawing.Point(906, 492);
            this.BT_ELIMINAREMAIL490WC.Name = "BT_ELIMINAREMAIL490WC";
            this.BT_ELIMINAREMAIL490WC.Size = new System.Drawing.Size(108, 38);
            this.BT_ELIMINAREMAIL490WC.TabIndex = 59;
            this.BT_ELIMINAREMAIL490WC.Text = "Eliminar";
            this.BT_ELIMINAREMAIL490WC.UseVisualStyleBackColor = false;
            this.BT_ELIMINAREMAIL490WC.Click += new System.EventHandler(this.BT_ELIMINAREMAIL490WC_Click);
            // 
            // BT_AGREGAREMAIL490WC
            // 
            this.BT_AGREGAREMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_AGREGAREMAIL490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AGREGAREMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_AGREGAREMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_AGREGAREMAIL490WC.Location = new System.Drawing.Point(764, 492);
            this.BT_AGREGAREMAIL490WC.Name = "BT_AGREGAREMAIL490WC";
            this.BT_AGREGAREMAIL490WC.Size = new System.Drawing.Size(108, 38);
            this.BT_AGREGAREMAIL490WC.TabIndex = 58;
            this.BT_AGREGAREMAIL490WC.Text = "Agregar";
            this.BT_AGREGAREMAIL490WC.UseVisualStyleBackColor = false;
            this.BT_AGREGAREMAIL490WC.Click += new System.EventHandler(this.BT_AGREGAREMAIL490WC_Click);
            // 
            // listboxEmailsCliente490WC
            // 
            this.listboxEmailsCliente490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.listboxEmailsCliente490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxEmailsCliente490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.listboxEmailsCliente490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.listboxEmailsCliente490WC.FormattingEnabled = true;
            this.listboxEmailsCliente490WC.ItemHeight = 19;
            this.listboxEmailsCliente490WC.Location = new System.Drawing.Point(764, 360);
            this.listboxEmailsCliente490WC.Name = "listboxEmailsCliente490WC";
            this.listboxEmailsCliente490WC.Size = new System.Drawing.Size(250, 97);
            this.listboxEmailsCliente490WC.TabIndex = 57;
            // 
            // TB_CELULAR490WC
            // 
            this.TB_CELULAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_CELULAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CELULAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_CELULAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_CELULAR490WC.Location = new System.Drawing.Point(479, 459);
            this.TB_CELULAR490WC.Name = "TB_CELULAR490WC";
            this.TB_CELULAR490WC.Size = new System.Drawing.Size(250, 27);
            this.TB_CELULAR490WC.TabIndex = 61;
            // 
            // TB_EMAIL490WC
            // 
            this.TB_EMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_EMAIL490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_EMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_EMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_EMAIL490WC.Location = new System.Drawing.Point(764, 459);
            this.TB_EMAIL490WC.Name = "TB_EMAIL490WC";
            this.TB_EMAIL490WC.Size = new System.Drawing.Size(250, 27);
            this.TB_EMAIL490WC.TabIndex = 62;
            // 
            // BT_Activar490WC
            // 
            this.BT_Activar490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_Activar490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Activar490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_Activar490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_Activar490WC.Location = new System.Drawing.Point(226, 477);
            this.BT_Activar490WC.Name = "BT_Activar490WC";
            this.BT_Activar490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_Activar490WC.TabIndex = 63;
            this.BT_Activar490WC.Text = "Activar";
            this.BT_Activar490WC.UseVisualStyleBackColor = false;
            this.BT_Activar490WC.Click += new System.EventHandler(this.BT_Activar490WC_Click);
            // 
            // PrevisualizadorXML490WC
            // 
            this.PrevisualizadorXML490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.PrevisualizadorXML490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrevisualizadorXML490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.PrevisualizadorXML490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.PrevisualizadorXML490WC.Location = new System.Drawing.Point(12, 539);
            this.PrevisualizadorXML490WC.Multiline = true;
            this.PrevisualizadorXML490WC.Name = "PrevisualizadorXML490WC";
            this.PrevisualizadorXML490WC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrevisualizadorXML490WC.Size = new System.Drawing.Size(1233, 259);
            this.PrevisualizadorXML490WC.TabIndex = 64;
            // 
            // BT_MODOSERIALIZAR490WC
            // 
            this.BT_MODOSERIALIZAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_MODOSERIALIZAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MODOSERIALIZAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_MODOSERIALIZAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_MODOSERIALIZAR490WC.Location = new System.Drawing.Point(1270, 536);
            this.BT_MODOSERIALIZAR490WC.Name = "BT_MODOSERIALIZAR490WC";
            this.BT_MODOSERIALIZAR490WC.Size = new System.Drawing.Size(136, 47);
            this.BT_MODOSERIALIZAR490WC.TabIndex = 65;
            this.BT_MODOSERIALIZAR490WC.Text = "Serializar";
            this.BT_MODOSERIALIZAR490WC.UseVisualStyleBackColor = false;
            this.BT_MODOSERIALIZAR490WC.Click += new System.EventHandler(this.BT_MODOSERIALIZAR490WC_Click);
            // 
            // BT_ACEPTARSERIALIZAR490WC
            // 
            this.BT_ACEPTARSERIALIZAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ACEPTARSERIALIZAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ACEPTARSERIALIZAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ACEPTARSERIALIZAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ACEPTARSERIALIZAR490WC.Location = new System.Drawing.Point(1270, 589);
            this.BT_ACEPTARSERIALIZAR490WC.Name = "BT_ACEPTARSERIALIZAR490WC";
            this.BT_ACEPTARSERIALIZAR490WC.Size = new System.Drawing.Size(136, 47);
            this.BT_ACEPTARSERIALIZAR490WC.TabIndex = 66;
            this.BT_ACEPTARSERIALIZAR490WC.Text = "Aceptar";
            this.BT_ACEPTARSERIALIZAR490WC.UseVisualStyleBackColor = false;
            this.BT_ACEPTARSERIALIZAR490WC.Click += new System.EventHandler(this.BT_ACEPTARSERIALIZAR490WC_Click);
            // 
            // BT_CANCELARSERIALIZAR490WC
            // 
            this.BT_CANCELARSERIALIZAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELARSERIALIZAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELARSERIALIZAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELARSERIALIZAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELARSERIALIZAR490WC.Location = new System.Drawing.Point(1270, 642);
            this.BT_CANCELARSERIALIZAR490WC.Name = "BT_CANCELARSERIALIZAR490WC";
            this.BT_CANCELARSERIALIZAR490WC.Size = new System.Drawing.Size(136, 47);
            this.BT_CANCELARSERIALIZAR490WC.TabIndex = 67;
            this.BT_CANCELARSERIALIZAR490WC.Text = "Cancelar";
            this.BT_CANCELARSERIALIZAR490WC.UseVisualStyleBackColor = false;
            this.BT_CANCELARSERIALIZAR490WC.Click += new System.EventHandler(this.BT_CANCELARSERIALIZAR490WC_Click);
            // 
            // BT_DesSerializar490WC
            // 
            this.BT_DesSerializar490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_DesSerializar490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_DesSerializar490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_DesSerializar490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_DesSerializar490WC.Location = new System.Drawing.Point(1270, 695);
            this.BT_DesSerializar490WC.Name = "BT_DesSerializar490WC";
            this.BT_DesSerializar490WC.Size = new System.Drawing.Size(136, 47);
            this.BT_DesSerializar490WC.TabIndex = 69;
            this.BT_DesSerializar490WC.Text = "Deserializar";
            this.BT_DesSerializar490WC.UseVisualStyleBackColor = false;
            this.BT_DesSerializar490WC.Click += new System.EventHandler(this.BT_DesSerializar490WC_Click);
            // 
            // BT_LIMPIARDESERIALIZAR490WC
            // 
            this.BT_LIMPIARDESERIALIZAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_LIMPIARDESERIALIZAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LIMPIARDESERIALIZAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_LIMPIARDESERIALIZAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_LIMPIARDESERIALIZAR490WC.Location = new System.Drawing.Point(1270, 748);
            this.BT_LIMPIARDESERIALIZAR490WC.Name = "BT_LIMPIARDESERIALIZAR490WC";
            this.BT_LIMPIARDESERIALIZAR490WC.Size = new System.Drawing.Size(136, 47);
            this.BT_LIMPIARDESERIALIZAR490WC.TabIndex = 70;
            this.BT_LIMPIARDESERIALIZAR490WC.Text = "Limpiar";
            this.BT_LIMPIARDESERIALIZAR490WC.UseVisualStyleBackColor = false;
            this.BT_LIMPIARDESERIALIZAR490WC.Click += new System.EventHandler(this.BT_LIMPIARDESERIALIZAR490WC_Click);
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
            // columnaDireccion
            // 
            this.columnaDireccion.HeaderText = "Direccion";
            this.columnaDireccion.Name = "columnaDireccion";
            this.columnaDireccion.ReadOnly = true;
            // 
            // columnaEmail
            // 
            this.columnaEmail.HeaderText = "Emails";
            this.columnaEmail.Name = "columnaEmail";
            this.columnaEmail.ReadOnly = true;
            // 
            // columnaCelulares
            // 
            this.columnaCelulares.HeaderText = "Celurares";
            this.columnaCelulares.Name = "columnaCelulares";
            this.columnaCelulares.ReadOnly = true;
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
            // FormMaestroCliente490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1426, 807);
            this.Controls.Add(this.BT_LIMPIARDESERIALIZAR490WC);
            this.Controls.Add(this.BT_DesSerializar490WC);
            this.Controls.Add(this.BT_CANCELARSERIALIZAR490WC);
            this.Controls.Add(this.BT_ACEPTARSERIALIZAR490WC);
            this.Controls.Add(this.BT_MODOSERIALIZAR490WC);
            this.Controls.Add(this.PrevisualizadorXML490WC);
            this.Controls.Add(this.BT_Activar490WC);
            this.Controls.Add(this.TB_EMAIL490WC);
            this.Controls.Add(this.TB_CELULAR490WC);
            this.Controls.Add(this.LABEL_EMAILSDELCLIENTE490WC);
            this.Controls.Add(this.BT_ELIMINAREMAIL490WC);
            this.Controls.Add(this.BT_AGREGAREMAIL490WC);
            this.Controls.Add(this.listboxEmailsCliente490WC);
            this.Controls.Add(this.labelCelularCliente490WC);
            this.Controls.Add(this.BT_ELIMINARCELULAR490WC);
            this.Controls.Add(this.BT_AGREGARCELULAR490WC);
            this.Controls.Add(this.listboxCelularesCliente490WC);
            this.Controls.Add(this.LABEL_ESTRELLASCLIENTE490WC);
            this.Controls.Add(this.TB_ESTRELLASCLIENTE490WC);
            this.Controls.Add(this.labelDireccion490WC);
            this.Controls.Add(this.TB_DIRECCION490WC);
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
            this.Load += new System.EventHandler(this.FormMaestroCliente490WC_Load);
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
        private System.Windows.Forms.Label labelDireccion490WC;
        private System.Windows.Forms.TextBox TB_DIRECCION490WC;
        private System.Windows.Forms.TextBox TB_ESTRELLASCLIENTE490WC;
        private System.Windows.Forms.Label LABEL_ESTRELLASCLIENTE490WC;
        private System.Windows.Forms.ListBox listboxCelularesCliente490WC;
        private System.Windows.Forms.Button BT_ELIMINARCELULAR490WC;
        private System.Windows.Forms.Button BT_AGREGARCELULAR490WC;
        private System.Windows.Forms.Label labelCelularCliente490WC;
        private System.Windows.Forms.Label LABEL_EMAILSDELCLIENTE490WC;
        private System.Windows.Forms.Button BT_ELIMINAREMAIL490WC;
        private System.Windows.Forms.Button BT_AGREGAREMAIL490WC;
        private System.Windows.Forms.ListBox listboxEmailsCliente490WC;
        private System.Windows.Forms.TextBox TB_CELULAR490WC;
        private System.Windows.Forms.TextBox TB_EMAIL490WC;
        private System.Windows.Forms.Button BT_Activar490WC;
        private System.Windows.Forms.TextBox PrevisualizadorXML490WC;
        private System.Windows.Forms.Button BT_MODOSERIALIZAR490WC;
        private System.Windows.Forms.Button BT_ACEPTARSERIALIZAR490WC;
        private System.Windows.Forms.Button BT_CANCELARSERIALIZAR490WC;
        private System.Windows.Forms.Button BT_DesSerializar490WC;
        private System.Windows.Forms.Button BT_LIMPIARDESERIALIZAR490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCelulares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTRELLAS_CLIENTE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN_ESTRELLA;
    }
}