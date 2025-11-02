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
            MostrarPaginaInicio();
        }

        private void MostrarPaginaInicio()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(buttonVolver);
            panelContent.Controls.Add(flowLayoutPanelButtons);
            panelContent.Controls.Add(tituloLabel);
            buttonVolver.Visible = false;
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(buttonVolver);
            buttonVolver.Visible = true;
            buttonVolver.BringToFront();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContent.Controls.Add(formulario);
            formulario.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelContent.Controls.OfType<Form>().ToList())
            {
                control.Dispose();
            }
            MostrarPaginaInicio();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usuarioLista = new UsuarioLista();
            usuarioLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(usuarioLista);
        }

        private void tiposDeAnomaliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tipoLista = new TipoAnomaliaLista();
            tipoLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(tipoLista);
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var localidadLista = new LocalidadLista();
            localidadLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(localidadLista);
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zonaLista = new ZonaLista();
            zonaLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(zonaLista);
        }

        private void pedidosDeAgregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidoAg = new PedidoAgregacionLista();
            pedidoAg.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoAg);
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
            var pedidoResolucion = new ListaPedidoResolucion();
            pedidoResolucion.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoResolucion);
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