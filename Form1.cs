using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4_tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random rnd = new Random();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();

            int num = Convert.ToInt32(nudNum.Value);

            for (int i = 1; i <= 10; i++)
                lstTabuada.Items.Add(i + " x " + num + " = " + num * i);

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            BackColor = randomColor;
        }


    }
}
