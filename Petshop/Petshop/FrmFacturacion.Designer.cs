
namespace PetShop
{
    partial class FrmFacturacion
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
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_factura
            // 
            this.txt_factura.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_factura.Location = new System.Drawing.Point(55, 61);
            this.txt_factura.Multiline = true;
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(555, 304);
            this.txt_factura.TabIndex = 10;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.Coral;
            this.btn_guardar.Location = new System.Drawing.Point(141, 386);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(396, 45);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar en txt";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 463);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_factura);
            this.Name = "FrmFacturacion";
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.Controls.SetChildIndex(this.txt_factura, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_factura;
        public System.Windows.Forms.Button btn_guardar;
    }
}