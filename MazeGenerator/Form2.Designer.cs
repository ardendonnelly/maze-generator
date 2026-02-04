namespace MazeGenerator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CBAdvGenerationAlg = new ComboBox();
            NUDWidth = new NumericUpDown();
            NUDHeight = new NumericUpDown();
            label1 = new Label();
            Height = new Label();
            BTSave = new Button();
            BTWallColour = new Button();
            label2 = new Label();
            BTPathColour = new Button();
            BTBackgroundColour = new Button();
            BTStartColour = new Button();
            BTEndColour = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BTResetToDefault = new Button();
            BTExit = new Button();
            LBLChangesSaved = new Label();
            CHMaintainAspectRatio = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)NUDWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDHeight).BeginInit();
            SuspendLayout();
            // 
            // CBAdvGenerationAlg
            // 
            CBAdvGenerationAlg.BackColor = SystemColors.Window;
            CBAdvGenerationAlg.DropDownStyle = ComboBoxStyle.DropDownList;
            CBAdvGenerationAlg.Font = new Font("Courier New", 15.75F);
            CBAdvGenerationAlg.FormattingEnabled = true;
            CBAdvGenerationAlg.Items.AddRange(new object[] { "Binary Tree", "Iterative Backtracker", "Randomized Kruskal's" });
            CBAdvGenerationAlg.Location = new Point(31, 36);
            CBAdvGenerationAlg.Margin = new Padding(5, 4, 5, 4);
            CBAdvGenerationAlg.Name = "CBAdvGenerationAlg";
            CBAdvGenerationAlg.Size = new Size(316, 31);
            CBAdvGenerationAlg.TabIndex = 2;
            CBAdvGenerationAlg.SelectedIndexChanged += CBAdvGenerationAlg_SelectedIndexChanged;
            // 
            // NUDWidth
            // 
            NUDWidth.Font = new Font("Courier New", 15.75F);
            NUDWidth.Location = new Point(227, 150);
            NUDWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDWidth.Name = "NUDWidth";
            NUDWidth.Size = new Size(120, 31);
            NUDWidth.TabIndex = 3;
            NUDWidth.TextAlign = HorizontalAlignment.Center;
            NUDWidth.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NUDWidth.ValueChanged += NUDWidth_ValueChanged;
            // 
            // NUDHeight
            // 
            NUDHeight.Font = new Font("Courier New", 15.75F);
            NUDHeight.Location = new Point(227, 204);
            NUDHeight.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDHeight.Name = "NUDHeight";
            NUDHeight.Size = new Size(120, 31);
            NUDHeight.TabIndex = 4;
            NUDHeight.TextAlign = HorizontalAlignment.Center;
            NUDHeight.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NUDHeight.ValueChanged += NUDHeight_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 15.75F);
            label1.Location = new Point(31, 152);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 5;
            label1.Text = "Width";
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Font = new Font("Courier New", 15.75F);
            Height.Location = new Point(31, 206);
            Height.Name = "Height";
            Height.Size = new Size(88, 23);
            Height.TabIndex = 6;
            Height.Text = "Height";
            // 
            // BTSave
            // 
            BTSave.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTSave.Location = new Point(241, 386);
            BTSave.Margin = new Padding(5, 4, 5, 4);
            BTSave.Name = "BTSave";
            BTSave.Size = new Size(144, 41);
            BTSave.TabIndex = 7;
            BTSave.Text = "Save";
            BTSave.UseVisualStyleBackColor = true;
            BTSave.Click += BTSave_Click;
            // 
            // BTWallColour
            // 
            BTWallColour.BackColor = Color.Black;
            BTWallColour.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTWallColour.Location = new Point(674, 36);
            BTWallColour.Margin = new Padding(5, 4, 5, 4);
            BTWallColour.Name = "BTWallColour";
            BTWallColour.Size = new Size(43, 41);
            BTWallColour.TabIndex = 8;
            BTWallColour.UseVisualStyleBackColor = false;
            BTWallColour.Click += BTWallColour_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F);
            label2.Location = new Point(478, 44);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 9;
            label2.Text = "Wall";
            // 
            // BTPathColour
            // 
            BTPathColour.BackColor = Color.LightBlue;
            BTPathColour.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTPathColour.Location = new Point(674, 85);
            BTPathColour.Margin = new Padding(5, 4, 5, 4);
            BTPathColour.Name = "BTPathColour";
            BTPathColour.Size = new Size(43, 41);
            BTPathColour.TabIndex = 10;
            BTPathColour.UseVisualStyleBackColor = false;
            BTPathColour.Click += BTPathColour_Click;
            // 
            // BTBackgroundColour
            // 
            BTBackgroundColour.BackColor = Color.WhiteSmoke;
            BTBackgroundColour.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTBackgroundColour.Location = new Point(674, 134);
            BTBackgroundColour.Margin = new Padding(5, 4, 5, 4);
            BTBackgroundColour.Name = "BTBackgroundColour";
            BTBackgroundColour.Size = new Size(43, 41);
            BTBackgroundColour.TabIndex = 11;
            BTBackgroundColour.UseVisualStyleBackColor = false;
            BTBackgroundColour.Click += BTBackgroundColour_Click;
            // 
            // BTStartColour
            // 
            BTStartColour.BackColor = Color.LimeGreen;
            BTStartColour.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTStartColour.Location = new Point(674, 183);
            BTStartColour.Margin = new Padding(5, 4, 5, 4);
            BTStartColour.Name = "BTStartColour";
            BTStartColour.Size = new Size(43, 41);
            BTStartColour.TabIndex = 12;
            BTStartColour.UseVisualStyleBackColor = false;
            BTStartColour.Click += BTStartColour_Click;
            // 
            // BTEndColour
            // 
            BTEndColour.BackColor = Color.Red;
            BTEndColour.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTEndColour.Location = new Point(674, 232);
            BTEndColour.Margin = new Padding(5, 4, 5, 4);
            BTEndColour.Name = "BTEndColour";
            BTEndColour.Size = new Size(43, 41);
            BTEndColour.TabIndex = 13;
            BTEndColour.UseVisualStyleBackColor = false;
            BTEndColour.Click += BTEndColour_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F);
            label3.Location = new Point(478, 94);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 14;
            label3.Text = "Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F);
            label4.Location = new Point(478, 143);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 15;
            label4.Text = "Background";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F);
            label5.Location = new Point(478, 192);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 16;
            label5.Text = "Start";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F);
            label6.Location = new Point(478, 241);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 17;
            label6.Text = "End";
            // 
            // BTResetToDefault
            // 
            BTResetToDefault.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTResetToDefault.Location = new Point(460, 303);
            BTResetToDefault.Margin = new Padding(5, 4, 5, 4);
            BTResetToDefault.Name = "BTResetToDefault";
            BTResetToDefault.Size = new Size(286, 41);
            BTResetToDefault.TabIndex = 18;
            BTResetToDefault.Text = "Reset to Default";
            BTResetToDefault.UseVisualStyleBackColor = true;
            BTResetToDefault.Click += BTResetToDefault_Click;
            // 
            // BTExit
            // 
            BTExit.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTExit.Location = new Point(418, 386);
            BTExit.Margin = new Padding(5, 4, 5, 4);
            BTExit.Name = "BTExit";
            BTExit.Size = new Size(144, 41);
            BTExit.TabIndex = 19;
            BTExit.Text = "Exit";
            BTExit.UseVisualStyleBackColor = true;
            BTExit.Click += BTExit_Click;
            // 
            // LBLChangesSaved
            // 
            LBLChangesSaved.AutoSize = true;
            LBLChangesSaved.Font = new Font("Courier New", 15.75F);
            LBLChangesSaved.Location = new Point(28, 312);
            LBLChangesSaved.Name = "LBLChangesSaved";
            LBLChangesSaved.Size = new Size(370, 23);
            LBLChangesSaved.TabIndex = 20;
            LBLChangesSaved.Text = "⚠ You have unsaved changes!";
            LBLChangesSaved.Visible = false;
            // 
            // CHMaintainAspectRatio
            // 
            CHMaintainAspectRatio.AutoSize = true;
            CHMaintainAspectRatio.BackColor = Color.Transparent;
            CHMaintainAspectRatio.Font = new Font("Courier New", 15.75F);
            CHMaintainAspectRatio.Location = new Point(31, 257);
            CHMaintainAspectRatio.Margin = new Padding(5, 4, 5, 4);
            CHMaintainAspectRatio.Name = "CHMaintainAspectRatio";
            CHMaintainAspectRatio.Size = new Size(302, 27);
            CHMaintainAspectRatio.TabIndex = 21;
            CHMaintainAspectRatio.Text = "Maintain aspect ratio";
            CHMaintainAspectRatio.UseVisualStyleBackColor = false;
            CHMaintainAspectRatio.CheckedChanged += CHMaintainAspectRatio_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(CHMaintainAspectRatio);
            Controls.Add(LBLChangesSaved);
            Controls.Add(BTExit);
            Controls.Add(BTResetToDefault);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BTEndColour);
            Controls.Add(BTStartColour);
            Controls.Add(BTBackgroundColour);
            Controls.Add(BTPathColour);
            Controls.Add(label2);
            Controls.Add(BTWallColour);
            Controls.Add(BTSave);
            Controls.Add(Height);
            Controls.Add(label1);
            Controls.Add(NUDHeight);
            Controls.Add(NUDWidth);
            Controls.Add(CBAdvGenerationAlg);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Advanced Options";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)NUDWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBAdvGenerationAlg;
        private NumericUpDown NUDWidth;
        private NumericUpDown NUDHeight;
        private Label label1;
        private Label Height;
        private Button BTSave;
        private Button BTWallColour;
        private Label label2;
        private Button BTPathColour;
        private Button BTBackgroundColour;
        private Button BTStartColour;
        private Button BTEndColour;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BTResetToDefault;
        private Button BTExit;
        private Label LBLChangesSaved;
        private CheckBox CHMaintainAspectRatio;
    }
}