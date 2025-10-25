namespace WindowsForms.FormsPedidoAgregacion
{
    partial class PedidoAgregacionDetalle
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
            errorProvider = new ErrorProvider(components);
            idLabel = new Label();
            descripcionLabel = new Label();
            dificultadLabel = new Label();
            estadoLabel = new Label();
            idTextBox = new TextBox();
            descripcionTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            estadoTextBox = new TextBox();
            dificultadComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(82, 46);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(82, 94);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(72, 15);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripción:";
            // 
            // dificultadLabel
            // 
            dificultadLabel.AutoSize = true;
            dificultadLabel.Location = new Point(82, 149);
            dificultadLabel.Name = "dificultadLabel";
            dificultadLabel.Size = new Size(61, 15);
            dificultadLabel.TabIndex = 2;
            dificultadLabel.Text = "Dificultad:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(82, 205);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(45, 15);
            estadoLabel.TabIndex = 3;
            estadoLabel.Text = "Estado:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(182, 46);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(182, 94);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(330, 23);
            descripcionTextBox.TabIndex = 5;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(437, 269);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 8;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(268, 269);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // estadoTextBox
            // 
            estadoTextBox.Location = new Point(182, 197);
            estadoTextBox.Name = "estadoTextBox";
            estadoTextBox.ReadOnly = true;
            estadoTextBox.Size = new Size(161, 23);
            estadoTextBox.TabIndex = 7;
            // 
            // dificultadComboBox
            // 
            dificultadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dificultadComboBox.FormattingEnabled = true;
            dificultadComboBox.Items.AddRange(new object[] { "1", "2", "3" });
            dificultadComboBox.Location = new Point(182, 149);
            dificultadComboBox.Name = "dificultadComboBox";
            dificultadComboBox.Size = new Size(121, 23);
            dificultadComboBox.TabIndex = 10;
            // 
            // PedidoAgregacionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 364);
            Controls.Add(dificultadComboBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(estadoTextBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(idTextBox);
            Controls.Add(estadoLabel);
            Controls.Add(dificultadLabel);
            Controls.Add(descripcionLabel);
            Controls.Add(idLabel);
            Name = "PedidoAgregacionDetalle";
            Text = "PedidoAgregacionDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Button aceptarButton;
        private TextBox descripcionTextBox;
        private TextBox idTextBox;
        private Label estadoLabel;
        private Label dificultadLabel;
        private Label descripcionLabel;
        private Label idLabel;
        private ComboBox dificultadComboBox;
        private TextBox estadoTextBox;
    }
}