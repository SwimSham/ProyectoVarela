using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class V : Form
    {
        public V()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txt_idmaterial.Text))
                {
                    MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "SELECT MATERIAL,TIPO,CALIBRE,MEDIDA,EXISTENCIA FROM MATERIAL WHERE IDMATERIAL = @ID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@ID", txt_idmaterial.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lbl_material.Text = reader["MATERIAL"].ToString();
                        lbl_tipo.Text = reader["TIPO"].ToString();
                        lbl_calibre.Text = reader["CALIBRE"].ToString();
                        lbl_medida.Text = reader["MEDIDA"].ToString();
                        lbl_existencia.Text = reader["EXISTENCIA"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void V_Load(object sender, EventArgs e)
        {

        }

        private void btm_modificar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_material.Text)
                    && string.IsNullOrEmpty(txt_tipo.Text)
                    && string.IsNullOrEmpty(txt_calibre.Text)
                     && string.IsNullOrEmpty(txt_medida.Text)
                      && string.IsNullOrEmpty(txt_existencia.Text))

                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_material.Text))
                {
                    txt_material.Text = lbl_material.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_tipo.Text))
                {
                    txt_tipo.Text = lbl_tipo.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_calibre.Text))
                {
                    txt_calibre.Text = lbl_calibre.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_medida.Text))
                {
                    txt_medida.Text = lbl_medida.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_existencia.Text))
                {
                    txt_existencia.Text = lbl_existencia.Text;
                    return;
                }


                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "UPDATE MATERIAL SET MATERIAL = @material,TIPO = @tipo,CALIBRE = @calibre,MEDIDA =@medida,EXISTENCIA = @existencia WHERE IDMATERIAL = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", txt_idmaterial.Text);
                    cmd.Parameters.AddWithValue("@material", txt_material.Text);
                    cmd.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                    cmd.Parameters.AddWithValue("@calibre", txt_calibre.Text);
                    cmd.Parameters.AddWithValue("@medida", txt_medida.Text);
                    cmd.Parameters.AddWithValue("@existencia", txt_existencia.Text);
                    int filasActualizadas = cmd.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("SE ACTUALIZÓ CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ConsultarMaterial modificar = new ConsultarMaterial();
                        modificar.Show();

                        lbl_material.Text = string.Empty;
                        lbl_tipo.Text = string.Empty;
                        lbl_medida.Text = string.Empty;
                        lbl_calibre.Text = string.Empty;
                        lbl_existencia.Text = string.Empty;
                        txt_idmaterial.Text = string.Empty;
                        txt_material.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_calibre.Text = string.Empty;
                        txt_medida.Text = string.Empty;
                        txt_existencia.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_idmaterial.Text))
                {
                    MessageBox.Show("INTRODUZCA CÓDIGO DEL MATERIAL.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string verificarEmpleadoQuery = "SELECT COUNT(*) FROM MATERIAL WHERE IDMATERIAL = @id";
                    SqlCommand verificarEmpleadoCmd = new SqlCommand(verificarEmpleadoQuery, cn);
                    verificarEmpleadoCmd.Parameters.AddWithValue("@id", txt_idmaterial.Text);
                    int EmpleadoExistente = (int)verificarEmpleadoCmd.ExecuteScalar();

                    if (EmpleadoExistente > 0)
                    {
                        string query = "DELETE FROM MATERIAL WHERE IDMATERIAL = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txt_idmaterial.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("MATERIAL ELIMINADO CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ConsultarMaterial modificar = new ConsultarMaterial();
                        modificar.Show();
                        lbl_material.Text = string.Empty;
                        lbl_tipo.Text = string.Empty;
                        lbl_medida.Text = string.Empty;
                        lbl_calibre.Text = string.Empty;
                        lbl_existencia.Text = string.Empty;
                        txt_idmaterial.Text = string.Empty;
                        txt_material.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_calibre.Text = string.Empty;
                        txt_medida.Text = string.Empty;
                        txt_existencia.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRÓ HERRAMIENTA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
