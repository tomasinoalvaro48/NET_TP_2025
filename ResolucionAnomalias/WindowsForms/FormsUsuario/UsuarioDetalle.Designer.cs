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
            idLabel.Location = new Point(91, 77);
            idLabel.Margin = new Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(42, 32);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(91, 149);
            nombreLabel.Margin = new Padding(6, 0, 6, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(107, 32);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(91, 226);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(76, 32);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new Point(91, 299);
            contraseniaLabel.Margin = new Padding(6, 0, 6, 0);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(139, 32);
            contraseniaLabel.TabIndex = 3;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new Point(91, 386);
            tipoLabel.Margin = new Padding(6, 0, 6, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(66, 32);
            tipoLabel.TabIndex = 4;
            tipoLabel.Text = "Tipo:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new Point(91, 469);
            localidadLabel.Margin = new Padding(6, 0, 6, 0);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(119, 32);
            localidadLabel.TabIndex = 5;
            localidadLabel.Text = "Localidad:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new Point(91, 553);
            zonaLabel.Margin = new Padding(6, 0, 6, 0);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new Size(73, 32);
            zonaLabel.TabIndex = 6;
            zonaLabel.Text = "Zona:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(286, 60);
            idTextBox.Margin = new Padding(6, 6, 6, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(182, 39);
            idTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(286, 132);
            nombreTextBox.Margin = new Padding(6, 6, 6, 6);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(327, 39);
            nombreTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(286, 209);
            emailTextBox.Margin = new Padding(6, 6, 6, 6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(327, 39);
            emailTextBox.TabIndex = 9;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(286, 282);
            contraseniaTextBox.Margin = new Padding(6, 6, 6, 6);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(327, 39);
            contraseniaTextBox.TabIndex = 10;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(286, 369);
            tipoComboBox.Margin = new Padding(6, 6, 6, 6);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(327, 40);
            tipoComboBox.TabIndex = 11;
            // 
            // localidadComboBox
            // 
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(286, 452);
            localidadComboBox.Margin = new Padding(6, 6, 6, 6);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(327, 40);
            localidadComboBox.TabIndex = 12;
            // 
            // zonaComboBox
            // 
            zonaComboBox.FormattingEnabled = true;
            zonaComboBox.Location = new Point(286, 535);
            zonaComboBox.Margin = new Padding(6, 6, 6, 6);
            zonaComboBox.Name = "zonaComboBox";
            zonaComboBox.Size = new Size(327, 40);
            zonaComboBox.TabIndex = 13;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(563, 638);
            aceptarButton.Margin = new Padding(6, 6, 6, 6);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(139, 49);
            aceptarButton.TabIndex = 14;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(249, 636);
            cancelarButton.Margin = new Padding(6, 6, 6, 6);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(139, 49);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
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
            Margin = new Padding(6, 6, 6, 6);
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