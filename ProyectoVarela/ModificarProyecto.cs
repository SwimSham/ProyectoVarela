using ProyectoVarela.Utilerias;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ModificarProyecto : Form
    {
        public ModificarProyecto()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idproyecto.Text))
            {
                MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                string query = "SELECT PROYECTOS WHERE Id_Proyecto = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", txt_idproyecto.Text);
                cn.Open();
                // Obtener datos para la primera tabla
                DataTable tabla1 = ObtenerDatosDesdeBD(cn, "SELECT * FROM PROYECTO WHERE Id_Proyecto =@ID");
                MostrarDatosEnDataGridView(tabla1, dataGridView1);

                // Obtener datos para la segunda tabla
                DataTable tabla2 = ObtenerDatosDesdeBD(cn, "SELECT * FROM MATERIALES_PROYECTOS WHERE Id_Proyecto =@ID");
                MostrarDatosEnDataGridView(tabla2, dataGridView2);

                // Obtener datos para la tercera tabla
                DataTable tabla3 = ObtenerDatosDesdeBD(cn, "SELECT * FROM HERRAMIENTAS_PROYECTOS WHERE Id_Proyecto =@ID");
                MostrarDatosEnDataGridView(tabla3, dataGridView3);
             
            }
        }

        private DataTable ObtenerDatosDesdeBD(SqlConnection cn, string consulta)
        {
            DataTable resultado = new DataTable();

            using (SqlCommand comando = new SqlCommand(consulta, cn))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(resultado);
                }
            }

            return resultado;
        }

        private void MostrarDatosEnDataGridView(DataTable datos, DataGridView dataGridView)
        {
            // Limpia las filas existentes en el DataGridView
            dataGridView.Rows.Clear();

            // Agrega las columnas al DataGridView
            foreach (DataColumn columna in datos.Columns)
            {
                dataGridView.Columns.Add(columna.ColumnName, columna.ColumnName);
            }

            // Agrega las filas al DataGridView
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView.Rows.Add(fila.ItemArray);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
  