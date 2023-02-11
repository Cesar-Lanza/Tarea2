using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private async void Calcular_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(Nota1.Text);
            decimal n2 = Convert.ToDecimal(Nota2.Text);
            decimal n3 = Convert.ToDecimal(Nota3.Text);
            decimal n4 = Convert.ToDecimal(Nota4.Text);

            decimal resultado = await promedioasync(n1, n2, n3, n4);

            MessageBox.Show("El promedio Final de el Estudiantes es de: " + resultado);
        }

        private async Task<decimal> promedioasync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
    }
}
