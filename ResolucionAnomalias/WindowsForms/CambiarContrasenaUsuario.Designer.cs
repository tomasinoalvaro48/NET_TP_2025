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
            label1.Location = new Point(76, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 2;
            label3.Text = "Repita Nueva Contraseña:";
            // 
            // textBoxContrasenaActual
            // 
            textBoxContrasenaActual.Location = new Point(195, 68);
            textBoxContrasenaActual.Margin = new Padding(2, 1, 2, 1);
            textBoxContrasenaActual.Name = "textBoxContrasenaActual";
            textBoxContrasenaActual.Size = new Size(110, 23);
            textBoxContrasenaActual.TabIndex = 3;
            textBoxContrasenaActual.UseSystemPasswordChar = true;
            // 
            // textBoxNuevaContrasena
            // 
            textBoxNuevaContrasena.Location = new Point(195, 105);
            textBoxNuevaContrasena.Margin = new Padding(2, 1, 2, 1);
            textBoxNuevaContrasena.Name = "textBoxNuevaContrasena";
            textBoxNuevaContrasena.Size = new Size(110, 23);
            textBoxNuevaContrasena.TabIndex = 4;
            textBoxNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // textBoxRepetirNuevaContrasena
            // 
            textBoxRepetirNuevaContrasena.Location = new Point(195, 141);
            textBoxRepetirNuevaContrasena.Margin = new Padding(2, 1, 2, 1);
            textBoxRepetirNuevaContrasena.Name = "textBoxRepetirNuevaContrasena";
            textBoxRepetirNuevaContrasena.Size = new Size(110, 23);
            textBoxRepetirNuevaContrasena.TabIndex = 5;
            textBoxRepetirNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(135, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 6;
            label4.Text = "Cambio de Contraseña";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(95, 186);
            buttonCancelar.Margin = new Padding(2, 1, 2, 1);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(81, 22);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(222, 186);
            buttonConfirmar.Margin = new Padding(2, 1, 2, 1);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(81, 22);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 235);
            Controls.Add(buttonConfirmar);
            Controls.Add(buttonCancelar);
            Controls.Add(label4);
            Controls.Add(textBoxRepetirNuevaContrasena);
            Controls.Add(textBoxNuevaContrasena);
            Controls.Add(textBoxContrasenaActual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
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