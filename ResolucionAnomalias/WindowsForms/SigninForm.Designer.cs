namespace WindowsForms
{
    partial class SigninForm
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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(193, 452);
            cancelarButton.Margin = new Padding(6);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(139, 49);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // registrarseButton
            // 
            registrarseButton.Location = new Point(396, 452);
            registrarseButton.Margin = new Padding(6);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(139, 49);
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
            zonaComboBox.Location = new Point(230, 381);
            zonaComboBox.Margin = new Padding(6);
            zonaComboBox.Name = "zonaComboBox";
            zonaComboBox.Size = new Size(327, 40);
            zonaComboBox.TabIndex = 25;
            // 
            // localidadComboBox
            // 
            localidadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(230, 311);
            localidadComboBox.Margin = new Padding(6);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(327, 40);
            localidadComboBox.TabIndex = 24;
            localidadComboBox.SelectedIndexChanged += localidadSeleccionada;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(230, 236);
            contraseniaTextBox.Margin = new Padding(6);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(327, 39);
            contraseniaTextBox.TabIndex = 23;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(230, 165);
            emailTextBox.Margin = new Padding(6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(327, 39);
            emailTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(230, 88);
            nombreTextBox.Margin = new Padding(6);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(327, 39);
            nombreTextBox.TabIndex = 21;
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new Point(142, 382);
            zonaLabel.Margin = new Padding(6, 0, 6, 0);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new Size(73, 32);
            zonaLabel.TabIndex = 20;
            zonaLabel.Text = "Zona:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new Point(96, 311);
            localidadLabel.Margin = new Padding(6, 0, 6, 0);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(119, 32);
            localidadLabel.TabIndex = 19;
            localidadLabel.Text = "Localidad:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new Point(79, 238);
            contraseniaLabel.Margin = new Padding(6, 0, 6, 0);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(139, 32);
            contraseniaLabel.TabIndex = 18;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(142, 168);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(76, 32);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(111, 88);
            nombreLabel.Margin = new Padding(6, 0, 6, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(107, 32);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // tituloLabel
            // 
            tituloLabel.Anchor = AnchorStyles.Top;
            tituloLabel.AutoSize = true;
            tituloLabel.BorderStyle = BorderStyle.FixedSingle;
            tituloLabel.Location = new Point(247, 29);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(229, 34);
            tituloLabel.TabIndex = 28;
            tituloLabel.Text = "Registro de Cazador";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 548);
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
            Name = "SigninForm";
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
    }
}