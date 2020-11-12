using CapaBaseDeDatos;
using Encuesta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidades
{
    public class PantallaRegistrar
    {
        Label lbNombre = new Label();
        Label lbApellido = new Label();
        Label lbNombreUsuario = new Label();
        Label lbClave = new Label();
        Label lbConfirmarClave = new Label();

        TextBox txtNombre = new TextBox();
        TextBox txtApellido = new TextBox();
        TextBox txtNombreUsuario = new TextBox();
        TextBox txtClave = new TextBox();
        TextBox txtConfirmarClave = new TextBox();
        Form form;
        Button btnRegistrar = new Button();

        public void CrearPantallaRegistrar()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(868, 523);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            // LABEL
            #region label
            lbNombre.Text = "NOMBRE";
            lbNombre.Visible = true;
            lbNombre.Size = new Size(144, 32);
            lbNombre.Location = new Point(54, 9);
            lbNombre.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            form.Controls.Add(lbNombre);

            lbApellido.Text = "APELLIDO";
            lbApellido.Visible = true;
            lbApellido.Size = new Size(161, 32);
            lbApellido.Location = new Point(54, 108);
            lbApellido.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            form.Controls.Add(lbApellido);

            lbNombreUsuario.Text = "NOMBRE USUARIO";
            lbNombreUsuario.Visible = true;
            lbNombreUsuario.Size = new Size(286, 32);
            lbNombreUsuario.Location = new Point(54, 219);
            lbNombreUsuario.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            form.Controls.Add(lbNombreUsuario);

            lbClave.Text = "CONTRASEÑA";
            lbClave.Visible = true;
            lbClave.Size = new Size(220, 32);
            lbClave.Location = new Point(54, 322);
            lbClave.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            form.Controls.Add(lbClave);

            lbConfirmarClave.Text = "CONFIRMAR CONTRASEÑA";
            lbConfirmarClave.Visible = true;
            lbConfirmarClave.Size = new Size(405, 32);
            lbConfirmarClave.Location = new Point(54, 415);
            lbConfirmarClave.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            form.Controls.Add(lbConfirmarClave);
            #endregion

            // TEXTBOX
            #region textbox
            // TEXTBOX
            txtNombre.Visible = true;
            txtNombre.Size = new Size(332, 22);
            txtNombre.Location = new Point(184, 44);
            form.Controls.Add(txtNombre);

            txtApellido.Visible = true;
            txtApellido.Size = new Size(332, 22);
            txtApellido.Location = new Point(183, 143);
            form.Controls.Add(txtApellido);

            txtNombreUsuario.Visible = true;
            txtNombreUsuario.Size = new Size(332, 22);
            txtNombreUsuario.Location = new Point(183, 253);
            form.Controls.Add(txtNombreUsuario);

            txtClave.Visible = true;
            txtClave.Size = new Size(332, 22);
            txtClave.Location = new Point(183, 357);
            form.Controls.Add(txtClave);

            txtConfirmarClave.Visible = true;
            txtConfirmarClave.Size = new Size(332, 22);
            txtConfirmarClave.Location = new Point(183, 450);
            form.Controls.Add(txtConfirmarClave);
            #endregion

            // BUTTON
            #region BUTTON
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.Visible = true;
            btnRegistrar.Size = new Size(241, 110);
            btnRegistrar.Location = new Point(569, 206);
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            btnRegistrar.Click += new EventHandler(btnCrearUsuario);
            form.Controls.Add(btnRegistrar);
            #endregion
        }

        void btnCrearUsuario(object sender, EventArgs e)
        {
            if (txtNombre.Text == null && txtNombre.Text == ""
                  && txtApellido.Text == null && txtApellido.Text == ""
                  && txtNombreUsuario.Text == null && txtNombreUsuario.Text == ""
                  && txtClave.Text == null && txtClave.Text == ""
                  && txtConfirmarClave.Text == null && txtConfirmarClave.Text == "")
            {
                MessageBox.Show("hay campos vacios");
            }
            else
            {
              

                if (txtClave.Text == txtConfirmarClave.Text)
                {
                    String nombre = txtNombre.Text;
                    String apellidoUsuario = txtApellido.Text;
                    String nombreUsuario = txtNombreUsuario.Text;
                    String claveUusuario = txtConfirmarClave.Text;
               

                    usuario usuario = Conexion.getInstance().AccesoSistema(nombreUsuario, claveUusuario);

                    if (usuario == null)
                    {
                        //GUARDAR
                        usuarioNL usuarioNL = new usuarioNL();
                        usuarioNL.GuardarUsuario(nombreUsuario,apellidoUsuario,nombreUsuario,claveUusuario);
                        MessageBox.Show("Guardado!!");

                        Form1 fr = new Form1();
                        fr.Show();
                        form.Close();

                    }
                    else
                    {
                        MessageBox.Show("El usuario exite");
                    }    
                }

                else
                {
                    MessageBox.Show("La clave y cofirmacion de clave no son iguales");
                }
            }
        }
    }
}
