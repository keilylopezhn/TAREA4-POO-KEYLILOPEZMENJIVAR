using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.FORMULARIOS
{
    public partial class FrmSalario : Form
    {
        CLASES.NUEVO_SALARIO sALARIO = new CLASES.NUEVO_SALARIO();
        public FrmSalario()
        {
            InitializeComponent();
        }

        private void FrmSalario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length==0)
            {
                MessageBox.Show("INGRESAR NOMBRE");
                TxtNombre.Focus();
                return;
            }
            if (TxtHex.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE CANTIDAD HORA");
                TxtHex.Focus();
                return;
            }
            if (TxtSalarioB.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESAR SALARIO BASE");
                TxtSalarioB.Focus();
                return;
            }
            if (TxtHrex.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESAR PRECIO HORA");
                TxtHrex.Focus();
                return;
            }
            double sal, salhe,ded,saln,ch;
            string nombre;

            sal= Convert.ToDouble(TxtSalarioB.Text);
            salhe = Convert.ToDouble(TxtHex.Text);
            ded = Convert.ToDouble(TxtDeduc.Text);
            saln = Convert.ToDouble(TxtSalN.Text);
            ch = Convert.ToDouble(TxtHrex.Text);
            nombre = TxtNombre.Text;

            

            salhe = sALARIO.Salext(ch,salhe);

            TxtNombre.Text = nombre;
            TxtDeduc.Text = ded.ToString();
            TxtHex.Text = sALARIO.Salext(ch, salhe).ToString();
            TxtSalN.Text = sALARIO.Salanet(sal,salhe,ded).ToString();


                

            






        }
    }
}
