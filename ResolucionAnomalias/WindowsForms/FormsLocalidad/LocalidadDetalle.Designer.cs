namespace WindowsForms
{
    partial class LocalidadDetalle
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
            labelCodigoLoc = new Label();
            labelNombreLoc = new Label();
            errorProvider = new ErrorProvider(components);
            buttonAceptarDetLoc = new Button();
            buttonCancelarLocDet = new Button();
            textBoxCodigoLoc = new TextBox();
            textBoxNombreLoc = new TextBox();
            labelIdDetLoc = new Label();
            textBoxIdDetLoc = new TextBox();
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
            tableLayoutPanelMain.Size = new Size(470, 285);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(labelIdDetLoc);
            panelFields.Controls.Add(textBoxIdDetLoc);
            panelFields.Controls.Add(labelCodigoLoc);
            panelFields.Controls.Add(textBoxCodigoLoc);
            panelFields.Controls.Add(labelNombreLoc);
            panelFields.Controls.Add(textBoxNombreLoc);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(20);
            panelFields.Size = new Size(464, 213);
            panelFields.TabIndex = 0;
            // 
            // labelIdDetLoc
            // 
            labelIdDetLoc.AutoSize = true;
            labelIdDetLoc.Font = new Font("Segoe UI", 10F);
            labelIdDetLoc.Location = new Point(30, 50);
            labelIdDetLoc.Name = "labelIdDetLoc";
            labelIdDetLoc.Size = new Size(30, 23);
            labelIdDetLoc.TabIndex = 5;
            labelIdDetLoc.Text = "ID:";
            // 
            // textBoxIdDetLoc
            // 
            textBoxIdDetLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdDetLoc.BackColor = SystemColors.Control;
            textBoxIdDetLoc.Font = new Font("Segoe UI", 10F);
            textBoxIdDetLoc.Location = new Point(150, 47);
            textBoxIdDetLoc.Name = "textBoxIdDetLoc";
            textBoxIdDetLoc.ReadOnly = true;
            textBoxIdDetLoc.Size = new Size(294, 30);
            textBoxIdDetLoc.TabIndex = 6;
            textBoxIdDetLoc.TextChanged += textBoxIdDetLoc_TextChanged;
            // 
            // labelCodigoLoc
            // 
            labelCodigoLoc.AutoSize = true;
            labelCodigoLoc.Font = new Font("Segoe UI", 10F);
            labelCodigoLoc.Location = new Point(30, 100);
            labelCodigoLoc.Name = "labelCodigoLoc";
            labelCodigoLoc.Size = new Size(69, 23);
            labelCodigoLoc.TabIndex = 0;
            labelCodigoLoc.Text = "Codigo:";
            // 
            // textBoxCodigoLoc
            // 
            textBoxCodigoLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoLoc.BackColor = SystemColors.Window;
            textBoxCodigoLoc.Font = new Font("Segoe UI", 10F);
            textBoxCodigoLoc.Location = new Point(150, 97);
            textBoxCodigoLoc.Name = "textBoxCodigoLoc";
            textBoxCodigoLoc.Size = new Size(294, 30);
            textBoxCodigoLoc.TabIndex = 4;
            // 
            // labelNombreLoc
            // 
            labelNombreLoc.AutoSize = true;
            labelNombreLoc.Font = new Font("Segoe UI", 10F);
            labelNombreLoc.Location = new Point(30, 150);
            labelNombreLoc.Name = "labelNombreLoc";
            labelNombreLoc.Size = new Size(73, 23);
            labelNombreLoc.TabIndex = 1;
            labelNombreLoc.Text = "Nombre:";
            // 
            // textBoxNombreLoc
            // 
            textBoxNombreLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombreLoc.Font = new Font("Segoe UI", 10F);
            textBoxNombreLoc.Location = new Point(150, 147);
            textBoxNombreLoc.Name = "textBoxNombreLoc";
            textBoxNombreLoc.Size = new Size(294, 30);
            textBoxNombreLoc.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelarLocDet);
            panelButtons.Controls.Add(buttonAceptarDetLoc);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 222);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10, 5, 10, 10);
            panelButtons.Size = new Size(464, 60);
            panelButtons.TabIndex = 1;
            // 
            // buttonCancelarLocDet
            // 
            buttonCancelarLocDet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelarLocDet.Font = new Font("Segoe UI", 10F);
            buttonCancelarLocDet.Location = new Point(248, 10);
            buttonCancelarLocDet.Name = "buttonCancelarLocDet";
            buttonCancelarLocDet.Size = new Size(100, 40);
            buttonCancelarLocDet.TabIndex = 3;
            buttonCancelarLocDet.Text = "Cancelar";
            buttonCancelarLocDet.UseVisualStyleBackColor = true;
            buttonCancelarLocDet.Click += cancelarButton_Click;
            // 
            // buttonAceptarDetLoc
            // 
            buttonAceptarDetLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptarDetLoc.Font = new Font("Segoe UI", 10F);
            buttonAceptarDetLoc.Location = new Point(354, 10);
            buttonAceptarDetLoc.Name = "buttonAceptarDetLoc";
            buttonAceptarDetLoc.Size = new Size(100, 40);
            buttonAceptarDetLoc.TabIndex = 2;
            buttonAceptarDetLoc.Text = "Aceptar";
            buttonAceptarDetLoc.UseVisualStyleBackColor = true;
            buttonAceptarDetLoc.Click += aceptarButton_Click;
            // 
            // LocalidadDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 315);
            MinimumSize = new Size(400, 300);
            Controls.Add(tableLayoutPanelMain);
            Name = "LocalidadDetalle";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localidad";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelCodigoLoc;
        private Label labelNombreLoc;
        private Button buttonAceptarDetLoc;
        private Button buttonCancelarLocDet;
        private TextBox textBoxCodigoLoc;
        private TextBox textBoxNombreLoc;
        private Label labelIdDetLoc;
        private TextBox textBoxIdDetLoc;
        private ErrorProvider errorProvider;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelFields;
        private Panel panelButtons;
    }
}