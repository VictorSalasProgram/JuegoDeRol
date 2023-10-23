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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nuevap_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(new Seleccion_personaje());
            

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(new Ctl_principal());
            
        }
    }
}
