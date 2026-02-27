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
        void SetDefaults() 
        {
        
        }

        void AddItems()
        {

        }

        void DrawImage() 
        {
            ImagePictureBox.BackgroundImage = Image.FromFile(ACPath);
            ImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }


        void DisplayResults()
        {

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
            DisplayResults();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void VGenTrackBar_Scroll(object sender, EventArgs e)
        {
            VGenTextBox.Text = VGenTrackBar.Value.ToString();
        }

        private void VGenTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                VGenTrackBar.Value = int.Parse(VGenTextBox.Text);
                VGenTextBox.BackColor = Color.White;
            }
            catch 
            {
                VGenTextBox.BackColor= Color.PaleVioletRed;
                MessageBox.Show("Check Input. It has to be whole numbers between 0-10");
            }
        }

        private void FrequencyTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                int Hz = int.Parse(FrequencyTextBox.Text);
                if (Hz > 1000000) 
                {
                    FrequencyTextBox.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Check Input. It has to be whole numbers between 1-1,000,000");
                }
                else if (Hz < 0) 
                {
                    FrequencyTextBox.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Check Input. It has to be whole numbers between 1-1,000,000");
                }
                else 
                {
                    FrequencyTextBox.BackColor = Color.White;
                }
            }
            catch 
            {
                FrequencyTextBox.BackColor= Color.PaleVioletRed;
                MessageBox.Show("Check Input. It has to be whole numbers between 1-1,000,000");
            }
        }
    }
}
