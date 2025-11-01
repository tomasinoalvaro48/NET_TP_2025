namespace WindowsForms.FormsPedidoResolucion
{
    partial class DetallePedidoResolucion
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
            dataGridViewAnomalias = new DataGridView();
            labelId = new Label();
            label3 = new Label();
            label4 = new Label();
            labelDenunciante = new Label();
            textBoxId = new TextBox();
            textBoxDireccion = new TextBox();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            label6 = new Label();
            textBoxComentario = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxDificultad = new TextBox();
            labelDescripcion = new Label();
            labelComentario = new Label();
            label7 = new Label();
            comboBoxZonas = new ComboBox();
            labelFecha = new Label();
            textBoxFecha = new TextBox();
            labelCazador = new Label();
            textBoxCazador = new TextBox();
            textBoxDenunciante = new TextBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelFields = new Panel();
            panelAnomalias = new Panel();
            panelAnomaliaButtons = new Panel();
            panelBottomInfo = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnomalias).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelFields.SuspendLayout();
            panelAnomalias.SuspendLayout();
            panelAnomaliaButtons.SuspendLayout();
            panelBottomInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // dataGridViewAnomalias
            // 
            dataGridViewAnomalias.AllowUserToAddRows = false;
            dataGridViewAnomalias.AllowUserToDeleteRows = false;
            dataGridViewAnomalias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnomalias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnomalias.Location = new Point(49, 72);
            dataGridViewAnomalias.Margin = new Padding(5, 5, 5, 5);
            dataGridViewAnomalias.MinimumSize = new Size(1306, 231);
            dataGridViewAnomalias.MultiSelect = false;
            dataGridViewAnomalias.Name = "dataGridViewAnomalias";
            dataGridViewAnomalias.ReadOnly = true;
            dataGridViewAnomalias.RowHeadersWidth = 51;
            dataGridViewAnomalias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnomalias.Size = new Size(1306, 231);
            dataGridViewAnomalias.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F);
            labelId.Location = new Point(49, 32);
            labelId.Margin = new Padding(5, 0, 5, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(43, 37);
            labelId.TabIndex = 1;
            labelId.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(49, 176);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(49, 24);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 37);
            label4.TabIndex = 4;
            label4.Text = "Anomalías";
            // 
            // labelDenunciante
            // 
            labelDenunciante.AutoSize = true;
            labelDenunciante.Font = new Font("Segoe UI", 10F);
            labelDenunciante.Location = new Point(49, 104);
            labelDenunciante.Margin = new Padding(5, 0, 5, 0);
            labelDenunciante.Name = "labelDenunciante";
            labelDenunciante.Size = new Size(166, 37);
            labelDenunciante.TabIndex = 5;
            labelDenunciante.Text = "Denunciante";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.Control;
            textBoxId.Font = new Font("Segoe UI", 10F);
            textBoxId.Location = new Point(276, 27);
            textBoxId.Margin = new Padding(5, 5, 5, 5);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(322, 43);
            textBoxId.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Font = new Font("Segoe UI", 10F);
            textBoxDireccion.Location = new Point(276, 171);
            textBoxDireccion.Margin = new Padding(5, 5, 5, 5);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(322, 43);
            textBoxDireccion.TabIndex = 10;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10F);
            buttonCancelar.Location = new Point(1037, 16);
            buttonCancelar.Margin = new Padding(5, 5, 5, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(162, 64);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(1209, 16);
            buttonAceptar.Margin = new Padding(5, 5, 5, 5);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(179, 64);
            buttonAceptar.TabIndex = 12;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregar.Font = new Font("Segoe UI", 10F);
            buttonAgregar.Location = new Point(1155, 8);
            buttonAgregar.Margin = new Padding(5, 5, 5, 5);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(162, 56);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminar.Font = new Font("Segoe UI", 10F);
            buttonEliminar.Location = new Point(983, 8);
            buttonEliminar.Margin = new Padding(5, 5, 5, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(162, 56);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(1056, 104);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 37);
            label6.TabIndex = 15;
            label6.Text = "Dificultad";
            // 
            // textBoxComentario
            // 
            textBoxComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxComentario.Font = new Font("Segoe UI", 10F);
            textBoxComentario.Location = new Point(276, 99);
            textBoxComentario.Margin = new Padding(5, 5, 5, 5);
            textBoxComentario.Name = "textBoxComentario";
            textBoxComentario.Size = new Size(735, 43);
            textBoxComentario.TabIndex = 16;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.Font = new Font("Segoe UI", 10F);
            textBoxDescripcion.Location = new Point(276, 27);
            textBoxDescripcion.Margin = new Padding(5, 5, 5, 5);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(1076, 43);
            textBoxDescripcion.TabIndex = 17;
            // 
            // textBoxDificultad
            // 
            textBoxDificultad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDificultad.BackColor = SystemColors.Control;
            textBoxDificultad.Font = new Font("Segoe UI", 10F);
            textBoxDificultad.Location = new Point(1201, 99);
            textBoxDificultad.Margin = new Padding(5, 5, 5, 5);
            textBoxDificultad.Name = "textBoxDificultad";
            textBoxDificultad.ReadOnly = true;
            textBoxDificultad.Size = new Size(152, 43);
            textBoxDificultad.TabIndex = 18;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(49, 32);
            labelDescripcion.Margin = new Padding(5, 0, 5, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(155, 37);
            labelDescripcion.TabIndex = 19;
            labelDescripcion.Text = "Descripción";
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.Font = new Font("Segoe UI", 10F);
            labelComentario.Location = new Point(49, 104);
            labelComentario.Margin = new Padding(5, 0, 5, 0);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(157, 37);
            labelComentario.TabIndex = 20;
            labelComentario.Text = "Comentario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(682, 176);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 37);
            label7.TabIndex = 21;
            label7.Text = "Zona";
            // 
            // comboBoxZonas
            // 
            comboBoxZonas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxZonas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZonas.FlatStyle = FlatStyle.Popup;
            comboBoxZonas.Font = new Font("Segoe UI", 10F);
            comboBoxZonas.ForeColor = Color.Black;
            comboBoxZonas.FormattingEnabled = true;
            comboBoxZonas.Location = new Point(861, 171);
            comboBoxZonas.Margin = new Padding(5, 5, 5, 5);
            comboBoxZonas.Name = "comboBoxZonas";
            comboBoxZonas.Size = new Size(492, 45);
            comboBoxZonas.TabIndex = 22;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 10F);
            labelFecha.Location = new Point(682, 32);
            labelFecha.Margin = new Padding(5, 0, 5, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(85, 37);
            labelFecha.TabIndex = 23;
            labelFecha.Text = "Fecha";
            // 
            // textBoxFecha
            // 
            textBoxFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFecha.BackColor = SystemColors.Control;
            textBoxFecha.Font = new Font("Segoe UI", 10F);
            textBoxFecha.Location = new Point(861, 27);
            textBoxFecha.Margin = new Padding(5, 5, 5, 5);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.ReadOnly = true;
            textBoxFecha.Size = new Size(492, 43);
            textBoxFecha.TabIndex = 24;
            // 
            // labelCazador
            // 
            labelCazador.AutoSize = true;
            labelCazador.Font = new Font("Segoe UI", 10F);
            labelCazador.Location = new Point(682, 104);
            labelCazador.Margin = new Padding(5, 0, 5, 0);
            labelCazador.Name = "labelCazador";
            labelCazador.Size = new Size(115, 37);
            labelCazador.TabIndex = 6;
            labelCazador.Text = "Cazador";
            // 
            // textBoxCazador
            // 
            textBoxCazador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCazador.BackColor = SystemColors.Control;
            textBoxCazador.Font = new Font("Segoe UI", 10F);
            textBoxCazador.Location = new Point(861, 99);
            textBoxCazador.Margin = new Padding(5, 5, 5, 5);
            textBoxCazador.Name = "textBoxCazador";
            textBoxCazador.ReadOnly = true;
            textBoxCazador.Size = new Size(492, 43);
            textBoxCazador.TabIndex = 25;
            // 
            // textBoxDenunciante
            // 
            textBoxDenunciante.BackColor = SystemColors.Control;
            textBoxDenunciante.Font = new Font("Segoe UI", 10F);
            textBoxDenunciante.Location = new Point(276, 99);
            textBoxDenunciante.Margin = new Padding(5, 5, 5, 5);
            textBoxDenunciante.Name = "textBoxDenunciante";
            textBoxDenunciante.ReadOnly = true;
            textBoxDenunciante.Size = new Size(322, 43);
            textBoxDenunciante.TabIndex = 26;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelAnomalias, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelBottomInfo, 0, 2);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(24, 24);
            tableLayoutPanelMain.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1414, 992);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(labelId);
            panelFields.Controls.Add(textBoxId);
            panelFields.Controls.Add(labelFecha);
            panelFields.Controls.Add(textBoxFecha);
            panelFields.Controls.Add(labelDenunciante);
            panelFields.Controls.Add(textBoxDenunciante);
            panelFields.Controls.Add(labelCazador);
            panelFields.Controls.Add(textBoxCazador);
            panelFields.Controls.Add(label3);
            panelFields.Controls.Add(textBoxDireccion);
            panelFields.Controls.Add(label7);
            panelFields.Controls.Add(comboBoxZonas);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(5, 5);
            panelFields.Margin = new Padding(5, 5, 5, 5);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(32, 16, 32, 16);
            panelFields.Size = new Size(1404, 272);
            panelFields.TabIndex = 0;
            // 
            // panelAnomalias
            // 
            panelAnomalias.Controls.Add(label4);
            panelAnomalias.Controls.Add(dataGridViewAnomalias);
            panelAnomalias.Controls.Add(panelAnomaliaButtons);
            panelAnomalias.Dock = DockStyle.Fill;
            panelAnomalias.Location = new Point(5, 287);
            panelAnomalias.Margin = new Padding(5, 5, 5, 5);
            panelAnomalias.Name = "panelAnomalias";
            panelAnomalias.Padding = new Padding(32, 16, 32, 16);
            panelAnomalias.Size = new Size(1404, 389);
            panelAnomalias.TabIndex = 1;
            // 
            // panelAnomaliaButtons
            // 
            panelAnomaliaButtons.Controls.Add(buttonEliminar);
            panelAnomaliaButtons.Controls.Add(buttonAgregar);
            panelAnomaliaButtons.Dock = DockStyle.Bottom;
            panelAnomaliaButtons.Location = new Point(32, 309);
            panelAnomaliaButtons.Margin = new Padding(5, 5, 5, 5);
            panelAnomaliaButtons.Name = "panelAnomaliaButtons";
            panelAnomaliaButtons.Padding = new Padding(16, 8, 16, 8);
            panelAnomaliaButtons.Size = new Size(1340, 64);
            panelAnomaliaButtons.TabIndex = 2;
            // 
            // panelBottomInfo
            // 
            panelBottomInfo.Controls.Add(labelDescripcion);
            panelBottomInfo.Controls.Add(textBoxDescripcion);
            panelBottomInfo.Controls.Add(labelComentario);
            panelBottomInfo.Controls.Add(textBoxComentario);
            panelBottomInfo.Controls.Add(label6);
            panelBottomInfo.Controls.Add(textBoxDificultad);
            panelBottomInfo.Dock = DockStyle.Fill;
            panelBottomInfo.Location = new Point(5, 686);
            panelBottomInfo.Margin = new Padding(5, 5, 5, 5);
            panelBottomInfo.Name = "panelBottomInfo";
            panelBottomInfo.Padding = new Padding(32, 16, 32, 16);
            panelBottomInfo.Size = new Size(1404, 205);
            panelBottomInfo.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 901);
            panelButtons.Margin = new Padding(5, 5, 5, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(16, 16, 16, 16);
            panelButtons.Size = new Size(1404, 86);
            panelButtons.TabIndex = 3;
            // 
            // DetallePedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 1040);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(1488, 1111);
            Name = "DetallePedidoResolucion";
            Padding = new Padding(24, 24, 24, 24);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Pedido de Resolución";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnomalias).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelAnomalias.ResumeLayout(false);
            panelAnomalias.PerformLayout();
            panelAnomaliaButtons.ResumeLayout(false);
            panelBottomInfo.ResumeLayout(false);
            panelBottomInfo.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider;
        private TextBox textBoxId;
        private Label labelDenunciante;
        private Label label4;
        private Label label3;
        private Label labelId;
        private DataGridView dataGridViewAnomalias;
        private Label label6;
        private Button buttonEliminar;
        private Button buttonAgregar;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private TextBox textBoxDireccion;
        private TextBox textBoxDescripcion;
        private TextBox textBoxComentario;
        private Label labelComentario;
        private Label labelDescripcion;
        private TextBox textBoxDificultad;
        private ComboBox comboBoxZonas;
        private Label label7;
        private TextBox textBoxFecha;
        private Label labelFecha;
        private TextBox textBoxDenunciante;
        private TextBox textBoxCazador;
        private Label labelCazador;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelFields;
        private Panel panelAnomalias;
        private Panel panelAnomaliaButtons;
        private Panel panelBottomInfo;
        private Panel panelButtons;
    }
}