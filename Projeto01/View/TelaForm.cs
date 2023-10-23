using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01.View
{
    public partial class TelaForm : Form
    {
        public TelaForm()
        {
            InitializeComponent();
        }

        private int MaiorValor(int num, int num2, int num3)
        {
            int resultado = Math.Max(num, Math.Max(num2, num3));
            return resultado;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbx_Valor1.Text);
            int num2 = Convert.ToInt32(tbx_Valor2.Text);
            int num3 = Convert.ToInt32(tbx_Valor3.Text);

            lbl_Resultado.Text = "O maior valor é " + MaiorValor(num, num2, num3);
        }

        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            lbl_Resultado.Text = string.Empty;
        }
    }
}
