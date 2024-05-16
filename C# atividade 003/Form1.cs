using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__atividade_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBox1.Text);
            int valor2 = Convert.ToInt32(textBox2.Text);
            int valor3 = Convert.ToInt32(textBox3.Text);

            double Media = (valor1 + valor2 + valor3) / 3;
            MessageBox.Show($"A media das idade é: {Media}", "Média das idades");
        }
    }
}
