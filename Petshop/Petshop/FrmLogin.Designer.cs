
namespace PetShop
{
    partial class FrmLogin
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.Size = new System.Drawing.Size(395, 35);
            this.panel_barra.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(73, 98);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(191, 23);
            this.txt_usuario.TabIndex = 10;
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(73, 183);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.PasswordChar = '*';
            this.txt_pswd.Size = new System.Drawing.Size(191, 23);
            this.txt_pswd.TabIndex = 11;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nombre.Location = new System.Drawing.Point(73, 62);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(66, 21);
            this.lbl_nombre.TabIndex = 12;
            this.lbl_nombre.Text = "Usuario";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pswd.ForeColor = System.Drawing.Color.Coral;
            this.lbl_pswd.Location = new System.Drawing.Point(73, 149);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(103, 21);
            this.lbl_pswd.TabIndex = 13;
            this.lbl_pswd.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.ForeColor = System.Drawing.Color.Coral;
            this.btn_ingresar.Location = new System.Drawing.Point(87, 237);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(157, 45);
            this.btn_ingresar.TabIndex = 14;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.ForeColor = System.Drawing.Color.Aqua;
            this.btn_admin.Location = new System.Drawing.Point(35, 333);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(154, 45);
            this.btn_admin.TabIndex = 15;
            this.btn_admin.Text = "admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_empleado.FlatAppearance.BorderSize = 0;
            this.btn_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleado.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_empleado.ForeColor = System.Drawing.Color.Aqua;
            this.btn_empleado.Location = new System.Drawing.Point(202, 333);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(143, 45);
            this.btn_empleado.TabIndex = 16;
            this.btn_empleado.Text = "empleado";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(395, 390);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.txt_usuario);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Controls.SetChildIndex(this.panel_barra, 0);
            this.Controls.SetChildIndex(this.txt_usuario, 0);
            this.Controls.SetChildIndex(this.txt_pswd, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.lbl_pswd, 0);
            this.Controls.SetChildIndex(this.btn_ingresar, 0);
            this.Controls.SetChildIndex(this.btn_admin, 0);
            this.Controls.SetChildIndex(this.btn_empleado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_pswd;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_pswd;
        public System.Windows.Forms.Button btn_ingresar;
        public System.Windows.Forms.Button btn_admin;
        public System.Windows.Forms.Button btn_empleado;
    }
}