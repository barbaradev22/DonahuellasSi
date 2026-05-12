namespace DonahuellasSi.vista.Forms
{
    partial class FormAportes
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
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.spnMonto = new System.Windows.Forms.NumericUpDown();
            this.cbProyectos = new System.Windows.Forms.ComboBox();
            this.cbDonantes = new System.Windows.Forms.ComboBox();
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
            this.donaHuellasDataSet9 = new DonahuellasSi.donaHuellasDataSet9();
            this.donanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donanteTableAdapter = new DonahuellasSi.donaHuellasDataSet9TableAdapters.donanteTableAdapter();
            this.donaHuellasDataSet10 = new DonahuellasSi.donaHuellasDataSet10();
            this.donanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donanteTableAdapter1 = new DonahuellasSi.donaHuellasDataSet10TableAdapters.donanteTableAdapter();
            this.donaHuellasDataSet11 = new DonahuellasSi.donaHuellasDataSet11();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTableAdapter = new DonahuellasSi.donaHuellasDataSet11TableAdapters.proyectoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tablaPrincipal);
            this.panel4.Location = new System.Drawing.Point(4, 298);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1665, 479);
            this.panel4.TabIndex = 2;
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablaPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.ReadOnly = true;
            this.tablaPrincipal.RowHeadersWidth = 51;
            this.tablaPrincipal.Size = new System.Drawing.Size(1665, 479);
            this.tablaPrincipal.TabIndex = 0;
            this.tablaPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrincipal_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.spnMonto);
            this.panel3.Controls.Add(this.cbProyectos);
            this.panel3.Controls.Add(this.cbDonantes);
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
            // spnMonto
            // 
            this.spnMonto.Location = new System.Drawing.Point(833, 94);
            this.spnMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spnMonto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.spnMonto.Name = "spnMonto";
            this.spnMonto.Size = new System.Drawing.Size(355, 22);
            this.spnMonto.TabIndex = 14;
            // 
            // cbProyectos
            // 
            this.cbProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProyectos.FormattingEnabled = true;
            this.cbProyectos.Location = new System.Drawing.Point(43, 150);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Size = new System.Drawing.Size(353, 24);
            this.cbProyectos.TabIndex = 13;
            // 
            // cbDonantes
            // 
            this.cbDonantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonantes.FormattingEnabled = true;
            this.cbDonantes.Location = new System.Drawing.Point(43, 94);
            this.cbDonantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDonantes.Name = "cbDonantes";
            this.cbDonantes.Size = new System.Drawing.Size(353, 24);
            this.cbDonantes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proyecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto Aportado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Donante:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(52, 16);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id del aporte: ";
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
            this.label1.Text = "Gestión de Aportes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donaHuellasDataSet9
            // 
            this.donaHuellasDataSet9.DataSetName = "donaHuellasDataSet9";
            this.donaHuellasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donanteBindingSource
            // 
            this.donanteBindingSource.DataMember = "donante";
            this.donanteBindingSource.DataSource = this.donaHuellasDataSet9;
            // 
            // donanteTableAdapter
            // 
            this.donanteTableAdapter.ClearBeforeFill = true;
            // 
            // donaHuellasDataSet10
            // 
            this.donaHuellasDataSet10.DataSetName = "donaHuellasDataSet10";
            this.donaHuellasDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donanteBindingSource1
            // 
            this.donanteBindingSource1.DataMember = "donante";
            this.donanteBindingSource1.DataSource = this.donaHuellasDataSet10;
            // 
            // donanteTableAdapter1
            // 
            this.donanteTableAdapter1.ClearBeforeFill = true;
            // 
            // donaHuellasDataSet11
            // 
            this.donaHuellasDataSet11.DataSetName = "donaHuellasDataSet11";
            this.donaHuellasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "proyecto";
            this.proyectoBindingSource.DataSource = this.donaHuellasDataSet11;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // FormAportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 780);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAportes";
            this.Text = "FormAportes";
            this.Load += new System.EventHandler(this.FormAportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tablaPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spnMonto;
        private System.Windows.Forms.ComboBox cbProyectos;
        private System.Windows.Forms.ComboBox cbDonantes;
        private donaHuellasDataSet9 donaHuellasDataSet9;
        private System.Windows.Forms.BindingSource donanteBindingSource;
        private donaHuellasDataSet9TableAdapters.donanteTableAdapter donanteTableAdapter;
        private donaHuellasDataSet10 donaHuellasDataSet10;
        private System.Windows.Forms.BindingSource donanteBindingSource1;
        private donaHuellasDataSet10TableAdapters.donanteTableAdapter donanteTableAdapter1;
        private donaHuellasDataSet11 donaHuellasDataSet11;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private donaHuellasDataSet11TableAdapters.proyectoTableAdapter proyectoTableAdapter;
    }
}