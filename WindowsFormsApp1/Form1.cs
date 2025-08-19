using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ENTRAR_Click(object sender, EventArgs e)
        {
          
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            string usuario = lblUsuario.Text;
            string senha = lblsenha.Text;
            string CPF = mtbcpf.Text;
            string nome = txbnome.Text;
            string termosegur = ckbsegurança.Checked.ToString(); ;
            string informações = rdbinformações.Checked.ToString(); ;
            // 🔹 Caminho do arquivo na mesma pasta do programa
            string caminho = Path.Combine(Application.StartupPath, "usuarios.txt");

            // 🔹 Salva no arquivo
            using (StreamWriter sw = new StreamWriter(caminho, true))
            {
                sw.WriteLine($"Usuário: {usuario}, Senha: {senha}, CPF: {CPF}, Nome: {nome}, Termos: {termosegur}, Informações: {informacoes}");
            }

            MessageBox.Show("Dados salvos com sucesso!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbsegurança_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
