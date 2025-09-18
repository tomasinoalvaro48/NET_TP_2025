using System.Windows.Forms;

namespace WindowsForms.FormsZona
{
    partial class ZonaDetalle
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
            errorProvider = new ErrorProvider(components);
            btnAceptar = new Button();
            btnCancelar = new Button();
            labelId = new Label();
            labelNombre = new Label();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            labelIdLocalidad = new Label();
            comboBoxLocalidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(443, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(206, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(206, 103);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(206, 149);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.ControlLight;
            textBoxId.Location = new Point(352, 96);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(185, 27);
            textBoxId.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(352, 146);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(185, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // labelIdLocalidad
            // 
            labelIdLocalidad.AutoSize = true;
            labelIdLocalidad.Location = new Point(206, 197);
            labelIdLocalidad.Name = "labelIdLocalidad";
            labelIdLocalidad.Size = new Size(74, 20);
            labelIdLocalidad.TabIndex = 8;
            labelIdLocalidad.Text = "Localidad";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(352, 197);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(185, 28);
            comboBoxLocalidad.TabIndex = 9;
            // 
            // ZonaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(labelIdLocalidad);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxId);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ZonaDetalle";
            Text = "Zona";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();

            //Load += ZonaDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label labelId;
        private Label labelNombre;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private Label labelIdLocalidad;
        private ComboBox comboBoxLocalidad;
        private ErrorProvider errorProvider;
    }
}