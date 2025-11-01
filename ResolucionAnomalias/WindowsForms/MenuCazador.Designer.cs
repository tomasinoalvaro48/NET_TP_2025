namespace WindowsForms
{
    partial class MenuCazador
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
            EnterCRUDUsuarioButton = new Button();
            EnterCRUDTipoAnomaliaButton = new Button();
            label2 = new Label();
            menuStripCazador = new MenuStrip();
            tomarPedidoDeResoluciónToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoAgregacionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cambiarContrasenaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            buttonTomarPedido = new Button();
            label1 = new Label();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelMenu = new Panel();
            panelContent = new Panel();
            buttonPedidoAgregacion = new Button();
            menuStripCazador.SuspendLayout();
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
            logoutButton.TabIndex = 3;
            logoutButton.Visible = false;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(0, 0);
            EnterCRUDUsuarioButton.Margin = new Padding(5);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(122, 37);
            EnterCRUDUsuarioButton.TabIndex = 13;
            EnterCRUDUsuarioButton.Visible = false;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(0, 0);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(5);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(122, 37);
            EnterCRUDTipoAnomaliaButton.TabIndex = 12;
            EnterCRUDTipoAnomaliaButton.Visible = false;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 11;
            label2.Visible = false;
            // 
            // menuStripCazador
            // 
            menuStripCazador.BackColor = Color.FromArgb(245, 245, 245);
            menuStripCazador.Dock = DockStyle.Fill;
            menuStripCazador.Font = new Font("Segoe UI", 9.5F);
            menuStripCazador.ImageScalingSize = new Size(20, 20);
            menuStripCazador.Items.AddRange(new ToolStripItem[] { realizarPedidoAgregacionToolStripMenuItem, tomarPedidoDeResoluciónToolStripMenuItem, toolStripMenuItemMasAjustes });
            menuStripCazador.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStripCazador.Location = new Point(0, 0);
            menuStripCazador.Name = "menuStripCazador";
            menuStripCazador.Padding = new Padding(16, 0, 0, 16);
            menuStripCazador.Size = new Size(406, 526);
            menuStripCazador.TabIndex = 9;
            menuStripCazador.Text = "menuStripCazador";
            // 
            // tomarPedidoDeResoluciónToolStripMenuItem
            // 
            tomarPedidoDeResoluciónToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            tomarPedidoDeResoluciónToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            tomarPedidoDeResoluciónToolStripMenuItem.Name = "tomarPedidoDeResoluciónToolStripMenuItem";
            tomarPedidoDeResoluciónToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            tomarPedidoDeResoluciónToolStripMenuItem.Size = new Size(389, 56);
            tomarPedidoDeResoluciónToolStripMenuItem.Text = "Tomar Pedido de Resolución";
            tomarPedidoDeResoluciónToolStripMenuItem.Click += tomarPedidoDeResoluciónToolStripMenuItem_Click;
            // 
            // realizarPedidoAgregacionToolStripMenuItem
            // 
            realizarPedidoAgregacionToolStripMenuItem.ForeColor = Color.FromArgb(60, 60, 60);
            realizarPedidoAgregacionToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            realizarPedidoAgregacionToolStripMenuItem.Name = "realizarPedidoAgregacionToolStripMenuItem";
            realizarPedidoAgregacionToolStripMenuItem.Padding = new Padding(10, 8, 10, 8);
            realizarPedidoAgregacionToolStripMenuItem.Size = new Size(389, 56);
            realizarPedidoAgregacionToolStripMenuItem.Text = "Pedidos de Agregación";
            realizarPedidoAgregacionToolStripMenuItem.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
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
            // buttonTomarPedido
            // 
            buttonTomarPedido.BackColor = Color.Green;
            buttonTomarPedido.Cursor = Cursors.Hand;
            buttonTomarPedido.FlatAppearance.BorderSize = 0;
            buttonTomarPedido.FlatStyle = FlatStyle.Flat;
            buttonTomarPedido.Font = new Font("Segoe UI", 10F);
            buttonTomarPedido.ForeColor = Color.White;
            buttonTomarPedido.Location = new Point(130, 312);
            buttonTomarPedido.Margin = new Padding(5);
            buttonTomarPedido.Name = "buttonTomarPedido";
            buttonTomarPedido.Size = new Size(552, 88);
            buttonTomarPedido.TabIndex = 10;
            buttonTomarPedido.Text = "Tomar Pedido de Resolución";
            buttonTomarPedido.UseVisualStyleBackColor = false;
            buttonTomarPedido.Click += buttonTomarPedido_Click;
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
            label1.TabIndex = 14;
            label1.Text = "Bienvenido, Cazador";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            panelMenu.Controls.Add(menuStripCazador);
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
            panelContent.Controls.Add(buttonTomarPedido);
            panelContent.Controls.Add(buttonPedidoAgregacion);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(411, 5);
            panelContent.Margin = new Padding(5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(49, 48, 49, 48);
            panelContent.Size = new Size(722, 516);
            panelContent.TabIndex = 1;
            // 
            // buttonPedidoAgregacion
            // 
            buttonPedidoAgregacion.BackColor = Color.DodgerBlue;
            buttonPedidoAgregacion.Cursor = Cursors.Hand;
            buttonPedidoAgregacion.FlatAppearance.BorderSize = 0;
            buttonPedidoAgregacion.FlatStyle = FlatStyle.Flat;
            buttonPedidoAgregacion.Font = new Font("Segoe UI", 10F);
            buttonPedidoAgregacion.ForeColor = Color.White;
            buttonPedidoAgregacion.Location = new Point(130, 192);
            buttonPedidoAgregacion.Margin = new Padding(5);
            buttonPedidoAgregacion.Name = "buttonPedidoAgregacion";
            buttonPedidoAgregacion.Size = new Size(552, 88);
            buttonPedidoAgregacion.TabIndex = 15;
            buttonPedidoAgregacion.Text = "Pedidos de Agregación";
            buttonPedidoAgregacion.UseVisualStyleBackColor = false;
            buttonPedidoAgregacion.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
            // 
            // MenuCazador
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 526);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(label2);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(logoutButton);
            MainMenuStrip = menuStripCazador;
            Margin = new Padding(5);
            MinimumSize = new Size(1040, 597);
            Name = "MenuCazador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cazador - Sistema de Resolución de Anomalías";
            FormClosing += MenuCazador_FormClosing;
            menuStripCazador.ResumeLayout(false);
            menuStripCazador.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button logoutButton;
        private Button EnterCRUDUsuarioButton;
        private Button EnterCRUDTipoAnomaliaButton;
        private Label label2;
        private MenuStrip menuStripCazador;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem realizarPedidoAgregacionToolStripMenuItem;
        private ToolStripMenuItem tomarPedidoDeResoluciónToolStripMenuItem;
        private Button buttonTomarPedido;
        private ToolStripMenuItem cambiarContrasenaToolStripMenuItem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelMenu;
        private Panel panelContent;
        private Button buttonPedidoAgregacion;
    }
}