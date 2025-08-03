namespace WindowsForms
{
    partial class DenunciantesLista
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
            denunciantesDataGridView = new DataGridView();
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)denunciantesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // denunciantesDataGridView
            // 
            denunciantesDataGridView.AllowUserToOrderColumns = true;
            denunciantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            denunciantesDataGridView.Location = new Point(24, 24);
            denunciantesDataGridView.Margin = new Padding(2, 1, 2, 1);
            denunciantesDataGridView.MultiSelect = false;
            denunciantesDataGridView.Name = "denunciantesDataGridView";
            denunciantesDataGridView.ReadOnly = true;
            denunciantesDataGridView.RowHeadersWidth = 82;
            denunciantesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            denunciantesDataGridView.Size = new Size(858, 360);
            denunciantesDataGridView.TabIndex = 0;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(578, 400);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(93, 29);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(683, 400);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(93, 29);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(790, 400);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(93, 29);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // DenunciantesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 468);
            Controls.Add(agregarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(denunciantesDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DenunciantesLista";
            Text = "Denunciantes";
            Load += Denunciantes_Load;
            ((System.ComponentModel.ISupportInitialize)denunciantesDataGridView).EndInit();
            ResumeLayout(false);
        }

        private void DenunciantesLista_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView denunciantesDataGridView;
        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
    }
}