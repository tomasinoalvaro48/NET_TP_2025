namespace WindowsForms
{
    partial class CambiarContrasenaUsuario
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
            label2 = new Label();
            label3 = new Label();
            textBoxContrasenaActual = new TextBox();
            textBoxNuevaContrasena = new TextBox();
            textBoxRepetirNuevaContrasena = new TextBox();
            label4 = new Label();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 148);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 0;
            label1.Text = "Contraseña actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 228);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 1;
            label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 301);
            label3.Name = "label3";
            label3.Size = new Size(288, 32);
            label3.TabIndex = 2;
            label3.Text = "Repita Nueva Contraseña:";
            // 
            // textBoxContrasenaActual
            // 
            textBoxContrasenaActual.Location = new Point(363, 145);
            textBoxContrasenaActual.Name = "textBoxContrasenaActual";
            textBoxContrasenaActual.Size = new Size(200, 39);
            textBoxContrasenaActual.TabIndex = 3;
            // 
            // textBoxNuevaContrasena
            // 
            textBoxNuevaContrasena.Location = new Point(363, 225);
            textBoxNuevaContrasena.Name = "textBoxNuevaContrasena";
            textBoxNuevaContrasena.Size = new Size(200, 39);
            textBoxNuevaContrasena.TabIndex = 4;
            // 
            // textBoxRepetirNuevaContrasena
            // 
            textBoxRepetirNuevaContrasena.Location = new Point(363, 301);
            textBoxRepetirNuevaContrasena.Name = "textBoxRepetirNuevaContrasena";
            textBoxRepetirNuevaContrasena.Size = new Size(200, 39);
            textBoxRepetirNuevaContrasena.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(250, 43);
            label4.Name = "label4";
            label4.Size = new Size(259, 34);
            label4.TabIndex = 6;
            label4.Text = "Cambio de Contraseña";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(177, 397);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(150, 46);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(413, 397);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(150, 46);
            buttonConfirmar.TabIndex = 8;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // CambiarContrasenaUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 502);
            Controls.Add(buttonConfirmar);
            Controls.Add(buttonCancelar);
            Controls.Add(label4);
            Controls.Add(textBoxRepetirNuevaContrasena);
            Controls.Add(textBoxNuevaContrasena);
            Controls.Add(textBoxContrasenaActual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CambiarContrasenaUsuario";
            Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxContrasenaActual;
        private TextBox textBoxNuevaContrasena;
        private TextBox textBoxRepetirNuevaContrasena;
        private Label label4;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private ErrorProvider errorProvider;
    }
}