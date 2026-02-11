namespace MazeGenerator
{
    public partial class Form2 : Form
    {
        public bool saved = true;
        public bool ratioMaintained = false;

        public int width = 10;
        public int height = 10;
        public string generationAlgorithm = "Binary Tree";

        public Color wallColour = Color.Black;
        public Color pathColour = Color.LightBlue;
        public Color backgroundColour = Color.WhiteSmoke;
        public Color startColour = Color.LimeGreen;
        public Color endColour = Color.Red;

        ColorDialog wallDialog = new ColorDialog();
        ColorDialog pathDialog = new ColorDialog();
        ColorDialog backgroundDialog = new ColorDialog();
        ColorDialog startDialog = new ColorDialog();
        ColorDialog endDialog = new ColorDialog();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (CBAdvGenerationAlg.SelectedItem == null)
                CBAdvGenerationAlg.SelectedIndex = 0;
            saved = true;
            LBLChangesSaved.Visible = false;
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            saved = true;
            LBLChangesSaved.Visible = false;

            width = Convert.ToInt16(NUDWidth.Value);
            height = Convert.ToInt16(NUDHeight.Value);
            generationAlgorithm = CBAdvGenerationAlg.SelectedItem.ToString();
            wallColour = BTWallColour.BackColor;
            pathColour = BTPathColour.BackColor;
            backgroundColour = BTBackgroundColour.BackColor;
            startColour = BTStartColour.BackColor;
            endColour = BTEndColour.BackColor;
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LBLChangesSaved.Visible = false;
                    NUDWidth.Value = width;
                    NUDHeight.Value = height;
                    CBAdvGenerationAlg.SelectedItem = generationAlgorithm;
                    BTWallColour.BackColor = wallColour;
                    BTPathColour.BackColor = pathColour;
                    BTBackgroundColour.BackColor = backgroundColour;
                    BTStartColour.BackColor = startColour;
                    BTEndColour.BackColor = endColour;
                    this.Close();
                }
            }
            else
            {
                LBLChangesSaved.Visible = false;
                this.Close();
            }

        }

        private void BTWallColour_Click(object sender, EventArgs e)
        {
            if (wallDialog.ShowDialog() == DialogResult.OK)
            {
                BTWallColour.BackColor = wallDialog.Color;
                LBLChangesSaved.Visible = true;
                saved = false;
            }

        }

        private void BTPathColour_Click(object sender, EventArgs e)
        {
            if (pathDialog.ShowDialog() == DialogResult.OK)
            {
                BTPathColour.BackColor = pathDialog.Color;
                LBLChangesSaved.Visible = true;
                saved = false;
            }
        }

        private void BTBackgroundColour_Click(object sender, EventArgs e)
        {
            if (backgroundDialog.ShowDialog() == DialogResult.OK)
            {
                BTBackgroundColour.BackColor = backgroundDialog.Color;
                LBLChangesSaved.Visible = true;
                saved = false;
            }
        }

        private void BTStartColour_Click(object sender, EventArgs e)
        {
            if (startDialog.ShowDialog() == DialogResult.OK)
            {
                BTStartColour.BackColor = startDialog.Color;
                LBLChangesSaved.Visible = true;
                saved = false;
            }
        }

        private void BTEndColour_Click(object sender, EventArgs e)
        {
            if (endDialog.ShowDialog() == DialogResult.OK)
            {
                BTEndColour.BackColor = endDialog.Color;
                LBLChangesSaved.Visible = true;
                saved = false;
            }
        }

        private void BTResetToDefault_Click(object sender, EventArgs e)
        {
            CBAdvGenerationAlg.SelectedIndex = 0;
            BTWallColour.BackColor = Color.Black;
            BTPathColour.BackColor = Color.LightBlue;
            BTBackgroundColour.BackColor = Color.WhiteSmoke;
            BTStartColour.BackColor = Color.LimeGreen;
            BTEndColour.BackColor = Color.Red;
            LBLChangesSaved.Visible = true;
            NUDHeight.Value = 10;
            NUDWidth.Value = 10;
            saved = false;
        }

        private void NUDWidth_ValueChanged(object sender, EventArgs e)
        {
            if (ratioMaintained)
                NUDHeight.Value = NUDWidth.Value;
            LBLChangesSaved.Visible = true;
            saved = false;
        }

        private void NUDHeight_ValueChanged(object sender, EventArgs e)
        {
            LBLChangesSaved.Visible = true;
            saved = false;
        }

        private void CBAdvGenerationAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBLChangesSaved.Visible = true;
            saved = false;
        }

        private void CHMaintainAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (CHMaintainAspectRatio.Checked)
            {
                CHMaintainAspectRatio.ImageIndex = 1;
                NUDHeight.Enabled = false;
                NUDHeight.Value = NUDWidth.Value;
            }
            else
            {
                CHMaintainAspectRatio.ImageIndex = 0;
                NUDHeight.Enabled = true;
            }

            ratioMaintained = CHMaintainAspectRatio.Checked;
            NUDHeight.Value = NUDWidth.Value;
        }
    }
}
