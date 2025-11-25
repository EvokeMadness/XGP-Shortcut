using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XGP_Shortcut
{
    public partial class Form2 : Form
    {
        string licensePath = Path.Combine(Environment.CurrentDirectory, "ImageMagick", "LICENSE.txt");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxLicenses.Text = File.ReadAllText(licensePath);
        }
    }
}
