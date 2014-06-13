namespace Juego
{
    partial class PlanearJuego
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
            this.dtgvInactivo = new System.Windows.Forms.DataGridView();
            this.Cuestionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvActivo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActivo = new System.Windows.Forms.Button();
            this.btnInactivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvInactivo
            // 
            this.dtgvInactivo.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dtgvInactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInactivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuestionario});
            this.dtgvInactivo.Location = new System.Drawing.Point(61, 110);
            this.dtgvInactivo.Name = "dtgvInactivo";
            this.dtgvInactivo.Size = new System.Drawing.Size(242, 337);
            this.dtgvInactivo.TabIndex = 10;
            // 
            // Cuestionario
            // 
            this.Cuestionario.HeaderText = "Cuestionario";
            this.Cuestionario.Name = "Cuestionario";
            this.Cuestionario.ReadOnly = true;
            this.Cuestionario.Width = 200;
            // 
            // dtgvActivo
            // 
            this.dtgvActivo.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dtgvActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvActivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dtgvActivo.Location = new System.Drawing.Point(419, 110);
            this.dtgvActivo.Name = "dtgvActivo";
            this.dtgvActivo.Size = new System.Drawing.Size(242, 337);
            this.dtgvActivo.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuestionario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // btnActivo
            // 
            this.btnActivo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnActivo.Font = new System.Drawing.Font("Wingdings 3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnActivo.ForeColor = System.Drawing.Color.White;
            this.btnActivo.Location = new System.Drawing.Point(320, 137);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(84, 84);
            this.btnActivo.TabIndex = 12;
            this.btnActivo.Text = "u";
            this.btnActivo.UseVisualStyleBackColor = false;
            this.btnActivo.Click += new System.EventHandler(this.btnActivo_Click);
            // 
            // btnInactivo
            // 
            this.btnInactivo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnInactivo.Font = new System.Drawing.Font("Wingdings 3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnInactivo.ForeColor = System.Drawing.Color.White;
            this.btnInactivo.Location = new System.Drawing.Point(320, 275);
            this.btnInactivo.Name = "btnInactivo";
            this.btnInactivo.Size = new System.Drawing.Size(84, 84);
            this.btnInactivo.TabIndex = 13;
            this.btnInactivo.Text = "t";
            this.btnInactivo.UseVisualStyleBackColor = false;
            this.btnInactivo.Click += new System.EventHandler(this.btnInactivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Esta vez no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "En Juego";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImage = global::Juego.Properties.Resources._1402398252_MB__home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.Location = new System.Drawing.Point(-2, -2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 69);
            this.btnHome.TabIndex = 16;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PlanearJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 488);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInactivo);
            this.Controls.Add(this.btnActivo);
            this.Controls.Add(this.dtgvActivo);
            this.Controls.Add(this.dtgvInactivo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlanearJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planear Juego";
            this.Load += new System.EventHandler(this.PlanearJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvInactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuestionario;
        private System.Windows.Forms.DataGridView dtgvActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.Button btnInactivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
    }
}