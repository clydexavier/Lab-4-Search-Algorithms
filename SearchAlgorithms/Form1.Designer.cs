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
            this.AnimationClock = new System.Windows.Forms.Timer(this.components);
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelNavigation = new System.Windows.Forms.Panel();
            this.LabelAnimationSpeed = new System.Windows.Forms.Label();
            this.ButtonStepForward = new System.Windows.Forms.Button();
            this.ButtonStepBack = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.Heading = new System.Windows.Forms.Label();
            this.PanelTopNavigation = new System.Windows.Forms.Panel();
            this.TextBoxBeam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEdge = new System.Windows.Forms.RadioButton();
            this.AddVertex = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).BeginInit();
            this.PanelNavigation.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.PanelTopNavigation.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).BeginInit();
            this.PanelRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRun
            // 
            this.ButtonRun.BackColor = System.Drawing.Color.Blue;
            this.ButtonRun.Enabled = false;
            this.ButtonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRun.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRun.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonRun.Location = new System.Drawing.Point(831, 6);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(103, 54);
            this.ButtonRun.TabIndex = 0;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = false;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // TrackbarSpeed
            // 
            this.TrackbarSpeed.Enabled = false;
            this.TrackbarSpeed.Location = new System.Drawing.Point(378, 3);
            this.TrackbarSpeed.Minimum = 1;
            this.TrackbarSpeed.Name = "TrackbarSpeed";
            this.TrackbarSpeed.Size = new System.Drawing.Size(195, 56);
            this.TrackbarSpeed.TabIndex = 1;
            this.TrackbarSpeed.Value = 1;
            // 
            // ButtonBFS
            // 
            this.ButtonBFS.AutoSize = true;
            this.ButtonBFS.Enabled = false;
            this.ButtonBFS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBFS.Location = new System.Drawing.Point(378, 6);
            this.ButtonBFS.Name = "ButtonBFS";
            this.ButtonBFS.Size = new System.Drawing.Size(58, 22);
            this.ButtonBFS.TabIndex = 2;
            this.ButtonBFS.TabStop = true;
            this.ButtonBFS.Text = "BFS";
            this.ButtonBFS.UseVisualStyleBackColor = true;
            // 
            // ButtonDFS
            // 
            this.ButtonDFS.AutoSize = true;
            this.ButtonDFS.Enabled = false;
            this.ButtonDFS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDFS.Location = new System.Drawing.Point(479, 3);
            this.ButtonDFS.Name = "ButtonDFS";
            this.ButtonDFS.Size = new System.Drawing.Size(59, 22);
            this.ButtonDFS.TabIndex = 3;
            this.ButtonDFS.TabStop = true;
            this.ButtonDFS.Text = "DFS";
            this.ButtonDFS.UseVisualStyleBackColor = true;
            // 
            // ButtonBeam
            // 
            this.ButtonBeam.AutoSize = true;
            this.ButtonBeam.Enabled = false;
            this.ButtonBeam.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBeam.Location = new System.Drawing.Point(602, 40);
            this.ButtonBeam.Name = "ButtonBeam";
            this.ButtonBeam.Size = new System.Drawing.Size(72, 22);
            this.ButtonBeam.TabIndex = 4;
            this.ButtonBeam.TabStop = true;
            this.ButtonBeam.Text = "Beam";
            this.ButtonBeam.UseVisualStyleBackColor = true;
            // 
            // ButtonHC
            // 
            this.ButtonHC.AutoSize = true;
            this.ButtonHC.Enabled = false;
            this.ButtonHC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHC.Location = new System.Drawing.Point(479, 38);
            this.ButtonHC.Name = "ButtonHC";
            this.ButtonHC.Size = new System.Drawing.Size(115, 22);
            this.ButtonHC.TabIndex = 5;
            this.ButtonHC.TabStop = true;
            this.ButtonHC.Text = "Hill-climbing";
            this.ButtonHC.UseVisualStyleBackColor = true;
            // 
            // ButtonBnB
            // 
            this.ButtonBnB.AutoSize = true;
            this.ButtonBnB.Enabled = false;
            this.ButtonBnB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBnB.Location = new System.Drawing.Point(602, 3);
            this.ButtonBnB.Name = "ButtonBnB";
            this.ButtonBnB.Size = new System.Drawing.Size(164, 22);
            this.ButtonBnB.TabIndex = 6;
            this.ButtonBnB.TabStop = true;
            this.ButtonBnB.Text = "Branch and Bound";
            this.ButtonBnB.UseVisualStyleBackColor = true;
            // 
            // ButtonAStar
            // 
            this.ButtonAStar.AutoSize = true;
            this.ButtonAStar.Enabled = false;
            this.ButtonAStar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAStar.Location = new System.Drawing.Point(378, 40);
            this.ButtonAStar.Name = "ButtonAStar";
            this.ButtonAStar.Size = new System.Drawing.Size(49, 22);
            this.ButtonAStar.TabIndex = 7;
            this.ButtonAStar.TabStop = true;
            this.ButtonAStar.Text = "A*";
            this.ButtonAStar.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Blue;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAdd.Location = new System.Drawing.Point(14, 109);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(388, 40);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFrom.Enabled = false;
            this.ComboBoxFrom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(14, 64);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(130, 26);
            this.ComboBoxFrom.TabIndex = 14;
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTo.Enabled = false;
            this.ComboBoxTo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(150, 65);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxTo.TabIndex = 15;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Enabled = false;
            this.TextBoxWeight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.TextBoxWeight.Location = new System.Drawing.Point(275, 66);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.PlaceholderText = "Weight";
            this.TextBoxWeight.Size = new System.Drawing.Size(125, 26);
            this.TextBoxWeight.TabIndex = 16;
            // 
            // ComboBoxStart
            // 
            this.ComboBoxStart.Enabled = false;
            this.ComboBoxStart.FormattingEnabled = true;
            this.ComboBoxStart.Location = new System.Drawing.Point(12, 6);
            this.ComboBoxStart.Name = "ComboBoxStart";
            this.ComboBoxStart.Size = new System.Drawing.Size(154, 28);
            this.ComboBoxStart.TabIndex = 17;
            // 
            // ButtonFinalize
            // 
            this.ButtonFinalize.BackColor = System.Drawing.Color.Blue;
            this.ButtonFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFinalize.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonFinalize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonFinalize.Location = new System.Drawing.Point(14, 165);
            this.ButtonFinalize.Name = "ButtonFinalize";
            this.ButtonFinalize.Size = new System.Drawing.Size(386, 40);
            this.ButtonFinalize.TabIndex = 18;
            this.ButtonFinalize.Text = "Finalize";
            this.ButtonFinalize.UseVisualStyleBackColor = false;
            this.ButtonFinalize.Click += new System.EventHandler(this.ButtonFinalize_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Enabled = false;
            this.ButtonPause.Location = new System.Drawing.Point(127, 3);
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
            this.ComboBoxSearch.Location = new System.Drawing.Point(196, 6);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(164, 28);
            this.ComboBoxSearch.TabIndex = 20;
            // 
            // ButtonUndoVertex
            // 
            this.ButtonUndoVertex.BackColor = System.Drawing.Color.Blue;
            this.ButtonUndoVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndoVertex.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUndoVertex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonUndoVertex.Location = new System.Drawing.Point(579, 8);
            this.ButtonUndoVertex.Name = "ButtonUndoVertex";
            this.ButtonUndoVertex.Size = new System.Drawing.Size(144, 38);
            this.ButtonUndoVertex.TabIndex = 21;
            this.ButtonUndoVertex.Text = "Undo Vertex";
            this.ButtonUndoVertex.UseVisualStyleBackColor = false;
            this.ButtonUndoVertex.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonUndoEdge
            // 
            this.ButtonUndoEdge.BackColor = System.Drawing.Color.Blue;
            this.ButtonUndoEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndoEdge.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUndoEdge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonUndoEdge.Location = new System.Drawing.Point(739, 6);
            this.ButtonUndoEdge.Name = "ButtonUndoEdge";
            this.ButtonUndoEdge.Size = new System.Drawing.Size(144, 40);
            this.ButtonUndoEdge.TabIndex = 22;
            this.ButtonUndoEdge.Text = "Undo Edge";
            this.ButtonUndoEdge.UseVisualStyleBackColor = false;
            this.ButtonUndoEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnimationClock
            // 
            this.AnimationClock.Interval = 2000;
            this.AnimationClock.Tick += new System.EventHandler(this.AnimationClock_Tick);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 692);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1339, 58);
            this.PanelBottom.TabIndex = 27;
            // 
            // PanelNavigation
            // 
            this.PanelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.PanelNavigation.Controls.Add(this.LabelAnimationSpeed);
            this.PanelNavigation.Controls.Add(this.ButtonStepForward);
            this.PanelNavigation.Controls.Add(this.ButtonStepBack);
            this.PanelNavigation.Controls.Add(this.ButtonUndoVertex);
            this.PanelNavigation.Controls.Add(this.ButtonPause);
            this.PanelNavigation.Controls.Add(this.TrackbarSpeed);
            this.PanelNavigation.Controls.Add(this.ButtonUndoEdge);
            this.PanelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelNavigation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelNavigation.Location = new System.Drawing.Point(0, 615);
            this.PanelNavigation.Name = "PanelNavigation";
            this.PanelNavigation.Size = new System.Drawing.Size(1339, 77);
            this.PanelNavigation.TabIndex = 28;
            // 
            // LabelAnimationSpeed
            // 
            this.LabelAnimationSpeed.AutoSize = true;
            this.LabelAnimationSpeed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAnimationSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.LabelAnimationSpeed.Location = new System.Drawing.Point(378, 49);
            this.LabelAnimationSpeed.Name = "LabelAnimationSpeed";
            this.LabelAnimationSpeed.Size = new System.Drawing.Size(202, 25);
            this.LabelAnimationSpeed.TabIndex = 23;
            this.LabelAnimationSpeed.Text = "Animation Speed";
            // 
            // ButtonStepForward
            // 
            this.ButtonStepForward.Enabled = false;
            this.ButtonStepForward.Location = new System.Drawing.Point(245, 3);
            this.ButtonStepForward.Name = "ButtonStepForward";
            this.ButtonStepForward.Size = new System.Drawing.Size(127, 29);
            this.ButtonStepForward.TabIndex = 22;
            this.ButtonStepForward.Text = "Step Forward";
            this.ButtonStepForward.UseVisualStyleBackColor = true;
            this.ButtonStepForward.Click += new System.EventHandler(this.ButtonStepForward_Click);
            // 
            // ButtonStepBack
            // 
            this.ButtonStepBack.Enabled = false;
            this.ButtonStepBack.Location = new System.Drawing.Point(12, 3);
            this.ButtonStepBack.Name = "ButtonStepBack";
            this.ButtonStepBack.Size = new System.Drawing.Size(94, 29);
            this.ButtonStepBack.TabIndex = 21;
            this.ButtonStepBack.Text = "Step Back";
            this.ButtonStepBack.UseVisualStyleBackColor = true;
            this.ButtonStepBack.Click += new System.EventHandler(this.ButtonStepBack_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.PanelTop.Controls.Add(this.Heading);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1339, 58);
            this.PanelTop.TabIndex = 29;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Heading.Location = new System.Drawing.Point(3, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(465, 41);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Algorithm Visualization";
            // 
            // PanelTopNavigation
            // 
            this.PanelTopNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.PanelTopNavigation.Controls.Add(this.TextBoxBeam);
            this.PanelTopNavigation.Controls.Add(this.label2);
            this.PanelTopNavigation.Controls.Add(this.label1);
            this.PanelTopNavigation.Controls.Add(this.ComboBoxStart);
            this.PanelTopNavigation.Controls.Add(this.ComboBoxSearch);
            this.PanelTopNavigation.Controls.Add(this.ButtonRun);
            this.PanelTopNavigation.Controls.Add(this.ButtonBFS);
            this.PanelTopNavigation.Controls.Add(this.ButtonDFS);
            this.PanelTopNavigation.Controls.Add(this.ButtonBnB);
            this.PanelTopNavigation.Controls.Add(this.ButtonBeam);
            this.PanelTopNavigation.Controls.Add(this.ButtonHC);
            this.PanelTopNavigation.Controls.Add(this.ButtonAStar);
            this.PanelTopNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopNavigation.Location = new System.Drawing.Point(0, 58);
            this.PanelTopNavigation.Name = "PanelTopNavigation";
            this.PanelTopNavigation.Size = new System.Drawing.Size(1339, 77);
            this.PanelTopNavigation.TabIndex = 30;
            // 
            // TextBoxBeam
            // 
            this.TextBoxBeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBeam.Enabled = false;
            this.TextBoxBeam.Location = new System.Drawing.Point(680, 41);
            this.TextBoxBeam.Name = "TextBoxBeam";
            this.TextBoxBeam.PlaceholderText = "Beam W";
            this.TextBoxBeam.Size = new System.Drawing.Size(125, 20);
            this.TextBoxBeam.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(196, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search Vertex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Starting Vertex";
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelLeft.Controls.Add(this.PictureBoxGraph);
            this.PanelLeft.Location = new System.Drawing.Point(0, 135);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(883, 480);
            this.PanelLeft.TabIndex = 31;
            // 
            // PictureBoxGraph
            // 
            this.PictureBoxGraph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBoxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxGraph.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxGraph.Name = "PictureBoxGraph";
            this.PictureBoxGraph.Size = new System.Drawing.Size(883, 480);
            this.PictureBoxGraph.TabIndex = 11;
            this.PictureBoxGraph.TabStop = false;
            this.PictureBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxGraph_MouseClick_1);
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.PanelRight.Controls.Add(this.panel2);
            this.PanelRight.Controls.Add(this.panel1);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(891, 135);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(448, 480);
            this.PanelRight.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.AddEdge);
            this.panel2.Controls.Add(this.AddVertex);
            this.panel2.Controls.Add(this.ButtonAdd);
            this.panel2.Controls.Add(this.ButtonFinalize);
            this.panel2.Controls.Add(this.ComboBoxFrom);
            this.panel2.Controls.Add(this.ComboBoxTo);
            this.panel2.Controls.Add(this.TextBoxWeight);
            this.panel2.Location = new System.Drawing.Point(16, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 220);
            this.panel2.TabIndex = 24;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEdge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.AddEdge.Location = new System.Drawing.Point(223, 14);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(177, 36);
            this.AddEdge.TabIndex = 25;
            this.AddEdge.TabStop = true;
            this.AddEdge.Text = "Add Edge";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.CheckedChanged += new System.EventHandler(this.AddEdge_CheckedChanged_1);
            // 
            // AddVertex
            // 
            this.AddVertex.AutoSize = true;
            this.AddVertex.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddVertex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.AddVertex.Location = new System.Drawing.Point(14, 14);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(203, 36);
            this.AddVertex.TabIndex = 24;
            this.AddVertex.TabStop = true;
            this.AddVertex.Text = "Add Vertex";
            this.AddVertex.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.LogBox);
            this.panel1.Location = new System.Drawing.Point(16, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 196);
            this.panel1.TabIndex = 23;
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(415, 196);
            this.LogBox.TabIndex = 13;
            this.LogBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1339, 750);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTopNavigation);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelNavigation);
            this.Controls.Add(this.PanelBottom);
            this.MaximumSize = new System.Drawing.Size(1357, 797);
            this.MinimumSize = new System.Drawing.Size(1357, 797);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).EndInit();
            this.PanelNavigation.ResumeLayout(false);
            this.PanelNavigation.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelTopNavigation.ResumeLayout(false);
            this.PanelTopNavigation.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).EndInit();
            this.PanelRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Timer AnimationClock;
        private Panel PanelBottom;
        private Panel PanelNavigation;
        private Label LabelAnimationSpeed;
        private Button ButtonStepForward;
        private Button ButtonStepBack;
        private Panel PanelTop;
        private Panel PanelTopNavigation;
        private Panel PanelLeft;
        private Panel PanelRight;
        private PictureBox PictureBoxGraph;
        private Label Heading;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private RichTextBox LogBox;
        private RadioButton AddEdge;
        private RadioButton AddVertex;
        private Panel panel2;
        private TextBox TextBoxBeam;
    }
}