
using Microsoft.EntityFrameworkCore;
using Sklad_project_2.Models;

namespace Sklad_project_2
{
    public partial class AdminCatalogForm : Form
    {
        private string _panelMode = "";
        private int _selectedProductId = 0;

        public AdminCatalogForm()
        {
            InitializeComponent();
            this.Text = "Каталог товаров - Администратор";
            lblUserInfo.Text = "Администратор: " + CurrentUser.User.Surname
                + " " + CurrentUser.User.Name;
        }

        private void LoadCategoriesToFilter()
        {
            using (var db = new SkladContext())
            {
                var cats = db.Categories.ToList();
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("Все категории");
                foreach (var c in cats)
                    cmbCategory.Items.Add(c.Name);
                cmbCategory.SelectedIndex = 0;
            }

            cmbAvailability.Items.Clear();
            cmbAvailability.Items.Add("Все");
            cmbAvailability.Items.Add("В наличии");
            cmbAvailability.Items.Add("Нет в наличии");
            cmbAvailability.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            using (var db = new SkladContext())
            {
                var allProducts = db.Products
                    .Include("Category")
                    .Include("Unit")
                    .Include("Stock")
                    .ToList();

                int totalCount = allProducts.Count;

                var searchText = txtSearch.Text.Trim().ToLower();
                var afterSearch = new List<Product>();

                if (string.IsNullOrEmpty(searchText))
                {
                    afterSearch = allProducts;
                }
                else
                {
                    foreach (var p in allProducts)
                    {
                        var pName = "";
                        var pArticle = "";
                        if (p.Name != null) pName = p.Name.ToLower();
                        if (p.Article != null) pArticle = p.Article.ToLower();

                        if (pName.Contains(searchText) || pArticle.Contains(searchText))
                            afterSearch.Add(p);
                    }
                }

                var afterCategory = new List<Product>();

                if (cmbCategory.SelectedIndex <= 0)
                {
                    afterCategory = afterSearch;
                }
                else
                {
                    var catName = cmbCategory.SelectedItem.ToString();
                    foreach (var p in afterSearch)
                    {
                        if (p.Category != null && p.Category.Name == catName)
                            afterCategory.Add(p);
                    }
                }

                var afterAvailability = new List<Product>();

                if (cmbAvailability.SelectedIndex == 1)
                {
                    foreach (var p in afterCategory)
                    {
                        if (p.Stock != null && p.Stock.Rest > 0)
                            afterAvailability.Add(p);
                    }
                }
                else if (cmbAvailability.SelectedIndex == 2)
                {
                    foreach (var p in afterCategory)
                    {
                        if (p.Stock == null || p.Stock.Rest == 0)
                            afterAvailability.Add(p);
                    }
                }
                else
                {
                    afterAvailability = afterCategory;
                }

                decimal priceFrom = 0;
                decimal priceTo = 1000000;
                decimal.TryParse(txtPriceFrom.Text, out priceFrom);
                decimal.TryParse(txtPriceTo.Text, out priceTo);

                var afterPrice = new List<Product>();
                foreach (var p in afterAvailability)
                {
                    if (p.Stock != null &&
                        p.Stock.PurchasePrice >= priceFrom &&
                        p.Stock.PurchasePrice <= priceTo)
                    {
                        afterPrice.Add(p);
                    }
                }

                lblFound.Text = "Найдено: " + afterPrice.Count + " из " + totalCount;

                dgvProducts.Rows.Clear();
                dgvProducts.Columns.Clear();
                dgvProducts.Columns.Add("colArticle", "Артикул");
                dgvProducts.Columns.Add("colName", "Наименование товара");
                dgvProducts.Columns.Add("colCategory", "Категория");
                dgvProducts.Columns.Add("colUnit", "Ед. измерения");
                dgvProducts.Columns.Add("colPrice", "Цена закупки");
                dgvProducts.Columns.Add("colRest", "Остаток");
                dgvProducts.Columns.Add("colId", "ID");
                dgvProducts.Columns["colId"].Visible = false;

                foreach (var p in afterPrice)
                {
                    var price = "—";
                    var rest = "—";
                    var catName = "";
                    var unitName = "";

                    if (p.Stock != null)
                    {
                        price = p.Stock.PurchasePrice.ToString("0") + " руб.";
                        rest = p.Stock.Rest.ToString();
                    }

                    if (p.Category != null) catName = p.Category.Name;
                    if (p.Unit != null) unitName = p.Unit.Name;

                    dgvProducts.Rows.Add(p.Article, p.Name, catName, unitName, price, rest, p.Id);
                }
            }
        }

