namespace Forms
{
    partial class JurassicWeb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JurassicWeb));
            this.pctPiso = new System.Windows.Forms.PictureBox();
            this.pctTrex = new System.Windows.Forms.PictureBox();
            this.pctObstaculo1 = new System.Windows.Forms.PictureBox();
            this.pctObstaculo2 = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.TimerJuego = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObstaculo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObstaculo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPiso
            // 
            this.pctPiso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctPiso.Location = new System.Drawing.Point(-5, 397);
            this.pctPiso.Name = "pctPiso";
            this.pctPiso.Size = new System.Drawing.Size(806, 50);
            this.pctPiso.TabIndex = 0;
            this.pctPiso.TabStop = false;
            // 
            // pctTrex
            // 
            this.pctTrex.BackColor = System.Drawing.Color.White;
            this.pctTrex.Image = ((System.Drawing.Image)(resources.GetObject("pctTrex.Image")));
            this.pctTrex.Location = new System.Drawing.Point(62, 336);
            this.pctTrex.Name = "pctTrex";
            this.pctTrex.Size = new System.Drawing.Size(55, 58);
            this.pctTrex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctTrex.TabIndex = 1;
            this.pctTrex.TabStop = false;
            // 
            // pctObstaculo1
            // 
            this.pctObstaculo1.Image = ((System.Drawing.Image)(resources.GetObject("pctObstaculo1.Image")));
            this.pctObstaculo1.Location = new System.Drawing.Point(400, 329);
            this.pctObstaculo1.Name = "pctObstaculo1";
            this.pctObstaculo1.Size = new System.Drawing.Size(33, 67);
            this.pctObstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctObstaculo1.TabIndex = 2;
            this.pctObstaculo1.TabStop = false;
            this.pctObstaculo1.Tag = "Obstaculo1";
            // 
            // pctObstaculo2
            // 
            this.pctObstaculo2.Image = ((System.Drawing.Image)(resources.GetObject("pctObstaculo2.Image")));
            this.pctObstaculo2.Location = new System.Drawing.Point(659, 341);
            this.pctObstaculo2.Name = "pctObstaculo2";
            this.pctObstaculo2.Size = new System.Drawing.Size(53, 55);
            this.pctObstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctObstaculo2.TabIndex = 3;
            this.pctObstaculo2.TabStop = false;
            this.pctObstaculo2.Tag = "Obstaculo2";
            // 
            // lblPuntos
            // 
            this.lblPuntos.Location = new System.Drawing.Point(688, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(100, 23);
            this.lblPuntos.TabIndex = 4;
            // 
            // TimerJuego
            // 
            this.TimerJuego.Enabled = true;
            this.TimerJuego.Interval = 20;
            this.TimerJuego.Tick += new System.EventHandler(this.EventoJuego);
            // 
            // JurassicWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.pctObstaculo2);
            this.Controls.Add(this.pctObstaculo1);
            this.Controls.Add(this.pctTrex);
            this.Controls.Add(this.pctPiso);
            this.Name = "JurassicWeb";
            this.Text = "JurassicWeb";
            ((System.ComponentModel.ISupportInitialize)(this.pctPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObstaculo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObstaculo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPiso;
        private System.Windows.Forms.PictureBox pctTrex;
        private System.Windows.Forms.PictureBox pctObstaculo1;
        private System.Windows.Forms.PictureBox pctObstaculo2;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer TimerJuego;
    }
}