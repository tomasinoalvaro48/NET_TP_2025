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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(720, 470);
            btnAceptar.Margin = new Padding(5, 5, 5, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(153, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(335, 470);
            btnCancelar.Margin = new Padding(5, 5, 5, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 46);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(335, 165);
            labelId.Margin = new Padding(5, 0, 5, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(42, 32);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(335, 238);
            labelNombre.Margin = new Padding(5, 0, 5, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(107, 32);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.ControlLight;
            textBoxId.Location = new Point(572, 154);
            textBoxId.Margin = new Padding(5, 5, 5, 5);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(298, 39);
            textBoxId.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(572, 234);
            textBoxNombre.Margin = new Padding(5, 5, 5, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(298, 39);
            textBoxNombre.TabIndex = 6;
            // 
            // labelIdLocalidad
            // 
            labelIdLocalidad.AutoSize = true;
            labelIdLocalidad.Location = new Point(335, 315);
            labelIdLocalidad.Margin = new Padding(5, 0, 5, 0);
            labelIdLocalidad.Name = "labelIdLocalidad";
            labelIdLocalidad.Size = new Size(114, 32);
            labelIdLocalidad.TabIndex = 8;
            labelIdLocalidad.Text = "Localidad";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(572, 315);
            comboBoxLocalidad.Margin = new Padding(5, 5, 5, 5);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(298, 40);
            comboBoxLocalidad.TabIndex = 9;
            // 
            // ZonaDetalle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 672);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(labelIdLocalidad);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxId);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ZonaDetalle";
            Text = "Zona";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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