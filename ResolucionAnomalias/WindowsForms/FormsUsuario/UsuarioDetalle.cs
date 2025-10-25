using System.Text.RegularExpressions;
using DTOs;
using API.Clients.EntitiesClients;
using API.Clients;

namespace WindowsForms.FormsUsuario
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class UsuarioDetalle : Form
    {
        private UsuarioDTO usuario;
        private FormMode mode;

        public UsuarioDTO Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set { SetFormMode(value); }
        }

        public UsuarioDetalle()
        {
            InitializeComponent();
            LoadTiposUsuario();
            LoadLocalidades();
            LoadZonas();
            mode = FormMode.Add;

            ValidarPermisos();
        }

        private void LoadTiposUsuario()
        {
            tipoComboBox.Items.Clear();
            tipoComboBox.Items.Add("Operador");
            tipoComboBox.Items.Add("Cazador");
            tipoComboBox.Items.Add("Denunciante");
            tipoComboBox.SelectedIndex = -1;
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

        private void SetUsuario()
        {
            this.idTextBox.Text = this.Usuario.Cod_usu.ToString();
            this.nombreTextBox.Text = this.Usuario.Nombre_usu;
            this.emailTextBox.Text = this.Usuario.Email_usu;
            this.contraseniaTextBox.Text = this.Usuario.Passw_usu;
            this.tipoComboBox.SelectedItem = this.Usuario.Tipo_usu;

            this.localidadComboBox.SelectedValue = this.Usuario.LocalidadId;
            this.zonaComboBox.SelectedValue = this.Usuario.ZonaId;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;

            }
            if (mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;

            }
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;
            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);
            errorProvider.SetError(tipoComboBox, string.Empty);
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

            if (tipoComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(tipoComboBox, "Debe seleccionar un tipo de usuario");
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

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsuario())
            {
                try
                {
                    this.usuario.Nombre_usu = nombreTextBox.Text;
                    this.usuario.Email_usu = emailTextBox.Text;
                    this.usuario.Passw_usu = contraseniaTextBox.Text;
                    this.usuario.Tipo_usu = tipoComboBox.SelectedItem.ToString();
                    this.usuario.LocalidadId = (int)localidadComboBox.SelectedValue;
                    this.usuario.ZonaId = (int)zonaComboBox.SelectedValue;

                    if (this.Mode == FormMode.Update)
                    {
                        await UsuarioApiClient.UpdateAsync(this.usuario);
                    }
                    else
                    {
                        await UsuarioApiClient.AddAsync(this.usuario);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ValidarPermisos()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (user.Tipo_usu != "Operador")
            {
                MessageBox.Show("No tenés permisos para editar Usuarios", "Acceso denegado");
                this.Close();
            }
        }
    }
}