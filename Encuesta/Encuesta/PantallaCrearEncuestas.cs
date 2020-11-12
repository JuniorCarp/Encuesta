using CapaBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    class PantallaCrearEncuestas
    {

        private System.Windows.Forms.Label lbTituloEncuesta;
        private System.Windows.Forms.Label lbNombreEncuestra;
        public static System.Windows.Forms.TextBox txtNombreEncuentra;
        private System.Windows.Forms.Label lbNumeroPreguntas;
        private System.Windows.Forms.TextBox txtNumeroPreguntas;
        private System.Windows.Forms.Button btnCrearEncuesta;
        public static Form form;
        int numeroDePreguntas;
        String nombrePreguntas;


        public void crearPantallaCrearEncuesta()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(851, 508);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloEncuesta = new System.Windows.Forms.Label();
            this.lbNombreEncuestra = new System.Windows.Forms.Label();
             txtNombreEncuentra = new System.Windows.Forms.TextBox();
            this.lbNumeroPreguntas = new System.Windows.Forms.Label();
            this.txtNumeroPreguntas = new System.Windows.Forms.TextBox();
            this.btnCrearEncuesta = new System.Windows.Forms.Button();
            // 
            // lbTituloEncuesta
            // 
            this.lbTituloEncuesta.AutoSize = true;
            this.lbTituloEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloEncuesta.Location = new System.Drawing.Point(12, 9);
            this.lbTituloEncuesta.Name = "lbTituloEncuesta";
            this.lbTituloEncuesta.Size = new System.Drawing.Size(313, 45);
            this.lbTituloEncuesta.TabIndex = 1;
            this.lbTituloEncuesta.Text = "Crear Encuestas";
            // 
            // lbNombreEncuestra
            // 
            this.lbNombreEncuestra.AutoSize = true;
            this.lbNombreEncuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEncuestra.Location = new System.Drawing.Point(28, 116);
            this.lbNombreEncuestra.Name = "lbNombreEncuestra";
            this.lbNombreEncuestra.Size = new System.Drawing.Size(443, 45);
            this.lbNombreEncuestra.TabIndex = 2;
            this.lbNombreEncuestra.Text = "Nombre de la Encuesta:";
            // 
            // txtNombreEncuentra
            // 
            txtNombreEncuentra.Location = new System.Drawing.Point(400, 129);
            txtNombreEncuentra.Name = "txtNombreEncuentra";
            txtNombreEncuentra.Size = new System.Drawing.Size(257, 22);
            txtNombreEncuentra.TabIndex = 3;
            // 
            // lbNumeroPreguntas
            // 
            this.lbNumeroPreguntas.AutoSize = true;
            this.lbNumeroPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPreguntas.Location = new System.Drawing.Point(28, 229);
            this.lbNumeroPreguntas.Name = "lbNumeroPreguntas";
            this.lbNumeroPreguntas.Size = new System.Drawing.Size(330, 36);
            this.lbNumeroPreguntas.TabIndex = 4;
            this.lbNumeroPreguntas.Text = "Numero de preguntas:";
            // 
            // txtNumeroPreguntas
            // 
            this.txtNumeroPreguntas.Location = new System.Drawing.Point(400, 242);
            this.txtNumeroPreguntas.Name = "txtNumeroPreguntas";
            this.txtNumeroPreguntas.Size = new System.Drawing.Size(257, 22);
            this.txtNumeroPreguntas.TabIndex = 5;
            // 
            // btnCrearEncuesta
            // 
            this.btnCrearEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEncuesta.Location = new System.Drawing.Point(268, 338);
            this.btnCrearEncuesta.Name = "btnCrearEncuesta";
            this.btnCrearEncuesta.Size = new System.Drawing.Size(242, 69);
            this.btnCrearEncuesta.TabIndex = 7;
            this.btnCrearEncuesta.Text = "Crear Encuesta";
            this.btnCrearEncuesta.UseVisualStyleBackColor = true;
            btnCrearEncuesta.Click += new EventHandler(CrearEncuestas);

            // 
            // Form3
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(800, 450);
            form.Controls.Add(btnCrearEncuesta);
            form.Controls.Add(txtNumeroPreguntas);
            form.Controls.Add(lbNumeroPreguntas);
            form.Controls.Add(txtNombreEncuentra);
            form.Controls.Add(lbNombreEncuestra);
            form.Controls.Add(lbTituloEncuesta);
            form.Name = "Form3";
            form.Text = "Form3";
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        void CrearEncuestas(object sender, EventArgs e)
        {    

            if(txtNombreEncuentra.Text.Equals("") || txtNumeroPreguntas.Text.Equals("") )
            {
                MessageBox.Show("Debe introducir el nombre de la encuesta y la cantidad de preguntas");
            }
            else
            {
                try
                {
                    numeroDePreguntas = int.Parse(txtNumeroPreguntas.Text);
                    nombrePreguntas = txtNombreEncuentra.Text;

                    usuarioNL usuario = new usuarioNL();
                    usuario.GuardarEncuesta(nombrePreguntas, 0, Form1.paseNombre);
                    form.Hide();
                  
                    PantallaPregunta pe = new PantallaPregunta();
                    pe.crearPantalla();
                 

                }
                catch
                {
                    MessageBox.Show("Debes introducir el numero de preguntas");

                }


            }

        }

    }
}
