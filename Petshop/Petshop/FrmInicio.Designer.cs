
namespace PetShop
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_tipoUser = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direc = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time_hora = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.panel_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.Controls.Add(this.panel_datos);
            this.panel_barra.Size = new System.Drawing.Size(800, 35);
            this.panel_barra.Controls.SetChildIndex(this.panel_datos, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ventas);
            this.panel2.Controls.Add(this.btn_empleados);
            this.panel2.Controls.Add(this.btn_vender);
            this.panel2.Controls.Add(this.btn_clientes);
            this.panel2.Controls.Add(this.btn_stock);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 470);
            this.panel2.TabIndex = 10;
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas.ForeColor = System.Drawing.Color.Coral;
            this.btn_ventas.Location = new System.Drawing.Point(0, 378);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(253, 45);
            this.btn_ventas.TabIndex = 16;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_empleados.ForeColor = System.Drawing.Color.Coral;
            this.btn_empleados.Location = new System.Drawing.Point(0, 296);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(253, 45);
            this.btn_empleados.TabIndex = 15;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_vender.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_vender.ForeColor = System.Drawing.Color.Coral;
            this.btn_vender.Location = new System.Drawing.Point(0, 57);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(250, 45);
            this.btn_vender.TabIndex = 10;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clientes.ForeColor = System.Drawing.Color.Coral;
            this.btn_clientes.Location = new System.Drawing.Point(0, 213);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(253, 45);
            this.btn_clientes.TabIndex = 12;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stock.ForeColor = System.Drawing.Color.Coral;
            this.btn_stock.Location = new System.Drawing.Point(0, 125);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(253, 45);
            this.btn_stock.TabIndex = 11;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.Coral;
            this.lbl_bienvenida.Location = new System.Drawing.Point(607, 51);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(115, 18);
            this.lbl_bienvenida.TabIndex = 11;
            this.lbl_bienvenida.Text = "Bienvenido, ";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_user.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_user.Location = new System.Drawing.Point(649, 72);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 22);
            this.txt_user.TabIndex = 12;
            // 
            // txt_tipoUser
            // 
            this.txt_tipoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_tipoUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tipoUser.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_tipoUser.ForeColor = System.Drawing.Color.Aquamarine;
            this.txt_tipoUser.Location = new System.Drawing.Point(668, 95);
            this.txt_tipoUser.Name = "txt_tipoUser";
            this.txt_tipoUser.Size = new System.Drawing.Size(100, 18);
            this.txt_tipoUser.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.ForeColor = System.Drawing.Color.Aquamarine;
            this.txt_nombre.Location = new System.Drawing.Point(587, 450);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(162, 18);
            this.txt_nombre.TabIndex = 14;
            // 
            // txt_direc
            // 
            this.txt_direc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_direc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_direc.ForeColor = System.Drawing.Color.Aquamarine;
            this.txt_direc.Location = new System.Drawing.Point(587, 479);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.Size = new System.Drawing.Size(162, 18);
            this.txt_direc.TabIndex = 15;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "petshop.foto.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop.Properties.Resources.petshop_foto;
            this.pictureBox1.Location = new System.Drawing.Point(252, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // time_hora
            // 
            this.time_hora.Enabled = true;
            this.time_hora.Tick += new System.EventHandler(this.time_hora_Tick);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Source Sans Pro", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(443, 195);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(337, 101);
            this.lbl_hora.TabIndex = 17;
            this.lbl_hora.Text = "lbl_hora";
            this.lbl_hora.Click += new System.EventHandler(this.lbl_hora_Click);
            // 
            // panel_datos
            // 
            this.panel_datos.Location = new System.Drawing.Point(581, 34);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(218, 105);
            this.panel_datos.TabIndex = 11;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_direc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_tipoUser);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.panel2);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lbl_hora, 0);
            this.Controls.SetChildIndex(this.panel_barra, 0);
            this.Controls.SetChildIndex(this.lbl_bienvenida, 0);
            this.Controls.SetChildIndex(this.txt_user, 0);
            this.Controls.SetChildIndex(this.txt_tipoUser, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_direc, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel_barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_vender;
        public System.Windows.Forms.Button btn_ventas;
        public System.Windows.Forms.Button btn_empleados;
        public System.Windows.Forms.Button btn_clientes;
        public System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_tipoUser;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer time_hora;
        private System.Windows.Forms.Panel panel_datos;
    }
}