namespace GUI490WC
{
    partial class FormReportesInteligentes490WC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LABEL_NOMBRE_ABM_USUARIO490WC = new System.Windows.Forms.Label();
            this.VisualizadorReporte490WC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BT_ImprimirReporte490WC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizadorReporte490WC)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_NOMBRE_ABM_USUARIO490WC
            // 
            this.LABEL_NOMBRE_ABM_USUARIO490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Font = new System.Drawing.Font("Roboto", 22.26804F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Location = new System.Drawing.Point(-28, 5);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Name = "LABEL_NOMBRE_ABM_USUARIO490WC";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Size = new System.Drawing.Size(894, 92);
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TabIndex = 25;
            this.LABEL_NOMBRE_ABM_USUARIO490WC.Text = "Reporte Inteligente Beneficios Canjeados En Base A Los Boletos Vendidos Cuatrimes" +
    "tral";
            this.LABEL_NOMBRE_ABM_USUARIO490WC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisualizadorReporte490WC
            // 
            chartArea1.Name = "ChartArea1";
            this.VisualizadorReporte490WC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.VisualizadorReporte490WC.Legends.Add(legend1);
            this.VisualizadorReporte490WC.Location = new System.Drawing.Point(12, 100);
            this.VisualizadorReporte490WC.Name = "VisualizadorReporte490WC";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.VisualizadorReporte490WC.Series.Add(series1);
            this.VisualizadorReporte490WC.Size = new System.Drawing.Size(1156, 458);
            this.VisualizadorReporte490WC.TabIndex = 26;
            this.VisualizadorReporte490WC.Text = "chart1";
            // 
            // BT_ImprimirReporte490WC
            // 
            this.BT_ImprimirReporte490WC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(13)))));
            this.BT_ImprimirReporte490WC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ImprimirReporte490WC.Font = new System.Drawing.Font("Roboto", 28.20619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ImprimirReporte490WC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.BT_ImprimirReporte490WC.Location = new System.Drawing.Point(905, 15);
            this.BT_ImprimirReporte490WC.Name = "BT_ImprimirReporte490WC";
            this.BT_ImprimirReporte490WC.Size = new System.Drawing.Size(263, 69);
            this.BT_ImprimirReporte490WC.TabIndex = 30;
            this.BT_ImprimirReporte490WC.Text = "Imprimir";
            this.BT_ImprimirReporte490WC.UseVisualStyleBackColor = false;
            this.BT_ImprimirReporte490WC.Click += new System.EventHandler(this.BT_ImprimirReporte490WC_Click);
            // 
            // FormReportesInteligentes490WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1178, 563);
            this.Controls.Add(this.BT_ImprimirReporte490WC);
            this.Controls.Add(this.VisualizadorReporte490WC);
            this.Controls.Add(this.LABEL_NOMBRE_ABM_USUARIO490WC);
            this.Name = "FormReportesInteligentes490WC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportesInteligentes490WC";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizadorReporte490WC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LABEL_NOMBRE_ABM_USUARIO490WC;
        private System.Windows.Forms.DataVisualization.Charting.Chart VisualizadorReporte490WC;
        private System.Windows.Forms.Button BT_ImprimirReporte490WC;
    }
}