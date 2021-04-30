using FassasInvoicingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FassasInvoicingUI
{
    public partial class ProvoliEterion : Form
    {
        private List<Eteria> availableEteries = GlobalConfig.Connection.GetEteries();

        public ProvoliEterion()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = availableEteries;
            //dataGridView1.
            DataTable dt = new DataTable();
            //dt = availableEteries.Add();






        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProvoliEterion_Load(object sender, EventArgs e)
        {

        }
    }
}
