using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_CSP
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            //Use database to populate listbox with orders
            lbxOrders.Items.Add("[Name]\t\t\t[Items]\t\t\t[Total]");
            lbxOrders.Items.Add("Royce McGregor\t\tCarrots(3)\t\t\t$3.00");

            ProgOps.EmployeesDatabaseCommand(dgvEmployeesView);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Make sure all fields are filled and user has selected a valid order
            if (tbxName.Text == "" || tbxItems.Text == "" || tbxTotal.Text == "")
            {
                MessageBox.Show("Please input data for all fields.", "Error");
            }
            else if (lbxOrders.SelectedIndex == -1 || lbxOrders.SelectedIndex == 0)
            {
                MessageBox.Show("Please select and order.", "Error");
            }
            else
            {
                //Removes the selected order and replaces it with an updated one / Update database.
                lbxOrders.Items.RemoveAt(lbxOrders.SelectedIndex);
                lbxOrders.Items.Add(tbxName.Text + "\t\t" + tbxItems.Text + "\t\t\t" + tbxTotal.Text);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            //Remove the approved order from the list
            lbxOrders.Items.RemoveAt(lbxOrders.SelectedIndex);
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            //Remove the declined order from the list (and from database)
            //lbxOrders.Items.RemoveAt(lbxOrders.SelectedIndex);

            int id;
            int.TryParse(tbxId.Text, out id);
            if(ProgOps.OrderVerify(id))
            {
                ProgOps.EmployeesDelete(id);
            }
            else
            {
                MessageBox.Show("That Order ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProgOps.EmployeesDatabaseCommand(dgvEmployeesView);
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            if(tbxId.Text == "")
            {
                tbxName.Enabled = false;
                tbxItems.Enabled = false;
                tbxQuantity.Enabled = false;
                tbxTotal.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                tbxName.Enabled = true;
                tbxItems.Enabled = true;
                tbxQuantity.Enabled = true;
                tbxTotal.Enabled = true;
                //btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
