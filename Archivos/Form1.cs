using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5
{
    public partial class Form1 : Form
    {
        private UsuarioManager usuarios;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Debe elegir la carpeta de archivos para comenzar", "Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            folderBrowserDialog1.ShowDialog();
            label7.Text = folderBrowserDialog1.SelectedPath;
            usuarios = new UsuarioManager(folderBrowserDialog1.SelectedPath);
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            refreshVista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //borro los datos que había
            refreshVista();
            deleteSelections();

        }
        private void deleteSelections()
        {
            label8.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1[5, e.RowIndex].Value.ToString());
            checkBox2.Checked = bool.Parse(dataGridView1[6, e.RowIndex].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuarios.agregarUsuario(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, checkBox1.Checked, checkBox2.Checked))
            {
                MessageBox.Show("Agregado con éxito");
                refreshVista();
            }
            else
                MessageBox.Show("No se pudo agregar el usuario");
            deleteSelections();
        }

        private void refreshVista()
        {
            dataGridView1.Rows.Clear();
            foreach (List<string> usuario in usuarios.obtenerUsuarios())
                dataGridView1.Rows.Add(usuario.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (usuarios.eliminarUsuario(int.Parse(label8.Text)))
            {
                MessageBox.Show("Eliminado con éxito");
                refreshVista();
            }
            else
                MessageBox.Show("No se pudo eliminar el usuario");
            deleteSelections();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usuarios.modificarUsuario(int.Parse(label8.Text), int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, checkBox1.Checked, checkBox2.Checked))
            {
                MessageBox.Show("Modificado con éxito");
                refreshVista();
            }
            else
                MessageBox.Show("No se pudo modificar el usuario");
            deleteSelections();
        }
    }
}
