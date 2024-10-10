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
        string nombreUsuario = "Admin";
        string nickname = "Administrador";
        public string contraseña = "admin123";
        string correo = "correoadministrador@correo.com";

  
        
        public Cuenta()
        {
            InitializeComponent();
            cmb_pais.SelectedIndex = 9;
            txt_nombre_usuario.Text = nombreUsuario;
            txt_contraseña.Text = contraseña;
            txt_nickname.Text = nickname;
            txt_correo.Text = correo;
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
           panel1.Controls.Clear();
            panel1.Controls.Add(new Ctl_principal());
        }

    
        private void btn_volver_Click_1(object sender, EventArgs e)
        {

            if (txt_nombre_usuario.Text != nombreUsuario || txt_nickname.Text != nickname || txt_correo.Text != correo || txt_contraseña.Text != contraseña )
            {
                DialogResult resultado=  MessageBox.Show("Desea regresar sin guardar?","Aviso del sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    pnl_principal.Controls.Clear();
                    pnl_principal.Controls.Add(new Ctl_principal());
                }

                else
                {
                    //NO PASA NADA
                }
            }
            else{
                pnl_principal.Controls.Clear();
                pnl_principal.Controls.Add(new Ctl_principal());

            }
         

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados con exito","AVISO DEL SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
            nombreUsuario = txt_nombre_usuario.Text;
            nickname = txt_nickname.Text ;
            correo = txt_correo.Text ;
            contraseña = txt_contraseña.Text;
            partidaGuardada = partidaGuardada + 1;
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            pnl_cambio_clave.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_clave_actual.Text != contraseña)
            {
                MessageBox.Show("Contraseña actual equivocada","Mensaje de error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }
            else
            {
                if (txt_clave_nueva.Text == txt_verificacion_clave.Text)
                    {
                    if (txt_clave_nueva.TextLength < 5)
                    {
                        MessageBox.Show("minimo 5 caracteres", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("Contraseña actualizada","Mensaje del sistema", MessageBoxButtons.OK,MessageBoxIcon.Information); 
                    contraseña = txt_clave_nueva.Text;
                    pnl_cambio_clave.Visible = false;
                    txt_clave_nueva.Clear();
                    txt_verificacion_clave.Clear();
                    txt_clave_actual.Clear();
                    txt_contraseña.Text = contraseña;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Mensaje de error ", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

                }
            }
        }

        private void btn_cambiar_clave_Click(object sender, EventArgs e)
        {
            pnl_cambio_clave.Visible = true;
        }
    }
}
