namespace Juego_Hum
{
    partial class frmConfigurar
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
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCuestionario = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddCuestionario = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCuestionario = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.grpRespuestas = new System.Windows.Forms.GroupBox();
            this.Op3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRcorrecta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtROp2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtROp3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtROp4 = new System.Windows.Forms.TextBox();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpRespuestas.SuspendLayout();
            this.Op3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3,
            this.btnSalir,
            this.toolStripSeparator4});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(708, 47);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Juego_Hum.Properties.Resources._1402802182_add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.Size = new System.Drawing.Size(64, 44);
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "toolStripButton2";
            this.btnAdd.ToolTipText = "Agregar Pregunta";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Juego_Hum.Properties.Resources._1402802127_f_cross_256;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(64, 44);
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "toolStripButton3";
            this.btnDelete.ToolTipText = "Eliminar Pregunta";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Juego_Hum.Properties.Resources._1402347449_floppy;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(64, 44);
            this.btnSave.Tag = "";
            this.btnSave.Text = "toolStripButton4";
            this.btnSave.ToolTipText = "Guardar Cambios";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbCuestionario,
            this.btnAddCuestionario,
            this.btnDeleteCuestionario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel1.Text = "Cuestionario:";
            // 
            // cmbCuestionario
            // 
            this.cmbCuestionario.Name = "cmbCuestionario";
            this.cmbCuestionario.Size = new System.Drawing.Size(121, 25);
            this.cmbCuestionario.TextChanged += new System.EventHandler(this.cmbCuestionario_TextChanged);
            // 
            // btnAddCuestionario
            // 
            this.btnAddCuestionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCuestionario.Image = global::Juego_Hum.Properties.Resources._1402802182_add;
            this.btnAddCuestionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCuestionario.Name = "btnAddCuestionario";
            this.btnAddCuestionario.Size = new System.Drawing.Size(23, 22);
            this.btnAddCuestionario.Text = "toolStripButton1";
            this.btnAddCuestionario.ToolTipText = "Agregar Cuestionario";
            this.btnAddCuestionario.Click += new System.EventHandler(this.btnAddCuestionario_Click);
            // 
            // btnDeleteCuestionario
            // 
            this.btnDeleteCuestionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCuestionario.Image = global::Juego_Hum.Properties.Resources._1402802127_f_cross_256;
            this.btnDeleteCuestionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCuestionario.Name = "btnDeleteCuestionario";
            this.btnDeleteCuestionario.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCuestionario.Text = "toolStripButton2";
            this.btnDeleteCuestionario.ToolTipText = "Eliminar Cuestionario";
            this.btnDeleteCuestionario.Click += new System.EventHandler(this.btnDeleteCuestionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregunta:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(202, 99);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPregunta.Size = new System.Drawing.Size(382, 83);
            this.txtPregunta.TabIndex = 3;
            // 
            // grpRespuestas
            // 
            this.grpRespuestas.Controls.Add(this.Op3);
            this.grpRespuestas.ForeColor = System.Drawing.Color.White;
            this.grpRespuestas.Location = new System.Drawing.Point(122, 199);
            this.grpRespuestas.Name = "grpRespuestas";
            this.grpRespuestas.Size = new System.Drawing.Size(462, 198);
            this.grpRespuestas.TabIndex = 4;
            this.grpRespuestas.TabStop = false;
            this.grpRespuestas.Text = "Respuestas";
            // 
            // Op3
            // 
            this.Op3.Controls.Add(this.tabPage1);
            this.Op3.Controls.Add(this.tabPage2);
            this.Op3.Controls.Add(this.tabPage3);
            this.Op3.Controls.Add(this.tabPage4);
            this.Op3.Location = new System.Drawing.Point(15, 47);
            this.Op3.Name = "Op3";
            this.Op3.SelectedIndex = 0;
            this.Op3.Size = new System.Drawing.Size(431, 132);
            this.Op3.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRcorrecta);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 99);
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
            this.tabPage2.Size = new System.Drawing.Size(423, 99);
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
            this.tabPage3.Size = new System.Drawing.Size(423, 99);
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
            this.tabPage4.Size = new System.Drawing.Size(423, 99);
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
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta,
            this.Respuesta,
            this.Opcion2,
            this.Opcion3,
            this.Opcion4});
            this.dtgvTabla.Location = new System.Drawing.Point(2, 417);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.Size = new System.Drawing.Size(706, 190);
            this.dtgvTabla.TabIndex = 10;
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
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(708, 630);
            this.Controls.Add(this.dtgvTabla);
            this.Controls.Add(this.grpRespuestas);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfigurar";
            this.Load += new System.EventHandler(this.frmConfigurar_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpRespuestas.ResumeLayout(false);
            this.Op3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbCuestionario;
        private System.Windows.Forms.ToolStripButton btnAddCuestionario;
        private System.Windows.Forms.ToolStripButton btnDeleteCuestionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox grpRespuestas;
        private System.Windows.Forms.TabControl Op3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRcorrecta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtROp2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtROp3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtROp4;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}