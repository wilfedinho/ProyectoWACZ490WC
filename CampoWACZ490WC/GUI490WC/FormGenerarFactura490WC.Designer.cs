namespace GUI490WC
{
    partial class FormGenerarFactura490WC
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
            this.BT_BUSCARCLIENTE490WC = new System.Windows.Forms.Button();
            this.TBINFOCLIENTE490WC = new System.Windows.Forms.TextBox();
            this.LABEL_DATOSCLIENTE490WC = new System.Windows.Forms.Label();
            this.LABEL_DNI490WC = new System.Windows.Forms.Label();
            this.TB_DNI490WC = new System.Windows.Forms.TextBox();
            this.dgvBoleto490WC = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPartidaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaLlegadaIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPartidaVUELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaLlegadaVUELTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPesoEquipajePermitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClaseBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumeroAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_COBRARFACTURA490WC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleto490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_BUSCARCLIENTE490WC
            // 
            this.BT_BUSCARCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BUSCARCLIENTE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BUSCARCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_BUSCARCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BUSCARCLIENTE490WC.Location = new System.Drawing.Point(916, 174);
            this.BT_BUSCARCLIENTE490WC.Name = "BT_BUSCARCLIENTE490WC";
            this.BT_BUSCARCLIENTE490WC.Size = new System.Drawing.Size(178, 40);
            this.BT_BUSCARCLIENTE490WC.TabIndex = 53;
            this.BT_BUSCARCLIENTE490WC.Text = "Buscar Cliente";
            this.BT_BUSCARCLIENTE490WC.UseVisualStyleBackColor = false;
            this.BT_BUSCARCLIENTE490WC.Click += new System.EventHandler(this.BT_BUSCARCLIENTE490WC_Click);
            // 
            // TBINFOCLIENTE490WC
            // 
            this.TBINFOCLIENTE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TBINFOCLIENTE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBINFOCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TBINFOCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TBINFOCLIENTE490WC.Location = new System.Drawing.Point(834, 39);
            this.TBINFOCLIENTE490WC.Multiline = true;
            this.TBINFOCLIENTE490WC.Name = "TBINFOCLIENTE490WC";
            this.TBINFOCLIENTE490WC.ReadOnly = true;
            this.TBINFOCLIENTE490WC.Size = new System.Drawing.Size(344, 73);
            this.TBINFOCLIENTE490WC.TabIndex = 52;
            // 
            // LABEL_DATOSCLIENTE490WC
            // 
            this.LABEL_DATOSCLIENTE490WC.AutoSize = true;
            this.LABEL_DATOSCLIENTE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DATOSCLIENTE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DATOSCLIENTE490WC.Location = new System.Drawing.Point(939, 16);
            this.LABEL_DATOSCLIENTE490WC.Name = "LABEL_DATOSCLIENTE490WC";
            this.LABEL_DATOSCLIENTE490WC.Size = new System.Drawing.Size(123, 20);
            this.LABEL_DATOSCLIENTE490WC.TabIndex = 51;
            this.LABEL_DATOSCLIENTE490WC.Text = "Datos Cliente";
            // 
            // LABEL_DNI490WC
            // 
            this.LABEL_DNI490WC.AutoSize = true;
            this.LABEL_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.LABEL_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_DNI490WC.Location = new System.Drawing.Point(984, 120);
            this.LABEL_DNI490WC.Name = "LABEL_DNI490WC";
            this.LABEL_DNI490WC.Size = new System.Drawing.Size(40, 20);
            this.LABEL_DNI490WC.TabIndex = 50;
            this.LABEL_DNI490WC.Text = "DNI";
            // 
            // TB_DNI490WC
            // 
            this.TB_DNI490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_DNI490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_DNI490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_DNI490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_DNI490WC.Location = new System.Drawing.Point(916, 141);
            this.TB_DNI490WC.Name = "TB_DNI490WC";
            this.TB_DNI490WC.Size = new System.Drawing.Size(178, 27);
            this.TB_DNI490WC.TabIndex = 49;
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
            this.ColumnaPesoEquipajePermitido,
            this.ColumnaClaseBoleto,
            this.ColumnaPrecio,
            this.ColumnaNumeroAsiento,
            this.ColumnaBeneficio});
            this.dgvBoleto490WC.Location = new System.Drawing.Point(12, 39);
            this.dgvBoleto490WC.MultiSelect = false;
            this.dgvBoleto490WC.Name = "dgvBoleto490WC";
            this.dgvBoleto490WC.ReadOnly = true;
            this.dgvBoleto490WC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBoleto490WC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoleto490WC.Size = new System.Drawing.Size(816, 221);
            this.dgvBoleto490WC.TabIndex = 55;
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
            // ColumnaPesoEquipajePermitido
            // 
            this.ColumnaPesoEquipajePermitido.HeaderText = "Peso Equipaje Permitido";
            this.ColumnaPesoEquipajePermitido.Name = "ColumnaPesoEquipajePermitido";
            this.ColumnaPesoEquipajePermitido.ReadOnly = true;
            // 
            // ColumnaClaseBoleto
            // 
            this.ColumnaClaseBoleto.HeaderText = "Clase Boleto";
            this.ColumnaClaseBoleto.Name = "ColumnaClaseBoleto";
            this.ColumnaClaseBoleto.ReadOnly = true;
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
            // ColumnaBeneficio
            // 
            this.ColumnaBeneficio.HeaderText = "Beneficio Aplicado";
            this.ColumnaBeneficio.Name = "ColumnaBeneficio";
            this.ColumnaBeneficio.ReadOnly = true;
            // 
            // BT_COBRARFACTURA490WC
            // 
            this.BT_COBRARFACTURA490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_COBRARFACTURA490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_COBRARFACTURA490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_COBRARFACTURA490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_COBRARFACTURA490WC.Location = new System.Drawing.Point(916, 220);
            this.BT_COBRARFACTURA490WC.Name = "BT_COBRARFACTURA490WC";
            this.BT_COBRARFACTURA490WC.Size = new System.Drawing.Size(178, 40);
            this.BT_COBRARFACTURA490WC.TabIndex = 56;
            this.BT_COBRARFACTURA490WC.Text = "Cobrar ";
            this.BT_COBRARFACTURA490WC.UseVisualStyleBackColor = false;
            this.BT_COBRARFACTURA490WC.Click += new System.EventHandler(this.BT_COBRARFACTURA490WC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(310, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Boletos Por Pagar";
            // 
            // FormGenerarFactura490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1190, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_COBRARFACTURA490WC);
            this.Controls.Add(this.dgvBoleto490WC);
            this.Controls.Add(this.BT_BUSCARCLIENTE490WC);
            this.Controls.Add(this.TBINFOCLIENTE490WC);
            this.Controls.Add(this.LABEL_DATOSCLIENTE490WC);
            this.Controls.Add(this.LABEL_DNI490WC);
            this.Controls.Add(this.TB_DNI490WC);
            this.Name = "FormGenerarFactura490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenerarFactura490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGenerarFactura490WC_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleto490WC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_BUSCARCLIENTE490WC;
        private System.Windows.Forms.TextBox TBINFOCLIENTE490WC;
        private System.Windows.Forms.Label LABEL_DATOSCLIENTE490WC;
        private System.Windows.Forms.Label LABEL_DNI490WC;
        private System.Windows.Forms.TextBox TB_DNI490WC;
        private System.Windows.Forms.DataGridView dgvBoleto490WC;
        private System.Windows.Forms.Button BT_COBRARFACTURA490WC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPartidaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaLlegadaIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPartidaVUELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaLlegadaVUELTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPesoEquipajePermitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClaseBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumeroAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBeneficio;
    }
}