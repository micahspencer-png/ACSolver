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
            FrequencyTextBox.Clear();
            FrequencyTextBox.Text = "1000";
            VGenTextBox.Clear();
            VGenTextBox.Text = "5";
            RWindingTextBox.Clear();
            RWindingTextBox.Text = "20";
            RGenComboBox.SelectedIndex = 0;
            R1PrefixComboBox.SelectedIndex = 0;
            C1PrefixComboBox.SelectedIndex = 1;
            C2PrefixComboBox.SelectedIndex = 1;
            L1PrefixComboBox.SelectedIndex = 1;
            R1ValueComboBox.SelectedIndex = 0;
            C1ValueComboBox.SelectedIndex = 0;
            C2ValueComboBox.SelectedIndex = 0;
            L1ValueComboBox.SelectedIndex = 0;
            RectangularRadioButton.Checked = true;
        }

        void AddItems()
        {
            RWindinglabel2.Text = $"{ohm}";
            RGenComboBox.Items.Clear();
            RGenComboBox.Items.Add("50");
            RGenComboBox.Items.Add("400");
            R1PrefixComboBox.Items.Clear();
            R1PrefixComboBox.Items.Add($"{ohm}");
            R1PrefixComboBox.Items.Add($"K{ohm}");
            R1PrefixComboBox.Items.Add($"M{ohm}");
            C1PrefixComboBox.Items.Clear();
            C1PrefixComboBox.Items.Add("pF");
            C1PrefixComboBox.Items.Add($"{micro}F");
            C2PrefixComboBox.Items.Clear();
            C2PrefixComboBox.Items.Add("pF");
            C2PrefixComboBox.Items.Add($"{micro}F");
            L1PrefixComboBox.Items.Clear();
            L1PrefixComboBox.Items.Add($"{micro}H");
            L1PrefixComboBox.Items.Add("mH");
            R1ValueComboBox.Items.Clear();
            R1ValueComboBox.Items.Add($"{1*1}");
        }

        void DrawImage() 
        {
            ImagePictureBox.BackgroundImage = Image.FromFile(ACPath);
            ImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void ValidateInputs() 
        {
            bool Valid = true;

            if (RGenComboBox.SelectedIndex == -1) 
            {
                Valid = false;
            }
            else if (R1ValueComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (R1PrefixComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (C1ValueComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (C1PrefixComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (C2ValueComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (C2PrefixComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (L1ValueComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (L1PrefixComboBox.SelectedIndex == -1)
            {
                Valid = false;
            }
            else if (FrequencyTextBox.Text == "")
            {
                Valid = false;
            }
            else if (RWindingTextBox.Text == "")
            {
                Valid = false;
            }

            if (!PolarRadioButton.Checked && !RectangularRadioButton.Checked)
            {
                Valid = false;
            }

            if (Valid == true)
            {
                DisplayResults();
            }
            else 
            {
                MessageBox.Show("Check Inputs. Make Sure All Values are Filled In and Correct");
            }
        }

        void DisplayResults()
        {
            Math();
            ResultsListBox.Items.Clear();
            ResultsListBox.Items.Add("Z total:");
            ResultsListBox.Items.Add("I Total:");
            ResultsListBox.Items.Add("R1:");
            ResultsListBox.Items.Add("C1:");
            ResultsListBox.Items.Add("C2:");
            ResultsListBox.Items.Add("L1:");
            ResultsListBox.Items.Add("XC1:");
            ResultsListBox.Items.Add("XC2:");
            ResultsListBox.Items.Add("XL1:");
            ResultsListBox.Items.Add("ZL1:");
            ResultsListBox.Items.Add("ZEQ:");
            ResultsListBox.Items.Add("VRGen:");
            ResultsListBox.Items.Add("VR1:");
            ResultsListBox.Items.Add("VC1:");
            ResultsListBox.Items.Add("VC2:");
            ResultsListBox.Items.Add("VL1:");
            ResultsListBox.Items.Add("IRGen:");
            ResultsListBox.Items.Add("IR1:");
            ResultsListBox.Items.Add("IC1:");
            ResultsListBox.Items.Add("IC2:");
            ResultsListBox.Items.Add("IL1:");
            ResultsListBox.Items.Add("Real Power:");
            ResultsListBox.Items.Add("Reactive Power:");
            ResultsListBox.Items.Add("Apparent Power:");
        }

        void Math() 
        {
            if (PolarRadioButton.Checked == true) 
            {
                
            }
            else if (RectangularRadioButton.Checked == true) 
            {
                
            } 
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
            ValidateInputs();
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
                else if (Hz < 1) 
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

        private void RWindingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Hz = int.Parse(RWindingTextBox.Text);
                if (Hz > 1000)
                {

                    RWindingTextBox.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Check Input. It has to be whole numbers between 0-1,000");
                    RWindingTextBox.Clear();
                }
                else if (Hz < 0)
                {
                    RWindingTextBox.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Check Input. It has to be whole numbers between 0-1,000");
                    RWindingTextBox.Clear();
                }
                else
                {
                    RWindingTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                RWindingTextBox.BackColor = Color.PaleVioletRed;
                if (RWindingTextBox.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("Check Input. It has to be whole numbers between 0-1,000");
                    RWindingTextBox.Clear();
                }
            }
        }
    }
}
