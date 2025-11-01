namespace WindowsForms.FormsTipoAnomalia
{
    partial class TipoAnomaliaDetalle
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonAceptarTipoDetalle = new Button();
            buttonCancelarTipoDetalle = new Button();
            LabelCodigoTipoDetalle = new Label();
            LabelNombreTipoDetalle = new Label();
            LabelDificultadTipoDetalle = new Label();
            TextBoxCodigoTipoDetalle = new TextBox();
            TextBoxNombreTipoDetalle = new TextBox();
            ComboDificultadTipoDetalle = new ComboBox();
            errorProvider = new ErrorProvider(components);
            tipoAnomaliaBindingSource = new BindingSource(components);
            tableLayoutPanelMain = new TableLayoutPanel();
            panelFields = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoAnomaliaBindingSource).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelFields.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tipoAnomaliaBindingSource
            // 
            tipoAnomaliaBindingSource.DataSource = typeof(Domain.Model.TipoAnomalia);
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
            panelFields.Controls.Add(LabelCodigoTipoDetalle);
            panelFields.Controls.Add(TextBoxCodigoTipoDetalle);
            panelFields.Controls.Add(LabelNombreTipoDetalle);
            panelFields.Controls.Add(TextBoxNombreTipoDetalle);
            panelFields.Controls.Add(LabelDificultadTipoDetalle);
            panelFields.Controls.Add(ComboDificultadTipoDetalle);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(30, 20, 30, 20);
            panelFields.Size = new Size(564, 248);
            panelFields.TabIndex = 0;
            // 
            // LabelCodigoTipoDetalle
            // 
            LabelCodigoTipoDetalle.AutoSize = true;
            LabelCodigoTipoDetalle.Font = new Font("Segoe UI", 10F);
            LabelCodigoTipoDetalle.Location = new Point(40, 50);
            LabelCodigoTipoDetalle.Name = "LabelCodigoTipoDetalle";
            LabelCodigoTipoDetalle.Size = new Size(69, 23);
            LabelCodigoTipoDetalle.TabIndex = 2;
            LabelCodigoTipoDetalle.Text = "Código:";
            // 
            // TextBoxCodigoTipoDetalle
            // 
            TextBoxCodigoTipoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxCodigoTipoDetalle.BackColor = SystemColors.Control;
            TextBoxCodigoTipoDetalle.Font = new Font("Segoe UI", 10F);
            TextBoxCodigoTipoDetalle.Location = new Point(200, 47);
            TextBoxCodigoTipoDetalle.Name = "TextBoxCodigoTipoDetalle";
            TextBoxCodigoTipoDetalle.ReadOnly = true;
            TextBoxCodigoTipoDetalle.Size = new Size(334, 30);
            TextBoxCodigoTipoDetalle.TabIndex = 6;
            // 
            // LabelNombreTipoDetalle
            // 
            LabelNombreTipoDetalle.AutoSize = true;
            LabelNombreTipoDetalle.Font = new Font("Segoe UI", 10F);
            LabelNombreTipoDetalle.Location = new Point(40, 105);
            LabelNombreTipoDetalle.Name = "LabelNombreTipoDetalle";
            LabelNombreTipoDetalle.Size = new Size(73, 23);
            LabelNombreTipoDetalle.TabIndex = 3;
            LabelNombreTipoDetalle.Text = "Nombre:";
            // 
            // TextBoxNombreTipoDetalle
            // 
            TextBoxNombreTipoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombreTipoDetalle.Font = new Font("Segoe UI", 10F);
            TextBoxNombreTipoDetalle.Location = new Point(200, 102);
            TextBoxNombreTipoDetalle.Name = "TextBoxNombreTipoDetalle";
            TextBoxNombreTipoDetalle.Size = new Size(334, 30);
            TextBoxNombreTipoDetalle.TabIndex = 5;
            // 
            // LabelDificultadTipoDetalle
            // 
            LabelDificultadTipoDetalle.AutoSize = true;
            LabelDificultadTipoDetalle.Font = new Font("Segoe UI", 10F);
            LabelDificultadTipoDetalle.Location = new Point(40, 160);
            LabelDificultadTipoDetalle.Name = "LabelDificultadTipoDetalle";
            LabelDificultadTipoDetalle.Size = new Size(86, 23);
            LabelDificultadTipoDetalle.TabIndex = 4;
            LabelDificultadTipoDetalle.Text = "Dificultad:";
            // 
            // ComboDificultadTipoDetalle
            // 
            ComboDificultadTipoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboDificultadTipoDetalle.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDificultadTipoDetalle.FlatStyle = FlatStyle.Popup;
            ComboDificultadTipoDetalle.Font = new Font("Segoe UI", 10F);
            ComboDificultadTipoDetalle.ForeColor = Color.Black;
            ComboDificultadTipoDetalle.FormattingEnabled = true;
            ComboDificultadTipoDetalle.Items.AddRange(new object[] { 1, 2, 3 });
            ComboDificultadTipoDetalle.Location = new Point(200, 157);
            ComboDificultadTipoDetalle.MaxDropDownItems = 3;
            ComboDificultadTipoDetalle.Name = "ComboDificultadTipoDetalle";
            ComboDificultadTipoDetalle.Size = new Size(334, 31);
            ComboDificultadTipoDetalle.TabIndex = 7;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelarTipoDetalle);
            panelButtons.Controls.Add(buttonAceptarTipoDetalle);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 257);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(564, 60);
            panelButtons.TabIndex = 1;
            // 
            // buttonCancelarTipoDetalle
            // 
            buttonCancelarTipoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelarTipoDetalle.Font = new Font("Segoe UI", 10F);
            buttonCancelarTipoDetalle.Location = new Point(338, 10);
            buttonCancelarTipoDetalle.Name = "buttonCancelarTipoDetalle";
            buttonCancelarTipoDetalle.Size = new Size(100, 40);
            buttonCancelarTipoDetalle.TabIndex = 1;
            buttonCancelarTipoDetalle.Text = "Cancelar";
            buttonCancelarTipoDetalle.UseVisualStyleBackColor = true;
            buttonCancelarTipoDetalle.Click += cancelarButton_Click;
            // 
            // buttonAceptarTipoDetalle
            // 
            buttonAceptarTipoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptarTipoDetalle.Font = new Font("Segoe UI", 10F);
            buttonAceptarTipoDetalle.Location = new Point(444, 10);
            buttonAceptarTipoDetalle.Name = "buttonAceptarTipoDetalle";
            buttonAceptarTipoDetalle.Size = new Size(110, 40);
            buttonAceptarTipoDetalle.TabIndex = 0;
            buttonAceptarTipoDetalle.Text = "Aceptar";
            buttonAceptarTipoDetalle.UseVisualStyleBackColor = true;
            buttonAceptarTipoDetalle.Click += aceptarButton_Click;
            // 
            // TipoAnomaliaDetalle
            // 
            ClientSize = new Size(600, 350);
            MinimumSize = new Size(500, 300);
            Controls.Add(tableLayoutPanelMain);
            Name = "TipoAnomaliaDetalle";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Tipo de Anomalía";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoAnomaliaBindingSource).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private TextBox TextBoxNombreTipoDetalle;
        private ComboBox ComboDificultadTipoDetalle;
        private BindingSource tipoAnomaliaBindingSource;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelFields;
        private Panel panelButtons;
    }
}