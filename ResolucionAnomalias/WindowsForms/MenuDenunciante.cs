using API.Clients;
using WindowsForms.FormsPedidoResolucion;
using DTOs;

namespace WindowsForms
{
    public partial class MenuDenunciante : Form
    {
        private bool CierreManual = true;
        
        public MenuDenunciante()
        {
            InitializeComponent();
            MostrarPaginaInicio();
        }

        private void MostrarPaginaInicio()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(buttonVolver);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(buttonRealizarPedido);
            panelContent.Controls.Add(buttonPedidoResolucion);
            buttonVolver.Visible = false;
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            panelContent.Controls.Clear();
            // botón volver
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

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            //AuthServiceProvider.Instance.ClearSession();

            CierreManual = false;
            this.Close();
        }

        private async void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            // AuthServiceProvider.Instance.ClearSession();

            CierreManual = false;
            this.Close();
        }

        private async void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
            if (user == null || !string.Equals(user.Tipo_usu, "Denunciante", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Solo un denunciante puede realizar pedidos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new PedidoResolucionDTO
            {
                Fecha = DateTime.Now,
                DenuncianteId = user.Cod_usu,
                DenuncianteNombre = user.Nombre_usu
            };

            var frm = new DetallePedidoResolucion(FormMode.Add, dto);
            
            frm.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(frm);
        }

        private void buttonPedidoResolucion_Click(object sender, EventArgs e)
        {
            var pedidoResolucion = new ListaPedidoResolucion();
            
            pedidoResolucion.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoResolucion);
        }

        private void cambiarContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cambiarContrasenaUsuario = new CambiarContrasenaUsuario();
            
            cambiarContrasenaUsuario.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            
            CargarFormularioEnPanel(cambiarContrasenaUsuario);
        }

        private async void MenuDenunciante_FormClosing(object sender, FormClosingEventArgs e)
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
                    // AuthServiceProvider.Instance.ClearSession();

                    Application.Exit();
                }
            }
        }
    }
}