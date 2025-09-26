using System.Text.RegularExpressions;
using DTOs;
using API.Clients.EntitiesClients;

namespace WindowsForms
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class DenuncianteDetalle : Form
    {
        private DenuncianteDTO denunciante;
        private FormMode mode;

        public DenuncianteDTO Denunciante
        {
            get { return denunciante; }
            set
            {
                denunciante = value;
                this.SetDenunciante();
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }

        public DenuncianteDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateDenunciante())
            {
                try
                {
                    this.Denunciante.Nombre_den = nombreTextBox.Text;
                    this.Denunciante.Telefono = telefonoTextBox.Text;
                    this.Denunciante.Direccion_den = direccionTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await DenuncianteApiClient.UpdateAsync(this.Denunciante);
                    }
                    else
                    {
                        await DenuncianteApiClient.AddAsync(this.Denunciante);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDenunciante()
        {
            this.codigoTextBox.Text = this.Denunciante.Cod_den.ToString();
            this.nombreTextBox.Text = this.Denunciante.Nombre_den;
            this.telefonoTextBox.Text = this.Denunciante.Telefono;
            this.direccionTextBox.Text = this.Denunciante.Direccion_den;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                codigoLabel.Visible = false;
                codigoTextBox.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                codigoLabel.Visible = true;
                codigoTextBox.Visible = true;
            }
        }

        private bool ValidateDenunciante()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(telefonoTextBox, string.Empty);
            errorProvider.SetError(direccionTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre es requerido");
            }
            else if (!Regex.IsMatch(nombreTextBox.Text, @"^[a-zA-Z·ÈÌÛ˙¡…Õ”⁄Ò—\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre no puede tener n˙meros");
            }

            if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El telÈfono es requerido");
            }
            else if (!Regex.IsMatch(telefonoTextBox.Text, @"^\d+$"))
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El telÈfono no puede tener letras ni espacios");
            }

            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "La direcciÛn es requerida");
            }
            else if (!Regex.IsMatch(direccionTextBox.Text, @"^(?=.*\d)[0-9a-zA-Z·ÈÌÛ˙¡…Õ”⁄Ò—\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "Formato direcciÛn: Calle + Altura");
            }

            return isValid;
        }
    }
}