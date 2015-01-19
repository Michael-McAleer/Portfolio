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
    /// Start of form AddArtefact 
    /// </summary>
    public partial class frmAddArtefact : Form
    {

        private Museum museum;

        /// <summary>
        ///  Initialising the object museum to keep the information entered in the system through all the screens
        /// </summary>
        /// <param name="m"></param>
        public frmAddArtefact(Museum m)
        {
            InitializeComponent();

            museum = m;
        }
        //End of initialisation

        /// <summary>
        /// Method for the picture box takes the user back to the HomeScreen and hides the current form
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
        /// Method for logout button takes the user back to the HomeScreen and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End of logOut button method

        /// <summary>
        /// add furniture button method calls the form add furniture and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addFurniture_Click(object sender, EventArgs e)
        {
            frmAddFurniture formFurniture = new frmAddFurniture(museum);
            this.Hide();
            formFurniture.ShowDialog();
            
        }
        //End of addFurniture button method

        /// <summary>
        /// addPainting button method calls the form add Painting and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addPainting_Click(object sender, EventArgs e)
        {
            frmAddPainting formPainting = new frmAddPainting(museum);
            this.Hide();
            formPainting.ShowDialog();
            
        }
        //End of addPainting button method

        /// <summary>
        /// back button method takes the user to the previous form and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            UserScreen FormUser = new UserScreen(museum);
            this.Hide();
            FormUser.ShowDialog();
            
        }
        //End of back button method
    }
    //End of frmAddArtefact class
}
