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
    public partial class UpdateStudentScores : Form
    {
        public UpdateStudentScores()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateScore updateScore = new UpdateScore();
            updateScore.ShowDialog();
            lstScores.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int itemIndex = lstScores.SelectedIndex;
            if (itemIndex > 0)
            {
                lstScores.Items.RemoveAt(itemIndex);
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            String scoresList = lstScores.Items[0].ToString();
            Class1.ListItem = txtName.Text + ": " + scoresList;

            this.Close();
        }

        public void fillScoreList()
        {
            if (!string.IsNullOrEmpty(Class1.ListItem))
                lstScores.Items.Add(Class1.ListItem);
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            fillScoreList();
        }
    }
}
