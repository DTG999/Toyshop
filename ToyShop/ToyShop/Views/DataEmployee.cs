using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyShop
{
    public partial class DataEmployee : Form
    {
        public Employee SelectedObject;
        bool gender;

        #region Constructs

        public DataEmployee(Employee employee, bool is_edit)
        {
            InitializeComponent();
            gender = Employee.MALE;
            SelectedObject = employee;
            FillComboBox();
            if (is_edit)
                FillData();
        }

        #endregion

        private void FillComboBox()
        {
            postComboBox.Items.Add(Employee.EmployeePost.Admin);
            postComboBox.Items.Add(Employee.EmployeePost.Deliveryman);
            postComboBox.Items.Add(Employee.EmployeePost.Director);
            postComboBox.Items.Add(Employee.EmployeePost.SecurityStorage);
            postComboBox.Items.Add(Employee.EmployeePost.Seller);
        }

        private void FillData()
        {
            nameTextBox.Text = SelectedObject.Name;
            surnameTextBox.Text = SelectedObject.LastName;
            salaryTextBox.Text = SelectedObject.Salary.ToString();
            gender = SelectedObject.Gender;
            if (gender == Employee.MALE)
                maleRadioButton.Checked = true;
            else
                femaleRadioButton.Checked = true;
            postComboBox.SelectedItem = SelectedObject.Post;
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectData())
                return;
            SelectedObject.Name = nameTextBox.Text;
            SelectedObject.LastName = surnameTextBox.Text;
            SelectedObject.Salary = Convert.ToDouble(salaryTextBox.Text);
            SelectedObject.Gender = gender;
            SelectedObject.Post = (Employee.EmployeePost)postComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool CheckCorrectData()
        {
            bool correct = true;

            try
            {
                if (nameTextBox.Text == "" || surnameTextBox.Text == "" || salaryTextBox.Text == "" || postComboBox.SelectedItem == null)
                    throw new Exception("Не все поля заполнены!");
                if (!nameTextBox.Text.All(char.IsLetter) || !surnameTextBox.Text.All(char.IsLetter))
                    throw new Exception("В имени или фамилии должны быть только буквы.");
                double salary = Convert.ToDouble(salaryTextBox.Text);
                if (salary <= 0)
                    throw new Exception("Зарпалата должна быть больше 0");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                correct = false;
            }

            return correct;
        }
    }
}
