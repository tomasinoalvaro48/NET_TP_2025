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
            dataGridViewPedidos.Location = new Point(16, 16);
            dataGridViewPedidos.Margin = new Padding(5);
            dataGridViewPedidos.MultiSelect = false;
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPedidos.Size = new Size(1860, 694);
            dataGridViewPedidos.TabIndex = 0;
            dataGridViewPedidos.DataBindingComplete += DataGridViewPedidos_DataBindingComplete;
            dataGridViewPedidos.SelectionChanged += DataGridViewPedidos_SelectionChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregar.Font = new Font("Segoe UI", 10F);
            buttonAgregar.Location = new Point(1615, 16);
            buttonAgregar.Margin = new Padding(5);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(260, 56);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Realizar Pedido";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Segoe UI", 10F);
            buttonModificar.Location = new Point(618, 16);
            buttonModificar.Margin = new Padding(5);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(292, 56);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Tomar Pedido";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 10F);
            buttonEliminar.Location = new Point(21, 16);
            buttonEliminar.Margin = new Padding(5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(195, 56);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizarPedido
            // 
            buttonFinalizarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFinalizarPedido.Font = new Font("Segoe UI", 10F);
            buttonFinalizarPedido.Location = new Point(1339, 16);
            buttonFinalizarPedido.Margin = new Padding(5);
            buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            buttonFinalizarPedido.Size = new Size(260, 56);
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
            tableLayoutPanelMain.Location = new Point(24, 24);
            tableLayoutPanelMain.Margin = new Padding(5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1902, 832);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewPedidos);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(5, 5);
            panelGrid.Margin = new Padding(5);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16);
            panelGrid.Size = new Size(1892, 726);
            panelGrid.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminar);
            panelButtons.Controls.Add(buttonModificar);
            panelButtons.Controls.Add(buttonFinalizarPedido);
            panelButtons.Controls.Add(buttonAgregar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 741);
            panelButtons.Margin = new Padding(5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(16);
            panelButtons.Size = new Size(1892, 86);
            panelButtons.TabIndex = 1;
            // 
            // ListaPedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1950, 880);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5);
            MinimumSize = new Size(1446, 757);
            Name = "ListaPedidoResolucion";
            Padding = new Padding(24);
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