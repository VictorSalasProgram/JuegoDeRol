namespace JuegoDeRol.Presentacion
{
    partial class CargarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarPartida));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_slot1 = new System.Windows.Forms.Button();
            this.btn_slot2 = new System.Windows.Forms.Button();
            this.btn_slot3 = new System.Windows.Forms.Button();
            this.btn_slot4 = new System.Windows.Forms.Button();
            this.btn_slot5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_principal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 112);
            this.panel1.TabIndex = 8;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbl_titulo.Location = new System.Drawing.Point(471, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(899, 81);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Carga tu partida";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_principal
            // 
            this.pnl_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnl_principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_principal.BackgroundImage")));
            this.pnl_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_principal.Controls.Add(this.flowLayoutPanel1);
            this.pnl_principal.Controls.Add(this.panel1);
            this.pnl_principal.Controls.Add(this.btn_seleccionar);
            this.pnl_principal.Controls.Add(this.btn_volver);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1761, 929);
            this.pnl_principal.TabIndex = 9;
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
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_volver.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_volver.Location = new System.Drawing.Point(18, 787);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(185, 49);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_slot1);
            this.flowLayoutPanel1.Controls.Add(this.btn_slot2);
            this.flowLayoutPanel1.Controls.Add(this.btn_slot3);
            this.flowLayoutPanel1.Controls.Add(this.btn_slot4);
            this.flowLayoutPanel1.Controls.Add(this.btn_slot5);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(568, 248);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 432);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btn_slot1
            // 
            this.btn_slot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_slot1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot1.Location = new System.Drawing.Point(3, 4);
            this.btn_slot1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_slot1.Name = "btn_slot1";
            this.btn_slot1.Size = new System.Drawing.Size(621, 78);
            this.btn_slot1.TabIndex = 0;
            this.btn_slot1.Text = "Partida de prueba";
            this.btn_slot1.UseVisualStyleBackColor = false;
            this.btn_slot1.Click += new System.EventHandler(this.btn_slot1_Click);
            // 
            // btn_slot2
            // 
            this.btn_slot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_slot2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot2.Location = new System.Drawing.Point(3, 90);
            this.btn_slot2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_slot2.Name = "btn_slot2";
            this.btn_slot2.Size = new System.Drawing.Size(621, 78);
            this.btn_slot2.TabIndex = 1;
            this.btn_slot2.Text = "Vacio";
            this.btn_slot2.UseVisualStyleBackColor = false;
            // 
            // btn_slot3
            // 
            this.btn_slot3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_slot3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot3.Location = new System.Drawing.Point(3, 176);
            this.btn_slot3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_slot3.Name = "btn_slot3";
            this.btn_slot3.Size = new System.Drawing.Size(621, 78);
            this.btn_slot3.TabIndex = 2;
            this.btn_slot3.Text = "Vacio";
            this.btn_slot3.UseVisualStyleBackColor = false;
            // 
            // btn_slot4
            // 
            this.btn_slot4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_slot4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot4.Location = new System.Drawing.Point(3, 262);
            this.btn_slot4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_slot4.Name = "btn_slot4";
            this.btn_slot4.Size = new System.Drawing.Size(621, 78);
            this.btn_slot4.TabIndex = 3;
            this.btn_slot4.Text = "Vacio";
            this.btn_slot4.UseVisualStyleBackColor = false;
            // 
            // btn_slot5
            // 
            this.btn_slot5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_slot5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot5.Location = new System.Drawing.Point(3, 348);
            this.btn_slot5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_slot5.Name = "btn_slot5";
            this.btn_slot5.Size = new System.Drawing.Size(621, 78);
            this.btn_slot5.TabIndex = 4;
            this.btn_slot5.Text = "Vacio";
            this.btn_slot5.UseVisualStyleBackColor = false;
            // 
            // CargarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_principal);
            this.Name = "CargarPartida";
            this.Size = new System.Drawing.Size(1761, 929);
            this.panel1.ResumeLayout(false);
            this.pnl_principal.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_slot1;
        private System.Windows.Forms.Button btn_slot2;
        private System.Windows.Forms.Button btn_slot3;
        private System.Windows.Forms.Button btn_slot4;
        private System.Windows.Forms.Button btn_slot5;
    }
}
