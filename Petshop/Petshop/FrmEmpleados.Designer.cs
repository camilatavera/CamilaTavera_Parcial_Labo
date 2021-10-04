
namespace PetShop
{
    partial class FrmEmpleados
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.list_ventas = new System.Windows.Forms.ListView();
            this.col_idVenta = new System.Windows.Forms.ColumnHeader();
            this.col_fecha = new System.Windows.Forms.ColumnHeader();
            this.col_montoFinal = new System.Windows.Forms.ColumnHeader();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbox_cargo = new System.Windows.Forms.CheckBox();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_datos
            // 
            this.panel_datos.Controls.Add(this.cbox_cargo);
            this.panel_datos.Controls.Add(this.list_ventas);
            this.panel_datos.Controls.Add(this.txt_pswd);
            this.panel_datos.Controls.Add(this.txt_usuario);
            this.panel_datos.Controls.Add(this.lbl_pswd);
            this.panel_datos.Controls.Add(this.lbl_usuario);
            this.panel_datos.Location = new System.Drawing.Point(525, 46);
            this.panel_datos.Size = new System.Drawing.Size(345, 431);
            this.panel_datos.Controls.SetChildIndex(this.txt_nombre, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_apellido, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_3, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_telefono, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.panel_datos.Controls.SetChildIndex(this.box_fecha, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_usuario, 0);
            this.panel_datos.Controls.SetChildIndex(this.lbl_pswd, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_usuario, 0);
            this.panel_datos.Controls.SetChildIndex(this.txt_pswd, 0);
            this.panel_datos.Controls.SetChildIndex(this.list_ventas, 0);
            this.panel_datos.Controls.SetChildIndex(this.cbox_cargo, 0);
            // 
            // box_fecha
            // 
            this.box_fecha.Location = new System.Drawing.Point(129, 135);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(11, 136);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(129, 97);
            // 
            // lbl_3
            // 
            this.lbl_3.Location = new System.Drawing.Point(24, 97);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(129, 58);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(24, 58);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(27, 13);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 14);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_stock.Location = new System.Drawing.Point(575, 472);
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.Location = new System.Drawing.Point(32, 423);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.Location = new System.Drawing.Point(252, 423);
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel_barra
            // 
            this.panel_barra.Size = new System.Drawing.Size(895, 35);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.Color.Coral;
            this.lbl_usuario.Location = new System.Drawing.Point(27, 180);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 21);
            this.lbl_usuario.TabIndex = 23;
            this.lbl_usuario.Text = "Usuario :";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pswd.ForeColor = System.Drawing.Color.Coral;
            this.lbl_pswd.Location = new System.Drawing.Point(27, 216);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(90, 21);
            this.lbl_pswd.TabIndex = 24;
            this.lbl_pswd.Text = "Password :";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(117, 180);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(153, 20);
            this.txt_usuario.TabIndex = 25;
            // 
            // txt_pswd
            // 
            this.txt_pswd.BackColor = System.Drawing.Color.White;
            this.txt_pswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pswd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pswd.Location = new System.Drawing.Point(117, 217);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.PasswordChar = '*';
            this.txt_pswd.Size = new System.Drawing.Size(153, 20);
            this.txt_pswd.TabIndex = 26;
            // 
            // list_ventas
            // 
            this.list_ventas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.list_ventas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idVenta,
            this.col_fecha,
            this.col_montoFinal});
            this.list_ventas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ventas.HideSelection = false;
            this.list_ventas.Location = new System.Drawing.Point(13, 295);
            this.list_ventas.MultiSelect = false;
            this.list_ventas.Name = "list_ventas";
            this.list_ventas.Size = new System.Drawing.Size(295, 125);
            this.list_ventas.TabIndex = 27;
            this.list_ventas.UseCompatibleStateImageBehavior = false;
            this.list_ventas.View = System.Windows.Forms.View.Details;
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
            // dgv_empleados
            // 
            this.dgv_empleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_apellido,
            this.col_cargo,
            this.col_nVentas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_empleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_empleados.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_empleados.Location = new System.Drawing.Point(12, 60);
            this.dgv_empleados.MultiSelect = false;
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RowHeadersVisible = false;
            this.dgv_empleados.RowTemplate.Height = 25;
            this.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empleados.Size = new System.Drawing.Size(471, 357);
            this.dgv_empleados.TabIndex = 24;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 80;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            this.col_apellido.Width = 130;
            // 
            // col_cargo
            // 
            this.col_cargo.HeaderText = "Cargo";
            this.col_cargo.Name = "col_cargo";
            this.col_cargo.ReadOnly = true;
            this.col_cargo.Width = 130;
            // 
            // col_nVentas
            // 
            this.col_nVentas.HeaderText = "n ventas";
            this.col_nVentas.Name = "col_nVentas";
            this.col_nVentas.ReadOnly = true;
            // 
            // cbox_cargo
            // 
            this.cbox_cargo.AutoSize = true;
            this.cbox_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_cargo.ForeColor = System.Drawing.Color.Coral;
            this.cbox_cargo.Location = new System.Drawing.Point(27, 252);
            this.cbox_cargo.Name = "cbox_cargo";
            this.cbox_cargo.Size = new System.Drawing.Size(156, 25);
            this.cbox_cargo.TabIndex = 28;
            this.cbox_cargo.Text = "Es administrador";
            this.cbox_cargo.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 538);
            this.Controls.Add(this.dgv_empleados);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.Controls.SetChildIndex(this.dgv_empleados, 0);
            this.Controls.SetChildIndex(this.panel_barra, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_stock, 0);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_pswd;
        public System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.TextBox txt_pswd;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.ListView list_ventas;
        private System.Windows.Forms.ColumnHeader col_idVenta;
        private System.Windows.Forms.ColumnHeader col_fecha;
        private System.Windows.Forms.ColumnHeader col_montoFinal;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nVentas;
        private System.Windows.Forms.CheckBox cbox_cargo;
    }
}