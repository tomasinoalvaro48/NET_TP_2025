namespace WindowsForms
{
    partial class DenuncianteDetalle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            codigoLabel = new Label();
            nombreLabel = new Label();
            telefonoLabel = new Label();
            direccionLabel = new Label();
            codigoTextBox = new TextBox();
            nombreTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            direccionTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new Point(37, 39);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(46, 15);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Código";
            codigoLabel.Click += label1_Click;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(37, 68);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            nombreLabel.Click += label2_Click;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(37, 97);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(53, 15);
            telefonoLabel.TabIndex = 2;
            telefonoLabel.Text = "Teléfono";
            telefonoLabel.Click += label3_Click;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new Point(37, 130);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(57, 15);
            direccionLabel.TabIndex = 3;
            direccionLabel.Text = "Dirección";
            direccionLabel.Click += label4_Click;
            // 
            // codigoTextBox
            // 
            codigoTextBox.Location = new Point(106, 36);
            codigoTextBox.Name = "codigoTextBox";
            codigoTextBox.Size = new Size(100, 23);
            codigoTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(106, 65);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(100, 23);
            nombreTextBox.TabIndex = 6;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(106, 94);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(100, 23);
            telefonoTextBox.TabIndex = 7;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(106, 127);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(100, 23);
            direccionTextBox.TabIndex = 8;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(191, 179);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 9;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += button1_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(293, 179);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 10;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += button2_Click;
            // 
            // DenuncianteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(direccionTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(codigoTextBox);
            Controls.Add(direccionLabel);
            Controls.Add(telefonoLabel);
            Controls.Add(nombreLabel);
            Controls.Add(codigoLabel);
            Name = "DenuncianteDetalle";
            Text = "Denunciante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label codigoLabel;
        private Label nombreLabel;
        private Label telefonoLabel;
        private Label direccionLabel;
        private TextBox codigoTextBox;
        private TextBox nombreTextBox;
        private TextBox telefonoTextBox;
        private TextBox direccionTextBox;
        private Button aceptarButton;
        private Button cancelarButton;
    }
}
