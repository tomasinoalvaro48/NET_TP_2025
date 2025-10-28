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
            verPedidosDeResoluciónToolStripMenuItem = new ToolStripMenuItem();
            pedidosDeAgregacionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            tituloLabel = new Label();
            btnReportePedidos = new Button();
            labeltitulo = new Label();
            menuStripOperador.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripOperador
            // 
            menuStripOperador.BackColor = SystemColors.ControlLight;
            menuStripOperador.Dock = DockStyle.Left;
            menuStripOperador.ImageScalingSize = new Size(32, 32);
            menuStripOperador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tiposDeAnomaliasToolStripMenuItem, localidadesToolStripMenuItem, zonasToolStripMenuItem, verPedidosDeResoluciónToolStripMenuItem, pedidosDeAgregacionToolStripMenuItem, toolStripMenuItemMasAjustes, reporteToolStripMenuItem });
            menuStripOperador.Location = new Point(0, 0);
            menuStripOperador.Name = "menuStripOperador";
            menuStripOperador.Padding = new Padding(4, 1, 0, 1);
            menuStripOperador.Size = new Size(245, 284);
            menuStripOperador.TabIndex = 7;
            menuStripOperador.Text = "menuStripOperador";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Margin = new Padding(5);
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(226, 19);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // tiposDeAnomaliasToolStripMenuItem
            // 
            tiposDeAnomaliasToolStripMenuItem.Margin = new Padding(5);
            tiposDeAnomaliasToolStripMenuItem.Name = "tiposDeAnomaliasToolStripMenuItem";
            tiposDeAnomaliasToolStripMenuItem.Size = new Size(226, 19);
            tiposDeAnomaliasToolStripMenuItem.Text = "Tipos de Anomalías";
            tiposDeAnomaliasToolStripMenuItem.Click += tiposDeAnomaliasToolStripMenuItem_Click;
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Margin = new Padding(5);
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(226, 19);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // zonasToolStripMenuItem
            // 
            zonasToolStripMenuItem.Margin = new Padding(5);
            zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            zonasToolStripMenuItem.Size = new Size(226, 19);
            zonasToolStripMenuItem.Text = "Zonas";
            zonasToolStripMenuItem.Click += zonasToolStripMenuItem_Click;
            // 
            // verPedidosDeResoluciónToolStripMenuItem
            // 
            verPedidosDeResoluciónToolStripMenuItem.Name = "verPedidosDeResoluciónToolStripMenuItem";
            verPedidosDeResoluciónToolStripMenuItem.Size = new Size(236, 19);
            verPedidosDeResoluciónToolStripMenuItem.Text = "Ver Pedidos de Resolución";
            verPedidosDeResoluciónToolStripMenuItem.Click += verPedidosDeResoluciónToolStripMenuItem_Click;
            // 
            // pedidosDeAgregacionToolStripMenuItem
            // 
            pedidosDeAgregacionToolStripMenuItem.Margin = new Padding(5);
            pedidosDeAgregacionToolStripMenuItem.Name = "pedidosDeAgregacionToolStripMenuItem";
            pedidosDeAgregacionToolStripMenuItem.Size = new Size(226, 19);
            pedidosDeAgregacionToolStripMenuItem.Text = "Pedidos de Agregación";
            pedidosDeAgregacionToolStripMenuItem.Click += pedidosDeAgregacionToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(236, 19);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.Margin = new Padding(5);
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(226, 19);
            reporteToolStripMenuItem.Text = "Reporte Pedidos de Agregacion (no pdf)";
            reporteToolStripMenuItem.Click += reporteToolStripMenuItem_Click;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new Point(375, 54);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(128, 15);
            tituloLabel.TabIndex = 8;
            tituloLabel.Text = "¡Bienvenido, Operador!";
            // 
            // btnReportePedidos
            // 
            btnReportePedidos.Location = new Point(428, 213);
            btnReportePedidos.Name = "btnReportePedidos";
            btnReportePedidos.Size = new Size(197, 46);
            btnReportePedidos.TabIndex = 9;
            btnReportePedidos.Text = "Generar Reporte de Pedidos de Resolucion del mes actual";
            btnReportePedidos.UseVisualStyleBackColor = true;
            btnReportePedidos.Click += btnReportePedidos_Click;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Location = new Point(371, 83);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(128, 15);
            labeltitulo.TabIndex = 10;
            labeltitulo.Text = "¡Bienvenido, Operador!";
            // 
            // MenuOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 284);
            Controls.Add(labeltitulo);
            Controls.Add(btnReportePedidos);
            Controls.Add(menuStripOperador);
            MainMenuStrip = menuStripOperador;
            Margin = new Padding(2);
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
        private Label tituloLabel;
        private Button btnReportePedidos;
        private ToolStripMenuItem verPedidosDeResoluciónToolStripMenuItem;
        private Label labeltitulo;
    }
}