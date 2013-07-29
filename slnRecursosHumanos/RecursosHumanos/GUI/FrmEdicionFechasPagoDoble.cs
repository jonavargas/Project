using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.GUI
{
    public partial class FrmEdicionFechasPagoDoble : Form
    {
        public FrmEdicionFechasPagoDoble()
        {
            InitializeComponent();

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbDia.Enabled = true;
            switch (this.cmbMes.SelectedIndex)
            {

                case 0:
                case 2:
                case 4:
                case 6:
                case 7:
                case 9:
                case 11:
                    cmbDia.Items.Clear();
                    for (int cont = 1; cont < 32; cont++)
                    {
                        cmbDia.Items.Add(cont);
                    }
                    break;
                case 3:
                case 5:
                case 8:
                case 10:
                    cmbDia.Items.Clear();
                    for (int cont = 1; cont < 31; cont++)
                    {
                        cmbDia.Items.Add(cont);
                    }
                    break;
                case 1:
                    cmbDia.Items.Clear();
                    for (int cont = 1; cont < 29; cont++)
                    {
                        cmbDia.Items.Add(cont);
                    }
                    break;
            }
        }
    }
}
