using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimplyMuseum
{
    /// <summary>
    /// Start of form UserScreen
    /// </summary>
    public partial class UserScreen : Form
    {
        Museum museum;

        /// <summary>
        /// Initialising the object museum to keep the information entered in the system through all the screens
        /// </summary>
        /// <param name="m"></param>
        public UserScreen(Museum m)
        {
            InitializeComponent();

            museum = m;
        }
        //End of Initalisation

        /// <summary>
        ///  Method for the picture box takes the user back to the HomeScreen and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbtn_Home_Click(object sender, EventArgs e)
        {
            HomeScreen formHome = new HomeScreen();
            this.Hide();
            formHome.ShowDialog();
        }
        //End of picture box method

        /// <summary>
        /// Method for listArtefact clears the console then calls the populate and listArtefact methods from the Museum class and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listArtefact_Click(object sender, EventArgs e)
        {
            Console.Clear();
            museum.listArtefact();
            MessageBox.Show("Use Console Window to View List");
        }
        //End of listArtefact button method

        /// <summary>
        /// Method for listPainting clears the console then calls the populate and listPainting methods from the Museum class and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listPainting_Click(object sender, EventArgs e)
        {
            Console.Clear();
            museum.listPainting();
            MessageBox.Show("Use Console Window to View List");
        }
        //End of listPainting button method

        /// <summary>
        /// Method for listFurniture clears the console then calls the populate and listFurniture methods from the Museum class and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listFurniture_Click(object sender, EventArgs e)
        {
            Console.Clear();
            museum.listFurniture();
            MessageBox.Show("Use Console Window to View List");
        }
        //End of listFurniture button method

        /// <summary>
        /// Method for Print button calls the populate and print artefact methods from the Museum class and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Print_Click(object sender, EventArgs e)
        {
            museum.printArtefact("PrintedArtefacts.txt");
            MessageBox.Show("Printed to txt file");
        }
        //End of print button method

        /// <summary>
        /// Method for logout button takes the user back to the HomeScreen and closes the current form and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Successfully Logged Out");
        }
        //End of logOut button method

        /// <summary>
        /// addArtefact method opens up addArtefact form and hides UserScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addArtefact_Click(object sender, EventArgs e)
        {
            frmAddArtefact formArtefact = new frmAddArtefact(museum);
            this.Hide();
            formArtefact.ShowDialog();
            
        }
        //End of addArtefact button method   

        /// <summary>
        /// EditArtefact button method opens up EditArtefact form and hides UserScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditArtefact_Click(object sender, EventArgs e)
        {
            frmEditArtefact formEditA = new frmEditArtefact(museum);
            this.Hide();
            formEditA.ShowDialog();
        }
        //End of editartefact button method
    }
    //End of UserScreen class
}
