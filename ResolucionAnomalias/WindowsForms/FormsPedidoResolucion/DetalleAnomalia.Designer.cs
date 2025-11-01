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
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(470, 170);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(label1);
            panelFields.Controls.Add(comboBoxTipoAnomalia);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(30, 20, 30, 20);
            panelFields.Size = new Size(464, 104);
            panelFields.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Anomalía";
            // 
            // comboBoxTipoAnomalia
            // 
            comboBoxTipoAnomalia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTipoAnomalia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoAnomalia.FlatStyle = FlatStyle.Popup;
            comboBoxTipoAnomalia.Font = new Font("Segoe UI", 10F);
            comboBoxTipoAnomalia.ForeColor = Color.Black;
            comboBoxTipoAnomalia.FormattingEnabled = true;
            comboBoxTipoAnomalia.Location = new Point(210, 42);
            comboBoxTipoAnomalia.Name = "comboBoxTipoAnomalia";
            comboBoxTipoAnomalia.Size = new Size(214, 31);
            comboBoxTipoAnomalia.TabIndex = 3;
            comboBoxTipoAnomalia.SelectedIndexChanged += comboBoxTipoAnomalia_SelectedIndexChanged;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 113);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(464, 54);
            panelButtons.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10F);
            buttonCancelar.Location = new Point(238, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 40);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(344, 10);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(110, 40);
            buttonAceptar.TabIndex = 2;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // DetalleAnomalia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 200);
            MinimumSize = new Size(400, 200);
            Controls.Add(tableLayoutPanelMain);
            Name = "DetalleAnomalia";
            Padding = new Padding(15);
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