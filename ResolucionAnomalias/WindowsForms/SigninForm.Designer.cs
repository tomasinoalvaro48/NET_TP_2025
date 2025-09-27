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
            signinCazadorButton = new Button();
            signinDenunciantePanel = new Panel();
            SuspendLayout();
            // 
            // signinCazadorButton
            // 
            signinCazadorButton.Location = new Point(537, 392);
            signinCazadorButton.Name = "signinCazadorButton";
            signinCazadorButton.Size = new Size(251, 46);
            signinCazadorButton.TabIndex = 0;
            signinCazadorButton.Text = "Registro de Cazador";
            signinCazadorButton.UseVisualStyleBackColor = true;
            // 
            // signinDenunciantePanel
            // 
            signinDenunciantePanel.Location = new Point(22, 22);
            signinDenunciantePanel.Name = "signinDenunciantePanel";
            signinDenunciantePanel.Size = new Size(761, 361);
            signinDenunciantePanel.TabIndex = 1;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signinDenunciantePanel);
            Controls.Add(signinCazadorButton);
            Name = "SigninForm";
            Text = "Resolución de Anomalías - Registro";
            ResumeLayout(false);
        }

        #endregion

        private Button signinCazadorButton;
        private Panel signinDenunciantePanel;
    }
}