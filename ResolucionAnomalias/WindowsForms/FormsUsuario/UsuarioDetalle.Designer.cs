namespace WindowsForms.FormsUsuario
{
    partial class UsuarioDetalle
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
            components = new System.ComponentModel.Container();
            idLabel = new Label();
            nombreLabel = new Label();
            emailLabel = new Label();
            contraseniaLabel = new Label();
            tipoLabel = new Label();
            localidadLabel = new Label();
            zonaLabel = new Label();
            idTextBox = new TextBox();
            nombreTextBox = new TextBox();
            emailTextBox = new TextBox();
            contraseniaTextBox = new TextBox();
            tipoComboBox = new ComboBox();
            localidadComboBox = new ComboBox();
            zonaComboBox = new ComboBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(49, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(49, 70);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(54, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(49, 106);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new Point(49, 140);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(70, 15);
            contraseniaLabel.TabIndex = 3;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new Point(49, 181);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(34, 15);
            tipoLabel.TabIndex = 4;
            tipoLabel.Text = "Tipo:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new Point(49, 220);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(61, 15);
            localidadLabel.TabIndex = 5;
            localidadLabel.Text = "Localidad:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new Point(49, 259);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new Size(37, 15);
            zonaLabel.TabIndex = 6;
            zonaLabel.Text = "Zona:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(154, 28);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(154, 62);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(178, 23);
            nombreTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(154, 98);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(178, 23);
            emailTextBox.TabIndex = 9;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(154, 132);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(178, 23);
            contraseniaTextBox.TabIndex = 10;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(154, 173);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(178, 23);
            tipoComboBox.TabIndex = 11;
            // 
            // localidadComboBox
            // 
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(154, 212);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(178, 23);
            localidadComboBox.TabIndex = 12;
            // 
            // zonaComboBox
            // 
            zonaComboBox.FormattingEnabled = true;
            zonaComboBox.Location = new Point(154, 251);
            zonaComboBox.Name = "zonaComboBox";
            zonaComboBox.Size = new Size(178, 23);
            zonaComboBox.TabIndex = 13;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(303, 299);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 14;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(134, 298);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 15;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // UsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(zonaComboBox);
            Controls.Add(localidadComboBox);
            Controls.Add(tipoComboBox);
            Controls.Add(contraseniaTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(idTextBox);
            Controls.Add(zonaLabel);
            Controls.Add(localidadLabel);
            Controls.Add(tipoLabel);
            Controls.Add(contraseniaLabel);
            Controls.Add(emailLabel);
            Controls.Add(nombreLabel);
            Controls.Add(idLabel);
            Name = "UsuarioDetalle";
            Text = "UsuarioDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label nombreLabel;
        private Label emailLabel;
        private Label contraseniaLabel;
        private Label tipoLabel;
        private Label localidadLabel;
        private Label zonaLabel;
        private TextBox idTextBox;
        private TextBox nombreTextBox;
        private TextBox emailTextBox;
        private TextBox contraseniaTextBox;
        private ComboBox tipoComboBox;
        private ComboBox localidadComboBox;
        private ComboBox zonaComboBox;
        private Button aceptarButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider;
    }
}