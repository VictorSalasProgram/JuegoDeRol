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
    public partial class Tienda_principal : UserControl
    {
        public Tienda_principal()
        {
            InitializeComponent();
            toolTip1.SetToolTip(pictureBox3, "ORO: 100 \n Posion de vida \n Recupera 25 puntos de vida.");
            toolTip1.SetToolTip(pictureBox4, "ORO: 100 \n Posion de mana \n Recupera 25 puntos de mana.");
            toolTip1.SetToolTip(pictureBox5, "ORO: 200 \n Posion de antidoto \n Elimina los efetos del veneno.");
            toolTip1.SetToolTip(pictureBox6, "ORO: 500 \n Super posion \n Recupera 25 puntos de vida y de mana.");
            toolTip1.SetToolTip(pictureBox7, "ORO: 700 \n Afilar espada \n Aumenta en 15% el ataque fisico del guerrero.");
            toolTip1.SetToolTip(pictureBox8, "ORO: 700 \n Armadura mejorada \n Aumenta en 15% la defensa fisca del guerrero.");
            toolTip1.SetToolTip(pictureBox9, "ORO: 700 \n Baston de Gandalf \n Aumenta en 15% el ataque magico del guerrero.");
            toolTip1.SetToolTip(pictureBox16, "ORO: 1000 \n Botas de Hermes \n Aumenta en 15% la velodicdad del guerrero.");
            toolTip1.SetToolTip(pictureBox15, "ORO: 700 \n Amuleto Magico \n Otorga a quien lo tenga +15% de defensa magica.");
            toolTip1.SetToolTip(pictureBox14, "ORO: 2000 \n DIAMANTES: 10 \n Esmeralda \n Se usa para subir 1 nivel de experiencia del guerrero.");
            toolTip1.SetToolTip(pictureBox13, "ORO: 700 \n Flechas Venenosas \n Al atacar aplicaras veneno a tus objetivos.");
            toolTip1.SetToolTip(pictureBox12, "DIAMANTES: 10 \n Furia \n Asesina a un enemigo de un solo golpe.");
            toolTip1.SetToolTip(pictureBox11, "DIAMANTES: 10 \n Armadura de Hercules \n Te hace intocable por dos turnos.");
            toolTip1.SetToolTip(pictureBox10, "ORO: 1000 \n Diamantes \n Adquiere 1 diamante.");
        }
        int oro = 10000;
        int diamantes = 10;
        int inventarioVida = 0;
        int inventarioMana = 0;
        int inventarioAntidoto = 0;
        int inventarioSuperPosion = 0;
        int inventarioAfilar = 0;
        int inventarioArmaduraMejorada = 0;
        int inventarioBaston = 0;
        int inventarioBotas= 0;
        int inventarioAmuleto = 0;
        int inventarioFlechasVenenosas = 0;
        int inventarioFuria = 0;
        int inventarioArmaduraHercules = 0;
        int inventarioEsmeraldas = 0;
        
        private void actualizarOro()
        {
            txt_oro.Text = oro.ToString();
            txt_diamantes.Text = diamantes.ToString();
        }
        private void actualizarInventario()
        {
            txt_inv_vida.Text = inventarioVida.ToString();
            txt_inv_mana.Text = inventarioMana.ToString();
            txt_inv_sp.Text = inventarioSuperPosion.ToString();
            txt_inv_ant.Text = inventarioAntidoto.ToString();
            txt_inv_df.Text = inventarioArmaduraMejorada.ToString();
            txt_inv_af.Text = inventarioAfilar.ToString();
            txt_inv_fu.Text = inventarioFuria.ToString();
            txt_inv_vel.Text = inventarioBotas.ToString();
            txt_inv_am.Text = inventarioBaston.ToString();
            txt_inv_esm.Text = inventarioEsmeraldas.ToString();
            txt_inv_dm.Text = inventarioAmuleto.ToString();
            txt_inv_sd.Text = inventarioArmaduraHercules.ToString();
            txt_inv_ven.Text = inventarioFlechasVenenosas.ToString();
            txt_diamantes.Text = diamantes.ToString();
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(new Ctl_principal());
        }

        private void Tienda_principal_Load(object sender, EventArgs e)
        {
            txt_oro.Text = oro.ToString();
            txt_diamantes.Text = diamantes.ToString();
            txt_inv_vida.Text = inventarioVida.ToString();
            txt_inv_mana.Text = inventarioMana.ToString();
            txt_inv_sp.Text = inventarioSuperPosion.ToString();
            txt_inv_ant.Text = inventarioAntidoto.ToString();   
            txt_inv_df.Text = inventarioArmaduraMejorada.ToString();
            txt_inv_af.Text = inventarioAfilar.ToString();
            txt_inv_fu.Text = inventarioFuria.ToString();
            txt_inv_vel.Text = inventarioBotas.ToString();
            txt_inv_am.Text = inventarioBaston.ToString();
            txt_inv_esm.Text = inventarioEsmeraldas.ToString(); 
            txt_inv_dm.Text = inventarioAmuleto.ToString();
            txt_inv_sd.Text = inventarioArmaduraHercules.ToString();
            txt_inv_ven.Text = inventarioFlechasVenenosas.ToString();

        }

 

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (oro >= 100)
            {
                oro = oro - 100;
                inventarioVida = inventarioVida + 1;
                actualizarOro();
                actualizarInventario();
            }
     
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        #region "Diseño de seleccion"
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnl_vida.BorderStyle = BorderStyle.Fixed3D;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnl_vida.BorderStyle = BorderStyle.None;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_vida.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnl_mana.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pnl_mana.BorderStyle = BorderStyle.None;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_mana.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pnl_mana.BorderStyle = BorderStyle.None;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pnl_ant.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pnl_ant.BorderStyle = BorderStyle.None;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pnl_ant.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pnl_ant.BorderStyle = BorderStyle.None;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pnl_superp.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pnl_superp.BorderStyle = BorderStyle.None;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pnl_superp.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pnl_superp.BorderStyle = BorderStyle.None;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pnl_ataquefisico.BorderStyle = BorderStyle.Fixed3D; 
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pnl_ataquefisico.BorderStyle = BorderStyle.None;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_ataquefisico.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pnl_ataquefisico.BorderStyle = BorderStyle.None;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_defensafisica.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pnl_defensafisica.BorderStyle = BorderStyle.None;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pnl_defensafisica.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            pnl_defensafisica.BorderStyle = BorderStyle.None;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pnl_ataquemagico.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pnl_ataquemagico.BorderStyle = BorderStyle.None;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_ataquemagico.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            pnl_ataquemagico.BorderStyle = BorderStyle.None;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pnl_velocidad.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pnl_velocidad.BorderStyle = BorderStyle.None;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            pnl_velocidad.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            pnl_velocidad.BorderStyle = BorderStyle.None;
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            pnl_defensamagica.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pnl_defensamagica.BorderStyle = BorderStyle.None;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            pnl_defensamagica.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            pnl_defensamagica.BorderStyle = BorderStyle.None;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pnl_esmeralda.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pnl_esmeralda.BorderStyle = BorderStyle.None;
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            pnl_esmeralda.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            pnl_esmeralda.BorderStyle = BorderStyle.None;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pnl_flechas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pnl_flechas.BorderStyle = BorderStyle.None;
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            pnl_flechas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            pnl_flechas.BorderStyle = BorderStyle.None;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pnl_asesinato.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pnl_asesinato.BorderStyle = BorderStyle.None;
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            pnl_asesinato.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            pnl_asesinato.BorderStyle = BorderStyle.None;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pnl_superdef.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pnl_superdef.BorderStyle = BorderStyle.None;
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            pnl_superdef.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            pnl_superdef.BorderStyle = BorderStyle.None;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pnl_diamantes.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pnl_diamantes.BorderStyle = BorderStyle.None;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            pnl_diamantes.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            pnl_diamantes.BorderStyle = BorderStyle.None;
        }

