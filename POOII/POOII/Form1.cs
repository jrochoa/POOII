using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POOII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            System.IO.StreamReader file;
            try {
                file =
              new System.IO.StreamReader("Datos\\productos.csv");
                while ((line = file.ReadLine()) != null)
                {
                    String[] arreglo = line.Split(',');
                    dtProductos.Rows.Add(arreglo);
                }
                file.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio algun Error");
            }
            finally {
               
            }
        }
    }
}
