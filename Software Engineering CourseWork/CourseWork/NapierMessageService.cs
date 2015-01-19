using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    /// <summary>
    /// Start of NapierMessageService class
    /// </summary>
    public class NapierMessageService
    {
        /// <summary>
        /// Creates a List of Messages and gives it the name messages.
        /// </summary>
        private List<Message> messages;

        /// <summary>
        /// getter & setter messsages
        /// </summary>
        public List<Message> Messsages
        {
            get
            {
                return messages;
            }
            set
            {
                messages = value;
            }
        }
        //End of getter & setter for Messages

        /// <summary>
        /// Constructor for NapierMessageService, creates a new Message list
        /// </summary>
        public NapierMessageService()
        {
            messages = new List<Message>();
        }
        //End of NapierMessageService constructor

        /// <summary>
        /// Start of addSMS method adds a SMS to the system
        /// </summary>
        /// <param name="bod">body</param>
        /// <param name="head">header</param>
        public void addSMS(string bod, string head)
        {
            SMS s = new SMS(bod, head);
            messages.Add(s);
        }
        //End of addSMS method

        /// <summary>
        /// Start of addEmail method adds a Email to the system
        /// </summary>
        /// <param name="bod">body</param>
        /// <param name="head">header</param>
        /// <param name="sub">subject</param>
        public void addEmail(string bod, string head, string sub)
        {
            Email e = new Email(bod, head, sub);
            messages.Add(e);
        }
        //End of addEmail method

        /// <summary>
        /// Start of addTweet method, adds a Tweet to the system
        /// </summary>
        /// <param name="bod">body</param>
        /// <param name="head">header</param>
        public void addTweet(string bod, string head)
        {
            Tweet t = new Tweet(bod, head);
            messages.Add(t);
        }
        //End of addTweet

        /// <summary>
        /// Start of checkIfBlocked method, checks if the sender is blocekd and displays an Exception if they are
        /// </summary>
        /// <returns></returns>
        public void checkIfBlocked()
        {
            System.Windows.MessageBox.Show("Checking if Sender is Blocked");

            foreach (Message m in messages)
            {
                if (m.BlockedList.Contains(m.Sender))
                throw new Exception("Sender is Blocked");
            }

          
           System.Windows.MessageBox.Show("Sender Not Blocked");
        }
        //End of checkIfBlocked method

        /// <summary>
        /// Start of checkMessageBoundaries method, checks the boundaries of the different types of messages and displays an Exception if out of bounds
        /// </summary>
        /// <returns></returns>
        public void checkMessageBoundaries()
        {
            System.Windows.MessageBox.Show("Checking Message Boundaries");

            foreach (SMS s in messages)
            {
                if (s.GetType() == typeof(SMS))
                {
                    s.messageBoundaries();
                    throw new Exception("Message Header or Body out of Bounds");
                }
            }

            foreach (Email e in messages)
            {
                if (e.GetType() == typeof(Email))
                {
                    e.messageBoundaries();
                    throw new Exception("Message Header or Body out of Bounds");
                }
            }

            foreach (Tweet t in messages)
            {
                if (t.GetType() == typeof(Tweet))
                {
                    t.messageBoundaries();
                    throw new Exception("Message Header or Body out of Bounds");
                }
                
            }

            System.Windows.MessageBox.Show("Message Boundaries Accepted");

        }
        //End of checkMessageBoundaries

        /// <summary>
        /// Start of display method, displays the messges
        /// </summary>
        public void display()
        {

            Console.WriteLine("Message" + "\n");
            foreach (Message m in messages)
            {

                Console.WriteLine(m.ToString());

            }
        }
        //End of display method
    }
    //End of NapierMessageService class
}
//End of CourseWork namespace
