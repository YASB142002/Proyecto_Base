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
    public partial class Menu_Form : Form
    {
        private Menu.Control_Platillo Control;
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                flowLayoutPanel1.Controls.Add(Control = new Menu.Control_Platillo());
                Control.BackColor = Color.DarkGray;
            }
        }
    }
}
