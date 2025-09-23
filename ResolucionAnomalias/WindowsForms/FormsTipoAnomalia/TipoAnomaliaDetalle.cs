using DTOs;
using WindowsForms.FormsTipoAnomalia;

namespace WindowsForms.FormsTipoAnomalia
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class TipoAnomaliaDetalle : Form
    {
        private TipoAnomaliaDTO tipo;
        private Button buttonAceptarTipoDetalle;
        private Button buttonCancelarTipoDetalle;
        private Label LabelCodigoTipoDetalle;
        private Label LabelNombreTipoDetalle;
        private Label LabelDificultadTipoDetalle;
        private TextBox TextBoxCodigoTipoDetalle;
        private FormMode mode;

        public TipoAnomaliaDTO Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                this.SetTipoAnomalia();

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

        public TipoAnomaliaDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateTipo())
            {
                try
                {
                    this.Tipo.Cod_anom = int.Parse(TextBoxCodigoTipoDetalle.Text);
                    this.Tipo.Nombre_anom = TextBoxNombreTipoDetalle.Text;
                    this.Tipo.Dif_anom = int.Parse(ComboDificultadTipoDetalle.Text);

                    if (Mode == FormMode.Update)
                    {
                        await TipoAnomaliaApiTipoAnomalia.UpdateAsync(this.Tipo);
                    }
                    else
                    {
                        await TipoAnomaliaApiTipoAnomalia.AddAsync(this.Tipo);
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

        private void SetTipoAnomalia()
        {
            this.TextBoxCodigoTipoDetalle.Text = this.Tipo.Cod_anom.ToString();
            this.TextBoxNombreTipoDetalle.Text = this.Tipo.Nombre_anom;
            this.ComboDificultadTipoDetalle.Text = this.Tipo.Dif_anom.ToString();
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                LabelCodigoTipoDetalle.Visible = false;
                TextBoxCodigoTipoDetalle.Visible = false;
                LabelNombreTipoDetalle.Visible = true;
                TextBoxNombreTipoDetalle.Visible = true;
                LabelDificultadTipoDetalle.Visible = true;
                ComboDificultadTipoDetalle.Visible = true;
            }
            if (mode == FormMode.Update)
            {
                LabelCodigoTipoDetalle.Visible = false;
                TextBoxCodigoTipoDetalle.Visible = false;
                LabelNombreTipoDetalle.Visible = true;
                TextBoxNombreTipoDetalle.Visible = true;
                LabelDificultadTipoDetalle.Visible = true;
                ComboDificultadTipoDetalle.Visible = true;
            }
        }

        private bool ValidateTipo()
        {
            bool valid = true;
            errorProvider.SetError(TextBoxNombreTipoDetalle, string.Empty);
            errorProvider.SetError(ComboDificultadTipoDetalle, string.Empty);

            if (this.TextBoxNombreTipoDetalle.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(TextBoxNombreTipoDetalle, "El nombre es Requerido");
            }

            if (this.ComboDificultadTipoDetalle.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(ComboDificultadTipoDetalle, "La dificultad es Requerida");
            }

            return valid;
        }
    }
}