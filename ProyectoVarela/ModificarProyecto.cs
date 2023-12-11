using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoVarela
{
    public partial class ModificarProyecto : Form
    {
        public ModificarProyecto()
        {
            InitializeComponent();
        }

        private void DatosMateriales()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ; Initial Catalog=laminadoVarela; Integrated Security = True"))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Id_Material, Cantidad_Necesaria FROM " +
                                        "MATERIALES_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["Id_Material"].ToString());
                            item.SubItems.Add(row["Cantidad_Necesaria"].ToString());
                            listViewMateriales.Items.Add(item);
                        }

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void DatosHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ; Initial Catalog = laminadoVarela; Integrated Security = True"))
            {
                try
                {
                    conexion.Open();

                    string consulta = " SELECT Id_Herramienta, Cantidad_Necesaria " +
                        "FROM HERRAMIENTAS_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["Id_Herramienta"].ToString());
                            item.SubItems.Add(row["Cantidad_Necesaria"].ToString());
                            listViewHerramientas.Items.Add(item);
                        }

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void DatosProyecto()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ; Initial Catalog=laminadoVarela; Integrated Security=True"))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Nombre_Proyecto, NomCliente FROM PROYECTO WHERE Id_Proyecto=@Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("Id_Proyecto", txtId_Proyecto.Text);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombreProyecto = reader["Nombre_Proyecto"].ToString();
                                string nomCliente = reader["NomCliente"].ToString();

                                txtNombreProyecto.Text = nombreProyecto;
                                txtNombreCliente.Text = nomCliente;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosProyecto();
            DatosMateriales();
            DatosHerramientas();
            CargarComboBoxMateriales();
            CargarComboBoxHerramientas();
        }

        public void CargarComboBoxMateriales()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {
                conexion.Open();

                string consulta = "SELECT IDMATERIAL FROM MATERIAL;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idMaterial = reader["IDMATERIAL"].ToString();

                            cbMateriales.Items.Add(idMaterial);
                        }
                    }
                }
            }
        }

        public void CargarComboBoxHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {
                conexion.Open();

                string consulta = "SELECT IDHERRAMIENTAS FROM HERRAMIENTAS;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idHerramienta = reader["IDHERRAMIENTAS"].ToString();

                            cbHerramientas.Items.Add(idHerramienta);
                        }
                    }
                }
            }
        }

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {

        }

        private void btnAnadirMateriales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMateriales.Text) || string.IsNullOrEmpty(txtCantidadM.Text))
            {
                return;
            }

            //using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            //{
            //        conexion.Open();
                        
            //            string consulta = "INSERT INTO MATERIALES_PROYECTOS (Id_Material, Cantidad_Necesaria, Id_Proyecto) " +
            //                        "VALUES(@Id_Material, @Cantidad_Necesaria, @Id_Proyecto);";

            //            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            //            {
            //                comando.Parameters.AddWithValue("@Id_Material", cbMateriales.Text);
            //                comando.Parameters.AddWithValue("@Cantidad_Necesaria", txtCantidadM.Text);
            //                comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

            //                comando.ExecuteNonQuery();
            //            }

            //}

            ListViewItem item = new ListViewItem(cbMateriales.Text);
            item.SubItems.Add(txtCantidadM.Text);

            listViewMateriales.Items.Add(item);
            txtCantidadM.Clear();
        }

        private void btnAnadirHerramienta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbHerramientas.Text) || string.IsNullOrEmpty(txtCantidadH.Text))
            {
                return;
            }

            //using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            //{
            //    conexion.Open();

            //    string consulta = "INSERT INTO HERRAMIENTAS_PROYECTOS (Id_Herramienta, Cantidad_Necesaria, Id_Proyecto) " +
            //                        "VALUES(@Id_Herramienta, @Cantidad_Necesaria, @Id_Proyecto);";

            //    using (SqlCommand comando = new SqlCommand(consulta, conexion))
            //    {
            //        comando.Parameters.AddWithValue("@Id_Material", cbHerramientas.Text);
            //        comando.Parameters.AddWithValue("@Cantidad_Necesaria", txtCantidadH.Text);
            //        comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

            //        comando.ExecuteNonQuery();
            //    }

            //}

            ListViewItem item = new ListViewItem(cbHerramientas.Text);
            item.SubItems.Add(txtCantidadH.Text);

            listViewHerramientas.Items.Add(item);
            txtCantidadH.Clear();
        }

        private void EliminarDatosObsoletos()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {
                    conexion.Open();

                        string consulta = "DELETE FROM MATERIALES_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;" +
                                "DELETE FROM HERRAMIENTAS_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;" +
                                "DELETE FROM PROYECTO WHERE Id_Proyecto = @Id_Proyecto;";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EliminarDatosObsoletos();
            RegistrarProyecto();
            RegistrarMateriales();
            RegistrarHerramientas();
        }

        private void RegistrarMateriales()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {

                try
                {
                    conexion.Open();

                    foreach (ListViewItem item in listViewMateriales.Items)
                    {

                        string id_material = item.SubItems[0].Text;
                        int cantidadM = Convert.ToInt32(item.SubItems[1].Text);

                        string consulta = "INSERT INTO MATERIALES_PROYECTOS (Id_Material, Cantidad_Necesaria, Id_Proyecto) " +
                                    "VALUES(@Id_Material, @Cantidad_Necesaria, @Id_Proyecto);";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Material", id_material);
                            comando.Parameters.AddWithValue("@Cantidad_Necesaria", cantidadM);
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos agregados a la base de datos correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void RegistrarHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {

                try
                {
                    conexion.Open();

                    foreach (ListViewItem item in listViewHerramientas.Items)
                    {

                        string id_herramienta = item.SubItems[0].Text;
                        int cantidadH = Convert.ToInt32(item.SubItems[1].Text);

                        string consulta = "INSERT INTO HERRAMIENTAS_PROYECTOS (Id_Herramienta, Cantidad_Necesaria, Id_Proyecto) " +
                                    "VALUES(@Id_Herramienta, @Cantidad_Necesaria, @Id_Proyecto);";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Herramienta", id_herramienta);
                            comando.Parameters.AddWithValue("@Cantidad_Necesaria", cantidadH);
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void RegistrarProyecto()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
            {

                try
                {
                    conexion.Open();

                    string consulta = "INSERT INTO PROYECTO (Id_Proyecto, NomCliente, Nombre_Proyecto) " +
                                "VALUES(@IdProyecto, @NombCliente, @Nombre_Proyecto);";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProyecto", txtId_Proyecto.Text);
                        comando.Parameters.AddWithValue("@NombCliente", txtNombreCliente.Text);
                        comando.Parameters.AddWithValue("@Nombre_Proyecto", txtNombreProyecto.Text);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            if (listViewMateriales.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewMateriales.SelectedItems)
                {
                    listViewMateriales.Items.Remove(item);
                    //using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-PCHPOMJ;Initial Catalog=laminadoVarela;Integrated Security=True"))
                    //{
                    //    conexion.Open();

                    //    string consulta = "DELETE FROM MATERIALES_PROYECTOS WHERE Id_Material = @Id_Material;";

                    //    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    //    {
                    //        comando.Parameters.AddWithValue("@Id_Material", item.Text);

                    //        comando.ExecuteNonQuery();
                    //    }
                    //}
                }
            }
        }

        private void btnEliminarH_Click(object sender, EventArgs e)
        {
            if (listViewHerramientas.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewHerramientas.SelectedItems)
                {
                    listViewHerramientas.Items.Remove(item);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proyecto proy = new Proyecto();
            proy.ShowDialog();
        }
    }
}
