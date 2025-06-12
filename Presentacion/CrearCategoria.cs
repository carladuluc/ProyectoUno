using FluentValidation;
using Microsoft.Identity.Client;
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

namespace Presentacion
{
    public partial class CrearCategoria : Form
    {
        private readonly CategoriaViewModel viewModel = new CategoriaViewModel();
        private readonly CategoriaValidator _validator;
        private readonly CategoriaRepository categoriaRepository;
        private readonly FotoRepository _fotoRepository;
        private List<Foto> fotos = new List<Foto>();
        private Categoria categoriaSeleccionada = new Categoria(); // para almacenar la categoría actual

        //public CategoriaViewModel ViewModel { get; set; }

        public CrearCategoria(CategoriaValidator validator, CategoriaRepository categoriaRepository, FotoRepository fotoRepository)
        {
            InitializeComponent();
            Load += CrearCategoria_Load;
            FormClosing += CrearCategoria_FormClosing;
            this._validator = validator;
            this.categoriaRepository = categoriaRepository;
            this._fotoRepository = fotoRepository;
        }

        //Limpia los datos del ViewModel cuando el formulario se cierra.

        private void CrearCategoria_FormClosing(object? sender, FormClosingEventArgs e)
        {
            viewModel.NombreCategoria = "";
            viewModel.DescripcionCategoria = "";
            viewModel.IdCategoria = 0;
        }

        //Carga las fotos desde la base de datos
        private void CargarFotos()
        {
            if (categoriaSeleccionada == null || categoriaSeleccionada.IdCategoria == 0)
                return;

            fotos = _fotoRepository.ObtenerFotosPorCategoria(categoriaSeleccionada.IdCategoria);
            flowFotos.Controls.Clear();

            foreach (var foto in fotos)
            {
                using (var ms = new MemoryStream(foto.Imagen))
                {
                    PictureBox pic = new PictureBox
                    {
                        Image = Image.FromStream(ms),
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Margin = new Padding(5)
                    };
                    flowFotos.Controls.Add(pic);
                }
            }
        }

        //Agrega el viewModel al bindingSource1 para que se puedan hacer data bindings en controles del formulario.
        private void CrearCategoria_Load(object? sender, EventArgs e)
        {
            bindingSource1.Add(viewModel);
        }

        //Botón aceptar
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            var validationResult = _validator.Validate(viewModel);
            if (!validationResult.IsValid)
            {
                var messages = string.Join('\n', validationResult.Errors.Select(a => a.ErrorMessage).ToList());
                MessageBox.Show(messages, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (viewModel.IdCategoria == 0)
            {
                categoriaRepository.Crear(new Categoria
                {
                    NombreCategoria = viewModel.NombreCategoria,
                    DescripcionCategoria = viewModel.DescripcionCategoria,
                });
            }
            else
            {
                categoriaRepository.Actualizar(new Categoria
                {
                    NombreCategoria = viewModel.NombreCategoria,
                    DescripcionCategoria = viewModel.DescripcionCategoria,
                    IdCategoria = viewModel.IdCategoria,
                });
            }



            DialogResult = DialogResult.OK;
        }

        //Boton Cancelar
        private void Cancelarbtn_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        //cuando se va a editar una categoría existente
        internal void Inicializar(Categoria categoria)
        {
            categoriaSeleccionada = categoria;

            viewModel.NombreCategoria = categoria.NombreCategoria;
            viewModel.DescripcionCategoria = categoria.DescripcionCategoria;
            viewModel.IdCategoria = categoria.IdCategoria;

            CargarFotos();
        }

        // permite agregar una o más fotos
        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            if (viewModel.IdCategoria == 0 && categoriaSeleccionada.IdCategoria == 0)
            {
                MessageBox.Show("Primero debes guardar la categoría para poder agregar fotos.");
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;
                byte[] imagenBytes = File.ReadAllBytes(ruta);
                string nombreArchivo = Path.GetFileName(ruta);

                var foto = new Foto
                {
                    IdCategoria = categoriaSeleccionada.IdCategoria != 0 ? categoriaSeleccionada.IdCategoria : viewModel.IdCategoria,
                    Imagen = imagenBytes,
                    NombreArchivo = nombreArchivo
                };

                if (_fotoRepository.GuardarFoto(foto))
                {
                    MessageBox.Show("Foto guardada correctamente.");
                    CargarFotos();
                }
                else
                {
                    MessageBox.Show("Error al guardar la foto.");
                }
            }
        }
    }

    public class CategoriaViewModel
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
    }


    public class CategoriaValidator : AbstractValidator<CategoriaViewModel>
    {
        public CategoriaValidator()
        {
            RuleFor(a => a.NombreCategoria).NotEmpty().WithMessage("Por favor, ingrese el nombre de la categoria")
                                           .MaximumLength(200);
            RuleFor(a => a.DescripcionCategoria).NotEmpty().WithMessage("Por favor, ingrese la descripción")
                                                .MaximumLength(800);


        }
    }
}
