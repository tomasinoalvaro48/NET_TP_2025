namespace WindowsForms
{
    partial class LocalidadLista
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
            dataGridViewLocalidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLocalidades
            // 
            dataGridViewLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalidades.Location = new Point(41, 66);
            dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            dataGridViewLocalidades.RowHeadersWidth = 51;
            dataGridViewLocalidades.Size = new Size(713, 288);
            dataGridViewLocalidades.TabIndex = 0;
            // 
            // LocalidadLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewLocalidades);
            Name = "LocalidadLista";
            Text = "LocalidadLista";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLocalidades;
    }
}