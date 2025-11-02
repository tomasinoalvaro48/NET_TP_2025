namespace WindowsForms.FormsPedidoAgregacion
{
    partial class PedidoAgregacionLista
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
            pedidosAgregacionDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            buttonAceptar = new Button();
            buttonRechazar = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelGrid = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)pedidosAgregacionDataGridView).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelGrid.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pedidosAgregacionDataGridView
            // 
            pedidosAgregacionDataGridView.AllowUserToAddRows = false;
            pedidosAgregacionDataGridView.AllowUserToDeleteRows = false;
            pedidosAgregacionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pedidosAgregacionDataGridView.Dock = DockStyle.Fill;
            pedidosAgregacionDataGridView.Location = new Point(16, 16);
            pedidosAgregacionDataGridView.Margin = new Padding(5, 5, 5, 5);
            pedidosAgregacionDataGridView.MultiSelect = false;
            pedidosAgregacionDataGridView.Name = "pedidosAgregacionDataGridView";
            pedidosAgregacionDataGridView.ReadOnly = true;
            pedidosAgregacionDataGridView.RowHeadersWidth = 51;
            pedidosAgregacionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pedidosAgregacionDataGridView.Size = new Size(1535, 694);
            pedidosAgregacionDataGridView.TabIndex = 0;
            pedidosAgregacionDataGridView.DataBindingComplete += pedidosAgregacionDataGridView_DataBindingComplete;
            pedidosAgregacionDataGridView.SelectionChanged += pedidosAgregacionDataGridView_SelectionChanged;
            // 
            // agregarButton
            // 
            agregarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            agregarButton.Font = new Font("Segoe UI", 10F);
            agregarButton.Location = new Point(1373, 16);
            agregarButton.Margin = new Padding(5, 5, 5, 5);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(179, 56);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Nuevo";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modificarButton.Font = new Font("Segoe UI", 10F);
            modificarButton.Location = new Point(1177, 16);
            modificarButton.Margin = new Padding(5, 5, 5, 5);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(179, 56);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            eliminarButton.Font = new Font("Segoe UI", 10F);
            eliminarButton.Location = new Point(999, 16);
            eliminarButton.Margin = new Padding(5, 5, 5, 5);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(162, 56);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(200, 16);
            buttonAceptar.Margin = new Padding(5, 5, 5, 5);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(162, 56);
            buttonAceptar.TabIndex = 4;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonRechazar
            // 
            buttonRechazar.Font = new Font("Segoe UI", 10F);
            buttonRechazar.Location = new Point(21, 16);
            buttonRechazar.Margin = new Padding(5, 5, 5, 5);
            buttonRechazar.Name = "buttonRechazar";
            buttonRechazar.Size = new Size(162, 56);
            buttonRechazar.TabIndex = 5;
            buttonRechazar.Text = "Rechazar";
            buttonRechazar.UseVisualStyleBackColor = true;
            buttonRechazar.Click += buttonRechazar_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelGrid, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(24, 24);
            tableLayoutPanelMain.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1577, 832);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(pedidosAgregacionDataGridView);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(5, 5);
            panelGrid.Margin = new Padding(5, 5, 5, 5);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 16, 16, 16);
            panelGrid.Size = new Size(1567, 726);
            panelGrid.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonRechazar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Controls.Add(eliminarButton);
            panelButtons.Controls.Add(modificarButton);
            panelButtons.Controls.Add(agregarButton);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 741);
            panelButtons.Margin = new Padding(5, 5, 5, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(16, 16, 16, 16);
            panelButtons.Size = new Size(1567, 86);
            panelButtons.TabIndex = 1;
            // 
            // PedidoAgregacionLista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 880);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(1284, 757);
            Name = "PedidoAgregacionLista";
            Padding = new Padding(24, 24, 24, 24);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos de agregacion de anomalías";
            Load += PedidosAgregacion_Load;
            ((System.ComponentModel.ISupportInitialize)pedidosAgregacionDataGridView).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pedidosAgregacionDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private Button buttonAceptar;
        private Button buttonRechazar;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelGrid;
        private Panel panelButtons;
    }
}