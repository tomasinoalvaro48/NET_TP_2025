namespace WindowsForms.FormsZona
{
    partial class ZonaLista
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
            dataGridViewZonas = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelGrid = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).BeginInit();
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
            tableLayoutPanelMain.Size = new Size(770, 420);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewZonas);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(10);
            panelGrid.Size = new Size(764, 354);
            panelGrid.TabIndex = 0;
            // 
            // dataGridViewZonas
            // 
            dataGridViewZonas.AllowUserToAddRows = false;
            dataGridViewZonas.AllowUserToDeleteRows = false;
            dataGridViewZonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZonas.Dock = DockStyle.Fill;
            dataGridViewZonas.Location = new Point(10, 10);
            dataGridViewZonas.MultiSelect = false;
            dataGridViewZonas.Name = "dataGridViewZonas";
            dataGridViewZonas.ReadOnly = true;
            dataGridViewZonas.RowHeadersWidth = 51;
            dataGridViewZonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewZonas.Size = new Size(744, 334);
            dataGridViewZonas.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnModificar);
            panelButtons.Controls.Add(btnEliminar);
            panelButtons.Controls.Add(btnAgregar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 363);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(764, 54);
            panelButtons.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.Font = new Font("Segoe UI", 10F);
            btnModificar.Location = new Point(434, 10);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(544, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(654, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ZonaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MinimumSize = new Size(600, 400);
            Controls.Add(tableLayoutPanelMain);
            Name = "ZonaLista";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zonas";
            Load += ZonaLista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewZonas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelGrid;
        private Panel panelButtons;
    }
}