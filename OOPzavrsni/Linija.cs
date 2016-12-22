using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPzavrsni
{
    class Linija:GrafickiOblici
    {
        System.Drawing.Point sp = new System.Drawing.Point(0, 0);
        System.Drawing.Point ep = new System.Drawing.Point(0, 0);

        public Linija() 
        {

        }

        public Linija(System.Drawing.Pen p, System.Drawing.Point s, System.Drawing.Point e) 
        {
            sp = s;
            ep = e;
            pen = p;

        }

        public override void crtaj(System.Drawing.Graphics g) 
        {
            g.DrawLine(pen, sp, ep);

        }
    }
}
