namespace WindowsForms.FormsPedidoResolucion
{
    partial class DetalleAnomalia
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
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            comboBoxTipoAnomalia = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanelMain = new TableLayoutPanel();
            panelFields = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelFields.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(65, 72);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Anomalía";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10F);
            buttonCancelar.Location = new Point(387, 16);
            buttonCancelar.Margin = new Padding(5, 5, 5, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(162, 64);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(559, 16);
            buttonAceptar.Margin = new Padding(5, 5, 5, 5);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(179, 64);
            buttonAceptar.TabIndex = 2;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // comboBoxTipoAnomalia
            // 
            comboBoxTipoAnomalia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTipoAnomalia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoAnomalia.FlatStyle = FlatStyle.Popup;
            comboBoxTipoAnomalia.Font = new Font("Segoe UI", 10F);
            comboBoxTipoAnomalia.ForeColor = Color.Black;
            comboBoxTipoAnomalia.FormattingEnabled = true;
            comboBoxTipoAnomalia.Location = new Point(341, 67);
            comboBoxTipoAnomalia.Margin = new Padding(5, 5, 5, 5);
            comboBoxTipoAnomalia.Name = "comboBoxTipoAnomalia";
            comboBoxTipoAnomalia.Size = new Size(345, 45);
            comboBoxTipoAnomalia.TabIndex = 3;
            comboBoxTipoAnomalia.SelectedIndexChanged += comboBoxTipoAnomalia_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(24, 24);
            tableLayoutPanelMain.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(764, 272);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(label1);
            panelFields.Controls.Add(comboBoxTipoAnomalia);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(5, 5);
            panelFields.Margin = new Padding(5, 5, 5, 5);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(49, 32, 49, 32);
            panelFields.Size = new Size(754, 166);
            panelFields.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 181);
            panelButtons.Margin = new Padding(5, 5, 5, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(16, 16, 16, 16);
            panelButtons.Size = new Size(754, 86);
            panelButtons.TabIndex = 1;
            // 
            // DetalleAnomalia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 320);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(838, 391);
            Name = "DetalleAnomalia";
            Padding = new Padding(24, 24, 24, 24);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Anomalía";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private ComboBox comboBoxTipoAnomalia;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelFields;
        private Panel panelButtons;
    }
}