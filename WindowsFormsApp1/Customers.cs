using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesDataSet1.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SalesEntities())
            {
                var x = this.salesDataSet1.Customers.
                MessageBox.Show("Record saved!");
                db.SaveChanges();
            }
        }
    }
}
