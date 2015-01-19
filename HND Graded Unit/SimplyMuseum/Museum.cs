using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SimplyMuseum
{
    /// <summary>
    /// Start of class Museum this class holds all the methods
    /// </summary>
    public class Museum
    {
        /// <summary>
        /// Creates a List of artefacts and gives it the name artefacts.
        /// </summary>
        private List<Artefact> artefacts;

        /// <summary>
        /// get method for artefacts allows other classes to access it but noi set method means they cannot set a value.
        /// </summary>
        public List<Artefact> Artefacts
        {
            get
            {
                return artefacts;
            }
            set
            {
                artefacts = value;
            }
        }
        //End of get method

        /// <summary>
        /// Museum constructor creates a new list of artefacts.
        /// </summary>
        public Museum()
        {
            artefacts = new List<Artefact>();
        }
        //End of Museum constructor

        /// <summary>
        /// addPainting method takes parameters to allow information to be added into the list
        /// </summary>
        /// <param name="cn">catalogueNumber</param> 
        /// <param name="dob">dateObtained</param> 
        /// <param name="pp">pricePaid</param> 
        /// <param name="iv">insuranceValue</param> 
        /// <param name="rn">roomNumber</param> 
        /// <param name="dn">displayNumber</param> 
        /// <param name="e">era</param> 
        /// <param name="b">beqeathed</param> 
        /// <param name="d">donor</param> 
        /// <param name="a">artist</param> 
        /// <param name="dp">datePainted</param> 
        /// <param name="fh">frameHeight</param> 
        /// <param name="fw">frameWidth</param> 
        /// <param name="w">watercolour</param> 
        public void addPainting(int cn, DateTime dob, decimal pp, decimal iv, int rn, int dn, string e, string b, string d, string a, DateTime dp, int fh, int fw, string w) 
        {
                Painting p = new Painting(cn, dob, pp, iv, rn, dn, e, b, d, a, dp, fh, fw, w);
                artefacts.Add(p);
            
        }
        //End of addPainting

        /// <summary>
        /// addFurniture method takes parameters to allow information to be added into the list
        /// </summary>
        /// <param name="cn">catalogueNumber</param> 
        /// <param name="dob">dateObtained</param> 
        /// <param name="pp">pricePaid</param> 
        /// <param name="iv">insuranceValue</param> 
        /// <param name="rn">roomNumber</param> 
        /// <param name="dn">displayNumber</param>
        /// <param name="e">era</param> 
        /// <param name="b">beqeathed</param> 
        /// <param name="d">donor</param> 
        /// <param name="de">designer</param> 
        /// <param name="dc">dateCreated</param> 
        /// <param name="h">height</param> 
        /// <param name="w">width</param> 
        /// <param name="dep">depth</param> 
        /// <param name="m">material</param>
        /// <param name="t">type</param> 
        /// <param name="s">style</param> 
        public void addFurniture(int cn, DateTime dob, decimal pp, decimal iv, int rn, int dn, string e, string b, string d, string de, DateTime dc, int h, int w, int dep, string m, string t, string s)
        {
            Furniture f = new Furniture(cn, dob, pp, iv, rn, dn, e, b, d, de, dc, h, w, dep, m, t, s);
            artefacts.Add(f);
        }
        //End of addFurniture

        /// <summary>
        /// listArtefact method displays each individual artefact in the list
        /// </summary>
        public void listArtefact()
        {

            Console.WriteLine("Artefacts in the System" + "\n");
            foreach (Artefact a in artefacts)
            {
                
                 Console.WriteLine(a.ToString());
                    
            }
            
        }
        //End of listArtefact

        /// <summary>
        /// listPainting method displays each individual painting in the list
        /// </summary>
        public void listPainting()
        {

            Console.WriteLine("Painting's in Museum");
            foreach (Artefact a in artefacts)
            {
                if (a.GetType() == typeof(Painting))
                    Console.WriteLine(a);
            }
            
        }
        //End of listPainting

        /// <summary>
        /// listFurniture method displays each individual furniture in the list
        /// </summary>
        public void listFurniture()
        {

            Console.WriteLine("Furniture in Museum");
            foreach (Artefact a in artefacts)
            {
                if (a.GetType() == typeof(Furniture))
                    Console.WriteLine(a);
            }
           
        }
        //End of listFurniture

        /// <summary>
        /// findArtefactByCatNum methid searches through the list to fin an artefact using its catalogue number
        /// </summary>
        /// <param name="catNum"></param>
        /// <returns></returns>
        public Artefact findArtefactByCatNum(int catNum)
        {
            foreach (Artefact a in artefacts)
            {
                if (a.CatalogueNumber == catNum)
                    return a;
            }
            throw new Exception("No such catalogue number");

        }
        //End of findArtefactByCatNum

        /// <summary>
        /// printArtefact method sends the Artefact list to a document file 
        /// </summary>
        /// <param name="filename"></param>
        public void printArtefact(string filename)
        {

            using (StreamWriter sw = new StreamWriter(filename))
            {

                sw.WriteLine("Artefacts");
                sw.WriteLine("-------------------");
                sw.WriteLine(DateTime.Now);
                artefacts.Reverse();
                int count = 0;
                while (count < 15 && count < artefacts.Count)
                {
                    Artefact a = artefacts[count];
                    sw.WriteLine(a);
                    count++;
                }
                artefacts.Reverse();
            }
        }
        //End of printStock

        /// <summary>
        /// populate class adds values to the system
        /// </summary>
        public void populate()
        {
            addPainting(1024, DateTime.Parse("01/01/1789"), 500, 2000, 12, 15, "Renaisance", "No", "Glasgow Art", "Da Vinci", DateTime.Parse("01/01/1679"), 190, 150, "Paint");
            addPainting(1024, DateTime.Parse("01/05/1999"), 500, 2000, 12, 15, "Renaisance", "No", "Glasgow Art", "Da Vinci", DateTime.Parse("05/08/2001"), 190, 150, "Paint");
            addFurniture(1025, DateTime.Parse("25/11/1889"), 200, 1000, 12, 16, "Victorian", "Yes", "Edinburgh Art", "Chair Maker", DateTime.Parse("12/12/1999"), 120, 60, 30, "Pine", "Chair", "Victorian");
        }
        //end of populate class
    }
    //End of Musuem class
}
