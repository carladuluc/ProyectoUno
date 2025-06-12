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
            pictureBox2 = new PictureBox();
            btnAgregarFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            flowFotos = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label3.Location = new Point(7, 222);
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
            Aceptarbtn.Location = new Point(293, 419);
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
            Cancelarbtn.Location = new Point(193, 419);
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
            textBox2.Size = new Size(375, 58);
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
            textBox1.Size = new Size(375, 28);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(93, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(7, 215);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(116, 34);
            btnAgregarFoto.TabIndex = 16;
            btnAgregarFoto.Text = "Subir Foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp\"";
            openFileDialog1.Multiselect = true;
            // 
            // flowFotos
            // 
            flowFotos.AutoScroll = true;
            flowFotos.Location = new Point(12, 255);
            flowFotos.Name = "flowFotos";
            flowFotos.Size = new Size(218, 158);
            flowFotos.TabIndex = 17;
            // 
            // CrearCategoria
            // 
            AcceptButton = Aceptarbtn;
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = Cancelarbtn;
            ClientSize = new Size(399, 461);
            Controls.Add(flowFotos);
            Controls.Add(btnAgregarFoto);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private BindingSource bindingSource1;
        private Button btnAgregarFoto;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowFotos;
    }
}