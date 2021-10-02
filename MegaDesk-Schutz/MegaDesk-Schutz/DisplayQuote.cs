using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Schutz
{
    public partial class DisplayQuote : Form
    {
        public AddQuote ParentMenu { get; }
        public DisplayQuote(AddQuote parent)
        {
            this.ParentMenu = parent;
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            DeskQuote myQuote = ParentMenu.newQuote;

            // Fill in those text fields
            customerNameTextbox.Text = myQuote.customerName.ToString();
            widthCustomerLabel.Text = myQuote.customerDesk.width.ToString();
            depthCustomerLabel.Text = myQuote.customerDesk.depth.ToString();
            totalAreaLabel.Text = myQuote.area.ToString();
            areaCostLabel.Text = "$" + myQuote.areaCost.ToString();
            drawersCustomerLabel.Text = myQuote.drawers.ToString();
            drawerPriceLabel.Text = "$" + myQuote.drawerCost.ToString();
            desktopMaterialLabel.Text = myQuote.customerDesk.material.ToString();
            materialPriceLabel.Text = "$" + myQuote.getMaterialPrice(myQuote.customerDesk.material).ToString();
            rushOrderCustomerLabel.Text = getRushOrderDays(myQuote.rushDays);
            rushOrderPriceLabel.Text = "$" + myQuote.rushOrderCost.ToString();
            totalCostLabel.Text = "$" + myQuote.totalCost.ToString();
        }

        private String getRushOrderDays(int days)
        {
            switch(days)
            {
                case 0:
                    return "0";
                case 1:
                    return "3";
                case 2:
                    return "5";
                case 3:
                    return "7";
                default:
                    return "0";
            }
        }

        private void displayQuoteBackButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
