using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimplyMuseum
{
    class Program
    {        
        /// <summary>
        /// Allocates a new console for current process.
        /// uses  System.Runtime.InteropServices;
        /// 
        /// declaring extern (al) means available anywhere
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        /// <summary>
        /// Frees the console.
        /// uses  System.Runtime.InteropServices;
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       //Start of static void Main
        static void Main()
        {
           // Allocates a new conosle
            AllocConsole();

            //call test harnesses for white box testing

            //testHarness1();
            //testHarness2();
            //testHarness3();

           // Sets the systemn for using the forms created and then calls the HomeScreen form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
            FreeConsole();
        }
        //End of static void Main
        
        /// <summary>
        /// Test harness for adding an artefact to the system
        /// </summary>
        public static void testHarness1()
        {
            Artefact a1, a2, a3;
            a1 = new Artefact(1024,DateTime.Parse("05/01/1929"),500,2000,12,15,"Renaisance","No","Glasgow Art");
            a2 = new Artefact(1025,DateTime.Parse("06/06/1752"),200,1000,12,16,"Victorian","Yes","Edinburgh Art");
            a3 = new Artefact(1026,DateTime.Parse("01/05/1882"),1500,1500,12,12,"Romanticism","No","Me");


            Console.WriteLine("Three artefacts Created");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.ReadLine();
           
        }
        //End of testharness1

        /// <summary>
        /// Test harness for addPainting and addFurniture. adds a painting and furniture to the system then tests listArtefacts
        /// listPainting and listFurniture
        /// </summary>
        public static void testHarness2()
        {
            Museum themuseum = new Museum();
            themuseum.addPainting(1024, DateTime.Parse("15/07/1965"), 500, 2000, 12, 15, "Renaisance", "No", "Glasgow Art","Da Vinci", DateTime.Parse("01/01/2011"), 190, 150, "Paint");
            themuseum.addFurniture(1025, DateTime.Parse("28/12/1977"), 200, 1000, 12, 16, "Victorian", "Yes", "Edinburgh Art", "Chair Maker", DateTime.Parse("05/05/2013"), 120, 60, 30, "Pine", "Chair", "Victorian");

            themuseum.listArtefact();
        }
        //End of testharness2

        /// <summary>
        /// Tests populate method and calls the list methods and test print method
        /// </summary>
        public static void testHarness3()
        {
            Museum themuseum = new Museum();
            themuseum.populate();

           
            themuseum.listPainting();
            themuseum.listFurniture();
            themuseum.printArtefact("testharnessoutput.txt");
        }
        //End of testharness3
    }
    //End of program class
}
