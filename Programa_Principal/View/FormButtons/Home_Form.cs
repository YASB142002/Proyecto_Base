using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Principal.View.FormButtons
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
            tmFechaHora.Start();
            
            
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Home_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmFechaHora.Stop();
        }
    }
}
