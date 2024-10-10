namespace JuegoDeRol.Presentacion
{
    partial class Seleccion_personaje
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion_personaje));
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.lbl_titulocarga = new System.Windows.Forms.Label();
            this.pcb_cargando = new System.Windows.Forms.PictureBox();
            this.lbl_carga_personaje = new System.Windows.Forms.Label();
            this.pbar_cargando = new System.Windows.Forms.ProgressBar();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.pnl_fichas = new System.Windows.Forms.Panel();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.fpnl_personajes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_caballero = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_caballero = new System.Windows.Forms.PictureBox();
            this.pnl_elfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_elfa = new System.Windows.Forms.PictureBox();
            this.pnl_mago = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_mago = new System.Windows.Forms.PictureBox();
            this.pnl_orco = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_orco = new System.Windows.Forms.PictureBox();
            this.pnl_co = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_co = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cargando)).BeginInit();
            this.fpnl_personajes.SuspendLayout();
            this.pnl_caballero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_caballero)).BeginInit();
            this.pnl_elfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_elfa)).BeginInit();
            this.pnl_mago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mago)).BeginInit();
            this.pnl_orco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_orco)).BeginInit();
            this.pnl_co.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_co)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_principal
            // 
            this.pnl_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnl_principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_principal.BackgroundImage")));
            this.pnl_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_principal.Controls.Add(this.lbl_titulocarga);
            this.pnl_principal.Controls.Add(this.pcb_cargando);
            this.pnl_principal.Controls.Add(this.lbl_carga_personaje);
            this.pnl_principal.Controls.Add(this.pbar_cargando);
            this.pnl_principal.Controls.Add(this.btn_jugar);
            this.pnl_principal.Controls.Add(this.pnl_fichas);
            this.pnl_principal.Controls.Add(this.btn_seleccionar);
            this.pnl_principal.Controls.Add(this.fpnl_personajes);
            this.pnl_principal.Controls.Add(this.panel1);
            this.pnl_principal.Controls.Add(this.btn_volver);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1773, 951);
            this.pnl_principal.TabIndex = 1;
            // 
            // lbl_titulocarga
            // 
            this.lbl_titulocarga.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulocarga.Font = new System.Drawing.Font("Consolas", 20F);
            this.lbl_titulocarga.Location = new System.Drawing.Point(471, 81);
            this.lbl_titulocarga.Name = "lbl_titulocarga";
            this.lbl_titulocarga.Size = new System.Drawing.Size(899, 81);
            this.lbl_titulocarga.TabIndex = 12;
            this.lbl_titulocarga.Text = "SwissLand Kingdom.";
            this.lbl_titulocarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulocarga.Visible = false;
            // 
            // pcb_cargando
            // 
            this.pcb_cargando.Image = ((System.Drawing.Image)(resources.GetObject("pcb_cargando.Image")));
            this.pcb_cargando.Location = new System.Drawing.Point(50, 676);
            this.pcb_cargando.Name = "pcb_cargando";
            this.pcb_cargando.Size = new System.Drawing.Size(24, 27);
            this.pcb_cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_cargando.TabIndex = 0;
            this.pcb_cargando.TabStop = false;
            this.pcb_cargando.Visible = false;
            // 
            // lbl_carga_personaje
            // 
            this.lbl_carga_personaje.Location = new System.Drawing.Point(49, 704);
            this.lbl_carga_personaje.Name = "lbl_carga_personaje";
            this.lbl_carga_personaje.Size = new System.Drawing.Size(345, 23);
            this.lbl_carga_personaje.TabIndex = 11;
            this.lbl_carga_personaje.Text = "-";
            this.lbl_carga_personaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_carga_personaje.Visible = false;
            // 
            // pbar_cargando
            // 
            this.pbar_cargando.Location = new System.Drawing.Point(39, 744);
            this.pbar_cargando.Name = "pbar_cargando";
            this.pbar_cargando.Size = new System.Drawing.Size(1630, 82);
            this.pbar_cargando.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar_cargando.TabIndex = 10;
            this.pbar_cargando.Visible = false;
            // 
            // btn_jugar
            // 
            this.btn_jugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_jugar.Enabled = false;
            this.btn_jugar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.Location = new System.Drawing.Point(1508, 778);
            this.btn_jugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(185, 49);
            this.btn_jugar.TabIndex = 9;
            this.btn_jugar.Text = "JUGAR";
            this.btn_jugar.UseVisualStyleBackColor = false;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // pnl_fichas
            // 
            this.pnl_fichas.Location = new System.Drawing.Point(240, 152);
            this.pnl_fichas.Name = "pnl_fichas";
            this.pnl_fichas.Size = new System.Drawing.Size(1436, 581);
            this.pnl_fichas.TabIndex = 8;
            this.pnl_fichas.Visible = false;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_seleccionar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Location = new System.Drawing.Point(209, 787);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(185, 49);
            this.btn_seleccionar.TabIndex = 7;
            this.btn_seleccionar.Text = "Cambiar";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Visible = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // fpnl_personajes
            // 
            this.fpnl_personajes.BackColor = System.Drawing.Color.Transparent;
            this.fpnl_personajes.Controls.Add(this.pnl_caballero);
            this.fpnl_personajes.Controls.Add(this.pnl_elfo);
            this.fpnl_personajes.Controls.Add(this.pnl_mago);
            this.fpnl_personajes.Controls.Add(this.pnl_orco);
            this.fpnl_personajes.Controls.Add(this.pnl_co);
            this.fpnl_personajes.Location = new System.Drawing.Point(161, 152);
            this.fpnl_personajes.Name = "fpnl_personajes";
            this.fpnl_personajes.Size = new System.Drawing.Size(1508, 581);
            this.fpnl_personajes.TabIndex = 6;
            // 
            // pnl_caballero
            // 
            this.pnl_caballero.Controls.Add(this.label1);
            this.pnl_caballero.Controls.Add(this.pb_caballero);
            this.pnl_caballero.Location = new System.Drawing.Point(3, 3);
            this.pnl_caballero.Name = "pnl_caballero";
            this.pnl_caballero.Size = new System.Drawing.Size(290, 550);
            this.pnl_caballero.TabIndex = 0;
            this.pnl_caballero.Click += new System.EventHandler(this.pnl_caballero_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F);
            this.label1.Location = new System.Drawing.Point(37, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CABALLERO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // pb_caballero
            // 
            this.pb_caballero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_caballero.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_caballero.Image = ((System.Drawing.Image)(resources.GetObject("pb_caballero.Image")));
            this.pb_caballero.Location = new System.Drawing.Point(0, 0);
            this.pb_caballero.Name = "pb_caballero";
            this.pb_caballero.Size = new System.Drawing.Size(290, 488);
            this.pb_caballero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_caballero.TabIndex = 0;
            this.pb_caballero.TabStop = false;
            this.pb_caballero.Click += new System.EventHandler(this.pb_caballero_Click);
            this.pb_caballero.MouseLeave += new System.EventHandler(this.pb_caballero_MouseLeave);
            this.pb_caballero.MouseHover += new System.EventHandler(this.pb_caballero_MouseHover);
            // 
            // pnl_elfo
            // 
            this.pnl_elfo.Controls.Add(this.label2);
            this.pnl_elfo.Controls.Add(this.pb_elfa);
            this.pnl_elfo.Location = new System.Drawing.Point(299, 3);
            this.pnl_elfo.Name = "pnl_elfo";
            this.pnl_elfo.Size = new System.Drawing.Size(290, 550);
            this.pnl_elfo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F);
            this.label2.Location = new System.Drawing.Point(37, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "ELFA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // pb_elfa
            // 
            this.pb_elfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_elfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_elfa.Image = ((System.Drawing.Image)(resources.GetObject("pb_elfa.Image")));
            this.pb_elfa.Location = new System.Drawing.Point(0, 0);
            this.pb_elfa.Name = "pb_elfa";
            this.pb_elfa.Size = new System.Drawing.Size(290, 488);
            this.pb_elfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_elfa.TabIndex = 1;
            this.pb_elfa.TabStop = false;
            this.pb_elfa.Click += new System.EventHandler(this.pb_elfa_Click);
            this.pb_elfa.MouseLeave += new System.EventHandler(this.pb_elfa_MouseLeave);
            this.pb_elfa.MouseHover += new System.EventHandler(this.pb_elfa_MouseHover);
            // 
            // pnl_mago
            // 
            this.pnl_mago.Controls.Add(this.label3);
            this.pnl_mago.Controls.Add(this.pb_mago);
            this.pnl_mago.Location = new System.Drawing.Point(595, 3);
            this.pnl_mago.Name = "pnl_mago";
            this.pnl_mago.Size = new System.Drawing.Size(290, 550);
            this.pnl_mago.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F);
            this.label3.Location = new System.Drawing.Point(35, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAGO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // pb_mago
            // 
            this.pb_mago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_mago.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_mago.Image = ((System.Drawing.Image)(resources.GetObject("pb_mago.Image")));
            this.pb_mago.Location = new System.Drawing.Point(0, 0);
            this.pb_mago.Name = "pb_mago";
            this.pb_mago.Size = new System.Drawing.Size(290, 488);
            this.pb_mago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mago.TabIndex = 1;
            this.pb_mago.TabStop = false;
            this.pb_mago.Click += new System.EventHandler(this.pb_mago_Click);
            this.pb_mago.MouseLeave += new System.EventHandler(this.pb_mago_MouseLeave);
            this.pb_mago.MouseHover += new System.EventHandler(this.pb_mago_MouseHover);
            // 
            // pnl_orco
            // 
            this.pnl_orco.Controls.Add(this.label4);
            this.pnl_orco.Controls.Add(this.pb_orco);
            this.pnl_orco.Location = new System.Drawing.Point(891, 3);
            this.pnl_orco.Name = "pnl_orco";
            this.pnl_orco.Size = new System.Drawing.Size(290, 550);
            this.pnl_orco.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F);
            this.label4.Location = new System.Drawing.Point(33, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "ORCO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // pb_orco
            // 
            this.pb_orco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_orco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_orco.Image = ((System.Drawing.Image)(resources.GetObject("pb_orco.Image")));
            this.pb_orco.Location = new System.Drawing.Point(0, 0);
            this.pb_orco.Name = "pb_orco";
            this.pb_orco.Size = new System.Drawing.Size(290, 488);
            this.pb_orco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_orco.TabIndex = 1;
            this.pb_orco.TabStop = false;
            this.pb_orco.Click += new System.EventHandler(this.pb_orco_Click);
            this.pb_orco.MouseLeave += new System.EventHandler(this.pb_orco_MouseLeave);
            this.pb_orco.MouseHover += new System.EventHandler(this.pb_orco_MouseHover);
            // 
            // pnl_co
            // 
            this.pnl_co.Controls.Add(this.label5);
            this.pnl_co.Controls.Add(this.pb_co);
            this.pnl_co.Location = new System.Drawing.Point(1187, 3);
            this.pnl_co.Name = "pnl_co";
            this.pnl_co.Size = new System.Drawing.Size(290, 550);
            this.pnl_co.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F);
            this.label5.Location = new System.Drawing.Point(33, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "CABALLERO OSCURO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // pb_co
            // 
            this.pb_co.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_co.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_co.Image = ((System.Drawing.Image)(resources.GetObject("pb_co.Image")));
            this.pb_co.Location = new System.Drawing.Point(0, 0);
            this.pb_co.Name = "pb_co";
            this.pb_co.Size = new System.Drawing.Size(290, 488);
            this.pb_co.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_co.TabIndex = 1;
            this.pb_co.TabStop = false;
            this.pb_co.Click += new System.EventHandler(this.pb_co_Click);
            this.pb_co.MouseLeave += new System.EventHandler(this.pb_co_MouseLeave);
            this.pb_co.MouseHover += new System.EventHandler(this.pb_co_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1773, 112);
            this.panel1.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbl_titulo.Location = new System.Drawing.Point(471, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(899, 81);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Selecciona tu personaje";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_volver.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(18, 787);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(185, 49);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Seleccion_personaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.pnl_principal);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Seleccion_personaje";
            this.Size = new System.Drawing.Size(1773, 951);
            this.pnl_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cargando)).EndInit();
            this.fpnl_personajes.ResumeLayout(false);
            this.pnl_caballero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_caballero)).EndInit();
            this.pnl_elfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_elfa)).EndInit();
            this.pnl_mago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_mago)).EndInit();
            this.pnl_orco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_orco)).EndInit();
            this.pnl_co.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_co)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.FlowLayoutPanel fpnl_personajes;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Panel pnl_caballero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_caballero;
        private System.Windows.Forms.Panel pnl_elfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_elfa;
        private System.Windows.Forms.Panel pnl_mago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_mago;
        private System.Windows.Forms.Panel pnl_orco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_orco;
        private System.Windows.Forms.Panel pnl_co;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_co;
        private System.Windows.Forms.Panel pnl_fichas;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.ProgressBar pbar_cargando;
        private System.Windows.Forms.Label lbl_carga_personaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcb_cargando;
        private System.Windows.Forms.Label lbl_titulocarga;
    }
}
