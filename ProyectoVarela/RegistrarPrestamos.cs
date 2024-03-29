﻿using ProyectoVarela.Entidades;
using ProyectoVarela.Utilerias;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistrarPrestamos : Form
    {
        private List<Prestamo> Prestamos
        {
            get;
            set;
        } = new List<Prestamo>();

        public RegistrarPrestamos()
        {
            InitializeComponent();

            LlenarComboBoxEmpleados();
            LlenarComboBoxHerrramientas();
        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarComboBoxEmpleados()
        {
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                string query = "SELECT IdEmpleado, Nombre FROM Empleados ORDER BY Nombre";

                SqlDataAdapter da = new SqlDataAdapter(query, SqlHelper.GetConnectionString());

                cn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "Empleados");

                cboEmpleados.DisplayMember = "Nombre";
                cboEmpleados.ValueMember = "IdEmpleado";
                cboEmpleados.DataSource = ds.Tables["Empleados"];
            }
        }

        private void LlenarComboBoxHerrramientas()
        {
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                string query = "SELECT IdHerramientas, Nombre FROM Herramientas ORDER BY Nombre";

                SqlDataAdapter da = new SqlDataAdapter(query, SqlHelper.GetConnectionString());

                cn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "Herramientas");

                cboHerramientas.DisplayMember = "Nombre";
                cboHerramientas.ValueMember = "IdHerramientas";
                cboHerramientas.DataSource = ds.Tables["Herramientas"];
            }                
        }

        private void aceptar_Btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();

                string existencia = "SELECT ExistenciaH FROM Herramientas WHERE IdHerramientas = @IdHerramienta";
                
                SqlCommand cmdExistencia = new SqlCommand(existencia, cn);
                
                cmdExistencia.Parameters.AddWithValue("@IdHerramienta", cboHerramientas.SelectedValue.ToString());
                
                int countExistencia = (int)cmdExistencia.ExecuteScalar();
                
                if (countExistencia >= Convert.ToInt32(cantidad_UpDown.Value))
                {
                    Prestamo prestamo = new Prestamo()
                    {
                        FechaRegistro = fechaprestamo_Datepicker.Value,
                        FechaEntrega = fechadevolucion_Datepicker.Value,
                        IdEmpleado = (int)cboEmpleados.SelectedValue,
                        IdHerramienta = cboHerramientas.SelectedValue.ToString(),
                        NombreHerramienta = cboHerramientas.Text,
                        Cantidad = Convert.ToInt32(cantidad_UpDown.Value)
                    };

                    Prestamos.Add(prestamo);

                    dataGridViewPrestamos.DataSource = null;

                    dataGridViewPrestamos.DataSource = Prestamos;
                }
                else
                {
                    MessageBox.Show("NO HAY CANTIDAD DISPONIBLE PARA LA HERRAMIENTA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
        }

        private void registrar_Btn_Click(object sender, EventArgs e)
        {
            if (Prestamos.Count == 0)
            {
                MessageBox.Show("AGREGA HERRAMIENTAS AL PRESTAMO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();

                foreach (Prestamo prestamo in Prestamos)
                {
                    string query = "INSERT INTO Prestamos(FechaRegistro, FehaEntrega, IdHerramientas, IdEmpleado, Cantidad, Status) VALUES (@FechaRegistro, @FechaEntrega, @IdHerramienta, @IdEmpleado, @Cantidad, 'Activo')";
                    
                    SqlCommand cmd = new SqlCommand(query, cn);

                    string updateExistenciaQuery = "UPDATE Herramientas SET ExistenciaH = ExistenciaH - @Cantidad WHERE IdHerramientas = @IdHerramienta";

                    SqlCommand cmdUpdateExistencia = new SqlCommand(updateExistenciaQuery, cn);
                    cmdUpdateExistencia.Parameters.AddWithValue("@IdHerramienta", prestamo.IdHerramienta);
                    cmdUpdateExistencia.Parameters.AddWithValue("@Cantidad", prestamo.Cantidad);
                    cmdUpdateExistencia.ExecuteNonQuery();

                    DateTime fechaRegistro = fechaprestamo_Datepicker.Value;
                    string fechaRegistroFormateada = fechaRegistro.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistroFormateada);

                    DateTime fechaEntrega = fechadevolucion_Datepicker.Value;
                    string fechaEntregaFormateada = fechaEntrega.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntregaFormateada);

                    cmd.Parameters.AddWithValue("@IdHerramienta", prestamo.IdHerramienta);
                    cmd.Parameters.AddWithValue("@IdEmpleado", prestamo.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Cantidad", prestamo.Cantidad);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("REGISTRO DE HERRAMIENTAS REALIZADO.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void fechaprestamo_Datepicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}