namespace WindowsForms
{
    partial class LocalidadLista
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
            dataGridViewLocalidades = new DataGridView();
            buttonAgregarListLoc = new Button();
            buttonModificarListLoc = new Button();
            buttonEliminarListLoc = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelGrid = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelGrid.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewLocalidades
            // 
            dataGridViewLocalidades.AllowUserToAddRows = false;
            dataGridViewLocalidades.AllowUserToDeleteRows = false;
            dataGridViewLocalidades.AllowUserToOrderColumns = true;
            dataGridViewLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalidades.Dock = DockStyle.Fill;
            dataGridViewLocalidades.Location = new Point(9, 8);
            dataGridViewLocalidades.Margin = new Padding(3, 2, 3, 2);
            dataGridViewLocalidades.MultiSelect = false;
            dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            dataGridViewLocalidades.ReadOnly = true;
            dataGridViewLocalidades.RowHeadersWidth = 51;
            dataGridViewLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocalidades.Size = new Size(650, 252);
            dataGridViewLocalidades.TabIndex = 0;
            dataGridViewLocalidades.CellContentClick += dataGridViewLocalidades_CellContentClick;
            // 
            // buttonAgregarListLoc
            // 
            buttonAgregarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregarListLoc.Font = new Font("Segoe UI", 10F);
            buttonAgregarListLoc.Location = new Point(572, 8);
            buttonAgregarListLoc.Margin = new Padding(3, 2, 3, 2);
            buttonAgregarListLoc.Name = "buttonAgregarListLoc";
            buttonAgregarListLoc.Size = new Size(88, 26);
            buttonAgregarListLoc.TabIndex = 1;
            buttonAgregarListLoc.Text = "Agregar";
            buttonAgregarListLoc.UseVisualStyleBackColor = true;
            buttonAgregarListLoc.Click += agregarButton_Click;
            // 
            // buttonModificarListLoc
            // 
            buttonModificarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModificarListLoc.Font = new Font("Segoe UI", 10F);
            buttonModificarListLoc.Location = new Point(476, 8);
            buttonModificarListLoc.Margin = new Padding(3, 2, 3, 2);
            buttonModificarListLoc.Name = "buttonModificarListLoc";
            buttonModificarListLoc.Size = new Size(88, 26);
            buttonModificarListLoc.TabIndex = 2;
            buttonModificarListLoc.Text = "Modificar";
            buttonModificarListLoc.UseVisualStyleBackColor = true;
            buttonModificarListLoc.Click += modificarButton_Click;
            // 
            // buttonEliminarListLoc
            // 
            buttonEliminarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminarListLoc.Font = new Font("Segoe UI", 10F);
            buttonEliminarListLoc.Location = new Point(380, 8);
            buttonEliminarListLoc.Margin = new Padding(3, 2, 3, 2);
            buttonEliminarListLoc.Name = "buttonEliminarListLoc";
            buttonEliminarListLoc.Size = new Size(88, 26);
            buttonEliminarListLoc.TabIndex = 3;
            buttonEliminarListLoc.Text = "Eliminar";
            buttonEliminarListLoc.UseVisualStyleBackColor = true;
            buttonEliminarListLoc.Click += eliminarButton_Click;
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
            tableLayoutPanelMain.Size = new Size(674, 316);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewLocalidades);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 2);
            panelGrid.Margin = new Padding(3, 2, 3, 2);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(9, 8, 9, 8);
            panelGrid.Size = new Size(668, 268);
            panelGrid.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminarListLoc);
            panelButtons.Controls.Add(buttonModificarListLoc);
            panelButtons.Controls.Add(buttonAgregarListLoc);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 274);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(9, 8, 9, 8);
            panelButtons.Size = new Size(668, 40);
            panelButtons.TabIndex = 1;
            // 
            // LocalidadLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LocalidadLista";
            Padding = new Padding(13, 11, 13, 11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localidades";
            Load += Localidades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLocalidades;
        private Button buttonAgregarListLoc;
        private Button buttonModificarListLoc;
        private Button buttonEliminarListLoc;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelGrid;
        private Panel panelButtons;
    }
}