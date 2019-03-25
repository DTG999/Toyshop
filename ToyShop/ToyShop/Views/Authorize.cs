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
    public partial class Authorize : Form
    {
        IAuthService authService;

        public Authorize(IAuthService auth_service)
        {
            InitializeComponent();
            authService = auth_service;
        }
        
        private void enterButton_Click(object sender, EventArgs e)
        {
            User user = authService.Authorize(loginTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            MainForm mainForm = new MainForm(user);
            MessageBox.Show("Приветствую вас, " + user.Employee.FormattedName() + "!");
            Visible = false;
            mainForm.ShowDialog();
            Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
