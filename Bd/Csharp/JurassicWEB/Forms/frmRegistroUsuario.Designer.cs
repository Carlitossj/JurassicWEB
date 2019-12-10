namespace Forms
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(421, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 34);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(603, 44);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(185, 20);
            this.txtPass.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(186, 44);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(185, 20);
            this.txtNombreUsuario.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(439, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.BackColor = System.Drawing.Color.Black;
            this.lblNombreUser.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(12, 33);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(120, 41);
            this.lblNombreUser.TabIndex = 10;
            this.lblNombreUser.Text = "Nombre de Usuario";
            this.lblNombreUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Black;
            this.lblNombre.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 31);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.Black;
            this.lblApellido.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(439, 114);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(120, 31);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(603, 125);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(234, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 31);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(397, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreUser);
            this.Name = "frmRegistroUsuario";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}