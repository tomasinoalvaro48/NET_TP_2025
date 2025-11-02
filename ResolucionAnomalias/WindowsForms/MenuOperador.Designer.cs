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
            veToolStripMenuItem = new ToolStripMenuItem();
            pedidosDeAgregacionToolStripMenuItem = new ToolStripMenuItem();
            reporteResolucionToolStripMenuItem = new ToolStripMenuItem();
            reporteAgregacionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            buttonReportePedidoAgregacion = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelMenu = new Panel();
            panelContent = new Panel();
            buttonVolver = new Button();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonUsuarios = new Button();
            buttonTiposAnomalias = new Button();
            buttonLocalidades = new Button();
            buttonZonas = new Button();
            buttonPedidosResolucion = new Button();
            buttonPedidosAgregacion = new Button();
            buttonReportePedidosResolucion = new Button();
            buttonReportePedidosAgregacion = new Button();
            tituloLabel = new Label();
            menuStripOperador.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripOperador
            // 
            menuStripOperador.BackColor = Color.FromArgb(245, 245, 245);
            menuStripOperador.Dock = DockStyle.Fill;
            menuStripOperador.Font = new Font("Segoe UI", 9.5F);
            menuStripOperador.GripMargin = new Padding(4);
            menuStripOperador.ImageScalingSize = new Size(20, 20);
            menuStripOperador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tiposDeAnomaliasToolStripMenuItem, localidadesToolStripMenuItem, zonasToolStripMenuItem, veToolStripMenuItem, pedidosDeAgregacionToolStripMenuItem, reporteResolucionToolStripMenuItem, reporteAgregacionToolStripMenuItem, toolStripMenuItemMasAjustes });
            menuStripOperador.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStripOperador.Location = new Point(0, 0);
            menuStripOperador.Name = "menuStripOperador";
            menuStripOperador.Padding = new Padding(10, 0, 0, 10);
            menuStripOperador.Size = new Size(280, 1140);
            menuStripOperador.TabIndex = 7;
            menuStripOperador.Text = "menuStripOperador";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            usuariosToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            usuariosToolStripMenuItem.Size = new Size(269, 56);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // tiposDeAnomaliasToolStripMenuItem
            // 
            tiposDeAnomaliasToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            tiposDeAnomaliasToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            tiposDeAnomaliasToolStripMenuItem.Name = "tiposDeAnomaliasToolStripMenuItem";
            tiposDeAnomaliasToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            tiposDeAnomaliasToolStripMenuItem.Size = new Size(269, 56);
            tiposDeAnomaliasToolStripMenuItem.Text = "Tipos de Anomalías";
            tiposDeAnomaliasToolStripMenuItem.Click += tiposDeAnomaliasToolStripMenuItem_Click;
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            localidadesToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            localidadesToolStripMenuItem.Size = new Size(269, 56);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // zonasToolStripMenuItem
            // 
            zonasToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            zonasToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            zonasToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            zonasToolStripMenuItem.Size = new Size(269, 56);
            zonasToolStripMenuItem.Text = "Zonas";
            zonasToolStripMenuItem.Click += zonasToolStripMenuItem_Click;
            // 
            // veToolStripMenuItem
            // 
            veToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            veToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            veToolStripMenuItem.Name = "veToolStripMenuItem";
            veToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            veToolStripMenuItem.Size = new Size(269, 56);
            veToolStripMenuItem.Text = "Pedidos de Resolución";
            veToolStripMenuItem.Click += verPedidosDeResoluciónToolStripMenuItem_Click;
            // 
            // pedidosDeAgregacionToolStripMenuItem
            // 
            pedidosDeAgregacionToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            pedidosDeAgregacionToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            pedidosDeAgregacionToolStripMenuItem.Name = "pedidosDeAgregacionToolStripMenuItem";
            pedidosDeAgregacionToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            pedidosDeAgregacionToolStripMenuItem.Size = new Size(269, 56);
            pedidosDeAgregacionToolStripMenuItem.Text = "Pedidos de Agregación";
            pedidosDeAgregacionToolStripMenuItem.Click += pedidosDeAgregacionToolStripMenuItem_Click;
            // 
            // reporteResolucionToolStripMenuItem
            // 
            reporteResolucionToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            reporteResolucionToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            reporteResolucionToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            reporteResolucionToolStripMenuItem.Name = "reporteResolucionToolStripMenuItem";
            reporteResolucionToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            reporteResolucionToolStripMenuItem.Size = new Size(269, 56);
            reporteResolucionToolStripMenuItem.Text = "Reporte de Resolución";
            reporteResolucionToolStripMenuItem.Click += veToolStripMenuItem_Click;
            // 
            // reporteAgregacionToolStripMenuItem
            // 
            reporteAgregacionToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            reporteAgregacionToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            reporteAgregacionToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            reporteAgregacionToolStripMenuItem.Name = "reporteAgregacionToolStripMenuItem";
            reporteAgregacionToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            reporteAgregacionToolStripMenuItem.Size = new Size(269, 56);
            reporteAgregacionToolStripMenuItem.Text = "Reporte de Agregación";
            reporteAgregacionToolStripMenuItem.Click += reporteToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.ForeColor = Color.FromArgb(60, 60, 60);
            toolStripMenuItemMasAjustes.Margin = new Padding(0, 5, 0, 5);
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Padding = new Padding(10, 8, 10, 8);
            toolStripMenuItemMasAjustes.Size = new Size(269, 56);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            toolStripMenuItemMasAjustes.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(301, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // buttonReportePedidoAgregacion
            // 
            buttonReportePedidoAgregacion.Location = new Point(0, 0);
            buttonReportePedidoAgregacion.Name = "buttonReportePedidoAgregacion";
            buttonReportePedidoAgregacion.Size = new Size(75, 23);
            buttonReportePedidoAgregacion.TabIndex = 10;
            buttonReportePedidoAgregacion.Visible = false;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelMenu, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelContent, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1933, 1140);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(245, 245, 245);
            panelMenu.Controls.Add(menuStripOperador);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(280, 1140);
            panelMenu.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(buttonVolver);
            panelContent.Controls.Add(flowLayoutPanelButtons);
            panelContent.Controls.Add(tituloLabel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(283, 3);
            panelContent.MinimumSize = new Size(1517, 1130);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30, 30, 30, 20);
            panelContent.Size = new Size(1647, 1134);
            panelContent.TabIndex = 1;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Gray;
            buttonVolver.Cursor = Cursors.Hand;
            buttonVolver.FlatAppearance.BorderSize = 0;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(0, 0);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(143, 40);
            buttonVolver.TabIndex = 21;
            buttonVolver.Text = "← Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Visible = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelButtons.Controls.Add(buttonUsuarios);
            flowLayoutPanelButtons.Controls.Add(buttonTiposAnomalias);
            flowLayoutPanelButtons.Controls.Add(buttonLocalidades);
            flowLayoutPanelButtons.Controls.Add(buttonZonas);
            flowLayoutPanelButtons.Controls.Add(buttonPedidosResolucion);
            flowLayoutPanelButtons.Controls.Add(buttonPedidosAgregacion);
            flowLayoutPanelButtons.Controls.Add(buttonReportePedidosResolucion);
            flowLayoutPanelButtons.Controls.Add(buttonReportePedidosAgregacion);
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(30, 103);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(0, 10, 0, 0);
            flowLayoutPanelButtons.Size = new Size(1087, 1011);
            flowLayoutPanelButtons.TabIndex = 20;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(30, 144, 255);
            buttonUsuarios.Cursor = Cursors.Hand;
            buttonUsuarios.FlatAppearance.BorderSize = 0;
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Segoe UI", 9.5F);
            buttonUsuarios.ForeColor = Color.White;
            buttonUsuarios.Location = new Point(3, 13);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Size = new Size(260, 50);
            buttonUsuarios.TabIndex = 11;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.UseVisualStyleBackColor = false;
            buttonUsuarios.Click += usuariosToolStripMenuItem_Click;
            // 
            // buttonTiposAnomalias
            // 
            buttonTiposAnomalias.BackColor = Color.FromArgb(30, 144, 255);
            buttonTiposAnomalias.Cursor = Cursors.Hand;
            buttonTiposAnomalias.FlatAppearance.BorderSize = 0;
            buttonTiposAnomalias.FlatStyle = FlatStyle.Flat;
            buttonTiposAnomalias.Font = new Font("Segoe UI", 9.5F);
            buttonTiposAnomalias.ForeColor = Color.White;
            buttonTiposAnomalias.Location = new Point(269, 13);
            buttonTiposAnomalias.Name = "buttonTiposAnomalias";
            buttonTiposAnomalias.Size = new Size(260, 50);
            buttonTiposAnomalias.TabIndex = 12;
            buttonTiposAnomalias.Text = "Tipos de Anomalías";
            buttonTiposAnomalias.UseVisualStyleBackColor = false;
            buttonTiposAnomalias.Click += tiposDeAnomaliasToolStripMenuItem_Click;
            // 
            // buttonLocalidades
            // 
            buttonLocalidades.BackColor = Color.FromArgb(30, 144, 255);
            buttonLocalidades.Cursor = Cursors.Hand;
            buttonLocalidades.FlatAppearance.BorderSize = 0;
            buttonLocalidades.FlatStyle = FlatStyle.Flat;
            buttonLocalidades.Font = new Font("Segoe UI", 9.5F);
            buttonLocalidades.ForeColor = Color.White;
            buttonLocalidades.Location = new Point(535, 13);
            buttonLocalidades.Name = "buttonLocalidades";
            buttonLocalidades.Size = new Size(260, 50);
            buttonLocalidades.TabIndex = 13;
            buttonLocalidades.Text = "Localidades";
            buttonLocalidades.UseVisualStyleBackColor = false;
            buttonLocalidades.Click += localidadesToolStripMenuItem_Click;
            // 
            // buttonZonas
            // 
            buttonZonas.BackColor = Color.FromArgb(30, 144, 255);
            buttonZonas.Cursor = Cursors.Hand;
            buttonZonas.FlatAppearance.BorderSize = 0;
            buttonZonas.FlatStyle = FlatStyle.Flat;
            buttonZonas.Font = new Font("Segoe UI", 9.5F);
            buttonZonas.ForeColor = Color.White;
            buttonZonas.Location = new Point(801, 13);
            buttonZonas.Name = "buttonZonas";
            buttonZonas.Size = new Size(260, 50);
            buttonZonas.TabIndex = 14;
            buttonZonas.Text = "Zonas";
            buttonZonas.UseVisualStyleBackColor = false;
            buttonZonas.Click += zonasToolStripMenuItem_Click;
            // 
            // buttonPedidosResolucion
            // 
            buttonPedidosResolucion.BackColor = Color.DodgerBlue;
            buttonPedidosResolucion.Cursor = Cursors.Hand;
            buttonPedidosResolucion.FlatAppearance.BorderSize = 0;
            buttonPedidosResolucion.FlatStyle = FlatStyle.Flat;
            buttonPedidosResolucion.Font = new Font("Segoe UI", 9.5F);
            buttonPedidosResolucion.ForeColor = Color.White;
            buttonPedidosResolucion.Location = new Point(3, 69);
            buttonPedidosResolucion.Name = "buttonPedidosResolucion";
            buttonPedidosResolucion.Size = new Size(260, 86);
            buttonPedidosResolucion.TabIndex = 16;
            buttonPedidosResolucion.Text = "Pedidos de Resolución";
            buttonPedidosResolucion.UseVisualStyleBackColor = false;
            buttonPedidosResolucion.Click += verPedidosDeResoluciónToolStripMenuItem_Click;
            // 
            // buttonPedidosAgregacion
            // 
            buttonPedidosAgregacion.BackColor = Color.DodgerBlue;
            buttonPedidosAgregacion.Cursor = Cursors.Hand;
            buttonPedidosAgregacion.FlatAppearance.BorderSize = 0;
            buttonPedidosAgregacion.FlatStyle = FlatStyle.Flat;
            buttonPedidosAgregacion.Font = new Font("Segoe UI", 9.5F);
            buttonPedidosAgregacion.ForeColor = Color.White;
            buttonPedidosAgregacion.Location = new Point(269, 69);
            buttonPedidosAgregacion.Name = "buttonPedidosAgregacion";
            buttonPedidosAgregacion.Size = new Size(260, 86);
            buttonPedidosAgregacion.TabIndex = 15;
            buttonPedidosAgregacion.Text = "Pedidos de Agregación";
            buttonPedidosAgregacion.UseVisualStyleBackColor = false;
            buttonPedidosAgregacion.Click += pedidosDeAgregacionToolStripMenuItem_Click;
            // 
            // buttonReportePedidosResolucion
            // 
            buttonReportePedidosResolucion.BackColor = Color.Green;
            buttonReportePedidosResolucion.Cursor = Cursors.Hand;
            buttonReportePedidosResolucion.FlatAppearance.BorderSize = 0;
            buttonReportePedidosResolucion.FlatStyle = FlatStyle.Flat;
            buttonReportePedidosResolucion.Font = new Font("Segoe UI", 9.5F);
            buttonReportePedidosResolucion.ForeColor = Color.White;
            buttonReportePedidosResolucion.Location = new Point(535, 69);
            buttonReportePedidosResolucion.Name = "buttonReportePedidosResolucion";
            buttonReportePedidosResolucion.Size = new Size(260, 93);
            buttonReportePedidosResolucion.TabIndex = 17;
            buttonReportePedidosResolucion.Text = "Reporte de Pedidos de Resolucion";
            buttonReportePedidosResolucion.UseVisualStyleBackColor = false;
            buttonReportePedidosResolucion.Click += veToolStripMenuItem_Click;
            // 
            // buttonReportePedidosAgregacion
            // 
            buttonReportePedidosAgregacion.BackColor = Color.Green;
            buttonReportePedidosAgregacion.Cursor = Cursors.Hand;
            buttonReportePedidosAgregacion.FlatAppearance.BorderSize = 0;
            buttonReportePedidosAgregacion.FlatStyle = FlatStyle.Flat;
            buttonReportePedidosAgregacion.Font = new Font("Segoe UI", 9.5F);
            buttonReportePedidosAgregacion.ForeColor = Color.White;
            buttonReportePedidosAgregacion.Location = new Point(801, 69);
            buttonReportePedidosAgregacion.Name = "buttonReportePedidosAgregacion";
            buttonReportePedidosAgregacion.Size = new Size(260, 93);
            buttonReportePedidosAgregacion.TabIndex = 18;
            buttonReportePedidosAgregacion.Text = "Reporte de Pedidos de Agregación";
            buttonReportePedidosAgregacion.UseVisualStyleBackColor = false;
            buttonReportePedidosAgregacion.Click += reporteToolStripMenuItem_Click;
            // 
            // tituloLabel
            // 
            tituloLabel.Dock = DockStyle.Top;
            tituloLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLabel.ForeColor = Color.FromArgb(40, 40, 40);
            tituloLabel.Location = new Point(30, 30);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(1587, 73);
            tituloLabel.TabIndex = 19;
            tituloLabel.Text = "Bienvenido, Operador";
            tituloLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MenuOperador
            // 
            ClientSize = new Size(1933, 1140);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(buttonReportePedidoAgregacion);
            MainMenuStrip = menuStripOperador;
            MinimumSize = new Size(1959, 1211);
            Name = "MenuOperador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Operador - Sistema de Resolución de Anomalías";
            FormClosing += MenuOperador_FormClosing;
            menuStripOperador.ResumeLayout(false);
            menuStripOperador.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContent.ResumeLayout(false);
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
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
        private ToolStripMenuItem reporteAgregacionToolStripMenuItem;
        private Button buttonReportePedidoAgregacion;
        private ToolStripMenuItem veToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelMenu;
        private Panel panelContent;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonUsuarios;
        private Button buttonTiposAnomalias;
        private Button buttonLocalidades;
        private Button buttonZonas;
        private Button buttonPedidosAgregacion;
        private Button buttonPedidosResolucion;
        private Label tituloLabel;
        private Button buttonReportePedidosResolucion;
        private Button buttonReportePedidosAgregacion;
        private ToolStripMenuItem reporteResolucionToolStripMenuItem;
        private Button buttonVolver;
    }
}