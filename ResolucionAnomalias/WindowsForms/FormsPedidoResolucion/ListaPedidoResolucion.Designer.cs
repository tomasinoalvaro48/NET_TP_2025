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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelGrid = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelGrid.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewPedidos.AllowUserToDeleteRows = false;
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Dock = DockStyle.Fill;
            dataGridViewPedidos.Location = new Point(9, 8);
            dataGridViewPedidos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPedidos.MultiSelect = false;
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPedidos.Size = new Size(688, 265);
            dataGridViewPedidos.TabIndex = 0;
            dataGridViewPedidos.DataBindingComplete += DataGridViewPedidos_DataBindingComplete;
            dataGridViewPedidos.SelectionChanged += DataGridViewPedidos_SelectionChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregar.Font = new Font("Segoe UI", 10F);
            buttonAgregar.Location = new Point(557, 8);
            buttonAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(140, 26);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Realizar Pedido";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Segoe UI", 10F);
            buttonModificar.Location = new Point(333, 8);
            buttonModificar.Margin = new Padding(3, 2, 3, 2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(157, 26);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Tomar Pedido";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 10F);
            buttonEliminar.Location = new Point(11, 8);
            buttonEliminar.Margin = new Padding(3, 2, 3, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(105, 26);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizarPedido
            // 
            buttonFinalizarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFinalizarPedido.Font = new Font("Segoe UI", 10F);
            buttonFinalizarPedido.Location = new Point(408, 8);
            buttonFinalizarPedido.Margin = new Padding(3, 2, 3, 2);
            buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            buttonFinalizarPedido.Size = new Size(140, 26);
            buttonFinalizarPedido.TabIndex = 4;
            buttonFinalizarPedido.Text = "Finalizar Pedido";
            buttonFinalizarPedido.UseVisualStyleBackColor = true;
            buttonFinalizarPedido.Click += buttonFinalizarPedido_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelGrid, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(13, 11);
            tableLayoutPanelMain.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(712, 329);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewPedidos);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 2);
            panelGrid.Margin = new Padding(3, 2, 3, 2);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(9, 8, 9, 8);
            panelGrid.Size = new Size(706, 281);
            panelGrid.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminar);
            panelButtons.Controls.Add(buttonModificar);
            panelButtons.Controls.Add(buttonFinalizarPedido);
            panelButtons.Controls.Add(buttonAgregar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 287);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(9, 8, 9, 8);
            panelButtons.Size = new Size(706, 40);
            panelButtons.TabIndex = 1;
            // 
            // ListaPedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 351);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaPedidoResolucion";
            Padding = new Padding(13, 11, 13, 11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos Resolucion";
            Load += ListaPedidoResolucion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPedidos;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonFinalizarPedido;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelGrid;
        private Panel panelButtons;
    }
}