using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Work_Figur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double side = double.Parse(txtBox.Text);
            #region
            if (rdBtnQud.Checked)
            {
                Quadrate x = new Quadrate(side);
                label1.Text = null;
                label1.Text = Convert.ToString(x.Yardage());
                Group summ = new Group();
                summ.AddFigure(x);
                lbSum.Text = Convert.ToString(summ.Sum());
            }
            
            if (rdButLap.Checked)
            {
                Lap x = new Lap(side);
                label1.Text = null;
                label1.Text = Convert.ToString(x.Yardage());
                Group summ = new Group();
                summ.AddFigure(x);
                lbSum.Text = Convert.ToString(summ.Sum());
            }

            if (rdButBall.Checked)
            {
                Ball x = new Ball(side);
                label1.Text = null;
                label1.Text = Convert.ToString(x.Yardage());
                Group summ = new Group();
                summ.AddFigure(x);
                lbSum.Text = Convert.ToString(summ.Sum());
            }
            #endregion

        }


    }
}
