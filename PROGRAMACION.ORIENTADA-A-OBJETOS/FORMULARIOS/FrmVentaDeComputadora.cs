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
    public partial class FrmVentaDeComputadora : Form
    {
        public FrmVentaDeComputadora()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL CAMPO DEXCRIPCION ES REQUERIDO");
                TxtDescripcion.Focus();
                return;
            }
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL CAMPO PRECIO ES REQUERIDO");
                TxtPrecio.Focus();
                return;
            }
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL CAMPO PRECIO ES REQUERIDO");
                TxtPrecio.Focus();
                return;
            }

            if (RbnContador.Checked == true)
            {
                TxtPrecioNeto.Text = TxtPrecio.Text;

                


            }
            else
            {
               
            }

        }
    }
}
