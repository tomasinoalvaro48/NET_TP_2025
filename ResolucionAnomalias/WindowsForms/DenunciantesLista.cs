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

namespace WindowsForms
{
    public partial class DenunciantesLista : Form
    {
        public DenunciantesLista()
        {
            InitializeComponent();
        }

        private void Denunciantes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DenuncianteDetalle denuncianteDetalle = new DenuncianteDetalle();

            DenuncianteDTO denuncianteNuevo = new DenuncianteDTO();

            denuncianteDetalle.Mode = FormMode.Add;
            denuncianteDetalle.Denunciante = denuncianteNuevo;

            denuncianteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                DenuncianteDetalle denuncianteDetalle = new DenuncianteDetalle();

                int cod_den = this.SelectedItem().Cod_den;

                //DenuncianteDTO denunciante = await DenuncianteApiDenunciante.GetAsync(cod_den);

                var entity = await DenuncianteApiDenunciante.GetAsync(cod_den);
                DenuncianteDTO denunciante = DenuncianteMapper.ToDTO(entity);

                denuncianteDetalle.Mode = FormMode.Update;
                denuncianteDetalle.Denunciante = denunciante;

                denuncianteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar denunciante para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_den = this.SelectedItem().Cod_den;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el denunciante con código {cod_den}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await DenuncianteApiDenunciante.DeleteAsync(cod_den);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar denunciante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.denunciantesDataGridView.DataSource = null;
                this.denunciantesDataGridView.DataSource = await DenuncianteApiDenunciante.GetAllAsync();

                if (this.denunciantesDataGridView.Rows.Count > 0)
                {
                    this.denunciantesDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de denunciantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private DenuncianteDTO SelectedItem()
        {
            DenuncianteDTO denunciante;

            denunciante = (DenuncianteDTO)denunciantesDataGridView.SelectedRows[0].DataBoundItem;

            return denunciante;
        }
    }
}