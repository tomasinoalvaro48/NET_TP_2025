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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelTitle = new Panel();
            panelLogin = new Panel();
            panelRegister = new Panel();
            labelOr = new Label();
            panelFooter = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelTitle.SuspendLayout();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginButton.Font = new Font("Segoe UI", 10F);
            loginButton.Location = new Point(610, 200);
            loginButton.Margin = new Padding(5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(244, 56);
            loginButton.TabIndex = 0;
            loginButton.Text = "Iniciar Sesión";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usuarioTextBox.Font = new Font("Segoe UI", 10F);
            usuarioTextBox.Location = new Point(276, 51);
            usuarioTextBox.Margin = new Padding(5);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(575, 43);
            usuarioTextBox.TabIndex = 1;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contraseniaTextBox.Font = new Font("Segoe UI", 10F);
            contraseniaTextBox.Location = new Point(276, 123);
            contraseniaTextBox.Margin = new Padding(5);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(575, 43);
            contraseniaTextBox.TabIndex = 2;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // textBoxUsuarioLabel
            // 
            textBoxUsuarioLabel.AutoSize = true;
            textBoxUsuarioLabel.Font = new Font("Segoe UI", 10F);
            textBoxUsuarioLabel.Location = new Point(162, 56);
            textBoxUsuarioLabel.Margin = new Padding(5, 0, 5, 0);
            textBoxUsuarioLabel.Name = "textBoxUsuarioLabel";
            textBoxUsuarioLabel.Size = new Size(75, 37);
            textBoxUsuarioLabel.TabIndex = 3;
            textBoxUsuarioLabel.Text = "Mail:";
            // 
            // textBoxContraseniaLabel
            // 
            textBoxContraseniaLabel.AutoSize = true;
            textBoxContraseniaLabel.Font = new Font("Segoe UI", 10F);
            textBoxContraseniaLabel.Location = new Point(91, 128);
            textBoxContraseniaLabel.Margin = new Padding(5, 0, 5, 0);
            textBoxContraseniaLabel.Name = "textBoxContraseniaLabel";
            textBoxContraseniaLabel.Size = new Size(157, 37);
            textBoxContraseniaLabel.TabIndex = 4;
            textBoxContraseniaLabel.Text = "Contraseña:";
            // 
            // tituloLabel
            // 
            tituloLabel.Dock = DockStyle.Fill;
            tituloLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLabel.Location = new Point(16, 16);
            tituloLabel.Margin = new Padding(5, 0, 5, 0);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(869, 64);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Sistema de Resolución de Anomalías";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // signinCazadorButton
            // 
            signinCazadorButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signinCazadorButton.Font = new Font("Segoe UI", 9F);
            signinCazadorButton.Location = new Point(480, 88);
            signinCazadorButton.Margin = new Padding(5);
            signinCazadorButton.Name = "signinCazadorButton";
            signinCazadorButton.Size = new Size(358, 64);
            signinCazadorButton.TabIndex = 6;
            signinCazadorButton.Text = "Registrarse como cazador";
            signinCazadorButton.UseVisualStyleBackColor = true;
            signinCazadorButton.Click += signinCazadorButton_Click;
            // 
            // signinDenuncianteButton
            // 
            signinDenuncianteButton.Font = new Font("Segoe UI", 9F);
            signinDenuncianteButton.Location = new Point(65, 88);
            signinDenuncianteButton.Margin = new Padding(5);
            signinDenuncianteButton.Name = "signinDenuncianteButton";
            signinDenuncianteButton.Size = new Size(358, 64);
            signinDenuncianteButton.TabIndex = 7;
            signinDenuncianteButton.Text = "Registrarse como denunciante";
            signinDenuncianteButton.UseVisualStyleBackColor = true;
            signinDenuncianteButton.Click += signinDenuncianteButton_Click;
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseProgramButton.Font = new Font("Segoe UI", 9F);
            CloseProgramButton.Location = new Point(674, 21);
            CloseProgramButton.Margin = new Padding(5);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(211, 48);
            CloseProgramButton.TabIndex = 8;
            CloseProgramButton.Text = "Cerrar programa";
            CloseProgramButton.UseVisualStyleBackColor = true;
            CloseProgramButton.Click += CloseProgram_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelLogin, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelRegister, 0, 2);
            tableLayoutPanelMain.Controls.Add(panelFooter, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(32, 32);
            tableLayoutPanelMain.Margin = new Padding(5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(911, 704);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(tituloLabel);
            panelTitle.Dock = DockStyle.Fill;
            panelTitle.Location = new Point(5, 5);
            panelTitle.Margin = new Padding(5);
            panelTitle.Name = "panelTitle";
            panelTitle.Padding = new Padding(16);
            panelTitle.Size = new Size(901, 96);
            panelTitle.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(textBoxUsuarioLabel);
            panelLogin.Controls.Add(usuarioTextBox);
            panelLogin.Controls.Add(textBoxContraseniaLabel);
            panelLogin.Controls.Add(contraseniaTextBox);
            panelLogin.Controls.Add(loginButton);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(5, 111);
            panelLogin.Margin = new Padding(5);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(32);
            panelLogin.Size = new Size(901, 287);
            panelLogin.TabIndex = 1;
            // 
            // panelRegister
            // 
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(labelOr);
            panelRegister.Controls.Add(signinDenuncianteButton);
            panelRegister.Controls.Add(signinCazadorButton);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(5, 408);
            panelRegister.Margin = new Padding(5);
            panelRegister.Name = "panelRegister";
            panelRegister.Padding = new Padding(32);
            panelRegister.Size = new Size(901, 191);
            panelRegister.TabIndex = 2;
            // 
            // labelOr
            // 
            labelOr.Dock = DockStyle.Top;
            labelOr.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelOr.ForeColor = SystemColors.GrayText;
            labelOr.Location = new Point(32, 32);
            labelOr.Margin = new Padding(5, 0, 5, 0);
            labelOr.Name = "labelOr";
            labelOr.Size = new Size(835, 40);
            labelOr.TabIndex = 8;
            labelOr.Text = "¿No tienes cuenta? Regístrate:";
            labelOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(CloseProgramButton);
            panelFooter.Dock = DockStyle.Fill;
            panelFooter.Location = new Point(5, 609);
            panelFooter.Margin = new Padding(5);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(16);
            panelFooter.Size = new Size(901, 90);
            panelFooter.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 768);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5);
            MinimumSize = new Size(796, 677);
            Name = "LoginForm";
            Padding = new Padding(32);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resolución de Anomalías - Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelTitle;
        private Panel panelLogin;
        private Panel panelRegister;
        private Panel panelFooter;
        private Label labelOr;
    }
}