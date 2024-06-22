namespace AdministradorDeCanciones
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            usuariotxt = new TextBox();
            passwordtxt = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Location = new Point(4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 452);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(582, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
            label1.TabIndex = 1;
            label1.Text = "Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(536, 202);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // usuariotxt
            // 
            usuariotxt.Location = new Point(616, 202);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(100, 23);
            usuariotxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(616, 274);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(100, 23);
            passwordtxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 274);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(477, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "REGISTRARSE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(passwordtxt);
            Controls.Add(label3);
            Controls.Add(usuariotxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox usuariotxt;
        private TextBox passwordtxt;
        private Label label3;
        private Button button1;
    }
}
