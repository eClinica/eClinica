using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eClinicaCare.Models
{
    public class clsPatient
    {
        #region private variables
        private int ID;
        private string RegDate;
        private string MRN;
        private string FirstName;
        private string MiddleName;
        private string LastName;
        private string FatherName;
        private string MotherName;
        private string Occupation;
        private string Gender;
        private long Title;
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
        private long EmrTitle;
        private string EmrgName;
        private string EmrgAddress;
        private long EmrgCountry;
        private long EmrgState;
        private long EmrgCity;
        private long EmrgArea;
        private string EmrgPAN;
        private string EmrgMobile;
        private string EmrgPhone;
        private string EmrgEmailID;
        private bool IsAdressSameForEmerg;
        private string PreMedicalTest;
        private string PatientImage;
        private string Disease;
        private string LastAffectedDate;
        private bool IsPhysicallyChallenged;
        private bool Dead;
        private string EntryDate;
        private string EntryTime;
        private string LoginName;
        private bool Disabled;
        public int Choice;
       
        #endregion
        #region Properties
        public int ID_Prop
        {
            get
            { return ID; }
            set
            { ID = value; }
        }

        public string RegDate_Prop
        {
            get
            { return RegDate; }
            set
            { RegDate = value; }
        }

        public string MRN_Prop
        {
            get
            { return MRN; }
            set
            { MRN = value; }
        }

        public string FirstName_Prop
        {
            get
            { return FirstName; }
            set
            { FirstName = value; }
        }

        public string MiddleName_Prop
        {
            get
            { return MiddleName; }
            set
            { MiddleName = value; }
        }

        public string LastName_Prop
        {
            get
            { return LastName; }
            set
            { LastName = value; }
        }

        public string FatherName_Prop
        {
            get
            { return FatherName; }
            set
            { FatherName = value; }
        }

        public string MotherName_Prop
        {
            get
            { return MotherName; }
            set
            { MotherName = value; }
        }

        public string Occupation_Prop
        {
            get
            { return Occupation; }
            set
            { Occupation = value; }
        }

        public string Gender_Prop
        {
            get
            { return Gender; }
            set
            { Gender = value; }
        }

        public long Title_Prop
        {
            get
            { return Title; }
            set
            { Title = value; }
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

        public long EmrTitle_Prop
        {
            get
            { return EmrTitle; }
            set
            { EmrTitle = value; }
        }

        public string EmrgName_Prop
        {
            get
            { return EmrgName; }
            set
            { EmrgName = value; }
        }

        public string EmrgAddress_Prop
        {
            get
            { return EmrgAddress; }
            set
            { EmrgAddress = value; }
        }

        public long EmrgCountry_Prop
        {
            get
            { return EmrgCountry; }
            set
            { EmrgCountry = value; }
        }

        public long EmrgState_Prop
        {
            get
            { return EmrgState; }
            set
            { EmrgState = value; }
        }

        public long EmrgCity_Prop
        {
            get
            { return EmrgCity; }
            set
            { EmrgCity = value; }
        }

        public long EmrgArea_Prop
        {
            get
            { return EmrgArea; }
            set
            { EmrgArea = value; }
        }

        public string EmrgPAN_Prop
        {
            get
            { return EmrgPAN; }
            set
            { EmrgPAN = value; }
        }

        public string EmrgMobile_Prop
        {
            get
            { return EmrgMobile; }
            set
            { EmrgMobile = value; }
        }

        public string EmrgPhone_Prop
        {
            get
            { return EmrgPhone; }
            set
            { EmrgPhone = value; }
        }

        public string EmrgEmailID_Prop
        {
            get
            { return EmrgEmailID; }
            set
            { EmrgEmailID = value; }
        }

        public bool IsAdressSameForEmerg_Prop
        {
            get
            { return IsAdressSameForEmerg; }
            set
            { IsAdressSameForEmerg = value; }
        }

        public string PreMedicalTest_Prop
        {
            get
            { return PreMedicalTest; }
            set
            { PreMedicalTest = value; }
        }

        public string PatientImage_Prop
        {
            get
            { return PatientImage; }
            set
            { PatientImage = value; }
        }

        public string Disease_Prop
        {
            get
            { return Disease; }
            set
            { Disease = value; }
        }

        public string LastAffectedDate_Prop
        {
            get
            { return LastAffectedDate; }
            set
            { LastAffectedDate = value; }
        }

        public bool IsPhysicallyChallenged_Prop
        {
            get
            { return IsPhysicallyChallenged; }
            set
            { IsPhysicallyChallenged = value; }
        }

        public bool Dead_Prop
        {
            get
            { return Dead; }
            set
            { Dead = value; }
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