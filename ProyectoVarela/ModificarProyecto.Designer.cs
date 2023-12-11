namespace ProyectoVarela
{
    partial class ModificarProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProyecto));
            this.listViewHerramientas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnadirMateriales = new System.Windows.Forms.Button();
            this.txtCantidadM = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewMateriales = new System.Windows.Forms.ListView();
            this.Id_Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHerramientas = new System.Windows.Forms.ComboBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.btnAnadirHerramienta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Proyecto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHerramientas
            // 
            this.listViewHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.listViewHerramientas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewHerramientas.HideSelection = false;
            this.listViewHerramientas.Location = new System.Drawing.Point(257, 233);
            this.listViewHerramientas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewHerramientas.Name = "listViewHerramientas";
            this.listViewHerramientas.Size = new System.Drawing.Size(232, 166);
            this.listViewHerramientas.TabIndex = 63;
            this.listViewHerramientas.UseCompatibleStateImageBehavior = false;
            this.listViewHerramientas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id_Herramienta";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad Herramienta";
            this.columnHeader2.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "MATERIALES:";
            // 
            // btnAnadirMateriales
            // 
            this.btnAnadirMateriales.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirMateriales.Location = new System.Drawing.Point(162, 194);
            this.btnAnadirMateriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirMateriales.Name = "btnAnadirMateriales";
            this.btnAnadirMateriales.Size = new System.Drawing.Size(65, 25);
            this.btnAnadirMateriales.TabIndex = 61;
            this.btnAnadirMateriales.Text = "Añadir";
            this.btnAnadirMateriales.UseVisualStyleBackColor = false;
            this.btnAnadirMateriales.Click += new System.EventHandler(this.btnAnadirMateriales_Click);
            // 
            // txtCantidadM
            // 
            this.txtCantidadM.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM.Location = new System.Drawing.Point(100, 170);
            this.txtCantidadM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadM.Name = "txtCantidadM";
            this.txtCantidadM.Size = new System.Drawing.Size(130, 20);
            this.txtCantidadM.TabIndex = 60;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(32, 173);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 13);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // cbMateriales
            // 
            this.cbMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.cbMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(100, 139);
            this.cbMateriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(130, 21);
            this.cbMateriales.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "ID MATERIAL:";
            // 
            // txtCantidadH
            // 
            this.txtCantidadH.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadH.Location = new System.Drawing.Point(359, 170);
            this.txtCantidadH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadH.Name = "txtCantidadH";
            this.txtCantidadH.Size = new System.Drawing.Size(130, 20);
            this.txtCantidadH.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "CANTIDAD:";
            // 
            // listViewMateriales
            // 
            this.listViewMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.listViewMateriales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Material,
            this.CantidadM});
            this.listViewMateriales.HideSelection = false;
            this.listViewMateriales.Location = new System.Drawing.Point(22, 233);
            this.listViewMateriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewMateriales.Name = "listViewMateriales";
            this.listViewMateriales.Size = new System.Drawing.Size(205, 166);
            this.listViewMateriales.TabIndex = 54;
            this.listViewMateriales.UseCompatibleStateImageBehavior = false;
            this.listViewMateriales.View = System.Windows.Forms.View.Details;
            // 
            // Id_Material
            // 
            this.Id_Material.Text = "Id_Material";
            this.Id_Material.Width = 91;
            // 
            // CantidadM
            // 
            this.CantidadM.Text = "Cantidad Material";
            this.CantidadM.Width = 102;
            // 
            // cbHerramientas
            // 
            this.cbHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.cbHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHerramientas.FormattingEnabled = true;
            this.cbHerramientas.Location = new System.Drawing.Point(359, 139);
            this.cbHerramientas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHerramientas.Name = "cbHerramientas";
            this.cbHerramientas.Size = new System.Drawing.Size(130, 21);
            this.cbHerramientas.TabIndex = 53;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(30, 77);
            this.lblNombreProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(119, 13);
            this.lblNombreProyecto.TabIndex = 52;
            this.lblNombreProyecto.Text = "NOMBRE PROYECTO:";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProyecto.Location = new System.Drawing.Point(156, 75);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(165, 20);
            this.txtNombreProyecto.TabIndex = 51;
            // 
            // btnAnadirHerramienta
            // 
            this.btnAnadirHerramienta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirHerramienta.Location = new System.Drawing.Point(421, 194);
            this.btnAnadirHerramienta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirHerramienta.Name = "btnAnadirHerramienta";
            this.btnAnadirHerramienta.Size = new System.Drawing.Size(65, 25);
            this.btnAnadirHerramienta.TabIndex = 50;
            this.btnAnadirHerramienta.Text = "Añadir";
            this.btnAnadirHerramienta.UseVisualStyleBackColor = false;
            this.btnAnadirHerramienta.Click += new System.EventHandler(this.btnAnadirHerramienta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(421, 414);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 25);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(344, 414);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "ID_HERRAMIENTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "HERRAMIENTAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "NOMBRE CLIENTE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Location = new System.Drawing.Point(156, 47);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(165, 20);
            this.txtNombreCliente.TabIndex = 44;
            // 
            // btnEliminarH
            // 
            this.btnEliminarH.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarH.Location = new System.Drawing.Point(344, 194);
            this.btnEliminarH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarH.Name = "btnEliminarH";
            this.btnEliminarH.Size = new System.Drawing.Size(65, 25);
            this.btnEliminarH.TabIndex = 65;
            this.btnEliminarH.Text = "Eliminar";
            this.btnEliminarH.UseVisualStyleBackColor = false;
            this.btnEliminarH.Click += new System.EventHandler(this.btnEliminarH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID PROYECTO:";
            // 
            // txtId_Proyecto
            // 
            this.txtId_Proyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtId_Proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId_Proyecto.Location = new System.Drawing.Point(117, 17);
            this.txtId_Proyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId_Proyecto.Name = "txtId_Proyecto";
            this.txtId_Proyecto.Size = new System.Drawing.Size(165, 20);
            this.txtId_Proyecto.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(286, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 25);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Location = new System.Drawing.Point(84, 194);
            this.btnEliminarM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(65, 25);
            this.btnEliminarM.TabIndex = 70;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.txtNombreProyecto);
            this.panel1.Controls.Add(this.txtId_Proyecto);
            this.panel1.Controls.Add(this.btnEliminarM);
            this.panel1.Controls.Add(this.listViewMateriales);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.listViewHerramientas);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnEliminarH);
            this.panel1.Controls.Add(this.txtCantidadH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbHerramientas);
            this.panel1.Controls.Add(this.cbMateriales);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAnadirHerramienta);
            this.panel1.Controls.Add(this.txtCantidadM);
            this.panel1.Controls.Add(this.btnAnadirMateriales);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNombreProyecto);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarProyecto";
            this.Text = "Modificar Proyecto | VARELA";
            this.Load += new System.EventHandler(this.ModificarProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHerramientas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnadirMateriales;
        private System.Windows.Forms.TextBox txtCantidadM;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewMateriales;
        private System.Windows.Forms.ColumnHeader Id_Material;
        private System.Windows.Forms.ColumnHeader CantidadM;
        private System.Windows.Forms.ComboBox cbHerramientas;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Button btnAnadirHerramienta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnEliminarH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_Proyecto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Panel panel1;
    }
}