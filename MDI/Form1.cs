using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        Form2 hijoLogin;
        Form3 hijoMain;
        internal string texto;
        string usuario;
        bool logued;
        public bool touched;
        public Form1()
        {
            InitializeComponent();
            logued = false;
            hijoLogin = new Form2(new string[1]);
            
            hijoLogin.MdiParent = this;
            hijoLogin.TrasfEvento += TransfDelegado;
            
            hijoLogin.Show();
            touched = false;
        }
        private void TransfDelegado(string Usuario)
        {
            this.usuario = Usuario;
            if (usuario != null && usuario != "")
            {
                MessageBox.Show("Log in correcto, Usuario: " + usuario);
                hijoLogin.Close();
                hijoMain = new Form3(new string[] { usuario });
                hijoMain.MdiParent = this;
                hijoMain.Show();
            }
        }

    }
}
