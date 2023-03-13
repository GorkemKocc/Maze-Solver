using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace maze_form
{
    public partial class Start : UserControl
    {
        public UserControl problem_1 = new UserControl();
        public UserControl problem_2 = new UserControl();
        public int Row;
        public int Col;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            problem_1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Row = int.Parse(textBox1.Text) % 2 == 0 ? int.Parse(textBox1.Text) + 1 : int.Parse(textBox1.Text);
            Col = int.Parse(textBox2.Text) % 2 == 0 ? int.Parse(textBox2.Text) + 1 : int.Parse(textBox2.Text);
            problem_2.Visible = true;
            Form1.problem2_Screen(Row, Col, problem_2);
        }
    }
}
