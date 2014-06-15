namespace Juego_Hum
{
    partial class frmPreparar
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgInactivo = new System.Windows.Forms.DataGridView();
            this.Cuestionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgActivo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnInformación = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActivo)).BeginInit();
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
            this.Menu.Size = new System.Drawing.Size(662, 47);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "toolStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
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
            // dtgInactivo
            // 
            this.dtgInactivo.AllowUserToAddRows = false;
            this.dtgInactivo.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgInactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInactivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuestionario});
            this.dtgInactivo.Location = new System.Drawing.Point(14, 102);
            this.dtgInactivo.Margin = new System.Windows.Forms.Padding(5);
            this.dtgInactivo.Name = "dtgInactivo";
            this.dtgInactivo.Size = new System.Drawing.Size(243, 370);
            this.dtgInactivo.TabIndex = 2;
            // 
            // Cuestionario
            // 
            this.Cuestionario.HeaderText = "Cuestionario";
            this.Cuestionario.Name = "Cuestionario";
            this.Cuestionario.ReadOnly = true;
            this.Cuestionario.Width = 200;
            // 
            // dtgActivo
            // 
            this.dtgActivo.AllowUserToAddRows = false;
            this.dtgActivo.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dtgActivo.Location = new System.Drawing.Point(405, 101);
            this.dtgActivo.Margin = new System.Windows.Forms.Padding(5);
            this.dtgActivo.Name = "dtgActivo";
            this.dtgActivo.Size = new System.Drawing.Size(243, 370);
            this.dtgActivo.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuestionario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnActivar.Font = new System.Drawing.Font("Wingdings 3", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.Location = new System.Drawing.Point(276, 164);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(110, 112);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "u";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInactivar.Font = new System.Drawing.Font("Wingdings 3", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnInactivar.ForeColor = System.Drawing.Color.White;
            this.btnInactivar.Location = new System.Drawing.Point(276, 282);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(110, 112);
            this.btnInactivar.TabIndex = 5;
            this.btnInactivar.Text = "t";
            this.btnInactivar.UseVisualStyleBackColor = false;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "En Juego";
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
            this.btnHome.Text = "toolStripButton1";
            this.btnHome.ToolTipText = "Menú";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnInformación.Text = "toolStripButton1";
            this.btnInformación.ToolTipText = "Información";
            this.btnInformación.Click += new System.EventHandler(this.btnInformación_Click);
            // 
            // frmPreparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(662, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.dtgActivo);
            this.Controls.Add(this.dtgInactivo);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPreparar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreparar";
            this.Load += new System.EventHandler(this.frmPreparar_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dtgInactivo;
        private System.Windows.Forms.ToolStripButton btnInformación;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuestionario;
        private System.Windows.Forms.DataGridView dtgActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Label label1;
    }
}