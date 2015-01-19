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
    /// Start of form AddPainting
    /// </summary>
    public partial class frmAddPainting : Form
    {

        Museum museum;

        /// <summary>
        /// Initialising the object museum to keep the information entered in the system through all the screens
        /// </summary>
        /// <param name="m"></param>
        public frmAddPainting(Museum m)
        {
            InitializeComponent();

            museum = m;
        }
        //End of initialisation

        /// <summary>
        /// setNewPainting method sets the values in the text boxes
        /// </summary>
        private void setNewPainting()
        {
            txt_CatNum.Text = "";
            txt_Artist.Text = "";
            txt_PricePaid.Text = "";
            txt_InsuranceVal.Text = "";
            txt_Donor.Text = "";
            txt_Beqeathed.Text = "";
            txt_DateObt.Text = "";
            txt_DatePaint.Text = "";
            txt_Era.Text = "";
            txt_RoomNum.Text = "";
            txt_DispalyNum.Text = "";
            txt_FrameH.Text = "";
            txt_FrameW.Text = "";
            txt_Watercolour.Text = "";
            
        }
        //End of setNewPainting method

        /// <summary>
        /// AddPainting Button method allows the user to add furniture to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addPainting_Click_1(object sender, EventArgs e)
        {


            int catno; //stores catalogue number
            DateTime dateobt; //stores the date obtained
            decimal pcpd; //stores the price paid
            decimal insval; //stores the insurance value
            string wat; //stores the watercolour
            int roomNum; //stores the room number
            int displayNum; //stores the displayNumber
            string er; //stores the era
            string bq; //stores the bequeathed
            string don; //stores the donor
            string art; //stores the artist
            DateTime dptn; //stores the date painted
            int fht; //stores the frame height
            int fwdth; //stores the frame width


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

            if (txt_Artist.Text == "")
            {
                MessageBox.Show("No Artist Entered");
                return;
            }

            if (txt_Watercolour.Text == "")
            {
                MessageBox.Show("No Watercolour Entered");
                return;
            }

            try
            {
                DateTime.Parse(txt_DatePaint.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Date Painted");
                return;
            }

            try
            {
                int.Parse(txt_FrameH.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Height Value");
                return;
            }

            try
            {
                int.Parse(txt_FrameW.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Width Value");
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

            try
            {
                int.Parse(txt_PricePaid.Text);
            }
            catch
            {
                MessageBox.Show("Invalid or No Price Paid");
                return;
            }


            //End of Validation

            //Sets the variables created to the forms text boxes
            catno = int.Parse(txt_CatNum.Text);
            dateobt = DateTime.Parse(txt_DateObt.Text);
            pcpd = decimal.Parse(txt_PricePaid.Text);
            insval = decimal.Parse(txt_InsuranceVal.Text);
            roomNum = int.Parse(txt_RoomNum.Text);
            displayNum = int.Parse(txt_DispalyNum.Text);
            er = txt_Era.Text;
            bq = txt_Beqeathed.Text;
            don = txt_Donor.Text;
            art = txt_Artist.Text;
            dptn = DateTime.Parse(txt_DatePaint.Text);
            fht = int.Parse(txt_FrameH.Text);
            fwdth = int.Parse(txt_FrameW.Text);
            wat = txt_Watercolour.Text;

            //passes the variables through the addPainting method
            museum.addPainting(catno, dateobt, pcpd, insval, roomNum, displayNum, er, bq, don, art, dptn, fht, fwdth, wat);

            //Calls setNewPainting
            setNewPainting();
            MessageBox.Show("Painting Added");
        }
        //End of addPainting button method


        /// <summary>
        /// Method for logout button takes the user back to the HomeScreen and hides the current form and displays a message to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //End of logOut button method

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
        /// Back button method hides the current form and takes the user back a screen this one would display the addartefact form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            frmAddArtefact FormArtefact = new frmAddArtefact(museum);
            this.Hide();
            FormArtefact.Show();
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
            FormUser.Show();
        }
        //End of userscreen button method
    }
    //End of frmAddPainting Class
}
