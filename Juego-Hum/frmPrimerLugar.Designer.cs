namespace Juego_Hum
{
    partial class frmPrimerLugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimerLugar));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnInformación = new System.Windows.Forms.ToolStripButton();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripSeparator2,
            this.btnInformación});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.Size = new System.Drawing.Size(605, 47);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = global::Juego_Hum.Properties.Resources._1402796595_home;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHome.Size = new System.Drawing.Size(64, 44);
            this.btnHome.Tag = "";
            this.btnHome.Text = "btnHome";
            this.btnHome.ToolTipText = "Menú";
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
            this.btnSalir.Text = "btnSalir";
            this.btnSalir.ToolTipText = "Salir";
            // 
            // btnInformación
            // 
            this.btnInformación.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInformación.Image = global::Juego_Hum.Properties.Resources._1402807023_question_balloon_sticker;
            this.btnInformación.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInformación.Name = "btnInformación";
            this.btnInformación.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInformación.Size = new System.Drawing.Size(64, 44);
            this.btnInformación.Tag = "";
            this.btnInformación.Text = "frmInformacion";
            this.btnInformación.ToolTipText = "Información";
            // 
            // ptb2
            // 
            this.ptb2.Image = ((System.Drawing.Image)(resources.GetObject("ptb2.Image")));
            this.ptb2.Location = new System.Drawing.Point(318, 65);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(246, 226);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 1;
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.Image = ((System.Drawing.Image)(resources.GetObject("ptb1.Image")));
            this.ptb1.Location = new System.Drawing.Point(40, 65);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(246, 226);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            // 
            // frmCataPrimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 345);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCataPrimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCataPrimer";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnInformación;
    }
}