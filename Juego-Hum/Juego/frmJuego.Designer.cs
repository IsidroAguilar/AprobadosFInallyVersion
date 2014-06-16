namespace Juego_Hum.Juego
{
    partial class frmJuego
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
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnR4 = new System.Windows.Forms.Button();
            this.btnR3 = new System.Windows.Forms.Button();
            this.btnR2 = new System.Windows.Forms.Button();
            this.btnR1 = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Silver;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.Menu.Location = new System.Drawing.Point(0, 724);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.Size = new System.Drawing.Size(800, 47);
            this.Menu.TabIndex = 13;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnR4);
            this.groupBox1.Controls.Add(this.btnR3);
            this.groupBox1.Controls.Add(this.btnR2);
            this.groupBox1.Controls.Add(this.btnR1);
            this.groupBox1.Location = new System.Drawing.Point(0, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 348);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnR4
            // 
            this.btnR4.BackColor = System.Drawing.Color.Black;
            this.btnR4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnR4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR4.ForeColor = System.Drawing.Color.White;
            this.btnR4.Location = new System.Drawing.Point(3, 263);
            this.btnR4.Name = "btnR4";
            this.btnR4.Size = new System.Drawing.Size(794, 85);
            this.btnR4.TabIndex = 3;
            this.btnR4.Text = "Respuesta4";
            this.btnR4.UseVisualStyleBackColor = false;
            this.btnR4.Click += new System.EventHandler(this.btnR4_Click);
            // 
            // btnR3
            // 
            this.btnR3.BackColor = System.Drawing.Color.Black;
            this.btnR3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnR3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR3.ForeColor = System.Drawing.Color.White;
            this.btnR3.Location = new System.Drawing.Point(3, 182);
            this.btnR3.Name = "btnR3";
            this.btnR3.Size = new System.Drawing.Size(794, 81);
            this.btnR3.TabIndex = 2;
            this.btnR3.Text = "Respuesta3";
            this.btnR3.UseVisualStyleBackColor = false;
            this.btnR3.Click += new System.EventHandler(this.btnR3_Click);
            // 
            // btnR2
            // 
            this.btnR2.BackColor = System.Drawing.Color.Black;
            this.btnR2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnR2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR2.ForeColor = System.Drawing.Color.White;
            this.btnR2.Location = new System.Drawing.Point(3, 95);
            this.btnR2.Name = "btnR2";
            this.btnR2.Size = new System.Drawing.Size(794, 87);
            this.btnR2.TabIndex = 1;
            this.btnR2.Text = "Respuesta2";
            this.btnR2.UseVisualStyleBackColor = false;
            this.btnR2.Click += new System.EventHandler(this.btnR2_Click);
            // 
            // btnR1
            // 
            this.btnR1.BackColor = System.Drawing.Color.Black;
            this.btnR1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnR1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR1.ForeColor = System.Drawing.Color.White;
            this.btnR1.Location = new System.Drawing.Point(3, 16);
            this.btnR1.Name = "btnR1";
            this.btnR1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnR1.Size = new System.Drawing.Size(794, 79);
            this.btnR1.TabIndex = 0;
            this.btnR1.Text = "Respuesta 1";
            this.btnR1.UseVisualStyleBackColor = false;
            this.btnR1.Click += new System.EventHandler(this.btnR1_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPregunta.Font = new System.Drawing.Font("Century Gothic", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(0, 0);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPregunta.Size = new System.Drawing.Size(800, 105);
            this.txtPregunta.TabIndex = 17;
            this.txtPregunta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Wingdings 3", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnContinuar.Location = new System.Drawing.Point(340, 511);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(129, 89);
            this.btnContinuar.TabIndex = 18;
            this.btnContinuar.Text = "u";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntuaje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnR4;
        private System.Windows.Forms.Button btnR3;
        private System.Windows.Forms.Button btnR2;
        private System.Windows.Forms.Button btnR1;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnContinuar;
    }
}