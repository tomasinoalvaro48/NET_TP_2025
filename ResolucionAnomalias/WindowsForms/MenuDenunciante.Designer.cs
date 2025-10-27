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
            EnterCRUDTipoAnomaliaButton = new Button();
            logoutButton = new Button();
            label1 = new Label();
            EnterCRUDLocalidadButton = new Button();
            btnCrudZona = new Button();
            EnterCRUDUsuarioButton = new Button();
            label2 = new Label();
            menuStripDenunciante = new MenuStrip();
            toolStripMenuItemMasAjustes = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            realizarPedidoToolStripMenuItem = new ToolStripMenuItem();
            buttonPedidoResolucion = new Button();
            menuStripDenunciante.SuspendLayout();
            SuspendLayout();
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(42, 189);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(4, 4, 4, 4);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(192, 67);
            EnterCRUDTipoAnomaliaButton.TabIndex = 0;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
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
            label1.Text = "(menu temporal hasta que agreguemos el pedido)";
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(252, 104);
            EnterCRUDLocalidadButton.Margin = new Padding(4, 4, 4, 4);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(192, 67);
            EnterCRUDLocalidadButton.TabIndex = 3;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(252, 189);
            btnCrudZona.Margin = new Padding(4, 4, 4, 4);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(192, 67);
            btnCrudZona.TabIndex = 4;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(42, 104);
            EnterCRUDUsuarioButton.Margin = new Padding(4, 4, 4, 4);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(192, 67);
            EnterCRUDUsuarioButton.TabIndex = 5;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(390, 20);
            label2.TabIndex = 6;
            label2.Text = "(por ahora solo tiene permitido acceder a tipo_anomalia)";
            // 
            // menuStripDenunciante
            // 
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
            Controls.Add(label2);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDLocalidadButton);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MenuDenunciante";
            Text = "Menu Denunciante";
            menuStripDenunciante.ResumeLayout(false);
            menuStripDenunciante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDTipoAnomaliaButton;
        private Button logoutButton;
        private Label label1;
        private Button EnterCRUDLocalidadButton;
        private Button btnCrudZona;
        private Button EnterCRUDUsuarioButton;
        private Label label2;
        private MenuStrip menuStripDenunciante;
        private ToolStripMenuItem toolStripMenuItemMasAjustes;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private Button buttonPedidoResolucion;
    }
}