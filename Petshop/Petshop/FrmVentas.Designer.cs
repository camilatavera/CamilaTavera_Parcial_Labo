
namespace PetShop
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.col_idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_verFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idVenta,
            this.col_fecha,
            this.col_monto,
            this.col_vendedor,
            this.col_idComprador});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ventas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ventas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_ventas.Location = new System.Drawing.Point(38, 64);
            this.dgv_ventas.MultiSelect = false;
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.RowHeadersVisible = false;
            this.dgv_ventas.RowTemplate.Height = 25;
            this.dgv_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventas.Size = new System.Drawing.Size(582, 355);
            this.dgv_ventas.TabIndex = 24;
            this.dgv_ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellClick);
            // 
            // col_idVenta
            // 
            this.col_idVenta.HeaderText = "Id Venta";
            this.col_idVenta.Name = "col_idVenta";
            this.col_idVenta.ReadOnly = true;
            this.col_idVenta.Width = 80;
            // 
            // col_fecha
            // 
            this.col_fecha.HeaderText = "Fecha";
            this.col_fecha.Name = "col_fecha";
            this.col_fecha.ReadOnly = true;
            this.col_fecha.Width = 150;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // col_vendedor
            // 
            this.col_vendedor.HeaderText = "Vendedor";
            this.col_vendedor.Name = "col_vendedor";
            this.col_vendedor.ReadOnly = true;
            this.col_vendedor.Width = 150;
            // 
            // col_idComprador
            // 
            this.col_idComprador.HeaderText = "Id comprador";
            this.col_idComprador.Name = "col_idComprador";
            this.col_idComprador.ReadOnly = true;
            // 
            // btn_verFactura
            // 
            this.btn_verFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_verFactura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_verFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_verFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verFactura.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_verFactura.ForeColor = System.Drawing.Color.Coral;
            this.btn_verFactura.Location = new System.Drawing.Point(88, 467);
            this.btn_verFactura.Name = "btn_verFactura";
            this.btn_verFactura.Size = new System.Drawing.Size(454, 45);
            this.btn_verFactura.TabIndex = 25;
            this.btn_verFactura.Text = "Ver facturacion";
            this.btn_verFactura.UseVisualStyleBackColor = true;
            this.btn_verFactura.Click += new System.EventHandler(this.btn_verFactura_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 544);
            this.Controls.Add(this.btn_verFactura);
            this.Controls.Add(this.dgv_ventas);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Controls.SetChildIndex(this.dgv_ventas, 0);
            this.Controls.SetChildIndex(this.btn_verFactura, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idComprador;
        public System.Windows.Forms.Button btn_verFactura;
    }
}