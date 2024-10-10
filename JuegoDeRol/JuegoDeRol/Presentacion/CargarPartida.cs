using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeRol.Presentacion
{
    public partial class CargarPartida : UserControl
    {
        public CargarPartida()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(new Ctl_principal());
        }

        private void btn_slot1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PArtida cargada","Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
