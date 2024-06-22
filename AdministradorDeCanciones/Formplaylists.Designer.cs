namespace AdministradorDeCanciones
{
    partial class Formplaylists
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
            dataGriedViewPlaylists = new DataGridView();
            dataGridViewCanciones = new DataGridView();
            comboCancion = new ComboBox();
            agregarPlaylist = new Button();
            agregarCancion = new Button();
            txtPlaylistnombre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGriedViewPlaylists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCanciones).BeginInit();
            SuspendLayout();
            // 
            // dataGriedViewPlaylists
            // 
            dataGriedViewPlaylists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriedViewPlaylists.Location = new Point(46, 48);
            dataGriedViewPlaylists.Name = "dataGriedViewPlaylists";
            dataGriedViewPlaylists.Size = new Size(715, 181);
            dataGriedViewPlaylists.TabIndex = 0;
            dataGriedViewPlaylists.CellContentClick += dataGriedViewPlaylists_CellContentClick;
            // 
            // dataGridViewCanciones
            // 
            dataGridViewCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCanciones.Location = new Point(46, 330);
            dataGridViewCanciones.Name = "dataGridViewCanciones";
            dataGridViewCanciones.Size = new Size(715, 161);
            dataGridViewCanciones.TabIndex = 1;
            dataGridViewCanciones.CellContentClick += dataGridViewCanciones_CellContentClick;
            // 
            // comboCancion
            // 
            comboCancion.FormattingEnabled = true;
            comboCancion.Location = new Point(46, 279);
            comboCancion.Name = "comboCancion";
            comboCancion.Size = new Size(121, 23);
            comboCancion.TabIndex = 2;
            comboCancion.SelectedIndexChanged += comboCancion_SelectedIndexChanged;
            // 
            // agregarPlaylist
            // 
            agregarPlaylist.Location = new Point(785, 85);
            agregarPlaylist.Name = "agregarPlaylist";
            agregarPlaylist.Size = new Size(112, 23);
            agregarPlaylist.TabIndex = 3;
            agregarPlaylist.Text = "Agregar PlayList";
            agregarPlaylist.UseVisualStyleBackColor = true;
            agregarPlaylist.Click += agregarPlaylist_Click;
            // 
            // agregarCancion
            // 
            agregarCancion.Location = new Point(225, 279);
            agregarCancion.Name = "agregarCancion";
            agregarCancion.Size = new Size(245, 23);
            agregarCancion.TabIndex = 4;
            agregarCancion.Text = "Agregar Cancion a Playlist";
            agregarCancion.UseVisualStyleBackColor = true;
            agregarCancion.Click += agregarCancion_Click;
            // 
            // txtPlaylistnombre
            // 
            txtPlaylistnombre.Location = new Point(174, 12);
            txtPlaylistnombre.Name = "txtPlaylistnombre";
            txtPlaylistnombre.Size = new Size(146, 23);
            txtPlaylistnombre.TabIndex = 5;
            txtPlaylistnombre.TextChanged += txtPlaylistnombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre Playlist";
            // 
            // Formplaylists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 503);
            Controls.Add(label1);
            Controls.Add(txtPlaylistnombre);
            Controls.Add(agregarCancion);
            Controls.Add(agregarPlaylist);
            Controls.Add(comboCancion);
            Controls.Add(dataGridViewCanciones);
            Controls.Add(dataGriedViewPlaylists);
            Name = "Formplaylists";
            Text = "Formplaylists";
            ((System.ComponentModel.ISupportInitialize)dataGriedViewPlaylists).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCanciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGriedViewPlaylists;
        private DataGridView dataGridViewCanciones;
        private ComboBox comboCancion;
        private Button agregarPlaylist;
        private Button agregarCancion;
        private TextBox txtPlaylistnombre;
        private Label label1;
    }
}