using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form__ejercicio2_calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txt_valor1.Text);
            int Valor2 = Convert.ToInt32(txt_valor2.Text);



            int Resta, Multiplicacion, Division, Suma;

            Resta = Valor1 - Valor2;
            Multiplicacion = Valor2 * Valor1;
            Division = Valor1 / Valor2;
            Suma = Valor2 + Valor1;



            txt_resta.Text = Resta.ToString();

            txt_multiplicacion.Text = Multiplicacion.ToString();

            txt_divicion.Text = Division.ToString();

            txt_suma.Text = Suma.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_valor1.Clear();
            txt_valor2.Clear();
            txt_suma.Clear();
            txt_resta.Clear();
            txt_multiplicacion.Clear();
            txt_divicion.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_suma.Enabled = false;
            txt_resta.Enabled = false;
            txt_multiplicacion.Enabled = false;
            txt_divicion.Enabled = false;
        }
    }
}
