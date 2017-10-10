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
using TestPaint;

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
            TestCommand xcom = new TestCommand();

            PMenu pMenu = new PMenu();
            pMenu.xcom = xcom;
            Controls.Add(pMenu);

            PToolStrip pTool = new PToolStrip();
            pTool.xcom = xcom;
            Controls.Add(pTool);
        }
    }
}
