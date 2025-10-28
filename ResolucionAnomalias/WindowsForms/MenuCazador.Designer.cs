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
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cambiarContrasenaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoAgregacionToolStripMenuItem = new ToolStripMenuItem();
            buttonTomarPedido = new Button();
            label1 = new Label();
            menuStripCazador.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(341, 168);
            logoutButton.Margin = new Padding(4, 3, 4, 3);
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
            EnterCRUDUsuarioButton.Margin = new Padding(3, 2, 3, 2);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(66, 17);
            EnterCRUDUsuarioButton.TabIndex = 13;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(0, 0);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(3, 2, 3, 2);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(66, 17);
            EnterCRUDTipoAnomaliaButton.TabIndex = 12;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 11;
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
            menuStripCazador.Size = new Size(193, 231);
            menuStripCazador.TabIndex = 9;
            menuStripCazador.Text = "menuStripCazador";
            // 
            // tomarPedidoDeResoluciónToolStripMenuItem
            // 
            tomarPedidoDeResoluciónToolStripMenuItem.Name = "tomarPedidoDeResoluciónToolStripMenuItem";
            tomarPedidoDeResoluciónToolStripMenuItem.Size = new Size(184, 19);
            tomarPedidoDeResoluciónToolStripMenuItem.Text = "Tomar Pedido de Resolución";
            tomarPedidoDeResoluciónToolStripMenuItem.Click += tomarPedidoDeResoluciónToolStripMenuItem_Click;
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cambiarContrasenaToolStripMenuItem, cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(184, 19);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cambiarContrasenaToolStripMenuItem
            // 
            cambiarContrasenaToolStripMenuItem.Name = "cambiarContrasenaToolStripMenuItem";
            cambiarContrasenaToolStripMenuItem.Size = new Size(182, 22);
            cambiarContrasenaToolStripMenuItem.Text = "Cambiar Contraseña";
            cambiarContrasenaToolStripMenuItem.Click += cambiarContrasenaToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(182, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoAgregacionToolStripMenuItem
            // 
            realizarPedidoAgregacionToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoAgregacionToolStripMenuItem.Name = "realizarPedidoAgregacionToolStripMenuItem";
            realizarPedidoAgregacionToolStripMenuItem.Size = new Size(174, 19);
            realizarPedidoAgregacionToolStripMenuItem.Text = "Realizar Pedido de Agregación";
            realizarPedidoAgregacionToolStripMenuItem.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
            // 
            // buttonTomarPedido
            // 
            buttonTomarPedido.Location = new Point(233, 77);
            buttonTomarPedido.Margin = new Padding(3, 2, 3, 2);
            buttonTomarPedido.Name = "buttonTomarPedido";
            buttonTomarPedido.Size = new Size(146, 50);
            buttonTomarPedido.TabIndex = 10;
            buttonTomarPedido.Text = "Tomar Pedido de Resolución";
            buttonTomarPedido.UseVisualStyleBackColor = true;
            buttonTomarPedido.Click += buttonTomarPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 42);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 14;
            label1.Text = "¡Bienvenido, Cazador!";
            // 
            // MenuCazador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 231);
            Controls.Add(label1);
            Controls.Add(buttonTomarPedido);
            Controls.Add(menuStripCazador);
            Controls.Add(label2);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(logoutButton);
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem cambiarContrasenaToolStripMenuItem;
        private Label label1;
    }
}