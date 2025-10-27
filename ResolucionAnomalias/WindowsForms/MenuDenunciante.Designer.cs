namespace WindowsForms
{
    partial class MenuDenunciante
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
            EnterCRUDTipoAnomaliaButton = new Button();
            logoutButton = new Button();
            label1 = new Label();
            EnterCRUDLocalidadButton = new Button();
            btnCrudZona = new Button();
            EnterCRUDUsuarioButton = new Button();
            label2 = new Label();
            menuStripDenunciante = new MenuStrip();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoToolStripMenuItem = new ToolStripMenuItem();
            menuStripDenunciante.SuspendLayout();
            SuspendLayout();
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(487, 285);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(6);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(312, 107);
            EnterCRUDTipoAnomaliaButton.TabIndex = 0;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(667, 484);
            logoutButton.Margin = new Padding(6);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(251, 49);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 96);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(552, 32);
            label1.TabIndex = 2;
            label1.Text = "(menu temporal hasta que agreguemos el pedido)";
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(811, 166);
            EnterCRUDLocalidadButton.Margin = new Padding(6);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(312, 107);
            EnterCRUDLocalidadButton.TabIndex = 3;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(811, 285);
            btnCrudZona.Margin = new Padding(6);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(312, 107);
            btnCrudZona.TabIndex = 4;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(487, 166);
            EnterCRUDUsuarioButton.Margin = new Padding(6);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(312, 107);
            EnterCRUDUsuarioButton.TabIndex = 5;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 128);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(618, 32);
            label2.TabIndex = 6;
            label2.Text = "(por ahora solo tiene permitido acceder a tipo_anomalia)";
            // 
            // menuStripDenunciante
            // 
            menuStripDenunciante.BackColor = SystemColors.ControlLight;
            menuStripDenunciante.Dock = DockStyle.Left;
            menuStripDenunciante.ImageScalingSize = new Size(32, 32);
            menuStripDenunciante.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMasAjustes, realizarPedidoToolStripMenuItem });
            menuStripDenunciante.Location = new Point(0, 0);
            menuStripDenunciante.Name = "menuStripDenunciante";
            menuStripDenunciante.Size = new Size(246, 559);
            menuStripDenunciante.TabIndex = 8;
            menuStripDenunciante.Text = "menuStripDenunciante";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(233, 36);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(288, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoToolStripMenuItem
            // 
            realizarPedidoToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            realizarPedidoToolStripMenuItem.Size = new Size(223, 36);
            realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            realizarPedidoToolStripMenuItem.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 559);
            Controls.Add(menuStripDenunciante);
            Controls.Add(label2);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDLocalidadButton);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Margin = new Padding(6);
            Name = "MenuDenunciante";
            Text = "Menu Denunciante";
            FormClosing += MenuDenunciante_FormClosing;
            menuStripDenunciante.ResumeLayout(false);
            menuStripDenunciante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDTipoAnomaliaButton;
        private Button logoutButton;
        private Label label1;
        private Button EnterCRUDLocalidadButton;
        private Button btnCrudZona;
        private Button EnterCRUDUsuarioButton;
        private Label label2;
        private MenuStrip menuStripDenunciante;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem realizarPedidoToolStripMenuItem;
    }
}