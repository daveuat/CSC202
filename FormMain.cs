using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        Classes Observation = new Classes();
        Classes Supply = new Classes();
        Classes Airlock = new Classes();

        int threat = 1; //threat level counter for the meter before alien attack

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

            Observation.AreaNames = "Observation";
            Observation.AreaDescriptions = "As you enter the Observation room you just stop and stare in amazement." +
                " Is this really where you live now? Yes, yes it is.";

            Supply.AreaNames = "Supply";
            Supply.AreaDescriptions = "It's the supply room. Now you know where to go when you lose your pen.";

            Airlock.AreaNames = "Air Lock";
            Airlock.AreaDescriptions = "Nothing but 2 doors stopping the vaccuum of space from killing you.";
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
        private void navButtonME_Click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 1; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.engineering; //Shows the Engineering image on the PictureBox
                    //change name of location in roomname box
                    RoomNameBox1.Text = Engineering.AreaNames; //Week 4 updates with classes and objects for name and descriptions.
                                                               //change description of the room in "RoomDescriptionBox1
                    RoomDesccriptionBox1.Text = Engineering.AreaDescriptions; //Week 4 updates with classes and objects for name and descriptions.
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 1) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonOB.Enabled = false;
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
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 2; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.mainjunction; //Shows the Main junction image on the PictureBox
                    RoomNameBox1.Text = MainJunction.AreaNames;                    //change name of location in roomname box
                    RoomDesccriptionBox1.Text = MainJunction.AreaDescriptions;     //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 2) // If statement to enable all locations.
            {
                navButtonCD.Enabled = true;
                navButtonMB.Enabled = true;
                navButtonME.Enabled = true;
                navButtonMJ.Enabled = true;
                navButtonMH.Enabled = true;
                navButtonOB.Enabled = true;
                navButtonAL.Enabled = true;
                navButtonSP.Enabled = true;
            }
        }

        private void navButtonMB_Click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 3; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.mainbarracks; //Shows the Main barracks image on the PictureBox
                    RoomNameBox1.Text = Barracks.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = Barracks.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 3) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonCD.Enabled = false;
                navButtonME.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonOB.Enabled = false;
                navButtonAL.Enabled = false;
                navButtonSP.Enabled = false;
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
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 4; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.commanddeck;   //Shows the Command Deck image on the PictureBox
                    RoomNameBox1.Text = CommandDeck.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = CommandDeck.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 4) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonOB.Enabled = false;
                navButtonAL.Enabled = false;
                navButtonSP.Enabled = false;
                navButtonOB.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonMJ.Enabled = true;
                navButtonME.Enabled = true;
            }
        }

        private void navButtonMH_click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 5; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.messhall; //Shows the Mess Hall image on the PictureBox
                    RoomNameBox1.Text = MessHall.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = MessHall.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 5) // If statement to disable locations that are unavailable from the current location.
            {
                navButtonMB.Enabled = false;
                navButtonCD.Enabled = false;
                navButtonME.Enabled = false;
                navButtonOB.Enabled = false;
                navButtonAL.Enabled = false;
            }
            else // else statement to enable the locations that are available.
            {
                navButtonMJ.Enabled = true;
                navButtonMH.Enabled = true;
                navButtonSP.Enabled = true;
            }
        }

        private void navButtonOB_Click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 6; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.oberservation; //Shows the Oberservation image on the PictureBox
                    RoomNameBox1.Text = Observation.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = Observation.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 6) // If statement to enable all locations.
            {
                navButtonCD.Enabled = false;
                navButtonMB.Enabled = false;
                navButtonME.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonAL.Enabled = false;
                navButtonSP.Enabled = false;

            }
            else
            {
                navButtonMJ.Enabled = true;
                navButtonOB.Enabled = true;
            }
        }

        private void navButtonSP_Click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 7; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.supply;  //Shows the Oberservation image on the PictureBox
                    RoomNameBox1.Text = Supply.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = Supply.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 7) // If statement to enable all locations.
            {
                navButtonCD.Enabled = false;
                navButtonMB.Enabled = false;
                navButtonME.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonOB.Enabled = false;
                navButtonAL.Enabled = false;
            }
            else
            {
                navButtonMJ.Enabled = true;
                navButtonSP.Enabled = true;
            }
        }

        private void navButtonAL_Click(object sender, EventArgs e)
        {
            threat++; //threat meter counter with every location change
            threatCount.Text = Convert.ToString(threat); //updates number in threat box
            int playerCORD = 8; //Integer for locations
            if (threat >= 30) //if statement for threat/alien attack image and message
            {
                pictureBox1.Image = CSC202.Properties.Resources.alien;
                MessageBox.Show("An Alien has Attacked! You should head somewhere else and fast!");
                threat = 0; //resets threat
            }
            else
            {
                try
                {
                    pictureBox1.Image = CSC202.Properties.Resources.airlock;    //Shows the Airlock image on the PictureBox
                    RoomNameBox1.Text = Airlock.AreaNames;                //change name of location in roomname box
                    RoomDesccriptionBox1.Text = Airlock.AreaDescriptions; //change description of the room in "RoomDescriptionBox1
                }
                catch (Exception ex) //Final Week Exception Handling addition.
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (playerCORD == 8) // If statement to enable all locations.
            {
                navButtonCD.Enabled = false;
                navButtonMB.Enabled = false;
                navButtonME.Enabled = false;
                navButtonMH.Enabled = false;
                navButtonOB.Enabled = false;
                navButtonSP.Enabled = false;
            }
            else
            {
                navButtonMJ.Enabled = true;
                navButtonAL.Enabled = true;
            }
        }
    }
}