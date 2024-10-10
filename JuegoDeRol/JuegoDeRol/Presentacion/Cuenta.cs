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
    public partial class Cuenta : UserControl
    {
        int partidaGuardada = 0;
        public Cuenta()
        {
            InitializeComponent();
            cmb_pais.SelectedIndex = 9;
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
           panel1.Controls.Clear();
            panel1.Controls.Add(new Ctl_principal());
        }

    
        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            if (partidaGuardada == 0)
            {
              DialogResult resultado=  MessageBox.Show("Desea regresar sin guardar?","Aviso del sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    pnl_principal.Controls.Clear();
                    pnl_principal.Controls.Add(new Ctl_principal());
                }
            }
            else
            {
                pnl_principal.Controls.Clear();
                pnl_principal.Controls.Add(new Ctl_principal());
            }
           
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados con exito","AVISO DEL SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
            partidaGuardada = partidaGuardada + 1;
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
