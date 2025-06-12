namespace Presentacion
{
    partial class CrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProducto));
            label1 = new Label();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            textBox2 = new TextBox();
            Cancelarbtn = new Button();
            Aceptarbtn = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            comboBoxCategoria = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxSuplidor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Producto";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "NombreProducto", true));
            textBox1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(12, 96);
            textBox1.MaxLength = 200;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 28);
            textBox1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(ProductoViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción Producto";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "DescripcionProducto", true));
            textBox2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(12, 151);
            textBox2.MaxLength = 500;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(285, 61);
            textBox2.TabIndex = 3;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelarbtn.FlatStyle = FlatStyle.Popup;
            Cancelarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Cancelarbtn.Location = new Point(113, 400);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(94, 30);
            Cancelarbtn.TabIndex = 10;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = true;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // Aceptarbtn
            // 
            Aceptarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Aceptarbtn.FlatStyle = FlatStyle.Popup;
            Aceptarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Aceptarbtn.Location = new Point(213, 400);
            Aceptarbtn.Name = "Aceptarbtn";
            Aceptarbtn.Size = new Size(94, 30);
            Aceptarbtn.TabIndex = 11;
            Aceptarbtn.Text = "OK";
            Aceptarbtn.UseVisualStyleBackColor = true;
            Aceptarbtn.Click += Aceptarbtn_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "PrecioUnitario", true));
            textBox3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox3.Location = new Point(12, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 28);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 4;
            label3.Text = "Precio Unitario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(12, 293);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(285, 29);
            comboBoxCategoria.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label4.Location = new Point(12, 269);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 6;
            label4.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label5.Location = new Point(12, 325);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 8;
            label5.Text = "Suplidor";
            // 
            // comboBoxSuplidor
            // 
            comboBoxSuplidor.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            comboBoxSuplidor.FormattingEnabled = true;
            comboBoxSuplidor.Location = new Point(12, 349);
            comboBoxSuplidor.Name = "comboBoxSuplidor";
            comboBoxSuplidor.Size = new Size(285, 29);
            comboBoxSuplidor.TabIndex = 9;
            // 
            // CrearProducto
            // 
            AcceptButton = Aceptarbtn;
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = Cancelarbtn;
            ClientSize = new Size(309, 443);
            Controls.Add(label5);
            Controls.Add(comboBoxSuplidor);
            Controls.Add(label4);
            Controls.Add(comboBoxCategoria);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
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
            Name = "CrearProducto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearProducto";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button Cancelarbtn;
        private Button Aceptarbtn;
        private TextBox textBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private ComboBox comboBoxCategoria;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxSuplidor;
        private BindingSource bindingSource1;
    }
}