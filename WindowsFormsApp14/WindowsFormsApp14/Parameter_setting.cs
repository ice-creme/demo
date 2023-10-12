using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Paramete_setting : Form
    {

        int xmax = 0;
        int ymax = 0;
        int xmin = 0;
        int ymin = 0;
        public Paramete_setting()
        {
            InitializeComponent();

        }
        private void min_max()
        {
            xmax = Convert.ToInt32(Xmax.Text);
            ymax = Convert.ToInt32(Ymax.Text);
            xmin = Convert.ToInt32(Xmin.Text);
            ymin = Convert.ToInt32(Ymin.Text);
        }
    }
}
