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


namespace WindowsForms
{
    public enum FormMode
    {
        Add,
        Update
    }
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
            this.textBoxCodigoLoc.Text = this.Localidad.Codigo.ToString();
            this.textBoxNombreLoc.Text = this.Localidad.Nombre;
        }

        private void SerFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                labelCodigoLoc.Visible = true;
                textBoxCodigoLoc.Visible = true;
                labelNombreLoc.Visible = true;
                textBoxNombreLoc.Visible = true;
            }
            if (mode == FormMode.Update)
            {
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

        private void textBoxCodigoLoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
