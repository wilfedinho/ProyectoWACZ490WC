namespace GUI490WC
{
    partial class FormBackUp490WC
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
            this.TB_RUTABACKUP490WC = new System.Windows.Forms.TextBox();
            this.BT_BUSCARBACKUP490WC = new FontAwesome.Sharp.IconButton();
            this.BT_EJECUTARBACKUP490WC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_RUTABACKUP490WC
            // 
            this.TB_RUTABACKUP490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.TB_RUTABACKUP490WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_RUTABACKUP490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.TB_RUTABACKUP490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.TB_RUTABACKUP490WC.Location = new System.Drawing.Point(44, 89);
            this.TB_RUTABACKUP490WC.Name = "TB_RUTABACKUP490WC";
            this.TB_RUTABACKUP490WC.ReadOnly = true;
            this.TB_RUTABACKUP490WC.Size = new System.Drawing.Size(418, 27);
            this.TB_RUTABACKUP490WC.TabIndex = 16;
            // 
            // BT_BUSCARBACKUP490WC
            // 
            this.BT_BUSCARBACKUP490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_BUSCARBACKUP490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BUSCARBACKUP490WC.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.BT_BUSCARBACKUP490WC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_BUSCARBACKUP490WC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_BUSCARBACKUP490WC.IconSize = 100;
            this.BT_BUSCARBACKUP490WC.Location = new System.Drawing.Point(491, 49);
            this.BT_BUSCARBACKUP490WC.Name = "BT_BUSCARBACKUP490WC";
            this.BT_BUSCARBACKUP490WC.Size = new System.Drawing.Size(125, 104);
            this.BT_BUSCARBACKUP490WC.TabIndex = 20;
            this.BT_BUSCARBACKUP490WC.UseVisualStyleBackColor = false;
            this.BT_BUSCARBACKUP490WC.Click += new System.EventHandler(this.BT_BUSCARBACKUP490WC_Click);
            // 
            // BT_EJECUTARBACKUP490WC
            // 
            this.BT_EJECUTARBACKUP490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_EJECUTARBACKUP490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_EJECUTARBACKUP490WC.Font = new System.Drawing.Font("Roboto", 11.87629F, System.Drawing.FontStyle.Bold);
            this.BT_EJECUTARBACKUP490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_EJECUTARBACKUP490WC.Location = new System.Drawing.Point(639, 49);
            this.BT_EJECUTARBACKUP490WC.Name = "BT_EJECUTARBACKUP490WC";
            this.BT_EJECUTARBACKUP490WC.Size = new System.Drawing.Size(125, 104);
            this.BT_EJECUTARBACKUP490WC.TabIndex = 21;
            this.BT_EJECUTARBACKUP490WC.Text = "Ejecutar Back Up";
            this.BT_EJECUTARBACKUP490WC.UseVisualStyleBackColor = false;
            this.BT_EJECUTARBACKUP490WC.Click += new System.EventHandler(this.BT_EJECUTARBACKUP490WC_Click);
            // 
            // FormBackUp490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.BT_EJECUTARBACKUP490WC);
            this.Controls.Add(this.BT_BUSCARBACKUP490WC);
            this.Controls.Add(this.TB_RUTABACKUP490WC);
            this.Name = "FormBackUp490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBackUp490WC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBackUp490WC_FormClosed);
            this.Load += new System.EventHandler(this.FormBackUp490WC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_RUTABACKUP490WC;
        private FontAwesome.Sharp.IconButton BT_BUSCARBACKUP490WC;
        private System.Windows.Forms.Button BT_EJECUTARBACKUP490WC;
    }
}