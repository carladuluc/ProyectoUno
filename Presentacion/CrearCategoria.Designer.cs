namespace Presentacion
{
    partial class CrearCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCategoria));
            label3 = new Label();
            Aceptarbtn = new Button();
            Cancelarbtn = new Button();
            textBox2 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            categoriaViewModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label3.Location = new Point(7, 190);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 4;
            label3.Text = "Subir Foto";
            // 
            // Aceptarbtn
            // 
            Aceptarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Aceptarbtn.BackColor = Color.White;
            Aceptarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Aceptarbtn.Location = new Point(203, 381);
            Aceptarbtn.Name = "Aceptarbtn";
            Aceptarbtn.Size = new Size(94, 30);
            Aceptarbtn.TabIndex = 6;
            Aceptarbtn.Text = "OK";
            Aceptarbtn.UseVisualStyleBackColor = false;
            Aceptarbtn.Click += Aceptarbtn_Click;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelarbtn.BackColor = Color.White;
            Cancelarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Cancelarbtn.Location = new Point(103, 381);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(94, 30);
            Cancelarbtn.TabIndex = 5;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = false;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "DescripcionCategoria", true));
            textBox2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(7, 151);
            textBox2.MaxLength = 800;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(285, 27);
            textBox2.TabIndex = 3;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CategoriaViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label2.Location = new Point(7, 127);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción Categoría";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "NombreCategoria", true));
            textBox1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(7, 89);
            textBox1.MaxLength = 200;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 28);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label1.Location = new Point(7, 65);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Categoría";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // categoriaViewModelBindingSource
            // 
            categoriaViewModelBindingSource.DataSource = typeof(CategoriaViewModel);
            // 
            // CrearCategoria
            // 
            AcceptButton = Aceptarbtn;
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = Cancelarbtn;
            ClientSize = new Size(309, 423);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Aceptarbtn);
            Controls.Add(Cancelarbtn);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearCategoria";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearCategoria";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button Aceptarbtn;
        private Button Cancelarbtn;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private BindingSource bindingSource1;
        private BindingSource categoriaViewModelBindingSource;
    }
}