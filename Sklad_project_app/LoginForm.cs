using Microsoft.EntityFrameworkCore;
using Sklad_project_2.Models;
using SkladApp;

namespace Sklad_project_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SkladContext())
                {
                    db.Database.CanConnect();
                    MessageBox.Show("Подключение успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new SkladContext())
            {
                var allUsers = db.Users.Include("Role").ToList();
                User foundUser = null;

                foreach (var u in allUsers)
                {
                    var userLogin = "";
                    var userPassword = "";

                    if (u.Login != null) userLogin = u.Login.Trim();
                    if (u.Password != null) userPassword = u.Password.Trim();

                    if (userLogin == login && userPassword == password)
                    {
                        foundUser = u;
                        break;
                    }
                }

                if (foundUser == null)
                {
                    MessageBox.Show("Неверный логин или пароль!");
                    return;
                }

                CurrentUser.User = foundUser;
                CurrentUser.RoleName = foundUser.Role.RoleName;

                if (CurrentUser.IsAdmin)
                {
                    var adminForm = new AdminCatalogForm();
                    adminForm.Show();
                }
                else
                {
                    var storeForm = new StorekeeperCatalogForm();
                    storeForm.Show();
                }

                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}