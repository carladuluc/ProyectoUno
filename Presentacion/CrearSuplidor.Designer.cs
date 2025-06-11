namespace Presentacion
{
    partial class CrearSuplidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearSuplidor));
            textBox3 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label3 = new Label();
            Aceptarbtn = new Button();
            Cancelarbtn = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            suplidorViewModelBindingSource = new BindingSource(components);
            label7 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suplidorViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "NombreEmpresa", true));
            textBox3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox3.Location = new Point(12, 198);
            textBox3.MaxLength = 300;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 28);
            textBox3.TabIndex = 5;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(SuplidorViewModel);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 4;
            label3.Text = "Nombre de la Empresa";
            // 
            // Aceptarbtn
            // 
            Aceptarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Aceptarbtn.FlatStyle = FlatStyle.Popup;
            Aceptarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Aceptarbtn.Location = new Point(205, 487);
            Aceptarbtn.Name = "Aceptarbtn";
            Aceptarbtn.Size = new Size(94, 29);
            Aceptarbtn.TabIndex = 15;
            Aceptarbtn.Text = "OK";
            Aceptarbtn.UseVisualStyleBackColor = true;
            Aceptarbtn.Click += Aceptarbtn_Click;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelarbtn.FlatStyle = FlatStyle.Popup;
            Cancelarbtn.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            Cancelarbtn.Location = new Point(105, 487);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(94, 29);
            Cancelarbtn.TabIndex = 14;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = true;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Apellido", true));
            textBox2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(12, 146);
            textBox2.MaxLength = 100;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 28);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre", true));
            textBox1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(12, 92);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 28);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "SitioWeb", true));
            textBox4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox4.Location = new Point(12, 370);
            textBox4.MaxLength = 300;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(285, 28);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 10;
            label4.Text = "Sitio Web";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Correo", true));
            textBox5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox5.Location = new Point(12, 315);
            textBox5.MaxLength = 200;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(285, 28);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 8;
            label5.Text = "Correo";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Cedula", true));
            textBox6.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            textBox6.Location = new Point(12, 257);
            textBox6.MaxLength = 13;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(285, 28);
            textBox6.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 6;
            label6.Text = "Cedula";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // suplidorViewModelBindingSource
            // 
            suplidorViewModelBindingSource.DataSource = typeof(SuplidorViewModel);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold);
            label7.Location = new Point(12, 402);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 12;
            label7.Text = "Celular";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Celular", true));
            textBox7.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(12, 428);
            textBox7.MaxLength = 12;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(285, 28);
            textBox7.TabIndex = 13;
            // 
            // CrearSuplidor
            // 
            AcceptButton = Aceptarbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = Cancelarbtn;
            ClientSize = new Size(311, 528);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(Aceptarbtn);
            Controls.Add(Cancelarbtn);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearSuplidor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearSuplidor";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)suplidorViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Button Aceptarbtn;
        private Button Cancelarbtn;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private PictureBox pictureBox2;
        private BindingSource suplidorViewModelBindingSource;
        private BindingSource bindingSource1;
        private Label label7;
        private TextBox textBox7;
    }
}