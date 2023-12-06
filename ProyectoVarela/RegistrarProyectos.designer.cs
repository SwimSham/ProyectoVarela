﻿namespace ProyectoVarela
{
    partial class RegistrarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProyectos));
            this.txtId_Proyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAnadirHerramienta = new System.Windows.Forms.Button();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.cbHerramientas = new System.Windows.Forms.ComboBox();
            this.listViewMateriales = new System.Windows.Forms.ListView();
            this.Id_Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCantidadH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnadirMateriales = new System.Windows.Forms.Button();
            this.txtCantidadM = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewHerramientas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtId_Proyecto
            // 
            this.txtId_Proyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtId_Proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId_Proyecto.Location = new System.Drawing.Point(211, 33);
            this.txtId_Proyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_Proyecto.Name = "txtId_Proyecto";
            this.txtId_Proyecto.Size = new System.Drawing.Size(218, 22);
            this.txtId_Proyecto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID PROYECTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE CLIENTE";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Location = new System.Drawing.Point(211, 62);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(218, 22);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(467, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "HERRAMIENTAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(352, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID HERRAMIENTA";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(41, 453);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 31);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(583, 453);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 31);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAnadirHerramienta
            // 
            this.btnAnadirHerramienta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirHerramienta.Location = new System.Drawing.Point(585, 249);
            this.btnAnadirHerramienta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnadirHerramienta.Name = "btnAnadirHerramienta";
            this.btnAnadirHerramienta.Size = new System.Drawing.Size(80, 31);
            this.btnAnadirHerramienta.TabIndex = 22;
            this.btnAnadirHerramienta.Text = "Añadir";
            this.btnAnadirHerramienta.UseVisualStyleBackColor = false;
            this.btnAnadirHerramienta.Click += new System.EventHandler(this.btnAnadirHerramienta_Click);
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNombreProyecto.Location = new System.Drawing.Point(37, 92);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(144, 16);
            this.lblNombreProyecto.TabIndex = 25;
            this.lblNombreProyecto.Text = "NOMBRE PROYECTO";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BackColor = System.Drawing.Color.LightGreen;
            this.txtNombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProyecto.Location = new System.Drawing.Point(211, 89);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(218, 22);
            this.txtNombreProyecto.TabIndex = 24;
            // 
            // cbHerramientas
            // 
            this.cbHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.cbHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHerramientas.FormattingEnabled = true;
            this.cbHerramientas.Location = new System.Drawing.Point(489, 185);
            this.cbHerramientas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHerramientas.Name = "cbHerramientas";
            this.cbHerramientas.Size = new System.Drawing.Size(172, 24);
            this.cbHerramientas.TabIndex = 27;
            // 
            // listViewMateriales
            // 
            this.listViewMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.listViewMateriales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMateriales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Material,
            this.CantidadM});
            this.listViewMateriales.HideSelection = false;
            this.listViewMateriales.Location = new System.Drawing.Point(41, 305);
            this.listViewMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewMateriales.Name = "listViewMateriales";
            this.listViewMateriales.Size = new System.Drawing.Size(273, 142);
            this.listViewMateriales.TabIndex = 30;
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
            // txtCantidadH
            // 
            this.txtCantidadH.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadH.Location = new System.Drawing.Point(491, 222);
            this.txtCantidadH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadH.Name = "txtCantidadH";
            this.txtCantidadH.Size = new System.Drawing.Size(173, 22);
            this.txtCantidadH.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(352, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "CANTIDAD:";
            // 
            // btnAnadirMateriales
            // 
            this.btnAnadirMateriales.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnadirMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirMateriales.Location = new System.Drawing.Point(235, 249);
            this.btnAnadirMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnadirMateriales.Name = "btnAnadirMateriales";
            this.btnAnadirMateriales.Size = new System.Drawing.Size(80, 31);
            this.btnAnadirMateriales.TabIndex = 41;
            this.btnAnadirMateriales.Text = "Añadir";
            this.btnAnadirMateriales.UseVisualStyleBackColor = false;
            this.btnAnadirMateriales.Click += new System.EventHandler(this.btnAnadirMateriales_Click);
            // 
            // txtCantidadM
            // 
            this.txtCantidadM.BackColor = System.Drawing.Color.LightGreen;
            this.txtCantidadM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM.Location = new System.Drawing.Point(141, 220);
            this.txtCantidadM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadM.Name = "txtCantidadM";
            this.txtCantidadM.Size = new System.Drawing.Size(173, 22);
            this.txtCantidadM.TabIndex = 40;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCantidad.Location = new System.Drawing.Point(37, 226);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 16);
            this.lblCantidad.TabIndex = 39;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // cbMateriales
            // 
            this.cbMateriales.BackColor = System.Drawing.Color.LightGreen;
            this.cbMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(141, 182);
            this.cbMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(172, 24);
            this.cbMateriales.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(37, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "ID MATERIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(117, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "MATERIALES";
            // 
            // listViewHerramientas
            // 
            this.listViewHerramientas.BackColor = System.Drawing.Color.LightGreen;
            this.listViewHerramientas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewHerramientas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewHerramientas.HideSelection = false;
            this.listViewHerramientas.Location = new System.Drawing.Point(356, 305);
            this.listViewHerramientas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewHerramientas.Name = "listViewHerramientas";
            this.listViewHerramientas.Size = new System.Drawing.Size(309, 142);
            this.listViewHerramientas.TabIndex = 43;
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
            this.columnHeader2.Width = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 494);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegistrarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 487);
            this.Controls.Add(this.listViewHerramientas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnadirMateriales);
            this.Controls.Add(this.txtCantidadM);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbMateriales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listViewMateriales);
            this.Controls.Add(this.cbHerramientas);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.btnAnadirHerramienta);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId_Proyecto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Proyectos | VARELA";
            this.Load += new System.EventHandler(this.RegistrarProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId_Proyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAnadirHerramienta;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.ComboBox cbHerramientas;
        private System.Windows.Forms.ListView listViewMateriales;
        private System.Windows.Forms.ColumnHeader Id_Material;
        private System.Windows.Forms.ColumnHeader CantidadM;
        private System.Windows.Forms.TextBox txtCantidadH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnadirMateriales;
        private System.Windows.Forms.TextBox txtCantidadM;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewHerramientas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
    }
}