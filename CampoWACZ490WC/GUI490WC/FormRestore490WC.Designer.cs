namespace GUI490WC
{
    partial class FormRestore490WC
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
            this.TB_RESTORE490WC = new System.Windows.Forms.TextBox();
            this.BT_EJECUTARRESTORE490WC = new System.Windows.Forms.Button();
            this.BT_BUSCARRESTORE490WC = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TB_RESTORE490WC
            // 
            this.TB_RESTORE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_RESTORE490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_RESTORE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_RESTORE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_RESTORE490WC.Location = new System.Drawing.Point(28, 94);
            this.TB_RESTORE490WC.Name = "TB_RESTORE490WC";
            this.TB_RESTORE490WC.ReadOnly = true;
            this.TB_RESTORE490WC.Size = new System.Drawing.Size(418, 27);
            this.TB_RESTORE490WC.TabIndex = 15;
            // 
            // BT_EJECUTARRESTORE490WC
            // 
            this.BT_EJECUTARRESTORE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_EJECUTARRESTORE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_EJECUTARRESTORE490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_EJECUTARRESTORE490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_EJECUTARRESTORE490WC.Location = new System.Drawing.Point(610, 53);
            this.BT_EJECUTARRESTORE490WC.Name = "BT_EJECUTARRESTORE490WC";
            this.BT_EJECUTARRESTORE490WC.Size = new System.Drawing.Size(125, 104);
            this.BT_EJECUTARRESTORE490WC.TabIndex = 17;
            this.BT_EJECUTARRESTORE490WC.Text = "Ejecutar Restore";
            this.BT_EJECUTARRESTORE490WC.UseVisualStyleBackColor = false;
            this.BT_EJECUTARRESTORE490WC.Click += new System.EventHandler(this.BT_EJECUTARRESTORE490WC_Click);
            // 
            // BT_BUSCARRESTORE490WC
            // 
            this.BT_BUSCARRESTORE490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BUSCARRESTORE490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BUSCARRESTORE490WC.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.BT_BUSCARRESTORE490WC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BUSCARRESTORE490WC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_BUSCARRESTORE490WC.IconSize = 100;
            this.BT_BUSCARRESTORE490WC.Location = new System.Drawing.Point(463, 54);
            this.BT_BUSCARRESTORE490WC.Name = "BT_BUSCARRESTORE490WC";
            this.BT_BUSCARRESTORE490WC.Size = new System.Drawing.Size(125, 104);
            this.BT_BUSCARRESTORE490WC.TabIndex = 21;
            this.BT_BUSCARRESTORE490WC.UseVisualStyleBackColor = false;
            this.BT_BUSCARRESTORE490WC.Click += new System.EventHandler(this.BT_BUSCARRESTORE490WC_Click);
            // 
            // FormRestore490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 179);
            this.Controls.Add(this.BT_BUSCARRESTORE490WC);
            this.Controls.Add(this.BT_EJECUTARRESTORE490WC);
            this.Controls.Add(this.TB_RESTORE490WC);
            this.Name = "FormRestore490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRestore490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRestore490WC_FormClosed);
            this.Load += new System.EventHandler(this.FormRestore490WC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_RESTORE490WC;
        private System.Windows.Forms.Button BT_EJECUTARRESTORE490WC;
        private FontAwesome.Sharp.IconButton BT_BUSCARRESTORE490WC;
    }
}