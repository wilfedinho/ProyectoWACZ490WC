namespace GUI490WC
{
    partial class FormCambiarIdioma490WC
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
            this.CB_IdiomasDisponibles = new System.Windows.Forms.ComboBox();
            this.BT_CambiarIdioma = new System.Windows.Forms.Button();
            this.labelIdiomaActual = new System.Windows.Forms.Label();
            this.labelIdiomasDisponibles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_IdiomasDisponibles
            // 
            this.CB_IdiomasDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.CB_IdiomasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_IdiomasDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_IdiomasDisponibles.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.CB_IdiomasDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.CB_IdiomasDisponibles.FormattingEnabled = true;
            this.CB_IdiomasDisponibles.Location = new System.Drawing.Point(91, 177);
            this.CB_IdiomasDisponibles.Name = "CB_IdiomasDisponibles";
            this.CB_IdiomasDisponibles.Size = new System.Drawing.Size(292, 27);
            this.CB_IdiomasDisponibles.TabIndex = 93;
            // 
            // BT_CambiarIdioma
            // 
            this.BT_CambiarIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_CambiarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CambiarIdioma.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_CambiarIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_CambiarIdioma.Location = new System.Drawing.Point(91, 274);
            this.BT_CambiarIdioma.Name = "BT_CambiarIdioma";
            this.BT_CambiarIdioma.Size = new System.Drawing.Size(292, 47);
            this.BT_CambiarIdioma.TabIndex = 94;
            this.BT_CambiarIdioma.Text = "Modificar";
            this.BT_CambiarIdioma.UseVisualStyleBackColor = false;
            this.BT_CambiarIdioma.Click += new System.EventHandler(this.BT_CambiarIdioma_Click_1);
            // 
            // labelIdiomaActual
            // 
            this.labelIdiomaActual.AutoSize = true;
            this.labelIdiomaActual.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelIdiomaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelIdiomaActual.Location = new System.Drawing.Point(87, 58);
            this.labelIdiomaActual.Name = "labelIdiomaActual";
            this.labelIdiomaActual.Size = new System.Drawing.Size(177, 20);
            this.labelIdiomaActual.TabIndex = 95;
            this.labelIdiomaActual.Text = "Que desea Asignar?";
            // 
            // labelIdiomasDisponibles
            // 
            this.labelIdiomasDisponibles.AutoSize = true;
            this.labelIdiomasDisponibles.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.labelIdiomasDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.labelIdiomasDisponibles.Location = new System.Drawing.Point(87, 112);
            this.labelIdiomasDisponibles.Name = "labelIdiomasDisponibles";
            this.labelIdiomasDisponibles.Size = new System.Drawing.Size(177, 20);
            this.labelIdiomasDisponibles.TabIndex = 96;
            this.labelIdiomasDisponibles.Text = "Que desea Asignar?";
            // 
            // FormCambiarIdioma490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(523, 386);
            this.Controls.Add(this.labelIdiomasDisponibles);
            this.Controls.Add(this.labelIdiomaActual);
            this.Controls.Add(this.BT_CambiarIdioma);
            this.Controls.Add(this.CB_IdiomasDisponibles);
            this.Name = "FormCambiarIdioma490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCambiarIdioma490WC";
            this.Load += new System.EventHandler(this.FormCambiarIdioma490WC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_IdiomasDisponibles;
        private System.Windows.Forms.Button BT_CambiarIdioma;
        private System.Windows.Forms.Label labelIdiomaActual;
        private System.Windows.Forms.Label labelIdiomasDisponibles;
    }
}