using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class fStudentManagement : Form
    {
        ArrayList studentList;

        
        public fStudentManagement()
        {
            InitializeComponent();
        }

        private void fStudentManagement_Load(object sender, EventArgs e)
        {
            studentList = new ArrayList();

            studentList.Add(new Student { ID = 1, FirstName = "Yang", LastName = "Yu", HomeAddress = "12345 N Street", MonthOfAdmission = MonthOfAdmission.Apr, Grade = Grade.A, image = Image.FromFile(@"C:\Users\Yang Yu\Desktop\Yang Yu1.jpg") });

            dataGrid.DataSource = studentList;

            comboMonth.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
            comboGrade.DataSource = Enum.GetValues(typeof(Grade));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text != string.Empty && txtFName.Text != string.Empty && txtAddress.Text != string.Empty && txtLName.Text != string.Empty)
            {
                Student newStudent = new Student();

                newStudent.ID = Int32.Parse(txtID.Text);
                newStudent.FirstName = txtFName.Text;
                newStudent.LastName = txtLName.Text;
                newStudent.HomeAddress = txtAddress.Text;
                newStudent.MonthOfAdmission = (MonthOfAdmission)comboMonth.SelectedIndex;
                newStudent.Grade = (Grade)comboGrade.SelectedIndex;
                newStudent.image = (Image)image.Image;      
                

                studentList.Add(newStudent);
            }

            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentList.RemoveAt(dataGrid.CurrentRow.Index);
            RefreshData();
        }

        private void RefreshData()
        {
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            

            dataGrid.DataSource = null;
            dataGrid.DataSource = studentList;
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void upload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
