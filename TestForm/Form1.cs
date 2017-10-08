using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakePaintGreatAgain;
using MakePaintGreatAgain.Controls;
using MakePaintGreatAgain.API;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Controls.Add(new PMenu());
            Controls.Add(new PToolStrip());
        }
    }
}
