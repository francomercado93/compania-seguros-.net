namespace Tp_compañia_de_seguros
{
    partial class AnularSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnularSeguro));
            this.LabelAnular = new System.Windows.Forms.Label();
            this.LabelBusqueda = new System.Windows.Forms.Label();
            this.LabelCliente = new System.Windows.Forms.Label();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.AgenteLabel = new System.Windows.Forms.Label();
            this.AgenteComboBox = new System.Windows.Forms.ComboBox();
            this.PolizaLabel = new System.Windows.Forms.Label();
            this.PolizaTextBox = new System.Windows.Forms.TextBox();
            this.LabelFechaInicio = new System.Windows.Forms.Label();
            this.InicioPicker = new System.Windows.Forms.DateTimePicker();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.FinalPicker = new System.Windows.Forms.DateTimePicker();
            this.ContratacionLabel = new System.Windows.Forms.Label();
            this.TipoSeguroLabel = new System.Windows.Forms.Label();
            this.EstadoSeguroLabel = new System.Windows.Forms.Label();
            this.ContratacionPicker = new System.Windows.Forms.DateTimePicker();
            this.TipoSegComboBox = new System.Windows.Forms.ComboBox();
            this.EstadoSegComboBox = new System.Windows.Forms.ComboBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.SegurosDataGridView = new System.Windows.Forms.DataGridView();
            this.AnularBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SegurosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAnular
            // 
            this.LabelAnular.AccessibleName = "Anular Seguros";
            this.LabelAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LabelAnular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelAnular.AutoEllipsis = true;
            this.LabelAnular.AutoSize = true;
            this.LabelAnular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAnular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAnular.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnular.Location = new System.Drawing.Point(284, 9);
            this.LabelAnular.Name = "LabelAnular";
            this.LabelAnular.Size = new System.Drawing.Size(198, 39);
            this.LabelAnular.TabIndex = 0;
            this.LabelAnular.Text = "Anular Seguros";
            this.LabelAnular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBusqueda
            // 
            this.LabelBusqueda.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.LabelBusqueda.AutoEllipsis = true;
            this.LabelBusqueda.AutoSize = true;
            this.LabelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelBusqueda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBusqueda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelBusqueda.Location = new System.Drawing.Point(110, 61);
            this.LabelBusqueda.Name = "LabelBusqueda";
            this.LabelBusqueda.Size = new System.Drawing.Size(173, 27);
            this.LabelBusqueda.TabIndex = 1;
            this.LabelBusqueda.Text = "Filtros de Búsqueda";
            this.LabelBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCliente
            // 
            this.LabelCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.LabelCliente.AutoEllipsis = true;
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCliente.ForeColor = System.Drawing.Color.IndianRed;
            this.LabelCliente.Location = new System.Drawing.Point(110, 115);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(55, 17);
            this.LabelCliente.TabIndex = 2;
            this.LabelCliente.Text = "Cliente:";
            this.LabelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.ClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClienteComboBox.DropDownWidth = 121;
            this.ClienteComboBox.Location = new System.Drawing.Point(265, 112);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(140, 25);
            this.ClienteComboBox.Sorted = true;
            this.ClienteComboBox.TabIndex = 3;
            this.ClienteComboBox.Text = "Buscar Cliente...";
            // 
            // AgenteLabel
            // 
            this.AgenteLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AgenteLabel.AutoEllipsis = true;
            this.AgenteLabel.AutoSize = true;
            this.AgenteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgenteLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.AgenteLabel.Location = new System.Drawing.Point(110, 150);
            this.AgenteLabel.Name = "AgenteLabel";
            this.AgenteLabel.Size = new System.Drawing.Size(56, 17);
            this.AgenteLabel.TabIndex = 4;
            this.AgenteLabel.Text = "Agente:";
            this.AgenteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgenteComboBox
            // 
            this.AgenteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.AgenteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AgenteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AgenteComboBox.DropDownWidth = 121;
            this.AgenteComboBox.FormattingEnabled = true;
            this.AgenteComboBox.Location = new System.Drawing.Point(265, 147);
            this.AgenteComboBox.Name = "AgenteComboBox";
            this.AgenteComboBox.Size = new System.Drawing.Size(140, 25);
            this.AgenteComboBox.Sorted = true;
            this.AgenteComboBox.TabIndex = 5;
            this.AgenteComboBox.Text = "Buscar Agente...";
            // 
            // PolizaLabel
            // 
            this.PolizaLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.PolizaLabel.AutoEllipsis = true;
            this.PolizaLabel.AutoSize = true;
            this.PolizaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolizaLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.PolizaLabel.Location = new System.Drawing.Point(110, 185);
            this.PolizaLabel.Name = "PolizaLabel";
            this.PolizaLabel.Size = new System.Drawing.Size(122, 17);
            this.PolizaLabel.TabIndex = 6;
            this.PolizaLabel.Text = "Número de Poliza:";
            this.PolizaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PolizaTextBox
            // 
            this.PolizaTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.PolizaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PolizaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PolizaTextBox.Location = new System.Drawing.Point(265, 182);
            this.PolizaTextBox.Name = "PolizaTextBox";
            this.PolizaTextBox.Size = new System.Drawing.Size(140, 25);
            this.PolizaTextBox.TabIndex = 7;
            this.PolizaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PolizaTextBox_KeyPress);
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.LabelFechaInicio.AutoEllipsis = true;
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaInicio.ForeColor = System.Drawing.Color.IndianRed;
            this.LabelFechaInicio.Location = new System.Drawing.Point(110, 220);
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(104, 17);
            this.LabelFechaInicio.TabIndex = 8;
            this.LabelFechaInicio.Text = "Fecha de Inicio:";
            this.LabelFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InicioPicker
            // 
            this.InicioPicker.CustomFormat = "yyyy-MM-dd";
            this.InicioPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InicioPicker.Location = new System.Drawing.Point(265, 217);
            this.InicioPicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.InicioPicker.Name = "InicioPicker";
            this.InicioPicker.Size = new System.Drawing.Size(140, 25);
            this.InicioPicker.TabIndex = 9;
            this.InicioPicker.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // FinalLabel
            // 
            this.FinalLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.FinalLabel.AutoEllipsis = true;
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.FinalLabel.Location = new System.Drawing.Point(410, 220);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(143, 17);
            this.FinalLabel.TabIndex = 10;
            this.FinalLabel.Text = "Fecha de Finalización:";
            this.FinalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalPicker
            // 
            this.FinalPicker.CustomFormat = "yyyy-MM-dd";
            this.FinalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FinalPicker.Location = new System.Drawing.Point(560, 217);
            this.FinalPicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.FinalPicker.Name = "FinalPicker";
            this.FinalPicker.Size = new System.Drawing.Size(140, 25);
            this.FinalPicker.TabIndex = 11;
            this.FinalPicker.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // ContratacionLabel
            // 
            this.ContratacionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ContratacionLabel.AutoEllipsis = true;
            this.ContratacionLabel.AutoSize = true;
            this.ContratacionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContratacionLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ContratacionLabel.Location = new System.Drawing.Point(110, 255);
            this.ContratacionLabel.Name = "ContratacionLabel";
            this.ContratacionLabel.Size = new System.Drawing.Size(149, 17);
            this.ContratacionLabel.TabIndex = 12;
            this.ContratacionLabel.Text = "Fecha de Contratacion:";
            this.ContratacionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipoSeguroLabel
            // 
            this.TipoSeguroLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TipoSeguroLabel.AutoEllipsis = true;
            this.TipoSeguroLabel.AutoSize = true;
            this.TipoSeguroLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSeguroLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.TipoSeguroLabel.Location = new System.Drawing.Point(110, 290);
            this.TipoSeguroLabel.Name = "TipoSeguroLabel";
            this.TipoSeguroLabel.Size = new System.Drawing.Size(106, 17);
            this.TipoSeguroLabel.TabIndex = 13;
            this.TipoSeguroLabel.Text = "Tipo de Seguro:";
            this.TipoSeguroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EstadoSeguroLabel
            // 
            this.EstadoSeguroLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.EstadoSeguroLabel.AutoEllipsis = true;
            this.EstadoSeguroLabel.AutoSize = true;
            this.EstadoSeguroLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoSeguroLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.EstadoSeguroLabel.Location = new System.Drawing.Point(110, 325);
            this.EstadoSeguroLabel.Name = "EstadoSeguroLabel";
            this.EstadoSeguroLabel.Size = new System.Drawing.Size(100, 17);
            this.EstadoSeguroLabel.TabIndex = 14;
            this.EstadoSeguroLabel.Text = "Estado Seguro:";
            this.EstadoSeguroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContratacionPicker
            // 
            this.ContratacionPicker.CustomFormat = "yyyy-MM-dd";
            this.ContratacionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ContratacionPicker.Location = new System.Drawing.Point(265, 252);
            this.ContratacionPicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.ContratacionPicker.Name = "ContratacionPicker";
            this.ContratacionPicker.Size = new System.Drawing.Size(140, 25);
            this.ContratacionPicker.TabIndex = 15;
            this.ContratacionPicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // TipoSegComboBox
            // 
            this.TipoSegComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.TipoSegComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TipoSegComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TipoSegComboBox.DropDownWidth = 121;
            this.TipoSegComboBox.FormattingEnabled = true;
            this.TipoSegComboBox.Location = new System.Drawing.Point(265, 287);
            this.TipoSegComboBox.Name = "TipoSegComboBox";
            this.TipoSegComboBox.Size = new System.Drawing.Size(140, 25);
            this.TipoSegComboBox.Sorted = true;
            this.TipoSegComboBox.TabIndex = 16;
            this.TipoSegComboBox.Text = "Seleccione Tipo...";
            // 
            // EstadoSegComboBox
            // 
            this.EstadoSegComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.EstadoSegComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EstadoSegComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EstadoSegComboBox.DropDownWidth = 121;
            this.EstadoSegComboBox.FormattingEnabled = true;
            this.EstadoSegComboBox.Location = new System.Drawing.Point(265, 322);
            this.EstadoSegComboBox.Name = "EstadoSegComboBox";
            this.EstadoSegComboBox.Size = new System.Drawing.Size(140, 25);
            this.EstadoSegComboBox.Sorted = true;
            this.EstadoSegComboBox.TabIndex = 17;
            this.EstadoSegComboBox.Text = "Seleccione Estado...";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BotonBuscar.AutoEllipsis = true;
            this.BotonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonBuscar.Location = new System.Drawing.Point(265, 357);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(140, 25);
            this.BotonBuscar.TabIndex = 18;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // SegurosDataGridView
            // 
            this.SegurosDataGridView.AllowUserToAddRows = false;
            this.SegurosDataGridView.AllowUserToDeleteRows = false;
            this.SegurosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SegurosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegurosDataGridView.Location = new System.Drawing.Point(110, 412);
            this.SegurosDataGridView.MultiSelect = false;
            this.SegurosDataGridView.Name = "SegurosDataGridView";
            this.SegurosDataGridView.RowHeadersVisible = false;
            this.SegurosDataGridView.Size = new System.Drawing.Size(590, 150);
            this.SegurosDataGridView.TabIndex = 19;
            // 
            // AnularBoton
            // 
            this.AnularBoton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AnularBoton.AutoEllipsis = true;
            this.AnularBoton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnularBoton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.AnularBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnularBoton.Location = new System.Drawing.Point(265, 575);
            this.AnularBoton.Name = "AnularBoton";
            this.AnularBoton.Size = new System.Drawing.Size(140, 25);
            this.AnularBoton.TabIndex = 20;
            this.AnularBoton.Text = "Anular";
            this.AnularBoton.UseVisualStyleBackColor = true;
            this.AnularBoton.Click += new System.EventHandler(this.AnularBoton_Click);
            // 
            // AnularSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.AnularBoton);
            this.Controls.Add(this.SegurosDataGridView);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.EstadoSegComboBox);
            this.Controls.Add(this.TipoSegComboBox);
            this.Controls.Add(this.ContratacionPicker);
            this.Controls.Add(this.EstadoSeguroLabel);
            this.Controls.Add(this.TipoSeguroLabel);
            this.Controls.Add(this.ContratacionLabel);
            this.Controls.Add(this.FinalPicker);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.InicioPicker);
            this.Controls.Add(this.LabelFechaInicio);
            this.Controls.Add(this.PolizaTextBox);
            this.Controls.Add(this.PolizaLabel);
            this.Controls.Add(this.AgenteComboBox);
            this.Controls.Add(this.AgenteLabel);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.LabelCliente);
            this.Controls.Add(this.LabelBusqueda);
            this.Controls.Add(this.LabelAnular);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnularSeguro";
            this.Text = "AnularSeguro";
            this.Load += new System.EventHandler(this.AnularSeguro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SegurosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelAnular;
        public System.Windows.Forms.Label LabelBusqueda;
        private System.Windows.Forms.Label LabelCliente;
        public System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label AgenteLabel;
        public System.Windows.Forms.ComboBox AgenteComboBox;
        private System.Windows.Forms.Label PolizaLabel;
        public System.Windows.Forms.TextBox PolizaTextBox;
        private System.Windows.Forms.Label LabelFechaInicio;
        public System.Windows.Forms.DateTimePicker InicioPicker;
        private System.Windows.Forms.Label FinalLabel;
        public System.Windows.Forms.DateTimePicker FinalPicker;
        private System.Windows.Forms.Label ContratacionLabel;
        private System.Windows.Forms.Label TipoSeguroLabel;
        private System.Windows.Forms.Label EstadoSeguroLabel;
        public System.Windows.Forms.DateTimePicker ContratacionPicker;
        public System.Windows.Forms.ComboBox TipoSegComboBox;
        public System.Windows.Forms.ComboBox EstadoSegComboBox;
        private System.Windows.Forms.Button BotonBuscar;
        public System.Windows.Forms.DataGridView SegurosDataGridView;
        private System.Windows.Forms.Button AnularBoton;
    }
}