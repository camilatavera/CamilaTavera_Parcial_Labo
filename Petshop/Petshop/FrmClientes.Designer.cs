
namespace PetShop
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ncompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_plata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_plataDisponible = new System.Windows.Forms.NumericUpDown();
            this.list_pedidos = new System.Windows.Forms.ListView();
            this.col_idVenta = new System.Windows.Forms.ColumnHeader();
            this.col_fecha = new System.Windows.Forms.ColumnHeader();
            this.col_montoFinal = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_plataDisponible)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.label1);
            this.panel_datos.Controls.Add(this.list_pedidos);
            this.panel_datos.Controls.Add(this.num_plataDisponible);
            this.panel_datos.Location = new System.Drawing.Point(575, 66);
            this.panel_datos.Size = new System.Drawing.Size(367, 416);
            this.panel_datos.Controls.SetChildIndex(this.txt_nombre, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_apellido, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_3, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_telefono, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.panel_datos.Controls.SetChildIndex(this.box_fecha, 0);
            this.panel_datos.Controls.SetChildIndex(this.num_plataDisponible, 0);
            this.panel_datos.Controls.SetChildIndex(this.list_pedidos, 0);
            this.panel_datos.Controls.SetChildIndex(this.label1, 0);
            // 
            // box_fecha
            // 
            this.box_fecha.Location = new System.Drawing.Point(129, 170);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(14, 170);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(129, 117);
            // 
            // lbl_3
            // 
            this.lbl_3.Location = new System.Drawing.Point(24, 116);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(129, 66);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(26, 65);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(24, 20);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 21);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_stock.Location = new System.Drawing.Point(651, 493);
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.Location = new System.Drawing.Point(12, 491);
            this.btn_borrar.Size = new System.Drawing.Size(178, 55);
            this.btn_borrar.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.Location = new System.Drawing.Point(86, 491);
            this.btn_agregar.Size = new System.Drawing.Size(378, 53);
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel_barra
            // 
            this.panel_barra.Size = new System.Drawing.Size(954, 35);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_nombre,
            this.col_apellido,
            this.col_ncompras,
            this.col_plata});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_clientes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 66);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowTemplate.Height = 25;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(542, 398);
            this.dgv_clientes.TabIndex = 23;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 80;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            this.col_nombre.Width = 140;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            this.col_apellido.Width = 130;
            // 
            // col_ncompras
            // 
            this.col_ncompras.HeaderText = "n de compras";
            this.col_ncompras.Name = "col_ncompras";
            this.col_ncompras.ReadOnly = true;
            this.col_ncompras.Width = 90;
            // 
            // col_plata
            // 
            this.col_plata.HeaderText = "Plata disponible";
            this.col_plata.Name = "col_plata";
            this.col_plata.ReadOnly = true;
            // 
            // num_plataDisponible
            // 
            this.num_plataDisponible.Location = new System.Drawing.Point(170, 219);
            this.num_plataDisponible.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_plataDisponible.Name = "num_plataDisponible";
            this.num_plataDisponible.Size = new System.Drawing.Size(120, 23);
            this.num_plataDisponible.TabIndex = 24;
            // 
            // list_pedidos
            // 
            this.list_pedidos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.list_pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idVenta,
            this.col_fecha,
            this.col_montoFinal});
            this.list_pedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_pedidos.HideSelection = false;
            this.list_pedidos.Location = new System.Drawing.Point(26, 270);
            this.list_pedidos.MultiSelect = false;
            this.list_pedidos.Name = "list_pedidos";
            this.list_pedidos.Size = new System.Drawing.Size(321, 138);
            this.list_pedidos.TabIndex = 25;
            this.list_pedidos.UseCompatibleStateImageBehavior = false;
            this.list_pedidos.View = System.Windows.Forms.View.Details;
            // 
            // col_idVenta
            // 
            this.col_idVenta.Text = "Id Venta";
            this.col_idVenta.Width = 70;
            // 
            // col_fecha
            // 
            this.col_fecha.Text = "Fecha";
            this.col_fecha.Width = 140;
            // 
            // col_montoFinal
            // 
            this.col_montoFinal.Text = "Monto Final";
            this.col_montoFinal.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(14, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Plata disponible:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 576);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.Controls.SetChildIndex(this.panel_barra, 0);
            this.Controls.SetChildIndex(this.btn_stock, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.dgv_clientes, 0);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_plataDisponible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ncompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_plata;
        private System.Windows.Forms.NumericUpDown num_plataDisponible;
        private System.Windows.Forms.ListView list_pedidos;
        private System.Windows.Forms.ColumnHeader col_idVenta;
        private System.Windows.Forms.ColumnHeader col_fecha;
        private System.Windows.Forms.ColumnHeader col_montoFinal;
        public System.Windows.Forms.Label label1;
    }
}