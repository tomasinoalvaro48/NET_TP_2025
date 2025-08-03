namespace WindowsForms
{
    partial class LocalidadDetalle
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
            labelCodigoLoc = new Label();
            labelNombreLoc = new Label();
            buttonAceptarDetLoc = new Button();
            buttonCancelarLocDet = new Button();
            errorProvider = new ErrorProvider(components);
            textBoxCodigoLoc = new TextBox();
            textBoxNombreLoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelCodigoLoc
            // 
            labelCodigoLoc.AutoSize = true;
            labelCodigoLoc.Location = new Point(95, 122);
            labelCodigoLoc.Name = "labelCodigoLoc";
            labelCodigoLoc.Size = new Size(65, 20);
            labelCodigoLoc.TabIndex = 0;
            labelCodigoLoc.Text = "Codigo: ";
            // 
            // labelNombreLoc
            // 
            labelNombreLoc.AutoSize = true;
            labelNombreLoc.Location = new Point(95, 171);
            labelNombreLoc.Name = "labelNombreLoc";
            labelNombreLoc.Size = new Size(67, 20);
            labelNombreLoc.TabIndex = 1;
            labelNombreLoc.Text = "Nombre:";
            // 
            // buttonAceptarDetLoc
            // 
            buttonAceptarDetLoc.Location = new Point(348, 244);
            buttonAceptarDetLoc.Name = "buttonAceptarDetLoc";
            buttonAceptarDetLoc.Size = new Size(94, 29);
            buttonAceptarDetLoc.TabIndex = 2;
            buttonAceptarDetLoc.Text = "Aceptar";
            buttonAceptarDetLoc.UseVisualStyleBackColor = true;
            buttonAceptarDetLoc.Click += aceptarButton_Click;
            // 
            // buttonCancelarLocDet
            // 
            buttonCancelarLocDet.Location = new Point(116, 244);
            buttonCancelarLocDet.Name = "buttonCancelarLocDet";
            buttonCancelarLocDet.Size = new Size(94, 29);
            buttonCancelarLocDet.TabIndex = 3;
            buttonCancelarLocDet.Text = "Cancelar";
            buttonCancelarLocDet.UseVisualStyleBackColor = true;
            buttonCancelarLocDet.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // textBoxCodigoLoc
            // 
            textBoxCodigoLoc.BackColor = SystemColors.ControlLightLight;
            textBoxCodigoLoc.Location = new Point(183, 122);
            textBoxCodigoLoc.Name = "textBoxCodigoLoc";
            textBoxCodigoLoc.Size = new Size(210, 27);
            textBoxCodigoLoc.TabIndex = 4;

            //textBoxCodigoLoc.TextChanged += textBoxCodigoLoc_TextChanged;
           
            // 
            // textBoxNombreLoc
            // 
            textBoxNombreLoc.Location = new Point(183, 171);
            textBoxNombreLoc.Name = "textBoxNombreLoc";
            textBoxNombreLoc.Size = new Size(210, 27);
            textBoxNombreLoc.TabIndex = 4;
            // 
            // LocalidadDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 365);
            Controls.Add(textBoxNombreLoc);
            Controls.Add(textBoxCodigoLoc);
            Controls.Add(buttonCancelarLocDet);
            Controls.Add(buttonAceptarDetLoc);
            Controls.Add(labelNombreLoc);
            Controls.Add(labelCodigoLoc);
            Name = "LocalidadDetalle";
            Text = "Localidad";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCodigoLoc;
        private Label labelNombreLoc;
        private Button buttonAceptarDetLoc;
        private Button buttonCancelarLocDet;
        private TextBox textBoxCodigoLoc;
        private TextBox textBoxNombreLoc;
        private ErrorProvider errorProvider;
    }
}