using System.Windows.Forms;

namespace maze_form
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

        private void start1_Load(object sender, EventArgs e)
        {
            start1.problem_1 = problem_11;
            start1.problem_2 = problem_21;
        }

        private void problem_21_Load(object sender, EventArgs e)
        {

        }
        public static void problem2_Screen(int row, int col, UserControl problem2)
        {
            Maze maze = new Maze(row, col, problem2.Controls);
            maze.Generate();
            Button exit = new Button();
            exit.Text = "Çýkýþ";
            exit.Size = new Size(100, 50);
            exit.Location = new Point(150 + row * 25, 120 + (col * 25) / 2);
            problem2.Controls.Add(exit);
            exit.Click += (sender, args) =>
            {
                problem2.Controls.Clear();

                problem2.Visible = false;

            };

        }

    }
}