using CapaBaseDeDatos;
using Encuesta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    public class PantallaEncuestas
    {

        private System.Windows.Forms.Label lbTituloEncuesta;
        private System.Windows.Forms.DataGridView listaEncuestas;
        private System.Windows.Forms.Button btnTrabajarEncuesta;
        private System.Windows.Forms.RadioButton RBeditar;
        private System.Windows.Forms.RadioButton RBeliminar;
        private System.Windows.Forms.Button btnAgregarEncuesta;
        private System.Windows.Forms.Button btnCerrarSession;

        public static Form form;
        public static String valor;

        public void crearPantalla()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(851, 508);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloEncuesta = new System.Windows.Forms.Label();
            this.listaEncuestas = new System.Windows.Forms.DataGridView();
            this.btnTrabajarEncuesta = new System.Windows.Forms.Button();
            this.RBeditar = new System.Windows.Forms.RadioButton();
            this.RBeliminar = new System.Windows.Forms.RadioButton();
            this.btnAgregarEncuesta = new System.Windows.Forms.Button();
            this.btnCerrarSession = new System.Windows.Forms.Button();

            // 
            // lbTituloEncuesta
            // 
            this.lbTituloEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbTituloEncuesta.Location = new System.Drawing.Point(236, 18);
            this.lbTituloEncuesta.Name = "lbTituloEncuesta";
            this.lbTituloEncuesta.Size = new System.Drawing.Size(390, 36);
            this.lbTituloEncuesta.TabIndex = 0;
            this.lbTituloEncuesta.Text = "Selecciona una Encuestas";
            // 
            // listaEncuestas
            // 
            this.listaEncuestas.Location = new System.Drawing.Point(58, 151);
            this.listaEncuestas.Name = "listaEncuestas";
            this.listaEncuestas.RowHeadersWidth = 51;
            this.listaEncuestas.RowTemplate.Height = 24;
            this.listaEncuestas.Size = new System.Drawing.Size(464, 309);
            this.listaEncuestas.TabIndex = 2;
            listaEncuestas.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            // 
            // btnTrabajarEncuesta
            // 
            this.btnTrabajarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTrabajarEncuesta.Location = new System.Drawing.Point(548, 292);
            this.btnTrabajarEncuesta.Name = "btnTrabajarEncuesta";
            this.btnTrabajarEncuesta.Size = new System.Drawing.Size(240, 78);
            this.btnTrabajarEncuesta.TabIndex = 3;
            this.btnTrabajarEncuesta.Text = "Trabajar en Encuesta";
            this.btnTrabajarEncuesta.UseVisualStyleBackColor = true;
            btnTrabajarEncuesta.Click += new EventHandler(TrabajarConEncuesta);
            // 
            // RBeditar
            // 
            this.RBeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
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
            this.RBeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.RBeliminar.Location = new System.Drawing.Point(566, 216);
            this.RBeliminar.Name = "RBeliminar";
            this.RBeliminar.Size = new System.Drawing.Size(130, 33);
            this.RBeliminar.TabIndex = 5;
            this.RBeliminar.TabStop = true;
            this.RBeliminar.Text = "Eliminar";
            this.RBeliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEncuesta
            // 
            this.btnAgregarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEncuesta.Location = new System.Drawing.Point(160, 79);
            this.btnAgregarEncuesta.Name = "btnAgregarEncuesta";
            this.btnAgregarEncuesta.Size = new System.Drawing.Size(242, 51);
            this.btnAgregarEncuesta.TabIndex = 6;
            this.btnAgregarEncuesta.Text = "Agregar Encuesta";
            this.btnAgregarEncuesta.UseVisualStyleBackColor = true;
            btnAgregarEncuesta.Click += new EventHandler(CrearEncuesta);

            // 
            // btnCerrarSession
            // 
            this.btnCerrarSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSession.Location = new System.Drawing.Point(548, 389);
            this.btnCerrarSession.Name = "btnCerrarSession";
            this.btnCerrarSession.Size = new System.Drawing.Size(242, 71);
            this.btnCerrarSession.TabIndex = 7;
            this.btnCerrarSession.Text = "Cerrar Session";
            this.btnCerrarSession.UseVisualStyleBackColor = true;
            btnCerrarSession.Click += new EventHandler(CerrarSession);
        
            // 
            // Form2
            // 
            form.Controls.Add(btnAgregarEncuesta);
            form.Controls.Add(RBeliminar);
            form.Controls.Add(RBeditar);
            form.Controls.Add(btnTrabajarEncuesta);
            form.Controls.Add(listaEncuestas);
            form.Controls.Add(lbTituloEncuesta);
            form.Controls.Add(btnCerrarSession);

            CargarEncuesta();

        }

        void CargarEncuesta()
        {

            usuarioNL usuarioNL = new usuarioNL();
            usuarioNL.CargarData(listaEncuestas, Form1.paseNombre);

        }

        void TrabajarConEncuesta(object sender, EventArgs e)
        {
            if (RBeditar.Checked == false && RBeliminar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            else
            {
                if (listaEncuestas.SelectedRows.Count > 0 && RBeliminar.Checked == true)
                {
                    int filaSeleccionada = listaEncuestas.CurrentRow.Index;

                    usuarioNL usuarioNL = new usuarioNL();
                    usuarioNL.EliminarEncuesta(valor);
                    listaEncuestas.Columns.Clear();
                    listaEncuestas.DataSource = "";
                    CargarEncuesta();
                }

                else if(listaEncuestas.SelectedRows.Count > 0 && RBeditar.Checked == true)
                {
                    int filaSeleccionada = listaEncuestas.CurrentRow.Index;

                    form.Hide();
                    PantallaEditarEncuesta pee = new PantallaEditarEncuesta();
                    pee.CrearPantalla();
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
            string valorPrimerCelda = listaEncuestas.Rows[e.RowIndex].Cells[0].Value.ToString();
            valor = valorPrimerCelda;

        }

        void CrearEncuesta(object sender, EventArgs e)
        {
            PantallaCrearEncuestas pce = new PantallaCrearEncuestas();
            pce.crearPantallaCrearEncuesta();

            form.Close();
        }

        void CerrarSession(object sender, EventArgs e)
        {
            form.Close();

            Form1 fr1 = new Form1();
            fr1.Show();
        }

    }

}
