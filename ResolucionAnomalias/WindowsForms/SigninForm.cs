using DTOs;
using WindowsForms.FormsUsuario;

namespace WindowsForms
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
            cargarDetalleDenunciante();
        }

        private void cargarDetalleDenunciante()
        {
            UsuarioDetalle usuDetalle = new UsuarioDetalle();

            UsuarioDTO usuarioNuevo = new UsuarioDTO();

            usuDetalle.Mode = (FormsUsuario.FormMode)FormMode.Add;
            usuDetalle.Usuario = usuarioNuevo;

            usuDetalle.TopLevel = false;             // No es ventana independiente
            usuDetalle.FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
            usuDetalle.Dock = DockStyle.Fill;        // Se ajusta al contenedor

            // Lo agregamos al panel
            this.Controls.Clear();
            this.Controls.Add(usuDetalle);

            usuDetalle.Show(); // Mostrar
        }
    }
}
