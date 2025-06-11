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

        //public ProductoViewModel ViewModel { get; set; }


        public CrearProducto(ProductoValidador validator, ProductoRepository productoRepository)
        {
            InitializeComponent();
            Load += CrearProducto_Load;
            FormClosing += CrearProducto_FormClosing;
            this._validator = validator;
            this.productoRepository = productoRepository;
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
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
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

        }
    }
}
