using System;
using System.Data;
using System.Net.Sockets;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsContact
    {
        public enum enMode { AddNew, Update };
        public enMode Mode { get; private set; }
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public clsContact()
        {
            this.ContactID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            this.Mode = enMode.AddNew;
        }
        private clsContact(int CountactID, string FirstName, string LastName, string Email, 
            string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            this.ContactID = CountactID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            this.Mode = enMode.Update;

        }

        public static clsContact Find(int ID)
        {
            string FirstName="", LastName="", Email="", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;

            if(ContactDataAccess.GetContactByID(ref ID, ref FirstName, ref LastName, ref Email, 
                ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))
            {
                return new clsContact(ID, FirstName, LastName, Email, Phone, Address, DateOfBirth, 
                    CountryID, ImagePath);
            }

            return null;
        }
        
        private bool _AddNewContact()
        {
            this.ContactID = ContactDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email,
                this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);

            return this.ContactID != -1;
        }

        private bool _UpdateContact()
        {
            int ContactsUpdated = ContactDataAccess.UpdateContact(this.ContactID, this.FirstName, 
                this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, 
                this.ImagePath);

            return ContactsUpdated > 0;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (this._AddNewContact())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    if(this._UpdateContact()) return true;
                    break;
            }


            return false;
        }    

        public static bool DeletedContact(int ID)
        {
            return ContactDataAccess.DeleteContact(ID) > 0;
        }

        public static DataTable ListContacts()
        {
            return ContactDataAccess.ListContacts();
        }

        public static bool IsContactExist(int ID)
        {
            return ContactDataAccess.isContactExist(ID);
        }
    }
}