        private void AdminCatalogForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToFilter();
            LoadProducts();
            panelEdit.Visible = false;
            panelEdit.BringToFront();
        }

        private void LoadCategoriesToEditPanel()
        {
            using (var db = new SkladContext())
            {
                var cats = db.Categories.ToList();
                cmbCategoryEdit.Items.Clear();
                foreach (var c in cats)
                    cmbCategoryEdit.Items.Add(c.Name);
            }
        }

        private void LoadUnitsToCmbUnit()
        {
            using (var db = new SkladContext())
            {
                var units = db.Units.ToList();
                cmbUnitEdit.Items.Clear();
                foreach (var u in units)
                    cmbUnitEdit.Items.Add(u.Name);
            }
        }

        private void LoadProductToEditPanel(int productId)
        {
            using (var db = new SkladContext())
            {
                var allProducts = db.Products
                    .Include("Category")
                    .Include("Unit")
                    .Include("Stock")
                    .ToList();

                Product p = null;
                foreach (var prod in allProducts)
                {
                    if (prod.Id == productId)
                    {
                        p = prod;
                        break;
                    }
                }

                if (p == null) return;

                txtArticleEdit.ReadOnly = false;
                txtNameEdit.ReadOnly = false;
                cmbCategoryEdit.Enabled = true;
                cmbUnitEdit.Enabled = true;
                txtPriceEdit.ReadOnly = false;
                txtRestEdit.ReadOnly = false;
                btnSaveEdit.Visible = true;

                txtArticleEdit.Text = p.Article;
                txtNameEdit.Text = p.Name;

                if (p.Category != null)
                    cmbCategoryEdit.SelectedItem = p.Category.Name;

                if (p.Unit != null)
                    cmbUnitEdit.SelectedItem = p.Unit.Name;

                if (p.Stock != null)
                {
                    txtPriceEdit.Text = p.Stock.PurchasePrice.ToString("0");
                    txtRestEdit.Text = p.Stock.Rest.ToString();
                }
                else
                {
                    txtPriceEdit.Text = "0";
                    txtRestEdit.Text = "0";
                }
            }
        }

        private void ClearEditPanel()
        {
            txtArticleEdit.Text = "";
            txtNameEdit.Text = "";

            if (cmbCategoryEdit.Items.Count > 0)
                cmbCategoryEdit.SelectedIndex = 0;

            if (cmbUnitEdit.Items.Count > 0)
                cmbUnitEdit.SelectedIndex = 0;

            txtPriceEdit.Text = "";
            txtRestEdit.Text = "";

            txtArticleEdit.ReadOnly = false;
            txtNameEdit.ReadOnly = false;
            cmbCategoryEdit.Enabled = true;
            cmbUnitEdit.Enabled = true;
            txtPriceEdit.ReadOnly = false;
            txtRestEdit.ReadOnly = false;
            btnSaveEdit.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _panelMode = "add";
            _selectedProductId = 0;
            ClearEditPanel();
            LoadCategoriesToEditPanel();
            LoadUnitsToCmbUnit();
            lblPanelTitle.Text = "ДОБАВЛЕНИЕ ТОВАРА";
            panelEdit.Visible = true;
            panelEdit.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования!");
                return;
            }

            var row = dgvProducts.SelectedRows[0];
            if (!int.TryParse(row.Cells["colId"].Value?.ToString(), out _selectedProductId))
            {
                MessageBox.Show("Ошибка выбора товара!");
                return;
            }

