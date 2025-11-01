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
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelAnomalias, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelBottomInfo, 0, 2);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(870, 620);
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
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(20, 10, 20, 10);
            panelFields.Size = new Size(864, 170);
            panelFields.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F);
            labelId.Location = new Point(30, 20);
            labelId.Name = "labelId";
            labelId.Size = new Size(28, 23);
            labelId.TabIndex = 1;
            labelId.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.Control;
            textBoxId.Font = new Font("Segoe UI", 10F);
            textBoxId.Location = new Point(170, 17);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(200, 30);
            textBoxId.TabIndex = 7;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 10F);
            labelFecha.Location = new Point(420, 20);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(53, 23);
            labelFecha.TabIndex = 23;
            labelFecha.Text = "Fecha";
            // 
            // textBoxFecha
            // 
            textBoxFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFecha.BackColor = SystemColors.Control;
            textBoxFecha.Font = new Font("Segoe UI", 10F);
            textBoxFecha.Location = new Point(530, 17);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.ReadOnly = true;
            textBoxFecha.Size = new Size(304, 30);
            textBoxFecha.TabIndex = 24;
            // 
            // labelDenunciante
            // 
            labelDenunciante.AutoSize = true;
            labelDenunciante.Font = new Font("Segoe UI", 10F);
            labelDenunciante.Location = new Point(30, 65);
            labelDenunciante.Name = "labelDenunciante";
            labelDenunciante.Size = new Size(106, 23);
            labelDenunciante.TabIndex = 5;
            labelDenunciante.Text = "Denunciante";
            // 
            // textBoxDenunciante
            // 
            textBoxDenunciante.BackColor = SystemColors.Control;
            textBoxDenunciante.Font = new Font("Segoe UI", 10F);
            textBoxDenunciante.Location = new Point(170, 62);
            textBoxDenunciante.Name = "textBoxDenunciante";
            textBoxDenunciante.ReadOnly = true;
            textBoxDenunciante.Size = new Size(200, 30);
            textBoxDenunciante.TabIndex = 26;
            // 
            // labelCazador
            // 
            labelCazador.AutoSize = true;
            labelCazador.Font = new Font("Segoe UI", 10F);
            labelCazador.Location = new Point(420, 65);
            labelCazador.Name = "labelCazador";
            labelCazador.Size = new Size(74, 23);
            labelCazador.TabIndex = 6;
            labelCazador.Text = "Cazador";
            // 
            // textBoxCazador
            // 
            textBoxCazador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCazador.BackColor = SystemColors.Control;
            textBoxCazador.Font = new Font("Segoe UI", 10F);
            textBoxCazador.Location = new Point(530, 62);
            textBoxCazador.Name = "textBoxCazador";
            textBoxCazador.ReadOnly = true;
            textBoxCazador.Size = new Size(304, 30);
            textBoxCazador.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Font = new Font("Segoe UI", 10F);
            textBoxDireccion.Location = new Point(170, 107);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(200, 30);
            textBoxDireccion.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(420, 110);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
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
            comboBoxZonas.Location = new Point(530, 107);
            comboBoxZonas.Name = "comboBoxZonas";
            comboBoxZonas.Size = new Size(304, 31);
            comboBoxZonas.TabIndex = 22;
            // 
            // panelAnomalias
            // 
            panelAnomalias.Controls.Add(label4);
            panelAnomalias.Controls.Add(dataGridViewAnomalias);
            panelAnomalias.Controls.Add(panelAnomaliaButtons);
            panelAnomalias.Dock = DockStyle.Fill;
            panelAnomalias.Location = new Point(3, 179);
            panelAnomalias.Name = "panelAnomalias";
            panelAnomalias.Padding = new Padding(20, 10, 20, 10);
            panelAnomalias.Size = new Size(864, 244);
            panelAnomalias.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(30, 15);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 4;
            label4.Text = "Anomalías";
            // 
            // dataGridViewAnomalias
            // 
            dataGridViewAnomalias.AllowUserToAddRows = false;
            dataGridViewAnomalias.AllowUserToDeleteRows = false;
            dataGridViewAnomalias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnomalias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnomalias.Location = new Point(30, 45);
            dataGridViewAnomalias.MultiSelect = false;
            dataGridViewAnomalias.Name = "dataGridViewAnomalias";
            dataGridViewAnomalias.ReadOnly = true;
            dataGridViewAnomalias.RowHeadersWidth = 51;
            dataGridViewAnomalias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnomalias.Size = new Size(804, 145);
            dataGridViewAnomalias.TabIndex = 0;
            // 
            // panelAnomaliaButtons
            // 
            panelAnomaliaButtons.Controls.Add(buttonEliminar);
            panelAnomaliaButtons.Controls.Add(buttonAgregar);
            panelAnomaliaButtons.Dock = DockStyle.Bottom;
            panelAnomaliaButtons.Location = new Point(20, 194);
            panelAnomaliaButtons.Name = "panelAnomaliaButtons";
            panelAnomaliaButtons.Padding = new Padding(10, 5, 10, 5);
            panelAnomaliaButtons.Size = new Size(824, 40);
            panelAnomaliaButtons.TabIndex = 2;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminar.Font = new Font("Segoe UI", 10F);
            buttonEliminar.Location = new Point(604, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(100, 35);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregar.Font = new Font("Segoe UI", 10F);
            buttonAgregar.Location = new Point(710, 5);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(100, 35);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
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
            panelBottomInfo.Location = new Point(3, 429);
            panelBottomInfo.Name = "panelBottomInfo";
            panelBottomInfo.Padding = new Padding(20, 10, 20, 10);
            panelBottomInfo.Size = new Size(864, 128);
            panelBottomInfo.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(30, 20);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(99, 23);
            labelDescripcion.TabIndex = 19;
            labelDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.Font = new Font("Segoe UI", 10F);
            textBoxDescripcion.Location = new Point(170, 17);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(664, 30);
            textBoxDescripcion.TabIndex = 17;
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.Font = new Font("Segoe UI", 10F);
            labelComentario.Location = new Point(30, 65);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(102, 23);
            labelComentario.TabIndex = 20;
            labelComentario.Text = "Comentario";
            // 
            // textBoxComentario
            // 
            textBoxComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxComentario.Font = new Font("Segoe UI", 10F);
            textBoxComentario.Location = new Point(170, 62);
            textBoxComentario.Name = "textBoxComentario";
            textBoxComentario.Size = new Size(454, 30);
            textBoxComentario.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(650, 65);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 15;
            label6.Text = "Dificultad";
            // 
            // textBoxDificultad
            // 
            textBoxDificultad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDificultad.BackColor = SystemColors.Control;
            textBoxDificultad.Font = new Font("Segoe UI", 10F);
            textBoxDificultad.Location = new Point(739, 62);
            textBoxDificultad.Name = "textBoxDificultad";
            textBoxDificultad.ReadOnly = true;
            textBoxDificultad.Size = new Size(95, 30);
            textBoxDificultad.TabIndex = 18;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 563);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(864, 54);
            panelButtons.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10F);
            buttonCancelar.Location = new Point(638, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 40);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(744, 10);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(110, 40);
            buttonAceptar.TabIndex = 12;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // DetallePedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            MinimumSize = new Size(800, 600);
            Controls.Add(tableLayoutPanelMain);
            Name = "DetallePedidoResolucion";
            Padding = new Padding(15);
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