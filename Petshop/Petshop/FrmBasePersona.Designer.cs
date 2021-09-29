
namespace PetShop
{
    partial class FrmBasePersona
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
            this.panel_datos = new System.Windows.Forms.Panel();
            this.btn_stock = new System.Windows.Forms.Button();
            this.box_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.box_fecha);
            this.panel_datos.Controls.Add(this.lbl_fecha);
            this.panel_datos.Controls.Add(this.txt_telefono);
            this.panel_datos.Controls.Add(this.lbl_3);
            this.panel_datos.Controls.Add(this.txt_apellido);
            this.panel_datos.Controls.Add(this.lbl_apellido);
            this.panel_datos.Controls.Add(this.lbl_nombre);
            this.panel_datos.Controls.Add(this.txt_nombre);
            this.panel_datos.Location = new System.Drawing.Point(480, 41);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(324, 420);
            this.panel_datos.TabIndex = 18;
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stock.Location = new System.Drawing.Point(540, 423);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(206, 54);
            this.btn_stock.TabIndex = 20;
            this.btn_stock.Text = "Guardar ";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // box_fecha
            // 
            this.box_fecha.Location = new System.Drawing.Point(129, 204);
            this.box_fecha.Name = "box_fecha";
            this.box_fecha.Size = new System.Drawing.Size(192, 23);
            this.box_fecha.TabIndex = 9;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fecha.ForeColor = System.Drawing.Color.Coral;
            this.lbl_fecha.Location = new System.Drawing.Point(3, 206);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(122, 21);
            this.lbl_fecha.TabIndex = 8;
            this.lbl_fecha.Text = "Nacimiento :";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.Location = new System.Drawing.Point(129, 140);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(153, 20);
            this.txt_telefono.TabIndex = 7;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_3.ForeColor = System.Drawing.Color.Coral;
            this.lbl_3.Location = new System.Drawing.Point(24, 140);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(84, 21);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "Telefono :";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_apellido.Location = new System.Drawing.Point(129, 81);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(153, 20);
            this.txt_apellido.TabIndex = 5;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.ForeColor = System.Drawing.Color.Coral;
            this.lbl_apellido.Location = new System.Drawing.Point(26, 80);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(82, 21);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido :";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nombre.Location = new System.Drawing.Point(27, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 21);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(129, 33);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(153, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_borrar.Location = new System.Drawing.Point(12, 423);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(197, 54);
            this.btn_borrar.TabIndex = 21;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.Color.Coral;
            this.btn_agregar.Location = new System.Drawing.Point(226, 423);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(195, 54);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar Nuevo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FrmBasePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 508);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.panel_datos);
            this.Name = "FrmBasePersona";
            this.Text = "FrmBasePersona";
            this.Controls.SetChildIndex(this.panel_datos, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_stock, 0);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_datos;
        public System.Windows.Forms.DateTimePicker box_fecha;
        public System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox txt_telefono;
        public System.Windows.Forms.Label lbl_3;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.Button btn_stock;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.Button btn_agregar;
    }
}