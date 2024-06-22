using AdministradorDeCanciones.DAOANDMODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeCanciones
{
    public partial class Formplaylists : Form
    {
        int usuarioid;
        public Formplaylists(int idUsuario)
        {
            InitializeComponent();
            this.usuarioid = idUsuario;
            this.Load += new EventHandler(cargadDataGridViewPlaylistsLoad);
            dataGriedViewPlaylists.SelectionChanged += new EventHandler(this.cambiodefilaEventoGridPlaylists);
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


        private void cargadDataGridViewPlaylistsLoad(object sender, EventArgs e)
        {
            cargadatosdatagrid();
            CargarCancionesEnComboBox();
        }
        private void CargarCancionesEnComboBox()
        {
            DAOCanciones daoCanciones = new DAOCanciones();
            List<Cancion> canciones = daoCanciones.ObtenerTodasLasCanciones();

            if (canciones != null && canciones.Count > 0)
            {
                comboCancion.DataSource = canciones;
                comboCancion.DisplayMember = "titulo";
                comboCancion.ValueMember = "Id";
            }
           
        }


        private void cambiodefilaEventoGridPlaylists(object sender, EventArgs e)
        {
            if (dataGriedViewPlaylists.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGriedViewPlaylists.SelectedRows[0];
                int id = int.Parse( filaSeleccionada.Cells["Id"].Value.ToString());
                MessageBox.Show(id + "");
                cargardatosdatagridCanciones(id);
            }
        }

        private void cargadatosdatagrid()
        {
            dataGriedViewPlaylists.DataSource = null;
            DAOPlaylist daoplaylist = new DAOPlaylist();

            List<Playlist> playlistDisponibles = daoplaylist.ObtenerPlaylistsDeUsuario(usuarioid);
            
            if (playlistDisponibles != null & playlistDisponibles.Count > 0)
            {
                dataGriedViewPlaylists.DataSource = playlistDisponibles;
            }
            else
            {
                MessageBox.Show("Aun no hay playlists agrega una");
            }
        }

        private void cargardatosdatagridCanciones(int playlistID) {
            dataGridViewCanciones.DataSource = null;

            DAOplaylist_canciones playistcanciones = new DAOplaylist_canciones();

            List<Cancion> canciones =  playistcanciones.ObtenerCancionesDePlaylist(playlistID);

            if (canciones != null)
            {
                dataGridViewCanciones.DataSource = canciones;
            }
            else
            {
                MessageBox.Show("No hay ninguna cancion aun en esta playlist");
            }
            
        }

        private void txtPlaylistnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGriedViewPlaylists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarPlaylist_Click(object sender, EventArgs e)
        {
            DAOPlaylist daoplaylist = new DAOPlaylist();
            daoplaylist.CrearPlaylist(txtPlaylistnombre.Text, usuarioid);
            cargadatosdatagrid();
        }

        private void comboCancion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int ObtenerIdPlaylist()
        {
            if (dataGriedViewPlaylists.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGriedViewPlaylists.SelectedRows[0];
                int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
                MessageBox.Show(id + "");

                return id;
               }
            return 0;
        }
        private void agregarCancion_Click(object sender, EventArgs e)
        {
            Cancion cancionSeleccionada = comboCancion.SelectedItem as Cancion;
            DAOPlaylist playlists = new DAOPlaylist();

            if (cancionSeleccionada == null)
            {
                MessageBox.Show("Por favor, selecciona una canción.");
                return;
            }

            int idPlaylist = ObtenerIdPlaylist(); 
            if (idPlaylist <= 0)
            {
                MessageBox.Show("No se ha seleccionado una playlist válida.");
                return;
            }

            playlists.AgregarCancionAPlaylist(idPlaylist, cancionSeleccionada.id);
            cargardatosdatagridCanciones(idPlaylist);
        }

        private void dataGridViewCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
