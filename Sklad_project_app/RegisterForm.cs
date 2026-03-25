using Sklad_project_2.Models;

namespace Sklad_project_2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
                chkStorekeeper.Checked = false;
        }

        private void chkStorekeeper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStorekeeper.Checked)
                chkAdmin.Checked = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var fio = txtFio.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (!chkAdmin.Checked && !chkStorekeeper.Checked)
            {
                MessageBox.Show("Выберите роль!");
                return;
            }

            var parts = fio.Split(' ');
            var surname = "";
            var name = "";
            var patronymic = "";

            if (parts.Length > 0) surname = parts[0];
            if (parts.Length > 1) name = parts[1];
            if (parts.Length > 2) patronymic = parts[2];

            using (var db = new SkladContext())
            {
                var allUsers = db.Users.ToList();
                foreach (var u in allUsers)
                {
                    var userLogin = "";
                    if (u.Login != null) userLogin = u.Login.Trim();

                    if (userLogin == fio)
                    {
                        MessageBox.Show("Пользователь с таким ФИО уже существует!");
                        return;
                    }
                }

                var roleName = "";
                if (chkAdmin.Checked)
                    roleName = "Администратор";
                else
                    roleName = "Кладовщик";

                var allRoles = db.Roles.ToList();
                Role foundRole = null;

                foreach (var r in allRoles)
                {
                    if (r.RoleName == roleName)
                    {
                        foundRole = r;
                        break;
                    }
                }

                if (foundRole == null)
                {
                    MessageBox.Show("Роль не найдена в базе данных!");
                    return;
                }

                var newUser = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    Login = fio,
                    Password = password,
                    Role_id = foundRole.Id
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Регистрация успешна! Логин: " + fio);
                this.Close();
            }
        }
    }
}