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
            confirmarContraseniaLabel = new Label();
            confirmarContraseniaTextBox = new TextBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelTitle = new Panel();
            panelFields = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelTitle.SuspendLayout();
            panelFields.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(570, 420);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(tituloLabel);
            panelTitle.Dock = DockStyle.Fill;
            panelTitle.Location = new Point(3, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Padding = new Padding(10);
            panelTitle.Size = new Size(564, 50);
            panelTitle.TabIndex = 0;
            // 
            // tituloLabel
            // 
            tituloLabel.Dock = DockStyle.Fill;
            tituloLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tituloLabel.Location = new Point(10, 10);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(544, 30);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Registro de Denunciante";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(nombreLabel);
            panelFields.Controls.Add(nombreTextBox);
            panelFields.Controls.Add(emailLabel);
            panelFields.Controls.Add(emailTextBox);
            panelFields.Controls.Add(contraseniaLabel);
            panelFields.Controls.Add(contraseniaTextBox);
            panelFields.Controls.Add(confirmarContraseniaLabel);
            panelFields.Controls.Add(confirmarContraseniaTextBox);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 59);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(30, 20, 30, 20);
            panelFields.Size = new Size(564, 290);
            panelFields.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 10F);
            nombreLabel.Location = new Point(40, 50);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(73, 23);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nombreTextBox.Font = new Font("Segoe UI", 10F);
            nombreTextBox.Location = new Point(220, 47);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(314, 30);
            nombreTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F);
            emailLabel.Location = new Point(40, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(55, 23);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.Location = new Point(220, 97);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(314, 30);
            emailTextBox.TabIndex = 5;
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Font = new Font("Segoe UI", 10F);
            contraseniaLabel.Location = new Point(40, 150);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(95, 23);
            contraseniaLabel.TabIndex = 3;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contraseniaTextBox.Font = new Font("Segoe UI", 10F);
            contraseniaTextBox.Location = new Point(220, 147);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(314, 30);
            contraseniaTextBox.TabIndex = 6;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarContraseniaLabel
            // 
            confirmarContraseniaLabel.AutoSize = true;
            confirmarContraseniaLabel.Font = new Font("Segoe UI", 10F);
            confirmarContraseniaLabel.Location = new Point(40, 200);
            confirmarContraseniaLabel.Name = "confirmarContraseniaLabel";
            confirmarContraseniaLabel.Size = new Size(158, 23);
            confirmarContraseniaLabel.TabIndex = 9;
            confirmarContraseniaLabel.Text = "Confirmar Contraseña:";
            // 
            // confirmarContraseniaTextBox
            // 
            confirmarContraseniaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmarContraseniaTextBox.Font = new Font("Segoe UI", 10F);
            confirmarContraseniaTextBox.Location = new Point(220, 197);
            confirmarContraseniaTextBox.Name = "confirmarContraseniaTextBox";
            confirmarContraseniaTextBox.Size = new Size(314, 30);
            confirmarContraseniaTextBox.TabIndex = 10;
            confirmarContraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(cancelarButton);
            panelButtons.Controls.Add(registrarseButton);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 355);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(564, 62);
            panelButtons.TabIndex = 2;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelarButton.Font = new Font("Segoe UI", 10F);
            cancelarButton.Location = new Point(338, 13);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(100, 40);
            cancelarButton.TabIndex = 8;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // registrarseButton
            // 
            registrarseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            registrarseButton.Font = new Font("Segoe UI", 10F);
            registrarseButton.Location = new Point(444, 13);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(110, 40);
            registrarseButton.TabIndex = 7;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            registrarseButton.Click += registrarseButon_Click;
            // 
            // SigninDenuncianteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            MinimumSize = new Size(500, 400);
            Controls.Add(tableLayoutPanelMain);
            Name = "SigninDenuncianteForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resolución de Anomalías - Registro de Denunciante";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox confirmarContraseniaTextBox;
        private Label confirmarContraseniaLabel;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelTitle;
        private Panel panelFields;
        private Panel panelButtons;
    }
}