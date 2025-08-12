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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTiposAnomalia
            // 
            dataGridViewTiposAnomalia.AllowUserToAddRows = false;
            dataGridViewTiposAnomalia.AllowUserToDeleteRows = false;
            dataGridViewTiposAnomalia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiposAnomalia.Location = new Point(42, 37);
            dataGridViewTiposAnomalia.Name = "dataGridViewTiposAnomalia";
            dataGridViewTiposAnomalia.ReadOnly = true;
            dataGridViewTiposAnomalia.RowHeadersWidth = 82;
            dataGridViewTiposAnomalia.Size = new Size(903, 433);
            dataGridViewTiposAnomalia.TabIndex = 0;
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
            Text = "Lista Tipo de Anomalía";
            Load += TipoAnomalia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposAnomalia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTiposAnomalia;
        private Button buttonEliminarListTipo;
        private Button buttonModificarListTipo;
        private Button buttonAgregarListTipoAnomalia;
    }
}