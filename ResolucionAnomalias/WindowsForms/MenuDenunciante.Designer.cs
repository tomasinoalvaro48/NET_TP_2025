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
            menuStripDenunciante.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(466, 227);
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
            label1.Location = new Point(300, 76);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
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
            menuStripDenunciante.Padding = new Padding(3, 1, 0, 1);
            menuStripDenunciante.Size = new Size(112, 262);
            menuStripDenunciante.TabIndex = 8;
            menuStripDenunciante.Text = "menuStripDenunciante";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(105, 19);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoToolStripMenuItem
            // 
            realizarPedidoToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            realizarPedidoToolStripMenuItem.Size = new Size(95, 19);
            realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            realizarPedidoToolStripMenuItem.Click += realizarPedidoToolStripMenuItem_Click;
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 262);
            Controls.Add(menuStripDenunciante);
            Controls.Add(label1);
            Controls.Add(logoutButton);
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
    }
}