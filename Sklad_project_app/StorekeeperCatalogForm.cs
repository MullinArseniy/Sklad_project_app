
using Microsoft.EntityFrameworkCore;
using Sklad_project_2;
using Sklad_project_2.Models;


namespace SkladApp
{
    public partial class StorekeeperCatalogForm : Form
    {
        private int _selectedProductId = 0;

        public StorekeeperCatalogForm()
        {
            InitializeComponent();
            this.Text = "Каталог товаров - Кладовщик";
            lblUserInfo.Text = "Кладовщик: " + CurrentUser.User.Surname
                + " " + CurrentUser.User.Name;
        }

        private void StorekeeperCatalogForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToFilter();
            LoadProducts();
            panelView.Visible = false;
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

                //название
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

                //категория
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

                //наличие
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

                //цена
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


        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для просмотра!");
                return;
            }

            var row = dgvProducts.SelectedRows[0];
            if (!int.TryParse(row.Cells["colId"].Value?.ToString(), out _selectedProductId))
                return;

            LoadProductToViewPanel(_selectedProductId);
            lblPanelTitle.Text = "ПРОСМОТР ТОВАРА";
            panelView.Visible = true;
            panelView.BringToFront();
        }

        private void LoadProductToViewPanel(int productId)
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

                txtArticleView.Text = p.Article;
                txtNameView.Text = p.Name;

                if (p.Category != null)
                    txtCategoryView.Text = p.Category.Name;
                else
                    txtCategoryView.Text = "";

                if (p.Unit != null)
                    txtUnitView.Text = p.Unit.Name;
                else
                    txtUnitView.Text = "";

                if (p.Stock != null)
                {
                    txtPriceView.Text = p.Stock.PurchasePrice.ToString("0") + " руб.";
                    txtRestView.Text = p.Stock.Rest.ToString();
                }
                else
                {
                    txtPriceView.Text = "—";
                    txtRestView.Text = "—";
                }
            }
        }

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;
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

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;
            LoadProducts();
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            var form = new ShipmentForm();
            form.ShowDialog();
            LoadProducts();
        }

        private void btnMyShipments_Click(object sender, EventArgs e)
        {
            var form = new MyShipmentsForm();
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
