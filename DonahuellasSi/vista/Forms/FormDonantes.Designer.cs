namespace DonahuellasSi.vista.Forms
{
    partial class FormDonantes
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
            this.tablaDonantes = new System.Windows.Forms.DataGridView();
            this.iddonanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredonanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonodonanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutdonanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donaHuellasDataSet5 = new DonahuellasSi.donaHuellasDataSet5();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.donanteTableAdapter = new DonahuellasSi.donaHuellasDataSet5TableAdapters.donanteTableAdapter();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtRut = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDonantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 634);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tablaDonantes);
            this.panel4.Location = new System.Drawing.Point(3, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1249, 389);
            this.panel4.TabIndex = 2;
            // 
            // tablaDonantes
            // 
            this.tablaDonantes.AutoGenerateColumns = false;
            this.tablaDonantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDonantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.tablaDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDonantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddonanteDataGridViewTextBoxColumn,
            this.nombredonanteDataGridViewTextBoxColumn,
            this.telefonodonanteDataGridViewTextBoxColumn,
            this.rutdonanteDataGridViewTextBoxColumn});
            this.tablaDonantes.DataSource = this.donanteBindingSource;
            this.tablaDonantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDonantes.Location = new System.Drawing.Point(0, 0);
            this.tablaDonantes.Name = "tablaDonantes";
            this.tablaDonantes.RowHeadersWidth = 51;
            this.tablaDonantes.Size = new System.Drawing.Size(1249, 389);
            this.tablaDonantes.TabIndex = 0;
            this.tablaDonantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDonantes_CellContentClick);
            // 
            // iddonanteDataGridViewTextBoxColumn
            // 
            this.iddonanteDataGridViewTextBoxColumn.DataPropertyName = "id_donante";
            this.iddonanteDataGridViewTextBoxColumn.HeaderText = "id_donante";
            this.iddonanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddonanteDataGridViewTextBoxColumn.Name = "iddonanteDataGridViewTextBoxColumn";
            this.iddonanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombredonanteDataGridViewTextBoxColumn
            // 
            this.nombredonanteDataGridViewTextBoxColumn.DataPropertyName = "nombre_donante";
            this.nombredonanteDataGridViewTextBoxColumn.HeaderText = "nombre_donante";
            this.nombredonanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombredonanteDataGridViewTextBoxColumn.Name = "nombredonanteDataGridViewTextBoxColumn";
            // 
            // telefonodonanteDataGridViewTextBoxColumn
            // 
            this.telefonodonanteDataGridViewTextBoxColumn.DataPropertyName = "telefono_donante";
            this.telefonodonanteDataGridViewTextBoxColumn.HeaderText = "telefono_donante";
            this.telefonodonanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonodonanteDataGridViewTextBoxColumn.Name = "telefonodonanteDataGridViewTextBoxColumn";
            // 
            // rutdonanteDataGridViewTextBoxColumn
            // 
            this.rutdonanteDataGridViewTextBoxColumn.DataPropertyName = "rut_donante";
            this.rutdonanteDataGridViewTextBoxColumn.HeaderText = "rut_donante";
            this.rutdonanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rutdonanteDataGridViewTextBoxColumn.Name = "rutdonanteDataGridViewTextBoxColumn";
            // 
            // donanteBindingSource
            // 
            this.donanteBindingSource.DataMember = "donante";
            this.donanteBindingSource.DataSource = this.donaHuellasDataSet5;
            // 
            // donaHuellasDataSet5
            // 
            this.donaHuellasDataSet5.DataSetName = "donaHuellasDataSet5";
            this.donaHuellasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.txtRut);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Location = new System.Drawing.Point(3, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1249, 164);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(39, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 16);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id del donante: ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Location = new System.Drawing.Point(1165, 138);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(1165, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizar.Location = new System.Drawing.Point(1165, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 25);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(1165, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 67);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1243, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Donantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donanteTableAdapter
            // 
            this.donanteTableAdapter.ClearBeforeFill = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(42, 119);
            this.txtTelefono.Mask = "+56 9 0000 0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(354, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(625, 69);
            this.txtRut.Mask = "00.000.000-0";
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(354, 20);
            this.txtRut.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(42, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // FormDonantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 634);
            this.Controls.Add(this.panel1);
            this.Name = "FormDonantes";
            this.Text = "FormDonantes";
            this.Load += new System.EventHandler(this.FormDonantes_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDonantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaHuellasDataSet5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tablaDonantes;
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
        private donaHuellasDataSet5 donaHuellasDataSet5;
        private System.Windows.Forms.BindingSource donanteBindingSource;
        private donaHuellasDataSet5TableAdapters.donanteTableAdapter donanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddonanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredonanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonodonanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutdonanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtRut;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}