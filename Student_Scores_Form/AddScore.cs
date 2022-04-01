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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScore.Text))
            {
                Class1.ListItem = txtScore.Text;

                this.Close();
            }
            else
                MessageBox.Show("Please enter a score");
        }
    }
}
