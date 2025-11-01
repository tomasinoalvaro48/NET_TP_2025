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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelTitle = new Panel();
            panelFields = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelTitle.SuspendLayout();
            panelFields.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelFields, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelMain.Size = new Size(470, 320);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(label4);
            panelTitle.Dock = DockStyle.Fill;
            panelTitle.Location = new Point(3, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Padding = new Padding(10);
            panelTitle.Size = new Size(464, 50);
            panelTitle.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(444, 30);
            label4.TabIndex = 6;
            label4.Text = "Cambio de Contraseña";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(label1);
            panelFields.Controls.Add(textBoxContrasenaActual);
            panelFields.Controls.Add(label2);
            panelFields.Controls.Add(textBoxNuevaContrasena);
            panelFields.Controls.Add(label3);
            panelFields.Controls.Add(textBoxRepetirNuevaContrasena);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 59);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(30, 20, 30, 20);
            panelFields.Size = new Size(464, 192);
            panelFields.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 0;
            label1.Text = "Contraseña actual:";
            // 
            // textBoxContrasenaActual
            // 
            textBoxContrasenaActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxContrasenaActual.Font = new Font("Segoe UI", 10F);
            textBoxContrasenaActual.Location = new Point(220, 37);
            textBoxContrasenaActual.Name = "textBoxContrasenaActual";
            textBoxContrasenaActual.Size = new Size(214, 30);
            textBoxContrasenaActual.TabIndex = 3;
            textBoxContrasenaActual.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 1;
            label2.Text = "Nueva Contraseña:";
            // 
            // textBoxNuevaContrasena
            // 
            textBoxNuevaContrasena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNuevaContrasena.Font = new Font("Segoe UI", 10F);
            textBoxNuevaContrasena.Location = new Point(220, 87);
            textBoxNuevaContrasena.Name = "textBoxNuevaContrasena";
            textBoxNuevaContrasena.Size = new Size(214, 30);
            textBoxNuevaContrasena.TabIndex = 4;
            textBoxNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(40, 140);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Contraseña:";
            // 
            // textBoxRepetirNuevaContrasena
            // 
            textBoxRepetirNuevaContrasena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRepetirNuevaContrasena.Font = new Font("Segoe UI", 10F);
            textBoxRepetirNuevaContrasena.Location = new Point(220, 137);
            textBoxRepetirNuevaContrasena.Name = "textBoxRepetirNuevaContrasena";
            textBoxRepetirNuevaContrasena.Size = new Size(214, 30);
            textBoxRepetirNuevaContrasena.TabIndex = 5;
            textBoxRepetirNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancelar);
            panelButtons.Controls.Add(buttonConfirmar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 257);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(464, 60);
            panelButtons.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10F);
            buttonCancelar.Location = new Point(248, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 40);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonConfirmar.Font = new Font("Segoe UI", 10F);
            buttonConfirmar.Location = new Point(354, 10);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(100, 40);
            buttonConfirmar.TabIndex = 8;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // CambiarContrasenaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            MinimumSize = new Size(450, 320);
            Controls.Add(tableLayoutPanelMain);
            Name = "CambiarContrasenaUsuario";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelTitle;
        private Panel panelFields;
        private Panel panelButtons;
    }
}