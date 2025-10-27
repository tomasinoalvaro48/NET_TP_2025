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
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoAgregacionToolStripMenuItem = new ToolStripMenuItem();
            tomarPedidoDeResoluciónToolStripMenuItem = new ToolStripMenuItem();
            menuStripCazador.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(472, 331);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(101, 23);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(0, 0);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(75, 23);
            EnterCRUDUsuarioButton.TabIndex = 11;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(0, 0);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(75, 23);
            EnterCRUDTipoAnomaliaButton.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 113);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 6;
            label2.Text = "¡Bienvenido, Cazador!";
            // 
            // menuStripCazador
            // 
            menuStripCazador.BackColor = SystemColors.ControlLight;
            menuStripCazador.Dock = DockStyle.Left;
            menuStripCazador.ImageScalingSize = new Size(32, 32);
            menuStripCazador.Items.AddRange(new ToolStripItem[] { tomarPedidoDeResoluciónToolStripMenuItem, toolStripMenuItemMasAjustes, realizarPedidoAgregacionToolStripMenuItem });
            menuStripCazador.Location = new Point(0, 0);
            menuStripCazador.Name = "menuStripCazador";
            menuStripCazador.Padding = new Padding(3, 1, 0, 1);
            menuStripCazador.Size = new Size(192, 351);
            menuStripCazador.TabIndex = 9;
            menuStripCazador.Text = "menuStripCazador";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(185, 19);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoAgregacionToolStripMenuItem
            // 
            realizarPedidoAgregacionToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoAgregacionToolStripMenuItem.Name = "realizarPedidoAgregacionToolStripMenuItem";
            realizarPedidoAgregacionToolStripMenuItem.Size = new Size(175, 19);
            realizarPedidoAgregacionToolStripMenuItem.Text = "Realizar Pedido de Agregación";
            realizarPedidoAgregacionToolStripMenuItem.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
            // 
            // tomarPedidoDeResoluciónToolStripMenuItem
            // 
            tomarPedidoDeResoluciónToolStripMenuItem.Name = "tomarPedidoDeResoluciónToolStripMenuItem";
            tomarPedidoDeResoluciónToolStripMenuItem.Size = new Size(185, 19);
            tomarPedidoDeResoluciónToolStripMenuItem.Text = "Tomar Pedido de Resolución";
            tomarPedidoDeResoluciónToolStripMenuItem.Click += tomarPedidoDeResoluciónToolStripMenuItem_Click;
            // 
            // MenuCazador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 351);
            Controls.Add(menuStripCazador);
            Controls.Add(label2);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(logoutButton);
            Name = "MenuCazador";
            Text = "Menu Cazador";
            FormClosing += MenuCazador_FormClosing;
            menuStripCazador.ResumeLayout(false);
            menuStripCazador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}