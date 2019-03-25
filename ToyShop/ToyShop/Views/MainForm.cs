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
    public partial class MainForm : Form
    {
        const int SELECT_EMLOYEE = 0;
        const int SELECT_TOY = 1;
        const int SELECT_STORAGE = 2;
        const int SELECT_DELIVERY = 3;
        const int SELECT_USER = 4;

        IRepository repository;
        User user;
        object selectedData = null;
        int selectItem = 0;

        public MainForm(User user)
        {
            InitializeComponent();
            repository = new DataRepository(new JsonFileServiceComplex());
            repository.Load();
            this.user = user;
        }

        #region MenuStripItems

        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            RefreshEmployeeListView();
        }

        private void toyMenuItem_Click(object sender, EventArgs e)
        {
            RefreshToyListView();
        }

        private void storageMenuItem_Click(object sender, EventArgs e)
        {
            RefreshStorageListView();
        }

        private void deliveryMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDeliveryListView();
        }

        private void userMenuItem_Click(object sender, EventArgs e)
        {
            RefreshUserListView();
        }

        #endregion

        #region ButtonEvents

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Вы не администратор!");
                return;
            }
            if (selectedData == null)
            {
                MessageBox.Show("Выберите сущность");
                return;
            }
            if (!OpenDataForm(selectedData, false))
                return;
            repository.AddObject(selectedData);
            repository.SaveChanges();
            SetSelect();
            RefreshListView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Вы не администратор!");
                return;
            }
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите объект");
                return;
            }
            if (!OpenDataForm(listView.SelectedItems[0].Tag, true))
                return;
            repository.SaveChanges();
            RefreshListView();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Вы не администратор!");
                return;
            }
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите объект");
                return;
            }
            repository.RemoveObject(listView.SelectedItems[0].Tag);
            listView.Items.Remove(listView.SelectedItems[0]);
            repository.SaveChanges();
            RefreshListView();
        }

        #endregion

        #region FillInfoGroup

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            if (listView.SelectedItems[0].Tag is Employee)
                FillInfoEmployee((Employee)listView.SelectedItems[0].Tag);

            if (listView.SelectedItems[0].Tag is Toy)
                FillInfoToy((Toy)listView.SelectedItems[0].Tag);

            if (listView.SelectedItems[0].Tag is Storage)
                FillInfoStorage((Storage)listView.SelectedItems[0].Tag);

            if (listView.SelectedItems[0].Tag is Delivery)
                FillInfoDelivery((Delivery)listView.SelectedItems[0].Tag);

            if (listView.SelectedItems[0].Tag is User)
                FillInfoUser((User)listView.SelectedItems[0].Tag);
        }

        private void HideInfo()
        {
            infoLabel1.Text = string.Empty;
            infoLabel2.Text = string.Empty;
            infoLabel3.Text = string.Empty;
            infoLabel4.Text = string.Empty;
            infoLabel5.Text = string.Empty;
            infoLabel6.Text = string.Empty;
            infoLabel7.Text = string.Empty;
            toysListView.Items.Clear();
            toysListView.Visible = false;
        }

        private void FillInfoEmployee(Employee employee)
        {
            HideInfo();
            infoLabel1.Text = "Имя: " + employee.Name;
            infoLabel2.Text = "Фамилия: " + employee.LastName;
            infoLabel3.Text = "Должность: " + employee.Post;
            string gender = "мужской";
            if (employee.Gender == Employee.FEMALE)
                gender = "женский";
            infoLabel4.Text = "Пол: " + gender;
            infoLabel5.Text = "Зарплата: " + employee.Salary.ToString() + " р.";
        }

        private void FillInfoToy(Toy toy)
        {
            HideInfo();
            infoLabel1.Text = "Название: " + toy.Name;
            infoLabel2.Text = "Цена: " + toy.Price + " р.";
            infoLabel3.Text = "Вес: " + toy.Weight + " гр.";
            infoLabel4.Text = "От скольки лет: " + toy.AgeLimit.ToString() + "+";
            infoLabel5.Text = "Для кого: " + toy.ToyType;
            infoLabel6.Text = "Компания: " + toy.Company;
            infoLabel7.Text = "Материал: " + toy.Material;
        }

        private void FillInfoStorage(Storage storage)
        {
            HideInfo();
            infoLabel1.Text = "Адрес: " + storage.Address;
            infoLabel2.Text = "Охранник: " + storage.Employee.FormattedName();
            infoLabel3.Text = "Количество игрушек на складе: " + storage.CountToys.ToString();
            infoLabel7.Text = "Игрушки на складе";
            toysListView.Visible = true;
            foreach(Toy toy in storage.Toys)
            {
                ListViewItem item = new ListViewItem(toy.Name, 0);
                toysListView.Items.Add(item);
            }
        }

        private void FillInfoDelivery(Delivery delivery)
        {
            HideInfo();
            infoLabel1.Text = "Адрес: " + delivery.Address;
            infoLabel2.Text = "Доставщик: " + delivery.Deliveryman.FormattedName();
            infoLabel3.Text = "Цена доставки: " + delivery.Price.ToString();
            infoLabel4.Text = "Дата приёма: " + delivery.TimeEnd.ToLongDateString() + " р.";
            infoLabel7.Text = "Состав доставки";
            toysListView.Visible = true;
            foreach (Toy toy in delivery.Toys)
            {
                ListViewItem item = new ListViewItem(toy.Name, 0);
                toysListView.Items.Add(item);
            }
        }

        private void FillInfoUser(User user)
        {
            HideInfo();
            infoLabel1.Text = "Логин: " + user.Login;
            infoLabel2.Text = "Сотрудник: " + user.Employee.FormattedName();
        }

        #endregion

        #region RefreshListView    

        private void RefreshEmployeeListView()
        {
            listView.Items.Clear();
            ListViewItem item = null;
            foreach (Employee employee in repository.Employees)
            {
                item = new ListViewItem(employee.LastName);
                item.Tag = employee;
                listView.Items.Add(item);
            }
            selectItem = SELECT_EMLOYEE;
            SetSelect();
        }

        private void RefreshToyListView()
        {
            listView.Items.Clear();
            ListViewItem item = null;
            foreach (Toy toy in repository.Toys)
            {
                item = new ListViewItem(toy.Name);
                item.Tag = toy;
                listView.Items.Add(item);
            }
            selectItem = SELECT_TOY;
            SetSelect();
        }

        private void RefreshStorageListView()
        {
            listView.Items.Clear();
            ListViewItem item = null;
            foreach (Storage storage in repository.Storages)
            {
                item = new ListViewItem(storage.Id.ToString());
                item.Tag = storage;
                listView.Items.Add(item);
            }
            selectItem = SELECT_STORAGE;
            SetSelect();
        }

        private void RefreshDeliveryListView()
        {
            listView.Items.Clear();
            ListViewItem item = null;
            foreach (Delivery delivery in repository.Deliveries)
            {
                item = new ListViewItem(delivery.Id.ToString());
                item.Tag = delivery;
                listView.Items.Add(item);
            }
            selectItem = SELECT_DELIVERY;
            SetSelect();
        }

        private void RefreshUserListView()
        {
            listView.Items.Clear();
            ListViewItem item = null;
            foreach (User user in repository.Users)
            {
                item = new ListViewItem(user.Login);
                item.Tag = user;
                listView.Items.Add(item);
            }
            selectItem = SELECT_USER;
            SetSelect();
        }

        #endregion

        #region Methods

        private bool IsAdmin()
        {
            if (user.Employee.Post == Employee.EmployeePost.Admin)
                return true;
            else
                return false;
        }

        private void SetSelect()
        {
            if (selectItem == SELECT_EMLOYEE)
                selectedData = new Employee();
            if (selectItem == SELECT_TOY)
                selectedData = new Toy();
            if (selectItem == SELECT_STORAGE)
                selectedData = new Storage();
            if (selectItem == SELECT_DELIVERY)
                selectedData = new Delivery();
            if (selectItem == SELECT_USER)
                selectedData = new User();
        }

        private void RefreshListView()
        {
            if (selectItem == SELECT_EMLOYEE)
                RefreshEmployeeListView();
            if (selectItem == SELECT_TOY)
                RefreshToyListView();
            if (selectItem == SELECT_STORAGE)
                RefreshStorageListView();
            if (selectItem == SELECT_DELIVERY)
                RefreshDeliveryListView();
            if (selectItem == SELECT_USER)
                RefreshUserListView();
        }

        private bool OpenDataForm(object obj, bool is_edit)
        {
            if (selectItem == SELECT_EMLOYEE)
            {
                DataEmployee dataForm = new DataEmployee((Employee)obj, is_edit);
                if (dataForm.ShowDialog() == DialogResult.Cancel)
                    return false;
                if(!is_edit)
                    selectedData = dataForm.SelectedObject;
            }
            if (selectItem == SELECT_TOY)
            {
                DataToy dataForm = new DataToy((Toy)obj, is_edit);
                if (dataForm.ShowDialog() == DialogResult.Cancel)
                    return false;
                if (!is_edit)
                    selectedData = dataForm.SelectedObject;
            }
            if (selectItem == SELECT_STORAGE)
            {
                DataStorage dataForm = new DataStorage(repository.Employees, repository.Toys, (Storage)obj, is_edit);
                if (dataForm.ShowDialog() == DialogResult.Cancel)
                    return false;
                if (!is_edit)
                    selectedData = dataForm.SelectedObject;
            }
            if (selectItem == SELECT_DELIVERY)
            {
                DataDelivery dataForm = new DataDelivery(repository.Employees, repository.Toys, (Delivery)obj, is_edit);
                if (dataForm.ShowDialog() == DialogResult.Cancel)
                    return false;
                if (!is_edit)
                    selectedData = dataForm.SelectedObject;
            }
            if (selectItem == SELECT_USER)
            {
                DataUser dataForm = new DataUser(repository.Employees, (User)obj, is_edit);
                if (dataForm.ShowDialog() == DialogResult.Cancel)
                    return false;
                if (!is_edit)
                    selectedData = dataForm.SelectedObject;
            }
            return true;
        }

        #endregion

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
