using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label loginTexto = new Label();
        Label nombreTexto = new Label();
        Label claveTexto = new Label();
        TextBox nombreIngresado = new TextBox();
        TextBox nombreClave = new TextBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(818, 497);

            Button btnLoguear = new Button();
            Button btnRegistrar = new Button();


            loginTexto.Text = "LOGIN";
            loginTexto.Visible = true;
            loginTexto.Size = new Size(107, 32);
            loginTexto.Location = new Point(12, 9);
            loginTexto.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.Controls.Add(loginTexto);

            nombreTexto.Text = "USUARIO";
            nombreTexto.Visible = true;
            nombreTexto.Size = new Size(149, 32);
            nombreTexto.Location = new Point(315, 63);
            nombreTexto.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.Controls.Add(nombreTexto);

            claveTexto.Text = "CONTRASEÑA";
            claveTexto.Visible = true;
            claveTexto.Size = new Size(220, 32);
            claveTexto.Location = new Point(279, 196);
            claveTexto.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.Controls.Add(claveTexto);

            nombreIngresado.Text = "";
            nombreIngresado.Visible = true;
            nombreIngresado.Size = new Size(332, 22);
            nombreIngresado.Location = new Point(228, 113);
            this.Controls.Add(nombreIngresado);

            nombreClave.Text = "";
            nombreClave.Visible = true;
            nombreClave.Size = new Size(332, 22);
            nombreClave.Location = new Point(228, 248);
            nombreClave.PasswordChar = '*';
            this.Controls.Add(nombreClave);

            btnLoguear.Text = "LOGUEAR";
            btnLoguear.Visible = true;
            btnLoguear.Size = new Size(241, 76);
            btnLoguear.Location = new Point(101, 329);
            btnLoguear.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            btnLoguear.Click += new EventHandler(btnLogin);
            this.Controls.Add(btnLoguear);

            btnRegistrar.Text = "REGISTRATE";
            btnRegistrar.Visible = true;
            btnRegistrar.Size = new Size(241, 76);
            btnRegistrar.Location = new Point(435, 329);
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            btnRegistrar.Click += new EventHandler(btnRegistrarUsuario);
            this.Controls.Add(btnRegistrar);
        }
    }
}
