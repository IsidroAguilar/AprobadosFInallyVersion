namespace Juego
{
    partial class AdmnInfo
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
            this.dbBotton = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctgAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctgRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCtgr = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPreguntas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbRespuestas = new System.Windows.Forms.GroupBox();
            this.Op3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRcorrecta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtROp2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtROp3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtROp4 = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dbBotton.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbPreguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.grbRespuestas.SuspendLayout();
            this.Op3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbBotton
            // 
            this.dbBotton.BackColor = System.Drawing.Color.White;
            this.dbBotton.Controls.Add(this.btnHome);
            this.dbBotton.Controls.Add(this.btnSave);
            this.dbBotton.Controls.Add(this.btnAdd);
            this.dbBotton.Controls.Add(this.btnRemove);
            this.dbBotton.Dock = System.Windows.Forms.DockStyle.Right;
            this.dbBotton.Location = new System.Drawing.Point(724, 29);
            this.dbBotton.Name = "dbBotton";
            this.dbBotton.Size = new System.Drawing.Size(69, 525);
            this.dbBotton.TabIndex = 4;
            this.dbBotton.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.cmbCtgr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctgAdd,
            this.ctgRemove});
            this.categoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.categoriaToolStripMenuItem.Text = "Cuestionario";
            // 
            // ctgAdd
            // 
            this.ctgAdd.Name = "ctgAdd";
            this.ctgAdd.Size = new System.Drawing.Size(139, 26);
            this.ctgAdd.Text = "Añadir";
            this.ctgAdd.Click += new System.EventHandler(this.ctgAdd_Click);
            // 
            // ctgRemove
            // 
            this.ctgRemove.Name = "ctgRemove";
            this.ctgRemove.Size = new System.Drawing.Size(139, 26);
            this.ctgRemove.Text = "Eliminar";
            this.ctgRemove.Click += new System.EventHandler(this.ctgRemove_Click);
            // 
            // cmbCtgr
            // 
            this.cmbCtgr.Name = "cmbCtgr";
            this.cmbCtgr.Size = new System.Drawing.Size(121, 25);
            this.cmbCtgr.TextChanged += new System.EventHandler(this.cmbCtgr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 7;
            // 
            // gbPreguntas
            // 
            this.gbPreguntas.Controls.Add(this.label2);
            this.gbPreguntas.Controls.Add(this.dtgvTabla);
            this.gbPreguntas.Controls.Add(this.grbRespuestas);
            this.gbPreguntas.Controls.Add(this.txtPregunta);
            this.gbPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreguntas.Location = new System.Drawing.Point(0, 29);
            this.gbPreguntas.Name = "gbPreguntas";
            this.gbPreguntas.Size = new System.Drawing.Size(724, 525);
            this.gbPreguntas.TabIndex = 8;
            this.gbPreguntas.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pregunta:";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta,
            this.Respuesta,
            this.Opcion2,
            this.Opcion3,
            this.Opcion4});
            this.dtgvTabla.Location = new System.Drawing.Point(12, 245);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.Size = new System.Drawing.Size(706, 234);
            this.dtgvTabla.TabIndex = 9;
            this.dtgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTabla_CellClick);
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pregunta.FillWeight = 400F;
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            // 
            // Respuesta
            // 
            this.Respuesta.HeaderText = "Respuesta";
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.ReadOnly = true;
            // 
            // Opcion2
            // 
            this.Opcion2.HeaderText = "Opcion 2";
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.ReadOnly = true;
            this.Opcion2.Width = 110;
            // 
            // Opcion3
            // 
            this.Opcion3.HeaderText = "Opcion 3";
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.ReadOnly = true;
            this.Opcion3.Width = 110;
            // 
            // Opcion4
            // 
            this.Opcion4.HeaderText = "Opcion 4";
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.ReadOnly = true;
            this.Opcion4.Width = 110;
            // 
            // grbRespuestas
            // 
            this.grbRespuestas.Controls.Add(this.Op3);
            this.grbRespuestas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRespuestas.Location = new System.Drawing.Point(134, 71);
            this.grbRespuestas.Name = "grbRespuestas";
            this.grbRespuestas.Size = new System.Drawing.Size(452, 155);
            this.grbRespuestas.TabIndex = 6;
            this.grbRespuestas.TabStop = false;
            this.grbRespuestas.Text = "Respuestas";
            // 
            // Op3
            // 
            this.Op3.Controls.Add(this.tabPage1);
            this.Op3.Controls.Add(this.tabPage2);
            this.Op3.Controls.Add(this.tabPage3);
            this.Op3.Controls.Add(this.tabPage4);
            this.Op3.Location = new System.Drawing.Point(16, 26);
            this.Op3.Name = "Op3";
            this.Op3.SelectedIndex = 0;
            this.Op3.Size = new System.Drawing.Size(430, 123);
            this.Op3.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRcorrecta);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 90);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Correcta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRcorrecta
            // 
            this.txtRcorrecta.Location = new System.Drawing.Point(6, 6);
            this.txtRcorrecta.Multiline = true;
            this.txtRcorrecta.Name = "txtRcorrecta";
            this.txtRcorrecta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRcorrecta.Size = new System.Drawing.Size(410, 78);
            this.txtRcorrecta.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtROp2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 90);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opcion 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtROp2
            // 
            this.txtROp2.Location = new System.Drawing.Point(6, 6);
            this.txtROp2.Multiline = true;
            this.txtROp2.Name = "txtROp2";
            this.txtROp2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtROp2.Size = new System.Drawing.Size(410, 78);
            this.txtROp2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtROp3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(422, 90);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Opcion 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtROp3
            // 
            this.txtROp3.Location = new System.Drawing.Point(6, 6);
            this.txtROp3.Multiline = true;
            this.txtROp3.Name = "txtROp3";
            this.txtROp3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtROp3.Size = new System.Drawing.Size(410, 78);
            this.txtROp3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtROp4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(422, 90);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Opcion 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtROp4
            // 
            this.txtROp4.Location = new System.Drawing.Point(6, 6);
            this.txtROp4.Multiline = true;
            this.txtROp4.Name = "txtROp4";
            this.txtROp4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtROp4.Size = new System.Drawing.Size(410, 78);
            this.txtROp4.TabIndex = 2;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(134, 15);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPregunta.Size = new System.Drawing.Size(452, 50);
            this.txtPregunta.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImage = global::Juego.Properties.Resources._1402398252_MB__home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.Location = new System.Drawing.Point(0, 242);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 69);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::Juego.Properties.Resources._1402347449_floppy;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(0, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 69);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::Juego.Properties.Resources._1402349225_Plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(0, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 69);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BackgroundImage = global::Juego.Properties.Resources._1402347143_remove_sign;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRemove.Location = new System.Drawing.Point(1, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 69);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AdmnInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 554);
            this.Controls.Add(this.gbPreguntas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbBotton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdmnInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Información";
            this.Load += new System.EventHandler(this.AdmnInfo_Load);
            this.dbBotton.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPreguntas.ResumeLayout(false);
            this.gbPreguntas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.grbRespuestas.ResumeLayout(false);
            this.Op3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox dbBotton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctgAdd;
        private System.Windows.Forms.ToolStripComboBox cmbCtgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPreguntas;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.GroupBox grbRespuestas;
        private System.Windows.Forms.TabControl Op3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRcorrecta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtROp2;
        private System.Windows.Forms.TextBox txtROp3;
        private System.Windows.Forms.TextBox txtROp4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion4;
        private System.Windows.Forms.ToolStripMenuItem ctgRemove;
        private System.Windows.Forms.Button btnHome;
    }
}