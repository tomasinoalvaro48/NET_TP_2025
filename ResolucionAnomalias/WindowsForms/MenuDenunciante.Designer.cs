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
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cambiarContrasenaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoToolStripMenuItem = new ToolStripMenuItem();
            buttonPedidoResolucion = new Button();
            menuStripDenunciante.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(173, 201);
            logoutButton.Margin = new Padding(4, 3, 4, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(135, 23);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 2;
            label1.Text = "¡Bienvenido, Denunciante!";
            // 
            // menuStripDenunciante
            // 
            menuStripDenunciante.ImageScalingSize = new Size(32, 32);
            menuStripDenunciante.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMasAjustes, realizarPedidoToolStripMenuItem });
            menuStripDenunciante.Location = new Point(0, 0);
            menuStripDenunciante.Name = "menuStripDenunciante";
            menuStripDenunciante.Padding = new Padding(4, 1, 0, 1);
            menuStripDenunciante.Size = new Size(321, 24);
            menuStripDenunciante.TabIndex = 8;
            menuStripDenunciante.Text = "menuStripDenunciante";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cambiarContrasenaToolStripMenuItem, cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(82, 22);
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
            // realizarPedidoToolStripMenuItem
            // 
            realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            realizarPedidoToolStripMenuItem.Size = new Size(99, 22);
            realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            realizarPedidoToolStripMenuItem.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // buttonPedidoResolucion
            // 
            buttonPedidoResolucion.Location = new Point(103, 79);
            buttonPedidoResolucion.Margin = new Padding(3, 2, 3, 2);
            buttonPedidoResolucion.Name = "buttonPedidoResolucion";
            buttonPedidoResolucion.Size = new Size(122, 61);
            buttonPedidoResolucion.TabIndex = 9;
            buttonPedidoResolucion.Text = "Ver Pedidos de Resolución";
            buttonPedidoResolucion.UseVisualStyleBackColor = true;
            buttonPedidoResolucion.Click += buttonPedidoResolucion_Click;
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 236);
            Controls.Add(buttonPedidoResolucion);
            Controls.Add(menuStripDenunciante);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuDenunciante";
            Text = "Menu Denunciante";
            Load += MenuDenunciante_Load;
            menuStripDenunciante.ResumeLayout(false);
            menuStripDenunciante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}