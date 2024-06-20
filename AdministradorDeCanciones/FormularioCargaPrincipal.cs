using AdministradorDeCanciones.DAOANDMODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void FormularioCargaPrincipal_Load(object sender, EventArgs e)
        {
            this.idUsuario = usuario.Id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] profile_image = null;
            DAOCanciones canciones = new DAOCanciones(ConnectionManager.connectionString);
            cargarExplorador();

            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                    profile_image = stream.ToArray();
                    canciones.CrearCancion("Humbe", "carlos", profile_image, 1998, "dias");
                }
            }



        }

        private void cargarExplorador()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";



            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                string rutaImagen = openFileDialog.FileName;



                // Aquí puedes implementar la lógica para cargar la imagen en el Guna2CirclePictureBox

                pictureBox1.Image = Image.FromFile(rutaImagen);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAOCanciones daocanciones = new DAOCanciones(ConnectionManager.connectionString);
            Cancion cancion = daocanciones.buscarCancionPorID(1);

            if (cancion.foto_perfil != null)
                MessageBox.Show("cancion encontrada");
            using (MemoryStream stream = new MemoryStream(cancion.foto_perfil))

            {

                pictureBox1.Image = Image.FromStream(stream);

            }
        }
    }
}
