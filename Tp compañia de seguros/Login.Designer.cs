namespace Tp_compañia_de_seguros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(147, 76);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(144, 25);
            this.UsuarioTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(147, 119);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(144, 25);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UsuarioLabel.Location = new System.Drawing.Point(81, 79);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(59, 17);
            this.UsuarioLabel.TabIndex = 2;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLabel.Location = new System.Drawing.Point(59, 122);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Contraseña:";
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonIngresar.Location = new System.Drawing.Point(147, 161);
            this.BotonIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(146, 30);
            this.BotonIngresar.TabIndex = 4;
            this.BotonIngresar.Text = "Ingresar";
            this.BotonIngresar.UseVisualStyleBackColor = true;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(365, 268);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button BotonIngresar;
    }
}