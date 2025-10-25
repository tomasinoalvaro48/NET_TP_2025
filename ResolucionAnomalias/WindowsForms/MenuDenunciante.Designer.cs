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
            CloseProgramButton = new Button();
            label1 = new Label();
            EnterCRUDLocalidadButton = new Button();
            btnCrudZona = new Button();
            EnterCRUDUsuarioButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(37, 142);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(168, 50);
            EnterCRUDTipoAnomaliaButton.TabIndex = 0;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.Location = new Point(359, 227);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(135, 23);
            CloseProgramButton.TabIndex = 1;
            CloseProgramButton.Text = "Cerrar programa";
            CloseProgramButton.UseVisualStyleBackColor = true;
            CloseProgramButton.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(272, 15);
            label1.TabIndex = 2;
            label1.Text = "(menu temporal hasta que agreguemos el pedido)";
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(220, 78);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(168, 50);
            EnterCRUDLocalidadButton.TabIndex = 3;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(220, 142);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(168, 50);
            btnCrudZona.TabIndex = 4;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(37, 78);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(168, 50);
            EnterCRUDUsuarioButton.TabIndex = 5;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(306, 15);
            label2.TabIndex = 6;
            label2.Text = "(por ahora solo tiene permitido acceder a tipo_anomalia)";
            // 
            // MenuDenunciante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 262);
            Controls.Add(label2);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDLocalidadButton);
            Controls.Add(label1);
            Controls.Add(CloseProgramButton);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Name = "MenuDenunciante";
            Text = "Menu Denunciante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDTipoAnomaliaButton;
        private Button CloseProgramButton;
        private Label label1;
        private Button EnterCRUDLocalidadButton;
        private Button btnCrudZona;
        private Button EnterCRUDUsuarioButton;
        private Label label2;
    }
}