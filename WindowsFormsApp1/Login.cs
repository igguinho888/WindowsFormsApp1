using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=sqlexpress;Database=BASE25CJ3027651;User Id=aluno;Password=aluno;";
            string usuario = txbusuario.Text;
            string senha = txbsenha.Text;
            int count;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuarios WHERE Usuario=@usuario AND Senha=@senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    count = cmd.ExecuteReader().HasRows == true ? 1 : 0;
                    
                }
            }
            if (count > 0)
            {
                Principal principal = new Principal();
                this.Visible = false;
                principal.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
