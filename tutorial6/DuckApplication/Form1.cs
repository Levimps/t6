using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuckLibrary;

namespace DuckApplication
{
    public partial class Form1 : Form
    {
        private DuckType _ducktype;
        private Duck _duck;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void CheckDuckType()
        {
            if (rdbMallard.Checked)
            {
                _ducktype = DuckType.MallardDuck;
            }
            if (rdbRedHead.Checked)
            {
                _ducktype = DuckType.RedHeadDuck;
            }
            if (rdbRubber.Checked)
            {
                _ducktype = DuckType.RubberDuck;
            }
            if (rdbDecoyDuck.Checked)
            {
                _ducktype = DuckType.DecoyDuck;
            }

            switch (_ducktype)
            {
                case DuckType.MallardDuck:
                    _duck = new MallardDuck();
                    break;
                case DuckType.RedHeadDuck:
                    _duck = new RedHeadDuck();
                    break;
                case DuckType.RubberDuck:
                    _duck = new RubberDuck();
                    break;
                case DuckType.DecoyDuck:
                    _duck = new DecoyDuck();
                    break;
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.Display();
        }

        private void Fly_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.PerformFly();
        }

        private void Quack_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.PerformQuack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
