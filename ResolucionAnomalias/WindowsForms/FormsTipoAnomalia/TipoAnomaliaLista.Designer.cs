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
            // dataGridViewTiposAnomalia
            // 
            dataGridViewTiposAnomalia.AllowUserToAddRows = false;
            dataGridViewTiposAnomalia.AllowUserToDeleteRows = false;
            dataGridViewTiposAnomalia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiposAnomalia.Dock = DockStyle.Fill;
            dataGridViewTiposAnomalia.Location = new Point(9, 8);
            dataGridViewTiposAnomalia.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTiposAnomalia.MultiSelect = false;
            dataGridViewTiposAnomalia.Name = "dataGridViewTiposAnomalia";
            dataGridViewTiposAnomalia.ReadOnly = true;
            dataGridViewTiposAnomalia.RowHeadersWidth = 51;
            dataGridViewTiposAnomalia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposAnomalia.Size = new Size(738, 326);
            dataGridViewTiposAnomalia.TabIndex = 0;
            // 
            // buttonEliminarListTipo
            // 
            buttonEliminarListTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminarListTipo.Font = new Font("Segoe UI", 10F);
            buttonEliminarListTipo.Location = new Point(467, 8);
            buttonEliminarListTipo.Margin = new Padding(3, 2, 3, 2);
            buttonEliminarListTipo.Name = "buttonEliminarListTipo";
            buttonEliminarListTipo.Size = new Size(88, 26);
            buttonEliminarListTipo.TabIndex = 6;
            buttonEliminarListTipo.Text = "Eliminar";
            buttonEliminarListTipo.UseVisualStyleBackColor = true;
            buttonEliminarListTipo.Click += buttonEliminarListTipo_Click;
            // 
            // buttonModificarListTipo
            // 
            buttonModificarListTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModificarListTipo.Font = new Font("Segoe UI", 10F);
            buttonModificarListTipo.Location = new Point(564, 8);
            buttonModificarListTipo.Margin = new Padding(3, 2, 3, 2);
            buttonModificarListTipo.Name = "buttonModificarListTipo";
            buttonModificarListTipo.Size = new Size(88, 26);
            buttonModificarListTipo.TabIndex = 5;
            buttonModificarListTipo.Text = "Modificar";
            buttonModificarListTipo.UseVisualStyleBackColor = true;
            buttonModificarListTipo.Click += buttonModificarListTipo_Click;
            // 
            // buttonAgregarListTipoAnomalia
            // 
            buttonAgregarListTipoAnomalia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregarListTipoAnomalia.Font = new Font("Segoe UI", 10F);
            buttonAgregarListTipoAnomalia.Location = new Point(660, 8);
            buttonAgregarListTipoAnomalia.Margin = new Padding(3, 2, 3, 2);
            buttonAgregarListTipoAnomalia.Name = "buttonAgregarListTipoAnomalia";
            buttonAgregarListTipoAnomalia.Size = new Size(88, 26);
            buttonAgregarListTipoAnomalia.TabIndex = 4;
            buttonAgregarListTipoAnomalia.Text = "Agregar";
            buttonAgregarListTipoAnomalia.UseVisualStyleBackColor = true;
            buttonAgregarListTipoAnomalia.Click += buttonAgregarListTipoAnomalia_Click;
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
            tableLayoutPanelMain.Size = new Size(762, 390);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewTiposAnomalia);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 2);
            panelGrid.Margin = new Padding(3, 2, 3, 2);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(9, 8, 9, 8);
            panelGrid.Size = new Size(756, 342);
            panelGrid.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminarListTipo);
            panelButtons.Controls.Add(buttonModificarListTipo);
            panelButtons.Controls.Add(buttonAgregarListTipoAnomalia);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 348);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(9, 8, 9, 8);
            panelButtons.Size = new Size(756, 40);
            panelButtons.TabIndex = 1;
            // 
            // TipoAnomaliaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 412);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TipoAnomaliaLista";
            Padding = new Padding(13, 11, 13, 11);
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