namespace Tp_compañia_de_seguros
{
    partial class Estadisticas
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
            this.EstadisticasLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewMedidas = new System.Windows.Forms.ListView();
            this.listViewRiesgos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EstadisticasLabel
            // 
            this.EstadisticasLabel.AutoSize = true;
            this.EstadisticasLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadisticasLabel.Location = new System.Drawing.Point(194, 34);
            this.EstadisticasLabel.Name = "EstadisticasLabel";
            this.EstadisticasLabel.Size = new System.Drawing.Size(129, 25);
            this.EstadisticasLabel.TabIndex = 0;
            this.EstadisticasLabel.Text = "Estadisticas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de seguros con medidas de seguridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de seguros con riesgos contratados";
            // 
            // listViewMedidas
            // 
            this.listViewMedidas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewMedidas.FullRowSelect = true;
            this.listViewMedidas.Location = new System.Drawing.Point(61, 121);
            this.listViewMedidas.Name = "listViewMedidas";
            this.listViewMedidas.Size = new System.Drawing.Size(394, 167);
            this.listViewMedidas.TabIndex = 5;
            this.listViewMedidas.UseCompatibleStateImageBehavior = false;
            // 
            // listViewRiesgos
            // 
            this.listViewRiesgos.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewRiesgos.Location = new System.Drawing.Point(61, 350);
            this.listViewRiesgos.Name = "listViewRiesgos";
            this.listViewRiesgos.Size = new System.Drawing.Size(394, 126);
            this.listViewRiesgos.TabIndex = 6;
            this.listViewRiesgos.UseCompatibleStateImageBehavior = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 531);
            this.Controls.Add(this.listViewRiesgos);
            this.Controls.Add(this.listViewMedidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstadisticasLabel);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EstadisticasLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewMedidas;
        private System.Windows.Forms.ListView listViewRiesgos;
    }
}