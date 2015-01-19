using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initialises NapierMessageService, Tweet, Email and SMS 
        /// </summary>
        NapierMessageService service;
        SMS sms;
        Email email;
        Tweet tweet;

        /// <summary>
        /// Start of MainWindow method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent(); //Initialises Component

            service = new NapierMessageService(); //Creates new NapierMessageService

            txt_display.Visibility = Visibility.Hidden; //Hides the rich text box txt_display
            btn_previous.Visibility = Visibility.Hidden; //Hides the button btn_previous
            btn_next.Visibility = Visibility.Hidden; //Hides the button btn_next
        }
        //End of MainWindow method

        /// <summary>
        /// Start of setMessage method which clears all the text boxes
        /// </summary>
        private void setMessage()
        {

            txt_messageID.Text = "";
            txt_sender.Text = "";
            txt_date.Text = "";
            txt_subject.Text = "";
            txt_body.Text = "";
            txt_display.Document.Blocks.Clear();
        }
        //End of setMessage method

        /// <summary>
        /// Start of btn_process_Click method dictates what happens when the button btn_procees is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_process_Click(object sender, RoutedEventArgs e)
        {
            string messID = txt_messageID.Text; //Stores messageID
            string dt = txt_date.Text; //Stores date
            string hd = "Message ID " + messID + "\t" + "Date " + dt; //stores header
            string sndr = txt_sender.Text; //Stores sender
            string sbjct = txt_subject.Text; //Stores subject
            string bdy = txt_body.Text; //Stores body
            bdy = "Sender " + sndr + "\t" + bdy; //Adds Sender to body

            sms = new SMS(bdy, hd);
            email = new Email(bdy, hd, sbjct);
            tweet = new Tweet(bdy, hd);

            //if statement that says if the Message ID starts with E then it adds the subject to message body
            if (messID.StartsWith("E"))
            {
                bdy = sbjct + bdy;
            }
            //End of if statement

            //if statements that deal with seperating the messge into the correct message type, checks if the sender is blocked and checks the message boundaries
            if (messID.StartsWith("S"))
            {
                System.Windows.MessageBox.Show("Processing SMS");
                service.checkIfBlocked();
                service.checkMessageBoundaries();
                sms.abbreviation("textwords.csv");
                service.addSMS(bdy, hd);
            }
            else if (messID.StartsWith("E"))
            {
                System.Windows.MessageBox.Show("Processing Email");
                service.checkIfBlocked();
                service.checkMessageBoundaries();
                email.quarantine();
                service.addEmail(bdy, hd, sbjct);
            }
            else if (messID.StartsWith("T"))
            {
                System.Windows.MessageBox.Show("Processing Tweet");
                service.checkIfBlocked();
                service.checkMessageBoundaries();
                tweet.abbreviation("textwords.csv");
                tweet.trending();
                tweet.mention();
                service.addTweet(bdy, hd);
            }
            else 
            {
                throw new Exception("Message Type unacceptable must be S, E or T"); //Throws exception if message type is not acceptable
            }

            //Calls setMessage method
            setMessage();


            txt_messageID.Visibility = Visibility.Hidden; //Hides text box txt_messageID;
            txt_date.Visibility = Visibility.Hidden; //Hides text box txt_date;
            txt_sender.Visibility = Visibility.Hidden; //Hides text box txt_sender;
            txt_subject.Visibility = Visibility.Hidden; //Hides text box txt_subject;
            txt_body.Visibility = Visibility.Hidden; //Hides text box txt_body;
            lbl_messageID.Visibility = Visibility.Hidden; //Hides label lbl_messageID;
            lbl_date.Visibility = Visibility.Hidden; //Hides label lbl_date;
            lbl_sender.Visibility = Visibility.Hidden; //Hides label lbl_sender;
            lbl_subject.Visibility = Visibility.Hidden; //Hides label lbl_subject;
            lbl_body.Visibility = Visibility.Hidden; //Hides label lbl_body;
            btn_process.Visibility = Visibility.Hidden; //Hides button btn_process;
            txt_display.Visibility = Visibility.Visible; //Shows text box txt_display;
            btn_previous.Visibility = Visibility.Visible; //Shows text box btn_previous;
            btn_next.Visibility = Visibility.Visible; //Shows text box btn_next;
            
            txt_display.AppendText(hd + "\n" + bdy); //Puts the Message header and body into the rich text box txt_display
        }
        //End of btn_process_Click method
    }
    //End of class MainWindow
 }
//End of namespace CourseWork