            _panelMode = "edit";
            LoadCategoriesToEditPanel();
            LoadUnitsToCmbUnit();
            LoadProductToEditPanel(_selectedProductId);
            lblPanelTitle.Text = "РЕДАКТИРОВАНИЕ ТОВАРА";
            panelEdit.Visible = true;
            panelEdit.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления!");
                return;
            }

            var row = dgvProducts.SelectedRows[0];
            int productId;
            if (!int.TryParse(row.Cells["colId"].Value?.ToString(), out productId))
            {
                MessageBox.Show("Ошибка выбора товара!");
                return;
            }

            var result = MessageBox.Show("Удалить выбранный товар?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            using (var db = new SkladContext())
            {
                Stock foundStock = null;
                var allStocks = db.Stocks.ToList();
                foreach (var s in allStocks)
                {
                    if (s.ProductId == productId)
                    {
                        foundStock = s;
                        break;
                    }
                }
                if (foundStock != null) db.Stocks.Remove(foundStock);

                var product = db.Products.Find(productId);
                if (product != null) db.Products.Remove(product);

                db.SaveChanges();
            }

            LoadProducts();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для просмотра!");
                return;
            }

            var row = dgvProducts.SelectedRows[0];
            int productId;
            if (!int.TryParse(row.Cells["colId"].Value?.ToString(), out productId))
                return;

            _panelMode = "view";
            LoadCategoriesToEditPanel();
            LoadUnitsToCmbUnit();
            LoadProductToEditPanel(productId);
            lblPanelTitle.Text = "ПРОСМОТР ТОВАРА";

            txtArticleEdit.ReadOnly = true;
            txtNameEdit.ReadOnly = true;
            cmbCategoryEdit.Enabled = false;
            cmbUnitEdit.Enabled = false;
            txtPriceEdit.ReadOnly = true;
            txtRestEdit.ReadOnly = true;
            btnSaveEdit.Visible = false;

            panelEdit.Visible = true;
            panelEdit.BringToFront();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbCategory.SelectedIndex = 0;
            cmbAvailability.SelectedIndex = 0;
            txtPriceFrom.Text = "0";
            txtPriceTo.Text = "1000000";
            LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            CurrentUser.RoleName = null;
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var article = txtArticleEdit.Text.Trim();
            var name = txtNameEdit.Text.Trim();
            var catName = "";
            var unitName = "";

            if (cmbCategoryEdit.SelectedItem != null)
                catName = cmbCategoryEdit.SelectedItem.ToString();
            if (cmbUnitEdit.SelectedItem != null)
                unitName = cmbUnitEdit.SelectedItem.ToString();

            decimal price;
            int rest;

            if (!decimal.TryParse(txtPriceEdit.Text, out price))
            {
                MessageBox.Show("Введите корректную цену!");
                return;
            }
            if (!int.TryParse(txtRestEdit.Text, out rest))
            {
                MessageBox.Show("Введите корректный остаток!");
                return;
            }
            if (string.IsNullOrEmpty(article) || string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(catName) || string.IsNullOrEmpty(unitName))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new SkladContext())
            {
                Category foundCategory = null;
                var allCats = db.Categories.ToList();
                foreach (var c in allCats)
                {
                    if (c.Name == catName)
                    {
                        foundCategory = c;
                        break;
                    }
                }

                Unit foundUnit = null;
                var allUnits = db.Units.ToList();
                foreach (var u in allUnits)
                {
                    if (u.Name == unitName)
                    {
                        foundUnit = u;
                        break;
                    }
                }

                if (foundCategory == null || foundUnit == null)
                {
                    MessageBox.Show("Категория или единица измерения не найдены!");
                    return;
                }

                if (_panelMode == "add")
                {
                    var newProduct = new Product
                    {
                        Article = article,
                        Name = name,
                        CategoryId = foundCategory.Id,
                        UnitId = foundUnit.Id
                    };
                    db.Products.Add(newProduct);
                    db.SaveChanges();

                    var newStock = new Stock
                    {
                        ProductId = newProduct.Id,
                        PurchasePrice = price,
                        Rest = rest
                    };
                    db.Stocks.Add(newStock);
                    db.SaveChanges();

                    MessageBox.Show("Товар добавлен!");
                }
                else if (_panelMode == "edit")
                {
                    var product = db.Products.Find(_selectedProductId);
                    if (product == null) return;

                    product.Article = article;
                    product.Name = name;
                    product.CategoryId = foundCategory.Id;
                    product.UnitId = foundUnit.Id;

                    Stock foundStock = null;
                    var allStocks = db.Stocks.ToList();
                    foreach (var s in allStocks)
                    {
                        if (s.ProductId == _selectedProductId)
                        {
                            foundStock = s;
                            break;
                        }
                    }

                    if (foundStock == null)
                    {
                        foundStock = new Stock { ProductId = _selectedProductId };
                        db.Stocks.Add(foundStock);
                    }

                    foundStock.PurchasePrice = price;
                    foundStock.Rest = rest;

                    db.SaveChanges();
                    MessageBox.Show("Товар обновлён!");
                }
            }

            panelEdit.Visible = false;
            LoadProducts();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            LoadProducts();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            var form = new CategoriesForm();
            form.ShowDialog();
            LoadCategoriesToFilter();
            LoadProducts();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var form = new ShipmentHistoryForm();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
