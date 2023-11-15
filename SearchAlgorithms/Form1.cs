using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SearchAlgorithms
{
    public partial class Form1 : Form
    {
       
        public bool AnimationPaused = false;
        public bool AnimationRunning = false;
        // Contains all the ertices in the graph
        public List<Vertex> Vertices= new List<Vertex>();
        
        // Contains all the edges in the graph
        public List<Edge> Edges= new List<Edge>();  

        // Graph that is being used in the graph
        // Contains the adjacency matrix and searching algorithms
        public Graph Graph = new Graph();

        // Stores the path from starting vertex to the vertex that is being searched
        public List<Vertex> Path = new List<Vertex>();
        
        // Use for indexing current node that is being highlighted when animating
        // the search path
        private int CurrentNodeIndex = 0;

        // Vertex that is being searched in every traversal
        Vertex SearchVertex;
        // Starting vertex of the graph when searching
        Vertex StartVertex;
        
        // Object use when drawing the vertices
        Graphics g;

        // Flag to know if the animation is currently paused
        private bool isPaused = true;
        
        // Used for labeling newly added vertices
        char VertexLabel = 'A';

        // Used for indexing newly added vertices
        int VertexIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
            g = this.PictureBoxGraph.CreateGraphics();
        }


        private void PictureBoxGraph_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
       
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Checker used to ensure the user selected two vertcies when creating an edge
            if(ComboBoxFrom.SelectedIndex == -1 || ComboBoxTo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TextBoxWeight.Text)) 
            {
                MessageBox.Show("Complete empty fields!");
                return;
            }

            // Checker used to make sure the inputted weight is valid i.e. int
            if(!int.TryParse(TextBoxWeight.Text, out int weight))
            {
                MessageBox.Show("Input valid weight!");
                return;
            }

            // Checker used to make sure source vertex and destination vertex
            // are different when creating an edge between the two of them
            if(ComboBoxFrom.SelectedIndex == ComboBoxTo.SelectedIndex)
            {
                MessageBox.Show("Choose another destination vertex!");
                return;
            }

            // Source vertex
            Vertex start = Vertices[ComboBoxFrom.SelectedIndex];
            // Destinatino vertex
            Vertex end = Vertices[ComboBoxTo.SelectedIndex];
            // Add newly created edge to list of edges
            Edges.Add(new Edge(start, end, weight));
            
            // Font used for labeling
            Font font = new Font("Arial", 10);
            
            // corrected location so that the label will be in center
            float textX = (start.Location.X + end.Location.X) / 2;
            float textY = (start.Location.Y + end.Location.Y) / 2;

            // Draw the weight text at the calculated position
            g.DrawString(weight.ToString(), font, Brushes.Black, textX, textY);
            g.DrawLine(Pens.Black, start.Location, end.Location);
            // To make sure the line will not go inside tha circles' radius
            PaintVertex();
        }

        private void ButtonFinalize_Click(object sender, EventArgs e)
        {
            // Wont initialize the matrix if there is no edge.
            if(Edges.Count == 0)
            {
                MessageBox.Show("Add at least one edge!");
                return;
            }

            // Disables all the combo box that is used when adding edges and vertices
            // Cannot add vertex and edge ones the graph is finalized
            ComboBoxFrom.Enabled = false;
            ComboBoxTo.Enabled = false;
            TextBoxWeight.Enabled = false;
            AddEdge.Enabled = false;
            AddVertex.Enabled = false;
            ButtonAdd.Enabled = false;
            ButtonUndoEdge.Enabled = false;
            ButtonUndoVertex.Enabled = false;
            ButtonFinalize.Enabled = false;

            // Widges for animation now enabled since the graph is finalized
            TextBoxBeam.Enabled = true;
            ButtonBFS.Enabled = true;
            ButtonDFS.Enabled = true;
            ButtonAStar.Enabled = true;
            ButtonBeam.Enabled = true;
            ButtonBnB.Enabled = true;
            ButtonHC.Enabled = true;
            ComboBoxStart.Enabled = true;
            ComboBoxSearch.Enabled = true;
            ButtonRun.Enabled = true;
            ButtonReset.Enabled = true;
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
            // Enables the pause button and currently set as paused
            LogBox.Text = string.Empty;
            ButtonPause.Enabled = true;
            isPaused = false;

            SearchVertex = ComboBoxSearch.SelectedItem as Vertex;
            StartVertex = ComboBoxStart.SelectedItem as Vertex;
            
            //
            if(ButtonBFS.Checked)
            {
                // Path now contains the BFS path from starting vertex until the searched vertex
                Path = Graph.BFS_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonDFS.Checked) 
            {
                // Path now contains the DFS path from starting vertex until the searched vertex
                Path = Graph.DFS_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
                
            }
            else if (ButtonBeam.Checked)
            {
                if(!int.TryParse(TextBoxBeam.Text, out int w))
                {
                    MessageBox.Show("Enter valid value.");
                    return;
                }
                else if (w <= 1)
                {
                    MessageBox.Show("Enter values greater than 1.");
                    return;
                }
                Path = Graph.Beam_order(Vertices, StartVertex, SearchVertex, Vertices.Count, w);
            }
            else if (ButtonHC.Checked)
            {
                Path = Graph.HillClimbing_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonBnB.Checked) 
            {
                Path = Graph.BranchAndBound_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonAStar.Checked)
            {
                Path = Graph.AStar_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            //Initializes the animation process
            InitAnimation();
        }
        
        private void InitAnimation()
        {
            // Starts the clock for animation
            // Initializes the variable used to index the vertecies in path
            CurrentNodeIndex = 0;
            AnimationClock.Enabled = true;
            AnimationClock.Start();
            AnimationRunning = true;
            AnimationPaused = false;
        }
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            // If currently paused, start the clock again 
            // Button text will now change to pause again since 
            // the animation will now be playing
            if(isPaused)
            {
                AnimationClock.Start();
                isPaused = false;
                ButtonPause.Text = "Pause";

                // Cant step back or forward if animation is currently running
                ButtonStepBack.Enabled = false;
                ButtonStepForward.Enabled = false;
            }

            // Else if currently playing, the clock will pause
            // Button text will now change to play again since
            // the animation is currently on pause
            else
            {
                AnimationClock.Stop();
                isPaused = true;
                ButtonPause.Text = "Play";

                // can step back and forward iff animation is paused
                ButtonStepBack.Enabled = true;
                ButtonStepForward.Enabled = true;
            }
        }
 
        private void PaintVertex()
        {
            /*
             * Function used to redraw all the vertices
             */
            // Diameter of each vertex
            int diameter = 50;
            foreach (Vertex v in Vertices)
            {
                // Corrected location of each vertex to center the drawing
                int x = v.Location.X - diameter / 2;
                int y = v.Location.Y - diameter / 2;

                // Corrected location to center the label of each vertex
                int textX = v.Location.X - diameter / 8;
                int textY = v.Location.Y - diameter / 8;

                // Drawing of vertices
                g.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
                g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);    
            }
        }

        private void PaintEdges()
        {
            /*
             * Function used to redraw all the edges
             */
            foreach(Edge edge in Edges) 
            {
                // Location of the label weights
                float textX = (edge.From.Location.X + edge.To.Location.X) / 2;
                float textY = (edge.From.Location.Y + edge.To.Location.Y) / 2;
                // Draw the weight text at the calculated position
                g.DrawString(edge.Cost.ToString(), this.Font, Brushes.Black, textX, textY);
                g.DrawLine(Pens.Black, edge.From.Location, edge.To.Location);
            }
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            // If list of vertex is empty, you cant undo any vertex
            if (Vertices.Count <= 0) return;

            Vertex VertexToRemove = Vertices[Vertices.Count - 1];

            // Removes the edges where vertex to remove is connected
            List<Edge> EdgesToRemove = new List<Edge>();
            foreach(Edge edge in Edges)
            {
                if(edge.From.Equals(VertexToRemove) || edge.To.Equals(VertexToRemove))
                {
                    EdgesToRemove.Add(edge);
                }
            }
            // LONG CUT WAY BECAUSE SHORTCUT WILL THROW ERROR FOR SOME REASONS :)))))
            foreach (Edge edge in EdgesToRemove) 
            {
                Edges.Remove(edge);
            }

            // Removes the last added vertex
            Vertices.RemoveAt(Vertices.Count - 1);

            // Vertex label and index decrements after deleting last vertex that was added
            VertexLabel--;
            VertexIndex--;
            
            // Updates the picture box after the last vertex was removed
            PictureBoxGraph.Image = null;
            RefreshSource();
            PictureBoxGraph.Update();
            PaintEdges();
            PaintVertex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If list of edge is empty, you cant undo any edge
            if (Edges.Count <= 0) return;

            // Removes the last added edge
            Edges.RemoveAt(Edges.Count - 1);

            // Updates the picture box after the last vertex was removed
            ResetPictureBox();
        }

        private void RefreshSource()
        { 
            /*
             * Refreshes the data source of combo box after adding or deleting a vertex or edge
             */
            ComboBoxFrom.DataSource = null;
            ComboBoxTo.DataSource = null;
            ComboBoxStart.DataSource = null;
            ComboBoxSearch.DataSource = null;

            ComboBoxFrom.DataSource = new List<Vertex>(Vertices);
            ComboBoxTo.DataSource = new List<Vertex>(Vertices);
            ComboBoxStart.DataSource = Vertices;
            ComboBoxSearch.DataSource = new List<Vertex>(Vertices);
        }

        private async void AnimationClock_Tick(object sender, EventArgs e)
        {
            /*
             * EACH TICK, THE CURRENT VERTEX IN THE PATHS WILL BE HIGHLIGHTED
             */
            if (CurrentNodeIndex >= Path.Count)
            {
                AnimationClock.Stop();
                AnimationRunning = false;
                ResetPictureBox();
                return;
            }
            RenderVertex();
            // if index out of bounds, stop the animation
            
        }

        private void RenderVertex()
        {
            

            // Clears the previous logbox
            LogBox.Text = "";

            // diameter of vertex drawing
            int diameter = 50;

            // Currnet vertex that will be highligted
            Vertex CurrentVertex = Path[CurrentNodeIndex];

            if (CurrentNodeIndex > 0)
            {

                Vertex PreviousVertex = Path[CurrentNodeIndex - 1];

                // Location of the previous vertex
                int xx = PreviousVertex.Location.X - diameter / 2;
                int yy = PreviousVertex.Location.Y - diameter / 2;
                // Location of the label of the previous vertex
                int textXX = PreviousVertex.Location.X - diameter / 8;
                int textYY = PreviousVertex.Location.Y - diameter / 8;

                // Recolors the previous vertex back to green
                g.FillEllipse(Brushes.Blue, xx, yy, diameter, diameter);
                g.DrawEllipse(Pens.Black, xx, yy, diameter, diameter);
                g.DrawString(PreviousVertex.ID.ToString(), this.Font, Brushes.White, textXX, textYY);
            }

            // Location of the current vertex
            int x = CurrentVertex.Location.X - diameter / 2;
            int y = CurrentVertex.Location.Y - diameter / 2;

            // Location of the label of the current vertex
            int textX = CurrentVertex.Location.X - diameter / 8;
            int textY = CurrentVertex.Location.Y - diameter / 8;

            // Colors the current vertex to red
            g.FillEllipse(Brushes.Red, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.White, textX, textY);

            // If current vertex is equal to the searched index, highlight yellow
            if (CurrentVertex.Equals(SearchVertex))
            {
                // Vertex that's being searched is now found.
                // Color Yellow
                g.FillEllipse(Brushes.Yellow, x, y, diameter, diameter);
                g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
                g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.Black, textX, textY);

                LogBox.Text = CurrentVertex.Logs;

                // Recolor the searched vertex back to green after two seconds
                /* await Task.Delay(2000);
                 g.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
                 g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
                 g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.White, textX, textY);*/

            }

            LogBox.Text = CurrentVertex.Logs;

            // Moves to the next vertex in Path
            CurrentNodeIndex++;
        }


        private void PictureBoxGraph_MouseClick_1(object sender, MouseEventArgs e)
        {// Return if add vertex checkbox is not activated
            if (!AddVertex.Checked) return;


            // check box is now activated
            // Get the clicked point
            Point clickPoint = e.Location;

            // Create a new vertex object and add to the list of vertices
           
            Vertices.Add(new Vertex(VertexLabel, VertexIndex, e.Location));

            // Define the circle's  and size
            int diameter = 50;

            // x and y adjusted so that the point location will be centered
            // instead of the default upper right corner
            int x = clickPoint.X - diameter / 2;
            int y = clickPoint.Y - diameter / 2;

            // Used so that the label of every vertex is in center
            int textX = e.X - diameter / 8;
            int textY = e.Y - diameter / 8;

            // Fill a green circle and black outline and add a label
            g.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            g.DrawString(VertexLabel.ToString(), this.Font, Brushes.White, textX, textY);

            // Refreshes the contents inside the combo box
            // Updates the drop down menus that contains the vertices
            RefreshSource();

            // Increment the vertex label and index everytime you add new vertex
            VertexLabel++;
            VertexIndex++;
        }
       
        private void Form1_Activated(object sender, EventArgs e)
        {
            // Handle the Activated event to force PictureBox to repaint
            Form form = (Form)sender;
            PictureBox pictureBox = form.Controls.OfType<PictureBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                pictureBox.Invalidate(); // Forces a repaint
            }
        }

        private void ResetPictureBox()
        {
            PictureBoxGraph.Image = null;
            RefreshSource();
            PictureBoxGraph.Update();
            PaintEdges();
            PaintVertex();
        }

        private void ButtonStepBack_Click(object sender, EventArgs e)
        {
            if (CurrentNodeIndex <= 1)
            {
                ButtonStepBack.Enabled = false;
                return;
            }
            ButtonStepForward.Enabled = true;
            CurrentNodeIndex -= 2;

            // diameter of vertex drawing
            int diameter = 50;

            // Currnet vertex that will be highligted
            Vertex CurrentVertex = Path[CurrentNodeIndex + 1];
            // Location of the current vertex
            int x = CurrentVertex.Location.X - diameter / 2;
            int y = CurrentVertex.Location.Y - diameter / 2;

            // Location of the label of the current vertex
            int textX = CurrentVertex.Location.X - diameter / 8;
            int textY = CurrentVertex.Location.Y - diameter / 8;

            // Colors the current vertex to red
            g.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.White, textX, textY);

            RenderVertex();

        }

        private void ButtonStepForward_Click(object sender, EventArgs e)
        {
            if (CurrentNodeIndex >= Path.Count) 
            {
                ButtonStepForward.Enabled = false;
                return; 
            }
            ButtonStepBack.Enabled = true;
           RenderVertex();
        }

        private void AddEdge_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AddEdge.Checked)
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

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ComboBoxFrom.Enabled = true;
            ComboBoxTo.Enabled = true;
            TextBoxWeight.Enabled = true;
            AddEdge.Enabled = true;
            AddVertex.Enabled = true;
            ButtonAdd.Enabled = true;
            ButtonUndoEdge.Enabled = true;
            ButtonUndoVertex.Enabled = true;
            ButtonFinalize.Enabled = true;

            // Widges for animation now enabled since the graph is finalized
            TextBoxBeam.Enabled = false;
            ButtonBFS.Enabled = false;
            ButtonDFS.Enabled = false;
            ButtonAStar.Enabled = false;
            ButtonBeam.Enabled = false;
            ButtonBnB.Enabled = false;
            ButtonHC.Enabled = false;
            ComboBoxStart.Enabled = false;
            ComboBoxSearch.Enabled = false;
            ButtonRun.Enabled = false;
            ButtonReset.Enabled = false;
            TrackbarSpeed.Enabled = false;

            AnimationPaused = false;
            AnimationRunning = false;
            Vertices.Clear();
            Edges.Clear();
            Graph = new Graph();
            Path.Clear();
            CurrentNodeIndex = 0;

            Vertex SearchVertex = null;
            Vertex StartVertex = null;
            g = PictureBoxGraph.CreateGraphics();
            isPaused = true;
            VertexLabel = 'A';
            VertexIndex = 0;

            PictureBoxGraph.Image = null;
            RefreshSource();
            PictureBoxGraph.Update();
        }

        private void PictureBoxGraph_Paint(object sender, PaintEventArgs e)
        {
            PaintEdges();
            PaintVertex();
        }
    }
}