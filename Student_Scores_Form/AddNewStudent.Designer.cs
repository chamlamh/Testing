namespace Student_Scores_Form
{
    partial class AddNewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(34, 140);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(117, 48);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(25, 224);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(132, 48);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(526, 55);
            this.txtName.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(188, 137);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(166, 55);
            this.txtScore.TabIndex = 4;
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(188, 224);
            this.txtScores.Name = "txtScores";
            this.txtScores.ReadOnly = true;
            this.txtScores.Size = new System.Drawing.Size(526, 55);
            this.txtScores.TabIndex = 5;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(489, 131);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(225, 67);
            this.btnAddScore.TabIndex = 6;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(489, 322);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(225, 76);
            this.btnClearScores.TabIndex = 7;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(222, 462);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(225, 71);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(489, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 71);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Name = "AddNewStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblScore;
        private Label lblScores;
        private TextBox txtName;
        private TextBox txtScore;
        private TextBox txtScores;
        private Button btnAddScore;
        private Button btnClearScores;
        private Button btnOk;
        private Button btnCancel;
    }
}