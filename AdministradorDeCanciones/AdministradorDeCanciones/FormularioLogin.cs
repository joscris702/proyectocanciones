using AdministradorDeCanciones.DAOANDMODELS;

namespace AdministradorDeCanciones
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.ToString();
            string contrasenaUsuario = txtPassword.Text.ToString();

            UsuarioDAO usuarioDao = new UsuarioDAO(ConnectionManager.connectionString);


            Usuario usuario = usuarioDao.Login(nombreUsuario, contrasenaUsuario);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido" + nombreUsuario);
                this.Hide();
                FormularioCargaPrincipal formulariocarga = new FormularioCargaPrincipal(usuario);
                formulariocarga.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                MessageBox.Show(usuario + "");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formularioRegistro = new Form1();
            formularioRegistro.Show();
        }
    }
}
