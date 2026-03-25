using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Sklad_project_2.Models;

namespace Sklad_project_2
{
    public partial class ShipmentForm : Form
    {
        private Dictionary<int, int> _shipmentItems = new Dictionary<int, int>();

        public ShipmentForm()
        {
            InitializeComponent();
            lblUserInfo.Text = "Кладовщик: " + CurrentUser.User.Surname
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
                    .Include("Stock")
                    .ToList();

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

                dgvShipment.Rows.Clear();
                dgvShipment.Columns.Clear();

                dgvShipment.Columns.Add("colArticle", "Артикул");
                dgvShipment.Columns.Add("colName", "Наименование товара");
                dgvShipment.Columns.Add("colCategory", "Категория");
                dgvShipment.Columns.Add("colPrice", "Цена закупки");
                dgvShipment.Columns.Add("colRest", "Остаток");

                var btnMinus = new DataGridViewButtonColumn();
                btnMinus.Name = "colMinus";
                btnMinus.HeaderText = "";
                btnMinus.Text = "-";
                btnMinus.UseColumnTextForButtonValue = true;
                dgvShipment.Columns.Add(btnMinus);

                dgvShipment.Columns.Add("colQty", "Взято");

                var btnPlus = new DataGridViewButtonColumn();
                btnPlus.Name = "colPlus";
                btnPlus.HeaderText = "";
                btnPlus.Text = "+";
                btnPlus.UseColumnTextForButtonValue = true;
                dgvShipment.Columns.Add(btnPlus);

                dgvShipment.Columns.Add("colId", "ID");
                dgvShipment.Columns["colId"].Visible = false;

                foreach (var p in afterAvailability)
                {
                    var price = "—";
                    var rest = "0";
                    var catName = "";

                    if (p.Stock != null)
                    {
                        price = p.Stock.PurchasePrice.ToString("0") + " руб.";
                        rest = p.Stock.Rest.ToString();
                    }

                    if (p.Category != null) catName = p.Category.Name;

                    int qty = 0;
                    if (_shipmentItems.ContainsKey(p.Id))
                        qty = _shipmentItems[p.Id];

                    dgvShipment.Rows.Add(p.Article, p.Name, catName, price, rest, "-", qty.ToString(), "+", p.Id);
                }

                UpdateTotal();
            }
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToFilter();
            LoadProducts();
            dtpDate.Value = DateTime.Today;
        }

        private void UpdateTotal()
        {
            int total = 0;
            foreach (var kv in _shipmentItems)
                total += kv.Value;
            lblTotal.Text = "ВЗЯТО ТОВАРОВ:\n" + total.ToString();
        }


        private void dgvShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productId;
            if (!int.TryParse(dgvShipment.Rows[e.RowIndex].Cells["colId"].Value?.ToString(), out productId))
                return;

            int rest;
            if (!int.TryParse(dgvShipment.Rows[e.RowIndex].Cells["colRest"].Value?.ToString(), out rest))
                rest = 0;

            int currentQty = 0;
            if (_shipmentItems.ContainsKey(productId))
                currentQty = _shipmentItems[productId];

            if (e.ColumnIndex == dgvShipment.Columns["colPlus"].Index)
            {
                if (currentQty < rest)
                {
                    _shipmentItems[productId] = currentQty + 1;
                    dgvShipment.Rows[e.RowIndex].Cells["colQty"].Value = _shipmentItems[productId].ToString();
                }
                else
                {
                    MessageBox.Show("Недостаточно товара на складе!");
                }
            }
            else if (e.ColumnIndex == dgvShipment.Columns["colMinus"].Index)
            {
                if (currentQty > 0)
                {
                    _shipmentItems[productId] = currentQty - 1;
                    dgvShipment.Rows[e.RowIndex].Cells["colQty"].Value = _shipmentItems[productId].ToString();
                }
            }

            UpdateTotal();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var clientName = txtClientName.Text.Trim();
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Введите название клиента!");
                return;
            }

            var itemsToShip = new Dictionary<int, int>();
            foreach (var kv in _shipmentItems)
            {
                if (kv.Value > 0)
                    itemsToShip.Add(kv.Key, kv.Value);
            }

            if (itemsToShip.Count == 0)
            {
                MessageBox.Show("Выберите товары для отгрузки!");
                return;
            }

            using (var db = new SkladContext())
            {
                foreach (var item in itemsToShip)
                {
                    Stock foundStock = null;
                    var allStocks = db.Stocks.ToList();
                    foreach (var s in allStocks)
                    {
                        if (s.ProductId == item.Key)
                        {
                            foundStock = s;
                            break;
                        }
                    }

                    if (foundStock == null || foundStock.Rest < item.Value)
                    {
                        var product = db.Products.Find(item.Key);
                        var productName = "";
                        if (product != null) productName = product.Name;
                        MessageBox.Show("Недостаточно товара: " + productName);
                        return;
                    }
                }

                Client foundClient = null;
                var allClients = db.Clients.ToList();
                foreach (var c in allClients)
                {
                    if (c.Name == clientName)
                    {
                        foundClient = c;
                        break;
                    }
                }

                if (foundClient == null)
                {
                    foundClient = new Client { Name = clientName };
                    db.Clients.Add(foundClient);
                    db.SaveChanges();
                }

                var shipment = new Shipment
                {
                    ClientId = foundClient.Id,
                    UserId = CurrentUser.User.Id,
                    ShipmentDate = dtpDate.Value.Date
                };
                db.Shipments.Add(shipment);
                db.SaveChanges();

                foreach (var item in itemsToShip)
                {
                    db.ShipmentItems.Add(new ShipmentItem
                    {
                        ShipmentId = shipment.Id,
                        ProductId = item.Key,
                        Quantity = item.Value
                    });

                    var allStocks = db.Stocks.ToList();
                    foreach (var s in allStocks)
                    {
                        if (s.ProductId == item.Key)
                        {
                            s.Rest -= item.Value;
                            break;
                        }
                    }
                }

                db.SaveChanges();
            }

            MessageBox.Show("Отгрузка успешно оформлена!");
            _shipmentItems.Clear();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _shipmentItems.Clear();
            this.Close();
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
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}