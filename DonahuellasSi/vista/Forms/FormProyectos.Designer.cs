namespace DonahuellasSi.vista.Forms
{
    partial class FormProyectos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tablaProyectos = new System.Windows.Forms.DataGridView();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montodonadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donaHuellasDataSet3 = new DonahuellasSi.donaHuellasDataSet3();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericCosto = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectoTableAdapter = new DonahuellasSi.donaHuellasDataSet3TableAdapters.proyectoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 780);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tablaProyectos);
            this.panel4.Location = new System.Drawing.Point(4, 298);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1665, 479);
            this.panel4.TabIndex = 2;
            // 
            // tablaProyectos
            // 
            this.tablaProyectos.AutoGenerateColumns = false;
            this.tablaProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProyectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.tablaProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn,
            this.nombreproyectoDataGridViewTextBoxColumn,
            this.descripcionproyectoDataGridViewTextBoxColumn,
            this.montodonadoDataGridViewTextBoxColumn});
            this.tablaProyectos.DataSource = this.proyectoBindingSource;
            this.tablaProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaProyectos.Location = new System.Drawing.Point(0, 0);
            this.tablaProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaProyectos.Name = "tablaProyectos";
            this.tablaProyectos.ReadOnly = true;
            this.tablaProyectos.RowHeadersWidth = 51;
            this.tablaProyectos.Size = new System.Drawing.Size(1665, 479);
            this.tablaProyectos.TabIndex = 0;
            this.tablaProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProyectos_CellClick);
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
            this.nombreproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionproyectoDataGridViewTextBoxColumn
            // 
            this.descripcionproyectoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.HeaderText = "descripcion_proyecto";
            this.descripcionproyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionproyectoDataGridViewTextBoxColumn.Name = "descripcionproyectoDataGridViewTextBoxColumn";
            this.descripcionproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montodonadoDataGridViewTextBoxColumn
            // 
            this.montodonadoDataGridViewTextBoxColumn.DataPropertyName = "monto_donado";
            this.montodonadoDataGridViewTextBoxColumn.HeaderText = "monto_donado";
            this.montodonadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montodonadoDataGridViewTextBoxColumn.Name = "montodonadoDataGridViewTextBoxColumn";
            this.montodonadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "proyecto";
            this.proyectoBindingSource.DataSource = this.donaHuellasDataSet3;
            // 
            // donaHuellasDataSet3
            // 
            this.donaHuellasDataSet3.DataSetName = "donaHuellasDataSet3";
            this.donaHuellasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericCosto);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.txtNombreProyecto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Location = new System.Drawing.Point(4, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1665, 202);
            this.panel3.TabIndex = 1;
            // 
            // numericCosto
            // 
            this.numericCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCosto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCosto.Location = new System.Drawing.Point(111, 116);
            this.numericCosto.Margin = new System.Windows.Forms.Padding(4);
            this.numericCosto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericCosto.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCosto.Name = "numericCosto";
            this.numericCosto.Size = new System.Drawing.Size(472, 26);
            this.numericCosto.TabIndex = 11;
            this.numericCosto.ThousandsSeparator = true;
            this.numericCosto.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(1073, 16);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(441, 165);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.Location = new System.Drawing.Point(111, 62);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(471, 26);
            this.txtNombreProyecto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(948, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 16);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(128, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id del proyecto: ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Location = new System.Drawing.Point(1553, 170);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(1553, 116);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizar.Location = new System.Drawing.Point(1553, 59);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 31);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(1553, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1665, 82);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1657, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Proyectos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 780);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormProyectos";
            this.Text = "FormProyectos";
            this.Load += new System.EventHandler(this.FormProyectos_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tablaProyectos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private donaHuellasDataSet3 donaHuellasDataSet3;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private donaHuellasDataSet3TableAdapters.proyectoTableAdapter proyectoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montodonadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.NumericUpDown numericCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Timer timer1;
    }
}