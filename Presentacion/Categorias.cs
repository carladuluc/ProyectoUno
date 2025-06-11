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
    public partial class Categorias : Form
    {
        private readonly CategoriaRepository _categoriaRepository;
        private readonly CrearCategoria _crearCategoria;

        public Categorias(CategoriaRepository categoriaRepository, CrearCategoria crearCategoria)
        {
            InitializeComponent();
            _categoriaRepository = categoriaRepository;
            this._crearCategoria = crearCategoria;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            var categoria = _categoriaRepository.DarCategoria();
            CategoriasDataGridView1.DataSource = categoria;
        }

        private void crearCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_crearCategoria.ShowDialog() == DialogResult.OK)
            {
                CargarCategorias();

            }
            else
            {
                MessageBox.Show("Cancelar");
            }
        }

        private void editarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CategoriasDataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            var categoria = (Categoria)CategoriasDataGridView1.SelectedRows[0].DataBoundItem;

            _crearCategoria.Inicializar(categoria);
            if (_crearCategoria.ShowDialog() == DialogResult.OK)
            {
                CargarCategorias();
            }
            
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CategoriasDataGridView1.SelectedRows.Count > 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de borrar esta categoria?", "Borrar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var categoria = (Categoria)CategoriasDataGridView1.SelectedRows[0].DataBoundItem;
                _categoriaRepository.Borrar(categoria.IdCategoria);

                CargarCategorias();
            }
        }
    }
}
