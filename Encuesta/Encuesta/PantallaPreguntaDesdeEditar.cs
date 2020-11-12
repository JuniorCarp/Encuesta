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
    class PantallaPreguntaDesdeEditar
    {
        private System.Windows.Forms.Label lbTituloPrigunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnCrearEncuesta;
        private Form form;

        public void crearPantalla()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(703, 352);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloPrigunta = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnCrearEncuesta = new System.Windows.Forms.Button();

            // 
            // lbTituloPrigunta
            // 
            this.lbTituloPrigunta.AutoSize = true;
            this.lbTituloPrigunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrigunta.Location = new System.Drawing.Point(143, 55);
            this.lbTituloPrigunta.Name = "lbTituloPrigunta";
            this.lbTituloPrigunta.Size = new System.Drawing.Size(362, 36);
            this.lbTituloPrigunta.TabIndex = 2;
            this.lbTituloPrigunta.Text = "Introduzca una pregunta";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(179, 140);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(305, 22);
            this.txtPregunta.TabIndex = 3;
            // 
            // btnCrearEncuesta
            // 
            this.btnCrearEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEncuesta.Location = new System.Drawing.Point(208, 195);
            this.btnCrearEncuesta.Name = "btnCrearEncuesta";
            this.btnCrearEncuesta.Size = new System.Drawing.Size(242, 69);
            this.btnCrearEncuesta.TabIndex = 8;
            this.btnCrearEncuesta.Text = "Crear Pregunta";
            this.btnCrearEncuesta.UseVisualStyleBackColor = true;
            btnCrearEncuesta.Click += new EventHandler(ContinuarPreguntas);
            // 
            // Form4
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.Controls.Add(txtPregunta);
            form.Controls.Add(lbTituloPrigunta);
            form.Controls.Add(btnCrearEncuesta);
            form.Name = "Form4";
            form.Text = "Form4";
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        void ContinuarPreguntas(object sender, EventArgs e)
        {
            usuarioNL us = new usuarioNL();
            us.GuardarPreguntas(txtPregunta.Text, PantallaEncuestas.valor);


            PantallaEncuestas.form.Close();
            form.Close();

            PantallaEditarEncuesta fr = new PantallaEditarEncuesta();
            fr.CrearPantalla();
        }
    }
}
