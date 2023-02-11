using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicio_2
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
               
        private async void PromedioButton_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(Pacial1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Pacial2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Pacial3TextBox.Text);
            decimal nota4 = Convert.ToDecimal(Pacial4TextBox.Text);

            decimal total = await PromedioAsync(nota1,nota2, nota3, nota4);

            MessageBox.Show($"El promedio final es: {total}");
        }

        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
    }
}
