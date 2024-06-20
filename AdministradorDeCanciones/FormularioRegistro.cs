using AdministradorDeCanciones.DAOANDMODELS;

namespace AdministradorDeCanciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = usuariotxt.Text.ToString();
            string password = passwordtxt.Text.ToString();


            UsuarioDAO usuariodao = new UsuarioDAO(ConnectionManager.connectionString);

            bool usuario2 = usuariodao.RegistrarUsuario(usuario, password);

            if (usuario2)
            {
                MessageBox.Show("Usuario registrado correctamente, vuelva al login");
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usurio, datos invalidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularioLogin login = new FormularioLogin();
            login.Show();
        }
    }
}
