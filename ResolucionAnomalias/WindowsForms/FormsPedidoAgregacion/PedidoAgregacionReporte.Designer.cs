namespace WindowsForms.FormsPedidoAgregacion
{
    partial class PedidoAgregacionReporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            comboEstado = new ComboBox();
            generarButton = new Button();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(217, 22);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(173, 23);
            comboEstado.TabIndex = 0;
            // 
            // generarButton
            // 
            generarButton.Location = new Point(312, 66);
            generarButton.Name = "generarButton";
            generarButton.Size = new Size(138, 23);
            generarButton.TabIndex = 1;
            generarButton.Text = "Generar Reporte";
            generarButton.UseVisualStyleBackColor = true;
            generarButton.Click += generarButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 403);
            dataGridView1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(28, 149);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(497, 276);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 4;
            label1.Text = "Filtrar pedidos por su estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 111);
            label2.Name = "label2";
            label2.Size = new Size(322, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de pedidos realizados para el estado seleccionado:";
            // 
            // PedidoAgregacionReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(generarButton);
            Controls.Add(comboEstado);
            Name = "PedidoAgregacionReporte";
            Text = "Reporte de Pedidos de Agregacion de Anomalias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboEstado;
        private Button generarButton;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Label label2;
    }
}