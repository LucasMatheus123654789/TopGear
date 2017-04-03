using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopGear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //criação do objeto carro1 que é uma instancia da classe carro
            //preenchimento dos atributos do carro1
            
            
            Carro carro1 = new Carro();
            carro1.modelo = "opala";
            carro1.marca = "chevrolet";
            carro1.cor = "preto";
            carro1.motorizacao = "4.1";
            carro1.ano_fabricacao = 1978;
            carro1.velocidade_maxima = 290;
            carro1.quantidade_marchas = 5;

            //preenchimento da ficha do carro
            lblModelo.Text = carro1.modelo;
            lblMarca.Text = carro1.marca;
            lblCor.Text = carro1.cor;
            lblMotorizacao.Text = carro1.motorizacao;
            lblAnoFabricacao.Text = carro1.ano_fabricacao.ToString();
            lblVelocidadeMaxima.Text = carro1.velocidade_maxima.ToString();
            lblQuantidadeMarchas.Text = carro1.quantidade_marchas.ToString();

            picMavekao.Visible = false;
            picOpalao.Visible = true;
            
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mavekao_Click(object sender, EventArgs e)
        {
            Carro carro2 = new Carro();
            carro2.modelo = "Maverick";
            carro2.marca = "Ford";
            carro2.cor = "Cinza";
            carro2.motorizacao = "v8";
            carro2.ano_fabricacao = 1976;
            carro2.velocidade_maxima = 280;
            carro2.quantidade_marchas = 5;

            //preenchimento da ficha do carro
            lblModelo.Text = carro2.modelo;
            lblMarca.Text = carro2.marca;
            lblCor.Text = carro2.cor;
            lblMotorizacao.Text = carro2.motorizacao;
            lblAnoFabricacao.Text = carro2.ano_fabricacao.ToString();
            lblVelocidadeMaxima.Text = carro2.velocidade_maxima.ToString();
            lblQuantidadeMarchas.Text = carro2.quantidade_marchas.ToString();

            picMavekao.Visible = true;
            picOpalao.Visible = false;

        }
    }
}
