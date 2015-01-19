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
    /// Start of form HomeScreen
    /// </summary>
    public partial class HomeScreen : Form
    {
        Museum museum;

        /// <summary>
        /// Start of initialising the object museum so it can be passed through the other forms
        /// </summary>
        public HomeScreen()
        {
            InitializeComponent();

            museum = new Museum();
        }
       //End of Initialisation

       
        /// <summary>
        /// Method for Clicking on HomeScreen opens up UserScreen and hides the current form and displays a message for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clicked(object sender, EventArgs e)
        {
            UserScreen formUser = new UserScreen(museum);
            this.Hide();
            MessageBox.Show("Welcome User");
            formUser.ShowDialog();
            
        }
        //End of Clicked HomeScreen method
    }
    //End of HomeScreen class
}
