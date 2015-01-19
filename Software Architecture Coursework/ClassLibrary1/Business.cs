using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.KWIKDSTableAdapters;


namespace BusinessLayer
{
    public class Business
    {
        /// <summary>
        /// Instances of patientTableAdapter and patient_recordAdapter allow access to the data layer and the database queries within the DataSet
        /// </summary>
        private patientTableAdapter Padapter = new patientTableAdapter();
        private patient_recordTableAdapter Radapter = new patient_recordTableAdapter();

        /// <summary>
        /// Search method that returns a patient by their NHS RegNo
        /// </summary>
        /// <param name="reg">patients NHS RegNo</param>
        /// <returns></returns>
        public KWIKDS.patientDataTable getPatient(string reg)
        {
            return Padapter.GetDataByReg(reg);
        }

        /// <summary>
        /// Search method that returns a patient by their NHS RegNo and the Date 
        /// </summary>
        /// <param name="date">Date and Time the condition and treatment were added</param>
        /// <param name="reg">patients NHS RegNo</param>
        /// <returns></returns>
        public KWIKDS.patient_recordDataTable getRecord(string date, string reg)
        {
            return Radapter.GetDataByRegDate(reg, date);
        }

        /// <summary>
        /// Creates a new patient record and stores it in the patien_record table
        /// </summary>
        /// <param name="reg">patients NHS RegNo</param>
        /// <param name="name">patients first name</param>
        /// <param name="surname">patietns surname</param>
        /// <param name="houseNo">patients house number</param>
        /// <param name="street">patients street</param>
        /// <param name="city">patients city</param>
        /// <param name="postcode">patients postcode</param>
        /// <param name="sex">patients gender</param>
        public void createPatient(string reg, string name, string surname, string houseNo, string street, string city, string postcode, string sex)
        {
            Padapter.InsertPatient(name, surname, houseNo, street, city, postcode, sex); //Calls the object Padapter and the method within it InserPatient. This method comes from the DataLayer and adds data from the variables to the database
        }

        /// <summary>
        /// Method for updating a patient in the patient table
        /// </summary>
        public void updatePatient()
        {
            //Still to be coded
        }

        /// <summary>
        /// Creates a new patient record and stores it in the patien_record table
        /// </summary>
        /// <param name="date">Date and Time the condition and treatment were added</param>
        /// <param name="condition">For storing patients condition</param>
        /// <param name="treatment">For storing patients treatment</param>
        public void createRecord(DateTime date, string condition, string treatment)
        {
            Radapter.InsertRecord(date, condition, treatment); //Calls the object Radapter and the method within it InsertRecord. This method comes from the DataLayer and adds data from the variables to the database
        }

    /// <summary>
    /// Method for updating a patients record in the patient_record table
    /// </summary>
        public void updateRecord()
        {
          //Still to be coded
        }
    }
}
