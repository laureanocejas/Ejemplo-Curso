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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)//uso el forech accedo al objeto apliaction a la coleecion de objeto ventana cualqueir objeto que herede de la calse form
            //recorro la coleccion apliaction opoen from atraves del forech dentro de la avriable itlem voy a tener un form que esta dentro de esta colecion
            //
            //
            
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe otra ventana abierta");
                    return;
                }//el getype me devuelve el tipo de objeto es , si el tipo de objeto es igual tipo de objeto que busco 
                    //
                    

            }
            //puedo nmavegar a otro ventana
            //como navego de aca a otra ventana? creando la instancia de un objeto 
            Form1 ventana = new Form1();//esto va ser que me cree de forma manual un objeto el new que yo se lo daba a apliacation.run lo creo yo a mano y lo guardo en una variable
            ventana.MdiParent = this;//mdiparente es la ventana que estoy parado la referncia a esta ventana es  es this 
                                     //ventana.ShowDialog();//no puedo usar el showgdialog me va dar error cuando es parents me va mostra elñ formulario con show() me genera muchas instancia para evitar esto show dialog me muestra la ventana con un formato de dialogo captura la intereacion del momento
                                     //no pueod usar el showdialogo cuando utilo el parent porque le showdialog toma el control la ventana que emerge que se abre tome el control
                                     //si yo hago un arquitectura de tipo padre hijo la ventana que emerge nace adentro del formulario por el cual yo tengo la psobilidad de hacer acciones
                                     ////sobre la pantalla que es padre de las otras no e slogico que yo utilice showdialogo al momento de decirle que sea hija y al mismo momento que tome el control
                                     /////si yo loa bro con el 
                                     //ventana.ShowDialog();//abre la ventana de adentro hila pero lo abre de afuera de la pantalla padre

            ventana.Show();

        }
    }
}
