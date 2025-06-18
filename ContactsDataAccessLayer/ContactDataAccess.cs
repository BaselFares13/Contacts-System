using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web;
using Microsoft.SqlServer.Server;


namespace ContactsDataAccessLayer
{
    public static class ContactDataAccess
    {
        public static bool GetContactByID(ref int ID, ref string FirstName, ref string LastName, 
            ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth, 
            ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ContactID", ID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isFound = true;
                            ID = (int)reader["ContactID"];
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"];
                            Email = (string)reader["Email"];
                            Phone = (string)reader["Phone"];
                            Address = (string)reader["Address"];
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];
                            ImagePath = reader.IsDBNull(8)? "" : (string)reader["ImagePath"];
                        }
                    }

                }

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                

            return isFound;
        }

        public static int AddNewContact(string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth,int CountryID,
            string ImagePath)
        {
            int contactID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = @"INSERT INTO Contacts
                                     VALUES (@FirstName, @LastName, @Email, @Phone, @Address,
                                             @DateOfBirth, @CountryID, @ImagePath);
                                     SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    if(ImagePath == "") command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    connection.Open();
                    object ID = command.ExecuteScalar();
                    if (ID != null) {
                        int.TryParse(ID.ToString(), out int returnedID);
                        contactID = returnedID;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return contactID;
        }

        public static int UpdateContact(int ContactID, string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, int CountryID,
            string ImagePath)
        {
            int ContactsUpdated = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = @"UPDATE Contacts 
                                     SET FirstName = @FirstName, LastName = @LastName,
                                         Email = @Email, Phone = @Phone, Address = @Address,
                                         DateOfBirth = @DateOfBirth, CountryID = @CountryID,
                                         ImagePath = @ImagePath
                                      WHERE ContactID = @ContactID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ContactID", ContactID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    if(ImagePath == "") command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    connection.Open();
                    ContactsUpdated = command.ExecuteNonQuery();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ContactsUpdated;
        }

        public static int DeleteContact(int ID)
        {
            int AffectedRows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ContactID", ID);

                    connection.Open();
                    AffectedRows = command.ExecuteNonQuery();
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return AffectedRows;
        }
        public static DataTable ListContacts()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = "SELECT * FROM Contacts";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

        public static bool isContactExist(int ID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ContactDataAccessSettings.connectionString))
                {
                    string query = "SELECT 1 FROM Contacts WHERE ContactID = @ContactID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ContactID", ID);

                    connection.Open();
                    if(command.ExecuteScalar() != null)
                    {
                        isFound = true;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return isFound;
        }
    }
}
