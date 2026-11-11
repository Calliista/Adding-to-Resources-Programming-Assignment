using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_to_Resources_Programming_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "RAM is extremely fast memory that stores all of the programs and data that you are currently using. RAM loses the data it stores when the computer is turned off.";
            imgComponents.Image = Properties.Resources.RAM__2_;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "A power supply is a device that takes electricity from a source(like a wall outlet or battery) and converts it into the exact voltage, current, and form that an electronic device needs to work safely.";
            imgComponents.Image = Properties.Resources.powersupply;
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "A CPU (Central Processing Unit) is the primary component and brain of a computer or electronic device that runs operating systems, processes data, and executes software instructions.";
            imgComponents.Image = Properties.Resources.CPU1;
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "An SSD (Solid-State Drive) is a computer storage device that saves your operating system, apps, and files on memory chips";
            imgComponents.Image = Properties.Resources.SSD1;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "An input device is any hardware component that allows a user to enter data, send commands, or provide control signals to a computer or digital system. It translates physical actions, movements, or voice into digital signals that the computer can process. (eg; keyboard, mouse)";
            imgComponents.Image = Properties.Resources.input1;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            lblDesc.Text = "An output device is any piece of computer hardware that receives processed data from a computer and converts it into a form that humans can perceive—such as text, images, sound, or physical documents. (eg; monitor, printer, headphones)";
            imgComponents.Image = Properties.Resources.output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
