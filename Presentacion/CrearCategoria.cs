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

        //public CategoriaViewModel ViewModel { get; set; }

        public CrearCategoria(CategoriaValidator validator, CategoriaRepository categoriaRepository)
        {
            InitializeComponent();
            Load += CrearCategoria_Load;
            FormClosing += CrearCategoria_FormClosing;
            this._validator = validator;
            this.categoriaRepository = categoriaRepository;
        }

        private void CrearCategoria_FormClosing(object? sender, FormClosingEventArgs e)
        {
            viewModel.NombreCategoria = "";
            viewModel.DescripcionCategoria = "";
            viewModel.IdCategoria = 0;
        }

        private void CrearCategoria_Load(object? sender, EventArgs e)
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

            if (viewModel.IdCategoria==0)
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

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.Cancel;
        }

        internal void Inicializar(Categoria categoria)
        {
            viewModel.NombreCategoria= categoria.NombreCategoria;
            viewModel.DescripcionCategoria = categoria.DescripcionCategoria;
            viewModel.IdCategoria= categoria.IdCategoria;
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
