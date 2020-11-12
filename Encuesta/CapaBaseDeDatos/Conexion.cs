using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaBaseDeDatos
{
    public class Conexion
    {
        private static Conexion instancia = null;
        private Conexion() { }

        public static Conexion getInstance()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection(" Data Source = DESKTOP-KJ1LQ8U\\SQLEXPRESS; Initial Catalog = Encuestas; Integrated Security = True");
            return conexion;
        }

        public usuario AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            usuario usuario = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();

                sr = cmd.ExecuteReader();

                if (sr.Read())
                {
                    usuario = new usuario();
                    usuario.nombreUsuario = sr["nombreUsuario"].ToString();
                    usuario.clave = sr["clave"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return usuario;

        }

        public usuario GuardarUsuario(String user, String apellido, String nombreUsuario, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            usuario usuario = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                cmd.Parameters.AddWithValue("@prmUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@prmApellido", apellido);
                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return usuario;

        }


        // Encuestas

        public void cargarEncuestas(DataGridView dgv, String usuario)
        {
            SqlConnection conexion = null;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                da = new SqlDataAdapter("select * from encuesta where usuarioEncuesta = '" + usuario + "'", conexion);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }
        }

        public void GuardarEncuestas(String nombre, int numeroPreguntas, String usuarioEncuenta)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarEncuesta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmNombre", nombre);
                cmd.Parameters.AddWithValue("@prmNumeroPregunta", numeroPreguntas);
                cmd.Parameters.AddWithValue("@prmUsuarioEncuesta", usuarioEncuenta);
                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

        }

        public void EliminarEncuestas(String nombre)
        {
            SqlConnection conexion = null;
            SqlCommand cmd;
            DataTable dt = new DataTable();
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                cmd = new SqlCommand("delete from encuesta where nombreEncuesta = '" + nombre + "'", conexion);
                sr = cmd.ExecuteReader();
                MessageBox.Show("Elimnado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }
        }





        public void GuardarPreguntas(String pregunta , String usuarioEncuenta)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarPregunta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmPregunta", pregunta);
                cmd.Parameters.AddWithValue("@prmUsuario", usuarioEncuenta);
                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

        }

        public void cargarPreguntas(DataGridView dgv, String usuario)
        {
            SqlConnection conexion = null;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                da = new SqlDataAdapter("select * from preguntas where usuarioEncuesta = '" + usuario + "'", conexion);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }
        }

        public void EliminarPreguntas(String nombre)
        {
            SqlConnection conexion = null;
            SqlCommand cmd;
            DataTable dt = new DataTable();
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                cmd = new SqlCommand("delete from preguntas where pregunata = '" + nombre + "'", conexion);
                sr = cmd.ExecuteReader();
                MessageBox.Show("Elimnado");

                try
                {
                    conexion = Conexion.getInstance().ConexionBD();
                    conexion.Open();
                    cmd = new SqlCommand(" UPDATE encuesta set numeroDePreguntas = numeroDePreguntas - 1 WHERE nombreEncuesta = '"  +  nombre + "'", conexion);
                    sr = cmd.ExecuteReader();
                  
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error al cargar consultas " + ex.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }
        }
    }
}
