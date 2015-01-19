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
    /// Start of form EditArtefact
    /// </summary>
    public partial class frmEditArtefact : Form
    {       
        Museum museum;
   
        /// <summary>
        /// Initialising the object museum to keep the information entered in the system through all the screens
        /// </summary>
        /// <param name="m"></param>
        public frmEditArtefact(Museum m)
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

        /// <summary>
        /// Edit Furniture button method displays the edit furniture form and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditFurniture_Click(object sender, EventArgs e)
        {
            frmEditFurniture FormEditFrn = new frmEditFurniture(museum);
            this.Hide();
            FormEditFrn.ShowDialog();
        }
        //End of edit furniture method

        /// <summary>
        /// Edit Painting button method displays the edit painting form and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditPainting_Click(object sender, EventArgs e)
        {
            frmEditPainting FormEditPtn = new frmEditPainting(museum);
            this.Hide();
            FormEditPtn.ShowDialog();
        }
        //End of edit painting method 
    }
    //End of frmEditArtefact class
}
