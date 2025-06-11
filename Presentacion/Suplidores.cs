using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Suplidores : Form
    {
        private readonly SuplidorRepository _suplidorRepository; //se le pone _ a los campos privado para localizarlos rápido
        private readonly CrearSuplidor _crearSuplidor;

        public Suplidores(SuplidorRepository suplidorRepository, CrearSuplidor crearSuplidor)
        {
            InitializeComponent();
            _suplidorRepository = suplidorRepository;
            this._crearSuplidor = crearSuplidor;
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            CargarSuplidores();
        }

        private void CargarSuplidores()
        {
            var suplidores = _suplidorRepository.DarSuplidor();
            SuplidoresDataGridView.DataSource = suplidores;
        }

        private void crearSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_crearSuplidor.ShowDialog() == DialogResult.OK)
            {
                CargarSuplidores();
            }
            else
            {
                MessageBox.Show("Cancelar");
            }
        }

        private void editarSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SuplidoresDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            var suplidor = (Suplidor)SuplidoresDataGridView.SelectedRows[0].DataBoundItem;

            _crearSuplidor.Inicializar(suplidor);
            if (_crearSuplidor.ShowDialog() == DialogResult.OK)
            {
                CargarSuplidores();
            }
           

        }

        private void eliminarSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SuplidoresDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de borrar este suplidor?","Borrar Suplidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                var suplidor = (Suplidor)SuplidoresDataGridView.SelectedRows[0].DataBoundItem;
                _suplidorRepository.Borrar(suplidor.IdSuplidor);

                CargarSuplidores();
            }

            
        }
    }
}
