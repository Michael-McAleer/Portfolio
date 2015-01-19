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
    /// Start of form EditFurniture
    /// </summary>
    public partial class frmEditFurniture : Form
    {
        Museum museum;

        /// <summary>
        /// Initialising the object museum to keep the information entered in the system through all the screens
        /// </summary>
        /// <param name="m"></param>
        public frmEditFurniture(Museum m)
        {
            InitializeComponent();
            museum = m;
        }
        //End of initialisation

        /// <summary>
        /// SetNewFurniture method sets the values in the text boxes for frmAddFurniture
        /// </summary>
        private void setNewFurniture()
        {
            txt_CatNum.Text = "";
            txt_Designer.Text = "";
            txt_PricePaid.Text = "";
            txt_InsuranceVal.Text = "";
            txt_Donor.Text = "";
            txt_Beqeathed.Text = "";
            txt_DateObt.Text = "";
            txt_DateCrtd.Text = "";
            txt_Era.Text = "";
            txt_RoomNum.Text = "";
            txt_DispalyNum.Text = "";
            txt_Type.Text = "";
            txt_Style.Text = "";
            txt_Material.Text = "";
            txt_Height.Text = "";
            txt_Width.Text = "";
            txt_Depth.Text = "";
        }
        //End of setNewFurniture

        /// <summary>
        /// AddFurniture Button method allows the user to add furniture to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addFurniture_Click(object sender, EventArgs e)
        {


            int catno; //stores catalogue number
            DateTime dateobt; //stores the date obtained
            decimal pcpd; //stores the price paid
            decimal insval; //stores the insurance value
            string typ; //stores the type
            string styl; //stores the style
            string mat; //stores the material
            int roomNum; //stores the room number
            int displayNum; //stores the displayNumber
            string er; //stores the era
            string bq; //stores the bequeathed
            string don; //stores the donor
            string des; //stores the designer
            DateTime dctrd; //stores the creation date
            int ht; //stores the height
            int wdth; //stores the width
            int dpth; //stores the depth

            //Validation methods for data entry
            try
            {
                int.Parse(txt_CatNum.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Catalogue Number");
                return;
            }

            try
            {
                DateTime.Parse(txt_DateObt.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Date Obtained");
                return;
            }

            try
            {
                int.Parse(txt_RoomNum.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Room Number");
                return;
            }

            try
            {
                int.Parse(txt_DispalyNum.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Display Number");
                return;
            }

            if (txt_Era.Text == "")
            {
                MessageBox.Show("No era entered");
                return;
            }

            if (txt_Beqeathed.Text == "")
            {
                MessageBox.Show("Nothing Entered for Bequeathed");
                return;
            }

            if (txt_Donor.Text == "")
            {
                MessageBox.Show("No Donor Entered");
                return;
            }

            if (txt_Designer.Text == "")
            {
                MessageBox.Show("No Designer Entered");
                return;
            }
            try
            {
                DateTime.Parse(txt_DateCrtd.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Date Created");
                return;
            }

            try
            {
                int.Parse(txt_Height.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Height Value");
                return;
            }

            try
            {
                int.Parse(txt_Width.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Width Value");
                return;
            }

            try
            {
                int.Parse(txt_Depth.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Depth Value");
                return;
            }

            try
            {
                int.Parse(txt_PricePaid.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Price Paid");
                return;
            }

            try
            {
                int.Parse(txt_InsuranceVal.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Insurance Value");
                return;
            }

            if (txt_Material.Text == "")
            {
                MessageBox.Show("No Material Entered");
                return;
            }

            if (txt_Type.Text == "")
            {
                MessageBox.Show("No Type Entered");
                return;
            }

            if (txt_Style.Text == "")
            {
                MessageBox.Show("No Style Entered");
                return;
            }
            //End of Validation

            //Sets the variables created to the forms text boxes
            catno = int.Parse(txt_CatNum.Text);
            dateobt = DateTime.Parse(txt_DateObt.Text);
            pcpd = decimal.Parse(txt_PricePaid.Text);
            insval = decimal.Parse(txt_InsuranceVal.Text);
            typ = txt_Type.Text;
            styl = txt_Style.Text;
            mat = txt_Material.Text;
            roomNum = int.Parse(txt_RoomNum.Text);
            displayNum = int.Parse(txt_DispalyNum.Text);
            er = txt_Era.Text;
            bq = txt_Beqeathed.Text;
            don = txt_Donor.Text;
            des = txt_Designer.Text;
            dctrd = DateTime.Parse(txt_DateCrtd.Text);
            ht = int.Parse(txt_Height.Text);
            wdth = int.Parse(txt_Width.Text);
            dpth = int.Parse(txt_Depth.Text);

            //passes the variables through the add furniture method
            museum.addFurniture(catno, dateobt, pcpd, insval, roomNum, displayNum, er, bq, don, des, dctrd, ht, wdth, dpth, mat, typ, styl);

            //Calls setNewFurniture
            setNewFurniture();
        }
        //End of addFurniture button method

        /// <summary>
        ///  Method for the picture box takes the user back to the HomeScreen and hides the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbtn_Home_Click(object sender, EventArgs e)
        {
            HomeScreen formHome = new HomeScreen();
            this.Hide();
            formHome.Show();
        }
        //End of Picture box method

        /// <summary>
        /// Method for logout button takes the user back to the HomeScreen and hides the current form and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            HomeScreen formHome = new HomeScreen();
            this.Hide();
            formHome.Show();
            MessageBox.Show("Successfully Logged Out");
        }
        //End of logOut button method

        /// <summary>
        /// Back button method hides the current form and takes the user back a screen this one would display the addartefact form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            frmAddArtefact FormArtefact = new frmAddArtefact(museum);
            this.Hide();
            FormArtefact.ShowDialog();

        }
        //End of back button method

        /// <summary>
        /// Method for user screen button hides the current form and displays the User Screen form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UserScreen_Click(object sender, EventArgs e)
        {
            UserScreen FormUser = new UserScreen(museum);
            this.Hide();
            FormUser.ShowDialog();

        }
        //End of userscreen button method
        
    }
    //End of frmEditFurniture class
}
