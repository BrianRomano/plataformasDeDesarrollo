using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form2 : Form
    {
        private bool logued;
        private string[] argumentos;
        private string usuario;
        public delegate void TransfDelegado(string usuario);
        public TransfDelegado TrasfEvento;
        public Form2(string[] args)
        {
            logued = false;
            InitializeComponent();
            argumentos = args;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            usuario = textBox1.Text;
            if (usuario != null && usuario != "")
            {
                this.TrasfEvento(usuario);
                this.Close();
            }
            else
                MessageBox.Show("Debe ingresar un usuario!");

        }
        
    }
}
