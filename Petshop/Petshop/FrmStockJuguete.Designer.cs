
namespace PetShop
{
    partial class FrmStockJuguete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // panel_barra
            // 
            this.panel_barra.Size = new System.Drawing.Size(927, 35);
            // 
            // dgv_productos
            // 
            this.dgv_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_producto,
            this.col_cantidad,
            this.col_precio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_productos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_productos.Location = new System.Drawing.Point(22, 54);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowTemplate.Height = 25;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(475, 378);
            this.dgv_productos.TabIndex = 23;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 80;
            // 
            // col_producto
            // 
            this.col_producto.HeaderText = "Producto";
            this.col_producto.Name = "col_producto";
            this.col_producto.ReadOnly = true;
            this.col_producto.Width = 170;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // col_precio
            // 
            this.col_precio.HeaderText = "Precio";
            this.col_precio.Name = "col_precio";
            this.col_precio.ReadOnly = true;
            this.col_precio.Width = 120;
            // 
            // FrmStockJuguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 535);
            this.Controls.Add(this.dgv_productos);
            this.Name = "FrmStockJuguete";
            this.Text = "FrmStockJuguete";
            this.Load += new System.EventHandler(this.FrmStockJuguete_Load);
            this.Controls.SetChildIndex(this.panel_barra, 0);
            this.Controls.SetChildIndex(this.panel_datos, 0);
            this.Controls.SetChildIndex(this.btn_stock, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.dgv_productos, 0);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio;
    }
}