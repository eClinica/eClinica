using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eClinicaCare.Models
{
    public class clsDoctor
    {
        #region private variables
        private int DoctorCode;
        private long Title;
        private string DoctorName;
        private string Qualification;
        private string Specilization;
        private string Gender;
        private string DOB;
        private long bloodGroup;
        private long Nationality;
        private long Religion;
        private string Address;
        private long Country;
        private long State;
        private long City;
        private long Area;
        private string PAN;
        private string Mobile;
        private string Phone;
        private string EmailID;
        private string EntryDate;
        private string EntryTime;
        private string LoginName;
        private bool Disabled;
        public int Choice;
        public bool IsRefferal;
       
        #endregion
        #region Properties
        public int DoctorCode_Prop
        {
            get
            { return DoctorCode; }
            set
            { DoctorCode = value; }
        }

        public long Title_Prop
        {
            get
            { return Title; }
            set
            { Title = value; }
        }

        public string DoctorName_Prop
        {
            get
            { return DoctorName; }
            set
            { DoctorName = value; }
        }

        public string Qualification_Prop
        {
            get
            { return Qualification; }
            set
            { Qualification = value; }
        }

        public string Specilization_Prop
        {
            get
            { return Specilization; }
            set
            { Specilization = value; }
        }

        public string Gender_Prop
        {
            get
            { return Gender; }
            set
            { Gender = value; }
        }

        public string DOB_Prop
        {
            get
            { return DOB; }
            set
            { DOB = value; }
        }

        public long bloodGroup_Prop
        {
            get
            { return bloodGroup; }
            set
            { bloodGroup = value; }
        }

        public long Nationality_Prop
        {
            get
            { return Nationality; }
            set
            { Nationality = value; }
        }

        public long Religion_Prop
        {
            get
            { return Religion; }
            set
            { Religion = value; }
        }

        public string Address_Prop
        {
            get
            { return Address; }
            set
            { Address = value; }
        }

        public long Country_Prop
        {
            get
            { return Country; }
            set
            { Country = value; }
        }

        public long State_Prop
        {
            get
            { return State; }
            set
            { State = value; }
        }

        public long City_Prop
        {
            get
            { return City; }
            set
            { City = value; }
        }

        public long Area_Prop
        {
            get
            { return Area; }
            set
            { Area = value; }
        }

        public string PAN_Prop
        {
            get
            { return PAN; }
            set
            { PAN = value; }
        }

        public string Mobile_Prop
        {
            get
            { return Mobile; }
            set
            { Mobile = value; }
        }

        public string Phone_Prop
        {
            get
            { return Phone; }
            set
            { Phone = value; }
        }

        public string EmailID_Prop
        {
            get
            { return EmailID; }
            set
            { EmailID = value; }
        }

        public string EntryDate_Prop
        {
            get
            { return EntryDate; }
            set
            { EntryDate = value; }
        }

        public string EntryTime_Prop
        {
            get
            { return EntryTime; }
            set
            { EntryTime = value; }
        }

        public string LoginName_Prop
        {
            get
            { return LoginName; }
            set
            { LoginName = value; }
        }

        public bool Disabled_Prop
        {
            get
            { return Disabled; }
            set
            { Disabled = value; }
        }


        #endregion


    }


}