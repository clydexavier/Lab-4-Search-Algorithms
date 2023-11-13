namespace SearchAlgorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.TrackbarSpeed = new System.Windows.Forms.TrackBar();
            this.ButtonBFS = new System.Windows.Forms.RadioButton();
            this.ButtonDFS = new System.Windows.Forms.RadioButton();
            this.ButtonBeam = new System.Windows.Forms.RadioButton();
            this.ButtonHC = new System.Windows.Forms.RadioButton();
            this.ButtonBnB = new System.Windows.Forms.RadioButton();
            this.ButtonAStar = new System.Windows.Forms.RadioButton();
            this.PictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.AddVertex = new System.Windows.Forms.CheckBox();
            this.AddEdge = new System.Windows.Forms.CheckBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.ComboBoxStart = new System.Windows.Forms.ComboBox();
            this.ButtonFinalize = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.ButtonUndoVertex = new System.Windows.Forms.Button();
            this.ButtonUndoEdge = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.AnimationClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRun
            // 
            this.ButtonRun.Enabled = false;
            this.ButtonRun.Location = new System.Drawing.Point(302, 4);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(94, 29);
            this.ButtonRun.TabIndex = 0;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // TrackbarSpeed
            // 
            this.TrackbarSpeed.Enabled = false;
            this.TrackbarSpeed.Location = new System.Drawing.Point(402, 5);
            this.TrackbarSpeed.Name = "TrackbarSpeed";
            this.TrackbarSpeed.Size = new System.Drawing.Size(130, 56);
            this.TrackbarSpeed.TabIndex = 1;
            // 
            // ButtonBFS
            // 
            this.ButtonBFS.AutoSize = true;
            this.ButtonBFS.Enabled = false;
            this.ButtonBFS.Location = new System.Drawing.Point(12, 33);
            this.ButtonBFS.Name = "ButtonBFS";
            this.ButtonBFS.Size = new System.Drawing.Size(54, 24);
            this.ButtonBFS.TabIndex = 2;
            this.ButtonBFS.TabStop = true;
            this.ButtonBFS.Text = "BFS";
            this.ButtonBFS.UseVisualStyleBackColor = true;
            // 
            // ButtonDFS
            // 
            this.ButtonDFS.AutoSize = true;
            this.ButtonDFS.Enabled = false;
            this.ButtonDFS.Location = new System.Drawing.Point(81, 33);
            this.ButtonDFS.Name = "ButtonDFS";
            this.ButtonDFS.Size = new System.Drawing.Size(56, 24);
            this.ButtonDFS.TabIndex = 3;
            this.ButtonDFS.TabStop = true;
            this.ButtonDFS.Text = "DFS";
            this.ButtonDFS.UseVisualStyleBackColor = true;
            // 
            // ButtonBeam
            // 
            this.ButtonBeam.AutoSize = true;
            this.ButtonBeam.Enabled = false;
            this.ButtonBeam.Location = new System.Drawing.Point(153, 33);
            this.ButtonBeam.Name = "ButtonBeam";
            this.ButtonBeam.Size = new System.Drawing.Size(68, 24);
            this.ButtonBeam.TabIndex = 4;
            this.ButtonBeam.TabStop = true;
            this.ButtonBeam.Text = "Beam";
            this.ButtonBeam.UseVisualStyleBackColor = true;
            // 
            // ButtonHC
            // 
            this.ButtonHC.AutoSize = true;
            this.ButtonHC.Enabled = false;
            this.ButtonHC.Location = new System.Drawing.Point(279, 33);
            this.ButtonHC.Name = "ButtonHC";
            this.ButtonHC.Size = new System.Drawing.Size(117, 24);
            this.ButtonHC.TabIndex = 5;
            this.ButtonHC.TabStop = true;
            this.ButtonHC.Text = "Hill-climbing";
            this.ButtonHC.UseVisualStyleBackColor = true;
            // 
            // ButtonBnB
            // 
            this.ButtonBnB.AutoSize = true;
            this.ButtonBnB.Enabled = false;
            this.ButtonBnB.Location = new System.Drawing.Point(402, 33);
            this.ButtonBnB.Name = "ButtonBnB";
            this.ButtonBnB.Size = new System.Drawing.Size(151, 24);
            this.ButtonBnB.TabIndex = 6;
            this.ButtonBnB.TabStop = true;
            this.ButtonBnB.Text = "Branch and Bound";
            this.ButtonBnB.UseVisualStyleBackColor = true;
            // 
            // ButtonAStar
            // 
            this.ButtonAStar.AutoSize = true;
            this.ButtonAStar.Enabled = false;
            this.ButtonAStar.Location = new System.Drawing.Point(227, 33);
            this.ButtonAStar.Name = "ButtonAStar";
            this.ButtonAStar.Size = new System.Drawing.Size(46, 24);
            this.ButtonAStar.TabIndex = 7;
            this.ButtonAStar.TabStop = true;
            this.ButtonAStar.Text = "A*";
            this.ButtonAStar.UseVisualStyleBackColor = true;
            // 
            // PictureBoxGraph
            // 
            this.PictureBoxGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxGraph.Location = new System.Drawing.Point(12, 75);
            this.PictureBoxGraph.Name = "PictureBoxGraph";
            this.PictureBoxGraph.Size = new System.Drawing.Size(739, 663);
            this.PictureBoxGraph.TabIndex = 10;
            this.PictureBoxGraph.TabStop = false;
            this.PictureBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxGraph_MouseClick);
            // 
            // AddVertex
            // 
            this.AddVertex.AutoSize = true;
            this.AddVertex.Location = new System.Drawing.Point(818, 5);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(104, 24);
            this.AddVertex.TabIndex = 11;
            this.AddVertex.Text = "Add Vertex";
            this.AddVertex.UseVisualStyleBackColor = true;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Location = new System.Drawing.Point(928, 4);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(97, 24);
            this.AddEdge.TabIndex = 12;
            this.AddEdge.Text = "Add Edge";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.CheckedChanged += new System.EventHandler(this.AddEdge_CheckedChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(757, 164);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(379, 29);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.Enabled = false;
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(757, 117);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxFrom.TabIndex = 14;
            this.ComboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrom_SelectedIndexChanged);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.Enabled = false;
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(884, 117);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxTo.TabIndex = 15;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Enabled = false;
            this.TextBoxWeight.Location = new System.Drawing.Point(1011, 118);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.PlaceholderText = "Weight";
            this.TextBoxWeight.Size = new System.Drawing.Size(125, 27);
            this.TextBoxWeight.TabIndex = 16;
            // 
            // ComboBoxStart
            // 
            this.ComboBoxStart.Enabled = false;
            this.ComboBoxStart.FormattingEnabled = true;
            this.ComboBoxStart.Location = new System.Drawing.Point(16, 4);
            this.ComboBoxStart.Name = "ComboBoxStart";
            this.ComboBoxStart.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxStart.TabIndex = 17;
            // 
            // ButtonFinalize
            // 
            this.ButtonFinalize.Location = new System.Drawing.Point(757, 254);
            this.ButtonFinalize.Name = "ButtonFinalize";
            this.ButtonFinalize.Size = new System.Drawing.Size(379, 29);
            this.ButtonFinalize.TabIndex = 18;
            this.ButtonFinalize.Text = "Finalize";
            this.ButtonFinalize.UseVisualStyleBackColor = true;
            this.ButtonFinalize.Click += new System.EventHandler(this.ButtonFinalize_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Enabled = false;
            this.ButtonPause.Location = new System.Drawing.Point(538, 5);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(94, 29);
            this.ButtonPause.TabIndex = 19;
            this.ButtonPause.Text = "Play";
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.Enabled = false;
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Location = new System.Drawing.Point(153, 4);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSearch.TabIndex = 20;
            // 
            // ButtonUndoVertex
            // 
            this.ButtonUndoVertex.Location = new System.Drawing.Point(757, 210);
            this.ButtonUndoVertex.Name = "ButtonUndoVertex";
            this.ButtonUndoVertex.Size = new System.Drawing.Size(165, 29);
            this.ButtonUndoVertex.TabIndex = 21;
            this.ButtonUndoVertex.Text = "Undo Vertex";
            this.ButtonUndoVertex.UseVisualStyleBackColor = true;
            this.ButtonUndoVertex.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonUndoEdge
            // 
            this.ButtonUndoEdge.Location = new System.Drawing.Point(967, 210);
            this.ButtonUndoEdge.Name = "ButtonUndoEdge";
            this.ButtonUndoEdge.Size = new System.Drawing.Size(169, 29);
            this.ButtonUndoEdge.TabIndex = 22;
            this.ButtonUndoEdge.Text = "Undo Edge";
            this.ButtonUndoEdge.UseVisualStyleBackColor = true;
            this.ButtonUndoEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(757, 289);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(379, 449);
            this.LogBox.TabIndex = 25;
            this.LogBox.Text = "";
            // 
            // AnimationClock
            // 
            this.AnimationClock.Interval = 1000;
            this.AnimationClock.Tick += new System.EventHandler(this.AnimationClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 750);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.ButtonUndoEdge);
            this.Controls.Add(this.ButtonUndoVertex);
            this.Controls.Add(this.ComboBoxSearch);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonFinalize);
            this.Controls.Add(this.ComboBoxStart);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.ComboBoxTo);
            this.Controls.Add(this.ComboBoxFrom);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.AddVertex);
            this.Controls.Add(this.PictureBoxGraph);
            this.Controls.Add(this.ButtonAStar);
            this.Controls.Add(this.ButtonBnB);
            this.Controls.Add(this.ButtonHC);
            this.Controls.Add(this.ButtonBeam);
            this.Controls.Add(this.ButtonDFS);
            this.Controls.Add(this.ButtonBFS);
            this.Controls.Add(this.TrackbarSpeed);
            this.Controls.Add(this.ButtonRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonRun;
        private TrackBar TrackbarSpeed;
        private RadioButton ButtonBFS;
        private RadioButton ButtonDFS;
        private RadioButton ButtonBeam;
        private RadioButton ButtonHC;
        private RadioButton ButtonBnB;
        private RadioButton ButtonAStar;
        private PictureBox PictureBoxGraph;
        private CheckBox AddVertex;
        private CheckBox AddEdge;
        private Button ButtonAdd;
        private ComboBox ComboBoxFrom;
        private ComboBox ComboBoxTo;
        private TextBox TextBoxWeight;
        private ComboBox ComboBoxStart;
        private Button ButtonFinalize;
        private Button ButtonPause;
        private ComboBox ComboBoxSearch;
        private Button ButtonUndoVertex;
        private Button ButtonUndoEdge;
        private RichTextBox LogBox;
        private System.Windows.Forms.Timer AnimationClock;
    }
}