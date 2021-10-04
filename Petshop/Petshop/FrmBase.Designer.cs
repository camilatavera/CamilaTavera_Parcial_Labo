
namespace PetShop
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.panel_barra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_barra.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.Aquamarine;
            this.panel_barra.Controls.Add(this.panel1);
            this.panel_barra.Controls.Add(this.panel_menu);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(865, 35);
            this.panel_barra.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(665, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 10;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = global::PetShop.Properties.Resources.btn_min;
            this.btn_minimizar.Location = new System.Drawing.Point(70, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(49, 35);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.btn_cerrar.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(141, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 38);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_menu.Location = new System.Drawing.Point(97, 38);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(220, 525);
            this.panel_menu.TabIndex = 9;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(865, 566);
            this.Controls.Add(this.panel_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.panel_barra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_menu;
        public System.Windows.Forms.Panel panel_barra;
        public System.Windows.Forms.PictureBox btn_minimizar;
        public System.Windows.Forms.PictureBox btn_cerrar;
    }
}