namespace WindowsForms
{
    partial class SigninDenuncianteForm
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
            tituloLabel = new Label();
            nombreLabel = new Label();
            emailLabel = new Label();
            contraseniaLabel = new Label();
            nombreTextBox = new TextBox();
            emailTextBox = new TextBox();
            contraseniaTextBox = new TextBox();
            registrarseButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new Point(166, 35);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(135, 15);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Registro de denunciante";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(59, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(54, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(59, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new Point(59, 181);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(70, 15);
            contraseniaLabel.TabIndex = 3;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(157, 87);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(160, 23);
            nombreTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(157, 132);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(160, 23);
            emailTextBox.TabIndex = 5;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(157, 181);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(160, 23);
            contraseniaTextBox.TabIndex = 6;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // registrarseButton
            // 
            registrarseButton.Location = new Point(242, 234);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(75, 23);
            registrarseButton.TabIndex = 7;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            registrarseButton.Click += registrarseButon_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(127, 234);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 8;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // SigninDenuncianteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 333);
            Controls.Add(cancelarButton);
            Controls.Add(registrarseButton);
            Controls.Add(contraseniaTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(contraseniaLabel);
            Controls.Add(emailLabel);
            Controls.Add(nombreLabel);
            Controls.Add(tituloLabel);
            Name = "SigninDenuncianteForm";
            Text = "SigninDenuncianteForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label nombreLabel;
        private Label emailLabel;
        private Label contraseniaLabel;
        private TextBox nombreTextBox;
        private TextBox emailTextBox;
        private TextBox contraseniaTextBox;
        private Button registrarseButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider;
    }
}