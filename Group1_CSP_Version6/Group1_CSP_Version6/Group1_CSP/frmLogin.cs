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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdbCustomer.Checked == true)
            {
                if (ProgOps.UserLogin(tbxUsername.Text.ToString(), tbxPassword.Text.ToString(), dgvLoginHolder, "Customer") == true)
                {
                    frmCustomers customers = new frmCustomers();
                    customers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username, password, or login type is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbEmployee.Checked == true)
            {
                if (ProgOps.UserLogin(tbxUsername.Text.ToString(), tbxPassword.Text.ToString(), dgvLoginHolder, "Employee") == true)
                {
                    frmEmployees employees = new frmEmployees();
                    employees.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username, password, or login type is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbManager.Checked == true)
            {
                if (ProgOps.UserLogin(tbxUsername.Text.ToString(), tbxPassword.Text.ToString(), dgvLoginHolder, "Manager") == true)
                {
                    frmManagers managers = new frmManagers();
                    managers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username, password, or login type is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a user type", "Error");
            }
        }
    }
}
