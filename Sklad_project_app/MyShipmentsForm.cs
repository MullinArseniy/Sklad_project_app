using Microsoft.EntityFrameworkCore;

namespace Sklad_project_2
{
    public partial class MyShipmentsForm : Form
    {
        public MyShipmentsForm()
        {
            InitializeComponent();
        }

        private void LoadMyShipments()
        {
            using (var db = new SkladContext())
            {
                var userId = CurrentUser.User.Id;
                var allShipments = db.Shipments
                    .Include("Client")
                    .Include("ShipmentItems")
                    .ToList();

                dgvMyShipments.Rows.Clear();
                dgvMyShipments.Columns.Clear();
                dgvMyShipments.Columns.Add("colId", "№");
                dgvMyShipments.Columns.Add("colClient", "Клиент");
                dgvMyShipments.Columns.Add("colDate", "Дата");
                dgvMyShipments.Columns.Add("colItems", "Товаров");

                foreach (var s in allShipments)
                {
                    if (s.UserId == userId)
                    {
                        var clientName = "—";
                        var date = "—";
                        int itemCount = 0;

                        if (s.Client != null) clientName = s.Client.Name;
                        if (s.ShipmentDate != null) date = s.ShipmentDate.Value.ToString("dd.MM.yyyy");
                        if (s.ShipmentItems != null) itemCount = s.ShipmentItems.Count;

                        dgvMyShipments.Rows.Add(s.Id, clientName, date, itemCount);
                    }
                }
            }
        }
        private void MyShipmentsForm_Load(object sender, EventArgs e)
        {
            LoadMyShipments();
        }
    }
}
