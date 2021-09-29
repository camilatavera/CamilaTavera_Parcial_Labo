
namespace PetShop
{
    partial class FrmStockBase
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmb_extra = new System.Windows.Forms.ComboBox();
            this.cmb_mascota = new System.Windows.Forms.ComboBox();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.num_precio = new System.Windows.Forms.NumericUpDown();
            this.lbl_cmb = new System.Windows.Forms.Label();
            this.lbl_mascota = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.checkBox1);
            this.panel_datos.Controls.Add(this.cmb_extra);
            this.panel_datos.Controls.Add(this.cmb_mascota);
            this.panel_datos.Controls.Add(this.num_cantidad);
            this.panel_datos.Controls.Add(this.num_precio);
            this.panel_datos.Controls.Add(this.lbl_cmb);
            this.panel_datos.Controls.Add(this.lbl_mascota);
            this.panel_datos.Controls.Add(this.lbl_cantidad);
            this.panel_datos.Controls.Add(this.lbl_precio);
            this.panel_datos.Controls.Add(this.lbl_nombre);
            this.panel_datos.Controls.Add(this.txt_producto);
            this.panel_datos.Location = new System.Drawing.Point(548, 54);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(324, 420);
            this.panel_datos.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Coral;
            this.checkBox1.Location = new System.Drawing.Point(34, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 25);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "chBox_extra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmb_extra
            // 
            this.cmb_extra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cmb_extra.FormattingEnabled = true;
            this.cmb_extra.Location = new System.Drawing.Point(134, 255);
            this.cmb_extra.Name = "cmb_extra";
            this.cmb_extra.Size = new System.Drawing.Size(162, 23);
            this.cmb_extra.TabIndex = 18;
            this.cmb_extra.Text = "Seleccione";
            // 
            // cmb_mascota
            // 
            this.cmb_mascota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cmb_mascota.FormattingEnabled = true;
            this.cmb_mascota.Location = new System.Drawing.Point(134, 196);
            this.cmb_mascota.Name = "cmb_mascota";
            this.cmb_mascota.Size = new System.Drawing.Size(162, 23);
            this.cmb_mascota.TabIndex = 17;
            this.cmb_mascota.Text = "Seleccione mascota";
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(134, 145);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(115, 23);
            this.num_cantidad.TabIndex = 16;
            // 
            // num_precio
            // 
            this.num_precio.Location = new System.Drawing.Point(134, 93);
            this.num_precio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_precio.Name = "num_precio";
            this.num_precio.Size = new System.Drawing.Size(115, 23);
            this.num_precio.TabIndex = 15;
            // 
            // lbl_cmb
            // 
            this.lbl_cmb.AutoSize = true;
            this.lbl_cmb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cmb.ForeColor = System.Drawing.Color.Coral;
            this.lbl_cmb.Location = new System.Drawing.Point(34, 253);
            this.lbl_cmb.Name = "lbl_cmb";
            this.lbl_cmb.Size = new System.Drawing.Size(61, 21);
            this.lbl_cmb.TabIndex = 11;
            this.lbl_cmb.Text = "Saldo :";
            // 
            // lbl_mascota
            // 
            this.lbl_mascota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mascota.ForeColor = System.Drawing.Color.Coral;
            this.lbl_mascota.Location = new System.Drawing.Point(22, 196);
            this.lbl_mascota.Name = "lbl_mascota";
            this.lbl_mascota.Size = new System.Drawing.Size(122, 21);
            this.lbl_mascota.TabIndex = 8;
            this.lbl_mascota.Text = "Mascota: ";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Coral;
            this.lbl_cantidad.Location = new System.Drawing.Point(30, 145);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(99, 21);
            this.lbl_cantidad.TabIndex = 6;
            this.lbl_cantidad.Text = "Cantidad : ";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.ForeColor = System.Drawing.Color.Coral;
            this.lbl_precio.Location = new System.Drawing.Point(30, 93);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(65, 21);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio :";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nombre.Location = new System.Drawing.Point(27, 36);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 21);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.Color.White;
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_producto.Location = new System.Drawing.Point(129, 36);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(153, 20);
            this.txt_producto.TabIndex = 0;
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stock.Location = new System.Drawing.Point(611, 450);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(219, 54);
            this.btn_stock.TabIndex = 19;
            this.btn_stock.Text = "Guardar ";
            this.btn_stock.UseVisualStyleBackColor = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_borrar.Location = new System.Drawing.Point(45, 450);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(197, 54);
            this.btn_borrar.TabIndex = 20;
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
            this.btn_agregar.Location = new System.Drawing.Point(267, 450);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(195, 54);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "Agregar Nuevo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FrmStockBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 552);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.panel_datos);
            this.Name = "FrmStockBase";
            this.Text = "FrmStockBase";
            this.Controls.SetChildIndex(this.panel_datos, 0);
            this.Controls.SetChildIndex(this.btn_stock, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_datos;
        public System.Windows.Forms.Label lbl_cmb;
        public System.Windows.Forms.Label lbl_mascota;
        public System.Windows.Forms.Label lbl_cantidad;
        public System.Windows.Forms.Label lbl_precio;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.TextBox txt_producto;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox cmb_extra;
        public System.Windows.Forms.ComboBox cmb_mascota;
        public System.Windows.Forms.NumericUpDown num_cantidad;
        public System.Windows.Forms.NumericUpDown num_precio;
        public System.Windows.Forms.Button btn_stock;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.Button btn_agregar;
    }
}