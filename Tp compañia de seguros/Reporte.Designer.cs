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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxEstado = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte seguros de hogar";
            // 
            // comboMedidas
            // 
            this.comboMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedidas.FormattingEnabled = true;
            this.comboMedidas.Location = new System.Drawing.Point(610, 81);
            this.comboMedidas.Name = "comboMedidas";
            this.comboMedidas.Size = new System.Drawing.Size(121, 21);
            this.comboMedidas.TabIndex = 1;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(407, 177);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // comboRiesgo
            // 
            this.comboRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRiesgo.FormattingEnabled = true;
            this.comboRiesgo.Location = new System.Drawing.Point(237, 81);
            this.comboRiesgo.Name = "comboRiesgo";
            this.comboRiesgo.Size = new System.Drawing.Size(121, 21);
            this.comboRiesgo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Riesgos contratados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medidas de seguridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor del inmuble";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max:";
            // 
            // checkedListBoxEstado
            // 
            this.checkedListBoxEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxEstado.FormattingEnabled = true;
            this.checkedListBoxEstado.Location = new System.Drawing.Point(124, 150);
            this.checkedListBoxEstado.MultiColumn = true;
            this.checkedListBoxEstado.Name = "checkedListBoxEstado";
            this.checkedListBoxEstado.Size = new System.Drawing.Size(627, 15);
            this.checkedListBoxEstado.TabIndex = 13;
            this.checkedListBoxEstado.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxEstado_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(44, 211);
            this.dataGridViewReporte.MinimumSize = new System.Drawing.Size(830, 240);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(830, 243);
            this.dataGridViewReporte.TabIndex = 15;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMin.Location = new System.Drawing.Point(285, 114);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMin.TabIndex = 16;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMax.Location = new System.Drawing.Point(545, 114);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 17;
            this.numericUpDownMax.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 475);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBoxEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRiesgo);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.comboMedidas);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(840, 240);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBoxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
    }
}