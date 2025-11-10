namespace MazeGenerator
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
            PBMaze = new PictureBox();
            CBGenerationAlg = new ComboBox();
            CHPathShown = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PBMaze).BeginInit();
            SuspendLayout();
            // 
            // PBMaze
            // 
            PBMaze.Location = new Point(19, 17);
            PBMaze.Margin = new Padding(5, 4, 5, 4);
            PBMaze.Name = "PBMaze";
            PBMaze.Size = new Size(100, 50);
            PBMaze.SizeMode = PictureBoxSizeMode.AutoSize;
            PBMaze.TabIndex = 0;
            PBMaze.TabStop = false;
            // 
            // CBGenerationAlg
            // 
            CBGenerationAlg.BackColor = SystemColors.Window;
            CBGenerationAlg.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGenerationAlg.Font = new Font("Courier New", 15.75F);
            CBGenerationAlg.FormattingEnabled = true;
            CBGenerationAlg.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            CBGenerationAlg.Location = new Point(922, 88);
            CBGenerationAlg.Margin = new Padding(5, 4, 5, 4);
            CBGenerationAlg.Name = "CBGenerationAlg";
            CBGenerationAlg.Size = new Size(316, 31);
            CBGenerationAlg.TabIndex = 1;
            CBGenerationAlg.SelectedIndexChanged += Form1_Load;
            // 
            // CHPathShown
            // 
            CHPathShown.AutoSize = true;
            CHPathShown.BackColor = Color.White;
            CHPathShown.Font = new Font("Courier New", 15.75F);
            CHPathShown.Location = new Point(1092, 29);
            CHPathShown.Margin = new Padding(5, 4, 5, 4);
            CHPathShown.Name = "CHPathShown";
            CHPathShown.Size = new Size(146, 27);
            CHPathShown.TabIndex = 2;
            CHPathShown.Text = "Show Path";
            CHPathShown.UseVisualStyleBackColor = false;
            CHPathShown.CheckedChanged += CHPathShown_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(922, 21);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 41);
            button1.TabIndex = 3;
            button1.Text = "New Maze";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Form1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(CHPathShown);
            Controls.Add(CBGenerationAlg);
            Controls.Add(PBMaze);
            Font = new Font("Courier New", 14.25F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PBMaze).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBMaze;
        private ComboBox CBGenerationAlg;
        private CheckBox CHPathShown;
        private Button button1;
    }
}
