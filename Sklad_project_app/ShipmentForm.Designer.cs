
namespace Sklad_project_2
{
    partial class ShipmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblShipTitle = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvShipment = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.panelTop.Controls.Add(this.lblCompany);
            this.panelTop.Controls.Add(this.lblUserInfo);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblWarning);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 35);

            // lblCompany
            this.lblCompany.AutoSize = true;
            this.lblCompany.ForeColor = System.Drawing.Color.White;
            this.lblCompany.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompany.Location = new System.Drawing.Point(10, 8);
            this.lblCompany.Text = "ООО \"Птички-тупички\" - система управления складом";

            // lblUserInfo
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblUserInfo.Location = new System.Drawing.Point(800, 9);
            this.lblUserInfo.Text = "Кладовщик:";

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(1020, 5);
            this.btnLogout.Size = new System.Drawing.Size(70, 25);
            this.btnLogout.Text = "Выход";
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(210, 220, 235);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // lblWarning
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Yellow;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblWarning.Location = new System.Drawing.Point(450, 9);
            this.lblWarning.Text = "Перед отгрузкой проверьте наличие товара на складе";

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.panelLeft.Controls.Add(this.lblShipTitle);
            this.panelLeft.Controls.Add(this.lblClient);
            this.panelLeft.Controls.Add(this.txtClientName);
            this.panelLeft.Controls.Add(this.lblDate);
            this.panelLeft.Controls.Add(this.dtpDate);
            this.panelLeft.Controls.Add(this.lblTotal);
            this.panelLeft.Controls.Add(this.btnCancel);
            this.panelLeft.Controls.Add(this.btnSubmit);
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Size = new System.Drawing.Size(140, 565);

            // lblShipTitle
            this.lblShipTitle.AutoSize = false;
            this.lblShipTitle.ForeColor = System.Drawing.Color.White;
            this.lblShipTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblShipTitle.Location = new System.Drawing.Point(5, 8);
            this.lblShipTitle.Size = new System.Drawing.Size(130, 30);
            this.lblShipTitle.Text = "ДАННЫЕ ОТГРУЗКИ";
            this.lblShipTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblClient
            this.lblClient.AutoSize = true;
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Font = new System.Drawing.Font("Arial", 8F);
            this.lblClient.Location = new System.Drawing.Point(5, 45);
            this.lblClient.Text = "Клиент (название):";

            // txtClientName
            this.txtClientName.Location = new System.Drawing.Point(5, 62);
            this.txtClientName.Size = new System.Drawing.Size(130, 22);
            this.txtClientName.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtClientName.ForeColor = System.Drawing.Color.White;
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Arial", 8F);
            this.lblDate.Location = new System.Drawing.Point(5, 92);
            this.lblDate.Text = "Дата отгрузки:";

            // dtpDate
            this.dtpDate.Location = new System.Drawing.Point(5, 108);
            this.dtpDate.Size = new System.Drawing.Size(130, 22);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblTotal
            this.lblTotal.AutoSize = false;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(5, 145);
            this.lblTotal.Size = new System.Drawing.Size(130, 45);
            this.lblTotal.Text = "ВЗЯТО ТОВАРОВ:\n0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(5, 205);
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(5, 243);
            this.btnSubmit.Size = new System.Drawing.Size(130, 30);
            this.btnSubmit.Text = "ОТПРАВИТЬ";
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // panelActions
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Location = new System.Drawing.Point(140, 35);
            this.panelActions.Size = new System.Drawing.Size(960, 45);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(10, 8);
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelFilters
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);
            this.panelFilters.Controls.Add(this.lblSearch);
            this.panelFilters.Controls.Add(this.txtSearch);
            this.panelFilters.Controls.Add(this.lblCategory);
            this.panelFilters.Controls.Add(this.cmbCategory);
            this.panelFilters.Controls.Add(this.lblAvailability);
            this.panelFilters.Controls.Add(this.cmbAvailability);
            this.panelFilters.Controls.Add(this.lblFound);
            this.panelFilters.Controls.Add(this.btnReset);
            this.panelFilters.Location = new System.Drawing.Point(140, 80);
            this.panelFilters.Size = new System.Drawing.Size(960, 75);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSearch.Location = new System.Drawing.Point(10, 8);
            this.lblSearch.Text = "Поиск (название / артикул):";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(10, 25);
            this.txtSearch.Size = new System.Drawing.Size(160, 22);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 8F);
            this.lblCategory.Location = new System.Drawing.Point(185, 8);
            this.lblCategory.Text = "Категория:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(185, 25);
            this.cmbCategory.Size = new System.Drawing.Size(160, 22);
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

            // lblAvailability
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Arial", 8F);
            this.lblAvailability.Location = new System.Drawing.Point(360, 8);
            this.lblAvailability.Text = "Наличие:";

            // cmbAvailability
            this.cmbAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailability.Location = new System.Drawing.Point(360, 25);
            this.cmbAvailability.Size = new System.Drawing.Size(130, 22);

            // lblFound
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFound.Location = new System.Drawing.Point(10, 52);
            this.lblFound.Text = "Найдено: 0 из 0";

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(150, 48);
            this.btnReset.Size = new System.Drawing.Size(80, 22);
            this.btnReset.Text = "Сбросить";
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // dgvShipment
            this.dgvShipment.Location = new System.Drawing.Point(140, 155);
            this.dgvShipment.Size = new System.Drawing.Size(960, 445);
            this.dgvShipment.BackgroundColor = System.Drawing.Color.White;
            this.dgvShipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShipment.RowHeadersVisible = false;
            this.dgvShipment.AllowUserToAddRows = false;
            this.dgvShipment.AllowUserToDeleteRows = false;
            this.dgvShipment.ReadOnly = false;
            this.dgvShipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipment.MultiSelect = false;
            this.dgvShipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShipment.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvShipment.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShipment.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dgvShipment.EnableHeadersVisualStyles = false;
            this.dgvShipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipment_CellClick);

            // ShipmentForm
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.dgvShipment);
            this.Text = "Отгрузка - Кладовщик";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.ShipmentForm_Load);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblShipTitle;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvShipment;
    }
}
