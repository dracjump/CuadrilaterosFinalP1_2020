namespace Cuadrilateros.Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.mayMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnLadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLadoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLadoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLadoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbOrdenar,
            this.tsbActualizar,
            this.toolStripSeparator2,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(22, 99);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNuevo.Image = global::Cuadrilateros.Presentacion.Properties.Resources.new_copy_36px;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(64, 47);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(29, 47);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEditar.Image = global::Cuadrilateros.Presentacion.Properties.Resources.edit_36px;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(58, 47);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayMenorToolStripMenuItem,
            this.perimetroToolStripMenuItem});
            this.tsbOrdenar.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbOrdenar.Image = global::Cuadrilateros.Presentacion.Properties.Resources.Order_History_36px;
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(87, 47);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOrdenar.Click += new System.EventHandler(this.tsbOrdenar_Click);
            // 
            // mayMenorToolStripMenuItem
            // 
            this.mayMenorToolStripMenuItem.Name = "mayMenorToolStripMenuItem";
            this.mayMenorToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.mayMenorToolStripMenuItem.Text = "May-Menor";
            this.mayMenorToolStripMenuItem.Click += new System.EventHandler(this.mayMenorToolStripMenuItem_Click);
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbActualizar.Image = global::Cuadrilateros.Presentacion.Properties.Resources.update_36px;
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(89, 47);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbActualizar.Click += new System.EventHandler(this.tsbActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSalir.Image = global::Cuadrilateros.Presentacion.Properties.Resources.exit_36px;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(46, 47);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(22, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 690);
            this.panel1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnLadoA,
            this.cmnLadoB,
            this.cmnLadoC,
            this.cmnLadoD,
            this.cmnPerimetro,
            this.cmnArea});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(874, 690);
            this.dgvDatos.TabIndex = 0;
            // 
            // cmnLadoA
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnLadoA.DefaultCellStyle = dataGridViewCellStyle8;
            this.cmnLadoA.HeaderText = "LadoA";
            this.cmnLadoA.MinimumWidth = 6;
            this.cmnLadoA.Name = "cmnLadoA";
            this.cmnLadoA.ReadOnly = true;
            this.cmnLadoA.Width = 125;
            // 
            // cmnLadoB
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnLadoB.DefaultCellStyle = dataGridViewCellStyle9;
            this.cmnLadoB.HeaderText = "LadoB";
            this.cmnLadoB.MinimumWidth = 6;
            this.cmnLadoB.Name = "cmnLadoB";
            this.cmnLadoB.ReadOnly = true;
            this.cmnLadoB.Width = 125;
            // 
            // cmnLadoC
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnLadoC.DefaultCellStyle = dataGridViewCellStyle10;
            this.cmnLadoC.HeaderText = "LadoC";
            this.cmnLadoC.MinimumWidth = 6;
            this.cmnLadoC.Name = "cmnLadoC";
            this.cmnLadoC.ReadOnly = true;
            this.cmnLadoC.Width = 125;
            // 
            // cmnLadoD
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnLadoD.DefaultCellStyle = dataGridViewCellStyle11;
            this.cmnLadoD.HeaderText = "LadoD";
            this.cmnLadoD.MinimumWidth = 6;
            this.cmnLadoD.Name = "cmnLadoD";
            this.cmnLadoD.ReadOnly = true;
            this.cmnLadoD.Width = 125;
            // 
            // cmnPerimetro
            // 
            this.cmnPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnPerimetro.DefaultCellStyle = dataGridViewCellStyle12;
            this.cmnPerimetro.HeaderText = "Perimetro";
            this.cmnPerimetro.MinimumWidth = 6;
            this.cmnPerimetro.Name = "cmnPerimetro";
            this.cmnPerimetro.ReadOnly = true;
            // 
            // cmnArea
            // 
            this.cmnArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnArea.DefaultCellStyle = dataGridViewCellStyle13;
            this.cmnArea.HeaderText = "Área";
            this.cmnArea.MinimumWidth = 6;
            this.cmnArea.Name = "cmnArea";
            this.cmnArea.ReadOnly = true;
            // 
            // perimetroToolStripMenuItem
            // 
            this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
            this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.perimetroToolStripMenuItem.Text = "Perimetro-Asc";
            this.perimetroToolStripMenuItem.Click += new System.EventHandler(this.perimetroToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 869);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(22, 99, 22, 30);
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStripMenuItem mayMenorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLadoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnArea;
        private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
    }
}

