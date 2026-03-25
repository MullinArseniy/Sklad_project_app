using Sklad_project_2.Models;

namespace Sklad_project_2
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (var db = new SkladContext())
            {
                var cats = db.Categories.ToList();
                lstCategories.Items.Clear();
                foreach (var c in cats)
                    lstCategories.Items.Add(c.Name);
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название категории!");
                return;
            }

            using (var db = new SkladContext())
            {
                var allCats = db.Categories.ToList();
                foreach (var c in allCats)
                {
                    if (c.Name == name)
                    {
                        MessageBox.Show("Такая категория уже существует!");
                        return;
                    }
                }

                db.Categories.Add(new Category { Name = name });
                db.SaveChanges();
            }

            txtCategoryName.Text = "";
            LoadCategories();
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            var oldName = lstCategories.SelectedItem.ToString();
            var newName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Введите новое название!");
                return;
            }

            using (var db = new SkladContext())
            {
                var allCats = db.Categories.ToList();
                Category foundCat = null;

                foreach (var c in allCats)
                {
                    if (c.Name == oldName)
                    {
                        foundCat = c;
                        break;
                    }
                }

                if (foundCat == null) return;
                foundCat.Name = newName;
                db.SaveChanges();
            }

            txtCategoryName.Text = "";
            LoadCategories();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            var catName = lstCategories.SelectedItem.ToString();
            var result = MessageBox.Show("Удалить категорию '" + catName + "'?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            using (var db = new SkladContext())
            {
                var allCats = db.Categories.ToList();
                Category foundCat = null;

                foreach (var c in allCats)
                {
                    if (c.Name == catName)
                    {
                        foundCat = c;
                        break;
                    }
                }

                if (foundCat == null) return;

                var allProducts = db.Products.ToList();
                foreach (var p in allProducts)
                {
                    if (p.CategoryId == foundCat.Id)
                    {
                        MessageBox.Show("Нельзя удалить категорию — в ней есть товары!");
                        return;
                    }
                }

                db.Categories.Remove(foundCat);
                db.SaveChanges();
            }

            LoadCategories();
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex >= 0)
                txtCategoryName.Text = lstCategories.SelectedItem.ToString();
        }
    }
}