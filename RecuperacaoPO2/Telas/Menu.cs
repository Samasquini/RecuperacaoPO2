using RecuperacaoPO2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacaoPO2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Carros consultar = new Consultar_Carros();
            consultar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar_Carros cadastrar = new Cadastrar_Carros();
            cadastrar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
