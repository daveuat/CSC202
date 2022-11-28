using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC202
{

    public partial class FormMain : Form
    {
        //class labels for each section of the base.

        public FormMain()
        {
            InitializeComponent();
            // classes used to change the text to that areas description and name in the info box


        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Shows the Mess Hall image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.messhall;
            //change text in "RoomNameBox1" and update player location
            var playerLOC = "Mess Hall";
            RoomNameBox1.Text = playerLOC;
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = "Ah the Mess Hall! You can finally sit down, relax, and have a drink with your new crewmates." +
                " Frontier's mess hall is on the small side but the crew isn't huge. You feel you can easily wind down here." +
                " Now let's see whats on the menu.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void navButtonME_Click(object sender, EventArgs e)
        {
            //Shows the Engineering image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.engineering;
            //change text in "RoomNameBox1" and update player location
            var playerLOC = "Engineering";
            RoomNameBox1.Text = playerLOC;
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = "Frontier's engineering room is dark and dank." +
                " You aren't sure where to start. Best to find the Chief Engineer and see if you have any tasks.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void navButtonMJ_Click(object sender, EventArgs e)
        {
            //Shows the Main Junction image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.mainjunction;
            //change text in "RoomNameBox1" and update player location
            var playerLOC = "Main Junction";
            RoomNameBox1.Text = playerLOC;
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = "As you enter the junction you see multiple paths in front of you." +
                " Boxes, space suit helmets, and miscellaneous gear is lined along the walls." +
                " You feel this room can get busy and crowded fast. You should move along.";
        }

        private void navButtonMB_Click(object sender, EventArgs e)
        {
            //Shows the Main Junction image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.mainbarracks;
            //change text in "RoomNameBox1" and update player location
            var playerLOC = "Barracks";
            RoomNameBox1.Text = playerLOC;
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = "You've made it to your assigned barracks." +
                " Looks like the team has already put your name on one on your left." +
                " With a sign of relief you drop your bag on your rack and start to unpack.";
        }


        private void pathlabel3_Click(object sender, EventArgs e)
        {

        }

        private void navButtonCD_Click(object sender, EventArgs e)
        {
            //Shows the Command Deck image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.commanddeck;
            //change text in "RoomNameBox1" and update player location
            var playerLOC = "Command Deck";
            RoomNameBox1.Text = playerLOC;
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = "Welcome to the Command Deck!" +
                " Here you see many controls, terminals, and manned stations." +
                " You can hardly contain your excitement." +
                " It's wise to sit at your station and to start working." +
                " Try to not draw too much attention to yourself 'new guy'.";
        }
    }
}
