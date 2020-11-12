using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaBaseDeDatos
{
    public class usuarioNL
    {
        public usuario AccesoSistema(String user, String pass)
        {
            try
            {
                return Conexion.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public usuario GuardarUsuario(String user, String apellido, String nombreUsuario, String pass)
        {
            try
            {
                return Conexion.getInstance().GuardarUsuario(user, apellido,nombreUsuario,pass);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void CargarData(DataGridView dgv, String usuario)
        {
            try
            {
                 Conexion.getInstance().cargarEncuestas(dgv,usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void CargarPregunta(DataGridView dgv, String usuario)
        {
            try
            {
                Conexion.getInstance().cargarPreguntas(dgv, usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void EliminarEncuesta(String encuesta)
        {
            try
            {
                Conexion.getInstance().EliminarEncuestas(encuesta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void GuardarEncuesta(String encuesta,int numeroDePreguntas, String usuario)
        {
            try
            {
                Conexion.getInstance().GuardarEncuestas(encuesta,numeroDePreguntas,usuario);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void GuardarPreguntas(String pregunta, String usuarioEncuenta)
        {
            try
            {
                Conexion.getInstance().GuardarPreguntas(pregunta,usuarioEncuenta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void EliminarPregunta(String pregunta)
        {
            try
            {
                Conexion.getInstance().EliminarPreguntas(pregunta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
