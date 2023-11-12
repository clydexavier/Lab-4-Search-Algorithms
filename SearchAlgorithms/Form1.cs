using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SearchAlgorithms
{
    public partial class Form1 : Form
    {
        public List<Vertex> Vertices= new List<Vertex>();
        public List<Edge> Edges= new List<Edge>();  
        public Graph Graph = new Graph();

        private bool isPaused = true;
        char ID = 'A';
        int IDX = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void PictureBoxGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if(AddVertex.Checked)
            {
                // Get the clicked point
                Point clickPoint = e.Location;
                Vertices.Add(new Vertex(ID, IDX,e.Location));



                // Create a Graphics object from the PictureBox
                Graphics g = PictureBoxGraph.CreateGraphics();

                // Define the circle's position and size
                int diameter = 50;
                int x = clickPoint.X - diameter / 2;
                int y = clickPoint.Y - diameter / 2;

                // Create a green brush
                Brush greenBrush = new SolidBrush(Color.Green);
                Pen blackBrush = new Pen(Color.Black);

                int textX = e.X - diameter/ 8;
                int textY = e.Y - diameter / 8;
                // Fill a green circle
                g.FillEllipse(greenBrush, x, y, diameter, diameter);
                g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                g.DrawString(ID.ToString(), this.Font, Brushes.White, textX, textY);

                RefreshSource();

                // Dispose of the brush and Graphics object
                greenBrush.Dispose();
                g.Dispose();
                ID++;
                IDX++;
            }
        }

        private void AddEdge_CheckedChanged(object sender, EventArgs e)
        {
            if(AddEdge.Checked) 
            {
                ComboBoxFrom.Enabled = true;
                ComboBoxTo.Enabled = true;
                TextBoxWeight.Enabled = true;
            }
            else
            {
                ComboBoxFrom.Enabled = false;
                ComboBoxTo.Enabled = false;
                TextBoxWeight.Enabled = false;
            }
            
        }

        private void ComboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(ComboBoxFrom.SelectedIndex == -1 || ComboBoxTo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TextBoxWeight.Text)) 
            {
                MessageBox.Show("Complete empty fields!");
                return;
            }
            if(!int.TryParse(TextBoxWeight.Text, out int weight))
            {
                MessageBox.Show("Input valid weight!");
                return;
            }
            if(ComboBoxFrom.SelectedIndex == ComboBoxTo.SelectedIndex)
            {
                MessageBox.Show("Choose another destination vertex!");
                return;
            }

            Vertex start = Vertices[ComboBoxFrom.SelectedIndex];
            Vertex end = Vertices[ComboBoxTo.SelectedIndex];
            Edges.Add(new Edge(start, end, weight));
           // MessageBox.Show($"Vertex {start} connected to vertex {end} with weight {weight}.");
            
            Graphics g = PictureBoxGraph.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            Brush brush = new SolidBrush(Color.Black);
            float textX = (start.Location.X + end.Location.X) / 2;
            float textY = (start.Location.Y + end.Location.Y) / 2;



            

            // Draw the weight text at the calculated position
            g.DrawString(weight.ToString(), font, brush, textX, textY);

            g.DrawLine(pen, start.Location, end.Location);
            PaintVertex();

            pen.Dispose();
            g.Dispose();

        }

        private void ButtonFinalize_Click(object sender, EventArgs e)
        {
            if(Edges.Count == 0)
            {
                MessageBox.Show("Add at least one edge!");
                return;
            }
            ComboBoxFrom.Enabled = false;
            ComboBoxTo.Enabled = false;
            TextBoxWeight.Enabled = false;
            AddEdge.Enabled = false;
            AddVertex.Enabled = false;
            ButtonAdd.Enabled = false;

            LogBox.Enabled = true;
            ButtonBFS.Enabled = true;
            ButtonDFS.Enabled = true;
            ButtonAStar.Enabled = true;
            ButtonBeam.Enabled = true;
            ButtonBnB.Enabled = true;
            ButtonHC.Enabled = true;
            ComboBoxStart.Enabled = true;
            ComboBoxSearch.Enabled = true;
            ButtonRun.Enabled = true;
            TrackbarSpeed.Enabled = true;
            Graph.initMtx(Vertices.Count);
            Graph.updateMtx(Edges);

        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if(ComboBoxStart.SelectedIndex == -1 )
            {
                MessageBox.Show("Select a starting vertex!");
                return;
            }
            ButtonPause.Enabled = true;
            isPaused = false;
            ButtonPause.Text = "Pause";
            Vertex start = ComboBoxStart.SelectedItem as Vertex;
            Vertex search = ComboBoxSearch.SelectedItem as Vertex;
            
            if(ButtonBFS.Checked)
            {
                List<Vertex> order = Graph.BFS_order(Vertices, start, search, Vertices.Count);
                traverse(order);
            }
            else if (ButtonDFS.Checked) 
            {
                List<Vertex> order = Graph.DFS_order(Vertices, start, search, Vertices.Count);
                traverse(order);
            }
            isPaused = true;
            ButtonPause.Text = "Play";
            ButtonPause.Enabled = false;
            
        }

        public async void traverse(List<Vertex> vertices)
        {
            Graphics g = PictureBoxGraph.CreateGraphics();

            // Create a green brush
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Pen blackBrush = new Pen(Color.Black);
            Vertex u = ComboBoxSearch.SelectedItem as Vertex;

            int diameter = 50;
            foreach (Vertex v in vertices) 
            {

                
                int x = v.Location.X - diameter / 2;
                int y = v.Location.Y - diameter / 2;

                int textX = v.Location.X - diameter / 8;
                int textY = v.Location.Y - diameter / 8;

                g.FillEllipse(redBrush, x, y, diameter, diameter);
                g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);
                if(v.Equals(u))
                {
                    g.FillEllipse(yellowBrush, x, y, diameter, diameter);
                    g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                    g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);

                }

                await Task.Delay(1000/(TrackbarSpeed.Value + 1));

                g.FillEllipse(greenBrush, x, y, diameter, diameter);
                g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);
            }

            greenBrush.Dispose();
            g.Dispose();
        }


        private void ButtonPause_Click(object sender, EventArgs e)
        {
            //if(isPaused)
        }

        private void PaintVertex()
        {
            Graphics g = PictureBoxGraph.CreateGraphics();
            // Create a green brush
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Pen blackBrush = new Pen(Color.Black);
            Vertex u = ComboBoxSearch.SelectedItem as Vertex;

            int diameter = 50;
            foreach (Vertex v in Vertices)
            {
                int x = v.Location.X - diameter / 2;
                int y = v.Location.Y - diameter / 2;

                int textX = v.Location.X - diameter / 8;
                int textY = v.Location.Y - diameter / 8;

                g.FillEllipse(redBrush, x, y, diameter, diameter);
                g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);
                
                g.FillEllipse(greenBrush, x, y, diameter, diameter);
                g.DrawEllipse(blackBrush, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);
            }

            greenBrush.Dispose();
            g.Dispose();
        }

        private void PaintEdges()
        {
            Graphics g = PictureBoxGraph.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            Brush brush = new SolidBrush(Color.Black);

            foreach(Edge edge in Edges) 
            {
                float textX = (edge.From.Location.X + edge.To.Location.X) / 2;
                float textY = (edge.From.Location.Y + edge.To.Location.Y) / 2;
                // Draw the weight text at the calculated position
                g.DrawString(edge.Cost.ToString(), font, brush, textX, textY);

                g.DrawLine(pen, edge.From.Location, edge.To.Location);

            }


            pen.Dispose();
            g.Dispose();

        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (Vertices.Count <= 0) return;

            IDX--;
            ID--;
            PictureBoxGraph.Image = null;
            Vertices.RemoveAt(Vertices.Count-1);
            RefreshSource();
            PictureBoxGraph.Update();
            PaintVertex();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Edges.Count <= 0) return;

            PictureBoxGraph.Image= null;
            Edges.RemoveAt(Edges.Count-1);
            RefreshSource();
            PictureBoxGraph.Update();
            PaintEdges();
        }

        private void RefreshSource()
        {
            ComboBoxFrom.DataSource = null;
            ComboBoxTo.DataSource = null;
            ComboBoxStart.DataSource = null;
            ComboBoxSearch.DataSource = null;

            ComboBoxFrom.DataSource = new List<Vertex>(Vertices);
            ComboBoxTo.DataSource = new List<Vertex>(Vertices);
            ComboBoxStart.DataSource = Vertices;
            ComboBoxSearch.DataSource = new List<Vertex>(Vertices);
        }
    }
}