namespace Presentacion
{
    partial class Categorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CategoriasDataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            crearCategoriaToolStripMenuItem = new ToolStripMenuItem();
            editarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            eliminarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            flowLayoutPanelFotos = new FlowLayoutPanel();
            contextMenuFoto = new ContextMenuStrip(components);
            borrarFotoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)CategoriasDataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuFoto.SuspendLayout();
            SuspendLayout();
            // 
            // CategoriasDataGridView1
            // 
            CategoriasDataGridView1.BackgroundColor = Color.White;
            CategoriasDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriasDataGridView1.Dock = DockStyle.Left;
            CategoriasDataGridView1.Location = new Point(0, 32);
            CategoriasDataGridView1.Name = "CategoriasDataGridView1";
            CategoriasDataGridView1.RowHeadersWidth = 51;
            CategoriasDataGridView1.Size = new Size(829, 418);
            CategoriasDataGridView1.TabIndex = 0;
            CategoriasDataGridView1.SelectionChanged += CategoriasDataGridView1_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearCategoriaToolStripMenuItem, editarCategoriaToolStripMenuItem, eliminarCategoriaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearCategoriaToolStripMenuItem
            // 
            crearCategoriaToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            crearCategoriaToolStripMenuItem.ForeColor = Color.White;
            crearCategoriaToolStripMenuItem.Name = "crearCategoriaToolStripMenuItem";
            crearCategoriaToolStripMenuItem.Size = new Size(143, 28);
            crearCategoriaToolStripMenuItem.Text = "Crear Categoria";
            crearCategoriaToolStripMenuItem.Click += crearCategoriaToolStripMenuItem_Click;
            // 
            // editarCategoriaToolStripMenuItem
            // 
            editarCategoriaToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            editarCategoriaToolStripMenuItem.ForeColor = Color.White;
            editarCategoriaToolStripMenuItem.Name = "editarCategoriaToolStripMenuItem";
            editarCategoriaToolStripMenuItem.Size = new Size(146, 28);
            editarCategoriaToolStripMenuItem.Text = "Editar Categoria";
            editarCategoriaToolStripMenuItem.Click += editarCategoriaToolStripMenuItem_Click;
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            eliminarCategoriaToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            eliminarCategoriaToolStripMenuItem.ForeColor = Color.White;
            eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            eliminarCategoriaToolStripMenuItem.Size = new Size(165, 28);
            eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            eliminarCategoriaToolStripMenuItem.Click += eliminarCategoriaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelFotos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(829, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 418);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanelFotos
            // 
            flowLayoutPanelFotos.AutoScroll = true;
            flowLayoutPanelFotos.Location = new Point(3, 3);
            flowLayoutPanelFotos.Name = "flowLayoutPanelFotos";
            flowLayoutPanelFotos.Size = new Size(196, 403);
            flowLayoutPanelFotos.TabIndex = 0;
            // 
            // contextMenuFoto
            // 
            contextMenuFoto.ImageScalingSize = new Size(20, 20);
            contextMenuFoto.Items.AddRange(new ToolStripItem[] { borrarFotoToolStripMenuItem });
            contextMenuFoto.Name = "contextMenuStrip1";
            contextMenuFoto.Size = new Size(211, 56);
            // 
            // borrarFotoToolStripMenuItem
            // 
            borrarFotoToolStripMenuItem.Name = "borrarFotoToolStripMenuItem";
            borrarFotoToolStripMenuItem.Size = new Size(210, 24);
            borrarFotoToolStripMenuItem.Text = "Borrar Foto";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(panel1);
            Controls.Add(CategoriasDataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriasDataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            contextMenuFoto.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CategoriasDataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearCategoriaToolStripMenuItem;
        private ToolStripMenuItem editarCategoriaToolStripMenuItem;
        private ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelFotos;
        private ContextMenuStrip contextMenuFoto;
        private ToolStripMenuItem borrarFotoToolStripMenuItem;
    }
}