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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelFields = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
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
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(570, 320);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(idLabel);
            panelFields.Controls.Add(idTextBox);
            panelFields.Controls.Add(descripcionLabel);
            panelFields.Controls.Add(descripcionTextBox);
            panelFields.Controls.Add(dificultadLabel);
            panelFields.Controls.Add(dificultadComboBox);
            panelFields.Controls.Add(estadoLabel);
            panelFields.Controls.Add(estadoTextBox);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(30, 20, 30, 20);
            panelFields.Size = new Size(564, 248);
            panelFields.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 10F);
            idLabel.Location = new Point(40, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(105, 23);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id del pedido:";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.BackColor = SystemColors.Control;
            idTextBox.Font = new Font("Segoe UI", 10F);
            idTextBox.Location = new Point(220, 37);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(314, 30);
            idTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new Font("Segoe UI", 10F);
            descripcionLabel.Location = new Point(40, 90);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(99, 23);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripción:";
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descripcionTextBox.Font = new Font("Segoe UI", 10F);
            descripcionTextBox.Location = new Point(220, 87);
            descripcionTextBox.Multiline = true;
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(314, 50);
            descripcionTextBox.TabIndex = 5;
            // 
            // dificultadLabel
            // 
            dificultadLabel.AutoSize = true;
            dificultadLabel.Font = new Font("Segoe UI", 10F);
            dificultadLabel.Location = new Point(40, 155);
            dificultadLabel.Name = "dificultadLabel";
            dificultadLabel.Size = new Size(86, 23);
            dificultadLabel.TabIndex = 2;
            dificultadLabel.Text = "Dificultad:";
            // 
            // dificultadComboBox
            // 
            dificultadComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dificultadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dificultadComboBox.Font = new Font("Segoe UI", 10F);
            dificultadComboBox.ForeColor = Color.Black;
            dificultadComboBox.FormattingEnabled = true;
            dificultadComboBox.Items.AddRange(new object[] { "1", "2", "3" });
            dificultadComboBox.Location = new Point(220, 152);
            dificultadComboBox.Name = "dificultadComboBox";
            dificultadComboBox.Size = new Size(314, 31);
            dificultadComboBox.TabIndex = 10;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new Font("Segoe UI", 10F);
            estadoLabel.Location = new Point(40, 205);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(63, 23);
            estadoLabel.TabIndex = 3;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            estadoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            estadoTextBox.BackColor = SystemColors.Control;
            estadoTextBox.Font = new Font("Segoe UI", 10F);
            estadoTextBox.Location = new Point(220, 202);
            estadoTextBox.Name = "estadoTextBox";
            estadoTextBox.ReadOnly = true;
            estadoTextBox.Size = new Size(314, 30);
            estadoTextBox.TabIndex = 7;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(cancelarButton);
            panelButtons.Controls.Add(aceptarButton);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 257);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(564, 60);
            panelButtons.TabIndex = 1;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelarButton.Font = new Font("Segoe UI", 10F);
            cancelarButton.Location = new Point(338, 10);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(100, 40);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aceptarButton.Font = new Font("Segoe UI", 10F);
            aceptarButton.Location = new Point(444, 10);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(110, 40);
            aceptarButton.TabIndex = 8;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // PedidoAgregacionDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            MinimumSize = new Size(500, 300);
            Controls.Add(tableLayoutPanelMain);
            Name = "PedidoAgregacionDetalle";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedido de agregacion de anomalía";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelFields;
        private Panel panelButtons;
    }
}