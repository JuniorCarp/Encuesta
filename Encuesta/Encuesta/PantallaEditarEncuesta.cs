using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBaseDeDatos;


namespace Encuesta
{
    class PantallaEditarEncuesta
    {
        private System.Windows.Forms.Label lbTituloPregunta;
        private System.Windows.Forms.DataGridView listaPreguntas;
        private System.Windows.Forms.Button btnTrabajarPregunta;
        private System.Windows.Forms.RadioButton RBeditar;
        private System.Windows.Forms.RadioButton RBeliminar;
        private System.Windows.Forms.Button btnAgregarPregunta;
        private System.Windows.Forms.Label lbNombreEncuesta;
        private System.Windows.Forms.Button volver;
        public static String valor;
        public Form form;

        public void CrearPantalla()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(703, 352);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloPregunta = new System.Windows.Forms.Label();
            this.listaPreguntas = new System.Windows.Forms.DataGridView();
            this.btnTrabajarPregunta = new System.Windows.Forms.Button();
            this.RBeditar = new System.Windows.Forms.RadioButton();
            this.RBeliminar = new System.Windows.Forms.RadioButton();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            this.lbNombreEncuesta = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();

            // 
            // lbTituloPregunta
            // 
            this.lbTituloPregunta.AutoSize = true;
            this.lbTituloPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPregunta.Location = new System.Drawing.Point(236, 18);
            this.lbTituloPregunta.Name = "lbTituloPregunta";
            this.lbTituloPregunta.Size = new System.Drawing.Size(464, 45);
            this.lbTituloPregunta.TabIndex = 0;
            this.lbTituloPregunta.Text = "Selecciona una Pregunta";
            // 
            // listaPreguntas
            // 
            this.listaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPreguntas.Location = new System.Drawing.Point(58, 151);
            this.listaPreguntas.Name = "listaPreguntas";
            this.listaPreguntas.RowHeadersWidth = 51;
            this.listaPreguntas.RowTemplate.Height = 24;
            this.listaPreguntas.Size = new System.Drawing.Size(464, 309);
            this.listaPreguntas.TabIndex = 2;
            listaPreguntas.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            // 
            // btnTrabajarPregunta
            // 
            this.btnTrabajarPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajarPregunta.Location = new System.Drawing.Point(566, 368);
            this.btnTrabajarPregunta.Name = "btnTrabajarPregunta";
            this.btnTrabajarPregunta.Size = new System.Drawing.Size(240, 78);
            this.btnTrabajarPregunta.TabIndex = 3;
            this.btnTrabajarPregunta.Text = "Trabajar en Pregunta";
            this.btnTrabajarPregunta.UseVisualStyleBackColor = true;
            btnTrabajarPregunta.Click += new EventHandler(TrabajarConEncuesta);
            // 
            // RBeditar
            // 
            this.RBeditar.AutoSize = true;
            this.RBeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBeditar.Location = new System.Drawing.Point(566, 151);
            this.RBeditar.Name = "RBeditar";
            this.RBeditar.Size = new System.Drawing.Size(103, 33);
            this.RBeditar.TabIndex = 4;
            this.RBeditar.TabStop = true;
            this.RBeditar.Text = "Editar";
            this.RBeditar.UseVisualStyleBackColor = true;
            // 
            // RBeliminar
            // 
            this.RBeliminar.AutoSize = true;
            this.RBeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBeliminar.Location = new System.Drawing.Point(566, 216);
            this.RBeliminar.Name = "RBeliminar";
            this.RBeliminar.Size = new System.Drawing.Size(130, 33);
            this.RBeliminar.TabIndex = 5;
            this.RBeliminar.TabStop = true;
            this.RBeliminar.Text = "Eliminar";
            this.RBeliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPregunta.Location = new System.Drawing.Point(566, 276);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(242, 68);
            this.btnAgregarPregunta.TabIndex = 6;
            this.btnAgregarPregunta.Text = "Agregar Pregunta";
            this.btnAgregarPregunta.UseVisualStyleBackColor = true;
            btnAgregarPregunta.Click += new EventHandler(crearPregunta);
            // 
            // lbNombreEncuesta
            // 
            this.lbNombreEncuesta.AutoSize = true;
            this.lbNombreEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEncuesta.Location = new System.Drawing.Point(97, 88);
            this.lbNombreEncuesta.Name = "lbNombreEncuesta";
            this.lbNombreEncuesta.Size = new System.Drawing.Size(267, 36);
            this.lbNombreEncuesta.TabIndex = 7;
            this.lbNombreEncuesta.Text = "Nombre Encuesta";
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(706, 18);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(136, 73);
            this.volver.TabIndex = 8;
            this.volver.Text = "Atras";
            this.volver.UseVisualStyleBackColor = true;
            volver.Click += new EventHandler(volverAtras);
            // 
            // Form2
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(853, 473);
            form.Controls.Add(lbNombreEncuesta);
            form.Controls.Add(btnAgregarPregunta);
            form.Controls.Add(RBeliminar);
            form.Controls.Add(RBeditar);
            form.Controls.Add(btnTrabajarPregunta);
            form.Controls.Add(listaPreguntas);
            form.Controls.Add(lbTituloPregunta);
            form.Controls.Add(volver);
            form.Name = "Form2";
            form.Text = "Form2";

            CargarEncuesta();
        }

        void CargarEncuesta()
        {

            usuarioNL usuarioNL = new usuarioNL();
            usuarioNL.CargarPregunta(listaPreguntas, PantallaEncuestas.valor);

            PantallaEncuestas.form.Close();
        }

        void TrabajarConEncuesta(object sender, EventArgs e)
        {
            if (RBeditar.Checked == false && RBeliminar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            else
            {
                if (listaPreguntas.SelectedRows.Count > 0 && RBeliminar.Checked == true)
                {
                    int filaSeleccionada = listaPreguntas.CurrentRow.Index;

                    usuarioNL usuarioNL = new usuarioNL();
                    usuarioNL.EliminarPregunta(valor);
                    listaPreguntas.Columns.Clear();
                    listaPreguntas.DataSource = "";
                    CargarEncuesta();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar la columna pulsando en la columna a la izquierda del todo");
                }
            }

        }

        public void DataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            //obtienes el valor de la primer columna
            string valorPrimerCelda = listaPreguntas.Rows[e.RowIndex].Cells[0].Value.ToString();
            valor = valorPrimerCelda;

        }

        void CrearEncuesta(object sender, EventArgs e)
        {
            PantallaCrearEncuestas pce = new PantallaCrearEncuestas();
            pce.crearPantallaCrearEncuesta();

            form.Hide();
        }

        void CerrarSession(object sender, EventArgs e)
        {
            form.Close();

            Form1 fr1 = new Form1();
            fr1.Show();
        }

        void crearPregunta(object sender, EventArgs e)
        {
            form.Close();

            PantallaPreguntaDesdeEditar ppde = new PantallaPreguntaDesdeEditar();
            ppde.crearPantalla();


        }

        void volverAtras(object sender, EventArgs e)
        {
            form.Close();

            PantallaEncuestas PE = new PantallaEncuestas();
            PE.crearPantalla();


        }
    }
}
