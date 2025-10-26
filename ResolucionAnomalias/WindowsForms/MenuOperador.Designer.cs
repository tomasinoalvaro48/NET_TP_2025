namespace WindowsForms
{
    partial class MenuOperador
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
            EnterCRUDLocalidadButton = new Button();
            logoutButton = new Button();
            EnterCRUDTipoAnomaliaButton = new Button();
            btnCrudZona = new Button();
            EnterCRUDUsuarioButton = new Button();
            pedidoAgregacionButton = new Button();
            menuStripOperador = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeAnomaliasToolStripMenuItem = new ToolStripMenuItem();
            localidadesToolStripMenuItem = new ToolStripMenuItem();
            zonasToolStripMenuItem = new ToolStripMenuItem();
            pedidosDeAgregacionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStripOperador.SuspendLayout();
            SuspendLayout();
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(306, 379);
            EnterCRUDLocalidadButton.Margin = new Padding(4);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(279, 92);
            EnterCRUDLocalidadButton.TabIndex = 1;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // logoutButton
            // 
            logoutButton.AutoSize = true;
            logoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton.Location = new Point(709, 529);
            logoutButton.Margin = new Padding(4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(162, 42);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(13, 377);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(4);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(279, 92);
            EnterCRUDTipoAnomaliaButton.TabIndex = 3;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(306, 479);
            btnCrudZona.Margin = new Padding(6, 4, 6, 4);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(279, 92);
            btnCrudZona.TabIndex = 4;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(13, 277);
            EnterCRUDUsuarioButton.Margin = new Padding(4);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(279, 92);
            EnterCRUDUsuarioButton.TabIndex = 5;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // pedidoAgregacionButton
            // 
            pedidoAgregacionButton.Location = new Point(15, 479);
            pedidoAgregacionButton.Margin = new Padding(6);
            pedidoAgregacionButton.Name = "pedidoAgregacionButton";
            pedidoAgregacionButton.Size = new Size(279, 92);
            pedidoAgregacionButton.TabIndex = 6;
            pedidoAgregacionButton.Text = "CRUD Pedido de Agregacion";
            pedidoAgregacionButton.UseVisualStyleBackColor = true;
            pedidoAgregacionButton.Click += pedidoAgregacionButton_Click;
            // 
            // menuStripOperador
            // 
            menuStripOperador.BackColor = SystemColors.Control;
            menuStripOperador.ImageScalingSize = new Size(32, 32);
            menuStripOperador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tiposDeAnomaliasToolStripMenuItem, localidadesToolStripMenuItem, zonasToolStripMenuItem, pedidosDeAgregacionToolStripMenuItem, toolStripMenuItemMasAjustes });
            menuStripOperador.Location = new Point(0, 0);
            menuStripOperador.Name = "menuStripOperador";
            menuStripOperador.Size = new Size(1213, 40);
            menuStripOperador.TabIndex = 7;
            menuStripOperador.Text = "menuStripOperador";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(124, 38);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // tiposDeAnomaliasToolStripMenuItem
            // 
            tiposDeAnomaliasToolStripMenuItem.Name = "tiposDeAnomaliasToolStripMenuItem";
            tiposDeAnomaliasToolStripMenuItem.Size = new Size(242, 38);
            tiposDeAnomaliasToolStripMenuItem.Text = "Tipos de Anomalías";
            tiposDeAnomaliasToolStripMenuItem.Click += tiposDeAnomaliasToolStripMenuItem_Click;
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(157, 38);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // zonasToolStripMenuItem
            // 
            zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            zonasToolStripMenuItem.Size = new Size(98, 38);
            zonasToolStripMenuItem.Text = "Zonas";
            zonasToolStripMenuItem.Click += zonasToolStripMenuItem_Click;
            // 
            // pedidosDeAgregacionToolStripMenuItem
            // 
            pedidosDeAgregacionToolStripMenuItem.Name = "pedidosDeAgregacionToolStripMenuItem";
            pedidosDeAgregacionToolStripMenuItem.Size = new Size(279, 38);
            pedidosDeAgregacionToolStripMenuItem.Text = "Pedidos de Agregación";
            pedidosDeAgregacionToolStripMenuItem.Click += pedidosDeAgregacionToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(161, 38);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(288, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // MenuOperador
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 606);
            Controls.Add(pedidoAgregacionButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(logoutButton);
            Controls.Add(EnterCRUDLocalidadButton);
            Controls.Add(menuStripOperador);
            MainMenuStrip = menuStripOperador;
            Margin = new Padding(4);
            Name = "MenuOperador";
            Text = "Menu Operador";
            menuStripOperador.ResumeLayout(false);
            menuStripOperador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EnterCRUDLocalidadButton;
        private Button logoutButton;
        private Button EnterCRUDTipoAnomaliaButton;
        private Button btnCrudZona;
        private Button EnterCRUDUsuarioButton;
        private Button pedidoAgregacionButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tiposDeAnomaliasToolStripMenuItem;
        private ToolStripMenuItem localidadesToolStripMenuItem;
        private ToolStripMenuItem zonasToolStripMenuItem;
        private ToolStripMenuItem pedidosDeAgregacionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private MenuStrip menuStripOperador;
    }
}