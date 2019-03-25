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
    public partial class DataDelivery : Form
    {
        public Delivery SelectedObject;
        Dictionary<string, int> emps;
        List<Employee> employees;
        Dictionary<string, int> ts;
        List<Toy> toys;
        List<Toy> toysDelivery;

        #region Constructs

        public DataDelivery(List<Employee> employees, List<Toy> toys, Delivery delivery, bool is_edit)
        {
            InitializeComponent();
            SelectedObject = delivery;
            this.employees = employees;
            this.toys = toys;
            toysDelivery = new List<Toy>();
            emps = new Dictionary<string, int>();
            ts = new Dictionary<string, int>();
            FillComboBox();
            if (is_edit)
                FillData();
        }

        #endregion

        private void FillComboBox()
        {
            foreach (Employee employee in employees)
            {
                if (employee.Post == Employee.EmployeePost.Deliveryman)
                {
                    deliveryComboBox.Items.Add(employee.FormattedName());
                    emps.Add(employee.FormattedName(), employee.Id);
                }
            }
            toysListView.Items.Clear();
            foreach (Toy toy in toys)
            {
                if (toy.IdDeliveryInclude.Contains(SelectedObject.Id))
                {
                    toysDelivery.Add(toy);
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
            priceTextBox.Text = SelectedObject.Price.ToString();
            dateTimePicker.Value = SelectedObject.TimeEnd;
            deliveryComboBox.SelectedItem = SelectedObject.Deliveryman.FormattedName();
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectData())
                return;
            SelectedObject.Address = addressTextBox.Text;
            SelectedObject.Price = Convert.ToDouble(priceTextBox.Text);
            SelectedObject.TimeEnd = dateTimePicker.Value;
            SelectedObject.IdDeliveryman = emps[(string)deliveryComboBox.SelectedItem];
            SelectedObject.Deliveryman = employees.SingleOrDefault(emp => emp.Id == SelectedObject.IdDeliveryman);
            SelectedObject.Toys = toysDelivery;
            foreach (Toy toy in toys)
            {
                if (toy.Deliveries == null)
                    toy.Deliveries = new List<Delivery>();
                if (SelectedObject.Toys.Contains(toy))
                {
                    if (!toy.Deliveries.Contains(SelectedObject))
                    {
                        toy.IdDeliveryInclude.Add(SelectedObject.Id);
                        toy.Deliveries.Add(SelectedObject);
                    }
                }
                else
                {
                    if (toy.Deliveries.Contains(SelectedObject))
                    {
                        toy.IdDeliveryInclude.Remove(SelectedObject.Id);
                        toy.Deliveries.Remove(SelectedObject);
                    }
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
                if (addressTextBox.Text == "" || deliveryComboBox.SelectedItem == null || priceTextBox.Text == "")
                    throw new Exception("Не все поля заполнены!");
                double price = Convert.ToDouble(priceTextBox.Text);
                if (price < 0)
                    throw new Exception("Цена должна быть больше 0.");
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
                MessageBox.Show("Выберите игрушку для добавления в заказ.");
                return;
            }
            ListViewItem item = new ListViewItem((string)toyComboBox.SelectedItem, 0);
            item.Tag = (string)toyComboBox.SelectedItem;
            int idToy = ts[(string)toyComboBox.SelectedItem];
            toysDelivery.Add(toys.SingleOrDefault(t => t.Id == idToy));
            toysListView.Items.Add(item);
            toyComboBox.Items.Remove(toyComboBox.SelectedItem);
            toyComboBox.Text = string.Empty;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (toysListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите игрушку для удаления из заказа.");
                return;
            }
            Toy toy = (Toy)toysListView.SelectedItems[0].Tag;
            toysDelivery.Remove(toy);
            toyComboBox.Items.Add(toy.Name);
            toysListView.Items.Remove(toysListView.SelectedItems[0]);
        }
    }
}
