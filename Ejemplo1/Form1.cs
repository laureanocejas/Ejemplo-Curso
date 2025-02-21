using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;//capturo atraves de una variavle lo que tenga en txtelementos
            lwElementos.Items.Add(elemento);//items es un objeto es todo objeto es un listado el lwes un listado el lisatdo es una coleccion  .add para agregar un elemento elemento
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFav.Items.Add("ROJO");//Le agrego un par de colores , el elelemnto el objeto combobosbox. iteme y le grego colores add 
            cboColorFav.Items.Add("VERDE");//cuando cargue la pamntalla me va cargar con un par de item y voy a tener estos itewme pára elegir 
            cboColorFav.Items.Add("NEGRO");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;//me guardo el valor que tiene dtp .value devuelve un datetime fecha 
            string chocolate = ckbChocolate.Checked == true ? "le gusta el chocolate " : "odia el chocolate";//es un operador ternario ? por un lado pongo un verddadero sino pongo un faslo, si esl chec bob esta chequeado si es true 
                                                                      //ponele esta cadena"le gusta el chocolotate" sino esta otro cadena"odia ek choccoloate"
            string tipo;
            if (rbtMugel.Checked)//si el elemento esta chequeado
            {
                tipo = "Muggel";

            }
            else
            {
                if (rbtWizird.Checked)
                {
                    tipo = "Wizard";
                }
                else
                {
                    tipo = "Skill";
                }
            }
            string colorfavorito = cboColorFav.SelectedItem.ToString();//tiene items el itemes que le agrego me devuelve un object relacionado a la herencia y familia de clases
                                                                       ////este control combo box me permite que le cargue cualquier tipo de objeto lo trabja de manera generica me devuelve objet por eso to string le pongo
            string numeroFavorito = numNumeroFavorito.Value.ToString();
            string mensaje = chocolate + ", es " + tipo + "su color favorito es: " + colorfavorito + " su numero favorito es:" + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + "fecha: " + fecha + ", " + chocolate + ", es " + tipo + "su color favorito es: " + colorfavorito + " su numero favorito es:" + numNumeroFavorito);

        }
    }
}
