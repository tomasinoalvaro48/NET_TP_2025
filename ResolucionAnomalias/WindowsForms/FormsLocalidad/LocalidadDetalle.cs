using System.Text.RegularExpressions;
using DTOs;
using WindowsForms.FormsLocalidad;

namespace WindowsForms
{
    // public enum FormMode
    //{
    //Add,
    //     Update
    //}
    public partial class LocalidadDetalle : Form
    {
        private LocalidadDTO localidad;
        private FormMode mode;

        public LocalidadDTO Localidad
        {
            get { return localidad; }
            set
            {
                localidad = value;
                this.SetLocalidad();
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
                SerFormMode(value);
            }
        }

        public LocalidadDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateLocalidad())
            {
                try
                {

                    this.Localidad.Codigo = int.Parse(textBoxCodigoLoc.Text);
                    this.Localidad.Nombre = textBoxNombreLoc.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await LocalidadApiLocalidad.UpdateAsync(this.Localidad);
                    }
                    else
                    {
                        await LocalidadApiLocalidad.AddAsync(this.Localidad);
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

        private void SetLocalidad()
        {
            this.textBoxIdDetLoc.Text = this.Localidad.ID.ToString();
            if (this.Mode == FormMode.Add && this.Localidad.Codigo == 0)
                this.textBoxCodigoLoc.Text = string.Empty;
            else
                this.textBoxCodigoLoc.Text = this.Localidad.Codigo.ToString();
            this.textBoxNombreLoc.Text = this.Localidad.Nombre;
        }

        private void SerFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                labelIdDetLoc.Visible = false;
                textBoxIdDetLoc.Visible = false;
                labelCodigoLoc.Visible = true;
                textBoxCodigoLoc.Visible = true;
                labelNombreLoc.Visible = true;
                textBoxNombreLoc.Visible = true;
            }
            if (mode == FormMode.Update)
            {
                labelIdDetLoc.Visible = true;
                textBoxIdDetLoc.Visible = true;
                labelCodigoLoc.Visible = true;
                textBoxCodigoLoc.Visible = true;
                labelNombreLoc.Visible = true;
                textBoxNombreLoc.Visible = true;
            }

        }

        private bool ValidateLocalidad()
        {
            bool valid = true;
            errorProvider.SetError(textBoxCodigoLoc, string.Empty);
            errorProvider.SetError(textBoxNombreLoc, string.Empty);

            if (this.textBoxCodigoLoc.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(textBoxCodigoLoc, "El código es requerido");
            }
            else if (!Regex.IsMatch(textBoxCodigoLoc.Text, @"^\d+$"))
            {
                valid = false;
                errorProvider.SetError(textBoxCodigoLoc, "El código no puede tener letras ni espacios");
            }

            if (this.textBoxNombreLoc.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(textBoxNombreLoc, "El nombre es requerido");
            }
            else if (!Regex.IsMatch(textBoxNombreLoc.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                valid = false;
                errorProvider.SetError(textBoxNombreLoc, "El nombre no puede tener números");
            }

            return valid;
        }

        private void textBoxCodigoLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdDetLoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}