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
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewZonas
            // 
            dataGridViewZonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZonas.Location = new Point(81, 47);
            dataGridViewZonas.Name = "dataGridViewZonas";
            dataGridViewZonas.RowHeadersWidth = 51;
            dataGridViewZonas.Size = new Size(700, 301);
            dataGridViewZonas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(622, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(510, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(398, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // ZonaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewZonas);
            Name = "ZonaLista";
            Text = "ZonaLista";
            Load += ZonaLista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewZonas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}