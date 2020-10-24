using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.FORMULARIOS
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSalario sal =new FORMULARIOS.FrmSalario();
            sal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmPrestamo presta = new FORMULARIOS.FrmPrestamo();
            presta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSalarioBaseAumento aumento = new FORMULARIOS.FrmSalarioBaseAumento();
            aumento.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmVentaDeComputadora compu = new FORMULARIOS.FrmVentaDeComputadora();
            compu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmVendedor vende = new FORMULARIOS.FrmVendedor();
            vende.Show();
        }
    }
}
