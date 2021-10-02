using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Schutz
{
    public partial class AddQuote : Form
    {

        private bool isReadyToConfirm = false;
        private Desk newDesk { get; set; }
        public DeskQuote newQuote { get; set; }

        private MainMenu ParentMenu { get; }

        public AddQuote(MainMenu parent)
        {
            this.ParentMenu = parent;

            InitializeComponent();
        }

        private void addQuoteBackButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void widthTextbox_TextChanged(object sender, EventArgs e)
        {
            int width;
            // If widthTextbox value is an integer
            if (int.TryParse(widthTextbox.Text, out width))
            {
                // Out of bounds
                if (width < 24 || width > 96)
                {
                    widthTextbox.BackColor = Color.LightCoral;
                    MessageBox.Show("Please choose a width between 24 and 96 inches", "Error");
                    widthTextbox.Focus();
                }
                else
                {
                    widthTextbox.BackColor = Color.White;
                }
            }
        }

        private void depthTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            String customerName = customerNameLabel.Text;
            int width, depth, drawers, rushOrder, materialsIndex;
            DesktopMaterial material;

            // If all our numbers work
            if(int.TryParse(widthTextbox.Text, out width) && int.TryParse(depthTextbox.Text, out depth) && !String.IsNullOrEmpty(customerNameTextbox.Text))
            {
                if(width < 24 || width > 96)
                {
                    MessageBox.Show("Please enter a width between 24 and 96 inches.", "Error");
                }
                if(depth <12 || depth > 48)
                {
                    MessageBox.Show("Please enter a depth between 12 and 48 inches.", "Error");
                    depthTextbox.BackColor = Color.LightCoral;
                    return;
                }
                else
                {
                    depthTextbox.BackColor = Color.White;
                }

                rushOrder = rushOrderOptionsBox.SelectedIndex;
                drawers = (int)drawersNumberCounter.Value;

                materialsIndex = desktopMaterialBox.SelectedIndex;
                switch(materialsIndex)
                    {
                        case 0:
                            material = DesktopMaterial.Laminate;
                            break;
                        case 1:
                            material = DesktopMaterial.Oak;
                            break;
                        case 2:
                            material = DesktopMaterial.Rosewood;
                            break;
                        case 3:
                            material = DesktopMaterial.Veneer;
                            break;
                        case 4:
                            material = DesktopMaterial.Pine;
                            break;
                        default:
                            material = DesktopMaterial.Laminate;
                            break;
                    }
                
                newDesk = new Desk(width, depth, drawers, material);
                newQuote = new DeskQuote(newDesk, customerNameTextbox.Text, rushOrder);

                newQuote.CalculateQuote();

                totalAreaLabel.Text = newQuote.area.ToString() + " in squared";
                areaCostLabel.Text = "$" + newQuote.areaCost.ToString();
                drawerPriceLabel.Text = "$" + newQuote.drawerCost.ToString();
                materialPriceLabel.Text = "$" + newQuote.materialCost.ToString();
                rushOrderPriceLabel.Text = "$" + newQuote.rushOrderCost.ToString();
                totalCostLabel.Text = "$" + newQuote.totalCost.ToString();

                isReadyToConfirm = true;
                confirmAddQuote.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please fill in all boxes.", "Error");
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            rushOrderOptionsBox.SelectedIndex = 0;
            desktopMaterialBox.SelectedIndex = 0;
        }

        private void drawersNumberCounter_Validated(object sender, EventArgs e)
        {
            if(drawersNumberCounter.Value > 7)
            {
                drawersNumberCounter.Value = 7;
            }
            if(drawersNumberCounter.Value < 0)
            {
                drawersNumberCounter.Value = 0;
            }
        }

        private void depthTextbox_Validated(object sender, EventArgs e)
        {
            int depth;
            // If depthTextbox value is an integer
            if (int.TryParse(depthTextbox.Text, out depth))
            {
                // Out of bounds
                if (depth < 12 || depth > 48)
                {
                    depthTextbox.BackColor = Color.LightCoral;
                    MessageBox.Show("Please choose a depth between 12 and 48 inches", "Error");
                    depthTextbox.Focus();
                }
                else
                {
                    depthTextbox.BackColor = Color.White;
                }
            }
        }

        private void widthTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void confirmAddQuote_Click(object sender, EventArgs e)
        {
            if(!isReadyToConfirm)
            {
                MessageBox.Show("Please create and view quote first before confirming order.", "Error");
                return;
            }
            DisplayQuote viewDisplayQuote = new DisplayQuote(this);
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }
    }
}
