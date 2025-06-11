namespace Presentacion
{
    partial class Suplidores
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
            SuplidoresDataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            crearSuplidorToolStripMenuItem = new ToolStripMenuItem();
            editarSuplidorToolStripMenuItem = new ToolStripMenuItem();
            eliminarSuplidorToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)SuplidoresDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SuplidoresDataGridView
            // 
            SuplidoresDataGridView.BackgroundColor = Color.White;
            SuplidoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuplidoresDataGridView.Dock = DockStyle.Fill;
            SuplidoresDataGridView.Location = new Point(0, 32);
            SuplidoresDataGridView.Name = "SuplidoresDataGridView";
            SuplidoresDataGridView.RowHeadersWidth = 51;
            SuplidoresDataGridView.Size = new Size(800, 418);
            SuplidoresDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearSuplidorToolStripMenuItem, editarSuplidorToolStripMenuItem, eliminarSuplidorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearSuplidorToolStripMenuItem
            // 
            crearSuplidorToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            crearSuplidorToolStripMenuItem.ForeColor = Color.White;
            crearSuplidorToolStripMenuItem.Name = "crearSuplidorToolStripMenuItem";
            crearSuplidorToolStripMenuItem.Size = new Size(134, 28);
            crearSuplidorToolStripMenuItem.Text = "Crear Suplidor";
            crearSuplidorToolStripMenuItem.Click += crearSuplidorToolStripMenuItem_Click;
            // 
            // editarSuplidorToolStripMenuItem
            // 
            editarSuplidorToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            editarSuplidorToolStripMenuItem.ForeColor = Color.White;
            editarSuplidorToolStripMenuItem.Name = "editarSuplidorToolStripMenuItem";
            editarSuplidorToolStripMenuItem.Size = new Size(137, 28);
            editarSuplidorToolStripMenuItem.Text = "Editar Suplidor";
            editarSuplidorToolStripMenuItem.Click += editarSuplidorToolStripMenuItem_Click;
            // 
            // eliminarSuplidorToolStripMenuItem
            // 
            eliminarSuplidorToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold);
            eliminarSuplidorToolStripMenuItem.ForeColor = Color.White;
            eliminarSuplidorToolStripMenuItem.Name = "eliminarSuplidorToolStripMenuItem";
            eliminarSuplidorToolStripMenuItem.Size = new Size(156, 28);
            eliminarSuplidorToolStripMenuItem.Text = "Eliminar Suplidor";
            eliminarSuplidorToolStripMenuItem.Click += eliminarSuplidorToolStripMenuItem_Click;
            // 
            // Suplidores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuplidoresDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Suplidores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suplidores";
            Load += Suplidores_Load;
            ((System.ComponentModel.ISupportInitialize)SuplidoresDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SuplidoresDataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearSuplidorToolStripMenuItem;
        private ToolStripMenuItem editarSuplidorToolStripMenuItem;
        private ToolStripMenuItem eliminarSuplidorToolStripMenuItem;
    }
}