using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_form
{
    public class History
    {

        public List<Cell[,]> maze = new List<Cell[,]>();
        public List<Cell[,]> Grid = new List<Cell[,]>();
        public List<int> mazeElapsedTime = new List<int>();
        public List<int> gridElapsedTime = new List<int>();

        public History()
        {

        }

        public void showMazeElapsedTime(Cell[,] cell, List<Tuple<int, int>> path, System.Windows.Forms.Control.ControlCollection control)
        {

            maze.Add(cell);
            mazeElapsedTime.Add(path.Count);
            Button time = new Button();
            time.Text = "Geçen Süre: " + path.Count + " sn";
            time.Size = new Size(150, 70);
            time.Location = new Point(295 + maze[maze.Count - 1].GetLength(0) * 25, 100 + (maze[maze.Count - 1].GetLength(1) * 25) / 2);
            saveHistory(path, "maze");
            control.Add(time);
        }

        public void showGridElapsedTime(Cell[,] cell, List<Tuple<int, int>> path, System.Windows.Forms.Control.ControlCollection control)
        {

            Grid.Add(cell);
            gridElapsedTime.Add(path.Count);
            Button time = new Button();
            time.Text = "Geçen Süre: " + path.Count + " sn";
            time.Size = new Size(150, 70);
            time.Location = new Point(370 + Grid[Grid.Count - 1].GetLength(0) * 35, -20 + (Grid[Grid.Count - 1].GetLength(1) * 35) / 2);
            saveHistory(path, "grid");
            control.Add(time);
        }

        public void saveHistory(List<Tuple<int, int>> path, string type)
        {
            string fileName = type + ".txt";

            using (StreamWriter sw = File.AppendText(fileName))
            {
                int i = 1;
                if (string.Equals(type, "maze"))
                    sw.WriteLine("Labirent Boyutu : " + maze[maze.Count - 1].GetLength(0).ToString() + ", " + maze[maze.Count - 1].GetLength(1).ToString());
                else sw.WriteLine("Izgaranın Boyutu : " + Grid[Grid.Count - 1].GetLength(0).ToString() + ", " + Grid[Grid.Count - 1].GetLength(1).ToString());

                foreach (Tuple<int, int> item in path)
                {
                    sw.WriteLine("Adım " + i + ": (" + item.Item1.ToString() + ", " + item.Item2.ToString() + ")");
                    i++;
                }

                sw.WriteLine("Geçen Süre: " + path.Count + " Saniye");
                sw.WriteLine();
                sw.Close();
            }


        }
    }
}
