using API.Clients;
using API.Clients.EntitiesClients;
using WindowsForms.FormsPedidoAgregacion;
using WindowsForms.FormsPedidoResolucion;
using WindowsForms.FormsTipoAnomalia;
using WindowsForms.FormsUsuario;
using WindowsForms.FormsZona;
using System.Diagnostics;


namespace WindowsForms
{
    public partial class MenuOperador : Form
    {
        private bool CierreManual = true;
        public MenuOperador()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioLista usuarioLista = new UsuarioLista();
            usuarioLista.ShowDialog();
        }

        private void tiposDeAnomaliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnomaliaLista tipoLista = new TipoAnomaliaLista();
            tipoLista.ShowDialog();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadLista localidadLista = new LocalidadLista();
            localidadLista.ShowDialog();
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZonaLista zonaLista = new ZonaLista();
            zonaLista.ShowDialog();
        }

        private void pedidosDeAgregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoAgregacionLista pedidoAg = new PedidoAgregacionLista();
            pedidoAg.ShowDialog();
        }

        private async void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var pdfBytes = await ReporteApiClient.ObtenerReportePedidosAgregacionCategoriasAsync();

                var tempPath = Path.GetTempPath();
                var fileName = $"ReportePedidosAgregacion_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                var fullPath = Path.Combine(tempPath, fileName);

                await File.WriteAllBytesAsync(fullPath, pdfBytes);

                var psi = new ProcessStartInfo(fullPath) { UseShellExecute = true };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar/abrir el reporte de agregación: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            //AuthServiceProvider.Instance.ClearSession();

            CierreManual = false;
            this.Close();
        }

        private void verPedidosDeResoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPedidoResolucion pedidoResolucion = new ListaPedidoResolucion();
            pedidoResolucion.ShowDialog();
        }

        private async void MenuOperador_FormClosing(object sender, FormClosingEventArgs e)
        {
            // usuario cerró con la cruz:
            if (CierreManual && e.CloseReason == CloseReason.UserClosing)
            {
                // Cancelar el cierre temporalmente para mostrar el diálogo
                e.Cancel = true;

                string message = "¿Cerrar sesión y salir de la aplicación?";
                string caption = "¿Desea cerrar sesión y salir de la aplicación?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                
                if (result == DialogResult.Yes)
                {
                    CierreManual = false;
                    
                    //logout
                    await AuthServiceProvider.Instance.LogoutAsync();
                    //AuthServiceProvider.Instance.ClearSession();

                    Application.Exit();
                }
            }
        }

        private async void veToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var pdfBytes = await ReporteApiClient.ObtenerReportePedidosResolucionMesActualAsync();

                // Guardar en archivo temporal
                var tempPath = Path.GetTempPath();
                var fileName = $"ReportePedidosResolucion_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                var fullPath = Path.Combine(tempPath, fileName);

                await File.WriteAllBytesAsync(fullPath, pdfBytes);

                // Abrir con el visor PDF predeterminado
                var psi = new ProcessStartInfo(fullPath) { UseShellExecute = true };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar/abrir el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}