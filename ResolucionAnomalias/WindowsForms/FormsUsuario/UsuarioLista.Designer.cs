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
            usuariosDataGridView.Location = new Point(15, 78);
            usuariosDataGridView.Margin = new Padding(6, 6, 6, 6);
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.RowHeadersWidth = 82;
            usuariosDataGridView.Size = new Size(1442, 644);
            usuariosDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(1311, 734);
            agregarButton.Margin = new Padding(6, 6, 6, 6);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(139, 49);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(1160, 734);
            eliminarButton.Margin = new Padding(6, 6, 6, 6);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(139, 49);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(1009, 734);
            modificarButton.Margin = new Padding(6, 6, 6, 6);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(139, 49);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // buscarTextBox
            // 
            buscarTextBox.Location = new Point(15, 21);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.PlaceholderText = "Buscar por nombre, apellido o email...";
            buscarTextBox.Size = new Size(748, 39);
            buscarTextBox.TabIndex = 4;
            // 
            // buscarButton
            // 
            buscarButton.Location = new Point(785, 17);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(150, 46);
            buscarButton.TabIndex = 5;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += BuscarButton_Click;
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 798);
            Controls.Add(buscarButton);
            Controls.Add(buscarTextBox);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(usuariosDataGridView);
            Margin = new Padding(6, 6, 6, 6);
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