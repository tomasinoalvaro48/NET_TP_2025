using API.Clients.EntitiesClients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.FormsPedidoResolucion
{
    public partial class DetalleAnomalia : Form
    {
        private AnomaliaPedidoDTO anomalia;
        private FormMode mode;

        public AnomaliaPedidoDTO Anomalia
        {
            get { return anomalia; }
            set
            {
                anomalia = value;
                this.SetAnomaliaPedido();
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set
            {
                this.SetFormMode(value);
            }
        }

        public DetalleAnomalia()
        {
            InitializeComponent();
        }


        public DetalleAnomalia(FormMode mode, AnomaliaPedidoDTO anomalia) : this()
        {
            Init(mode, anomalia);
        }

        private async Task Init(FormMode mode, AnomaliaPedidoDTO anomalia)
        {
            await LoadTiposAnomalias();
            this.Mode = mode;
            this.Anomalia = anomalia;
        }

        private async Task LoadTiposAnomalias()
        {
            var tiposAnomalias = await TipoAnomaliaApiClient.GetAllAsync();
            comboBoxTipoAnomalia.DataSource = tiposAnomalias;
            comboBoxTipoAnomalia.DisplayMember = "Nombre_anom";
            comboBoxTipoAnomalia.ValueMember = "Cod_anom";
            comboBoxTipoAnomalia.SelectedIndex = -1;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateItem())
            {
                this.Anomalia.TipoAnomaliaId = (int)comboBoxTipoAnomalia.SelectedValue;
                this.Anomalia.TipoAnomaliaDescripcion = comboBoxTipoAnomalia.Text;
                this.Anomalia.TipoAnomaliaDificultad = ((TipoAnomaliaDTO)comboBoxTipoAnomalia.SelectedItem).Dif_anom;
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        
        private bool ValidateItem()
        {
            bool isValid = true;
            errorProvider1.SetError(comboBoxTipoAnomalia, string.Empty);
            if (comboBoxTipoAnomalia.SelectedIndex == null)
            {
                errorProvider1.SetError(comboBoxTipoAnomalia, "Debe seleccionar un tipo de anomalia.");
                isValid = false;
            }

            return isValid;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void SetAnomaliaPedido()
        {
            this.comboBoxTipoAnomalia.SelectedItem = this.anomalia.TipoAnomaliaId;
        }

        private void SetFormMode(FormMode formMode)
        {
            if (Mode == FormMode.Update)
            {
                comboBoxTipoAnomalia.Enabled = false;
            }
            else
            {
                comboBoxTipoAnomalia.Enabled = true;
            }
        }

        private async void comboBoxTipoAnomalia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoAnomalia.SelectedValue is int tipoAnomaliaId && tipoAnomaliaId > 0)
            {
                try
                {
                    var tipoAnomalia = await TipoAnomaliaApiClient.GetAsync(tipoAnomaliaId);
                    // Podés hacer algo con tipoAnomalia si necesitás
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener tipo de anomalia: {ex.Message}");
                }
            }
        }
    }
}
