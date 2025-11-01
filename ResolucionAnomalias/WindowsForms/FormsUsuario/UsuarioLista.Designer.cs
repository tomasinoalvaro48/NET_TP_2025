namespace WindowsForms.FormsUsuario
{
    partial class UsuarioLista
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
            usuariosDataGridView = new DataGridView();
            buscarTextBox = new TextBox();
            buscarButton = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelSearch = new Panel();
            panelGrid = new Panel();
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelSearch.SuspendLayout();
            panelGrid.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelGrid, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(970, 520);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buscarTextBox);
            panelSearch.Controls.Add(buscarButton);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(10);
            panelSearch.Size = new Size(964, 60);
            panelSearch.TabIndex = 0;
            // 
            // buscarTextBox
            // 
            buscarTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buscarTextBox.Font = new Font("Segoe UI", 10F);
            buscarTextBox.Location = new Point(13, 15);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.PlaceholderText = "Buscar por nombre, apellido o email...";
            buscarTextBox.Size = new Size(798, 30);
            buscarTextBox.TabIndex = 4;
            // 
            // buscarButton
            // 
            buscarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buscarButton.Font = new Font("Segoe UI", 10F);
            buscarButton.Location = new Point(821, 13);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(130, 35);
            buscarButton.TabIndex = 5;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += BuscarButton_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(usuariosDataGridView);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 69);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(10);
            panelGrid.Size = new Size(964, 448);
            panelGrid.TabIndex = 1;
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.AllowUserToAddRows = false;
            usuariosDataGridView.AllowUserToDeleteRows = false;
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Dock = DockStyle.Fill;
            usuariosDataGridView.Location = new Point(10, 10);
            usuariosDataGridView.MultiSelect = false;
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.ReadOnly = true;
            usuariosDataGridView.RowHeadersWidth = 51;
            usuariosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usuariosDataGridView.Size = new Size(944, 428);
            usuariosDataGridView.TabIndex = 0;
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            MinimumSize = new Size(800, 500);
            Controls.Add(tableLayoutPanelMain);
            Name = "UsuarioLista";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Usuarios";
            Load += UsuarioLista_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usuariosDataGridView;
        private TextBox buscarTextBox;
        private Button buscarButton;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelSearch;
        private Panel panelGrid;
    }
}