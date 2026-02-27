using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitSolver
{
    //Micah Spencer
    //RCET 3371
    //Spring 2026
    //Circuit Solver Program
    //
    public partial class CircuitSolver : Form
    {
        string ACPath = "..\\..\\..\\AC-SeriesParallel.png";
        public CircuitSolver()
        {
            InitializeComponent();
            DrawImage();
        }
        //Program Logic------------------------------------------------------------------------------------------------

        void DrawImage() 
        {
            ImagePictureBox.BackgroundImage = Image.FromFile(ACPath);
            ImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        //Event Handlers-----------------------------------------------------------------------------------------------
        private void CircuitSolver_Load(object sender, EventArgs e)
        {
            DrawImage();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void PolarRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RGenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void R1ValueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void R1PrefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void C1ValueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void C1PrefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void C2ValueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void C2PrefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L1ValueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L1PrefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
