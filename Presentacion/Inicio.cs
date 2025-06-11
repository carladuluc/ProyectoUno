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
    public partial class Inicio : Form
    {
        private readonly Productos _productos;
        private readonly Suplidores _suplidores;
        private readonly Categorias _categorias;

        public Inicio(Productos productos, Suplidores suplidores, Categorias categorias)
        {
            InitializeComponent();
            this._productos = productos;
            this._suplidores = suplidores;
            this._categorias = categorias;
            Load += Inicio_Load;
        }

        private void Inicio_Load(object? sender, EventArgs e)
        {
          
        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _suplidores.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categorias.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _productos.ShowDialog();
        }
    }
}
