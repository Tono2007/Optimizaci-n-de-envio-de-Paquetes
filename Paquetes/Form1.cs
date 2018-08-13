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
        List<String> NomPaquetes = new List<String>();
        Random r = new Random();
        Item mayor = new Item();
        int Poblacion;
        double sumatoria = 0;
        int capacidadMochila;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
           // label3.Text = itemsPeso.Count.ToString();
            limpieza();
            cargrarDatos();
            genetico();
        }
        public void cargrarDatos()
        {
            capacidadMochila = Convert.ToInt32(tbCapacidad.Text);
            int rows = GV_Items.RowCount;
            foreach (DataGridViewRow row in GV_Items.Rows)
            {
                if (rows>1)
                {
                    NomPaquetes.Add(Convert.ToString(row.Cells[0].Value));
                    itemsPeso.Add(Convert.ToDouble(row.Cells[1].Value));
                    itemsGanancia.Add(Convert.ToDouble(row.Cells[2].Value));
                }
                rows--;
            }
        }
        public void genetico()//se llaman todos los metodos para el algoritmo genetico
        {
             int vueltas = 100;
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
            } while (vueltas != 0);
            FormResultados formResultado = new FormResultados();
            // formResultado.lbREs.Items.Clear();
            //   formResultado.lbREs.Items.Add(Convert.ToString(mayor.getValor()));
           int cont3 = 0;
            foreach (char d in mayor.getValor())
            {
                if (d == '1')
                {
                    formResultado.lbResultados.Items.Add(NomPaquetes[cont3]);
                }
                cont3++;
            }
            formResultado.lbGananciaTotal.Text = Convert.ToString(mayor.getGanacia());
            formResultado.lbPesoTotal.Text = Convert.ToString(mayor.getPeso());
            formResultado.Show();
        }
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            GV_Items.Rows.Add(tbNom.Text, tbGanancia.Text, tbPeso.Text);
            tbNom.Clear();
            tbPeso.Clear();
            tbGanancia.Clear();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void inicializacion()
        {
            if (itemsPeso.Count == itemsGanancia.Count)
            {
                Poblacion = 100;
                for (int i = 0; i < Poblacion; i++)
                {
                    string binario = "";
                    for (int j = 0; j < itemsPeso.Count; j++)//Generar numero binario aleatorio
                    {
                        int random = r.Next(0, 2);
                        binario = binario + Convert.ToString(random);
                    }
                    Item item = new Item();
                    item.setValor(binario);
                    Individuos.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Error", "El numero de items en peso y ganancia no son los mismos");
            }
        }
        public double Peso(String item)
        {
            int cont = 0;
            double peso = 0;
            foreach (char p in item)
            {
                if (p == '1')
                {
                    peso += itemsPeso[cont];
                }
                cont++;
            }
            return peso;
        }
        public void restricion()
        {
            sumatoria = 0;
            double ganancia;
            foreach (Item item in Individuos)
            {
                ganancia = 0;
                if (item.getPeso() <= capacidadMochila)
                {
                    item.setGanancia(funcion(item.getValor(), 0));
                }
                else
                {
                    item.setGanancia(0);
                    //ganancia = funcion(item.getValor(), penalizacion(item.getValor()));//ganancia con penalizacion
                    //item.setGanancia(ganancia);
                }
                sumatoria += item.getGanacia();
            }
        }
        public double funcion(String item, double pen)
        {
            double ganancia = 0;
            int cont = 0;
            foreach (char p in item)
            {
                if (p == '1')
                {
                    ganancia += itemsGanancia[cont] - pen;
                }
                cont++;
            }
            return ganancia;
        }
        public void fnorm()
        {
            int i = 0;
            double acumulado = 0;
            foreach (Item item in Individuos)
            {
                Fnorm.Add(item.getGanacia() / sumatoria);
                acumulado = acumulado + Convert.ToDouble(Fnorm[i]);//Calcular acumulado de fnorm
                Acumulado.Add(acumulado);
                i++;
            }
        }
        public void ruleta()
        {
            calcularMayor();
            for (int i = 0; i < Poblacion; i++) //seleccion por ruleta
            {
                double random = r.NextDouble();//Numero random entre 0 y 1
                for (int j = 0; j < Poblacion; j++)
                {
                    if (Acumulado[j] > random)
                    {
                        Padres.Add(Individuos[j]);
                        j = Poblacion;
                    }
                }
            }
        }
        public void cruce()
        {
            String aux1 = "", aux2 = "";
            double cruce;
            int pcrt1, pcrt2;
            for (int i = 0; i < Poblacion - 1; i++)
            {
                cruce = r.NextDouble();
                if (cruce <= Convert.ToDouble(0.70))
                {
                    do
                    {
                        pcrt1 = r.Next(0, itemsPeso.Count);//random de 0 a 7
                        pcrt2 = r.Next(0, itemsPeso.Count);
                    } while (pcrt1 == pcrt2);
                    if (pcrt1 < pcrt2)
                    {
                        for (int j = 0; j < itemsPeso.Count; j++)
                        {
                            if (j >= pcrt1 && j <= pcrt2)
                            {
                                aux1 += Padres[i + 1].getValor()[j];
                                aux2 += Padres[i].getValor()[j];
                            }
                            else
                            {
                                aux1 += Padres[i].getValor()[j];
                                aux2 += Padres[i + 1].getValor()[j];
                            }

                        }
                        Item hijo = new Item();
                        hijo.setValor(aux1);
                        Hijos.Add(hijo);
                        aux1 = "";
                        hijo = new Item();
                        hijo.setValor(aux2);
                        Hijos.Add(hijo);
                        aux2 = "";
                    }
                    else
                    {
                        for (int j = 0; j < itemsPeso.Count; j++)
                        {
                            if (j <= pcrt2 || j >= pcrt1)
                            {
                                aux1 += Padres[i + 1].getValor()[j];
                                aux2 += Padres[i].getValor()[j];
                            }
                            else
                            {
                                aux1 += Padres[i].getValor()[j];
                                aux2 += Padres[i + 1].getValor()[j];
                            }

                        }
                        Item hijo = new Item();
                        hijo.setValor(aux1);
                        Hijos.Add(hijo);
                        aux1 = "";
                        hijo = new Item();
                        hijo.setValor(aux2);
                        Hijos.Add(hijo);
                        aux2 = "";
                    }
                    i++;
                }
                else
                {
                    Hijos.Add(Padres[i]);
                    i++;
                    Hijos.Add(Padres[i]);
                }
            }
        }
        public void mutacion()
        {
            for (int i = 0; i < Poblacion; i++) //Recorrer el numero de hijos
            {
                string aux = "";
                for (int j = 0; j < itemsPeso.Count; j++)//Recorrer el numero de elementos de cada hijo
                {
                    double al1 = r.NextDouble();
                    if (al1 < Convert.ToDouble(0.01))//Si el numero aleatorio es menor que la probabilidad de mutacion
                    {
                        if (Hijos[i].getValor()[j] == '0')//si la posicion actual de j en hijo es 0
                        {
                            aux += "1";
                        }
                        else
                        {
                            aux += "0";
                        }
                    }
                    else
                    {
                        aux += Hijos[i].getValor().ToString()[j];
                    }
                }
                Mutacion.Add(aux);
                aux = "";
            }
        }
        public void reinicio()//se limpian los individuos de agregan los que estan en mutacion a individuos y se limpian los demas valores
        {
            //lbPruebas.Items.Clear();
            Individuos.Clear();
            foreach (String individuo in Mutacion)
            {
                Item ind = new Item();
                ind.setValor(individuo);
                Individuos.Add(ind);
            }
            Padres.Clear();
            Hijos.Clear();
            Fnorm.Clear();
            Acumulado.Clear();
            Mutacion.Clear();
        }
        public void calcularMayor()//se calcula la mejor convinacion de items
        {
            foreach (Item individuo in Individuos)
            {
                if (mayor.getGanacia() < individuo.getGanacia())
                {
                    mayor = individuo;
                }
            }
        }
        public int numeroItems(String mochila)
        {
            int items = 0;
            foreach (Char item in mochila)
            {
                if (item == '1')
                {
                    items++;
                }
            }
            return items;
        }
        public void limpieza()
        {
            itemsGanancia.Clear();
            itemsPeso.Clear();
            Individuos.Clear();
            Padres.Clear();
            Hijos.Clear();
            Fnorm.Clear();
            Acumulado.Clear();
            Mutacion.Clear();
            mayor = new Item();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //GV_Items.Rows.Remove(GV_Items.CurrentRow);
            GV_Items.Rows.Clear();
        }
    }
}
