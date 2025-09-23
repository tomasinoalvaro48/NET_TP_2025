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
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Location = new Point(46, 28);
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.Size = new Size(670, 236);
            usuariosDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(569, 294);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(466, 294);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(367, 294);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 374);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(usuariosDataGridView);
            Name = "UsuarioLista";
            Text = "UsuarioLista";
            Load += UsuarioLista_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usuariosDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}