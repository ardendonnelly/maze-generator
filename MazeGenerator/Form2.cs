using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class Form2 : Form
    {
        public int width = 10;
        public int height = 10;
        public string generationAlgorithm = "Binary Tree";
        public Form2()
        {
            InitializeComponent();
        }

        private void BTSaveAndExit_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt16(NUDWidth.Value);
            height = Convert.ToInt16(NUDHeight.Value);
            generationAlgorithm = CBAdvGenerationAlg.SelectedItem.ToString();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (CBAdvGenerationAlg.SelectedItem == null)
                CBAdvGenerationAlg.SelectedIndex = 0;
        }
    }
}
