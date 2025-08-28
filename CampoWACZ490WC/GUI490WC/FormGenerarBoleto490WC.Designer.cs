namespace GUI490WC
{
    partial class FormGenerarBoleto490WC
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
            this.RB_IDAVUELTA490WC = new System.Windows.Forms.RadioButton();
            this.RB_IDA490WC = new System.Windows.Forms.RadioButton();
            this.LABEL_MODALIDAD490WC = new System.Windows.Forms.Label();
            this.BT_CANCELAR490WC = new System.Windows.Forms.Button();
            this.BT_GENERARBOLETO490WC = new System.Windows.Forms.Button();
            this.LABEL_DNI490WC = new System.Windows.Forms.Label();
            this.TB_DNI490WC = new System.Windows.Forms.TextBox();
            this.TBINFOCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.LABEL_DATOSCLIENTE490WC = new System.Windows.Forms.Label();
            this.BT_BUSCARCLIENTE490WC = new System.Windows.Forms.Button();
            this.CB_BENEFICIOSCLIENTE490WC = new System.Windows.Forms.ComboBox();
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC = new System.Windows.Forms.Label();
            this.BT_APLICARBENEFICIO490WC = new System.Windows.Forms.Button();
            this.BT_CANJEARBENEFICIO490WC = new System.Windows.Forms.Button();
            this.TBINFOBOLETOGENERAR490WC = new System.Windows.Forms.TextBox();
            this.LABEL_INFOPARCIALBOLETO490WC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RB_IDAVUELTA490WC
            // 
            this.RB_IDAVUELTA490WC.AutoSize = true;
            this.RB_IDAVUELTA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RB_IDAVUELTA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RB_IDAVUELTA490WC.Location = new System.Drawing.Point(193, 32);
            this.RB_IDAVUELTA490WC.Name = "RB_IDAVUELTA490WC";
            this.RB_IDAVUELTA490WC.Size = new System.Drawing.Size(127, 24);
            this.RB_IDAVUELTA490WC.TabIndex = 41;
            this.RB_IDAVUELTA490WC.Text = "IDA VUELTA";
            this.RB_IDAVUELTA490WC.UseVisualStyleBackColor = true;
            // 
            // RB_IDA490WC
            // 
            this.RB_IDA490WC.AutoSize = true;
            this.RB_IDA490WC.Checked = true;
            this.RB_IDA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.RB_IDA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.RB_IDA490WC.Location = new System.Drawing.Point(28, 32);
            this.RB_IDA490WC.Name = "RB_IDA490WC";
            this.RB_IDA490WC.Size = new System.Drawing.Size(57, 24);
            this.RB_IDA490WC.TabIndex = 40;
            this.RB_IDA490WC.TabStop = true;
            this.RB_IDA490WC.Text = "IDA";
            this.RB_IDA490WC.UseVisualStyleBackColor = true;
            this.RB_IDA490WC.CheckedChanged += new System.EventHandler(this.RB_IDA490WC_CheckedChanged);
            // 
            // LABEL_MODALIDAD490WC
            // 
            this.LABEL_MODALIDAD490WC.AutoSize = true;
            this.LABEL_MODALIDAD490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_MODALIDAD490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_MODALIDAD490WC.Location = new System.Drawing.Point(24, 9);
            this.LABEL_MODALIDAD490WC.Name = "LABEL_MODALIDAD490WC";
            this.LABEL_MODALIDAD490WC.Size = new System.Drawing.Size(160, 20);
            this.LABEL_MODALIDAD490WC.TabIndex = 39;
            this.LABEL_MODALIDAD490WC.Text = "Modalidad Boleto";
            // 
            // BT_CANCELAR490WC
            // 
            this.BT_CANCELAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANCELAR490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANCELAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANCELAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANCELAR490WC.Location = new System.Drawing.Point(1245, 554);
            this.BT_CANCELAR490WC.Name = "BT_CANCELAR490WC";
            this.BT_CANCELAR490WC.Size = new System.Drawing.Size(169, 47);
            this.BT_CANCELAR490WC.TabIndex = 42;
            this.BT_CANCELAR490WC.Text = "Cancelar";
            this.BT_CANCELAR490WC.UseVisualStyleBackColor = false;
            this.BT_CANCELAR490WC.Click += new System.EventHandler(this.BT_CANCELAR490WC_Click);
            // 
            // BT_GENERARBOLETO490WC
            // 
            this.BT_GENERARBOLETO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_GENERARBOLETO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_GENERARBOLETO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_GENERARBOLETO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_GENERARBOLETO490WC.Location = new System.Drawing.Point(1070, 554);
            this.BT_GENERARBOLETO490WC.Name = "BT_GENERARBOLETO490WC";
            this.BT_GENERARBOLETO490WC.Size = new System.Drawing.Size(169, 47);
            this.BT_GENERARBOLETO490WC.TabIndex = 43;
            this.BT_GENERARBOLETO490WC.Text = "Generar Boleto";
            this.BT_GENERARBOLETO490WC.UseVisualStyleBackColor = false;
            this.BT_GENERARBOLETO490WC.Click += new System.EventHandler(this.BT_GENERARBOLETO490WC_Click);
            // 
            // LABEL_DNI490WC
            // 
            this.LABEL_DNI490WC.AutoSize = true;
            this.LABEL_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DNI490WC.Location = new System.Drawing.Point(1138, 9);
            this.LABEL_DNI490WC.Name = "LABEL_DNI490WC";
            this.LABEL_DNI490WC.Size = new System.Drawing.Size(40, 20);
            this.LABEL_DNI490WC.TabIndex = 45;
            this.LABEL_DNI490WC.Text = "DNI";
            // 
            // TB_DNI490WC
            // 
            this.TB_DNI490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DNI490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DNI490WC.Location = new System.Drawing.Point(1070, 32);
            this.TB_DNI490WC.Name = "TB_DNI490WC";
            this.TB_DNI490WC.Size = new System.Drawing.Size(178, 27);
            this.TB_DNI490WC.TabIndex = 44;
            // 
            // TBINFOCLIENTE490WC
            // 
            this.TBINFOCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TBINFOCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBINFOCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TBINFOCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TBINFOCLIENTE490WC.Location = new System.Drawing.Point(1070, 85);
            this.TBINFOCLIENTE490WC.Multiline = true;
            this.TBINFOCLIENTE490WC.Name = "TBINFOCLIENTE490WC";
            this.TBINFOCLIENTE490WC.ReadOnly = true;
            this.TBINFOCLIENTE490WC.Size = new System.Drawing.Size(344, 148);
            this.TBINFOCLIENTE490WC.TabIndex = 47;
            // 
            // LABEL_DATOSCLIENTE490WC
            // 
            this.LABEL_DATOSCLIENTE490WC.AutoSize = true;
            this.LABEL_DATOSCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DATOSCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DATOSCLIENTE490WC.Location = new System.Drawing.Point(1175, 62);
            this.LABEL_DATOSCLIENTE490WC.Name = "LABEL_DATOSCLIENTE490WC";
            this.LABEL_DATOSCLIENTE490WC.Size = new System.Drawing.Size(123, 20);
            this.LABEL_DATOSCLIENTE490WC.TabIndex = 46;
            this.LABEL_DATOSCLIENTE490WC.Text = "Datos Cliente";
            // 
            // BT_BUSCARCLIENTE490WC
            // 
            this.BT_BUSCARCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BUSCARCLIENTE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BUSCARCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BUSCARCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BUSCARCLIENTE490WC.Location = new System.Drawing.Point(1267, 12);
            this.BT_BUSCARCLIENTE490WC.Name = "BT_BUSCARCLIENTE490WC";
            this.BT_BUSCARCLIENTE490WC.Size = new System.Drawing.Size(147, 47);
            this.BT_BUSCARCLIENTE490WC.TabIndex = 48;
            this.BT_BUSCARCLIENTE490WC.Text = "Buscar Cliente";
            this.BT_BUSCARCLIENTE490WC.UseVisualStyleBackColor = false;
            this.BT_BUSCARCLIENTE490WC.Click += new System.EventHandler(this.BT_BUSCARCLIENTE490WC_Click);
            // 
            // CB_BENEFICIOSCLIENTE490WC
            // 
            this.CB_BENEFICIOSCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_BENEFICIOSCLIENTE490WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_BENEFICIOSCLIENTE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_BENEFICIOSCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_BENEFICIOSCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_BENEFICIOSCLIENTE490WC.FormattingEnabled = true;
            this.CB_BENEFICIOSCLIENTE490WC.Location = new System.Drawing.Point(1142, 262);
            this.CB_BENEFICIOSCLIENTE490WC.Name = "CB_BENEFICIOSCLIENTE490WC";
            this.CB_BENEFICIOSCLIENTE490WC.Size = new System.Drawing.Size(174, 27);
            this.CB_BENEFICIOSCLIENTE490WC.TabIndex = 49;
            // 
            // LABEL_DATOSBENEFICIOSCLIENTE490WC
            // 
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.AutoSize = true;
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.Location = new System.Drawing.Point(1126, 240);
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.Name = "LABEL_DATOSBENEFICIOSCLIENTE490WC";
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.Size = new System.Drawing.Size(216, 20);
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.TabIndex = 50;
            this.LABEL_DATOSBENEFICIOSCLIENTE490WC.Text = "Datos Beneficios Cliente";
            // 
            // BT_APLICARBENEFICIO490WC
            // 
            this.BT_APLICARBENEFICIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_APLICARBENEFICIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_APLICARBENEFICIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_APLICARBENEFICIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_APLICARBENEFICIO490WC.Location = new System.Drawing.Point(1070, 295);
            this.BT_APLICARBENEFICIO490WC.Name = "BT_APLICARBENEFICIO490WC";
            this.BT_APLICARBENEFICIO490WC.Size = new System.Drawing.Size(169, 37);
            this.BT_APLICARBENEFICIO490WC.TabIndex = 51;
            this.BT_APLICARBENEFICIO490WC.Text = "Aplicar Beneficio";
            this.BT_APLICARBENEFICIO490WC.UseVisualStyleBackColor = false;
            this.BT_APLICARBENEFICIO490WC.Click += new System.EventHandler(this.BT_APLICARBENEFICIO490WC_Click);
            // 
            // BT_CANJEARBENEFICIO490WC
            // 
            this.BT_CANJEARBENEFICIO490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CANJEARBENEFICIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CANJEARBENEFICIO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CANJEARBENEFICIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CANJEARBENEFICIO490WC.Location = new System.Drawing.Point(1245, 295);
            this.BT_CANJEARBENEFICIO490WC.Name = "BT_CANJEARBENEFICIO490WC";
            this.BT_CANJEARBENEFICIO490WC.Size = new System.Drawing.Size(169, 37);
            this.BT_CANJEARBENEFICIO490WC.TabIndex = 52;
            this.BT_CANJEARBENEFICIO490WC.Text = "Canjear Beneficio";
            this.BT_CANJEARBENEFICIO490WC.UseVisualStyleBackColor = false;
            this.BT_CANJEARBENEFICIO490WC.Click += new System.EventHandler(this.BT_CANJEARBENEFICIO490WC_Click);
            // 
            // TBINFOBOLETOGENERAR490WC
            // 
            this.TBINFOBOLETOGENERAR490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TBINFOBOLETOGENERAR490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBINFOBOLETOGENERAR490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TBINFOBOLETOGENERAR490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TBINFOBOLETOGENERAR490WC.Location = new System.Drawing.Point(1070, 358);
            this.TBINFOBOLETOGENERAR490WC.Multiline = true;
            this.TBINFOBOLETOGENERAR490WC.Name = "TBINFOBOLETOGENERAR490WC";
            this.TBINFOBOLETOGENERAR490WC.ReadOnly = true;
            this.TBINFOBOLETOGENERAR490WC.Size = new System.Drawing.Size(344, 190);
            this.TBINFOBOLETOGENERAR490WC.TabIndex = 53;
            // 
            // LABEL_INFOPARCIALBOLETO490WC
            // 
            this.LABEL_INFOPARCIALBOLETO490WC.AutoSize = true;
            this.LABEL_INFOPARCIALBOLETO490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_INFOPARCIALBOLETO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_INFOPARCIALBOLETO490WC.Location = new System.Drawing.Point(1175, 335);
            this.LABEL_INFOPARCIALBOLETO490WC.Name = "LABEL_INFOPARCIALBOLETO490WC";
            this.LABEL_INFOPARCIALBOLETO490WC.Size = new System.Drawing.Size(120, 20);
            this.LABEL_INFOPARCIALBOLETO490WC.TabIndex = 54;
            this.LABEL_INFOPARCIALBOLETO490WC.Text = "Datos Boleto";
            // 
            // FormGenerarBoleto490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1426, 613);
            this.Controls.Add(this.LABEL_INFOPARCIALBOLETO490WC);
            this.Controls.Add(this.TBINFOBOLETOGENERAR490WC);
            this.Controls.Add(this.BT_CANJEARBENEFICIO490WC);
            this.Controls.Add(this.BT_APLICARBENEFICIO490WC);
            this.Controls.Add(this.LABEL_DATOSBENEFICIOSCLIENTE490WC);
            this.Controls.Add(this.CB_BENEFICIOSCLIENTE490WC);
            this.Controls.Add(this.BT_BUSCARCLIENTE490WC);
            this.Controls.Add(this.TBINFOCLIENTE490WC);
            this.Controls.Add(this.LABEL_DATOSCLIENTE490WC);
            this.Controls.Add(this.LABEL_DNI490WC);
            this.Controls.Add(this.TB_DNI490WC);
            this.Controls.Add(this.BT_GENERARBOLETO490WC);
            this.Controls.Add(this.BT_CANCELAR490WC);
            this.Controls.Add(this.RB_IDAVUELTA490WC);
            this.Controls.Add(this.RB_IDA490WC);
            this.Controls.Add(this.LABEL_MODALIDAD490WC);
            this.Name = "FormGenerarBoleto490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenerarBoleto490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGenerarBoleto490WC_FormClosed);
            this.Load += new System.EventHandler(this.FormGenerarBoleto490WC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_IDAVUELTA490WC;
        private System.Windows.Forms.RadioButton RB_IDA490WC;
        private System.Windows.Forms.Label LABEL_MODALIDAD490WC;
        private System.Windows.Forms.Button BT_CANCELAR490WC;
        private System.Windows.Forms.Button BT_GENERARBOLETO490WC;
        private System.Windows.Forms.Label LABEL_DNI490WC;
        private System.Windows.Forms.TextBox TB_DNI490WC;
        private System.Windows.Forms.TextBox TBINFOCLIENTE490WC;
        private System.Windows.Forms.Label LABEL_DATOSCLIENTE490WC;
        private System.Windows.Forms.Button BT_BUSCARCLIENTE490WC;
        private System.Windows.Forms.ComboBox CB_BENEFICIOSCLIENTE490WC;
        private System.Windows.Forms.Label LABEL_DATOSBENEFICIOSCLIENTE490WC;
        private System.Windows.Forms.Button BT_APLICARBENEFICIO490WC;
        private System.Windows.Forms.Button BT_CANJEARBENEFICIO490WC;
        private System.Windows.Forms.TextBox TBINFOBOLETOGENERAR490WC;
        private System.Windows.Forms.Label LABEL_INFOPARCIALBOLETO490WC;
    }
}