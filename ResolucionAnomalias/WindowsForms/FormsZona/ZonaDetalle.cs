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
using WindowsForms;
using WindowsForms.FormsLocalidad;

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
                var localidades = await LocalidadApiLocalidad.GetAllAsync();
                comboBoxLocalidad.DataSource = localidades.ToList();
                comboBoxLocalidad.DisplayMember = "Nombre";
                comboBoxLocalidad.ValueMember = "Id";
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
            this.textBoxNombre.Text = this.Zona.Nombre.ToString();
            this.comboBoxLocalidad.SelectedValue = this.Zona.LocalidadId;
            /*
            if (comboBoxLocalidad.DataSource != null)
            {
                comboBoxLocalidad.SelectedValue = this.Zona.LocalidadId;
            }*/
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
                errorProvider.SetError(textBoxNombre, "eL NOMBRE es requerido");

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
                        await ZonaApiLocalidad.UpdateAsync(this.zona);
                    }
                    else
                    {
                        await ZonaApiLocalidad.AddAsync(this.zona);
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
