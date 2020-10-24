using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.FORMULARIOS
{
    public partial class FrmSalarioBaseAumento : Form
    {
        CLASES.AUMENTO premio = new CLASES.AUMENTO();
        public FrmSalarioBaseAumento()
        {
            InitializeComponent();
        }

        private void FrmSalarioBaseAumento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtSb.Text.Trim().Length== 0)
            {
                MessageBox.Show("CAMPO REQUERIDO");
                TxtSb.Focus();
                return;
            }
            if (TxtAum.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAMPO REQUERIDO");
                TxtAum.Focus();
                return;
            }

            double sal, aum,tot;

            sal = Convert.ToDouble(TxtSb.Text.Trim());
            aum = Convert.ToDouble(TxtAum.Text.Trim());

            tot = sal + aum;

            TxtSN.Text = MessageBox.Show("NUEVO SALARIO") + premio.Aumento(sal, aum).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtAum.Clear();
            TxtSb.Clear();
            TxtSN.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
