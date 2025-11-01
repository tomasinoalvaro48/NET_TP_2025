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
            logoutButton = new Button();
            label1 = new Label();
            menuStripDenunciante = new MenuStrip();
            toolStripMenuItemVerPedidos = new ToolStripMenuItem();
            realizarPedidoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cambiarContrasenaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            buttonPedidoResolucion = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelMenu = new Panel();
            panelContent = new Panel();
            buttonRealizarPedido = new Button();
            menuStripDenunciante.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(0, 0);
            logoutButton.Margin = new Padding(5);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(122, 37);
            logoutButton.TabIndex = 1;
            logoutButton.Visible = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(49, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(624, 64);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido, Denunciante";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStripDenunciante
            // 
            menuStripDenunciante.BackColor = Color.FromArgb(245, 245, 245);
            menuStripDenunciante.Dock = DockStyle.Fill;
            menuStripDenunciante.Font = new Font("Segoe UI", 9.5F);
            menuStripDenunciante.ImageScalingSize = new Size(20, 20);
            menuStripDenunciante.Items.AddRange(new ToolStripItem[] { toolStripMenuItemVerPedidos, realizarPedidoToolStripMenuItem, toolStripMenuItemMasAjustes });
            menuStripDenunciante.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStripDenunciante.Location = new Point(0, 0);
            menuStripDenunciante.Name = "menuStripDenunciante";
            menuStripDenunciante.Padding = new Padding(16, 0, 0, 16);
            menuStripDenunciante.Size = new Size(406, 526);
            menuStripDenunciante.TabIndex = 8;
            menuStripDenunciante.Text = "menuStripDenunciante";
            // 
            // toolStripMenuItemVerPedidos
            // 
            toolStripMenuItemVerPedidos.ForeColor = Color.FromArgb(60, 60, 60);
            toolStripMenuItemVerPedidos.Margin = new Padding(0, 5, 0, 5);
            toolStripMenuItemVerPedidos.Name = "toolStripMenuItemVerPedidos";
            toolStripMenuItemVerPedidos.Padding = new Padding(10, 8, 10, 8);
            toolStripMenuItemVerPedidos.Size = new Size(389, 56);
            toolStripMenuItemVerPedidos.Text = "Ver Pedidos";
            toolStripMenuItemVerPedidos.Click += buttonPedidoResolucion_Click;
            // 
            // realizarPedidoToolStripMenuItem
            // 
            realizarPedidoToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            realizarPedidoToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            realizarPedidoToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            realizarPedidoToolStripMenuItem.Size = new Size(389, 56);
            realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            realizarPedidoToolStripMenuItem.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cambiarContrasenaToolStripMenuItem, cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.ForeColor = Color.FromArgb(60, 60, 60);
            toolStripMenuItemMasAjustes.Margin = new Padding(0, 5, 0, 5);
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Padding = new Padding(10, 8, 10, 8);
            toolStripMenuItemMasAjustes.Size = new Size(389, 56);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cambiarContrasenaToolStripMenuItem
            // 
            cambiarContrasenaToolStripMenuItem.Name = "cambiarContrasenaToolStripMenuItem";
            cambiarContrasenaToolStripMenuItem.Size = new Size(380, 44);
            cambiarContrasenaToolStripMenuItem.Text = "Cambiar Contraseña";
            cambiarContrasenaToolStripMenuItem.Click += cambiarContrasenaToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(380, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // buttonPedidoResolucion
            // 
            buttonPedidoResolucion.BackColor = Color.DodgerBlue;
            buttonPedidoResolucion.Cursor = Cursors.Hand;
            buttonPedidoResolucion.FlatAppearance.BorderSize = 0;
            buttonPedidoResolucion.FlatStyle = FlatStyle.Flat;
            buttonPedidoResolucion.Font = new Font("Segoe UI", 10F);
            buttonPedidoResolucion.ForeColor = Color.White;
            buttonPedidoResolucion.Location = new Point(81, 192);
            buttonPedidoResolucion.Margin = new Padding(5);
            buttonPedidoResolucion.Name = "buttonPedidoResolucion";
            buttonPedidoResolucion.Size = new Size(552, 88);
            buttonPedidoResolucion.TabIndex = 9;
            buttonPedidoResolucion.Text = "Ver Pedidos de Resolución";
            buttonPedidoResolucion.UseVisualStyleBackColor = false;
            buttonPedidoResolucion.Click += buttonPedidoResolucion_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 406F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelMenu, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelContent, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1138, 526);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(245, 245, 245);
            panelMenu.Controls.Add(menuStripDenunciante);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(406, 526);
            panelMenu.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(buttonRealizarPedido);
            panelContent.Controls.Add(buttonPedidoResolucion);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(411, 5);
            panelContent.Margin = new Padding(5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(49, 48, 49, 48);
            panelContent.Size = new Size(722, 516);
            panelContent.TabIndex = 1;
            // 
            // buttonRealizarPedido
            // 
            buttonRealizarPedido.BackColor = Color.Green;
            buttonRealizarPedido.Cursor = Cursors.Hand;
            buttonRealizarPedido.FlatAppearance.BorderSize = 0;
            buttonRealizarPedido.FlatStyle = FlatStyle.Flat;
            buttonRealizarPedido.Font = new Font("Segoe UI", 10F);
            buttonRealizarPedido.ForeColor = Color.White;
            buttonRealizarPedido.Location = new Point(81, 312);
            buttonRealizarPedido.Margin = new Padding(5);
            buttonRealizarPedido.Name = "buttonRealizarPedido";
            buttonRealizarPedido.Size = new Size(552, 88);
            buttonRealizarPedido.TabIndex = 10;
            buttonRealizarPedido.Text = "Realizar Pedido de Resolución";
            buttonRealizarPedido.UseVisualStyleBackColor = false;
            buttonRealizarPedido.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 526);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(logoutButton);
            MainMenuStrip = menuStripDenunciante;
            Margin = new Padding(5);
            MinimumSize = new Size(1040, 597);
            Name = "MenuDenunciante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Denunciante - Sistema de Resolución de Anomalías";
            FormClosing += MenuDenunciante_FormClosing;
            menuStripDenunciante.ResumeLayout(false);
            menuStripDenunciante.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button logoutButton;
        private Label label1;
        private MenuStrip menuStripDenunciante;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private ToolStripMenuItem cambiarContrasenaToolStripMenuItem;
        private Button buttonPedidoResolucion;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelMenu;
        private Panel panelContent;
        private Button buttonRealizarPedido;
        private ToolStripMenuItem toolStripMenuItemVerPedidos;
    }
}