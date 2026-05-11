namespace DonahuellasSi.vista
{
    partial class Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnAportes = new System.Windows.Forms.RadioButton();
            this.rBtnProyectos = new System.Windows.Forms.RadioButton();
            this.rBtnDonantes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montodonadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donaHuellasDataSet2 = new DonahuellasSi.donaHuellasDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donaHuellasDataSet1 = new DonahuellasSi.donaHuellasDataSet1();
            this.donanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donanteTableAdapter = new DonahuellasSi.donaHuellasDataSet1TableAdapters.donanteTableAdapter();
            this.proyectoTableAdapter = new DonahuellasSi.donaHuellasDataSet2TableAdapters.proyectoTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 838);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.rBtnAportes);
            this.panel5.Controls.Add(this.rBtnProyectos);
            this.panel5.Controls.Add(this.rBtnDonantes);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(291, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1379, 246);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "¡Bienvenido a";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "Huellas!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rBtnAportes
            // 
            this.rBtnAportes.BackColor = System.Drawing.Color.White;
            this.rBtnAportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnAportes.Image = ((System.Drawing.Image)(resources.GetObject("rBtnAportes.Image")));
            this.rBtnAportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnAportes.Location = new System.Drawing.Point(1161, 183);
            this.rBtnAportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnAportes.Name = "rBtnAportes";
            this.rBtnAportes.Size = new System.Drawing.Size(199, 43);
            this.rBtnAportes.TabIndex = 3;
            this.rBtnAportes.Text = "Ver Aportes";
            this.rBtnAportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnAportes.UseVisualStyleBackColor = false;
            this.rBtnAportes.CheckedChanged += new System.EventHandler(this.rBtnAportes_CheckedChanged);
            // 
            // rBtnProyectos
            // 
            this.rBtnProyectos.BackColor = System.Drawing.Color.White;
            this.rBtnProyectos.Checked = true;
            this.rBtnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("rBtnProyectos.Image")));
            this.rBtnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnProyectos.Location = new System.Drawing.Point(557, 183);
            this.rBtnProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnProyectos.Name = "rBtnProyectos";
            this.rBtnProyectos.Size = new System.Drawing.Size(227, 43);
            this.rBtnProyectos.TabIndex = 2;
            this.rBtnProyectos.TabStop = true;
            this.rBtnProyectos.Text = "Ver Proyectos";
            this.rBtnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnProyectos.UseVisualStyleBackColor = false;
            this.rBtnProyectos.CheckedChanged += new System.EventHandler(this.rBtnProyectos_CheckedChanged);
            // 
            // rBtnDonantes
            // 
            this.rBtnDonantes.BackColor = System.Drawing.Color.White;
            this.rBtnDonantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDonantes.Image = ((System.Drawing.Image)(resources.GetObject("rBtnDonantes.Image")));
            this.rBtnDonantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnDonantes.Location = new System.Drawing.Point(24, 183);
            this.rBtnDonantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnDonantes.Name = "rBtnDonantes";
            this.rBtnDonantes.Size = new System.Drawing.Size(227, 43);
            this.rBtnDonantes.TabIndex = 1;
            this.rBtnDonantes.Text = "Ver Donantes";
            this.rBtnDonantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnDonantes.UseVisualStyleBackColor = false;
            this.rBtnDonantes.CheckedChanged += new System.EventHandler(this.rBtnDonantes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(509, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dona";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tablaPrincipal);
            this.panel4.Location = new System.Drawing.Point(291, 268);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1379, 555);
            this.panel4.TabIndex = 3;
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.AutoGenerateColumns = false;
            this.tablaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn,
            this.nombreproyectoDataGridViewTextBoxColumn,
            this.descripcionproyectoDataGridViewTextBoxColumn,
            this.montodonadoDataGridViewTextBoxColumn});
            this.tablaPrincipal.DataSource = this.proyectoBindingSource;
            this.tablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablaPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.RowHeadersWidth = 51;
            this.tablaPrincipal.Size = new System.Drawing.Size(1379, 555);
            this.tablaPrincipal.TabIndex = 0;
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            this.idproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproyectoDataGridViewTextBoxColumn
            // 
            this.nombreproyectoDataGridViewTextBoxColumn.DataPropertyName = "nombre_proyecto";
            this.nombreproyectoDataGridViewTextBoxColumn.HeaderText = "nombre_proyecto";
            this.nombreproyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreproyectoDataGridViewTextBoxColumn.Name = "nombreproyectoDataGridViewTextBoxColumn";
            // 
            // descripcionproyectoDataGridViewTextBoxColumn
            // 
            this.descripcionproyectoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.HeaderText = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionproyectoDataGridViewTextBoxColumn.Name = "descripcionproyectoDataGridViewTextBoxColumn";
            // 
            // montodonadoDataGridViewTextBoxColumn
            // 
            this.montodonadoDataGridViewTextBoxColumn.DataPropertyName = "monto_donado";
            this.montodonadoDataGridViewTextBoxColumn.HeaderText = "monto_donado";
            this.montodonadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montodonadoDataGridViewTextBoxColumn.Name = "montodonadoDataGridViewTextBoxColumn";
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "proyecto";
            this.proyectoBindingSource.DataSource = this.donaHuellasDataSet2;
            // 
            // donaHuellasDataSet2
            // 
            this.donaHuellasDataSet2.DataSetName = "donaHuellasDataSet2";
            this.donaHuellasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(16, 268);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 555);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 246);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1685, 838);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // donaHuellasDataSet1
            // 
            this.donaHuellasDataSet1.DataSetName = "donaHuellasDataSet1";
            this.donaHuellasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donanteBindingSource
            // 
            this.donanteBindingSource.DataMember = "donante";
            this.donanteBindingSource.DataSource = this.donaHuellasDataSet1;
            // 
            // donanteTableAdapter
            // 
            this.donanteTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donantesToolStripMenuItem,
            this.aportesToolStripMenuItem,
            this.proyectosToolStripMenuItem});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // donantesToolStripMenuItem
            // 
            this.donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            this.donantesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.donantesToolStripMenuItem.Text = "Donantes";
            this.donantesToolStripMenuItem.Click += new System.EventHandler(this.donantesToolStripMenuItem_Click);
            // 
            // aportesToolStripMenuItem
            // 
            this.aportesToolStripMenuItem.Name = "aportesToolStripMenuItem";
            this.aportesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aportesToolStripMenuItem.Text = "Aportes";
            this.aportesToolStripMenuItem.Click += new System.EventHandler(this.aportesToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dash";
            this.Text = "Dashboard - DonaHuellas";
            this.Load += new System.EventHandler(this.Dash_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tablaPrincipal;
        private donaHuellasDataSet1 donaHuellasDataSet1;
        private System.Windows.Forms.BindingSource donanteBindingSource;
        private donaHuellasDataSet1TableAdapters.donanteTableAdapter donanteTableAdapter;
        private donaHuellasDataSet2 donaHuellasDataSet2;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private donaHuellasDataSet2TableAdapters.proyectoTableAdapter proyectoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montodonadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rBtnDonantes;
        private System.Windows.Forms.RadioButton rBtnAportes;
        private System.Windows.Forms.RadioButton rBtnProyectos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
    }
}