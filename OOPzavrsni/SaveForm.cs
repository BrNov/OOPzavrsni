using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPzavrsni
{
    public partial class SaveForm : Form
    {
        public bool potvrda = false;

        public SaveForm()
        {
            InitializeComponent();
        }

        private void daButton_Click(object sender, EventArgs e)
        {
            potvrda = true;
            Close();
        }

        private void neButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
