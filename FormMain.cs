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
        Classes MainJunction = new Classes();
        Classes CommandDeck = new Classes();
        Classes Barracks = new Classes();
        Classes Engineering = new Classes();
        Classes MessHall = new Classes();

        public FormMain()
        {
            InitializeComponent();
            // classes used to change the text to that areas description and name in the info box
            MainJunction.AreaNames = "Main Junction";
            MainJunction.AreaDescriptions = "As you enter the junction you see multiple paths in front of you." +
                " Boxes, space suit helmets, and miscellaneous gear is lined along the walls." +
                " You feel this room can get busy and crowded fast. You should move along." +
                " ALL TRAVEL LOCATIONS ARE AVAILABLE FROM THE MAIN JUNCTION.";

            CommandDeck.AreaNames = "Command Deck";
            CommandDeck.AreaDescriptions = "Welcome to the Command Deck!" +
                " Here you see many controls, terminals, and manned stations." +
                " You can hardly contain your excitement." +
                " It's wise to sit at your station and to start working." +
                " Try to not draw too much attention to yourself 'new guy'." +
                " You may also continue back to the Main Junction or stay on ladder all the way down to Engineering.";

            Barracks.AreaNames = "Barracks";
            Barracks.AreaDescriptions = "You've made it to your assigned barracks." +
                " Looks like the team has already put your name on one on your left." +
                " With a sign of relief you drop your bag on your rack and start to unpack." +
                " After unpacking you notice you can travel back to the Main Junction and then decide your next destination.";

            Engineering.AreaNames = "Engineering";
            Engineering.AreaDescriptions = "Frontier's engineering room is dark and dank." +
                " You aren't sure where to start. Best to find the Chief Engineer and see if you have any tasks." +
                " When navigating you may continue back to the Main Junction or stay on ladder all the way up to the Command Deck.";

            MessHall.AreaNames = "Mess Hall";
            MessHall.AreaDescriptions = "Ah the Mess Hall! You can finally sit down, relax, and have a drink with your new crewmates." +
                " Frontier's mess hall is on the small side but the crew isn't huge. You feel you can easily wind down here." +
                " Now let's see whats on the menu." +
                " After eating you notice you can go back to the Main Junction to travel to your next destination.";


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


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void navButtonME_Click(object sender, EventArgs e)
        {
            //Shows the Engineering image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.engineering;
            int playerCORD = 5; //Integer for locations
            //change name of location in roomname box
            RoomNameBox1.Text = Engineering.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = Engineering.AreaDescriptions; //Week 4 updates with classes and objects for name and descriptions.
            if (playerCORD == 5) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonMH.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonCD.Enabled = true;
                navButtonMJ.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void navButtonMJ_Click(object sender, EventArgs e)
        {
            //Shows the Main Junction image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.mainjunction;
            int playerCORD = 1; //Integer for locations
                                //change name of location in roomname box
            RoomNameBox1.Text = MainJunction.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = MainJunction.AreaDescriptions;
            if (playerCORD == 1) // If statement to enable all locations.
            {
                navButtonCD.Enabled = true;
                navButtonMB.Enabled = true;
                navButtonME.Enabled = true;
                navButtonMJ.Enabled = true;
                navButtonMH.Enabled = true;
            }
        }

        private void navButtonMB_Click(object sender, EventArgs e)
        {
            //Shows the Main barracks image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.mainbarracks;
            int playerCORD = 3; //Integer for locations
            //change name of location in roomname box
            RoomNameBox1.Text = Barracks.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = Barracks.AreaDescriptions; //Week 4 updates with classes and objects for name and descriptions.
            if (playerCORD == 3) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonCD.Enabled = false;
                navButtonME.Enabled = false;
                navButtonMH.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonMJ.Enabled = true;
                navButtonMB.Enabled = true;   
            }
        }


        private void pathlabel3_Click(object sender, EventArgs e)
        {

        }

        private void navButtonCD_Click(object sender, EventArgs e)
        {
            //Shows the Command Deck image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.commanddeck;
            int playerCORD = 4; //Integer for locations
            //change name of location in roomname box
            RoomNameBox1.Text = CommandDeck.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = CommandDeck.AreaDescriptions; //Week 4 updates with classes and objects for name and descriptions.
            if (playerCORD == 4) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonMH.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonMJ.Enabled = true;
                navButtonME.Enabled = true;
            }
        }

        private void navButtonMH_click(object sender, EventArgs e)
        {
            //Shows the Mess Hall image on the PictureBox
            pictureBox1.Image = CSC202.Properties.Resources.messhall;
            int playerCORD = 2; //Integer for locations
            //change name of location in roomname box
            RoomNameBox1.Text = MessHall.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
            //change description of the room in "RoomDescriptionBox1
            RoomDesccriptionBox1.Text = MessHall.AreaDescriptions; //Week 4 updates with classes and objects for name and descriptions.
            if (playerCORD == 2) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonCD.Enabled = false;
                navButtonME.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonMJ.Enabled = true;
                navButtonMH.Enabled = true;
            }
        }
    }
}
