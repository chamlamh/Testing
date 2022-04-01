namespace Student_Scores_Form
{
    public partial class frmStudentScores : Form
    {
        public frmStudentScores()
        {
            InitializeComponent();
        }
        
        public frmStudentScores(string name, string scores)
        {
            InitializeComponent();

            if (scores == null)
            {
                lstStudents.DataSource = scores;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        public void fillStudentList()
        {
            if (!string.IsNullOrEmpty(Class1.ListItem))
                lstStudents.Items.Add(Class1.ListItem);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Class1.ListItem = String.Empty;
            AddNewStudent form2 = new AddNewStudent();
            form2.ShowDialog();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemIndex = lstStudents.SelectedIndex;
            lstStudents.Items.RemoveAt(itemIndex);
        }

        private void frmStudentScores_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Class1.ListItem))
                lstStudents.Items.Add(Class1.ListItem);
            
            fillStudentList();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentScores updateStudentScores = new UpdateStudentScores();
            updateStudentScores.ShowDialog();
            if (lstStudents.Items.Count != 0)
            {
                lstStudents.Items.RemoveAt(lstStudents.Items.Count - 1);
            }
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            fillStudentList();

            txtScoreTotal.Text = Class1.scoreTotal.ToString();
            txtScoreCount.Text = Class1.scoreCount.ToString();
            txtAverage.Text = Class1.average.ToString();
        }
    }
}