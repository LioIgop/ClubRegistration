namespace ClubRegistration
{
    public partial class Form1 : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, LastName, Middlename, Gender, Program;
        private long StudentID;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }
        public int RegistrationID()
        {
            return count++;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.RegisterStudent(RegistrationID(),
                int.Parse(txtStudentID.Text),
                txtFirstName.Text, txtLastName.Text, txtMiddleName.Text,
                int.Parse(txtAge.Text),
                cbGender.SelectedItem.ToString(),
                cbProgram.SelectedItem.ToString());
            MessageBox.Show("Successfully registered! Pls Click Refresh!");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateMember fupd = new FormUpdateMember();
            fupd.Show();
        }
    }
}