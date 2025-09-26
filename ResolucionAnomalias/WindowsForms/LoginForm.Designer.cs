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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(329, 350);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(193, 46);
            loginButton.TabIndex = 0;
            loginButton.Text = "Iniciar Sesión";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(333, 141);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(200, 39);
            usuarioTextBox.TabIndex = 1;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(333, 244);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(200, 39);
            contraseniaTextBox.TabIndex = 2;
            // 
            // textBoxUsuarioLabel
            // 
            textBoxUsuarioLabel.AutoSize = true;
            textBoxUsuarioLabel.Location = new Point(340, 107);
            textBoxUsuarioLabel.Name = "textBoxUsuarioLabel";
            textBoxUsuarioLabel.Size = new Size(99, 32);
            textBoxUsuarioLabel.TabIndex = 3;
            textBoxUsuarioLabel.Text = "Usuario:";
            // 
            // textBoxContraseniaLabel
            // 
            textBoxContraseniaLabel.AutoSize = true;
            textBoxContraseniaLabel.Location = new Point(333, 209);
            textBoxContraseniaLabel.Name = "textBoxContraseniaLabel";
            textBoxContraseniaLabel.Size = new Size(139, 32);
            textBoxContraseniaLabel.TabIndex = 4;
            textBoxContraseniaLabel.Text = "Contraseña:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.BorderStyle = BorderStyle.FixedSingle;
            tituloLabel.Location = new Point(340, 35);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(184, 34);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Inicio de Sesión";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tituloLabel);
            Controls.Add(textBoxContraseniaLabel);
            Controls.Add(textBoxUsuarioLabel);
            Controls.Add(contraseniaTextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(loginButton);
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
    }
}