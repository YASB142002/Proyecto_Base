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
    public partial class Branch_Office_Form : Form
    {
        private Branch_Office.Control_Mesa Control;
        public Branch_Office_Form()
        {
            InitializeComponent();
        }

        private void Branch_Office_Form_Load(object sender, EventArgs e)
        {
            //Por cada elemento en la lista donde iran las mesas con sus propiedades
            for (int i = 0; i < 50; i++)
            {
                flowLayoutPanel1.Controls.Add(Control = new Branch_Office.Control_Mesa());
                Control.BackColor = Color.LightGray;
            }
        }

        private void Branch_Office_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
