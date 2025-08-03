using Domain.Model;
using DTOs;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                    this.Denunciante.Telefono = int.Parse(telefonoTextBox.Text);
                    this.Denunciante.Direccion_den = direccionTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        //await DenuncianteApiDenunciante.UpdateAsync(this.Denunciante);
                        await DenuncianteApiDenunciante.UpdateAsync(DenuncianteMapper.ToEntity(this.Denunciante));
                    }
                    else
                    {
                        //await DenuncianteApiDenunciante.AddAsync(this.Denunciante);
                        await DenuncianteApiDenunciante.AddAsync(DenuncianteMapper.ToEntity(this.Denunciante));
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
            this.telefonoTextBox.Text = this.Denunciante.Telefono.ToString();
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
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El Teléfono es Requerido");
            }

            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "La Dirección es Requerida");
            }

            return isValid;
        }
    }
}

public static class DenuncianteMapper
{
    public static Domain.Model.Denunciante ToEntity(DTOs.DenuncianteDTO dto)
    {
        return new Domain.Model.Denunciante(
            dto.Cod_den,
            dto.Nombre_den,
            dto.Telefono,
            dto.Direccion_den
        );
    }

    public static DTOs.DenuncianteDTO ToDTO(Domain.Model.Denunciante entity)
    {
        return new DTOs.DenuncianteDTO
        {
            Cod_den = entity.Cod_den,
            Nombre_den = entity.Nombre_den,
            Direccion_den = entity.Direccion_den,
            Telefono = entity.Telefono
        };
    }
}