#endregion
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (oro >= 100)
            {
                oro = oro - 100;
                inventarioMana = inventarioMana + 1;
                actualizarOro();
                actualizarInventario();

            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (oro >= 100)
            {
                oro = oro - 100;
                inventarioVida = inventarioVida + 1;
                actualizarOro();
                actualizarInventario();

            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (oro >= 100)
            {
                oro = oro - 100;
                inventarioMana = inventarioMana + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (oro >= 200)
            {
                oro = oro - 200;
                inventarioAntidoto = inventarioAntidoto + 1;
                actualizarOro();
                actualizarInventario();

            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (oro >= 200)
            {
                oro = oro - 200;
                inventarioAntidoto = inventarioAntidoto + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (oro >= 500)
            {
                oro = oro - 500;
                inventarioSuperPosion = inventarioSuperPosion + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (oro >= 500)
            {
                oro = oro - 500;
                inventarioSuperPosion = inventarioSuperPosion + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioAfilar = inventarioAfilar + 1;
                actualizarOro();
                actualizarInventario();

            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioAfilar = inventarioAfilar + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioArmaduraMejorada = inventarioArmaduraMejorada + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioBaston = inventarioBaston + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioArmaduraMejorada = inventarioArmaduraMejorada + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioBaston = inventarioBaston + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (oro >= 1000)
            {
                oro = oro - 1000;
                inventarioBotas = inventarioBotas + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (oro >= 1000)
            {
                oro = oro - 1000;
                inventarioBotas = inventarioBotas + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioAmuleto = inventarioAmuleto + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        private void label9_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioAmuleto = inventarioAmuleto + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (oro >= 2000)
            {
                oro = oro - 2000;
                inventarioEsmeraldas = inventarioEsmeraldas + 1;
                actualizarOro();
                actualizarInventario();
            }
            else
            {
                MessageBox.Show("Oro insuficiente","Aviso del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioFlechasVenenosas = inventarioFlechasVenenosas + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (oro >= 700)
            {
                oro = oro - 700;
                inventarioFlechasVenenosas = inventarioFlechasVenenosas + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (diamantes >= 10)
            {
                diamantes = diamantes - 10;
                inventarioFuria = inventarioFuria + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Diamantes insuficientes", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (diamantes >= 10)
            {
                diamantes = diamantes - 10;
                inventarioFuria = inventarioFuria + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Diamantes insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (diamantes >= 10)
            {
                diamantes = diamantes - 10;
                inventarioArmaduraHercules = inventarioArmaduraHercules + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Diamantes insuficientes", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (diamantes >= 10)
            {
                diamantes = diamantes - 10;
                inventarioArmaduraHercules = inventarioArmaduraHercules + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Diamantes insuficientes", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (oro >= 1000)
            {
                oro = oro - 1000;
                diamantes = diamantes + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (oro >= 1000)
            {
                oro = oro - 1000;
                diamantes = diamantes + 1;
                actualizarOro();
                actualizarInventario();
            }

            else
            {
                MessageBox.Show("Oro insuficiente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
