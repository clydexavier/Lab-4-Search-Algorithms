﻿namespace SearchAlgorithms
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
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelNavigation = new System.Windows.Forms.Panel();
            this.LabelAnimationSpeed = new System.Windows.Forms.Label();
            this.ButtonStepForward = new System.Windows.Forms.Button();
            this.ButtonStepBack = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.Heading = new System.Windows.Forms.Label();
            this.PanelTopNavigation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).BeginInit();
            this.PanelNavigation.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.PanelTopNavigation.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).BeginInit();
            this.PanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRun
            // 
            this.ButtonRun.BackColor = System.Drawing.Color.Blue;
            this.ButtonRun.Enabled = false;
            this.ButtonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRun.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRun.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonRun.Location = new System.Drawing.Point(770, 6);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(107, 42);
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
            this.ButtonBeam.Location = new System.Drawing.Point(378, 36);
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
            this.ButtonHC.Location = new System.Drawing.Point(479, 36);
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
            this.ButtonAStar.Location = new System.Drawing.Point(602, 36);
            this.ButtonAStar.Name = "ButtonAStar";
            this.ButtonAStar.Size = new System.Drawing.Size(49, 22);
            this.ButtonAStar.TabIndex = 7;
            this.ButtonAStar.TabStop = true;
            this.ButtonAStar.Text = "A*";
            this.ButtonAStar.UseVisualStyleBackColor = true;
            // 
            // AddVertex
            // 
            this.AddVertex.AutoSize = true;
            this.AddVertex.Location = new System.Drawing.Point(135, 47);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(104, 24);
            this.AddVertex.TabIndex = 11;
            this.AddVertex.Text = "Add Vertex";
            this.AddVertex.UseVisualStyleBackColor = true;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Location = new System.Drawing.Point(245, 43);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(97, 24);
            this.AddEdge.TabIndex = 12;
            this.AddEdge.Text = "Add Edge";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.CheckedChanged += new System.EventHandler(this.AddEdge_CheckedChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(238, 167);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(165, 29);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.Enabled = false;
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(24, 77);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxFrom.TabIndex = 14;
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.Enabled = false;
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(166, 77);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxTo.TabIndex = 15;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Enabled = false;
            this.TextBoxWeight.Location = new System.Drawing.Point(306, 78);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.PlaceholderText = "Weight";
            this.TextBoxWeight.Size = new System.Drawing.Size(125, 27);
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
            this.ButtonFinalize.Location = new System.Drawing.Point(245, 202);
            this.ButtonFinalize.Name = "ButtonFinalize";
            this.ButtonFinalize.Size = new System.Drawing.Size(165, 29);
            this.ButtonFinalize.TabIndex = 18;
            this.ButtonFinalize.Text = "Finalize";
            this.ButtonFinalize.UseVisualStyleBackColor = true;
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
            this.ButtonUndoVertex.Location = new System.Drawing.Point(63, 167);
            this.ButtonUndoVertex.Name = "ButtonUndoVertex";
            this.ButtonUndoVertex.Size = new System.Drawing.Size(165, 29);
            this.ButtonUndoVertex.TabIndex = 21;
            this.ButtonUndoVertex.Text = "Undo Vertex";
            this.ButtonUndoVertex.UseVisualStyleBackColor = true;
            this.ButtonUndoVertex.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonUndoEdge
            // 
            this.ButtonUndoEdge.Location = new System.Drawing.Point(63, 202);
            this.ButtonUndoEdge.Name = "ButtonUndoEdge";
            this.ButtonUndoEdge.Size = new System.Drawing.Size(169, 29);
            this.ButtonUndoEdge.TabIndex = 22;
            this.ButtonUndoEdge.Text = "Undo Edge";
            this.ButtonUndoEdge.UseVisualStyleBackColor = true;
            this.ButtonUndoEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.ForeColor = System.Drawing.Color.White;
            this.LogBox.Location = new System.Drawing.Point(24, 279);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(407, 179);
            this.LogBox.TabIndex = 25;
            this.LogBox.Text = "";
            // 
            // AnimationClock
            // 
            this.AnimationClock.Interval = 1000;
            this.AnimationClock.Tick += new System.EventHandler(this.AnimationClock_Tick);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 692);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1279, 58);
            this.PanelBottom.TabIndex = 27;
            // 
            // PanelNavigation
            // 
            this.PanelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.PanelNavigation.Controls.Add(this.LabelAnimationSpeed);
            this.PanelNavigation.Controls.Add(this.ButtonStepForward);
            this.PanelNavigation.Controls.Add(this.ButtonStepBack);
            this.PanelNavigation.Controls.Add(this.ButtonPause);
            this.PanelNavigation.Controls.Add(this.TrackbarSpeed);
            this.PanelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelNavigation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelNavigation.Location = new System.Drawing.Point(0, 615);
            this.PanelNavigation.Name = "PanelNavigation";
            this.PanelNavigation.Size = new System.Drawing.Size(1279, 77);
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
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.PanelTop.Controls.Add(this.Heading);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1279, 58);
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
            this.PanelTopNavigation.Size = new System.Drawing.Size(1279, 77);
            this.PanelTopNavigation.TabIndex = 30;
            // 
            // label2
            // 
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
            this.PanelLeft.Size = new System.Drawing.Size(823, 480);
            this.PanelLeft.TabIndex = 31;
            // 
            // PictureBoxGraph
            // 
            this.PictureBoxGraph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBoxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxGraph.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxGraph.Name = "PictureBoxGraph";
            this.PictureBoxGraph.Size = new System.Drawing.Size(823, 480);
            this.PictureBoxGraph.TabIndex = 11;
            this.PictureBoxGraph.TabStop = false;
            this.PictureBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxGraph_MouseClick_1);
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.PanelRight.Controls.Add(this.ButtonUndoVertex);
            this.PanelRight.Controls.Add(this.AddEdge);
            this.PanelRight.Controls.Add(this.ComboBoxFrom);
            this.PanelRight.Controls.Add(this.AddVertex);
            this.PanelRight.Controls.Add(this.LogBox);
            this.PanelRight.Controls.Add(this.ComboBoxTo);
            this.PanelRight.Controls.Add(this.ButtonUndoEdge);
            this.PanelRight.Controls.Add(this.TextBoxWeight);
            this.PanelRight.Controls.Add(this.ButtonAdd);
            this.PanelRight.Controls.Add(this.ButtonFinalize);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(831, 135);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(448, 480);
            this.PanelRight.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1279, 750);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTopNavigation);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelNavigation);
            this.Controls.Add(this.PanelBottom);
            this.MinimumSize = new System.Drawing.Size(1297, 797);
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
            this.PanelRight.PerformLayout();
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
    }
}