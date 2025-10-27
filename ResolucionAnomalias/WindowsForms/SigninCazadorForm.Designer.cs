namespace WindowsForms
{
    partial class SigninCazadorForm
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
            cancelarButton = new Button();
            registrarseButton = new Button();
            zonaComboBox = new ComboBox();
            localidadComboBox = new ComboBox();
            contraseniaTextBox = new TextBox();
            emailTextBox = new TextBox();
            nombreTextBox = new TextBox();
            zonaLabel = new Label();
            localidadLabel = new Label();
            contraseniaLabel = new Label();
            emailLabel = new Label();
            nombreLabel = new Label();
            tituloLabel = new Label();
            errorProvider = new ErrorProvider(components);
            confirmarContraseniaTextBox = new TextBox();
            confirmarContraseniaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(132, 250);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // registrarseButton
            // 
            registrarseButton.Location = new Point(241, 250);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(75, 23);
            registrarseButton.TabIndex = 26;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            registrarseButton.Click += registrarseButon_Click;
            // 
            // zonaComboBox
            // 
            zonaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            zonaComboBox.Enabled = false;
            zonaComboBox.FormattingEnabled = true;
            zonaComboBox.Location = new Point(152, 217);
            zonaComboBox.Name = "zonaComboBox";
            zonaComboBox.Size = new Size(178, 23);
            zonaComboBox.TabIndex = 25;
            // 
            // localidadComboBox
            // 
            localidadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(152, 184);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(178, 23);
            localidadComboBox.TabIndex = 24;
            localidadComboBox.SelectedIndexChanged += localidadSeleccionada;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(152, 115);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(178, 23);
            contraseniaTextBox.TabIndex = 23;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(152, 81);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(178, 23);
            emailTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(152, 45);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(178, 23);
            nombreTextBox.TabIndex = 21;
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new Point(104, 217);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new Size(37, 15);
            zonaLabel.TabIndex = 20;
            zonaLabel.Text = "Zona:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new Point(80, 184);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(61, 15);
            localidadLabel.TabIndex = 19;
            localidadLabel.Text = "Localidad:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new Point(71, 116);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(70, 15);
            contraseniaLabel.TabIndex = 18;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(104, 83);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(88, 45);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(54, 15);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // tituloLabel
            // 
            tituloLabel.Anchor = AnchorStyles.Top;
            tituloLabel.AutoSize = true;
            tituloLabel.BorderStyle = BorderStyle.FixedSingle;
            tituloLabel.Location = new Point(184, 18);
            tituloLabel.Margin = new Padding(2, 0, 2, 0);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(114, 17);
            tituloLabel.TabIndex = 28;
            tituloLabel.Text = "Registro de Cazador";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // confirmarContraseniaTextBox
            // 
            confirmarContraseniaTextBox.Location = new Point(152, 150);
            confirmarContraseniaTextBox.Name = "confirmarContraseniaTextBox";
            confirmarContraseniaTextBox.Size = new Size(178, 23);
            confirmarContraseniaTextBox.TabIndex = 29;
            confirmarContraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarContraseniaLabel
            // 
            confirmarContraseniaLabel.AutoSize = true;
            confirmarContraseniaLabel.Location = new Point(16, 153);
            confirmarContraseniaLabel.Name = "confirmarContraseniaLabel";
            confirmarContraseniaLabel.Size = new Size(127, 15);
            confirmarContraseniaLabel.TabIndex = 30;
            confirmarContraseniaLabel.Text = "Confirmar Contraseña:";
            // 
            // SigninCazadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 306);
            Controls.Add(confirmarContraseniaLabel);
            Controls.Add(confirmarContraseniaTextBox);
            Controls.Add(tituloLabel);
            Controls.Add(cancelarButton);
            Controls.Add(registrarseButton);
            Controls.Add(zonaComboBox);
            Controls.Add(localidadComboBox);
            Controls.Add(contraseniaTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(zonaLabel);
            Controls.Add(localidadLabel);
            Controls.Add(contraseniaLabel);
            Controls.Add(emailLabel);
            Controls.Add(nombreLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "SigninCazadorForm";
            Text = "Resolución de Anomalías - Registro";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarButton;
        private Button registrarseButton;
        private ComboBox zonaComboBox;
        private ComboBox localidadComboBox;
        private TextBox contraseniaTextBox;
        private TextBox emailTextBox;
        private TextBox nombreTextBox;
        private Label zonaLabel;
        private Label localidadLabel;
        private Label contraseniaLabel;
        private Label emailLabel;
        private Label nombreLabel;
        private Label tituloLabel;
        private ErrorProvider errorProvider;
        private Label confirmarContraseniaLabel;
        private TextBox confirmarContraseniaTextBox;
    }
}