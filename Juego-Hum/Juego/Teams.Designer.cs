namespace Juego_Hum.Juego
{
    partial class Teams
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblJugadores = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pctBoxMorado = new System.Windows.Forms.PictureBox();
            this.pctBoxGris = new System.Windows.Forms.PictureBox();
            this.pctBoxAzul = new System.Windows.Forms.PictureBox();
            this.pctBoxNaranja = new System.Windows.Forms.PictureBox();
            this.pctBoxRojo = new System.Windows.Forms.PictureBox();
            this.pctBoxVerde = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMorado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblJugadores});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1013, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblJugadores
            // 
            this.lblJugadores.ForeColor = System.Drawing.Color.White;
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(115, 25);
            this.lblJugadores.Text = "Jugador 1";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Silver;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.Menu.Location = new System.Drawing.Point(0, 623);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.Size = new System.Drawing.Size(1013, 47);
            this.Menu.TabIndex = 12;
            this.Menu.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::Juego_Hum.Properties.Resources._1402860914_exit;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSalir.Size = new System.Drawing.Size(64, 44);
            this.btnSalir.Tag = "";
            this.btnSalir.Text = "toolStripButton5";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pctBoxMorado
            // 
            this.pctBoxMorado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxMorado.Image = global::Juego_Hum.Properties.Resources.PersonajeMorado;
            this.pctBoxMorado.Location = new System.Drawing.Point(756, 306);
            this.pctBoxMorado.Name = "pctBoxMorado";
            this.pctBoxMorado.Size = new System.Drawing.Size(230, 222);
            this.pctBoxMorado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxMorado.TabIndex = 11;
            this.pctBoxMorado.TabStop = false;
            this.pctBoxMorado.Click += new System.EventHandler(this.pctBoxMorado_Click);
            // 
            // pctBoxGris
            // 
            this.pctBoxGris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxGris.Image = global::Juego_Hum.Properties.Resources.PersonajeGris;
            this.pctBoxGris.Location = new System.Drawing.Point(520, 306);
            this.pctBoxGris.Name = "pctBoxGris";
            this.pctBoxGris.Size = new System.Drawing.Size(230, 222);
            this.pctBoxGris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxGris.TabIndex = 10;
            this.pctBoxGris.TabStop = false;
            this.pctBoxGris.Click += new System.EventHandler(this.pctBoxGris_Click);
            // 
            // pctBoxAzul
            // 
            this.pctBoxAzul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxAzul.Image = global::Juego_Hum.Properties.Resources.PersonajeAzul;
            this.pctBoxAzul.Location = new System.Drawing.Point(284, 306);
            this.pctBoxAzul.Name = "pctBoxAzul";
            this.pctBoxAzul.Size = new System.Drawing.Size(230, 222);
            this.pctBoxAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAzul.TabIndex = 9;
            this.pctBoxAzul.TabStop = false;
            this.pctBoxAzul.Click += new System.EventHandler(this.pctBoxAzul_Click);
            // 
            // pctBoxNaranja
            // 
            this.pctBoxNaranja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxNaranja.Image = global::Juego_Hum.Properties.Resources.PersonajeNaranja;
            this.pctBoxNaranja.Location = new System.Drawing.Point(756, 78);
            this.pctBoxNaranja.Name = "pctBoxNaranja";
            this.pctBoxNaranja.Size = new System.Drawing.Size(230, 222);
            this.pctBoxNaranja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxNaranja.TabIndex = 8;
            this.pctBoxNaranja.TabStop = false;
            this.pctBoxNaranja.Click += new System.EventHandler(this.pctBoxNaranja_Click);
            // 
            // pctBoxRojo
            // 
            this.pctBoxRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxRojo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxRojo.Image = global::Juego_Hum.Properties.Resources.PersonajeRojo;
            this.pctBoxRojo.Location = new System.Drawing.Point(520, 78);
            this.pctBoxRojo.Name = "pctBoxRojo";
            this.pctBoxRojo.Size = new System.Drawing.Size(230, 222);
            this.pctBoxRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxRojo.TabIndex = 7;
            this.pctBoxRojo.TabStop = false;
            this.pctBoxRojo.Click += new System.EventHandler(this.pctBoxRojo_Click);
            // 
            // pctBoxVerde
            // 
            this.pctBoxVerde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxVerde.Image = global::Juego_Hum.Properties.Resources.PersonajeVerde;
            this.pctBoxVerde.Location = new System.Drawing.Point(284, 78);
            this.pctBoxVerde.Name = "pctBoxVerde";
            this.pctBoxVerde.Size = new System.Drawing.Size(230, 222);
            this.pctBoxVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxVerde.TabIndex = 6;
            this.pctBoxVerde.TabStop = false;
            this.pctBoxVerde.Click += new System.EventHandler(this.pctBoxVerde_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 670);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pctBoxMorado);
            this.Controls.Add(this.pctBoxGris);
            this.Controls.Add(this.pctBoxAzul);
            this.Controls.Add(this.pctBoxNaranja);
            this.Controls.Add(this.pctBoxRojo);
            this.Controls.Add(this.pctBoxVerde);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formación de Equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teams_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMorado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxVerde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblJugadores;
        private System.Windows.Forms.PictureBox pctBoxMorado;
        private System.Windows.Forms.PictureBox pctBoxGris;
        private System.Windows.Forms.PictureBox pctBoxAzul;
        private System.Windows.Forms.PictureBox pctBoxNaranja;
        private System.Windows.Forms.PictureBox pctBoxRojo;
        private System.Windows.Forms.PictureBox pctBoxVerde;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}