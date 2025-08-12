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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoAnomaliaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonAceptarTipoDetalle
            // 
            buttonAceptarTipoDetalle.Location = new Point(657, 461);
            buttonAceptarTipoDetalle.Name = "buttonAceptarTipoDetalle";
            buttonAceptarTipoDetalle.Size = new Size(150, 46);
            buttonAceptarTipoDetalle.TabIndex = 0;
            buttonAceptarTipoDetalle.Text = "Aceptar";
            buttonAceptarTipoDetalle.UseVisualStyleBackColor = true;
            buttonAceptarTipoDetalle.Click += aceptarButton_Click;
            // 
            // buttonCancelarTipoDetalle
            // 
            buttonCancelarTipoDetalle.Location = new Point(213, 461);
            buttonCancelarTipoDetalle.Name = "buttonCancelarTipoDetalle";
            buttonCancelarTipoDetalle.Size = new Size(150, 46);
            buttonCancelarTipoDetalle.TabIndex = 1;
            buttonCancelarTipoDetalle.Text = "Cancelar";
            buttonCancelarTipoDetalle.UseVisualStyleBackColor = true;
            buttonCancelarTipoDetalle.Click += cancelarButton_Click;
            // 
            // LabelCodigoTipoDetalle
            // 
            LabelCodigoTipoDetalle.AutoSize = true;
            LabelCodigoTipoDetalle.Location = new Point(156, 126);
            LabelCodigoTipoDetalle.Name = "LabelCodigoTipoDetalle";
            LabelCodigoTipoDetalle.Size = new Size(91, 32);
            LabelCodigoTipoDetalle.TabIndex = 2;
            LabelCodigoTipoDetalle.Text = "Código";
            // 
            // LabelNombreTipoDetalle
            // 
            LabelNombreTipoDetalle.AutoSize = true;
            LabelNombreTipoDetalle.Location = new Point(156, 196);
            LabelNombreTipoDetalle.Name = "LabelNombreTipoDetalle";
            LabelNombreTipoDetalle.Size = new Size(102, 32);
            LabelNombreTipoDetalle.TabIndex = 3;
            LabelNombreTipoDetalle.Text = "Nombre";
            // 
            // LabelDificultadTipoDetalle
            // 
            LabelDificultadTipoDetalle.AutoSize = true;
            LabelDificultadTipoDetalle.Location = new Point(156, 270);
            LabelDificultadTipoDetalle.Name = "LabelDificultadTipoDetalle";
            LabelDificultadTipoDetalle.Size = new Size(116, 32);
            LabelDificultadTipoDetalle.TabIndex = 4;
            LabelDificultadTipoDetalle.Text = "Dificultad";
            // 
            // TextBoxCodigoTipoDetalle
            // 
            TextBoxCodigoTipoDetalle.Location = new Point(328, 119);
            TextBoxCodigoTipoDetalle.Name = "TextBoxCodigoTipoDetalle";
            TextBoxCodigoTipoDetalle.ReadOnly = true;
            TextBoxCodigoTipoDetalle.Size = new Size(200, 39);
            TextBoxCodigoTipoDetalle.TabIndex = 6;
            // 
            // TextBoxNombreTipoDetalle
            // 
            TextBoxNombreTipoDetalle.Location = new Point(328, 196);
            TextBoxNombreTipoDetalle.Name = "TextBoxNombreTipoDetalle";
            TextBoxNombreTipoDetalle.Size = new Size(200, 39);
            TextBoxNombreTipoDetalle.TabIndex = 5;
            // 
            // ComboDificultadTipoDetalle
            // 
            ComboDificultadTipoDetalle.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDificultadTipoDetalle.FlatStyle = FlatStyle.Popup;
            ComboDificultadTipoDetalle.ForeColor = SystemColors.WindowFrame;
            ComboDificultadTipoDetalle.FormattingEnabled = true;
            ComboDificultadTipoDetalle.Items.AddRange(new object[] { "facil", "medio", "dificil" });
            ComboDificultadTipoDetalle.Location = new Point(328, 270);
            ComboDificultadTipoDetalle.MaxDropDownItems = 3;
            ComboDificultadTipoDetalle.Name = "ComboDificultadTipoDetalle";
            ComboDificultadTipoDetalle.Size = new Size(242, 40);
            ComboDificultadTipoDetalle.TabIndex = 7;
            ComboDificultadTipoDetalle.Tag = "";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tipoAnomaliaBindingSource
            // 
            tipoAnomaliaBindingSource.DataSource = typeof(Domain.Model.TipoAnomalia);
            // 
            // TipoAnomaliaDetalle
            // 
            ClientSize = new Size(1010, 605);
            Controls.Add(ComboDificultadTipoDetalle);
            Controls.Add(TextBoxCodigoTipoDetalle);
            Controls.Add(TextBoxNombreTipoDetalle);
            Controls.Add(LabelDificultadTipoDetalle);
            Controls.Add(LabelNombreTipoDetalle);
            Controls.Add(LabelCodigoTipoDetalle);
            Controls.Add(buttonCancelarTipoDetalle);
            Controls.Add(buttonAceptarTipoDetalle);
            Name = "TipoAnomaliaDetalle";
            Text = "Detalle Tipo de Anomalía";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoAnomaliaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}