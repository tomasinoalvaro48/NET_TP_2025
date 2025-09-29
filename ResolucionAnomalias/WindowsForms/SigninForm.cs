using API.Clients.EntitiesClients;
using Domain.Model;
using DTOs;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SigninForm : Form
    {
        private UsuarioDTO usuario;
        public SigninForm()
        {
            InitializeComponent();
            LoadLocalidades();
            LoadZonas();
        }
        public UsuarioDTO Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }
        private void SetUsuario()
        {
            this.nombreTextBox.Text = this.Usuario.Nombre_usu;
            this.emailTextBox.Text = this.Usuario.Email_usu;
            this.contraseniaTextBox.Text = this.Usuario.Passw_usu;

            this.localidadComboBox.SelectedValue = this.Usuario.LocalidadId;
            this.zonaComboBox.SelectedValue = this.Usuario.ZonaId;
        }
        private async void LoadLocalidades()
        {
            try
            {
                var localidades = await LocalidadApiClient.GetAllAsync();
                localidadComboBox.DataSource = localidades.ToList();
                localidadComboBox.DisplayMember = "Nombre";
                localidadComboBox.ValueMember = "ID";
                localidadComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadZonas()
        {
            try
            {
                var zonas = await ZonaApiClient.GetAllAsync();
                zonaComboBox.DataSource = zonas.ToList();
                zonaComboBox.DisplayMember = "Nombre";
                zonaComboBox.ValueMember = "ID";
                zonaComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar zonas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateUsuario()
        {
            bool isValid = true;
            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);
            errorProvider.SetError(localidadComboBox, string.Empty);
            errorProvider.SetError(zonaComboBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre es requerido");
            }
            else if (!Regex.IsMatch(nombreTextBox.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre no puede tener números");
            }

            if (this.emailTextBox.Text == string.Empty || !Regex.IsMatch(emailTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "Debe ingresar un email válido");
            }

            if (this.contraseniaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(contraseniaTextBox, "La contraseña es requerida");
            }
            else if (contraseniaTextBox.Text.Length < 6)
            {
                isValid = false;
                errorProvider.SetError(contraseniaTextBox, "La contraseña debe tener mínimo 6 caracteres");
            }

            if (localidadComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(localidadComboBox, "Debe seleccionar una localidad");
            }

            if (zonaComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(zonaComboBox, "Debe seleccionar una zona");
            }

            return isValid;
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void registrarseButon_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsuario())
            {
                try
                {
                    this.usuario.Nombre_usu = nombreTextBox.Text;
                    this.usuario.Email_usu = emailTextBox.Text;
                    this.usuario.Passw_usu = contraseniaTextBox.Text;
                    this.usuario.Tipo_usu = "Cazador";
                    this.usuario.LocalidadId = (int)localidadComboBox.SelectedValue;
                    this.usuario.ZonaId = (int)zonaComboBox.SelectedValue;
                    
                    await UsuarioApiClient.AddAsync(this.usuario);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
