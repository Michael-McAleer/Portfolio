using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplyMuseum
{
    /// <summary>
    /// Start of Abstract Artefact Class
    /// </summary>

    public class Artefact
    {
        /// <summary>
        /// Variables for Artefact class. Automatically made private
        /// </summary>
        int catalogueNumber;
        DateTime dateObtained;
        decimal pricePaid;
        decimal insuranceValue;
        string Era;
        int roomNumber;
        int displayNumber;
        string bequeathed;
        string donor;

        /// <summary>
        /// Get set method to allow other classes to acess catalogue number 
        /// </summary>
        public int CatalogueNumber
        {
            get
            {
                return catalogueNumber;
            }

            set
            {
                catalogueNumber = value;
            }
        }
        //End of get, set method

        /// <summary>
        /// Constructor called Artefact, takes the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="intcatnum">catalogueNumber</param> 
        /// <param name="intdateobt">dateObtained</param>
        /// <param name="intprice">pricePaid</param>
        /// <param name="intvalue">insuranceValue</param>
        /// <param name="introom">roomNumber</param>
        /// <param name="intdisplay">displayNumber</param>
        /// <param name="strera">Era</param>
        /// <param name="strbequeathed">bequeathed</param>
        /// <param name="strdonor">donor</param>
        public Artefact(int intcatnum, DateTime intdateobt, decimal intprice, decimal intvalue, int introom, int intdisplay, string strera, string strbequeathed, string strdonor)
        {
            catalogueNumber = intcatnum;
            dateObtained = intdateobt;
            pricePaid = intprice;
            insuranceValue = intvalue;
            roomNumber = introom;
            displayNumber = intdisplay;
            Era = strera;
            bequeathed = strbequeathed;
            donor = strdonor;

        }
        //End of Artefact Constructor

        /// <summary>
        /// Tostring method sets the way the information is displayed in the console window.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = "Catalogue Number " + catalogueNumber + "\n" + "Date Obtained " + dateObtained.ToShortDateString() + "\t" + "Era " + Era;
            strout = strout + "\n" + "Price Paid £" + pricePaid + "\t" + "Insurance Value £" + insuranceValue;
            strout = strout + "\n" + "Room Number " + roomNumber + "\t" + "Display Number " + displayNumber;
            strout = strout + "\n" + "Bequeathed " + bequeathed + "\n" + "Donor " + donor + "\n";
            return strout;
        }
        //End of Tostring method

    }
    // End of Artefact Class


    //Start of Inheriting Painting Class
    class Painting : Artefact
    {
        /// <summary>
        /// Variables for Painting class. Automatically made private
        /// </summary>
        string artist;
        DateTime datePainted;
        int frameHeight;
        int frameWidth;
        string watercolour;

        /// <summary>
        /// Painting Constructor to take the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="intcatnum">catalogueNumber</param>
        /// <param name="intdateobt">dateObtained</param>
        /// <param name="intprice">pricePaid</param>
        /// <param name="intvalue">insuranceValue</param>
        /// <param name="introom">roomNumber</param>
        /// <param name="intdisplay">displayNumber</param>
        /// <param name="strera">Era</param>
        /// <param name="strbequeathed">bequeathed</param>
        /// <param name="strdonor">donor</param>
        /// <param name="strartist">artist</param>
        /// <param name="intdatepainted">datePainted</param>
        /// <param name="intframeheight">frameHeight</param>
        /// <param name="intframewidth">frameWidth</param>
        /// <param name="strwatercolour">watercolour</param>
        public Painting(int intcatnum, DateTime intdateobt, decimal intprice, decimal intvalue, int introom, int intdisplay, string strera, string strbequeathed, string strdonor,
            string strartist, DateTime intdatepainted, int intframeheight, int intframewidth, string strwatercolour)
            : base(intcatnum, intdateobt, intprice, intvalue, introom, intdisplay, strera, strbequeathed, strdonor)
        {
            artist = strartist;
            datePainted = intdatepainted;
            frameHeight = intframeheight;
            frameWidth = intframewidth;
            watercolour = strwatercolour;
        }
        //End of Painting Constructor


        /// <summary>
        /// Tostring method sets the way the information is displayed in the console window.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = "Artist " + artist + "\n" + "Date Painted " + datePainted.ToShortDateString();
            strout = strout + "\n" + "Frame Height " + frameHeight + "cm" + "\t" + "Frame Width " + frameWidth + "cm";
            strout = strout + "\n" + "Watercolour " + watercolour + "\n";
            strout = strout + "\n" + base.ToString();
            return strout;
        }
        //End of Tostring method
    }
  
    // End of Painting Class
    
    

    //Start of Inheriting Furniture Class
    class Furniture : Artefact
    {
        /// <summary>
        /// Variables for Furniture class. Automatically made private
        /// </summary>
        string designer;
        DateTime dateCreated;
        int height;
        int width;
        int depth;
        string material;
        string type;
        string style;

        /// <summary>
        /// Furniture Constructor to take the parameters created and assigns them to the variables.
        /// </summary>
        /// <param name="intcatnum">catalogueNumber</param>
        /// <param name="intdateobt">dateObtained</param>
        /// <param name="intprice">pricePaid</param>
        /// <param name="intvalue">insuranceValue</param>
        /// <param name="introom">roomNumber</param>
        /// <param name="intdisplay">displayNumber</param>
        /// <param name="strera">Era</param>
        /// <param name="strbequeathed">bequeathed</param>
        /// <param name="strdonor">donor</param>
        /// <param name="strdesigner">designer</param>
        /// <param name="intdatecreated">dateCreated</param>
        /// <param name="intheight">height</param>
        /// <param name="intwidth">width</param>
        /// <param name="intdepth">depth</param>
        /// <param name="strmaterial">material</param>
        /// <param name="strtype">type</param>
        /// <param name="strstyle">style</param>
        public Furniture(int intcatnum, DateTime intdateobt, decimal intprice, decimal intvalue, int introom, int intdisplay, string strera, string strbequeathed, string strdonor,
            string strdesigner, DateTime intdatecreated, int intheight, int intwidth, int intdepth, string strmaterial, string strtype, string strstyle)
            : base(intcatnum, intdateobt, intprice, intvalue, introom, intdisplay, strera, strbequeathed, strdonor)
        {
            designer = strdesigner;
            dateCreated = intdatecreated;
            height = intheight;
            width = intwidth;
            depth = intdepth;
            material = strmaterial;
            type = strtype;
            style = strstyle;
        }
        //End of Furniture Constructor

        /// <summary>
        /// Tostring method sets the way the information is displayed in the console window
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = "Designer " + designer + "\n" + "Date Created " + dateCreated.ToShortDateString() + "\n" + "Height " + height + "cm" + "\t" + "Width " + width + "cm";
            strout = strout + "\t" + "Depth " + depth + "cm" + "\n" + "Material " + material + "\t" + "Type " + type + "\t" + "Style " + style + "\n";
            strout = strout + "\n" + base.ToString();
            return strout;
        }
        //End of Tostring method
    }
    // End of Furniture Class
}
