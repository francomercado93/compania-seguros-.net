namespace Tp_compañia_de_seguros
{
    partial class Reporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMedidas = new System.Windows.Forms.ComboBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.comboRiesgo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMed = new System.Windows.Forms.Label();
            this.reporteDVT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDVT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte seguros de hogar";
            // 
            // comboMedidas
            // 
            this.comboMedidas.FormattingEnabled = true;
            this.comboMedidas.Location = new System.Drawing.Point(470, 92);
            this.comboMedidas.Name = "comboMedidas";
            this.comboMedidas.Size = new System.Drawing.Size(121, 21);
            this.comboMedidas.TabIndex = 1;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(175, 149);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // comboRiesgo
            // 
            this.comboRiesgo.FormattingEnabled = true;
            this.comboRiesgo.Location = new System.Drawing.Point(175, 95);
            this.comboRiesgo.Name = "comboRiesgo";
            this.comboRiesgo.Size = new System.Drawing.Size(121, 21);
            this.comboRiesgo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Riesgos contratados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medidas de seguridad:";
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(12, 185);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(72, 13);
            this.labelMed.TabIndex = 2;
            this.labelMed.Text = "Seleccionado";
            // 
            // reporteDVT
            // 
            this.reporteDVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDVT.Location = new System.Drawing.Point(85, 264);
            this.reporteDVT.Name = "reporteDVT";
            this.reporteDVT.Size = new System.Drawing.Size(598, 123);
            this.reporteDVT.TabIndex = 7;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 460);
            this.Controls.Add(this.reporteDVT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRiesgo);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.labelMed);
            this.Controls.Add(this.comboMedidas);
            this.Controls.Add(this.label1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMedidas;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ComboBox comboRiesgo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMed;
        private System.Windows.Forms.DataGridView reporteDVT;
    }
}