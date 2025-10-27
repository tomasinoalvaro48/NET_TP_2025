namespace WindowsForms.FormsPedidoResolucion
{
    partial class ListaPedidoResolucion
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
            dataGridViewPedidos = new DataGridView();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonFinalizarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(71, 47);
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.Size = new Size(956, 337);
            dataGridViewPedidos.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(1101, 431);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(193, 29);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Realizar Pedido";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(449, 431);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(197, 29);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Tomar Pedido";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(71, 431);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(107, 29);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizarPedido
            // 
            buttonFinalizarPedido.Location = new Point(682, 431);
            buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            buttonFinalizarPedido.Size = new Size(213, 29);
            buttonFinalizarPedido.TabIndex = 4;
            buttonFinalizarPedido.Text = "Finalizar Pedido";
            buttonFinalizarPedido.UseVisualStyleBackColor = true;
            buttonFinalizarPedido.Click += buttonFinalizarPedido_Click;
            // 
            // ListaPedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 490);
            Controls.Add(buttonFinalizarPedido);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(dataGridViewPedidos);
            Name = "ListaPedidoResolucion";
            Text = "Pedidos Resolucion";
            Load += ListaPedidoResolucion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPedidos;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonFinalizarPedido;
    }
}