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
            EnterCRUDLocalidadButton = new Button();
            btnCrudZona = new Button();
            label1 = new Label();
            logoutButton = new Button();
            EnterCRUDUsuarioButton = new Button();
            EnterCRUDTipoAnomaliaButton = new Button();
            label2 = new Label();
            pedidoAgregacionButton = new Button();
            menuStripCazador = new MenuStrip();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoAgregacionToolStripMenuItem = new ToolStripMenuItem();
            menuStripCazador.SuspendLayout();
            SuspendLayout();
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(509, 385);
            EnterCRUDLocalidadButton.Margin = new Padding(6);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(271, 105);
            EnterCRUDLocalidadButton.TabIndex = 0;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(792, 385);
            btnCrudZona.Margin = new Padding(6);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(271, 105);
            btnCrudZona.TabIndex = 1;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 290);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(552, 32);
            label1.TabIndex = 2;
            label1.Text = "(menu temporal hasta que agreguemos el pedido)";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(876, 706);
            logoutButton.Margin = new Padding(6);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(187, 49);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(38, 401);
            EnterCRUDUsuarioButton.Margin = new Padding(6);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(271, 105);
            EnterCRUDUsuarioButton.TabIndex = 4;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(38, 518);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(6);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(271, 105);
            EnterCRUDTipoAnomaliaButton.TabIndex = 5;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 258);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(708, 32);
            label2.TabIndex = 6;
            label2.Text = "(solo tiene permitido acceder a localidad y zona, y pedido_agreg)";
            // 
            // pedidoAgregacionButton
            // 
            pedidoAgregacionButton.Location = new Point(792, 502);
            pedidoAgregacionButton.Margin = new Padding(6);
            pedidoAgregacionButton.Name = "pedidoAgregacionButton";
            pedidoAgregacionButton.Size = new Size(271, 105);
            pedidoAgregacionButton.TabIndex = 7;
            pedidoAgregacionButton.Text = "CRUD Pedido de Agregacion";
            pedidoAgregacionButton.UseVisualStyleBackColor = true;
            pedidoAgregacionButton.Click += pedidoAgregacionButton_Click;
            // 
            // menuStripCazador
            // 
            menuStripCazador.BackColor = SystemColors.ControlLight;
            menuStripCazador.Dock = DockStyle.Left;
            menuStripCazador.ImageScalingSize = new Size(32, 32);
            menuStripCazador.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMasAjustes, realizarPedidoAgregacionToolStripMenuItem });
            menuStripCazador.Location = new Point(0, 0);
            menuStripCazador.Name = "menuStripCazador";
            menuStripCazador.Size = new Size(373, 770);
            menuStripCazador.TabIndex = 9;
            menuStripCazador.Text = "menuStripCazador";
            // 
            // toolStripMenuItemMasAjustes
            // 
            toolStripMenuItemMasAjustes.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemMasAjustes.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            toolStripMenuItemMasAjustes.Name = "toolStripMenuItemMasAjustes";
            toolStripMenuItemMasAjustes.Size = new Size(350, 36);
            toolStripMenuItemMasAjustes.Text = "Más Ajustes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(288, 44);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // realizarPedidoAgregacionToolStripMenuItem
            // 
            realizarPedidoAgregacionToolStripMenuItem.Margin = new Padding(5);
            realizarPedidoAgregacionToolStripMenuItem.Name = "realizarPedidoAgregacionToolStripMenuItem";
            realizarPedidoAgregacionToolStripMenuItem.Size = new Size(350, 36);
            realizarPedidoAgregacionToolStripMenuItem.Text = "Realizar Pedido de Agregación";
            realizarPedidoAgregacionToolStripMenuItem.Click += realizarPedidoAgregacionToolStripMenuItem_Click;
            // 
            // MenuCazador
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 770);
            Controls.Add(menuStripCazador);
            Controls.Add(pedidoAgregacionButton);
            Controls.Add(label2);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDLocalidadButton);
            Margin = new Padding(6);
            Name = "MenuCazador";
            Text = "Menu Cazador";
            FormClosing += MenuCazador_FormClosing;
            menuStripCazador.ResumeLayout(false);
            menuStripCazador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDLocalidadButton;
        private Button btnCrudZona;
        private Label label1;
        private Button logoutButton;
        private Button EnterCRUDUsuarioButton;
        private Button EnterCRUDTipoAnomaliaButton;
        private Label label2;
        private Button pedidoAgregacionButton;
        private MenuStrip menuStripCazador;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem realizarPedidoAgregacionToolStripMenuItem;
    }
}