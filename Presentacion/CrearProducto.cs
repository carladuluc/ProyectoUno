using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.CrearCategoria;
using static Presentacion.CrearSuplidor;
using static Presentacion.CrearProducto;
using FluentValidation;

namespace Presentacion
{
    public partial class CrearProducto : Form
    {
        private readonly ProductoViewModel viewModel = new ProductoViewModel();
        private readonly ProductoValidador _validator;
        private readonly ProductoRepository productoRepository;
        private readonly CategoriaRepository _categoriaRepository;
        private readonly SuplidorRepository _suplidorRepository;

        //public ProductoViewModel ViewModel { get; set; }

        //Se cargaron los 3 repositorios para que se muestren los datos que ya se han ingresado

        public CrearProducto(ProductoValidador validator, ProductoRepository productoRepository, CategoriaRepository categoriaRepository, SuplidorRepository suplidorRepository)
        {
            InitializeComponent();
            Load += CrearProducto_Load;
            FormClosing += CrearProducto_FormClosing;
            this._validator = validator;
            this.productoRepository = productoRepository;
            this._categoriaRepository = categoriaRepository;
            this._suplidorRepository = suplidorRepository;
        }



        //Se cargan los suplidores y las categorias para crear el producto

        private void CargarCategorias()
        {
            var categorias = _categoriaRepository.DarCategoria().ToList();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "NombreCategoria";
            comboBoxCategoria.ValueMember = "IdCategoria";
            comboBoxCategoria.SelectedIndex = -1;
        }

        private void CargarSuplidores()
        {
            var suplidores = _suplidorRepository.DarSuplidor().ToList();
            comboBoxSuplidor.DataSource = suplidores;
            comboBoxSuplidor.DisplayMember = "NombreEmpresa";
            comboBoxSuplidor.ValueMember = "IdSuplidor";
            comboBoxSuplidor.SelectedIndex = -1;
        }




        private void CrearProducto_FormClosing(object? sender, FormClosingEventArgs e)
        {
            viewModel.IdProducto = 0;
            viewModel.NombreProducto = "";
            viewModel.DescripcionProducto = "";
            viewModel.PrecioUnitario = 0;
            viewModel.IdCategoria = 0;
            viewModel.IdSuplidor = 0;
        }

        private void CrearProducto_Load(object? sender, EventArgs e)
        {
            bindingSource1.Add(viewModel);
            CargarCategorias();
            CargarSuplidores();
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            // paar asegurarse de que los valores seleccionados se pasen al viewModel
            viewModel.IdCategoria = comboBoxCategoria.SelectedValue is not null ? (int)comboBoxCategoria.SelectedValue : 0;
            viewModel.IdSuplidor = comboBoxSuplidor.SelectedValue is not null ? (int)comboBoxSuplidor.SelectedValue : 0;


            var validationResult = _validator.Validate(viewModel);
            if (!validationResult.IsValid)
            {
                var messages = string.Join('\n', validationResult.Errors.Select(a => a.ErrorMessage).ToList());
                MessageBox.Show(messages, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (viewModel.IdProducto==0)
            {
                productoRepository.Crear(new Producto
                {
                    IdCategoria = viewModel.IdCategoria,
                    IdSuplidor = viewModel.IdSuplidor,
                    NombreProducto = viewModel.NombreProducto,
                    DescripcionProducto = viewModel.DescripcionProducto,
                    PrecioUnitario = viewModel.PrecioUnitario,

                });
            }
            else
            {
                productoRepository.Actualizar(new Producto
                {
                    IdCategoria = viewModel.IdCategoria,
                    IdSuplidor = viewModel.IdSuplidor,
                    NombreProducto = viewModel.NombreProducto,
                    DescripcionProducto = viewModel.DescripcionProducto,
                    PrecioUnitario = viewModel.PrecioUnitario,
                    IdProducto = viewModel.IdProducto,

                });
            }

            DialogResult = DialogResult.OK;

        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {

            
            DialogResult = DialogResult.Cancel;
        }

        //cuando se va a editar un producto existente

        internal void Inicializar(Producto producto)
        {
            viewModel.IdProducto= producto.IdProducto;
            viewModel.NombreProducto= producto.NombreProducto;
            viewModel.DescripcionProducto= producto.DescripcionProducto;
            viewModel.PrecioUnitario= producto.PrecioUnitario;
            viewModel.IdCategoria= producto.IdCategoria;
            viewModel.IdSuplidor= producto.IdSuplidor;
        }
    }

    public class ProductoViewModel
    {
        public int IdProducto { get; set; }
        public int IdSuplidor { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

    public class ProductoValidador : AbstractValidator<ProductoViewModel>
    {
        public ProductoValidador()
        {

            RuleFor(a => a.NombreProducto).NotEmpty().WithMessage("No puede dejar el nombre vacío")
                                          .MaximumLength(200);
            RuleFor(a => a.DescripcionProducto).NotEmpty().WithMessage("No puede dejar la descripción vacía")
                                               .MaximumLength(500);
            RuleFor(a => a.PrecioUnitario).NotEmpty().WithMessage("No puede dejar el precio vacío")
                                          .GreaterThanOrEqualTo(5).WithMessage("El precio debe ser mayor a 5");
            RuleFor(a => a.IdCategoria).GreaterThan(0).WithMessage("Debe seleccionar una categoría válida.");
            RuleFor(a => a.IdSuplidor).GreaterThan(0).WithMessage("Debe seleccionar un suplidor válido.");

        }
    }
}
