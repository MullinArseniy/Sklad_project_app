using Microsoft.EntityFrameworkCore;

namespace Sklad_project_2
{
    public partial class ShipmentHistoryForm : Form
    {
        public ShipmentHistoryForm()
        {
            InitializeComponent();
        }

        private void LoadHistory()
        {
            using (var db = new SkladContext())
            {
                var shipments = db.Shipments
                    .Include("Client")
                    .Include("User")
                    .ToList();

                dgvHistory.Rows.Clear();
                dgvHistory.Columns.Clear();
                dgvHistory.Columns.Add("colShipId", "№");
                dgvHistory.Columns.Add("colShipClient", "Клиент");
                dgvHistory.Columns.Add("colShipUser", "Кладовщик");
                dgvHistory.Columns.Add("colShipDate", "Дата");
                dgvHistory.Columns.Add("colShipIdHidden", "ID");
                dgvHistory.Columns["colShipIdHidden"].Visible = false;

                foreach (var s in shipments)
                {
                    var clientName = "—";
                    var userName = "—";
                    var date = "—";

                    if (s.Client != null) clientName = s.Client.Name;
                    if (s.User != null) userName = s.User.Surname + " " + s.User.Name;
                    if (s.ShipmentDate != null) date = s.ShipmentDate.Value.ToString("dd.MM.yyyy");

                    dgvHistory.Rows.Add(s.Id, clientName, userName, date, s.Id);
                }
            }
        }

        private void ShipmentHistoryForm_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        

        private void LoadShipmentItems(int shipmentId)
        {
            using (var db = new SkladContext())
            {
                var allItems = db.ShipmentItems
                    .Include("Product")
                    .ToList();

                dgvHistoryItems.Rows.Clear();
                dgvHistoryItems.Columns.Clear();
                dgvHistoryItems.Columns.Add("colItemName", "Товар");
                dgvHistoryItems.Columns.Add("colItemQty", "Количество");

                foreach (var item in allItems)
                {
                    if (item.ShipmentId == shipmentId)
                    {
                        var productName = "—";
                        if (item.Product != null) productName = item.Product.Name;
                        dgvHistoryItems.Rows.Add(productName, item.Quantity);
                    }
                }
            }
        }

        private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0) return;

            int shipId;
            if (!int.TryParse(
                dgvHistory.SelectedRows[0].Cells["colShipIdHidden"].Value?.ToString(),
                out shipId)) return;

            LoadShipmentItems(shipId);
        }
    }
}