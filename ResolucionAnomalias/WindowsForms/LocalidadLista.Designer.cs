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
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLocalidades
            // 
            dataGridViewLocalidades.AllowUserToOrderColumns = true;
            dataGridViewLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalidades.Location = new Point(43, 47);
            dataGridViewLocalidades.MultiSelect = false;
            dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            dataGridViewLocalidades.ReadOnly = true;
            dataGridViewLocalidades.RowHeadersWidth = 51;
            dataGridViewLocalidades.RowTemplate.Height = 41;
            dataGridViewLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocalidades.Size = new Size(713, 288);
            dataGridViewLocalidades.TabIndex = 0;
            dataGridViewLocalidades.CellContentClick += dataGridViewLocalidades_CellContentClick;
            // 
            // buttonAgregarListLoc
            // 
            buttonAgregarListLoc.Location = new Point(662, 370);
            buttonAgregarListLoc.Name = "buttonAgregarListLoc";
            buttonAgregarListLoc.Size = new Size(94, 29);
            buttonAgregarListLoc.TabIndex = 1;
            buttonAgregarListLoc.Text = "Agregar";
            buttonAgregarListLoc.UseVisualStyleBackColor = true;
            buttonAgregarListLoc.Click += agregarButton_Click;
            // 
            // buttonModificarListLoc
            // 
            buttonModificarListLoc.Location = new Point(532, 370);
            buttonModificarListLoc.Name = "buttonModificarListLoc";
            buttonModificarListLoc.Size = new Size(94, 29);
            buttonModificarListLoc.TabIndex = 2;
            buttonModificarListLoc.Text = "Modificar";
            buttonModificarListLoc.UseVisualStyleBackColor = true;
            buttonModificarListLoc.Click += modificarButton_Click;
            // 
            // buttonEliminarListLoc
            // 
            buttonEliminarListLoc.Location = new Point(400, 370);
            buttonEliminarListLoc.Name = "buttonEliminarListLoc";
            buttonEliminarListLoc.Size = new Size(94, 29);
            buttonEliminarListLoc.TabIndex = 3;
            buttonEliminarListLoc.Text = "Eliminar";
            buttonEliminarListLoc.UseVisualStyleBackColor = true;
            buttonEliminarListLoc.Click += eliminarButton_Click;
            // 
            // LocalidadLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEliminarListLoc);
            Controls.Add(buttonModificarListLoc);
            Controls.Add(buttonAgregarListLoc);
            Controls.Add(dataGridViewLocalidades);
            Name = "LocalidadLista";
            Text = "Localidades";
            Load += Localidades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dataGridViewLocalidades;
        private Button buttonAgregarListLoc;
        private Button buttonModificarListLoc;
        private Button buttonEliminarListLoc;
    }
}