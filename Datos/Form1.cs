using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
   
    public partial class Form1 : Form
    {
        List<int> Milista = new List<int>(); 
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvalor.Text);
            Milista.Add(n);
            txtvalor.Clear();
            txtvalor.Focus();

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            int n, pos;
            n = int.Parse(txtvalor.Text);
            pos = int.Parse(txtposicion.Text);
            Milista.Insert(n, pos);
            txtvalor.Clear();
            txtvalor.Focus();
            txtposicion.Clear();
            txtposicion.Focus();
        }

        private void btneliminarde_Click(object sender, EventArgs e)
        {
            int pos;
            pos= int.Parse(txtposicion.Text);
            txtposicion.Clear();
            txtposicion.Focus();
            Milista.RemoveAt(pos);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvalor.Text);
            Milista.Remove(n);
            txtvalor.Clear();
            txtvalor.Focus();

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int i;
            liver.Items.Clear();
            for (i = 0; i <= Milista.Count - 1; i++)
            {
                liver.Items.Add(Milista.ElementAt(i));
            }

        }
    }
}
