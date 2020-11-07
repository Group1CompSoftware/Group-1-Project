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
    public partial class frmCustomers : Form
    {
        //declaring variables
        const int SIZE = 10;
        double total = 0;
        Items[] items = new Items[SIZE];

        //creating Item structure for items on form
        struct Items
        {
            public string name;
            public double cost;
            public int quantity;
        }

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //opens checkout form

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            //creating item objects
            items[0].name = "Apples";
            items[0].cost = .50;
            items[0].quantity = 5;

            items[1].name = "Bananas";
            items[1].cost = .75;
            items[1].quantity = 8;

            items[2].name = "Grapes";
            items[2].cost = .80;
            items[2].quantity = 4;

            items[3].name = "Carrots";
            items[3].cost = 1.00;
            items[3].quantity = 5;

            items[4].name = "Oranges";
            items[4].cost = .50;
            items[4].quantity = 6;

            items[5].name = "Eggs";
            items[5].cost = 3.50;
            items[5].quantity = 10;

            items[6].name = "Steak";
            items[6].cost = 5.00;
            items[6].quantity = 3;

            items[7].name = "Bread";
            items[7].cost = 2.00;
            items[7].quantity = 7;

            items[8].name = "Milk";
            items[8].cost = 3.00;
            items[8].quantity = 3;

            items[9].name = "Chicken";
            items[9].cost = 4.50;
            items[9].quantity = 6;
        }

        private void pbxApples_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[0].quantity > 0)
            {
                items[0].quantity -= 1;
                total += items[0].cost;
                lblApplesInventory.Text = items[0].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[0].quantity == 0)
                MessageBox.Show("Apples are sold out!", "SOLD OUT");
        }

        private void pbxBananas_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[1].quantity > 0)
            {
                items[1].quantity -= 1;
                total += items[1].cost;
                lblBananaInventory.Text = items[1].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[1].quantity == 0)
                MessageBox.Show("Bananas are sold out!", "SOLD OUT");
        }

        private void pbxGrapes_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[2].quantity > 0)
            {
                items[2].quantity -= 1;
                total += items[2].cost;
                lblGrapesInventory.Text = items[2].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[2].quantity == 0)
                MessageBox.Show("Grapes are sold out!", "SOLD OUT");
        }

        private void pbxCarrots_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[3].quantity > 0)
            {
                items[3].quantity -= 1;
                total += items[3].cost;
                lblCarrotsInventory.Text = items[3].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[3].quantity == 0)
                MessageBox.Show("Carrots are sold out!", "SOLD OUT");
        }

        private void pbxEggs_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[5].quantity > 0)
            {
                items[5].quantity -= 1;
                total += items[5].cost;
                lblEggsInventory.Text = items[5].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[5].quantity == 0)
                MessageBox.Show("Eggs are sold out!", "SOLD OUT");
        }

        private void pbxOranges_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[4].quantity > 0)
            {
                items[4].quantity -= 1;
                total += items[4].cost;
                lblOrangesInventory.Text = items[4].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[4].quantity == 0)
                MessageBox.Show("Oranges are sold out!", "SOLD OUT");
        }

        private void pbxSteak_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[6].quantity > 0)
            {
                items[6].quantity -= 1;
                total += items[6].cost;
                lblSteakInventory.Text = items[6].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[6].quantity == 0)
                MessageBox.Show("Steak is sold out!", "SOLD OUT");
        }

        private void pbxBread_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[7].quantity > 0)
            {
                items[7].quantity -= 1;
                total += items[7].cost;
                lblBreadInventory.Text = items[7].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[7].quantity == 0)
                MessageBox.Show("Bread is sold out!", "SOLD OUT");
        }

        private void pbxMilk_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[8].quantity > 0)
            {
                items[8].quantity -= 1;
                total += items[8].cost;
                lblMilkInventory.Text = items[8].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[8].quantity == 0)
                MessageBox.Show("Milk is sold out!", "SOLD OUT");
        }

        private void pbxChicken_Click(object sender, EventArgs e)
        {
            //loops until quantity is 0 and displays sold out message
            //adds items to customers cart
            while (items[9].quantity > 0)
            {
                items[9].quantity -= 1;
                total += items[9].cost;
                lblChickenInventory.Text = items[9].quantity.ToString();
                //add to the customers total
                //lblTotal.Text = total.ToString("C");
                break;
            }
            if (items[9].quantity == 0)
                MessageBox.Show("Chicken is sold out!", "SOLD OUT");
        }
    }
    
    
}
