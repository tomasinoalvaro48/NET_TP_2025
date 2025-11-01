namespace WindowsForms
{
    partial class SigninCazadorForm
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
            confirmarContraseniaTextBox = new TextBox();
            confirmarContraseniaLabel = new Label();
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
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelarButton.Font = new Font("Segoe UI", 10F);
            cancelarButton.Location = new Point(620, 21);
            cancelarButton.Margin = new Padding(5, 5, 5, 5);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(162, 64);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // registrarseButton
            // 
            registrarseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            registrarseButton.Font = new Font("Segoe UI", 10F);
            registrarseButton.Location = new Point(793, 21);
            registrarseButton.Margin = new Padding(5, 5, 5, 5);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(179, 64);
            registrarseButton.TabIndex = 26;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            registrarseButton.Click += registrarseButon_Click;
            // 
            // zonaComboBox
            // 
            zonaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zonaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            zonaComboBox.Enabled = false;
            zonaComboBox.Font = new Font("Segoe UI", 10F);
            zonaComboBox.ForeColor = Color.Black;
            zonaComboBox.FormattingEnabled = true;
            zonaComboBox.Location = new Point(346, 413);
            zonaComboBox.Margin = new Padding(5, 5, 5, 5);
            zonaComboBox.Name = "zonaComboBox";
            zonaComboBox.Size = new Size(590, 45);
            zonaComboBox.TabIndex = 25;
            // 
            // localidadComboBox
            // 
            localidadComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            localidadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            localidadComboBox.Font = new Font("Segoe UI", 10F);
            localidadComboBox.ForeColor = Color.Black;
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(346, 341);
            localidadComboBox.Margin = new Padding(5, 5, 5, 5);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(590, 45);
            localidadComboBox.TabIndex = 24;
            localidadComboBox.SelectedIndexChanged += localidadSeleccionada;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contraseniaTextBox.Font = new Font("Segoe UI", 10F);
            contraseniaTextBox.Location = new Point(346, 197);
            contraseniaTextBox.Margin = new Padding(5, 5, 5, 5);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(590, 43);
            contraseniaTextBox.TabIndex = 23;
            contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.Location = new Point(346, 125);
            emailTextBox.Margin = new Padding(5, 5, 5, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(590, 43);
            emailTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nombreTextBox.Font = new Font("Segoe UI", 10F);
            nombreTextBox.Location = new Point(346, 53);
            nombreTextBox.Margin = new Padding(5, 5, 5, 5);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(590, 43);
            nombreTextBox.TabIndex = 21;
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Font = new Font("Segoe UI", 10F);
            zonaLabel.Location = new Point(65, 416);
            zonaLabel.Margin = new Padding(5, 0, 5, 0);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new Size(83, 37);
            zonaLabel.TabIndex = 20;
            zonaLabel.Text = "Zona:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Font = new Font("Segoe UI", 10F);
            localidadLabel.Location = new Point(65, 344);
            localidadLabel.Margin = new Padding(5, 0, 5, 0);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(138, 37);
            localidadLabel.TabIndex = 19;
            localidadLabel.Text = "Localidad:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Font = new Font("Segoe UI", 10F);
            contraseniaLabel.Location = new Point(65, 200);
            contraseniaLabel.Margin = new Padding(5, 0, 5, 0);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new Size(157, 37);
            contraseniaLabel.TabIndex = 18;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F);
            emailLabel.Location = new Point(65, 128);
            emailLabel.Margin = new Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(88, 37);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 10F);
            nombreLabel.Location = new Point(65, 56);
            nombreLabel.Margin = new Padding(5, 0, 5, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(121, 37);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // tituloLabel
            // 
            tituloLabel.Dock = DockStyle.Fill;
            tituloLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tituloLabel.Location = new Point(16, 16);
            tituloLabel.Margin = new Padding(5, 0, 5, 0);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(955, 48);
            tituloLabel.TabIndex = 28;
            tituloLabel.Text = "Registro de Cazador";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // confirmarContraseniaTextBox
            // 
            confirmarContraseniaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmarContraseniaTextBox.Font = new Font("Segoe UI", 10F);
            confirmarContraseniaTextBox.Location = new Point(346, 269);
            confirmarContraseniaTextBox.Margin = new Padding(5, 5, 5, 5);
            confirmarContraseniaTextBox.Name = "confirmarContraseniaTextBox";
            confirmarContraseniaTextBox.Size = new Size(590, 43);
            confirmarContraseniaTextBox.TabIndex = 29;
            confirmarContraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarContraseniaLabel
            // 
            confirmarContraseniaLabel.AutoSize = true;
            confirmarContraseniaLabel.Font = new Font("Segoe UI", 10F);
            confirmarContraseniaLabel.Location = new Point(65, 272);
            confirmarContraseniaLabel.Margin = new Padding(5, 0, 5, 0);
            confirmarContraseniaLabel.Name = "confirmarContraseniaLabel";
            confirmarContraseniaLabel.Size = new Size(282, 37);
            confirmarContraseniaLabel.TabIndex = 30;
            confirmarContraseniaLabel.Text = "Confirmar Contraseña:";
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(24, 24);
            tableLayoutPanelMain.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(997, 752);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(tituloLabel);
            panelTitle.Dock = DockStyle.Fill;
            panelTitle.Location = new Point(5, 5);
            panelTitle.Margin = new Padding(5, 5, 5, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Padding = new Padding(16, 16, 16, 16);
            panelTitle.Size = new Size(987, 80);
            panelTitle.TabIndex = 0;
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
            panelFields.Controls.Add(localidadLabel);
            panelFields.Controls.Add(localidadComboBox);
            panelFields.Controls.Add(zonaLabel);
            panelFields.Controls.Add(zonaComboBox);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(5, 95);
            panelFields.Margin = new Padding(5, 5, 5, 5);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(49, 32, 49, 32);
            panelFields.Size = new Size(987, 543);
            panelFields.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(cancelarButton);
            panelButtons.Controls.Add(registrarseButton);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 648);
            panelButtons.Margin = new Padding(5, 5, 5, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(16, 16, 16, 16);
            panelButtons.Size = new Size(987, 99);
            panelButtons.TabIndex = 2;
            // 
            // SigninCazadorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 800);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(796, 677);
            Name = "SigninCazadorForm";
            Padding = new Padding(24, 24, 24, 24);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resolución de Anomalías - Registro de Cazador";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label confirmarContraseniaLabel;
        private TextBox confirmarContraseniaTextBox;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelTitle;
        private Panel panelFields;
        private Panel panelButtons;
    }
}