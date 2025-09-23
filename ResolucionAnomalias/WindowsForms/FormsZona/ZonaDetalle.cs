using DTOs;
using API.Clients;

namespace WindowsForms.FormsZona
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class ZonaDetalle : Form
    {
        private ZonaDTO zona;
        private FormMode mode;

        public ZonaDTO Zona
        {
            get { return zona; }
            set
            {
                zona = value;
                this.SetZona();
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set { SetFormMode(value); }
        }

        public ZonaDetalle()
        {
            InitializeComponent();
            LoadLocalidades();
            mode = FormMode.Add;
        }

        private async void LoadLocalidades()
        {
            try
            {
                var localidades = await LocalidadApiClient.GetAllAsync();
                comboBoxLocalidad.DataSource = localidades.ToList();
                comboBoxLocalidad.DisplayMember = "Nombre";
                comboBoxLocalidad.ValueMember = "ID";
                comboBoxLocalidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetZona()
        {
            this.textBoxId.Text = this.Zona.Id.ToString();
            this.textBoxNombre.Text = this.Zona.Nombre;
            this.comboBoxLocalidad.SelectedValue = this.Zona.LocalidadId;

        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                labelId.Visible = false;
                textBoxId.Visible = false;

            }
            if (mode == FormMode.Update)
            {
                labelId.Visible = true;
                textBoxId.Visible = true;

            }
        }

        private bool ValidateZona()
        {
            bool isValid = true;
            errorProvider.SetError(textBoxNombre, string.Empty);
            errorProvider.SetError(comboBoxLocalidad, string.Empty);

            if (this.textBoxNombre.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBoxNombre, "El nombre es requerido");
            }
            if (this.comboBoxLocalidad.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBoxLocalidad, "Debe seleccionar una localidad");
            }
            return isValid;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateZona())
            {
                try
                {
                    this.zona.Nombre = textBoxNombre.Text;
                    this.zona.LocalidadId = (int)comboBoxLocalidad.SelectedValue;
                    if(this.Mode == FormMode.Update)
                    {
                        await ZonaApiClient.UpdateAsync(this.zona);
                    }
                    else
                    {
                        await ZonaApiClient.AddAsync(this.zona);
                    }
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