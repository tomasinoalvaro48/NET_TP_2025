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
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelGrid, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(1170, 520);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewPedidos);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(10);
            panelGrid.Size = new Size(1164, 454);
            panelGrid.TabIndex = 0;
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewPedidos.AllowUserToDeleteRows = false;
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Dock = DockStyle.Fill;
            dataGridViewPedidos.Location = new Point(10, 10);
            dataGridViewPedidos.MultiSelect = false;
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPedidos.Size = new Size(1144, 434);
            dataGridViewPedidos.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminar);
            panelButtons.Controls.Add(buttonModificar);
            panelButtons.Controls.Add(buttonFinalizarPedido);
            panelButtons.Controls.Add(buttonAgregar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 463);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(1164, 54);
            panelButtons.TabIndex = 1;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 10F);
            buttonEliminar.Location = new Point(13, 10);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(120, 35);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonModificar.Font = new Font("Segoe UI", 10F);
            buttonModificar.Location = new Point(380, 10);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(180, 35);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Tomar Pedido";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonFinalizarPedido
            // 
            buttonFinalizarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFinalizarPedido.Font = new Font("Segoe UI", 10F);
            buttonFinalizarPedido.Location = new Point(824, 10);
            buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            buttonFinalizarPedido.Size = new Size(160, 35);
            buttonFinalizarPedido.TabIndex = 4;
            buttonFinalizarPedido.Text = "Finalizar Pedido";
            buttonFinalizarPedido.UseVisualStyleBackColor = true;
            buttonFinalizarPedido.Click += buttonFinalizarPedido_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregar.Font = new Font("Segoe UI", 10F);
            buttonAgregar.Location = new Point(994, 10);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(160, 35);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Realizar Pedido";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // ListaPedidoResolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 550);
            MinimumSize = new Size(900, 500);
            Controls.Add(tableLayoutPanelMain);
            Name = "ListaPedidoResolucion";
            Padding = new Padding(15);
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