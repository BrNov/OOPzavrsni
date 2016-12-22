using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace OOPzavrsni
{
    public partial class Form1 : Form
    {
        Point sp = new Point(0, 0);
        Point ep = new Point(0,0);
        Point mp = new Point(0,0);
        bool c = false;

        int debljina = 1;
        bool close = false;
     
        List<GrafickiOblici> objektiList=new List<GrafickiOblici>(); 

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, drawPanel, new object[] { true });

            debljinaTextBox.Text = debljina.ToString();

        }

        private void bojaButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                bojaButton.BackColor = colorDialog1.Color;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                sp = e.Location;
                c = true;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (c == true) 
            {
                ep = e.Location;
                Refresh();
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {

                ep = e.Location;
                c = false;
                Pen p = new Pen(bojaButton.BackColor, debljina);
                SolidBrush sb = new SolidBrush(Color.Transparent);

                if(linijaButton.Checked==true)
                {
                    Linija l = new Linija(p, sp, ep);
                    objektiList.Add(l);
                }
                if (kruznicaButton.Checked == true)
                {
                    //kruznica ispuna
                    if (ispunaButton.Checked == false)
                    {
                        Kruznica k = new Kruznica(p,sb, sp, ep);
                        objektiList.Add(k);
                    }
                    else
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Kruznica k = new Kruznica(p,sb, sp, ep);
                        objektiList.Add(k);
                    }


                }
                if (pravokutnikButton.Checked == true)
                {
                    Point sP = sp, eP = ep;
                    if (sP.X > eP.X)
                    {
                        int temp = sp.X;
                        sP.X = eP.X;
                        eP.X = temp;
                    }
                    if (sP.Y > eP.Y)
                    {
                        int temp = sP.Y;
                        sP.Y = eP.Y;
                        eP.Y = temp;
                    }
                    //ispuna pravokutnika
                    if (ispunaButton.Checked == false) 
                    {
                        Pravokutnik pravokutnik = new Pravokutnik(p, sb, sP, eP);
                        objektiList.Add(pravokutnik);
                    }
                    else 
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Pravokutnik pravokutnik = new Pravokutnik(p, sb, sP, eP);
                        objektiList.Add(pravokutnik);
                    }
                }


                //Trokut
                if (trokutButton.Checked == true)
                {
                    mp.X = sp.X;
                    mp.Y = ep.Y;
                  
                    if (ispunaButton.Checked == false)
                    {
                        Trokut t = new Trokut(p,sb, sp, mp, ep);
                        objektiList.Add(t);
                    }
                    else
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Trokut t = new Trokut(p,sb, sp, mp, ep);
                        objektiList.Add(t);
                    }
                }
                c = false;
                Refresh();
            }

        }

        private void linijaButton_Click(object sender, EventArgs e)
        {
            linijaButton.Checked = true;
            kruznicaButton.Checked = false;
            pravokutnikButton.Checked = false;
            trokutButton.Checked = false;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(bojaButton.BackColor, debljina);
            SolidBrush sb = new SolidBrush(Color.Transparent);

            foreach (GrafickiOblici o in objektiList) 
            {
                o.crtaj(g);
            }

            if (c==true)
            {

                if (linijaButton.Checked == true)
                {
                    Linija l = new Linija(p, sp, ep);
                    l.crtaj(g);

                }

                if (kruznicaButton.Checked == true)
                {

                    //kruznica ispuna
                    if (ispunaButton.Checked == false)
                    {
                        Kruznica k = new Kruznica(p, sb, sp, ep);
                        k.crtaj(g);
                    }
                    else
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Kruznica k = new Kruznica(p, sb, sp, ep);
                        k.crtaj(g);
                    }

                }

                if (pravokutnikButton.Checked == true)
                {
                    Point sP = sp, eP = ep;
                    if (sP.X > eP.X)
                    {
                        int temp = sp.X;
                        sP.X = eP.X;
                        eP.X = temp;
                    }
                    if (sP.Y > eP.Y)
                    {
                        int temp = sP.Y;
                        sP.Y = eP.Y;
                        eP.Y = temp;
                    }
                    //pravokutnik ispuna
                    if (ispunaButton.Checked == false)
                    {
                        Pravokutnik pravokutnik = new Pravokutnik(p, sb, sP, eP);
                        pravokutnik.crtaj(g);
                    }
                    else
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Pravokutnik pravokutnik = new Pravokutnik(p, sb, sP, eP);
                        pravokutnik.crtaj(g);
                    }
                }
                //trokut

                if (trokutButton.Checked == true)
                {
                    mp.X = sp.X;
                    mp.Y = ep.Y;
                    //trokut ispuna
                    if (ispunaButton.Checked == false)
                    {
                        Trokut t = new Trokut(p, sb, sp, mp, ep);
                        t.crtaj(g);
                    }
                    else
                    {
                        sb.Color = ispunaCollor.BackColor;
                        Trokut t = new Trokut(p, sb, sp, mp, ep);
                        t.crtaj(g);
                    }

                }
            }

        }

        private void kruznicaButton_Click(object sender, EventArgs e)
        {
            kruznicaButton.Checked = true;
            linijaButton.Checked = false;
            pravokutnikButton.Checked = false;
            trokutButton.Checked = false;

        }

        private void pravokutnikButton_Click(object sender, EventArgs e)
        {
            kruznicaButton.Checked = false;
            linijaButton.Checked = false;
            pravokutnikButton.Checked = true;
            trokutButton.Checked = false;
        }

        private void ocistiPapir_Click(object sender, EventArgs e)
        {
            
            objektiList.Clear();
            Refresh();
        }

  

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Izradio:\tBruno Novak\nSmjer:\tRačunarstvo \nKolegij:\tObjektno orijentirano programiranje\n\nMeđimursko Veleučilište u Čakovcu");

        }
        //save
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                Bitmap bmp = new Bitmap(drawPanel.Width, drawPanel.Height);
                drawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, drawPanel.Width, drawPanel.Height));
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void trokutButton_Click(object sender, EventArgs e)
        {
            kruznicaButton.Checked = false;
            linijaButton.Checked = false;
            pravokutnikButton.Checked = false;
            trokutButton.Checked = true;

        }

        private void ispunaCollor_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                ispunaCollor.BackColor = colorDialog2.Color;
            }
        }

        private void ispunaButton_Click(object sender, EventArgs e)
        {
            if (ispunaButton.Checked == true)
            {
                ispunaButton.Checked = false;
            }
            else 
            {
                ispunaButton.Checked = true;
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objektiList.Count > 0) { 
                objektiList.RemoveAt(objektiList.Count - 1);
                Refresh();
                
            }
        }
        //save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objektiList.Count > 0)
            {
                SaveForm saveForm = new SaveForm();
                saveForm.ShowDialog();

                if(saveForm.potvrda == true)
                {
                    saveFileDialog1.ShowDialog();
                }

                close = true;
                System.Windows.Forms.Application.Exit();
            }
        }
     
        private void plusButton_Click(object sender, EventArgs e)
        {
            if(debljina < 5)
            {
                debljina++;
            }

            debljinaTextBox.Text = debljina.ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if(debljina > 1)
            {
                debljina--;
            }

            debljinaTextBox.Text = debljina.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image img = Image.FromFile(openFileDialog1.FileName);
            drawPanel.Width = img.Width;
            drawPanel.Height = img.Height;
            drawPanel.BackgroundImage = img;
            objektiList.Clear();
            
            Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (objektiList.Count > 0 && close == false)
            {
                SaveForm saveForm = new SaveForm();
                saveForm.ShowDialog();

                if (saveForm.potvrda == true)
                {
                    saveFileDialog1.ShowDialog();
                }
            }
        }
    }
}
