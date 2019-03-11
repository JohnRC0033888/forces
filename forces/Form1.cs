using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double X)
        {
            return (Math.Asin(X) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.XCos(x * Math.PI / 180.0));
        }

        double acos(double X)
        {
            return (Math.Acos(X) * 180 / Math.PI);
        }

    }
}
