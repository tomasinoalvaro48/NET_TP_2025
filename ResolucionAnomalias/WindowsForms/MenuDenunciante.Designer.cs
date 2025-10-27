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
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoToolStripMenuItem = new ToolStripMenuItem();
            buttonPedidoResolucion = new Button();
            menuStripDenunciante.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(410, 302);
            logoutButton.Margin = new Padding(4, 4, 4, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(154, 31);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 20);
            label1.TabIndex = 2;
            label1.Text = "¡Bienvenido, Denunciante!";
            // 
            // menuStripDenunciante
            // 
            menuStripDenunciante.BackColor = SystemColors.ControlLight;
            menuStripDenunciante.Dock = DockStyle.Left;
            menuStripDenunciante.ImageScalingSize = new Size(32, 32);
            menuStripDenunciante.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMasAjustes, realizarPedidoToolStripMenuItem });
            menuStripDenunciante.Location = new Point(0, 0);
            menuStripDenunciante.Name = "menuStripDenunciante";
            menuStripDenunciante.Padding = new Padding(4, 1, 0, 1);
            menuStripDenunciante.Size = new Size(700, 26);
            menuStripDenunciante.TabIndex = 8;
            menuStripDenunciante.Text = "menuStripDenunciante";
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
            // realizarPedidoToolStripMenuItem
            // 
            realizarPedidoToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            realizarPedidoToolStripMenuItem.Size = new Size(126, 24);
            realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            realizarPedidoToolStripMenuItem.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // buttonPedidoResolucion
            // 
            buttonPedidoResolucion.Location = new Point(499, 130);
            buttonPedidoResolucion.Name = "buttonPedidoResolucion";
            buttonPedidoResolucion.Size = new Size(139, 81);
            buttonPedidoResolucion.TabIndex = 9;
            buttonPedidoResolucion.Text = "Hacer Pedido";
            buttonPedidoResolucion.UseVisualStyleBackColor = true;
            buttonPedidoResolucion.Click += buttonPedidoResolucion_Click;
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 349);
            Controls.Add(buttonPedidoResolucion);
            Controls.Add(menuStripDenunciante);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MenuDenunciante";
            Text = "Menu Denunciante";
            FormClosing += MenuDenunciante_FormClosing;
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
        private Button buttonPedidoResolucion;
    }
}