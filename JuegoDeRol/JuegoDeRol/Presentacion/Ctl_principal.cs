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
    public partial class Ctl_principal : UserControl
    {
        public Ctl_principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nuevap_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal actual
            Frm_principal formularioPrincipal = Application.OpenForms.OfType<Frm_principal>().FirstOrDefault();

            if (formularioPrincipal != null)
            {
                // Crear una instancia del control Seleccion_personaje
                Seleccion_personaje control = new Seleccion_personaje();

                // Limpiar el contenido del panel pnl_principal
                formularioPrincipal.pnl_principal.Controls.Clear();

                // Agregar el control Seleccion_personaje al panel pnl_principal
                formularioPrincipal.pnl_principal.Controls.Add(control);
            }

        }

        private void btn_tienda_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal actual
            Frm_principal formularioPrincipal = Application.OpenForms.OfType<Frm_principal>().FirstOrDefault();

            if (formularioPrincipal != null)
            {
                // Crear una instancia del control Seleccion_personaje
                Tienda_principal control = new Tienda_principal();

                // Limpiar el contenido del panel pnl_principal
                formularioPrincipal.pnl_principal.Controls.Clear();

                // Agregar el control Seleccion_personaje al panel pnl_principal
                formularioPrincipal.pnl_principal.Controls.Add(control);
            }
        }
    }
}
