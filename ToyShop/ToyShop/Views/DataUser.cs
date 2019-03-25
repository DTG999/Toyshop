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
    public partial class DataUser : Form
    {
        public User SelectedObject;
        Dictionary<string, int> emps;
        List<Employee> employees;

        #region Constructs

        public DataUser(List<Employee> employees, User user, bool is_edit)
        {
            InitializeComponent();
            SelectedObject = user;
            this.employees = employees;
            emps = new Dictionary<string, int>();
            FillComboBox();
            if (is_edit)
                FillData();
        }

        #endregion

        private void FillComboBox()
        {
            foreach(Employee employee in employees)
            {
                employeeComboBox.Items.Add(employee.FormattedName());
                emps.Add(employee.FormattedName(), employee.Id);
            }
        }

        private void FillData()
        {
            loginTextBox.Text = SelectedObject.Login;
            passwordTextBox.Text = SelectedObject.Password;
            employeeComboBox.SelectedItem = SelectedObject.Employee.FormattedName();
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectData())
                return;
            SelectedObject.Login = loginTextBox.Text;
            SelectedObject.Password = passwordTextBox.Text;
            SelectedObject.IdEmployee = emps[(string)employeeComboBox.SelectedItem];
            SelectedObject.Employee = employees.SingleOrDefault(emp => emp.Id == SelectedObject.IdEmployee);
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
                if (loginTextBox.Text == "" || passwordTextBox.Text == "" || employeeComboBox.SelectedItem == null)
                    throw new Exception("Не все поля заполнены!");
                if (passwordTextBox.Text.Length < 4)
                    throw new Exception("Слишком короткий пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                correct = false;
            }

            return correct;
        }
    }
}
