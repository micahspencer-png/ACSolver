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
        string ztotal = "";
        string igen = "";
        string r1 = "";
        string c1 = "";
        string c2 = "";
        string l1 = "";
        string xc1 = "";
        string xc2 = "";
        string xl1 = "";
        string zl1 = "";
        string zeq = "";
        string vrgen = "";
        string vr1 = "";
        string vc1 = "";
        string vc2 = "";
        string vl1 = "";
        string irgen = "";
        string ir1 = "";
        string ic1 = "";
        string ic2 = "";
        string il1 = "";
        string realP = "";
        string reactP = "";
        string apparentP = "";
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
            R1ValueComboBox.SelectedIndex = 48;
            C1ValueComboBox.SelectedIndex = 12;
            C2ValueComboBox.SelectedIndex = 12;
            L1ValueComboBox.SelectedIndex = 2;
            RectangularRadioButton.Checked = true;
            ResultsListBox.Items.Clear();
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
            R1ValueComboBox.Items.Add($"{1 * 1}");
            R1ValueComboBox.Items.Add($"{1.1 * 1}");
            R1ValueComboBox.Items.Add($"{1.2 * 1}");
            R1ValueComboBox.Items.Add($"{1.3 * 1}");
            R1ValueComboBox.Items.Add($"{1.5 * 1}");
            R1ValueComboBox.Items.Add($"{1.6 * 1}");
            R1ValueComboBox.Items.Add($"{1.8 * 1}");
            R1ValueComboBox.Items.Add($"{2 * 1}");
            R1ValueComboBox.Items.Add($"{2.2 * 1}");
            R1ValueComboBox.Items.Add($"{2.4 * 1}");
            R1ValueComboBox.Items.Add($"{2.7 * 1}");
            R1ValueComboBox.Items.Add($"{3 * 1}");
            R1ValueComboBox.Items.Add($"{3.3 * 1}");
            R1ValueComboBox.Items.Add($"{3.6 * 1}");
            R1ValueComboBox.Items.Add($"{3.9 * 1}");
            R1ValueComboBox.Items.Add($"{4.3 * 1}");
            R1ValueComboBox.Items.Add($"{4.7 * 1}");
            R1ValueComboBox.Items.Add($"{5.1 * 1}");
            R1ValueComboBox.Items.Add($"{5.6 * 1}");
            R1ValueComboBox.Items.Add($"{6.2 * 1}");
            R1ValueComboBox.Items.Add($"{6.8 * 1}");
            R1ValueComboBox.Items.Add($"{7.5 * 1}");
            R1ValueComboBox.Items.Add($"{8.2 * 1}");
            R1ValueComboBox.Items.Add($"{9.1 * 1}");
            R1ValueComboBox.Items.Add($"{1 * 10}");
            R1ValueComboBox.Items.Add($"{1.1 * 10}");
            R1ValueComboBox.Items.Add($"{1.2 * 10}");
            R1ValueComboBox.Items.Add($"{1.3 * 10}");
            R1ValueComboBox.Items.Add($"{1.5 * 10}");
            R1ValueComboBox.Items.Add($"{1.6 * 10}");
            R1ValueComboBox.Items.Add($"{1.8 * 10}");
            R1ValueComboBox.Items.Add($"{2 * 10}");
            R1ValueComboBox.Items.Add($"{2.2 * 10}");
            R1ValueComboBox.Items.Add($"{2.4 * 10}");
            R1ValueComboBox.Items.Add($"{2.7 * 10}");
            R1ValueComboBox.Items.Add($"{3 * 10}");
            R1ValueComboBox.Items.Add($"{3.3 * 10}");
            R1ValueComboBox.Items.Add($"{3.6 * 10}");
            R1ValueComboBox.Items.Add($"{3.9 * 10}");
            R1ValueComboBox.Items.Add($"{4.3 * 10}");
            R1ValueComboBox.Items.Add($"{4.7 * 10}");
            R1ValueComboBox.Items.Add($"{5.1 * 10}");
            R1ValueComboBox.Items.Add($"{5.6 * 10}");
            R1ValueComboBox.Items.Add($"{6.2 * 10}");
            R1ValueComboBox.Items.Add($"{6.8 * 10}");
            R1ValueComboBox.Items.Add($"{7.5 * 10}");
            R1ValueComboBox.Items.Add($"{8.2 * 10}");
            R1ValueComboBox.Items.Add($"{9.1 * 10}");
            R1ValueComboBox.Items.Add($"{1 * 100}");
            R1ValueComboBox.Items.Add($"{1.1 * 100}");
            R1ValueComboBox.Items.Add($"{1.2 * 100}");
            R1ValueComboBox.Items.Add($"{1.3 * 100}");
            R1ValueComboBox.Items.Add($"{1.5 * 100}");
            R1ValueComboBox.Items.Add($"{1.6 * 100}");
            R1ValueComboBox.Items.Add($"{1.8 * 100}");
            R1ValueComboBox.Items.Add($"{2 * 100}");
            R1ValueComboBox.Items.Add($"{2.2 * 100}");
            R1ValueComboBox.Items.Add($"{2.4 * 100}");
            R1ValueComboBox.Items.Add($"{2.7 * 100}");
            R1ValueComboBox.Items.Add($"{3 * 100}");
            R1ValueComboBox.Items.Add($"{3.3 * 100}");
            R1ValueComboBox.Items.Add($"{3.6 * 100}");
            R1ValueComboBox.Items.Add($"{3.9 * 100}");
            R1ValueComboBox.Items.Add($"{4.3 * 100}");
            R1ValueComboBox.Items.Add($"{4.7 * 100}");
            R1ValueComboBox.Items.Add($"{5.1 * 100}");
            R1ValueComboBox.Items.Add($"{5.6 * 100}");
            R1ValueComboBox.Items.Add($"{6.2 * 100}");
            R1ValueComboBox.Items.Add($"{6.8 * 100}");
            R1ValueComboBox.Items.Add($"{7.5 * 100}");
            R1ValueComboBox.Items.Add($"{8.2 * 100}");
            R1ValueComboBox.Items.Add($"{9.1 * 100}");

            C1ValueComboBox.Items.Add($"{0.01 * 1}");
            C1ValueComboBox.Items.Add($"{0.02 * 1}");
            C1ValueComboBox.Items.Add($"{0.022 * 1}");
            C1ValueComboBox.Items.Add($"{0.025 * 1}");
            C1ValueComboBox.Items.Add($"{0.033 * 1}");
            C1ValueComboBox.Items.Add($"{0.047 * 1}");
            C1ValueComboBox.Items.Add($"{0.068 * 1}");
            C1ValueComboBox.Items.Add($"{0.01 * 10}");
            C1ValueComboBox.Items.Add($"{0.02 * 10}");
            C1ValueComboBox.Items.Add($"{0.033 * 10}");
            C1ValueComboBox.Items.Add($"{0.047 * 10}");
            C1ValueComboBox.Items.Add($"{0.5}");
            C1ValueComboBox.Items.Add($"{0.01 * 100}");
            C1ValueComboBox.Items.Add($"{0.033 * 100}");
            C1ValueComboBox.Items.Add($"{0.047 * 100}");
            C1ValueComboBox.Items.Add($"{0.01 * 1000}");
            C1ValueComboBox.Items.Add($"{0.022 * 1000}");
            C1ValueComboBox.Items.Add($"{0.033 * 1000}");
            C1ValueComboBox.Items.Add($"{0.047 * 1000}");
            C1ValueComboBox.Items.Add($"{0.01 * 10000}");
            C1ValueComboBox.Items.Add($"{0.022 * 10000}");
            C1ValueComboBox.Items.Add($"{0.033 * 10000}");
            C1ValueComboBox.Items.Add($"{0.047 * 10000}");
            C1ValueComboBox.Items.Add($"{0.01 * 100000}");
            C1ValueComboBox.Items.Add($"{0.022 * 100000}");
            C1ValueComboBox.Items.Add($"{0.033 * 100000}");
            C1ValueComboBox.Items.Add($"{0.047 * 100000}");
            C1ValueComboBox.Items.Add($"{68 * 1}");
            C1ValueComboBox.Items.Add($"{68 * 10}");
            C1ValueComboBox.Items.Add($"{68 * 100}");
            C1ValueComboBox.Items.Add($"{15 * 1}");
            C1ValueComboBox.Items.Add($"{15 * 10}");
            C1ValueComboBox.Items.Add($"{15 * 100}");
            C1ValueComboBox.Items.Add($"{180 * 1}");
            C1ValueComboBox.Items.Add($"{180 * 10}");

            C2ValueComboBox.Items.Add($"{0.01 * 1}");
            C2ValueComboBox.Items.Add($"{0.02 * 1}");
            C2ValueComboBox.Items.Add($"{0.022 * 1}");
            C2ValueComboBox.Items.Add($"{0.025 * 1}");
            C2ValueComboBox.Items.Add($"{0.033 * 1}");
            C2ValueComboBox.Items.Add($"{0.047 * 1}");
            C2ValueComboBox.Items.Add($"{0.068 * 1}");
            C2ValueComboBox.Items.Add($"{0.01 * 10}");
            C2ValueComboBox.Items.Add($"{0.02 * 10}");
            C2ValueComboBox.Items.Add($"{0.033 * 10}");
            C2ValueComboBox.Items.Add($"{0.047 * 10}");
            C2ValueComboBox.Items.Add($"{0.5}");
            C2ValueComboBox.Items.Add($"{0.01 * 100}");
            C2ValueComboBox.Items.Add($"{0.033 * 100}");
            C2ValueComboBox.Items.Add($"{0.047 * 100}");
            C2ValueComboBox.Items.Add($"{0.01 * 1000}");
            C2ValueComboBox.Items.Add($"{0.022 * 1000}");
            C2ValueComboBox.Items.Add($"{0.033 * 1000}");
            C2ValueComboBox.Items.Add($"{0.047 * 1000}");
            C2ValueComboBox.Items.Add($"{0.01 * 10000}");
            C2ValueComboBox.Items.Add($"{0.022 * 10000}");
            C2ValueComboBox.Items.Add($"{0.033 * 10000}");
            C2ValueComboBox.Items.Add($"{0.047 * 10000}");
            C2ValueComboBox.Items.Add($"{0.01 * 100000}");
            C2ValueComboBox.Items.Add($"{0.022 * 100000}");
            C2ValueComboBox.Items.Add($"{0.033 * 100000}");
            C2ValueComboBox.Items.Add($"{0.047 * 100000}");
            C2ValueComboBox.Items.Add($"{68 * 1}");
            C2ValueComboBox.Items.Add($"{68 * 10}");
            C2ValueComboBox.Items.Add($"{68 * 100}");
            C2ValueComboBox.Items.Add($"{15 * 1}");
            C2ValueComboBox.Items.Add($"{15 * 10}");
            C2ValueComboBox.Items.Add($"{15 * 100}");
            C2ValueComboBox.Items.Add($"{180 * 1}");
            C2ValueComboBox.Items.Add($"{180 * 10}");

            L1ValueComboBox.Items.Add($"{1}");
            L1ValueComboBox.Items.Add($"{5 * 1}");
            L1ValueComboBox.Items.Add($"{10 * 1}");
            L1ValueComboBox.Items.Add($"{27 * 1}");
            L1ValueComboBox.Items.Add($"{68 * 1}");
            L1ValueComboBox.Items.Add($"{100 * 1}");

            C1ValueComboBox.Sorted = true;
            C2ValueComboBox.Sorted = true;
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
            CircuitMath();
            ResultsListBox.Items.Clear();
            ResultsListBox.Items.Add($"Z total: {ztotal}");
            ResultsListBox.Items.Add($"I Total: {igen}");
            ResultsListBox.Items.Add($"R1: {r1}");
            ResultsListBox.Items.Add($"C1: {c1}");
            ResultsListBox.Items.Add($"C2: {c2}");
            ResultsListBox.Items.Add($"L1: {l1}");
            ResultsListBox.Items.Add($"XC1: {xc1}");
            ResultsListBox.Items.Add($"XC2: {xc2}");
            ResultsListBox.Items.Add($"XL1: {xl1}");
            ResultsListBox.Items.Add($"ZL1: {zl1}");
            ResultsListBox.Items.Add($"ZEQ: {zeq}");
            ResultsListBox.Items.Add($"VRGen: {vrgen}");
            ResultsListBox.Items.Add($"VR1: {vr1}");
            ResultsListBox.Items.Add($"VC1: {vc1}");
            ResultsListBox.Items.Add($"VC2: {vc2}");
            ResultsListBox.Items.Add($"VL1: {vl1}");
            ResultsListBox.Items.Add($"IRGen: {irgen}");
            ResultsListBox.Items.Add($"IR1: {ir1}");
            ResultsListBox.Items.Add($"IC1: {ic1}");
            ResultsListBox.Items.Add($"IC2: {ic2}");
            ResultsListBox.Items.Add($"IL1: {il1}");
            ResultsListBox.Items.Add($"Real Power: {realP}");
            ResultsListBox.Items.Add($"Reactive Power: {reactP}");
            ResultsListBox.Items.Add($"Apparent Power: {apparentP}");
        }
        static string ToEngineering(double value, string unit = "")
        {
            if (value == 0)
                return "0 " + unit;

            double abs = Math.Abs(value);
            int exponent = (int)Math.Floor(Math.Log10(abs) / 3) * 3;

            double scaled = value / Math.Pow(10, exponent);
            string v = "";
            string micro = "\u00B5";
            switch (exponent)
            {
                case -12:
                    v = "p";
                    break;
                case -9:
                    v = "n";
                    break;
                case -6:
                    v = $"{micro}";
                    break;
                case -3:
                    v = "m";
                    break;
                case 0:
                    v = "";
                    break;
                case 3:
                    v = "k";
                    break;
                case 6:
                    v = "M";
                    break;
                case 9:
                    v = "G";
                    break;
                case 12:
                    v = "T";
                    break;
            }
            string prefix = v;

            return $"{scaled:0.###} {prefix}{unit}";
        }

        void CircuitMath() 
        {
            string o = ohm;
            int R1 = int.Parse(R1ValueComboBox.Text);
            int C1 = int.Parse(C1ValueComboBox.Text);
            int C2 = int.Parse(C2ValueComboBox.Text);
            int L1 = int.Parse(L1ValueComboBox.Text);
            double PreR1 = R1PrefixComboBox.SelectedIndex;
            double PreC1 = C1PrefixComboBox.SelectedIndex;
            double PreC2 = C2PrefixComboBox.SelectedIndex;
            double PreL1 = L1PrefixComboBox.SelectedIndex;
            if (PreR1 == 0)
            { 
                PreR1 = 1;
            }
            else if (PreR1 == 1)
            {
                PreR1 = 1000;
            }
            else if (PreR1 == 2)
            {
                PreR1 = 1000000;
            }
            if (PreC1 == 0)
            {
                PreC1 = 0.000000000001;
            }
            else if (PreC1 == 1)
            {
                PreC1 = 0.000001;
            }
            if (PreC2 == 0)
            {
                PreC2 = 0.000000000001;
            }
            else if (PreC2 == 1)
            {
                PreC2 = 0.000001;
            }
            if (PreL1 == 0)
            {
                PreL1 = 0.000001;
            }
            else if (PreL1 == 1)
            {
                PreL1 = 0.001;
            }
            int RW = int.Parse(RWindingTextBox.Text);
            int Freq = int.Parse(FrequencyTextBox.Text);
            int RGen = int.Parse(RGenComboBox.Text);
            int V = int.Parse(VGenTextBox.Text);
            double pi = Math.PI;
            double XC1 = 1/(2*pi*C1*PreC1*Freq);
            double XC2 = 1/(2 * pi*C2*PreC2*Freq);
            double XL1 = 2*pi*L1*PreL1*Freq;
            double ZL1 = (RW*RW) + (XL1 * XL1);
            double AngZl1 = Math.Atan2(XL1,RW);
            double ZeqH = XC2*(Math.Sqrt(ZL1));
            double ZeqL = (RW*RW) + (XL1 - XC2)*(XL1-XC2);
            ZeqL = Math.Sqrt(ZeqL);
            double Zeq = ZeqH / ZeqL;
            double AngZeqL = Math.Atan2((XL1-XC2),RW);
            double AngZeq = (-45 + AngZl1)-AngZeqL;
            double RZeq = Zeq*Math.Cos(AngZeq);
            double IZeq = Zeq*Math.Sin(AngZeq);
            double RzTot = RGen + (R1 * PreR1) + RZeq;
            double IzTot = XC1 + IZeq;
            double zTotA = (RzTot*RzTot) + (IzTot*IzTot);
            double Rigen = (V / zTotA)*Math.Cos(-Math.Atan2(IzTot, RzTot));
            double Iigen = (V / zTotA) * Math.Sin(-Math.Atan2(IzTot, RzTot));
            if (PolarRadioButton.Checked == true) 
            {
                ztotal = $"{ToEngineering(zTotA ,o)}{angle}{Math.Atan2(IzTot,RzTot)}";
                igen = $"{ToEngineering(V/zTotA, "A")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                r1 = $"{ToEngineering(R1*PreR1, o)}{angle}0";
                c1 = $"{ToEngineering(C1*PreC1, "F")}{angle}-45";
                c2 = $"{ToEngineering(C2*PreC2, "F")}{angle}-45";
                l1 = $"{ToEngineering(L1*PreL1, "H")}{angle}45";
                xc1 = $"{ToEngineering(XC1, o)}{angle}-45";
                xc2 = $"{ToEngineering(XC2, o)}{angle}-45";
                xl1 = $"{ToEngineering(XL1, o)}{angle}45";
                zl1 = $"{ToEngineering(Math.Sqrt(ZL1), o)}{angle}{Math.Atan2(XL1,RW)}";
                zeq = $"{ToEngineering(Zeq, o)}{angle}{-AngZeqL}";
                vrgen = $"{ToEngineering(RGen*V/zTotA, "V")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                vr1 = $"{ToEngineering(R1*PreR1*V/zTotA, "V")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                vc1 = $"{ToEngineering(XC1*V/zTotA, "V")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                vc2 = $"{ToEngineering(Zeq*V/zTotA, "V")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                vl1 = $"{ToEngineering(Zeq*V/zTotA, "V")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                irgen = $"{ToEngineering(V/zTotA, "A")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                ir1 = $"{ToEngineering(V/zTotA, "A")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                ic1 = $"{ToEngineering(V/zTotA, "A")}{angle}{-Math.Atan2(IzTot, RzTot)}";
                ic2 = $"{ToEngineering(zTotA, "A")}";
                il1 = $"{ToEngineering(zTotA, "A")}";
                realP = $"{ToEngineering(zTotA, "W")}";
                reactP = $"{ToEngineering(zTotA, "W")}";
                apparentP = $"{ToEngineering(zTotA, "W")}";
            }
            else if (RectangularRadioButton.Checked == true) 
            {
                ztotal = $"{RzTot}+j{IzTot}";
                igen = $"{Rigen}+j{Iigen}";
                r1 = $"{R1*PreR1}{ohm}+j0";
                c1 = $"0-j{C1*PreC1}F";
                c2 = $"0-j{C2*PreC2}F";
                l1 = $"0+j{L1*PreL1}H";
                xc1 = $"0-j{XC1}{ohm}";
                xc2 = $"0-j{XC2}{ohm}";
                xl1 = $"0+j{XL1}{ohm}";
                zl1 = $"{RW}+j{XL1}{ohm}";
                zeq = $"{RZeq}+{IZeq}";
                vrgen = $"{RGen*Rigen}+j{Iigen}";
                vr1 = $"{R1*PreR1*Rigen}+j{Iigen}";
                vc1 = $"{Rigen} +j {XC1*Iigen}";
                vc2 = $"{RZeq*Rigen} +j{IZeq*Iigen}";
                vl1 = $"{RZeq*Rigen} +j{IZeq*Iigen}";
                irgen = $"{Rigen} +j {Iigen}";
                ir1 = $"{Rigen}+j{Iigen}";
                ic1 = $"{Rigen}+j{Iigen}";
                ic2 = $"";
                il1 = $"";
                realP = $"";
                reactP = $"";
                apparentP = $"";
            } 
        }

        //Event Handlers-----------------------------------------------------------------------------------------------
        private void CircuitSolver_Load(object sender, EventArgs e)
        {
            DrawImage();
            VGenTextBox.Text = "0";
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
