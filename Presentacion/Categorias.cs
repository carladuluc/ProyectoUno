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
        private readonly FotoRepository _fotoRepository;


        // se inyectan en el constructor para aplicar inyección de dependencias para las fotos y las categorias para la conexion d elos datos como puente
        public Categorias(CategoriaRepository categoriaRepository, CrearCategoria crearCategoria, FotoRepository fotoRepository)
        {
            InitializeComponent();
            _categoriaRepository = categoriaRepository;
            this._crearCategoria = crearCategoria;
            this._fotoRepository = fotoRepository;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();

            CargarCategorias(); // tu método actual de carga
        }

        private void CargarCategorias()
        {
            var categoria = _categoriaRepository.DarCategoria();
            CategoriasDataGridView1.DataSource = categoria;
        }


        private void MostrarTodasLasFotos(int idCategoria)
        {
            flowLayoutPanelFotos.Controls.Clear();
            var fotos = _fotoRepository.ObtenerTodasPorCategoria(idCategoria);
            foreach (var foto in fotos)
            {
                var pic = new PictureBox();
                pic.Image = ByteArrayToImage(foto.Imagen);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 120;
                pic.Height = 120;
                pic.Margin = new Padding(5);
                pic.Tag = foto;
               

                flowLayoutPanelFotos.Controls.Add(pic);
              

            }
        }

     

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
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
            //BORRADO TOTAL
            //if (CategoriasDataGridView1.SelectedRows.Count <= 0)
            //{
            //    MessageBox.Show("Debe de seleccionar un registro");
            //    return;
            //}

            //if (MessageBox.Show("¿Estás seguro de borrar esta categoria?", "Borrar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    var categoria = (Categoria)CategoriasDataGridView1.SelectedRows[0].DataBoundItem;
            //    _categoriaRepository.Borrar(categoria.IdCategoria);

            //    CargarCategorias();
            //}

            //BORRADO LÓGICO
            if (CategoriasDataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de desactivar esta categoria?", "Borrar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var categoria = (Categoria)CategoriasDataGridView1.SelectedRows[0].DataBoundItem;
                var desactivado = _categoriaRepository.DesactivarCategoria(categoria.IdCategoria);
                if (desactivado)
                {
                    MessageBox.Show("Categoria desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("No se pudo desactivar la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarCategorias();
            }
        }

        private void CategoriasDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriasDataGridView1.SelectedRows.Count > 0)
            {

                var fila = CategoriasDataGridView1.SelectedRows[0];
                var idCategoria = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
                MostrarTodasLasFotos(idCategoria);
            }
        }

      

        
    }
}
