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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnomalias).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // dataGridViewAnomalias
            // 
            dataGridViewAnomalias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnomalias.Location = new Point(40, 210);
            dataGridViewAnomalias.Name = "dataGridViewAnomalias";
            dataGridViewAnomalias.RowHeadersWidth = 51;
            dataGridViewAnomalias.Size = new Size(707, 129);
            dataGridViewAnomalias.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(57, 40);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 1;
            labelId.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 130);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 187);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Anomalias";
            // 
            // labelDenunciante
            // 
            labelDenunciante.AutoSize = true;
            labelDenunciante.Location = new Point(57, 77);
            labelDenunciante.Name = "labelDenunciante";
            labelDenunciante.Size = new Size(92, 20);
            labelDenunciante.TabIndex = 5;
            labelDenunciante.Text = "Denunciante";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(172, 33);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(200, 27);
            textBoxId.TabIndex = 7;
            textBoxId.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(172, 130);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(200, 27);
            textBoxDireccion.TabIndex = 10;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(386, 467);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(534, 467);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(213, 29);
            buttonAceptar.TabIndex = 12;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(653, 345);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(94, 29);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(524, 345);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(504, 413);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 15;
            label6.Text = "Dificultad";
            // 
            // textBoxComentario
            // 
            textBoxComentario.Location = new Point(160, 434);
            textBoxComentario.Name = "textBoxComentario";
            textBoxComentario.Size = new Size(268, 27);
            textBoxComentario.TabIndex = 16;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(160, 367);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(268, 27);
            textBoxDescripcion.TabIndex = 17;
            // 
            // textBoxDificultad
            // 
            textBoxDificultad.Location = new Point(604, 406);
            textBoxDificultad.Name = "textBoxDificultad";
            textBoxDificultad.ReadOnly = true;
            textBoxDificultad.Size = new Size(125, 27);
            textBoxDificultad.TabIndex = 18;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(57, 370);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 20);
            labelDescripcion.TabIndex = 19;
            labelDescripcion.Text = "Descripcion";
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.Location = new Point(57, 441);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(87, 20);
            labelComentario.TabIndex = 20;
            labelComentario.Text = "Comentario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 130);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 21;
            label7.Text = "Zona";
            // 
            // comboBoxZonas
            // 
            comboBoxZonas.FormattingEnabled = true;
            comboBoxZonas.Location = new Point(504, 130);
            comboBoxZonas.Name = "comboBoxZonas";
            comboBoxZonas.Size = new Size(231, 28);
            comboBoxZonas.TabIndex = 22;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(416, 36);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(47, 20);
            labelFecha.TabIndex = 23;
            labelFecha.Text = "Fecha";
            // 
            // textBoxFecha
            // 
            textBoxFecha.Location = new Point(504, 33);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.ReadOnly = true;
            textBoxFecha.Size = new Size(231, 27);
            textBoxFecha.TabIndex = 24;
            // 
            // labelCazador
            // 
            labelCazador.AutoSize = true;
            labelCazador.Location = new Point(416, 84);
            labelCazador.Name = "labelCazador";
            labelCazador.Size = new Size(64, 20);
            labelCazador.TabIndex = 6;
            labelCazador.Text = "Cazador";
            // 
            // textBoxCazador
            // 
            textBoxCazador.Location = new Point(504, 84);
            textBoxCazador.Name = "textBoxCazador";
            textBoxCazador.ReadOnly = true;
            textBoxCazador.Size = new Size(231, 27);
            textBoxCazador.TabIndex = 25;
            // 
            // textBoxDenunciante
            // 
            textBoxDenunciante.Location = new Point(172, 74);
            textBoxDenunciante.Name = "textBoxDenunciante";
            textBoxDenunciante.ReadOnly = true;
            textBoxDenunciante.Size = new Size(200, 27);
            textBoxDenunciante.TabIndex = 26;
            // 
            // DetallePedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(textBoxDenunciante);
            Controls.Add(textBoxCazador);
            Controls.Add(textBoxFecha);
            Controls.Add(labelFecha);
            Controls.Add(comboBoxZonas);
            Controls.Add(label7);
            Controls.Add(labelComentario);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDificultad);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxComentario);
            Controls.Add(label6);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonAceptar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxId);
            Controls.Add(labelCazador);
            Controls.Add(labelDenunciante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelId);
            Controls.Add(dataGridViewAnomalias);
            Name = "DetallePedidoResolucion";
            Text = "Detalle Pedido";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnomalias).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}