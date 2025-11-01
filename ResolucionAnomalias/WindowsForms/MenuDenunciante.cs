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

            using var frm = new DetallePedidoResolucion(FormMode.Add, dto);
            frm.ShowDialog();
        }

        private void buttonPedidoResolucion_Click(object sender, EventArgs e)
        {
            ListaPedidoResolucion pedidoResolucion = new ListaPedidoResolucion();
            pedidoResolucion.ShowDialog();
        }

        private void cambiarContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContrasenaUsuario cambiarContrasenaUsuario = new CambiarContrasenaUsuario();
            cambiarContrasenaUsuario.ShowDialog();
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