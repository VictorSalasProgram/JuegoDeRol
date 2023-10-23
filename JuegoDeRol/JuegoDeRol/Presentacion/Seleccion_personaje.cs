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
    public partial class Seleccion_personaje : UserControl
    {
        public Seleccion_personaje()
        {
            InitializeComponent();
        }
        public int p_seleccionado = 0;

        private void btn_volver_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(new Ctl_principal());
        }

        private void pb_caballero_MouseHover(object sender, EventArgs e)
        {
            pnl_caballero.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb_caballero_MouseLeave(object sender, EventArgs e)
        {
            pnl_caballero.BorderStyle = BorderStyle.None;
        }

        private void pb_elfa_MouseHover(object sender, EventArgs e)
        {
            pnl_elfo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb_elfa_MouseLeave(object sender, EventArgs e)
        {
            pnl_elfo.BorderStyle = BorderStyle.None;
        }

        private void pb_mago_MouseHover(object sender, EventArgs e)
        {
            pnl_mago.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb_mago_MouseLeave(object sender, EventArgs e)
        {
            pnl_mago.BorderStyle = BorderStyle.None;
        }

        private void pb_orco_MouseHover(object sender, EventArgs e)
        {
            pnl_orco.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb_orco_MouseLeave(object sender, EventArgs e)
        {
            pnl_orco.BorderStyle = BorderStyle.None;
        }

        private void pb_co_MouseHover(object sender, EventArgs e)
        {
            pnl_co.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb_co_MouseLeave(object sender, EventArgs e)
        {
            pnl_co.BorderStyle = BorderStyle.None;
        }

        private void pnl_caballero_Click(object sender, EventArgs e)
        {
            fpnl_personajes.Controls.Clear();
        }

        private void pb_caballero_Click(object sender, EventArgs e)
        {
            pnl_fichas.Visible = true;
            pnl_fichas.Controls.Add(new Ficha_caballero());
            btn_seleccionar.Visible = true;
            btn_jugar.Enabled = true;
            p_seleccionado = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fpnl_personajes.Controls.Clear();
            fpnl_personajes.Controls.Add(new Ficha_caballero());
            btn_seleccionar.Visible = true;
            p_seleccionado = 1;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_caballero.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pnl_caballero.BorderStyle = BorderStyle.None;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_elfo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pnl_elfo.BorderStyle = BorderStyle.None;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pnl_mago.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pnl_mago.BorderStyle = BorderStyle.None;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pnl_orco.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pnl_orco.BorderStyle = BorderStyle.None;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_co.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pnl_co.BorderStyle = BorderStyle.None;
        }

        private void pb_elfa_Click(object sender, EventArgs e)
        {
            pnl_fichas.Visible = true;
            pnl_fichas.Controls.Add(new Ficha_elfa());
            btn_seleccionar.Visible = true;
            btn_jugar.Enabled = true;
            p_seleccionado = 2;
        }

        private void pb_mago_Click(object sender, EventArgs e)
        {
            pnl_fichas.Visible = true;
            pnl_fichas.Controls.Add(new Ficha_mago());
            btn_seleccionar.Visible =true;
            btn_jugar.Enabled = true;
            p_seleccionado = 3;
        }

        private void pb_orco_Click(object sender, EventArgs e)
        {
            pnl_fichas.Visible=true;
            pnl_fichas.Controls.Add(new Ficha_orco());
            btn_seleccionar.Visible = true;
            btn_jugar.Enabled = true;
            p_seleccionado = 4;
        }

        private void pb_co_Click(object sender, EventArgs e)
        {
            pnl_fichas.Visible = true;
            pnl_fichas.Controls.Add(new Ficha_co());
            btn_seleccionar.Visible = true;
            btn_jugar.Enabled = true;
            p_seleccionado = 5;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            fpnl_personajes.Controls.Clear();
            fpnl_personajes.Controls.Add(new Ficha_elfa());
            p_seleccionado = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            fpnl_personajes.Controls.Clear();
            fpnl_personajes.Controls.Add(new Ficha_mago());
            p_seleccionado = 3;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            fpnl_personajes.Controls.Clear();
            fpnl_personajes.Controls.Add(new Ficha_orco());
            p_seleccionado = 4;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            fpnl_personajes.Controls.Clear();
            fpnl_personajes.Controls.Add(new Ficha_co());
            p_seleccionado = 5;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            pnl_fichas.Controls.Clear();
            pnl_fichas.Visible = false;
            btn_seleccionar.Visible = false;
            btn_jugar.Enabled = false;
            p_seleccionado = 0;

        }

        private void Seleccion_personaje_Load(object sender, EventArgs e)
        {
            fpnl_personajes.Controls.Clear();
            
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            timer1.Start();
   
            switch (p_seleccionado)
            {
                case 1:
                    lbl_carga_personaje.Text = "Has elegido caballero...";
                    break;
                case 2:
                    lbl_carga_personaje.Text = "Has elegido elfa...";
                    break;
                case 3:
                    lbl_carga_personaje.Text = "Has elegido mago...";
                    break;
                case 4:
                    lbl_carga_personaje.Text = "Has elegido orco...";
                    break;
                case 5:
                    lbl_carga_personaje.Text = "Has elegido caballero oscuro...";
                    break;

            }

            pcb_cargando.Visible = true;
            lbl_carga_personaje.Visible = true;
            fpnl_personajes.Visible = false;
            btn_jugar .Visible = false;
            btn_seleccionar.Visible = false;
            btn_volver.Visible = false;
            pnl_fichas .Visible = false;
            panel1 .Visible = false;
            pnl_principal.BackgroundImage = Image.FromFile("C:\\Users\\uSer\\source\\repos\\JuegoDeRol\\JuegoDeRol\\Imagenes\\fondo_carga1.jpg");
            pnl_principal.BackgroundImageLayout = ImageLayout.Stretch;
            pbar_cargando.BringToFront();
            pbar_cargando.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbar_cargando.Value + 1 <= pbar_cargando.Maximum)
            {
                pbar_cargando.Value += 1;

                
            }
            else
            {
                // Llegaste al valor máximo o a un punto de referencia deseado.
                // Puedes detener el Timer si es necesario.
                timer1.Stop();
            }
        }
    }
}
