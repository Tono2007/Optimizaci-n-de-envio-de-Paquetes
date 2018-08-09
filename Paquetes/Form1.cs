using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paquetes
{
    public partial class Form1 : Form
    {
        List<Item> Individuos = new List<Item>();
        List<Item> Padres = new List<Item>();
        List<double> Fnorm = new List<double>();
        List<Item> Hijos = new List<Item>();
        List<double> Acumulado = new List<double>();
        List<double> itemsPeso = new List<double>();
        List<double> itemsGanancia = new List<double>();
        List<String> Mutacion = new List<String>();
        Random r = new Random();
        Item mayor = new Item();
        int Poblacion;
        double sumatoria = 0;
        int capacidadMochila;
        string line;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            genetico();
        }
        public void cargrarDatos()
        {
            capacidadMochila = Convert.ToInt32(tbCapacidad.Text);
            foreach (DataGridViewRow row in GV_Items.Rows)
            {
                itemsPeso.Add(Convert.ToDouble(row.Cells[1].Value));
                itemsGanancia.Add(Convert.ToDouble(row.Cells[2].Value));
                //formResultado.listView1.Items.Add(Convert.ToString(row.Cells[1].Value));
            }
        }
        public void genetico()//se llaman todos los metodos para el algoritmo genetico
        {
           /* int vueltas = Convert.ToInt32(40);
            inicializacion();
            do
            {
                foreach (Item item in Individuos)
                {
                    item.setPeso(Peso(item.getValor()));
                }

                restricion();//se aplica la restricion y se calcula la ganancia y la sumatoria
                fnorm();
                ruleta();
                cruce();
                mutacion();
                reinicio();
                vueltas--;
            } while (vueltas != 0);*/
            FormResultados formResultado = new FormResultados();
            tbCapacidad.Text = Convert.ToString(mayor.getValor());
            formResultado.listView1.Items.Add(Convert.ToString(mayor.getValor()));
            formResultado.lbGananciaTotal.Text = Convert.ToString(mayor.getGanacia());
            formResultado.lbPesoTotal.Text = Convert.ToString(mayor.getPeso());
            formResultado.Show();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            GV_Items.Rows.Add(tbNom.Text, tbPeso.Text, tbGanancia.Text);
            tbNom.Clear();
            tbGanancia.Clear();
            tbPeso.Clear();
        }
    }
}
