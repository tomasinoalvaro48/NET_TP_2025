namespace WindowsForms.FormsTipoAnomalia
{
    partial class TipoAnomaliaLista
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
            dataGridViewTiposAnomalia = new DataGridView();
            buttonEliminarListTipo = new Button();
            buttonModificarListTipo = new Button();
            buttonAgregarListTipoAnomalia = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelGrid = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).BeginInit();
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
            tableLayoutPanelMain.Size = new Size(870, 520);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewTiposAnomalia);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(10);
            panelGrid.Size = new Size(864, 454);
            panelGrid.TabIndex = 0;
            // 
            // dataGridViewTiposAnomalia
            // 
            dataGridViewTiposAnomalia.AllowUserToAddRows = false;
            dataGridViewTiposAnomalia.AllowUserToDeleteRows = false;
            dataGridViewTiposAnomalia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiposAnomalia.Dock = DockStyle.Fill;
            dataGridViewTiposAnomalia.Location = new Point(10, 10);
            dataGridViewTiposAnomalia.MultiSelect = false;
            dataGridViewTiposAnomalia.Name = "dataGridViewTiposAnomalia";
            dataGridViewTiposAnomalia.ReadOnly = true;
            dataGridViewTiposAnomalia.RowHeadersWidth = 51;
            dataGridViewTiposAnomalia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposAnomalia.Size = new Size(844, 434);
            dataGridViewTiposAnomalia.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminarListTipo);
            panelButtons.Controls.Add(buttonModificarListTipo);
            panelButtons.Controls.Add(buttonAgregarListTipoAnomalia);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 463);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(864, 54);
            panelButtons.TabIndex = 1;
            // 
            // buttonEliminarListTipo
            // 
            buttonEliminarListTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminarListTipo.Font = new Font("Segoe UI", 10F);
            buttonEliminarListTipo.Location = new Point(534, 10);
            buttonEliminarListTipo.Name = "buttonEliminarListTipo";
            buttonEliminarListTipo.Size = new Size(100, 35);
            buttonEliminarListTipo.TabIndex = 6;
            buttonEliminarListTipo.Text = "Eliminar";
            buttonEliminarListTipo.UseVisualStyleBackColor = true;
            buttonEliminarListTipo.Click += buttonEliminarListTipo_Click;
            // 
            // buttonModificarListTipo
            // 
            buttonModificarListTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModificarListTipo.Font = new Font("Segoe UI", 10F);
            buttonModificarListTipo.Location = new Point(644, 10);
            buttonModificarListTipo.Name = "buttonModificarListTipo";
            buttonModificarListTipo.Size = new Size(100, 35);
            buttonModificarListTipo.TabIndex = 5;
            buttonModificarListTipo.Text = "Modificar";
            buttonModificarListTipo.UseVisualStyleBackColor = true;
            buttonModificarListTipo.Click += buttonModificarListTipo_Click;
            // 
            // buttonAgregarListTipoAnomalia
            // 
            buttonAgregarListTipoAnomalia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregarListTipoAnomalia.Font = new Font("Segoe UI", 10F);
            buttonAgregarListTipoAnomalia.Location = new Point(754, 10);
            buttonAgregarListTipoAnomalia.Name = "buttonAgregarListTipoAnomalia";
            buttonAgregarListTipoAnomalia.Size = new Size(100, 35);
            buttonAgregarListTipoAnomalia.TabIndex = 4;
            buttonAgregarListTipoAnomalia.Text = "Agregar";
            buttonAgregarListTipoAnomalia.UseVisualStyleBackColor = true;
            buttonAgregarListTipoAnomalia.Click += buttonAgregarListTipoAnomalia_Click;
            // 
            // TipoAnomaliaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            MinimumSize = new Size(700, 500);
            Controls.Add(tableLayoutPanelMain);
            Name = "TipoAnomaliaLista";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Tipo de Anomalía";
            Load += TipoAnomalia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTiposAnomalia;
        private Button buttonEliminarListTipo;
        private Button buttonModificarListTipo;
        private Button buttonAgregarListTipoAnomalia;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelGrid;
        private Panel panelButtons;
    }
}