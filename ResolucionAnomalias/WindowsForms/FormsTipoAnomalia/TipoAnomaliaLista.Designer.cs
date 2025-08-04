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
            Cod_anom = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Dif_anom = new DataGridViewTextBoxColumn();
            buttonEliminarListTipo = new Button();
            buttonModificarListTipo = new Button();
            buttonAgregarListTipoAnomalia = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTiposAnomalia
            // 
            dataGridViewTiposAnomalia.AllowUserToAddRows = false;
            dataGridViewTiposAnomalia.AllowUserToDeleteRows = false;
            dataGridViewTiposAnomalia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiposAnomalia.Columns.AddRange(new DataGridViewColumn[] { Cod_anom, Nombre, Dif_anom });
            dataGridViewTiposAnomalia.Location = new Point(42, 37);
            dataGridViewTiposAnomalia.Name = "dataGridViewTiposAnomalia";
            dataGridViewTiposAnomalia.ReadOnly = true;
            dataGridViewTiposAnomalia.RowHeadersWidth = 82;
            dataGridViewTiposAnomalia.Size = new Size(824, 388);
            dataGridViewTiposAnomalia.TabIndex = 0;
            // 
            // Cod_anom
            // 
            Cod_anom.Frozen = true;
            Cod_anom.HeaderText = "Código";
            Cod_anom.MinimumWidth = 10;
            Cod_anom.Name = "Cod_anom";
            Cod_anom.ReadOnly = true;
            Cod_anom.Width = 200;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre_anom";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Dif_anom
            // 
            Dif_anom.Frozen = true;
            Dif_anom.HeaderText = "Dificultad";
            Dif_anom.MinimumWidth = 10;
            Dif_anom.Name = "Dif_anom";
            Dif_anom.ReadOnly = true;
            Dif_anom.Width = 200;
            // 
            // buttonEliminarListTipo
            // 
            buttonEliminarListTipo.Location = new Point(495, 505);
            buttonEliminarListTipo.Margin = new Padding(5);
            buttonEliminarListTipo.Name = "buttonEliminarListTipo";
            buttonEliminarListTipo.Size = new Size(153, 46);
            buttonEliminarListTipo.TabIndex = 6;
            buttonEliminarListTipo.Text = "Eliminar";
            buttonEliminarListTipo.UseVisualStyleBackColor = true;
            buttonEliminarListTipo.Click += buttonEliminarListTipo_Click;
            // 
            // buttonModificarListTipo
            // 
            buttonModificarListTipo.Location = new Point(658, 505);
            buttonModificarListTipo.Margin = new Padding(5);
            buttonModificarListTipo.Name = "buttonModificarListTipo";
            buttonModificarListTipo.Size = new Size(153, 46);
            buttonModificarListTipo.TabIndex = 5;
            buttonModificarListTipo.Text = "Modificar";
            buttonModificarListTipo.UseVisualStyleBackColor = true;
            buttonModificarListTipo.Click += buttonModificarListTipo_Click;
            // 
            // buttonAgregarListTipoAnomalia
            // 
            buttonAgregarListTipoAnomalia.Location = new Point(821, 505);
            buttonAgregarListTipoAnomalia.Margin = new Padding(5);
            buttonAgregarListTipoAnomalia.Name = "buttonAgregarListTipoAnomalia";
            buttonAgregarListTipoAnomalia.Size = new Size(153, 46);
            buttonAgregarListTipoAnomalia.TabIndex = 4;
            buttonAgregarListTipoAnomalia.Text = "Agregar";
            buttonAgregarListTipoAnomalia.UseVisualStyleBackColor = true;
            buttonAgregarListTipoAnomalia.Click += buttonAgregarListTipoAnomalia_Click;
            // 
            // TipoAnomaliaLista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 565);
            Controls.Add(buttonEliminarListTipo);
            Controls.Add(buttonModificarListTipo);
            Controls.Add(buttonAgregarListTipoAnomalia);
            Controls.Add(dataGridViewTiposAnomalia);
            Name = "TipoAnomaliaLista";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTiposAnomalia;
        private DataGridViewTextBoxColumn Cod_anom;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Dif_anom;
        private Button buttonEliminarListTipo;
        private Button buttonModificarListTipo;
        private Button buttonAgregarListTipoAnomalia;
    }
}