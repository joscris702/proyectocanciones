using AdministradorDeCanciones.DAOANDMODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministradorDeCanciones
{
    public partial class FormularioCargaPrincipal : Form
    {
        Usuario usuario;
        int idUsuario;
        public FormularioCargaPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.BackColor = Color.FromArgb(33, 43, 54);
            button3.Enabled = false;
            button3.Visible = false;
            using (var brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(33, 43, 54), Color.FromArgb(53, 63, 74), LinearGradientMode.Vertical))
            {
                this.BackgroundImage = new Bitmap(1, 1);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                using (var g = Graphics.FromImage(this.BackgroundImage))
                {
                    g.FillRectangle(brush, this.ClientRectangle);
                }
            }

        }

        private void FormularioCargaPrincipal_Load(object sender, EventArgs e)
        {
            this.idUsuario = usuario.Id;
            DAOCanciones daocanciones = new DAOCanciones();
            List<Cancion> canciones = daocanciones.ObtenerTodasLasCanciones();
            MostrarCancionesEnPanel(canciones);

        }




        private void button1_Click(object sender, EventArgs e)
        {
            cargarExplorador();





        }

        private void cargarExplorador()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";



            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                string rutaImagen = openFileDialog.FileName;




                pictureBox1.Image = Image.FromFile(rutaImagen);

            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DAOCanciones daocanciones = new DAOCanciones();
            Cancion cancion = daocanciones.BuscarCancionPorID(1);

            if (cancion.foto_perfil != null)
                MessageBox.Show("cancion encontrada");
            using (MemoryStream stream = new MemoryStream(cancion.foto_perfil))

            {

                // pictureBox1.Image = Image.FromStream(stream);

            }



        }
        private void MostrarCancionesEnPanel(List<Cancion> canciones)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var cancion in canciones)
            {
                Panel panelCancion = new Panel();
                panelCancion.Width = 200;
                panelCancion.Height = 350;
                panelCancion.BackColor = Color.FromArgb(33, 43, 54);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 180;
                pictureBox.Height = 180;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = ByteArrayToImage(cancion.foto_perfil);
                pictureBox.Dock = DockStyle.Top;

                System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
                graphicsPath.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                pictureBox.Region = new Region(graphicsPath);

                Label lblTitulo = new Label();
                lblTitulo.Text = "Título: " + cancion.titulo;
                lblTitulo.ForeColor = Color.White;
                lblTitulo.Dock = DockStyle.Top;

                Label lblArtista = new Label();
                lblArtista.Text = "Artista: " + cancion.artista;
                lblArtista.ForeColor = Color.White;
                lblArtista.Dock = DockStyle.Top;

                Label lblAno = new Label();
                lblAno.Text = "Año: " + cancion.ano.ToString();
                lblAno.ForeColor = Color.White;
                lblAno.Dock = DockStyle.Top;

                Label lblGenero = new Label();
                lblGenero.Text = "Género: " + cancion.genero;
                lblGenero.ForeColor = Color.White;
                lblGenero.Dock = DockStyle.Top;

                panelCancion.Controls.Add(lblGenero);
                panelCancion.Controls.Add(lblAno);
                panelCancion.Controls.Add(lblArtista);
                panelCancion.Controls.Add(lblTitulo);
                panelCancion.Controls.Add(pictureBox);

                Button btnEditar = new Button();
                btnEditar.Text = "Editar";
                btnEditar.Tag = cancion.id;
                btnEditar.Click += BtnEditar_Click;
                btnEditar.Dock = DockStyle.Bottom;

                Button btnEliminar = new Button();
                btnEliminar.Text = "Eliminar";
                btnEliminar.Tag = cancion.id;
                btnEliminar.Click += BtnEliminar_Click;
                btnEliminar.Dock = DockStyle.Bottom;

                btnEditar.BackColor = Color.FromArgb(33, 43, 54);
                btnEditar.ForeColor = Color.White;
                btnEliminar.BackColor = Color.FromArgb(33, 43, 54);
                btnEliminar.ForeColor = Color.White;

                panelCancion.Controls.Add(btnEliminar);
                panelCancion.Controls.Add(btnEditar);

                flowLayoutPanel1.Controls.Add(panelCancion);
            }
        }



        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btnEditar = sender as Button;
            int idCancion = (int)btnEditar.Tag;



            DAOCanciones daocanciones = new DAOCanciones();
            Cancion cancion = daocanciones.BuscarCancionPorID(idCancion);
            if (cancion != null)
            {
                txtTitulo.Text = cancion.titulo;
                txtArtista.Text = cancion.artista;
                pictureBox1.Image = ByteArrayToImage(cancion.foto_perfil);
                txtAno.Text = cancion.ano.ToString();
                txtGenero.Text = cancion.genero;
                txtIdCancion.Text = cancion.id.ToString();
                button3.Enabled = true;
                button3.Visible = true;

            }
            else
            {
                MessageBox.Show("Error al obtener la canción para editar.");
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = sender as Button;
            int idCancion = (int)btnEliminar.Tag;
            DAOCanciones daoCanciones = new DAOCanciones();

            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar esta canción?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                bool exito = daoCanciones.EliminarCancion(idCancion);

                if (exito)
                {
                    MessageBox.Show("Canción eliminada correctamente.");
                    List<Cancion> canciones = daoCanciones.ObtenerTodasLasCanciones();
                    MostrarCancionesEnPanel(canciones);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la canción.");
                }
            }
        }


        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            byte[] imagen_perfil = null;

            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                    imagen_perfil = stream.ToArray();


                    return imagen_perfil;
                }
            }
            else
            {
                MessageBox.Show("No has ingresado ninguna foto, ingresala porfavor");
                return null;
            }
        }

        private void LimpiarControles()
        {
            txtTitulo.Text = "";
            txtArtista.Text = "";
            pictureBox1.Image = null;
            txtAno.Text = "";
            txtGenero.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                string artista = txtArtista.Text;
                byte[] fotoDePerfil = ImageToByteArray(pictureBox1.Image);
                int ano = Convert.ToInt32(txtAno.Text);
                string genero = txtGenero.Text;

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(artista) || fotoDePerfil == null || string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DAOCanciones daoCanciones = new DAOCanciones();

                bool exito = daoCanciones.CrearCancion(titulo, artista, fotoDePerfil, ano, genero);

                if (exito)
                {
                    MessageBox.Show("Canción agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarControles();
                    DAOCanciones daocanciones = new DAOCanciones();
                    List<Cancion> canciones = daocanciones.ObtenerTodasLasCanciones();
                    MostrarCancionesEnPanel(canciones);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la canción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idCancion = Convert.ToInt32(txtIdCancion.Text);
                string titulo = txtTitulo.Text;
                string artista = txtArtista.Text;
                byte[] fotoDePerfil = ImageToByteArray(pictureBox1.Image); // Convertir la imagen a bytes
                int ano = Convert.ToInt32(txtAno.Text);
                string genero = txtGenero.Text;

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(artista) || fotoDePerfil == null || string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DAOCanciones daoCanciones = new DAOCanciones();
                Cancion cancionActual = daoCanciones.BuscarCancionPorID(idCancion);

                bool imagenCambiada = !SonBytesIguales(fotoDePerfil, cancionActual.foto_perfil);

                bool exito = false;
                if (imagenCambiada || titulo != cancionActual.titulo || artista != cancionActual.artista || ano != cancionActual.ano || genero != cancionActual.genero)
                {
                    exito = daoCanciones.EditarCancion(idCancion, titulo, artista, fotoDePerfil, ano, genero);
                }
                else
                {
                    exito = true;
                }

                if (exito)
                {
                    MessageBox.Show("Canción actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarControles();
                    DAOCanciones daocanciones = new DAOCanciones();
                    List<Cancion> canciones = daocanciones.ObtenerTodasLasCanciones();
                    MostrarCancionesEnPanel(canciones);
                    button3.Enabled = false;
                    button3.Visible = false;

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SonBytesIguales(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1 == null && bytes2 == null)
                return true;
            if (bytes1 == null || bytes2 == null || bytes1.Length != bytes2.Length)
                return false;

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                    return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formplaylists formularioplaylists = new Formplaylists();
        }
    }




}