using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTOs;


namespace WindowsForms.FormsTipoAnomalia
{
    public partial class TipoAnomaliaDetalle : Form
    {
        private TipoAnomaliaDTO tipo;
        private Button button1;
        private FormMode mode;

        public TipoAnomaliaDTO Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                SetTipoAnomalia();

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

                    this.Localidad.Codigo = int.Parse(textBoxCodigoLoc.Text);
                    this.Localidad.Nombre = textBoxNombreLoc.Text;

                    if (Mode == FormMode.Update)
                    {
                        await LocalidadApiLocalidad.UpdateAsync(this.Localidad);
                    }
                    else
                    {
                        await LocalidadApiLocalidad.AddAsync(this.Localidad);
                    }

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SetLocalidad()
        {
            this.textBoxCodigoTipo.Text = this.Tipo.Cod_anom.ToString();
            this.textBoxNombreTipo.Text = this.Tipo.Nombre_anom;
        }

        private void SetFormMode(FormMode value)
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
                errorProvider.SetError(textBoxCodigoLoc, "El Codigo es Requerido");
            }

            if (this.textBoxNombreLoc.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(textBoxNombreLoc, "El Nombre es Requerido");
            }

            return valid;
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(760, 536);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TipoAnomaliaDetalle
            // 
            ClientSize = new Size(1010, 605);
            Controls.Add(button1);
            Name = "TipoAnomaliaDetalle";
            ResumeLayout(false);

        }
    }
}
