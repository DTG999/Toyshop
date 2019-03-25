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
    public partial class DataStorage : Form
    {
        public Storage SelectedObject;
        Dictionary<string, int> emps;
        List<Employee> employees;
        Dictionary<string, int> ts;
        List<Toy> toys;
        List<Toy> toysStorage;

        #region Constructs

        public DataStorage(List<Employee> employees, List<Toy> toys, Storage storage, bool is_edit)
        {
            InitializeComponent();
            SelectedObject = storage;
            this.employees = employees;
            this.toys = toys;
            toysStorage = new List<Toy>();
            emps = new Dictionary<string, int>();
            ts = new Dictionary<string, int>();
            FillComboBox();
            if (is_edit)
                FillData();
        }

        #endregion

        private void FillComboBox()
        {
            foreach(Employee employee in employees)
            {
                if(employee.Post == Employee.EmployeePost.SecurityStorage)
                {
                    securityComboBox.Items.Add(employee.FormattedName());
                    emps.Add(employee.FormattedName(), employee.Id);
                }
            }
            toysListView.Items.Clear();
            foreach (Toy toy in toys)
            {
                if (toy.IdStorage == SelectedObject.Id)
                {
                    toysStorage.Add(toy);
                    ListViewItem item = new ListViewItem(toy.Name, 1);
                    item.Tag = toy;
                    toysListView.Items.Add(item);
                }
                else
                    toyComboBox.Items.Add(toy.Name);
                ts.Add(toy.Name, toy.Id);
            }
        }

        private void FillData()
        {
            addressTextBox.Text = SelectedObject.Address;
            securityComboBox.SelectedItem = SelectedObject.Employee.FormattedName();
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectData())
                return;
            SelectedObject.Address = addressTextBox.Text;
            SelectedObject.CountToys = toysStorage.Count();
            SelectedObject.IdEmployee = emps[(string)securityComboBox.SelectedItem];
            SelectedObject.Employee = employees.SingleOrDefault(emp => emp.Id == SelectedObject.IdEmployee);
            SelectedObject.Toys = toysStorage;
            foreach(Toy toy in toys)
            {
                if (SelectedObject.Toys.Contains(toy))
                {
                    toy.IdStorage = SelectedObject.Id;
                    toy.Storage = SelectedObject;
                }
            }
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
                if (addressTextBox.Text == "" || securityComboBox.SelectedItem == null)
                    throw new Exception("Не все поля заполнены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                correct = false;
            }

            return correct;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (toyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите игрушку для добавления на склад.");
                return;
            }
            ListViewItem item = new ListViewItem((string)toyComboBox.SelectedItem, 0);
            item.Tag = (string)toyComboBox.SelectedItem;
            int idToy = ts[(string)toyComboBox.SelectedItem];
            toysStorage.Add(toys.SingleOrDefault(t => t.Id == idToy));
            toysListView.Items.Add(item);
            toyComboBox.Items.Remove(toyComboBox.SelectedItem);
            toyComboBox.Text = string.Empty;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (toysListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите игрушку для удаления из склада.");
                return;
            }
            Toy toy = (Toy)toysListView.SelectedItems[0].Tag;
            toysStorage.Remove(toy);
            toyComboBox.Items.Add(toy.Name);
            toysListView.Items.Remove(toysListView.SelectedItems[0]);
        }
    }
}
