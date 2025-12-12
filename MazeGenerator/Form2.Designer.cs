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
            BTSaveAndExit = new Button();
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
            // 
            // NUDHeight
            // 
            NUDHeight.Font = new Font("Courier New", 15.75F);
            NUDHeight.Location = new Point(227, 224);
            NUDHeight.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDHeight.Name = "NUDHeight";
            NUDHeight.Size = new Size(120, 31);
            NUDHeight.TabIndex = 4;
            NUDHeight.TextAlign = HorizontalAlignment.Center;
            NUDHeight.Value = new decimal(new int[] { 10, 0, 0, 0 });
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
            Height.Location = new Point(31, 226);
            Height.Name = "Height";
            Height.Size = new Size(88, 23);
            Height.TabIndex = 6;
            Height.Text = "Height";
            // 
            // BTSaveAndExit
            // 
            BTSaveAndExit.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTSaveAndExit.Location = new Point(293, 375);
            BTSaveAndExit.Margin = new Padding(5, 4, 5, 4);
            BTSaveAndExit.Name = "BTSaveAndExit";
            BTSaveAndExit.Size = new Size(223, 41);
            BTSaveAndExit.TabIndex = 7;
            BTSaveAndExit.Text = "Save and Exit";
            BTSaveAndExit.UseVisualStyleBackColor = true;
            BTSaveAndExit.Click += BTSaveAndExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTSaveAndExit);
            Controls.Add(Height);
            Controls.Add(label1);
            Controls.Add(NUDHeight);
            Controls.Add(NUDWidth);
            Controls.Add(CBAdvGenerationAlg);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
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
        private Button BTSaveAndExit;
    }
}