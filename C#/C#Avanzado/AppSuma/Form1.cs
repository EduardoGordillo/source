using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// necesitamos estos namespace
using System.Reflection;
using TiposPlug_on;

namespace AppSuma
{
    public partial class Form1 : Form
    {
        // no olvidar hacer la referencia a tiposplugin

        // colocar los dll de los plug ins en la carpeta de la aplicacion
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarPlugInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mosttramos el cuadro de dialogo para cargar el plug in
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (VerificarCargarPlugIn(openFileDialog1.FileName) == false)
                    string.Format("Realizado");
                else
                    MessageBox.Show("No es un plug-in valido para nuestra aplicacion");
            }
        }
        private bool VerificarCargarPlugIn(string plugin)
        {
            bool encontrado = false;

            Assembly pluginAsm = null;

            // obtenemos los valores de la forma
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = 0.0;
            try
            {
                // cargamos el assembly que contiene el plug in
                pluginAsm = Assembly.LoadFrom(plugin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return encontrado;
            }

            // obtenemos las clases que implementan nuestra interfaz IPlugInMates
            // que se encuentra en el assembly
            var clases = from t in pluginAsm.GetTypes()
                         where t.IsClass && (t.GetInterface("IPlugInMates") != null)
                         select t;
        
            // creamos el objeto de las instancias(clases) encontradas
            foreach (Type t in clases)
            {
                // creamos instancia
                IPlugInMates objeto = (IPlugInMates)pluginAsm.CreateInstance(t.FullName, true);
                // invocamos el metodo del plug in
                r = objeto.Calcular(a, b);
                // actualizamos el resultado
                lblResultado.Text = r.ToString();
                var pluginInfo = from ci in t.GetCustomAttributes(false)
                                 where (ci.GetType() == typeof(CInfoPlugIn))
                                 select ci;
                // colocamos informacion en la forma
                foreach(CInfoPlugIn c in pluginInfo)
                {
                    lblInfo.Text = c.Creador + "," + c.Informacion;
                }
                
            }
            return encontrado;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
