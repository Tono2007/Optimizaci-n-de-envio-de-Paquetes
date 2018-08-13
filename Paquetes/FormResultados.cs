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
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbREs.Items.Clear();
            lbResultados.Items.Clear();          
            this.Close();
        }
    }
}
