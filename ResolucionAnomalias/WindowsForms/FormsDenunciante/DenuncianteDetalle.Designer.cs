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
            components = new System.ComponentModel.Container();
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
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new Point(24, 15);
            codigoLabel.Margin = new Padding(2, 0, 2, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(46, 15);
            codigoLabel.TabIndex = 11;
            codigoLabel.Text = "Código";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 51);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(24, 82);
            telefonoLabel.Margin = new Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(53, 15);
            telefonoLabel.TabIndex = 5;
            telefonoLabel.Text = "Teléfono";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new Point(24, 119);
            direccionLabel.Margin = new Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(57, 15);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "Dirección";
            // 
            // codigoTextBox
            // 
            codigoTextBox.BackColor = SystemColors.Control;
            codigoTextBox.Location = new Point(131, 15);
            codigoTextBox.Margin = new Padding(2, 1, 2, 1);
            codigoTextBox.Name = "codigoTextBox";
            codigoTextBox.ReadOnly = true;
            codigoTextBox.Size = new Size(110, 23);
            codigoTextBox.TabIndex = 0;
            codigoTextBox.TabStop = false;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(131, 51);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(131, 82);
            telefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(110, 23);
            telefonoTextBox.TabIndex = 1;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(131, 119);
            direccionTextBox.Margin = new Padding(2, 1, 2, 1);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(110, 23);
            direccionTextBox.TabIndex = 8;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(239, 199);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(331, 199);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private ErrorProvider errorProvider;
    }
}
