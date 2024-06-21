namespace AdministradorDeCanciones
{
    partial class FormularioLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLogin));
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(582, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 23);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 272);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(496, 196);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(582, 201);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(187, 23);
            txtUsuario.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 449);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-40, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 456);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(541, 96);
            label3.Name = "label3";
            label3.Size = new Size(94, 36);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // button1
            // 
            button1.Location = new Point(537, 349);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 6;
            button1.Text = "Loguearse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(650, 349);
            button2.Name = "button2";
            button2.Size = new Size(96, 43);
            button2.TabIndex = 7;
            button2.Text = "Registro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "FormularioLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
