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
            menuStripOperador = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeAnomaliasToolStripMenuItem = new ToolStripMenuItem();
            localidadesToolStripMenuItem = new ToolStripMenuItem();
            zonasToolStripMenuItem = new ToolStripMenuItem();
            pedidosDeAgregacionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            menuStripOperador.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripOperador
            // 
            menuStripOperador.BackColor = SystemColors.ControlLight;
            menuStripOperador.Dock = DockStyle.Left;
            menuStripOperador.ImageScalingSize = new Size(32, 32);
            menuStripOperador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tiposDeAnomaliasToolStripMenuItem, localidadesToolStripMenuItem, zonasToolStripMenuItem, pedidosDeAgregacionToolStripMenuItem, toolStripMenuItemMasAjustes, reporteToolStripMenuItem });
            menuStripOperador.Location = new Point(0, 0);
            menuStripOperador.Name = "menuStripOperador";
            menuStripOperador.Size = new Size(426, 606);
            menuStripOperador.TabIndex = 7;
            menuStripOperador.Text = "menuStripOperador";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Margin = new Padding(5);
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(403, 36);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // tiposDeAnomaliasToolStripMenuItem
            // 
            tiposDeAnomaliasToolStripMenuItem.Margin = new Padding(5);
            tiposDeAnomaliasToolStripMenuItem.Name = "tiposDeAnomaliasToolStripMenuItem";
            tiposDeAnomaliasToolStripMenuItem.Size = new Size(403, 36);
            tiposDeAnomaliasToolStripMenuItem.Text = "Tipos de Anomalías";
            tiposDeAnomaliasToolStripMenuItem.Click += tiposDeAnomaliasToolStripMenuItem_Click;
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Margin = new Padding(5);
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(403, 36);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // zonasToolStripMenuItem
            // 
            zonasToolStripMenuItem.Margin = new Padding(5);
            zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            zonasToolStripMenuItem.Size = new Size(403, 36);
            zonasToolStripMenuItem.Text = "Zonas";
            zonasToolStripMenuItem.Click += zonasToolStripMenuItem_Click;
            // 
            // pedidosDeAgregacionToolStripMenuItem
            // 
            pedidosDeAgregacionToolStripMenuItem.Margin = new Padding(5);
            pedidosDeAgregacionToolStripMenuItem.Name = "pedidosDeAgregacionToolStripMenuItem";
            pedidosDeAgregacionToolStripMenuItem.Size = new Size(403, 36);
            pedidosDeAgregacionToolStripMenuItem.Text = "Pedidos de Agregación";
            pedidosDeAgregacionToolStripMenuItem.Click += pedidosDeAgregacionToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(413, 36);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(359, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.Margin = new Padding(5);
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(403, 36);
            reporteToolStripMenuItem.Text = "Ver Reporte Pedidos de Agregacion";
            reporteToolStripMenuItem.Click += reporteToolStripMenuItem_Click;
            // 
            // MenuOperador
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 606);
            Controls.Add(menuStripOperador);
            MainMenuStrip = menuStripOperador;
            Margin = new Padding(4);
            Name = "MenuOperador";
            Text = "Menu Operador";
            FormClosing += MenuOperador_FormClosing;
            menuStripOperador.ResumeLayout(false);
            menuStripOperador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tiposDeAnomaliasToolStripMenuItem;
        private ToolStripMenuItem localidadesToolStripMenuItem;
        private ToolStripMenuItem zonasToolStripMenuItem;
        private ToolStripMenuItem pedidosDeAgregacionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private MenuStrip menuStripOperador;
        private ToolStripMenuItem reporteToolStripMenuItem;
    }
}