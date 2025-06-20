﻿namespace GUI490WC
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
            this.labelDireccion490WC = new System.Windows.Forms.Label();
            this.TB_DIRECCION490WC = new System.Windows.Forms.TextBox();
            this.TB_ESTRELLASCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxCelularesCliente490WC = new System.Windows.Forms.ListBox();
            this.BT_ELIMINARCELULAR490WC = new System.Windows.Forms.Button();
            this.BT_AGREGARCELULAR490WC = new System.Windows.Forms.Button();
            this.labelCelularCliente490WC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_ELIMINAREMAIL490WC = new System.Windows.Forms.Button();
            this.BT_AGREGAREMAIL490WC = new System.Windows.Forms.Button();
            this.listboxEmailsCliente490WC = new System.Windows.Forms.ListBox();
            this.TB_CELULAR490WC = new System.Windows.Forms.TextBox();
            this.TB_EMAIL490WC = new System.Windows.Forms.TextBox();
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
            // labelDireccion490WC
            // 
            this.labelDireccion490WC.AutoSize = true;
            this.labelDireccion490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelDireccion490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelDireccion490WC.Location = new System.Drawing.Point(222, 340);
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
            this.TB_DIRECCION490WC.Location = new System.Drawing.Point(226, 363);
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
            this.TB_ESTRELLASCLIENTE490WC.Location = new System.Drawing.Point(226, 424);
            this.TB_ESTRELLASCLIENTE490WC.Name = "TB_ESTRELLASCLIENTE490WC";
            this.TB_ESTRELLASCLIENTE490WC.Size = new System.Drawing.Size(184, 27);
            this.TB_ESTRELLASCLIENTE490WC.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(222, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Estrellas Cliente";
            // 
            // listboxCelularesCliente490WC
            // 
            this.listboxCelularesCliente490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.listboxCelularesCliente490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxCelularesCliente490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.listboxCelularesCliente490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.listboxCelularesCliente490WC.FormattingEnabled = true;
            this.listboxCelularesCliente490WC.ItemHeight = 19;
            this.listboxCelularesCliente490WC.Location = new System.Drawing.Point(432, 354);
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
            this.BT_ELIMINARCELULAR490WC.Location = new System.Drawing.Point(574, 486);
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
            this.BT_AGREGARCELULAR490WC.Location = new System.Drawing.Point(432, 486);
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
            this.labelCelularCliente490WC.Location = new System.Drawing.Point(462, 331);
            this.labelCelularCliente490WC.Name = "labelCelularCliente490WC";
            this.labelCelularCliente490WC.Size = new System.Drawing.Size(184, 20);
            this.labelCelularCliente490WC.TabIndex = 56;
            this.labelCelularCliente490WC.Text = "Celulares Del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(747, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Emails  Del Cliente";
            // 
            // BT_ELIMINAREMAIL490WC
            // 
            this.BT_ELIMINAREMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ELIMINAREMAIL490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ELIMINAREMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ELIMINAREMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ELIMINAREMAIL490WC.Location = new System.Drawing.Point(859, 486);
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
            this.BT_AGREGAREMAIL490WC.Location = new System.Drawing.Point(717, 486);
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
            this.listboxEmailsCliente490WC.Location = new System.Drawing.Point(717, 354);
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
            this.TB_CELULAR490WC.Location = new System.Drawing.Point(432, 453);
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
            this.TB_EMAIL490WC.Location = new System.Drawing.Point(717, 453);
            this.TB_EMAIL490WC.Name = "TB_EMAIL490WC";
            this.TB_EMAIL490WC.Size = new System.Drawing.Size(250, 27);
            this.TB_EMAIL490WC.TabIndex = 62;
            // 
            // FormMaestroCliente490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(983, 536);
            this.Controls.Add(this.TB_EMAIL490WC);
            this.Controls.Add(this.TB_CELULAR490WC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_ELIMINAREMAIL490WC);
            this.Controls.Add(this.BT_AGREGAREMAIL490WC);
            this.Controls.Add(this.listboxEmailsCliente490WC);
            this.Controls.Add(this.labelCelularCliente490WC);
            this.Controls.Add(this.BT_ELIMINARCELULAR490WC);
            this.Controls.Add(this.BT_AGREGARCELULAR490WC);
            this.Controls.Add(this.listboxCelularesCliente490WC);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTRELLAS_CLIENTE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN_ESTRELLA;
        private System.Windows.Forms.TextBox TB_ESTRELLASCLIENTE490WC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxCelularesCliente490WC;
        private System.Windows.Forms.Button BT_ELIMINARCELULAR490WC;
        private System.Windows.Forms.Button BT_AGREGARCELULAR490WC;
        private System.Windows.Forms.Label labelCelularCliente490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_ELIMINAREMAIL490WC;
        private System.Windows.Forms.Button BT_AGREGAREMAIL490WC;
        private System.Windows.Forms.ListBox listboxEmailsCliente490WC;
        private System.Windows.Forms.TextBox TB_CELULAR490WC;
        private System.Windows.Forms.TextBox TB_EMAIL490WC;
    }
}