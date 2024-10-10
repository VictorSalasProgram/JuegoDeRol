namespace JuegoDeRol.Presentacion
{
    partial class Ctl_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctl_principal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_nuevap = new System.Windows.Forms.Button();
            this.btn_cargarp = new System.Windows.Forms.Button();
            this.btn_cuenta = new System.Windows.Forms.Button();
            this.btn_tienda = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_nuevap);
            this.flowLayoutPanel1.Controls.Add(this.btn_cargarp);
            this.flowLayoutPanel1.Controls.Add(this.btn_cuenta);
            this.flowLayoutPanel1.Controls.Add(this.btn_tienda);
            this.flowLayoutPanel1.Controls.Add(this.btn_salir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(580, 269);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 432);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_nuevap
            // 
            this.btn_nuevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_nuevap.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevap.Location = new System.Drawing.Point(3, 4);
            this.btn_nuevap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nuevap.Name = "btn_nuevap";
            this.btn_nuevap.Size = new System.Drawing.Size(621, 78);
            this.btn_nuevap.TabIndex = 0;
            this.btn_nuevap.Text = "Nueva Partida";
            this.btn_nuevap.UseVisualStyleBackColor = false;
            this.btn_nuevap.Click += new System.EventHandler(this.btn_nuevap_Click);
            // 
            // btn_cargarp
            // 
            this.btn_cargarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_cargarp.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarp.Location = new System.Drawing.Point(3, 90);
            this.btn_cargarp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cargarp.Name = "btn_cargarp";
            this.btn_cargarp.Size = new System.Drawing.Size(621, 78);
            this.btn_cargarp.TabIndex = 1;
            this.btn_cargarp.Text = "Cargar Partida";
            this.btn_cargarp.UseVisualStyleBackColor = false;
            // 
            // btn_cuenta
            // 
            this.btn_cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_cuenta.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuenta.Location = new System.Drawing.Point(3, 176);
            this.btn_cuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cuenta.Name = "btn_cuenta";
            this.btn_cuenta.Size = new System.Drawing.Size(621, 78);
            this.btn_cuenta.TabIndex = 2;
            this.btn_cuenta.Text = "Cuenta";
            this.btn_cuenta.UseVisualStyleBackColor = false;
            this.btn_cuenta.Click += new System.EventHandler(this.btn_cuenta_Click);
            // 
            // btn_tienda
            // 
            this.btn_tienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_tienda.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tienda.Location = new System.Drawing.Point(3, 262);
            this.btn_tienda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tienda.Name = "btn_tienda";
            this.btn_tienda.Size = new System.Drawing.Size(621, 78);
            this.btn_tienda.TabIndex = 3;
            this.btn_tienda.Text = "Tienda";
            this.btn_tienda.UseVisualStyleBackColor = false;
            this.btn_tienda.Click += new System.EventHandler(this.btn_tienda_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_salir.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(3, 348);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(621, 78);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbl_titulo.Location = new System.Drawing.Point(445, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(899, 81);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Bienvenido guerrero";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 112);
            this.panel1.TabIndex = 3;
            // 
            // Ctl_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Ctl_principal";
            this.Size = new System.Drawing.Size(1761, 929);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_nuevap;
        private System.Windows.Forms.Button btn_cargarp;
        private System.Windows.Forms.Button btn_cuenta;
        private System.Windows.Forms.Button btn_tienda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
    }
}
