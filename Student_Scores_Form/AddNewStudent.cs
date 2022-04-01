using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores_Form
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        int scoreCnt = 0;

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            String scores = txtScores.Text;
            txtScores.Text = txtScore.Text + " " + scores;

            if (!String.IsNullOrEmpty(txtScores.Text))
            {
                // calculate score total
                String totalScore = txtScore.Text;
                Class1.scoreTotal = Convert.ToInt32(totalScore) + Convert.ToInt32(totalScore);

                // calculate score count
                scoreCnt = scoreCnt + 1;
                Class1.scoreCount = scoreCnt;

                // calculate score average
                Class1.average = Class1.scoreTotal / Class1.scoreCount;
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            txtScores.Text = null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {   
            if (!string.IsNullOrEmpty(txtScores.Text))
            {
                Class1.ListItem = txtName.Text + ": " + txtScores.Text;
                Form1.fillStudentList();
                this.Close();
            }
            else
                MessageBox.Show("Please enter some scores");
        }
    }
}
