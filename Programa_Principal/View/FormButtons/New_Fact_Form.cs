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
    public partial class New_Fact_Form : Form
    {
        public New_Fact_Form()
        {
            InitializeComponent();
            cbxPlatillo.Items.AddRange(Controllers.CPlatillo.GetNamePlatillos().ToArray());
            cbxExtra.Items.AddRange(Controllers.CIngrediente.GetIngredientes().ToArray());
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            if (cbxExtra.Items.Count != 0)
                dgvExtra.DataSource = Controllers.CIngrediente.AdddgvExtra(cbxExtra.SelectedItem.ToString());
            else
                MessageBox.Show("Debe seleccionar un Extra ");
        }

        string Nombre;
        private string GetNombreIngredientedgvExtra() 
        {
            try
            {
                return dgvExtra.Rows[dgvExtra.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }
        private void btnRemoveExtra_Click(object sender, EventArgs e)
        {
            if (Nombre != null)
                dgvExtra.DataSource = Controllers.CIngrediente.RemovedgvExtra(Nombre = GetNombreIngredientedgvExtra());
            else
                MessageBox.Show("Debe seleccionar un Extra ");
        }

        private void btnAddPlatillo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxPlatillo.SelectedItem.ToString()))
            {
                dgvPlatillo.DataSource = Controllers.CPlatillo.AddPlatillo(cbxPlatillo.SelectedItem.ToString());
            }
        }
    }
}
