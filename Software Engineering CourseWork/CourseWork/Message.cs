using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace CourseWork
{
    /// <summary>
    /// Start of Message class
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// Variables for Message Class
        /// </summary>
        private string messageID;
        private string date;
        private string header;
        private string sender;
        private string body;
        private string[] blockedList = new string[] { "+447234567891", "joebloggs@live.napier.ac.uk", "@Jbloggs" };

        /// <summary>
        /// getter & setter for variable messageID
        /// </summary>
        public String MessageID
        {
            get
            {
                return messageID;
            }
            set
            {
                header = value;
            }
        }
        //End of MessageID getter & setter

        /// <summary>
        /// getter & setter for variable date
        /// </summary>
        public String Date
        {
            get
            {
                return date;
            }
            set
            {
                header = value;
            }
        }
        //End of Date getter & setter

        /// <summary>
        /// getter & setter for variable header
        /// </summary>
        public String Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        //End of Header getter & setter

        /// <summary>
        /// getter & setter for variable sender
        /// </summary>
        public String Sender
        {
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
        }
        //End of Sender getter & sender

        /// <summary>
        /// getter & setter for variable body
        /// </summary>
        public String Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }
        //End of Body getter & setter

        /// <summary>
        /// Start of method addFromFile takes a message from a file and adds it to the system
        /// </summary>
        /// <param name="file"></param>
        public void addFromFile(string file)
        {
            //Unfortunately I didnt get this part coded
        }
        //En dof method addFromFile

        /// <summary>
        /// getter for blockedList variable
        /// </summary>
        public String[] BlockedList
        {
            get
            {
                return blockedList;
            }
        }
        //End of BlockedList getter 

        /// <summary>
        /// Constructor called Message, takes the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="strbody">body</param>
        /// <param name="strheader">header</param>
        public Message(string strbody, string strheader)
        {
            header = messageID + date;
            body = sender + body;
            strheader = header;
            strbody = body;

        }
        //End of constructor Message
    }
    //End of Message class

    /// <summary>
    /// Start of SMS class that inherits from Message class
    /// </summary>
    public class SMS : Message
    {
        /// <summary>
        /// Variable abbreviationList for SMS class
        /// </summary>
        List<string> abbreviationList = new List<string>();

        /// <summary>
        /// method messageBoundaries sets the boundaries for body
        /// </summary>
        public Boolean messageBoundaries()
        {
            if (Header.Length < 18 || Header.Length > 18)
            {
                return false;
            }

            if (Body.Length > 140)
            {
                return false;
            }

            return true;
        }
        //End of method messageBoundaries

        /// <summary>
        /// Takes abbreviations in the text and expands them 
        /// </summary>
        public void abbreviation(string file)
        {
            string[] textSpeak = File.ReadAllLines(file);

            foreach (string s in textSpeak)
            {
                for (int i = 0; i < Body.Length; i++)
                {
                    string[] values = s.Split(',');
                    if (i + values[0].Length > Body.Length)
                    {
                        continue;
                    }
                    if (s.Substring(i, i + values[0].Length) == values[0])
                    {
                        Body = Body.Insert(i + values[0].Length, "< " + values[1] + " >");
                    }
                }
            }

        }
        //End of method abbreviation

        /// <summary>
        /// constructor called SMS takes the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="strbody">body</param>
        /// <param name="strheader">header</param>
        public SMS(string strbody, string strheader)
            : base(strbody, strheader)
        {

        }
        //End of constructer SMS
    }
    //End of SMS class

    /// <summary>
    /// Start of Email class that inherits from Message class
    /// </summary>
    public class Email : Message
    {
        /// <summary>
        /// Variable subject and quarantineList for Email class
        /// </summary>
        private string subject;
        List<string> quarantineList = new List<string>();

        /// <summary>
        /// method messageBoundaries sets the boundaries for body and subject
        /// </summary>
        public Boolean messageBoundaries()
        {
            if (Header.Length < 18 || Header.Length > 18)
            {
                return false;
            }
            if (Body.Length > 1028)
            {
                return false;
            }
            if (subject.Length > 20)
            {
                return false;
            }

            return true;
        }
        //End of method messageBoundaries

        /// <summary>
        /// Adds URLs to a list and replaces them in the message with <quarantined>
        /// </summary>
        public void quarantine()
        {
            var regex = new Regex(@"(?<=http)\\w+");
            var matches = regex.Matches(Body);

            foreach (Match m in matches)
            {
                quarantineList.Add(m.Value);

                Body.Replace(m.Value, "<quarantined>");
            }
        }
        //End of method quarantine

        /// <summary>
        /// constructor called Email takes the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="strbody">body</param>
        /// <param name="strheader">header</param>
        /// <param name="strsub">subject</param>
        public Email(string strbody, string strheader, string strsub)
            : base(strbody, strheader)
        {
            strsub = subject;
            strheader = strheader + subject;
        }
        //End of constructor Email
    }
    //End of Email class

    /// <summary>
    /// Start of Tweet class that inherits from Message class
    /// </summary>
    public class Tweet : Message
    {
        /// <summary>
        /// Variables  Creates Lists called mentionList and trendList for Tweet class
        /// </summary>
        string[] abbreviationList;
        List<string> mentionList = new List<string>();
        List<string> trendList = new List<string>();

        /// <summary>
        /// method messageBoundaries sets the boundaries for sender and body
        /// </summary>
        public Boolean messageBoundaries()
        {
            if (Header.Length < 18 || Header.Length > 18)
            {
                return false;
            }
            if (Sender.Length > 16)
            {
                return false;
            }
            if (Body.Length > 156)
            {
                return false;
            }
            return true;
        }
        //End of method messageBoundaries 

        /// <summary>
        /// Takes abbreviations in the text and expands them 
        /// </summary>
        public void abbreviation(string file)
        {
            string[] textSpeak = File.ReadAllLines(file);

            foreach (string s in textSpeak)
            {
                for (int i = 0; i < Body.Length; i++)
                {
                    string[] values = s.Split(',');
                    if (i + values[0].Length > Body.Length)
                    {
                        continue;
                    }
                    if (s.Substring(i, i + values[0].Length) == values[0])
                    {
                        Body = Body.Insert(i + values[0].Length, "<" + values[1] + ">");
                    }
                }
            }

        }
        //End of method abbreviation

        /// <summary>
        /// Adds hashtags in the tweet to a list and then primts them to a txt file
        /// </summary>
        public void trending()
        {

            var regex = new Regex(@"(?<=#)\\w+");
            var matches = regex.Matches(Body);

            foreach (Match m in matches)
                trendList.Add(m.Value);
        }
        //End of trending method

        /// <summary>
        /// Adds mentions in the tweet to a list and then prints them to a txt file
        /// </summary>
        public void mention()
        {
            var regex = new Regex(@"(?<=@)\\w+");
            var matches = regex.Matches(Body);

            foreach (Match m in matches)
                mentionList.Add(m.Value);


        }
        //End of method mention

        /// <summary>
        /// constructor called Tweet takes the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="strbody">body</param>
        /// <param name="strheader">header</param>
        public Tweet(string strbody, string strheader)
            : base(strbody, strheader)
        {

        }
        //End of constructor Email
    }
    //End of Tweet class
}
//End of namespace CourseWork
