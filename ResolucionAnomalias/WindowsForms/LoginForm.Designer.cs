namespace WindowsForms
{
    partial class LoginForm
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
            loginButton = new Button();
            usuarioTextBox = new TextBox();
            contraseniaTextBox = new TextBox();
            textBoxUsuarioLabel = new Label();
            textBoxContraseniaLabel = new Label();
            tituloLabel = new Label();
            errorProvider = new ErrorProvider(components);
            signinCazadorButton = new Button();
            signinDenuncianteButton = new Button();
            CloseProgramButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(212, 159);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 22);
            loginButton.TabIndex = 0;
            loginButton.Text = "Iniciar Sesión";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(179, 66);
            usuarioTextBox.Margin = new Padding(2, 1, 2, 1);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(195, 23);
            usuarioTextBox.TabIndex = 1;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(179, 114);
            contraseniaTextBox.Margin = new Padding(2, 1, 2, 1);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(195, 23);
            contraseniaTextBox.TabIndex = 2;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // textBoxUsuarioLabel
            // 
            textBoxUsuarioLabel.AutoSize = true;
            textBoxUsuarioLabel.Location = new Point(127, 74);
            textBoxUsuarioLabel.Margin = new Padding(2, 0, 2, 0);
            textBoxUsuarioLabel.Name = "textBoxUsuarioLabel";
            textBoxUsuarioLabel.Size = new Size(33, 15);
            textBoxUsuarioLabel.TabIndex = 3;
            textBoxUsuarioLabel.Text = "Mail:";
            // 
            // textBoxContraseniaLabel
            // 
            textBoxContraseniaLabel.AutoSize = true;
            textBoxContraseniaLabel.Location = new Point(90, 122);
            textBoxContraseniaLabel.Margin = new Padding(2, 0, 2, 0);
            textBoxContraseniaLabel.Name = "textBoxContraseniaLabel";
            textBoxContraseniaLabel.Size = new Size(70, 15);
            textBoxContraseniaLabel.TabIndex = 4;
            textBoxContraseniaLabel.Text = "Contraseña:";
            // 
            // tituloLabel
            // 
            tituloLabel.Anchor = AnchorStyles.Top;
            tituloLabel.BorderStyle = BorderStyle.FixedSingle;
            tituloLabel.Location = new Point(159, 19);
            tituloLabel.Margin = new Padding(2, 0, 2, 0);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(168, 17);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Iniciar Sesión";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // signinCazadorButton
            // 
            signinCazadorButton.Location = new Point(255, 232);
            signinCazadorButton.Margin = new Padding(2, 1, 2, 1);
            signinCazadorButton.Name = "signinCazadorButton";
            signinCazadorButton.Size = new Size(190, 36);
            signinCazadorButton.TabIndex = 6;
            signinCazadorButton.Text = "Registrarse como cazador";
            signinCazadorButton.UseVisualStyleBackColor = true;
            signinCazadorButton.Click += signinCazadorButton_Click;
            // 
            // signinDenuncianteButton
            // 
            signinDenuncianteButton.Location = new Point(22, 232);
            signinDenuncianteButton.Name = "signinDenuncianteButton";
            signinDenuncianteButton.Size = new Size(194, 36);
            signinDenuncianteButton.TabIndex = 7;
            signinDenuncianteButton.Text = "Registrarse como denunciante";
            signinDenuncianteButton.UseVisualStyleBackColor = true;
            signinDenuncianteButton.Click += signinDenuncianteButton_Click;
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.Location = new Point(372, 289);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(143, 23);
            CloseProgramButton.TabIndex = 8;
            CloseProgramButton.Text = "Cerrar programa";
            CloseProgramButton.UseVisualStyleBackColor = true;
            CloseProgramButton.Click += CloseProgram_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 324);
            Controls.Add(CloseProgramButton);
            Controls.Add(signinDenuncianteButton);
            Controls.Add(signinCazadorButton);
            Controls.Add(tituloLabel);
            Controls.Add(textBoxContraseniaLabel);
            Controls.Add(textBoxUsuarioLabel);
            Controls.Add(contraseniaTextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(loginButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginForm";
            Text = "Resolución de Anomalías - Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox usuarioTextBox;
        private TextBox contraseniaTextBox;
        private Label textBoxUsuarioLabel;
        private Label textBoxContraseniaLabel;
        private Label tituloLabel;
        private ErrorProvider errorProvider;
        private Button signinCazadorButton;
        private Button signinDenuncianteButton;
        private Button CloseProgramButton;
    }
}