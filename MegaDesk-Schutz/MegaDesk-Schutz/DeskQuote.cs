using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Schutz
{
    public class DeskQuote
    {
        public Desk customerDesk { get; }

        public String customerName { get; }
        public int area { get; }
        public int areaCost { get; set; }
        public int rushDays { get; }
        public int drawers { get; }
        public int drawerCost { get; set; }
        public int materialCost { get; set; }
        public int rushOrderCost { get; set; }
        public int totalCost { get; set; }
        public DateTime quoteDate { get; }

        public DeskQuote(Desk newCustomerDesk, String name, int newRushDays)
        {
            customerDesk = newCustomerDesk;
            customerName = name;
            area = newCustomerDesk.width * newCustomerDesk.depth;
            drawers = newCustomerDesk.drawers;
            quoteDate = DateTime.Now;
            rushDays = newRushDays;
            
        }
        public void CalculateQuote()
        {
            // Calculate areaCost
            areaCost = 200;
            
            if (area > 1000)
            {
                areaCost += area - 1000;
            }
            else
            {
                areaCost = 200;
            }
            // Calculate drawerCost
            drawerCost = drawers * 50;

            // Calculate materialCost
            materialCost = getMaterialPrice(customerDesk.material);

            // Calculate rushOrderCost
            rushOrderCost = getRushOrderPrice(rushDays);

            totalCost = areaCost + drawerCost + materialCost + rushOrderCost;
        }

        public int getMaterialPrice(DesktopMaterial m)
        {
            switch (m)
            {
                case DesktopMaterial.Laminate:
                    return 100;

                case DesktopMaterial.Oak:
                    return 200;

                case DesktopMaterial.Rosewood:
                    return 300;

                case DesktopMaterial.Veneer:
                    return 125;

                case DesktopMaterial.Pine:
                    return 50;

                default:
                    return 0;

            }
        }

        public int getRushOrderPrice(int rushOrder)
        {
            switch(rushOrder)
            {
                case 0:
                    return 0;

                case 1:
                    if(area < 1000)
                    {
                        return 60;
                    }
                    else if(area >= 1000 && area <= 2000)
                    {
                        return 70;
                    }
                    else if(area > 2000)
                    {
                        return 80;
                    }
                    break;
                case 2:
                    if(area < 1000)
                    {
                        return 40;
                    }
                    else if(area >= 1000 && area <= 2000)
                    {
                        return 50;
                    }
                    else if(area > 2000)
                    {
                        return 60;
                    }
                    break;
                case 3:
                    if(area < 1000)
                    {
                        return 30;
                    }
                    else if(area >= 1000 && area <= 2000)
                    {
                        return 35;
                    }
                    else if(area > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }
    }
}
