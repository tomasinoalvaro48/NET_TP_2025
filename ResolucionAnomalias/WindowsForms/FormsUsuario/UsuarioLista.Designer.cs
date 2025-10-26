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
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            buscarTextBox = new TextBox();
            buscarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Location = new Point(8, 37);
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.RowHeadersWidth = 82;
            usuariosDataGridView.Size = new Size(776, 302);
            usuariosDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(706, 344);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(625, 344);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(543, 344);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // buscarTextBox
            // 
            buscarTextBox.Location = new Point(8, 10);
            buscarTextBox.Margin = new Padding(2, 1, 2, 1);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.PlaceholderText = "Buscar por nombre, apellido o email...";
            buscarTextBox.Size = new Size(405, 23);
            buscarTextBox.TabIndex = 4;
            // 
            // buscarButton
            // 
            buscarButton.Location = new Point(423, 8);
            buscarButton.Margin = new Padding(2, 1, 2, 1);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(81, 22);
            buscarButton.TabIndex = 5;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += BuscarButton_Click;
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 436);
            Controls.Add(buscarButton);
            Controls.Add(buscarTextBox);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(usuariosDataGridView);
            Name = "UsuarioLista";
            Text = "UsuarioLista";
            Load += UsuarioLista_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usuariosDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private TextBox buscarTextBox;
        private Button buscarButton;
    }
}