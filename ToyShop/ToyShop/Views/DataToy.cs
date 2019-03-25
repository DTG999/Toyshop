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
    public partial class DataToy : Form
    {
        public Toy SelectedObject;

        #region Constructs

        public DataToy(Toy toy, bool is_edit)
        {
            InitializeComponent();
            SelectedObject = toy;
            FillComboBox();
            if (is_edit)
                FillData();
        }

        #endregion

        private void FillComboBox()
        {
            typeComboBox.Items.Add(Toy.ToyGender.boy);
            typeComboBox.Items.Add(Toy.ToyGender.girl);
            typeComboBox.Items.Add(Toy.ToyGender.unisex);
        }

        private void FillData()
        {
            nameTextBox.Text = SelectedObject.Name;
            priceTextBox.Text = SelectedObject.Price.ToString();
            materialTextBox.Text = SelectedObject.Material;
            companyTextBox.Text = SelectedObject.Company;
            weightTextBox.Text = SelectedObject.Weight.ToString();
            ageNumeric.Value = SelectedObject.AgeLimit;
            typeComboBox.SelectedItem = SelectedObject.ToyType;
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectData())
                return;
            SelectedObject.Name = nameTextBox.Text;
            SelectedObject.Price = Convert.ToDouble(priceTextBox.Text);
            SelectedObject.Material = materialTextBox.Text;
            SelectedObject.Company = companyTextBox.Text;
            SelectedObject.AgeLimit = Convert.ToInt32(ageNumeric.Value);
            SelectedObject.Weight = Convert.ToInt32(weightTextBox.Text);
            SelectedObject.ToyType = (Toy.ToyGender)typeComboBox.SelectedItem;
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
                if (nameTextBox.Text == "" || priceTextBox.Text == "" || materialTextBox.Text == "" || typeComboBox.SelectedItem == null ||
                    companyTextBox.Text == "" || weightTextBox.Text == "")
                    throw new Exception("Не все поля заполнены!");
                double price = Convert.ToDouble(priceTextBox.Text);
                int weight = Convert.ToInt32(weightTextBox.Text);
                if (price <= 0 || weight <= 0)
                    throw new Exception("Цена и вес должны быть больше 0");
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
