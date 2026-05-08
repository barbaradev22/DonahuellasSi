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
            this.rBtnAportes = new System.Windows.Forms.RadioButton();
            this.rBtnProyectos = new System.Windows.Forms.RadioButton();
            this.rBtnDonantes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montodonadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donaHuellasDataSet2 = new DonahuellasSi.donaHuellasDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donaHuellasDataSet1 = new DonahuellasSi.donaHuellasDataSet1();
            this.donanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donanteTableAdapter = new DonahuellasSi.donaHuellasDataSet1TableAdapters.donanteTableAdapter();
            this.proyectoTableAdapter = new DonahuellasSi.donaHuellasDataSet2TableAdapters.proyectoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rBtnAportes);
            this.panel5.Controls.Add(this.rBtnProyectos);
            this.panel5.Controls.Add(this.rBtnDonantes);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(218, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1034, 200);
            this.panel5.TabIndex = 4;
            // 
            // rBtnAportes
            // 
            this.rBtnAportes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAportes.Image = ((System.Drawing.Image)(resources.GetObject("rBtnAportes.Image")));
            this.rBtnAportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnAportes.Location = new System.Drawing.Point(865, 149);
            this.rBtnAportes.Name = "rBtnAportes";
            this.rBtnAportes.Size = new System.Drawing.Size(151, 35);
            this.rBtnAportes.TabIndex = 3;
            this.rBtnAportes.Text = "Ver Aportes";
            this.rBtnAportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnAportes.UseVisualStyleBackColor = true;
            // 
            // rBtnProyectos
            // 
            this.rBtnProyectos.Checked = true;
            this.rBtnProyectos.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("rBtnProyectos.Image")));
            this.rBtnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnProyectos.Location = new System.Drawing.Point(440, 149);
            this.rBtnProyectos.Name = "rBtnProyectos";
            this.rBtnProyectos.Size = new System.Drawing.Size(151, 35);
            this.rBtnProyectos.TabIndex = 2;
            this.rBtnProyectos.TabStop = true;
            this.rBtnProyectos.Text = "Ver Proyectos";
            this.rBtnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnProyectos.UseVisualStyleBackColor = true;
            this.rBtnProyectos.CheckedChanged += new System.EventHandler(this.rBtnProyectos_CheckedChanged);
            // 
            // rBtnDonantes
            // 
            this.rBtnDonantes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDonantes.Image = ((System.Drawing.Image)(resources.GetObject("rBtnDonantes.Image")));
            this.rBtnDonantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnDonantes.Location = new System.Drawing.Point(10, 149);
            this.rBtnDonantes.Name = "rBtnDonantes";
            this.rBtnDonantes.Size = new System.Drawing.Size(151, 35);
            this.rBtnDonantes.TabIndex = 1;
            this.rBtnDonantes.Text = "Ver Donantes";
            this.rBtnDonantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnDonantes.UseVisualStyleBackColor = true;
            this.rBtnDonantes.CheckedChanged += new System.EventHandler(this.rBtnDonantes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a DonaHuellas!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(218, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 451);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn,
            this.nombreproyectoDataGridViewTextBoxColumn,
            this.descripcionproyectoDataGridViewTextBoxColumn,
            this.montodonadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proyectoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1034, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            this.idproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproyectoDataGridViewTextBoxColumn
            // 
            this.nombreproyectoDataGridViewTextBoxColumn.DataPropertyName = "nombre_proyecto";
            this.nombreproyectoDataGridViewTextBoxColumn.HeaderText = "nombre_proyecto";
            this.nombreproyectoDataGridViewTextBoxColumn.Name = "nombreproyectoDataGridViewTextBoxColumn";
            // 
            // descripcionproyectoDataGridViewTextBoxColumn
            // 
            this.descripcionproyectoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.HeaderText = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.Name = "descripcionproyectoDataGridViewTextBoxColumn";
            // 
            // montodonadoDataGridViewTextBoxColumn
            // 
            this.montodonadoDataGridViewTextBoxColumn.DataPropertyName = "monto_donado";
            this.montodonadoDataGridViewTextBoxColumn.HeaderText = "monto_donado";
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
            this.panel3.Location = new System.Drawing.Point(12, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 451);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 681);
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
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Dash";
            this.Text = "Dashboard - DonaHuellas";
            this.Load += new System.EventHandler(this.Dash_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnAportes;
        private System.Windows.Forms.RadioButton rBtnProyectos;
    }
}