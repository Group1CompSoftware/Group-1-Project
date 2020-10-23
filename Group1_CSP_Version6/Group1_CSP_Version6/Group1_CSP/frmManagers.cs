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
    public partial class frmManagers : Form
    {
        public frmManagers()
        {
            InitializeComponent();
        }

        private void frmManagers_Load(object sender, EventArgs e)
        {
            ProgOps.ManagersDatabaseCommand(dgvManagersView);
        }

        private void frmManagers_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
