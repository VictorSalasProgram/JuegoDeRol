namespace JuegoDeRol.Presentacion
{
    partial class Cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnl_principal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_titulo.Location = new System.Drawing.Point(471, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(899, 81);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Configuracion de Cuenta";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_seleccionar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_seleccionar.Location = new System.Drawing.Point(945, 785);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(185, 49);
            this.btn_seleccionar.TabIndex = 7;
            this.btn_seleccionar.Text = "Guardar";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // pnl_principal
            // 
            this.pnl_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnl_principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_principal.BackgroundImage")));
            this.pnl_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_principal.Controls.Add(this.panel2);
            this.pnl_principal.Controls.Add(this.btn_seleccionar);
            this.pnl_principal.Controls.Add(this.panel1);
            this.pnl_principal.Controls.Add(this.btn_volver);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1773, 951);
            this.pnl_principal.TabIndex = 2;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_volver.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_volver.Location = new System.Drawing.Point(754, 785);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(185, 49);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_pais);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.txt_contraseña);
            this.panel2.Controls.Add(this.txt_nickname);
            this.panel2.Controls.Add(this.txt_nombre_usuario);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(507, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 625);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(146, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nickname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(146, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(193, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 66);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(146, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 66);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pais:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(324, 68);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(405, 34);
            this.txt_nombre_usuario.TabIndex = 6;
            this.txt_nombre_usuario.Text = "Admin";
            this.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nickname
            // 
            this.txt_nickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txt_nickname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nickname.Location = new System.Drawing.Point(324, 143);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(405, 34);
            this.txt_nickname.TabIndex = 7;
            this.txt_nickname.Text = "Administrador";
            this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txt_contraseña.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contraseña.Location = new System.Drawing.Point(324, 220);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(405, 34);
            this.txt_contraseña.TabIndex = 8;
            this.txt_contraseña.Text = "admin123";
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txt_correo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.Location = new System.Drawing.Point(324, 306);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(405, 34);
            this.txt_correo.TabIndex = 9;
            this.txt_correo.Text = "correoadmnistrador@correo.com";
            this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_pais
            // 
            this.cmb_pais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmb_pais.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pais.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Items.AddRange(new object[] {
            "México",
            "Guatemala",
            "Belice",
            "Honduras",
            "El Salvador",
            "Nicaragua",
            "Costa Rica",
            "Panamá",
            "Colombia",
            "Venezuela",
            "Ecuador",
            "Perú",
            "Brasil",
            "Paraguay",
            "Chile",
            "Argentina",
            "Uruguay"});
            this.cmb_pais.Location = new System.Drawing.Point(324, 409);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(405, 35);
            this.cmb_pais.TabIndex = 10;
            this.cmb_pais.SelectedIndexChanged += new System.EventHandler(this.cmb_pais_SelectedIndexChanged);
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.pnl_principal);
            this.Name = "Cuenta";
            this.Size = new System.Drawing.Size(1773, 951);
            this.panel1.ResumeLayout(false);
            this.pnl_principal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.ComboBox cmb_pais;
    }
}
