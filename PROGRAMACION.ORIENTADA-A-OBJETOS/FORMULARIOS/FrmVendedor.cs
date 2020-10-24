using PROGRAMACION.ORIENTADA_A_OBJETOS.CLASES;
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
    public partial class FrmVendedor : Form

        
    {
        CLASES.VENTAS vENTAS = new CLASES.VENTAS();
       
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtLunes.Clear();
            TxtMar.Clear();
            TxtMier.Clear();
            TxtJue.Clear();
            TxtVier.Clear();
            TxtSab.Clear();
            TxtVenta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtLunes.Text.Trim().Length==0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtLunes.Focus();
                return;
            }
            if (TxtMar.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtMar.Focus();
                return;
            }
            if (TxtMier.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtMier.Focus();
                return;
            }
            if (TxtJue.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtJue.Focus();
                return;
            }
            if (TxtVier.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtVier.Focus();
                return;
            }

            if (TxtSab.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtSab.Focus();
                return;
            }
            double d1, d2, d3, d4, d5, d6, valor, suma;

            d1 = Convert.ToDouble(TxtLunes.Text.Trim());
            d2 = Convert.ToDouble(TxtMar.Text.Trim());
            d3 = Convert.ToDouble(TxtMier.Text.Trim());
            d4 = Convert.ToDouble(TxtJue.Text.Trim());
            d5 = Convert.ToDouble(TxtVier.Text.Trim());
            d6 = Convert.ToDouble(TxtSab.Text.Trim());

            valor = 0.05;
            TxtVenta.Text = valor.ToString() ;
        }
    }
}
