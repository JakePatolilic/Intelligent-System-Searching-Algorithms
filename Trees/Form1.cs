using System.Xml.Linq;
using System.Drawing;
using System;
using TreeAlgo;

namespace Trees
{
    public partial class Form1 : Form
    {
        private Dictionary<char, Point> vertexLocations = new Dictionary<char, Point>();
        private Pen edgePen = new Pen(Color.Black, 2);
        private Random random = new Random();
        private Search search;

        private bool isDragging = false;
        private char draggedVertex = ' ';
        private Point offset;

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_TextChanged;
            textBox2.KeyPress += textBox2_TextChanged;
            textBox4.KeyPress += textBox4_TextChanged;
            panel1.MouseClick += panel1_MouseClick;
            comboBox1.Items.Add("BFS");
            comboBox1.Items.Add("DFS");
            comboBox1.Items.Add("A*");

            search = new Search(100);
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && textBox1.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && textBox2.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && textBox4.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char vertex1 = textBox1.Text.ToUpper()[0];
            char vertex2 = textBox2.Text.ToUpper()[0];
            int weight = int.Parse(textBox4.Text);

            // Connect the vertices
            ConnectVertices(vertex1, vertex2, weight);

            char v, w;
            int x;
            if (char.TryParse(vertex1.ToString(), out v) && char.TryParse(vertex2.ToString(), out w))
            {
                search.AddEdge(v, w, weight);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the clicked position
            Point clickLocation = e.Location;

            // Generate a unique vertex label (you can modify this part based on your needs)
            char newVertexLabel = (char)('A' + vertexLocations.Count);

            // Draw a circle for the vertex
            using (Graphics g = panel1.CreateGraphics())
            {
                g.FillEllipse(Brushes.Green, clickLocation.X - 25, clickLocation.Y - 25, 50, 50);
                g.DrawString(newVertexLabel.ToString(), Font, Brushes.Red, clickLocation.X - 10, clickLocation.Y - 5);
            }

            // Save the location of the vertex
            vertexLocations[newVertexLabel] = clickLocation;
        }

        private void ConnectVertices(char vertex1, char vertex2, int weight)
        {
            // Connect the vertices with a line
            if (vertexLocations.ContainsKey(vertex1) && vertexLocations.ContainsKey(vertex2))
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    Point point1 = vertexLocations[vertex1];
                    Point point2 = vertexLocations[vertex2];

                    // Draw the line
                    g.DrawLine(edgePen, point1, point2);

                    // Calculate the midpoint for placing the weight
                    float midX = (point1.X + point2.X) / 2f;
                    float midY = (point1.Y + point2.Y) / 2f;

                    // Get the weight associated with this edge
                    char v, w;
                    if (char.TryParse(vertex1.ToString(), out v) && char.TryParse(vertex2.ToString(), out w))
                    {
                        //int weight = search.GetEdgeWeight(v, w);
                        // Draw the weight
                        g.DrawString(weight.ToString(), Font, Brushes.Black, midX, midY);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            char startVertex = textBox3.Text.ToUpper()[0];
            char end = textBox5.Text.ToUpper()[0];
            //char end = char.Parse(textBox5.Text);

            // Perform BFS with steps

            string selectedAlgorithm = comboBox1.SelectedItem.ToString();

            if (selectedAlgorithm == "BFS")
            {
                // Perform BFS with steps
                search.BFS(startVertex, end);
            }
            else if (selectedAlgorithm == "DFS")
            {
                // Perform DFS with steps
                search.DFS(startVertex, end);
            }

            // Display the steps in the TextBox (optional)
            //textBoxSteps.Text = string.Join(", ", search.steps);

            // Visualize the steps (change vertex colors)
            VisualizeSteps();

        }

        private void VisualizeSteps()
        {
            // Iterate through the recorded steps and change vertex colors
            foreach (char step in search.steps)
            {
                ChangeVertexColor(step, Color.Red);
                System.Threading.Thread.Sleep(500); // Optional delay for visualization
                Application.DoEvents(); // Allow the GUI to update
            }
        }

        private void ChangeVertexColor(char vertex, Color color)
        {
            if (vertexLocations.ContainsKey(vertex))
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    Point vertexLocation = vertexLocations[vertex];
                    g.FillEllipse(new SolidBrush(color), vertexLocation.X - 25, vertexLocation.Y - 25, 50, 50);
                    g.DrawString(vertex.ToString(), Font, Brushes.Black, vertexLocation.X - 10, vertexLocation.Y - 5);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (char step in search.steps)
            {
                ChangeVertexColor(step, Color.Green);
                // System.Threading.Thread.Sleep(500); // Optional delay for visualization
                Application.DoEvents(); // Allow the GUI to update
            }
            search.steps.Clear();
            search.dfsFlag = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}