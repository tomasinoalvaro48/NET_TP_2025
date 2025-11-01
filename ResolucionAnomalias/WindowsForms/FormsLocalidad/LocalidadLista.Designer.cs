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
            panelGrid.Controls.Add(dataGridViewLocalidades);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(3, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(10);
            panelGrid.Size = new Size(764, 354);
            panelGrid.TabIndex = 0;
            // 
            // dataGridViewLocalidades
            // 
            dataGridViewLocalidades.AllowUserToAddRows = false;
            dataGridViewLocalidades.AllowUserToDeleteRows = false;
            dataGridViewLocalidades.AllowUserToOrderColumns = true;
            dataGridViewLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalidades.Dock = DockStyle.Fill;
            dataGridViewLocalidades.Location = new Point(10, 10);
            dataGridViewLocalidades.MultiSelect = false;
            dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            dataGridViewLocalidades.ReadOnly = true;
            dataGridViewLocalidades.RowHeadersWidth = 51;
            dataGridViewLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocalidades.Size = new Size(744, 334);
            dataGridViewLocalidades.TabIndex = 0;
            dataGridViewLocalidades.CellContentClick += dataGridViewLocalidades_CellContentClick;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEliminarListLoc);
            panelButtons.Controls.Add(buttonModificarListLoc);
            panelButtons.Controls.Add(buttonAgregarListLoc);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 363);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(764, 54);
            panelButtons.TabIndex = 1;
            // 
            // buttonEliminarListLoc
            // 
            buttonEliminarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminarListLoc.Font = new Font("Segoe UI", 10F);
            buttonEliminarListLoc.Location = new Point(434, 10);
            buttonEliminarListLoc.Name = "buttonEliminarListLoc";
            buttonEliminarListLoc.Size = new Size(100, 35);
            buttonEliminarListLoc.TabIndex = 3;
            buttonEliminarListLoc.Text = "Eliminar";
            buttonEliminarListLoc.UseVisualStyleBackColor = true;
            buttonEliminarListLoc.Click += eliminarButton_Click;
            // 
            // buttonModificarListLoc
            // 
            buttonModificarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModificarListLoc.Font = new Font("Segoe UI", 10F);
            buttonModificarListLoc.Location = new Point(544, 10);
            buttonModificarListLoc.Name = "buttonModificarListLoc";
            buttonModificarListLoc.Size = new Size(100, 35);
            buttonModificarListLoc.TabIndex = 2;
            buttonModificarListLoc.Text = "Modificar";
            buttonModificarListLoc.UseVisualStyleBackColor = true;
            buttonModificarListLoc.Click += modificarButton_Click;
            // 
            // buttonAgregarListLoc
            // 
            buttonAgregarListLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregarListLoc.Font = new Font("Segoe UI", 10F);
            buttonAgregarListLoc.Location = new Point(654, 10);
            buttonAgregarListLoc.Name = "buttonAgregarListLoc";
            buttonAgregarListLoc.Size = new Size(100, 35);
            buttonAgregarListLoc.TabIndex = 1;
            buttonAgregarListLoc.Text = "Agregar";
            buttonAgregarListLoc.UseVisualStyleBackColor = true;
            buttonAgregarListLoc.Click += agregarButton_Click;
            // 
            // LocalidadLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            MinimumSize = new Size(600, 400);
            Controls.Add(tableLayoutPanelMain);
            Name = "LocalidadLista";
            Padding = new Padding(15);
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