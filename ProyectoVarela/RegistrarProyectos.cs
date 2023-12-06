using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistrarProyectos : Form
    {
        public RegistrarProyectos()
        {
            InitializeComponent();
        }

        private void RegistrarMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
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
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
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
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProyecto();
            RegistrarMateriales();
            RegistrarHerramientas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CargarComboBoxMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
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

        private void CargarComboBoxHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
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

        private void RegistrarProyectos_Load(object sender, EventArgs e)
        {
            CargarComboBoxMateriales();
            CargarComboBoxHerramientas();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAnadirMateriales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMateriales.Text) || string.IsNullOrEmpty(txtCantidadM.Text))
            {
                return;
            }

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

            ListViewItem item = new ListViewItem(cbHerramientas.Text);
            item.SubItems.Add(txtCantidadH.Text);

            listViewHerramientas.Items.Add(item);
            txtCantidadH.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
