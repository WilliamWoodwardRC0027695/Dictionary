using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Dictionary<string, double> prefixes = new Dictionary<string, double>();
            prefixes.Add("nm", 1e-9);
            prefixes.Add("μm", 1e-6);
            prefixes.Add("mm", 1e-3);
            prefixes.Add("m", 1);
            prefixes.Add("km", 1e3);
            prefixes.Add("Mm", 1e6);
            prefixes.Add("Gm", 1e9);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
