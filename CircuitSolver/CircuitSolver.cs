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
    }
}
