using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using API.Clients;
using System.Windows.Forms.DataVisualization.Charting;
using API.Clients.EntitiesClients;

namespace WindowsForms.FormsPedidoAgregacion
{
    public partial class PedidoAgregacionReporte : Form
    {
        public PedidoAgregacionReporte()
        {
            InitializeComponent();
            CargarEstados();
        }

        private void CargarEstados()
        {
            comboEstado.Items.Add("Pendiente");
            comboEstado.Items.Add("Aceptado");
            comboEstado.Items.Add("Rechazado");
        }

        private async void generarButton_Click(object sender, EventArgs e)
        {
            if (comboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            var all = await PedidoAgregacionApiClient.GetAllAsync();
            var filtrados = all.Where(p => p.Estado_pedido_agreg == comboEstado.SelectedItem.ToString()).ToList();

            dataGridView1.DataSource = filtrados;

            CargarGrafico(filtrados);
        }

        private void CargarGrafico(List<PedidoAgregacionDTO> pedidos)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("Main"));

            var serie = new Series("Pedidos")
            {
                ChartType = SeriesChartType.Column
            };

            // ejemplo: agrupar por dificultad
            var grupos = pedidos.GroupBy(p => p.Dificultad_pedido_agreg)
                               .Select(g => new { Dificultad = g.Key, Count = g.Count() });

            foreach (var g in grupos)
                serie.Points.AddXY($"Dif {g.Dificultad}", g.Count);

            chart1.Series.Add(serie);
        }
    }
}
