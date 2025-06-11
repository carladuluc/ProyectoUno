using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.CrearSuplidor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion
{
    public partial class CrearSuplidor : Form
    {
        private readonly SuplidorViewModel viewModel = new SuplidorViewModel();
        private readonly SuplidorValidador _validator;
        private readonly SuplidorRepository suplidorRepository;

        //public SuplidorViewModel ViewModel { get; set; }


        public CrearSuplidor(SuplidorValidador validator, SuplidorRepository suplidorRepository)
        {
            InitializeComponent();
            Load += CrearSuplidor_Load;
            FormClosing += CrearSuplidor_FormClosing;
            this._validator = validator;
            this.suplidorRepository = suplidorRepository;
        }

        private void CrearSuplidor_FormClosing(object? sender, FormClosingEventArgs e)
        {
            viewModel.Cedula = "";
            viewModel.Nombre = "";
            viewModel.Apellido = "";
            viewModel.Correo = "";
            viewModel.SitioWeb = "";
            viewModel.Celular = "";
            viewModel.NombreEmpresa = "";
            viewModel.IdSuplidor = 0;
        }

        private void CrearSuplidor_Load(object? sender, EventArgs e)
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

            if (viewModel.IdSuplidor == 0)
            {

                suplidorRepository.Crear(new Suplidor
                {
                    Cedula = viewModel.Cedula,
                    Nombre = viewModel.Nombre,
                    Apellido = viewModel.Apellido,
                    NombreEmpresa = viewModel.NombreEmpresa,
                    Celular = viewModel.Celular,
                    Correo = viewModel.Correo,
                    SitioWeb = viewModel.SitioWeb,

                });
            }
            else 
            {
                suplidorRepository.Actualizar(new Suplidor
                {
                    Cedula = viewModel.Cedula,
                    Nombre = viewModel.Nombre,
                    Apellido = viewModel.Apellido,
                    NombreEmpresa = viewModel.NombreEmpresa,
                    Celular = viewModel.Celular,
                    Correo = viewModel.Correo,
                    SitioWeb = viewModel.SitioWeb,
                    IdSuplidor = viewModel.IdSuplidor,

                });
            }

           

            DialogResult = DialogResult.OK;

        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        internal void Inicializar(Suplidor suplidor)
        {
            viewModel.Cedula = suplidor.Cedula;
            viewModel.Nombre = suplidor.Nombre;
            viewModel.Apellido = suplidor.Apellido;
            viewModel.Correo = suplidor.Correo;
            viewModel.SitioWeb = suplidor.SitioWeb;
            viewModel.Celular = suplidor.Celular;
            viewModel.NombreEmpresa = suplidor.NombreEmpresa;
            viewModel.IdSuplidor = suplidor.IdSuplidor;
           
        }

       
    }

    public class SuplidorViewModel
    {
        public int IdSuplidor { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreEmpresa { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
        public string Celular { get; set; }

    }

    public class SuplidorValidador: AbstractValidator<SuplidorViewModel> 
    {
        public SuplidorValidador()
        {
            RuleFor(a => a.Cedula).NotEmpty().WithMessage("Por favor ingrese la cédula")
                                  .Matches(@"^\d{3}-\d{7}-\d{1}$").WithMessage("Ingrese su cédula de manera correcta")
                                  .MaximumLength(13);
            RuleFor(a => a.Nombre).NotEmpty().WithMessage("Por favor ingrese su nombre")
                                  .MaximumLength(100);
            RuleFor(a => a.Apellido).NotEmpty().WithMessage("Por favor ingrese su apellido")
                                    .MaximumLength(100);
            RuleFor(a => a.NombreEmpresa).NotEmpty().WithMessage("Por favor ingrese el nombre de la empresa")
                                         .MaximumLength(300);
            RuleFor(a => a.Correo).NotEmpty().WithMessage("Por favor ingrese su correo")
                                  .EmailAddress().WithMessage("Ingrese su correo correctamente")
                                  .MaximumLength(200);
            RuleFor(a => a.SitioWeb).NotEmpty().WithMessage("Por favor ingrese su sitio web")
                                    .Matches(@"^www\.[a-zA-Z0-9\-]+\.[a-zA-Z]{2,4}$").WithMessage("Ingrese su web de manera correcta")
                                    .MaximumLength(300);
            RuleFor(a => a.Celular).NotEmpty().WithMessage("Por favor ingrese su celular")
                                   .Matches(@"^(809|829|849)-\d{3}-\d{4}$").WithMessage("Ingrese su celular de manera correcta, formato inválido");
        }

    }

}
