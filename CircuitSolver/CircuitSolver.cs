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
        string ohm = "\u03A9";
        string micro = "\u00B5";
        string angle = "\u2220";
        string degree = "\u00B0";
        string pi = "\u03C0";
        string euler = "\u0065";
        string infinity = "\u221E";
        public CircuitSolver()
        {
            InitializeComponent();
            DrawImage();
            AddItems();
        }
        //Program Logic------------------------------------------------------------------------------------------------
        void SetDefaults() 
        {
        
        }

        void AddItems()
        {
            RGenComboBox.Items.Clear();
            RGenComboBox.Items.Add("50");
            RGenComboBox.Items.Add("400");
            R1PrefixComboBox.Items.Clear();
            R1PrefixComboBox.Items.Add($"{ohm}");
            R1PrefixComboBox.Items.Add($"K{ohm}");
            R1PrefixComboBox.Items.Add($"M{ohm}");
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
                if (VGenTextBox.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("Check Input. It has to be whole numbers between 0-10");
                    VGenTextBox.Clear();
                }
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
                    FrequencyTextBox.Clear();
                }
                else if (Hz < 0) 
                {
                    FrequencyTextBox.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Check Input. It has to be whole numbers between 1-1,000,000");
                    FrequencyTextBox.Clear();
                }
                else 
                {
                    FrequencyTextBox.BackColor = Color.White;
                }
            }
            catch 
            {
                FrequencyTextBox.BackColor= Color.PaleVioletRed;
                if (FrequencyTextBox.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("Check Input. It has to be whole numbers between 1-1,000,000");
                    FrequencyTextBox.Clear();
                }
            }
        }
    }
}
