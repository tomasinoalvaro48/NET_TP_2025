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
            CloseProgramButton = new Button();
            EnterCRUDUsuarioButton = new Button();
            EnterCRUDTipoAnomaliaButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(264, 90);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(146, 49);
            EnterCRUDLocalidadButton.TabIndex = 0;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(264, 168);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(146, 49);
            btnCrudZona.TabIndex = 1;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(272, 15);
            label1.TabIndex = 2;
            label1.Text = "(menu temporal hasta que agreguemos el pedido)";
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.Location = new Point(372, 275);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(131, 23);
            CloseProgramButton.TabIndex = 3;
            CloseProgramButton.Text = "Cerrar programa";
            CloseProgramButton.UseVisualStyleBackColor = true;
            CloseProgramButton.Click += CloseProgram_Click;
            // 
            // EnterCRUDUsuarioButton
            // 
            EnterCRUDUsuarioButton.Location = new Point(73, 90);
            EnterCRUDUsuarioButton.Name = "EnterCRUDUsuarioButton";
            EnterCRUDUsuarioButton.Size = new Size(146, 49);
            EnterCRUDUsuarioButton.TabIndex = 4;
            EnterCRUDUsuarioButton.Text = "CRUD Usuario";
            EnterCRUDUsuarioButton.UseVisualStyleBackColor = true;
            EnterCRUDUsuarioButton.Click += ButtonCRUDUsuario_Click;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(73, 168);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(146, 49);
            EnterCRUDTipoAnomaliaButton.TabIndex = 5;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(316, 15);
            label2.TabIndex = 6;
            label2.Text = "(por ahora solo tiene permitido acceder a localidad y zona)";
            // 
            // MenuCazador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 310);
            Controls.Add(label2);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(EnterCRUDUsuarioButton);
            Controls.Add(CloseProgramButton);
            Controls.Add(label1);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDLocalidadButton);
            Name = "MenuCazador";
            Text = "Menu Cazador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDLocalidadButton;
        private Button btnCrudZona;
        private Label label1;
        private Button CloseProgramButton;
        private Button EnterCRUDUsuarioButton;
        private Button EnterCRUDTipoAnomaliaButton;
        private Label label2;
    }
}