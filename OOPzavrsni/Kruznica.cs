using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPzavrsni
{
    class Kruznica:GrafickiOblici
    {
         System.Drawing.Point sp=new System.Drawing.Point(0,0);
        System.Drawing.Point ep = new System.Drawing.Point(0, 0);

        public Kruznica() 
        {

        }

        public Kruznica(System.Drawing.Pen p,System.Drawing.Brush b, System.Drawing.Point s, System.Drawing.Point e) 
        {
            sp = s;
            ep = e;
            pen = p;
            brush = b;

        }

        public override void crtaj(System.Drawing.Graphics g) 
        {
          
            g.DrawEllipse(this.pen, sp.X, sp.Y, ep.X - sp.X, ep.Y - sp.Y);
            g.FillEllipse(this.brush, sp.X, sp.Y, ep.X - sp.X, ep.Y - sp.Y);
        }
    }
}
