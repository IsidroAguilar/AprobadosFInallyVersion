namespace Juego_Hum
{
    partial class frmMenu
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPreparar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.BackgroundImage = global::Juego_Hum.Properties.Resources._1402806568_Information;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Location = new System.Drawing.Point(164, 210);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(146, 142);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.White;
            this.btnJugar.BackgroundImage = global::Juego_Hum.Properties.Resources._1402804895_joypad;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.Location = new System.Drawing.Point(12, 210);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(146, 142);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPreparar
            // 
            this.btnPreparar.BackColor = System.Drawing.Color.White;
            this.btnPreparar.BackgroundImage = global::Juego_Hum.Properties.Resources._1402804871_settings02;
            this.btnPreparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreparar.Location = new System.Drawing.Point(164, 62);
            this.btnPreparar.Name = "btnPreparar";
            this.btnPreparar.Size = new System.Drawing.Size(146, 142);
            this.btnPreparar.TabIndex = 1;
            this.btnPreparar.UseVisualStyleBackColor = false;
            this.btnPreparar.Click += new System.EventHandler(this.btnPreparar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.BackColor = System.Drawing.Color.White;
            this.btnConfigurar.BackgroundImage = global::Juego_Hum.Properties.Resources._1402804866_settings01;
            this.btnConfigurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigurar.Location = new System.Drawing.Point(12, 62);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(146, 142);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.UseVisualStyleBackColor = false;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.Size = new System.Drawing.Size(320, 47);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::Juego_Hum.Properties.Resources._1402796165_Log_Out;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSalir.Size = new System.Drawing.Size(64, 44);
            this.btnSalir.Tag = "";
            this.btnSalir.Text = "toolStripButton5";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(320, 368);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnPreparar);
            this.Controls.Add(this.btnConfigurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnPreparar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}