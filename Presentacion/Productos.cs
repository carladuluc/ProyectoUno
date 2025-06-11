using Microsoft.Extensions.Configuration;

namespace Presentacion
{
    public partial class Productos : Form
    {
        private readonly ProductoRepository _productoRepository; //se le pone _ a los campos privado para localizarlos rápido
        private readonly CrearProducto _crearProducto;

        public Productos(ProductoRepository productoRepository, CrearProducto crearProducto)
        {
            InitializeComponent();
            _productoRepository = productoRepository;
            this._crearProducto = crearProducto;
            Load += Productos_Load;
        }

        private void Productos_Load(object? sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            var productos = _productoRepository.DarProducto();
            ProductosDataGridView.DataSource = productos;
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_crearProducto.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Cancelar");
            }

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de borrar este producto?", "Borrar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var producto = (Producto)ProductosDataGridView.SelectedRows[0].DataBoundItem;
                _productoRepository.Borrar(producto.IdProducto);

                CargarProductos();
            }
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ProductosDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe de seleccionar un registro");
                return;
            }

            var producto = (Producto)ProductosDataGridView.SelectedRows[0].DataBoundItem;

            _crearProducto.Inicializar(producto);
            if (_crearProducto.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
           
        }
    }
}
