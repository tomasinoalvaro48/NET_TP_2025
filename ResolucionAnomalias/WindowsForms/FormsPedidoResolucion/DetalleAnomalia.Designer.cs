namespace WindowsForms.FormsPedidoResolucion
{
    partial class DetalleAnomalia
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            comboBoxTipoAnomalia = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 160);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Anomalia";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(572, 275);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(427, 275);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(94, 29);
            buttonAceptar.TabIndex = 2;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // comboBoxTipoAnomalia
            // 
            comboBoxTipoAnomalia.FormattingEnabled = true;
            comboBoxTipoAnomalia.Location = new Point(281, 160);
            comboBoxTipoAnomalia.Name = "comboBoxTipoAnomalia";
            comboBoxTipoAnomalia.Size = new Size(374, 28);
            comboBoxTipoAnomalia.TabIndex = 3;
            comboBoxTipoAnomalia.SelectedIndexChanged += comboBoxTipoAnomalia_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DetalleAnomalia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 337);
            Controls.Add(comboBoxTipoAnomalia);
            Controls.Add(buttonAceptar);
            Controls.Add(buttonCancelar);
            Controls.Add(label1);
            Name = "DetalleAnomalia";
            Text = "DetalleAnomalia";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private ComboBox comboBoxTipoAnomalia;
        private ErrorProvider errorProvider1;
    }
}