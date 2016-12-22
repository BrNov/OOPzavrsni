using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPzavrsni
{
    class Trokut:GrafickiOblici
    {
        System.Drawing.Point sPoint = new System.Drawing.Point(0, 0);
        System.Drawing.Point ePoint = new System.Drawing.Point(0, 0);
        System.Drawing.Point mPoint = new System.Drawing.Point(0, 0);

        public Trokut()
        {
        }

        public Trokut(System.Drawing.Pen p, System.Drawing.Brush b, System.Drawing.Point sP, System.Drawing.Point mP, System.Drawing.Point eP)
        {
            this.pen = p;
            sPoint = sP;
            ePoint = eP;
            mPoint = mP;
            brush = b;
        }

        public override void crtaj(System.Drawing.Graphics g)
        {
            g.DrawPolygon(pen, new System.Drawing.Point[] { sPoint, mPoint, ePoint });
            g.FillPolygon(this.brush, new System.Drawing.Point[] { sPoint, mPoint, ePoint });

        }
    }
}
