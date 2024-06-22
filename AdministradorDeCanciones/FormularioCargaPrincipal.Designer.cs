namespace AdministradorDeCanciones
{
    partial class FormularioCargaPrincipal
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
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtArtista = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtGenero = new TextBox();
            label4 = new Label();
            txtAno = new TextBox();
            label5 = new Label();
            button3 = new Button();
            txtIdCancion = new TextBox();
            label6 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(230, 633);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 1;
            button1.Text = "Cambiar Imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(688, 590);
            button2.Name = "button2";
            button2.Size = new Size(173, 23);
            button2.TabIndex = 2;
            button2.Text = "Agregar Cancion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(15, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1072, 451);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 573);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(110, 23);
            txtTitulo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 573);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 7;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 633);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 9;
            label2.Text = "Artista";
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(89, 632);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(110, 23);
            txtArtista.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(244, 573);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 632);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 16;
            label3.Text = "Genero";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(471, 632);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(110, 23);
            txtGenero.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(389, 573);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 14;
            label4.Text = "Año";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(471, 573);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(110, 23);
            txtAno.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 36);
            label5.Name = "label5";
            label5.Size = new Size(208, 45);
            label5.TabIndex = 17;
            label5.Text = "CANCIONES";
            // 
            // button3
            // 
            button3.Location = new Point(688, 610);
            button3.Name = "button3";
            button3.Size = new Size(173, 23);
            button3.TabIndex = 18;
            button3.Text = "Guardar Cambios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtIdCancion
            // 
            txtIdCancion.Enabled = false;
            txtIdCancion.Location = new Point(885, 590);
            txtIdCancion.Name = "txtIdCancion";
            txtIdCancion.Size = new Size(100, 23);
            txtIdCancion.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 36);
            label6.Name = "label6";
            label6.Size = new Size(186, 45);
            label6.TabIndex = 20;
            label6.Text = "PLAYLISTS";
            // 
            // button4
            // 
            button4.Location = new Point(646, 36);
            button4.Name = "button4";
            button4.Size = new Size(150, 49);
            button4.TabIndex = 21;
            button4.Text = "PLAYLIST";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormularioCargaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 714);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(txtIdCancion);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtGenero);
            Controls.Add(label4);
            Controls.Add(txtAno);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtArtista);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormularioCargaPrincipal";
            Text = "FormularioCargaPrincipal";
            Load += FormularioCargaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private TextBox txtArtista;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtGenero;
        private Label label4;
        private TextBox txtAno;
        private Label label5;
        private Button button3;
        private TextBox txtIdCancion;
        private Label label6;
        private Button button4;
    }
}