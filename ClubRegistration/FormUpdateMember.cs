using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClubRegistration
{
    public partial class FormUpdateMember : Form
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlcommand;
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;

        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        ClubRegistrationQuery clubRegistrationQueryy = new ClubRegistrationQuery();
        public FormUpdateMember()
        {
            clubRegistrationQueryy = new ClubRegistrationQuery();
            connectionString = "Data Source=LIONEL-PC\\SQLEXPRESS;Initial Catalog=EventDrivenDB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            bindingSource = new BindingSource();
            dataTable = new DataTable();
            InitializeComponent();
        }
        public bool studentIDInfo()
        {
            sqlAdapter = new SqlDataAdapter("SELECT StudentID FROM ClubMembers", sqlConnection);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            cbStudentID.DataSource = dataTable;
            cbStudentID.DisplayMember = "ClubMembers";
            cbStudentID.ValueMember = "StudentID";
            return true;
        }
        public bool studInfoComplete()
        {
            sqlConnection.Open();
            sqlcommand = new SqlCommand("SELECT FirstName, LastName, MiddleName, Age, Gender, Program FROM ClubMembers WHERE StudentID = '" + cbStudentID + "'", sqlConnection);
            SqlDataReader rdr = sqlcommand.ExecuteReader();
            while (rdr.Read())
            {
                txtFirstName.Text = rdr.GetValue(0).ToString();
                txtLastName.Text = rdr.GetValue(1).ToString();
                txtMiddleName.Text = rdr.GetValue(2).ToString();
                txtAge.Text = rdr.GetValue(3).ToString();
                cbGender.Text = rdr.GetValue(4).ToString();
                cbProgram.Text = rdr.GetValue(5).ToString();
            }
            sqlConnection.Close();
            return true;
        }
        private void FormUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clubRegistrationQueryy.RegisterStudent(int.Parse(cbStudentID.Text), txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, int.Parse(txtAge.Text), cbGender.Text, cbProgram.Text);
        }

        private void cbStudentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            studInfoComplete();
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
