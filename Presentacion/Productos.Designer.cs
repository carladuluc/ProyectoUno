namespace Presentacion
{
    partial class Productos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductosDataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            nuevoProductoToolStripMenuItem = new ToolStripMenuItem();
            editarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosDataGridView
            // 
            ProductosDataGridView.BackgroundColor = Color.White;
            ProductosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDataGridView.Dock = DockStyle.Fill;
            ProductosDataGridView.Location = new Point(0, 32);
            ProductosDataGridView.Name = "ProductosDataGridView";
            ProductosDataGridView.RowHeadersWidth = 51;
            ProductosDataGridView.Size = new Size(800, 418);
            ProductosDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoProductoToolStripMenuItem, editarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            nuevoProductoToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            nuevoProductoToolStripMenuItem.ForeColor = Color.White;
            nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            nuevoProductoToolStripMenuItem.Size = new Size(147, 28);
            nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            nuevoProductoToolStripMenuItem.Click += nuevoProductoToolStripMenuItem_Click;
            // 
            // editarProductoToolStripMenuItem
            // 
            editarProductoToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            editarProductoToolStripMenuItem.ForeColor = Color.White;
            editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            editarProductoToolStripMenuItem.Size = new Size(144, 28);
            editarProductoToolStripMenuItem.Text = "Editar Producto";
            editarProductoToolStripMenuItem.Click += editarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            eliminarProductoToolStripMenuItem.ForeColor = Color.White;
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(163, 28);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductosDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)ProductosDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductosDataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private ToolStripMenuItem editarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
    }
}
