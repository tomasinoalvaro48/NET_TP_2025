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
            pedidosAgregacionDataGridView.Location = new Point(9, 8);
            pedidosAgregacionDataGridView.Margin = new Padding(3, 2, 3, 2);
            pedidosAgregacionDataGridView.MultiSelect = false;
            pedidosAgregacionDataGridView.Name = "pedidosAgregacionDataGridView";
            pedidosAgregacionDataGridView.ReadOnly = true;
            pedidosAgregacionDataGridView.RowHeadersWidth = 51;
            pedidosAgregacionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pedidosAgregacionDataGridView.Size = new Size(688, 265);
            pedidosAgregacionDataGridView.TabIndex = 0;
            pedidosAgregacionDataGridView.DataBindingComplete += pedidosAgregacionDataGridView_DataBindingComplete;
            pedidosAgregacionDataGridView.SelectionChanged += pedidosAgregacionDataGridView_SelectionChanged;
            // 
            // agregarButton
            // 
            agregarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            agregarButton.Font = new Font("Segoe UI", 10F);
            agregarButton.Location = new Point(601, 8);
            agregarButton.Margin = new Padding(3, 2, 3, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(96, 26);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Nuevo";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modificarButton.Font = new Font("Segoe UI", 10F);
            modificarButton.Location = new Point(496, 8);
            modificarButton.Margin = new Padding(3, 2, 3, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(96, 26);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            eliminarButton.Font = new Font("Segoe UI", 10F);
            eliminarButton.Location = new Point(400, 8);
            eliminarButton.Margin = new Padding(3, 2, 3, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(87, 26);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Font = new Font("Segoe UI", 10F);
            buttonAceptar.Location = new Point(108, 8);
            buttonAceptar.Margin = new Padding(3, 2, 3, 2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(87, 26);
            buttonAceptar.TabIndex = 4;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonRechazar
            // 
            buttonRechazar.Font = new Font("Segoe UI", 10F);
            buttonRechazar.Location = new Point(11, 8);
            buttonRechazar.Margin = new Padding(3, 2, 3, 2);
            buttonRechazar.Name = "buttonRechazar";
            buttonRechazar.Size = new Size(87, 26);
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
            panelGrid.Controls.Add(pedidosAgregacionDataGridView);
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
            panelButtons.Controls.Add(buttonRechazar);
            panelButtons.Controls.Add(buttonAceptar);
            panelButtons.Controls.Add(eliminarButton);
            panelButtons.Controls.Add(modificarButton);
            panelButtons.Controls.Add(agregarButton);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 287);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(9, 8, 9, 8);
            panelButtons.Size = new Size(706, 40);
            panelButtons.TabIndex = 1;
            // 
            // PedidoAgregacionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 351);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidoAgregacionLista";
            Padding = new Padding(13, 11, 13, 11);
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