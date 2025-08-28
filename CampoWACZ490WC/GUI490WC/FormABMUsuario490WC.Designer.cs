namespace GUI490WC
{
    partial class FormABMUsuario490WC
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
            this.dgvUsuario490WC = new System.Windows.Forms.DataGridView();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROL_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBLOQUEADO_USUARIO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IS_HABILITADOUSUARIO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BT_MODIFICAR_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_ALTA_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_DESBLOQUEAR_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_BAJA_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_APLICAR490WC = new System.Windows.Forms.Button();
            this.BT_ACTIVAR_USUARIO490WC = new System.Windows.Forms.Button();
            this.BT_SALIR490WC = new System.Windows.Forms.Button();
            this.TB_NOMBRE490WC = new System.Windows.Forms.TextBox();
            this.TB_APELLIDO490WC = new System.Windows.Forms.TextBox();
            this.TB_DNI490WC = new System.Windows.Forms.TextBox();
            this.TB_EMAIL490WC = new System.Windows.Forms.TextBox();
            this.CB_ROL490WC = new System.Windows.Forms.ComboBox();
            this.LABEL_EMAIL_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_DNI_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_APELLIDO_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_NOMBRE_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.LABEL_ROL_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.checkBoxMostrarDesactivados490WC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario490WC
            // 
            this.dgvUsuario490WC.AllowUserToAddRows = false;
            this.dgvUsuario490WC.AllowUserToDeleteRows = false;
            this.dgvUsuario490WC.AllowUserToResizeColumns = false;
            this.dgvUsuario490WC.AllowUserToResizeRows = false;
            this.dgvUsuario490WC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario490WC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario490WC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsuario,
            this.NOMBRE_USUARIO,
            this.APELLIDO_USUARIO,
            this.DNI_USUARIO,
            this.EMAIL_USUARIO,
            this.ROL_USUARIO,
            this.ISBLOQUEADO_USUARIO,
            this.IS_HABILITADOUSUARIO});
            this.dgvUsuario490WC.Location = new System.Drawing.Point(12, 28);
            this.dgvUsuario490WC.MultiSelect = false;
            this.dgvUsuario490WC.Name = "dgvUsuario490WC";
            this.dgvUsuario490WC.ReadOnly = true;
            this.dgvUsuario490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuario490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario490WC.Size = new System.Drawing.Size(1092, 221);
            this.dgvUsuario490WC.TabIndex = 0;
            this.dgvUsuario490WC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuario490WC_CellMouseClick);
            // 
            // ColumnUsuario
            // 
            this.ColumnUsuario.HeaderText = "Usuario";
            this.ColumnUsuario.Name = "ColumnUsuario";
            this.ColumnUsuario.ReadOnly = true;
            // 
            // NOMBRE_USUARIO
            // 
            this.NOMBRE_USUARIO.HeaderText = "Nombre";
            this.NOMBRE_USUARIO.Name = "NOMBRE_USUARIO";
            this.NOMBRE_USUARIO.ReadOnly = true;
            // 
            // APELLIDO_USUARIO
            // 
            this.APELLIDO_USUARIO.HeaderText = "Apellido";
            this.APELLIDO_USUARIO.Name = "APELLIDO_USUARIO";
            this.APELLIDO_USUARIO.ReadOnly = true;
            // 
            // DNI_USUARIO
            // 
            this.DNI_USUARIO.HeaderText = "DNI";
            this.DNI_USUARIO.Name = "DNI_USUARIO";
            this.DNI_USUARIO.ReadOnly = true;
            // 
            // EMAIL_USUARIO
            // 
            this.EMAIL_USUARIO.HeaderText = "Email";
            this.EMAIL_USUARIO.Name = "EMAIL_USUARIO";
            this.EMAIL_USUARIO.ReadOnly = true;
            // 
            // ROL_USUARIO
            // 
            this.ROL_USUARIO.HeaderText = "Rol";
            this.ROL_USUARIO.Name = "ROL_USUARIO";
            this.ROL_USUARIO.ReadOnly = true;
            // 
            // ISBLOQUEADO_USUARIO
            // 
            this.ISBLOQUEADO_USUARIO.HeaderText = "Bloqueado";
            this.ISBLOQUEADO_USUARIO.Name = "ISBLOQUEADO_USUARIO";
            this.ISBLOQUEADO_USUARIO.ReadOnly = true;
            // 
            // IS_HABILITADOUSUARIO
            // 
            this.IS_HABILITADOUSUARIO.HeaderText = "Habilitado";
            this.IS_HABILITADOUSUARIO.Name = "IS_HABILITADOUSUARIO";
            this.IS_HABILITADOUSUARIO.ReadOnly = true;
            // 
            // BT_MODIFICAR_USUARIO490WC
            // 
            this.BT_MODIFICAR_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_MODIFICAR_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MODIFICAR_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_MODIFICAR_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_MODIFICAR_USUARIO490WC.Location = new System.Drawing.Point(730, 260);
            this.BT_MODIFICAR_USUARIO490WC.Name = "BT_MODIFICAR_USUARIO490WC";
            this.BT_MODIFICAR_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_MODIFICAR_USUARIO490WC.TabIndex = 5;
            this.BT_MODIFICAR_USUARIO490WC.Text = "Modificar";
            this.BT_MODIFICAR_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_MODIFICAR_USUARIO490WC.Click += new System.EventHandler(this.BT_MODIFICAR_USUARIO490WC_Click);
            // 
            // BT_ALTA_USUARIO490WC
            // 
            this.BT_ALTA_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ALTA_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ALTA_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ALTA_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ALTA_USUARIO490WC.Location = new System.Drawing.Point(920, 260);
            this.BT_ALTA_USUARIO490WC.Name = "BT_ALTA_USUARIO490WC";
            this.BT_ALTA_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_ALTA_USUARIO490WC.TabIndex = 6;
            this.BT_ALTA_USUARIO490WC.Text = "Alta";
            this.BT_ALTA_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_ALTA_USUARIO490WC.Click += new System.EventHandler(this.BT_ALTA_USUARIO490WC_Click);
            // 
            // BT_DESBLOQUEAR_USUARIO490WC
            // 
            this.BT_DESBLOQUEAR_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_DESBLOQUEAR_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_DESBLOQUEAR_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_DESBLOQUEAR_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_DESBLOQUEAR_USUARIO490WC.Location = new System.Drawing.Point(730, 313);
            this.BT_DESBLOQUEAR_USUARIO490WC.Name = "BT_DESBLOQUEAR_USUARIO490WC";
            this.BT_DESBLOQUEAR_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_DESBLOQUEAR_USUARIO490WC.TabIndex = 7;
            this.BT_DESBLOQUEAR_USUARIO490WC.Text = "Desbloquear";
            this.BT_DESBLOQUEAR_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_DESBLOQUEAR_USUARIO490WC.Click += new System.EventHandler(this.BT_DESBLOQUEAR_USUARIO490WC_Click);
            // 
            // BT_BAJA_USUARIO490WC
            // 
            this.BT_BAJA_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BAJA_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BAJA_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BAJA_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BAJA_USUARIO490WC.Location = new System.Drawing.Point(920, 313);
            this.BT_BAJA_USUARIO490WC.Name = "BT_BAJA_USUARIO490WC";
            this.BT_BAJA_USUARIO490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_BAJA_USUARIO490WC.TabIndex = 8;
            this.BT_BAJA_USUARIO490WC.Text = "Baja";
            this.BT_BAJA_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_BAJA_USUARIO490WC.Click += new System.EventHandler(this.BT_BAJA_USUARIO490WC_Click);
            // 
            // BT_CANCELAR490WC
            // 
            this.BT_CANCELAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(730, 366);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_CANCELAR490WC.TabIndex = 9;
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
            this.BT_APLICAR490WC.Location = new System.Drawing.Point(920, 366);
            this.BT_APLICAR490WC.Name = "BT_APLICAR490WC";
            this.BT_APLICAR490WC.Size = new System.Drawing.Size(184, 47);
            this.BT_APLICAR490WC.TabIndex = 10;
            this.BT_APLICAR490WC.Text = "Aplicar";
            this.BT_APLICAR490WC.UseVisualStyleBackColor = false;
            this.BT_APLICAR490WC.Click += new System.EventHandler(this.BT_APLICAR490WC_Click);
            // 
            // BT_ACTIVAR_USUARIO490WC
            // 
            this.BT_ACTIVAR_USUARIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ACTIVAR_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ACTIVAR_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ACTIVAR_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ACTIVAR_USUARIO490WC.Location = new System.Drawing.Point(730, 419);
            this.BT_ACTIVAR_USUARIO490WC.Name = "BT_ACTIVAR_USUARIO490WC";
            this.BT_ACTIVAR_USUARIO490WC.Size = new System.Drawing.Size(374, 47);
            this.BT_ACTIVAR_USUARIO490WC.TabIndex = 11;
            this.BT_ACTIVAR_USUARIO490WC.Text = "Activar/Desactivar";
            this.BT_ACTIVAR_USUARIO490WC.UseVisualStyleBackColor = false;
            this.BT_ACTIVAR_USUARIO490WC.Click += new System.EventHandler(this.BT_ACTIVAR_USUARIO490WC_Click);
            // 
            // BT_SALIR490WC
            // 
            this.BT_SALIR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_SALIR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_SALIR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_SALIR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_SALIR490WC.Location = new System.Drawing.Point(730, 472);
            this.BT_SALIR490WC.Name = "BT_SALIR490WC";
            this.BT_SALIR490WC.Size = new System.Drawing.Size(374, 47);
            this.BT_SALIR490WC.TabIndex = 12;
            this.BT_SALIR490WC.Text = "Salir";
            this.BT_SALIR490WC.UseVisualStyleBackColor = false;
            this.BT_SALIR490WC.Click += new System.EventHandler(this.BT_SALIR490WC_Click);
            // 
            // TB_NOMBRE490WC
            // 
            this.TB_NOMBRE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_NOMBRE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NOMBRE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_NOMBRE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_NOMBRE490WC.Location = new System.Drawing.Point(158, 280);
            this.TB_NOMBRE490WC.Name = "TB_NOMBRE490WC";
            this.TB_NOMBRE490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_NOMBRE490WC.TabIndex = 14;
            // 
            // TB_APELLIDO490WC
            // 
            this.TB_APELLIDO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_APELLIDO490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_APELLIDO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_APELLIDO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_APELLIDO490WC.Location = new System.Drawing.Point(158, 324);
            this.TB_APELLIDO490WC.Name = "TB_APELLIDO490WC";
            this.TB_APELLIDO490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_APELLIDO490WC.TabIndex = 15;
            // 
            // TB_DNI490WC
            // 
            this.TB_DNI490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DNI490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DNI490WC.Location = new System.Drawing.Point(158, 364);
            this.TB_DNI490WC.Name = "TB_DNI490WC";
            this.TB_DNI490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_DNI490WC.TabIndex = 16;
            // 
            // TB_EMAIL490WC
            // 
            this.TB_EMAIL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_EMAIL490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_EMAIL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_EMAIL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_EMAIL490WC.Location = new System.Drawing.Point(158, 409);
            this.TB_EMAIL490WC.Name = "TB_EMAIL490WC";
            this.TB_EMAIL490WC.Size = new System.Drawing.Size(219, 27);
            this.TB_EMAIL490WC.TabIndex = 17;
            // 
            // CB_ROL490WC
            // 
            this.CB_ROL490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_ROL490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ROL490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_ROL490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_ROL490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_ROL490WC.FormattingEnabled = true;
            this.CB_ROL490WC.Location = new System.Drawing.Point(158, 453);
            this.CB_ROL490WC.Name = "CB_ROL490WC";
            this.CB_ROL490WC.Size = new System.Drawing.Size(219, 27);
            this.CB_ROL490WC.TabIndex = 18;
            // 
            // LABEL_EMAIL_ABM_USUARIO490WC
            // 
            this.LABEL_EMAIL_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_EMAIL_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_EMAIL_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_EMAIL_ABM_USUARIO490WC.Location = new System.Drawing.Point(21, 409);
            this.LABEL_EMAIL_ABM_USUARIO490WC.Name = "LABEL_EMAIL_ABM_USUARIO490WC";
            this.LABEL_EMAIL_ABM_USUARIO490WC.Size = new System.Drawing.Size(56, 20);
            this.LABEL_EMAIL_ABM_USUARIO490WC.TabIndex = 20;
            this.LABEL_EMAIL_ABM_USUARIO490WC.Text = "Email";
            // 
            // LABEL_DNI_ABM_USUARIO490WC
            // 
            this.LABEL_DNI_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_DNI_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DNI_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DNI_ABM_USUARIO490WC.Location = new System.Drawing.Point(21, 364);
            this.LABEL_DNI_ABM_USUARIO490WC.Name = "LABEL_DNI_ABM_USUARIO490WC";
            this.LABEL_DNI_ABM_USUARIO490WC.Size = new System.Drawing.Size(40, 20);
            this.LABEL_DNI_ABM_USUARIO490WC.TabIndex = 21;
            this.LABEL_DNI_ABM_USUARIO490WC.Text = "DNI";
            // 
            // LABEL_APELLIDO_ABM_USUARIO490WC
            // 
            this.LABEL_APELLIDO_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Location = new System.Drawing.Point(21, 324);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Name = "LABEL_APELLIDO_ABM_USUARIO490WC";
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Size = new System.Drawing.Size(79, 20);
            this.LABEL_APELLIDO_ABM_USUARIO490WC.TabIndex = 22;
            this.LABEL_APELLIDO_ABM_USUARIO490WC.Text = "Apellido";
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(21, 279);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Name = "LABEL_NOMBRE_ABM_USUARIO490WC";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Size = new System.Drawing.Size(77, 20);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TabIndex = 23;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Text = "Nombre";
            // 
            // LABEL_ROL_ABM_USUARIO490WC
            // 
            this.LABEL_ROL_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_ROL_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_ROL_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_ROL_ABM_USUARIO490WC.Location = new System.Drawing.Point(21, 453);
            this.LABEL_ROL_ABM_USUARIO490WC.Name = "LABEL_ROL_ABM_USUARIO490WC";
            this.LABEL_ROL_ABM_USUARIO490WC.Size = new System.Drawing.Size(36, 20);
            this.LABEL_ROL_ABM_USUARIO490WC.TabIndex = 24;
            this.LABEL_ROL_ABM_USUARIO490WC.Text = "Rol";
            // 
            // checkBoxMostrarDesactivados490WC
            // 
            this.checkBoxMostrarDesactivados490WC.AutoSize = true;
            this.checkBoxMostrarDesactivados490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.checkBoxMostrarDesactivados490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.checkBoxMostrarDesactivados490WC.Location = new System.Drawing.Point(429, 272);
            this.checkBoxMostrarDesactivados490WC.Name = "checkBoxMostrarDesactivados490WC";
            this.checkBoxMostrarDesactivados490WC.Size = new System.Drawing.Size(211, 24);
            this.checkBoxMostrarDesactivados490WC.TabIndex = 25;
            this.checkBoxMostrarDesactivados490WC.Text = "MostrarDesactivados";
            this.checkBoxMostrarDesactivados490WC.UseVisualStyleBackColor = true;
            this.checkBoxMostrarDesactivados490WC.CheckedChanged += new System.EventHandler(this.checkBoxMostrarDesactivados490WC_CheckedChanged);
            // 
            // FormABMUsuario490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1116, 545);
            this.Controls.Add(this.checkBoxMostrarDesactivados490WC);
            this.Controls.Add(this.LABEL_ROL_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_NOMBRE_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_APELLIDO_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_DNI_ABM_USUARIO490WC);
            this.Controls.Add(this.LABEL_EMAIL_ABM_USUARIO490WC);
            this.Controls.Add(this.CB_ROL490WC);
            this.Controls.Add(this.TB_EMAIL490WC);
            this.Controls.Add(this.TB_DNI490WC);
            this.Controls.Add(this.TB_APELLIDO490WC);
            this.Controls.Add(this.TB_NOMBRE490WC);
            this.Controls.Add(this.BT_SALIR490WC);
            this.Controls.Add(this.BT_ACTIVAR_USUARIO490WC);
            this.Controls.Add(this.BT_APLICAR490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.BT_BAJA_USUARIO490WC);
            this.Controls.Add(this.BT_DESBLOQUEAR_USUARIO490WC);
            this.Controls.Add(this.BT_ALTA_USUARIO490WC);
            this.Controls.Add(this.BT_MODIFICAR_USUARIO490WC);
            this.Controls.Add(this.dgvUsuario490WC);
            this.Name = "FormABMUsuario490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormABMUsuario490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormABMUsuario490WC_FormClosed);
            this.Load += new System.EventHandler(this.FormABMUsuario490WC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario490WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROL_USUARIO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISBLOQUEADO_USUARIO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IS_HABILITADOUSUARIO;
        private System.Windows.Forms.Button BT_MODIFICAR_USUARIO490WC;
        private System.Windows.Forms.Button BT_ALTA_USUARIO490WC;
        private System.Windows.Forms.Button BT_DESBLOQUEAR_USUARIO490WC;
        private System.Windows.Forms.Button BT_BAJA_USUARIO490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_APLICAR490WC;
        private System.Windows.Forms.Button BT_ACTIVAR_USUARIO490WC;
        private System.Windows.Forms.Button BT_SALIR490WC;
        private System.Windows.Forms.TextBox TB_NOMBRE490WC;
        private System.Windows.Forms.TextBox TB_APELLIDO490WC;
        private System.Windows.Forms.TextBox TB_DNI490WC;
        private System.Windows.Forms.TextBox TB_EMAIL490WC;
        private System.Windows.Forms.ComboBox CB_ROL490WC;
        private System.Windows.Forms.Label LABEL_EMAIL_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_DNI_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_APELLIDO_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_NOMBRE_ABM_USUARIO490WC;
        private System.Windows.Forms.Label LABEL_ROL_ABM_USUARIO490WC;
        private System.Windows.Forms.CheckBox checkBoxMostrarDesactivados490WC;
    }
}