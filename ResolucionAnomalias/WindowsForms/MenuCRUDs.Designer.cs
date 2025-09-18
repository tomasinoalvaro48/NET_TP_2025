namespace WindowsForms
{
    partial class MenuCRUDs
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
            EnterCRUDDenuncianteButton = new Button();
            EnterCRUDLocalidadButton = new Button();
            CloseProgramButton = new Button();
            EnterCRUDTipoAnomaliaButton = new Button();
            btnCrudZona = new Button();
            SuspendLayout();
            // 
            // EnterCRUDDenuncianteButton
            // 
            EnterCRUDDenuncianteButton.Location = new Point(149, 152);
            EnterCRUDDenuncianteButton.Margin = new Padding(2, 2, 2, 2);
            EnterCRUDDenuncianteButton.Name = "EnterCRUDDenuncianteButton";
            EnterCRUDDenuncianteButton.Size = new Size(172, 57);
            EnterCRUDDenuncianteButton.TabIndex = 0;
            EnterCRUDDenuncianteButton.Text = "CRUD Denunciante";
            EnterCRUDDenuncianteButton.UseVisualStyleBackColor = true;
            EnterCRUDDenuncianteButton.Click += ButtonCRUDDenunciante_Click;
            // 
            // EnterCRUDLocalidadButton
            // 
            EnterCRUDLocalidadButton.Location = new Point(357, 152);
            EnterCRUDLocalidadButton.Margin = new Padding(2, 2, 2, 2);
            EnterCRUDLocalidadButton.Name = "EnterCRUDLocalidadButton";
            EnterCRUDLocalidadButton.Size = new Size(172, 57);
            EnterCRUDLocalidadButton.TabIndex = 1;
            EnterCRUDLocalidadButton.Text = "CRUD Localidad";
            EnterCRUDLocalidadButton.UseVisualStyleBackColor = true;
            EnterCRUDLocalidadButton.Click += ButtonCRUDLocalidad_Click;
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.AutoSize = true;
            CloseProgramButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseProgramButton.Location = new Point(553, 365);
            CloseProgramButton.Margin = new Padding(2, 2, 2, 2);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(128, 30);
            CloseProgramButton.TabIndex = 2;
            CloseProgramButton.Text = "Cerrar Programa";
            CloseProgramButton.UseVisualStyleBackColor = true;
            CloseProgramButton.Click += CloseProgram_Click;
            // 
            // EnterCRUDTipoAnomaliaButton
            // 
            EnterCRUDTipoAnomaliaButton.Location = new Point(149, 232);
            EnterCRUDTipoAnomaliaButton.Margin = new Padding(2, 2, 2, 2);
            EnterCRUDTipoAnomaliaButton.Name = "EnterCRUDTipoAnomaliaButton";
            EnterCRUDTipoAnomaliaButton.Size = new Size(172, 57);
            EnterCRUDTipoAnomaliaButton.TabIndex = 3;
            EnterCRUDTipoAnomaliaButton.Text = "CRUD Tipo de Anomalia";
            EnterCRUDTipoAnomaliaButton.UseVisualStyleBackColor = true;
            EnterCRUDTipoAnomaliaButton.Click += ButtonCRUDTipoAnomalia_Click;
            // 
            // btnCrudZona
            // 
            btnCrudZona.Location = new Point(357, 232);
            btnCrudZona.Name = "btnCrudZona";
            btnCrudZona.Size = new Size(172, 57);
            btnCrudZona.TabIndex = 4;
            btnCrudZona.Text = "CRUD Zona";
            btnCrudZona.UseVisualStyleBackColor = true;
            btnCrudZona.Click += btnCrudZona_Click;
            // 
            // MenuCRUDs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 399);
            Controls.Add(btnCrudZona);
            Controls.Add(EnterCRUDTipoAnomaliaButton);
            Controls.Add(CloseProgramButton);
            Controls.Add(EnterCRUDLocalidadButton);
            Controls.Add(EnterCRUDDenuncianteButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuCRUDs";
            Text = "Menu de CRUDs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterCRUDDenuncianteButton;
        private Button EnterCRUDLocalidadButton;
        private Button CloseProgramButton;
        private Button EnterCRUDTipoAnomaliaButton;
        private Button btnCrudZona;
    }
}