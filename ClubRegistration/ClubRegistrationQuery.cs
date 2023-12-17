using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace ClubRegistration
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlcommand;
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;

        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _LastName, _MiddleName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = "Data Source=LIONEL-PC\\SQLEXPRESS;Initial Catalog=EventDrivenDB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            bindingSource = new BindingSource();
            dataTable = new DataTable();
        }
        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, LastName, MiddleName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnection);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }
        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlcommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnection);
            sqlcommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlcommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlcommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlcommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlcommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlcommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlcommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlcommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlcommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        internal void updateStudent(int v1, string text1, string text2, string text3, int v2, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        internal void RegisterStudent(int v1, string text1, string text2, string text3, int v2, string text4, string text5)
        {
            throw new NotImplementedException();
        }
    }
}
