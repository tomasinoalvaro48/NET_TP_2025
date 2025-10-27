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
            buttonTomarPedido = new Button();
            menuStripCazador.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(539, 441);
            logoutButton.Margin = new Padding(4, 4, 4, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(115, 31);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // menuStripCazador
            // 
            menuStripCazador.BackColor = SystemColors.ControlLight;
            menuStripCazador.Dock = DockStyle.Left;
            menuStripCazador.ImageScalingSize = new Size(32, 32);
            menuStripCazador.Items.AddRange(new ToolStripItem[] { tomarPedidoDeResoluciónToolStripMenuItem, toolStripMenuItemMasAjustes, realizarPedidoAgregacionToolStripMenuItem });
            menuStripCazador.Location = new Point(0, 0);
            menuStripCazador.Name = "menuStripCazador";
            menuStripCazador.Padding = new Padding(4, 1, 0, 1);
            menuStripCazador.Size = new Size(663, 26);
            menuStripCazador.TabIndex = 9;
            menuStripCazador.Text = "menuStripCazador";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(101, 24);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(179, 26);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoAgregacionToolStripMenuItem
            // 
            realizarPedidoAgregacionToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoAgregacionToolStripMenuItem.Name = "realizarPedidoAgregacionToolStripMenuItem";
            realizarPedidoAgregacionToolStripMenuItem.Size = new Size(228, 24);
            realizarPedidoAgregacionToolStripMenuItem.Text = "Realizar Pedido de Agregación";
            realizarPedidoAgregacionToolStripMenuItem.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
            // 
            // buttonTomarPedido
            // 
            buttonTomarPedido.Location = new Point(372, 324);
            buttonTomarPedido.Name = "buttonTomarPedido";
            buttonTomarPedido.Size = new Size(167, 66);
            buttonTomarPedido.TabIndex = 10;
            buttonTomarPedido.Text = "Tomar Pedido";
            buttonTomarPedido.UseVisualStyleBackColor = true;
            buttonTomarPedido.Click += buttonTomarPedido_Click;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 481);
            Controls.Add(buttonTomarPedido);
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
        private Button buttonTomarPedido;
    }
}