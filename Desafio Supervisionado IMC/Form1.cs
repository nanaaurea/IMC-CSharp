using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Supervisionado_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;  
            double resultado = 0;   
            if(n1 != "" && n2 != "")
            {
                n1 = double.Parse(n1.Text);
                n2 = double.Parse(n2.Text);
            }


        }
    }
}
