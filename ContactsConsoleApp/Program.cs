using System;
using System.Data;
using System.Deployment.Internal;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using ContactsBusinessLayer;

namespace ContactsPersentationLayer
{
    internal class Program
    {
        static void testFindContact(int ID)
        {
            clsContact contact = clsContact.Find(ID);

            if (contact != null) {
                Console.WriteLine("ContactID = " + contact.ContactID);
                Console.WriteLine("FirstName = " + contact.FirstName);
                Console.WriteLine("LastName = " + contact.LastName);
                Console.WriteLine("Email = " + contact.Email);
                Console.WriteLine("Phone = " + contact.Phone);
                Console.WriteLine("Address = " + contact.Address);
                Console.WriteLine("Date Of Birth = " + contact.DateOfBirth);
                Console.WriteLine("CountryID = " + contact.CountryID);
                Console.WriteLine("Image Path = " + contact.ImagePath);
            } 
            else
            {
                Console.WriteLine("Contact[" + ID + "] is not Found !!");
            }
        }
        static void testAddNewContact(clsContact contact)
        {
            if(contact.Mode == clsContact.enMode.AddNew && contact.Save())
            {
                Console.WriteLine("Contact was added successfully !");
            } else
            {
                Console.WriteLine("Contact already exists !");
            }
        }
        static void testUpdateContact(clsContact contact)
        {
            if(contact.Save())
            {
                Console.WriteLine("Contact Updated Successfully !");
            }
        }
        static void testDeleteContact(int ID)
        {
            if(clsContact.DeletedContact(ID))
            {
                Console.WriteLine("Contact is Deleted successfully !");
            } else
            {
                Console.WriteLine("Delete Faild !");
            }
        }

        static void testListContacts()
        {
            DataTable dt = clsContact.ListContacts();

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}, {row["FirstName"]} {row["LastName"]}");
            }
        }

        static void testIsContactExist(int ID)
        {
            if (clsContact.IsContactExist(ID))
            {
                Console.WriteLine("Contact is exist :)");
            }
            else Console.WriteLine("Contact is not exist :(");
        }
        static void Main(string[] args)
        {

           

        }
    }
}
