namespace WindowsForms.FormsPedidoAgregacion
{
    partial class PedidoAgregacionLista
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
            pedidosAgregacionDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            buttonAceptar = new Button();
            buttonRechazar = new Button();
            ((System.ComponentModel.ISupportInitialize)pedidosAgregacionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // pedidosAgregacionDataGridView
            // 
            pedidosAgregacionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pedidosAgregacionDataGridView.Location = new Point(21, 24);
            pedidosAgregacionDataGridView.Name = "pedidosAgregacionDataGridView";
            pedidosAgregacionDataGridView.Size = new Size(755, 301);
            pedidosAgregacionDataGridView.TabIndex = 0;
            pedidosAgregacionDataGridView.SelectionChanged += pedidosAgregacionDataGridView_SelectionChanged;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(663, 353);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(113, 23);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Nuevo pedido";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(499, 353);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(125, 23);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar pedido";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(341, 353);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(121, 23);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar pedido";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(125, 331);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 4;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonRechazar
            // 
            buttonRechazar.Location = new Point(21, 331);
            buttonRechazar.Name = "buttonRechazar";
            buttonRechazar.Size = new Size(75, 23);
            buttonRechazar.TabIndex = 5;
            buttonRechazar.Text = "Rechazar";
            buttonRechazar.UseVisualStyleBackColor = true;
            buttonRechazar.Click += buttonRechazar_Click;
            // 
            // PedidoAgregacionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(buttonRechazar);
            Controls.Add(buttonAceptar);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(pedidosAgregacionDataGridView);
            Name = "PedidoAgregacionLista";
            Text = "Pedidos de agregacion de anomalías";
            Load += PedidosAgregacion_Load;
            ((System.ComponentModel.ISupportInitialize)pedidosAgregacionDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pedidosAgregacionDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private Button buttonAceptar;
        private Button buttonRechazar;
    }
}