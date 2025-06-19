namespace GUI490WC
{
    partial class FormPermisos490WC
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
            this.CB_Familias = new System.Windows.Forms.ComboBox();
            this.BT_ElimiarSeleccionado = new System.Windows.Forms.Button();
            this.BT_ModificarNombre = new System.Windows.Forms.Button();
            this.BT_CrearRol = new System.Windows.Forms.Button();
            this.BT_CrearGrupoDePermisos = new System.Windows.Forms.Button();
            this.BT_GuardarCambios = new System.Windows.Forms.Button();
            this.TB_NuevoNombre = new System.Windows.Forms.TextBox();
            this.listaPermisos490WC = new System.Windows.Forms.CheckedListBox();
            this.vistaPermisosArbol = new System.Windows.Forms.TreeView();
            this.LABEL_NOMBRE_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Familias
            // 
            this.CB_Familias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_Familias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Familias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Familias.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_Familias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_Familias.FormattingEnabled = true;
            this.CB_Familias.Location = new System.Drawing.Point(44, 68);
            this.CB_Familias.Name = "CB_Familias";
            this.CB_Familias.Size = new System.Drawing.Size(219, 27);
            this.CB_Familias.TabIndex = 19;
            this.CB_Familias.SelectedIndexChanged += new System.EventHandler(this.CB_Familias_SelectedIndexChanged);
            // 
            // BT_ElimiarSeleccionado
            // 
            this.BT_ElimiarSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ElimiarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ElimiarSeleccionado.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ElimiarSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ElimiarSeleccionado.Location = new System.Drawing.Point(44, 123);
            this.BT_ElimiarSeleccionado.Name = "BT_ElimiarSeleccionado";
            this.BT_ElimiarSeleccionado.Size = new System.Drawing.Size(219, 47);
            this.BT_ElimiarSeleccionado.TabIndex = 20;
            this.BT_ElimiarSeleccionado.Text = "Eliminar Seleccionado";
            this.BT_ElimiarSeleccionado.UseVisualStyleBackColor = false;
            this.BT_ElimiarSeleccionado.Click += new System.EventHandler(this.BT_ElimiarSeleccionado_Click);
            // 
            // BT_ModificarNombre
            // 
            this.BT_ModificarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ModificarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ModificarNombre.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_ModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ModificarNombre.Location = new System.Drawing.Point(44, 187);
            this.BT_ModificarNombre.Name = "BT_ModificarNombre";
            this.BT_ModificarNombre.Size = new System.Drawing.Size(219, 47);
            this.BT_ModificarNombre.TabIndex = 21;
            this.BT_ModificarNombre.Text = "Modificar Nombre";
            this.BT_ModificarNombre.UseVisualStyleBackColor = false;
            this.BT_ModificarNombre.Click += new System.EventHandler(this.BT_ModificarNombre_Click);
            // 
            // BT_CrearRol
            // 
            this.BT_CrearRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CrearRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CrearRol.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CrearRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CrearRol.Location = new System.Drawing.Point(44, 329);
            this.BT_CrearRol.Name = "BT_CrearRol";
            this.BT_CrearRol.Size = new System.Drawing.Size(219, 47);
            this.BT_CrearRol.TabIndex = 22;
            this.BT_CrearRol.Text = "Crear Rol";
            this.BT_CrearRol.UseVisualStyleBackColor = false;
            this.BT_CrearRol.Click += new System.EventHandler(this.BT_CrearRol_Click);
            // 
            // BT_CrearGrupoDePermisos
            // 
            this.BT_CrearGrupoDePermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CrearGrupoDePermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CrearGrupoDePermisos.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CrearGrupoDePermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CrearGrupoDePermisos.Location = new System.Drawing.Point(44, 382);
            this.BT_CrearGrupoDePermisos.Name = "BT_CrearGrupoDePermisos";
            this.BT_CrearGrupoDePermisos.Size = new System.Drawing.Size(219, 47);
            this.BT_CrearGrupoDePermisos.TabIndex = 23;
            this.BT_CrearGrupoDePermisos.Text = "Crear Grupo Permisos";
            this.BT_CrearGrupoDePermisos.UseVisualStyleBackColor = false;
            this.BT_CrearGrupoDePermisos.Click += new System.EventHandler(this.BT_CrearGrupoDePermisos_Click);
            // 
            // BT_GuardarCambios
            // 
            this.BT_GuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_GuardarCambios.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_GuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_GuardarCambios.Location = new System.Drawing.Point(44, 435);
            this.BT_GuardarCambios.Name = "BT_GuardarCambios";
            this.BT_GuardarCambios.Size = new System.Drawing.Size(219, 47);
            this.BT_GuardarCambios.TabIndex = 24;
            this.BT_GuardarCambios.Text = "Guardar Cambios";
            this.BT_GuardarCambios.UseVisualStyleBackColor = false;
            this.BT_GuardarCambios.Click += new System.EventHandler(this.BT_GuardarCambios_Click);
            // 
            // TB_NuevoNombre
            // 
            this.TB_NuevoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_NuevoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NuevoNombre.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_NuevoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_NuevoNombre.Location = new System.Drawing.Point(44, 286);
            this.TB_NuevoNombre.Name = "TB_NuevoNombre";
            this.TB_NuevoNombre.Size = new System.Drawing.Size(219, 27);
            this.TB_NuevoNombre.TabIndex = 25;
            // 
            // listaPermisos490WC
            // 
            this.listaPermisos490WC.FormattingEnabled = true;
            this.listaPermisos490WC.Location = new System.Drawing.Point(357, 68);
            this.listaPermisos490WC.Name = "listaPermisos490WC";
            this.listaPermisos490WC.Size = new System.Drawing.Size(234, 304);
            this.listaPermisos490WC.TabIndex = 26;
            // 
            // vistaPermisosArbol
            // 
            this.vistaPermisosArbol.Location = new System.Drawing.Point(749, 68);
            this.vistaPermisosArbol.Name = "vistaPermisosArbol";
            this.vistaPermisosArbol.Size = new System.Drawing.Size(234, 308);
            this.vistaPermisosArbol.TabIndex = 27;
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.AutoSize = true;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(40, 30);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Name = "LABEL_NOMBRE_ABM_USUARIO490WC";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Size = new System.Drawing.Size(77, 20);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TabIndex = 28;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(40, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(430, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(833, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre";
            // 
            // FormPermisos490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1045, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LABEL_NOMBRE_ABM_USUARIO490WC);
            this.Controls.Add(this.vistaPermisosArbol);
            this.Controls.Add(this.listaPermisos490WC);
            this.Controls.Add(this.TB_NuevoNombre);
            this.Controls.Add(this.BT_GuardarCambios);
            this.Controls.Add(this.BT_CrearGrupoDePermisos);
            this.Controls.Add(this.BT_CrearRol);
            this.Controls.Add(this.BT_ModificarNombre);
            this.Controls.Add(this.BT_ElimiarSeleccionado);
            this.Controls.Add(this.CB_Familias);
            this.Name = "FormPermisos490WC";
            this.Text = "FormPermisos490WC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Familias;
        private System.Windows.Forms.Button BT_ElimiarSeleccionado;
        private System.Windows.Forms.Button BT_ModificarNombre;
        private System.Windows.Forms.Button BT_CrearRol;
        private System.Windows.Forms.Button BT_CrearGrupoDePermisos;
        private System.Windows.Forms.Button BT_GuardarCambios;
        private System.Windows.Forms.TextBox TB_NuevoNombre;
        private System.Windows.Forms.CheckedListBox listaPermisos490WC;
        private System.Windows.Forms.TreeView vistaPermisosArbol;
        private System.Windows.Forms.Label LABEL_NOMBRE_ABM_USUARIO490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}