using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Schutz
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public class Desk
    {
        public int width { get; }
        public int depth { get; }
        public int drawers { get; }
        public DesktopMaterial material { get; }

        public Desk(int xwidth, int xdepth, int xdrawers, DesktopMaterial xmaterial)
        {
            width = xwidth;
            depth = xdepth;
            drawers = xdrawers;
            material = xmaterial;
        }

        
    }
}
