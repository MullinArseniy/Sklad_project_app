namespace SkladApp
{
    partial class StorekeeperCatalogForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.btnMyShipments = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelView = new System.Windows.Forms.Panel();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.lblArticleView = new System.Windows.Forms.Label();
            this.txtArticleView = new System.Windows.Forms.TextBox();
            this.lblNameView = new System.Windows.Forms.Label();
            this.txtNameView = new System.Windows.Forms.TextBox();
            this.lblCategoryView = new System.Windows.Forms.Label();
            this.txtCategoryView = new System.Windows.Forms.TextBox();
            this.lblUnitView = new System.Windows.Forms.Label();
            this.txtUnitView = new System.Windows.Forms.TextBox();
            this.lblPriceView = new System.Windows.Forms.Label();
            this.txtPriceView = new System.Windows.Forms.TextBox();
            this.lblRestView = new System.Windows.Forms.Label();
            this.txtRestView = new System.Windows.Forms.TextBox();
            this.btnCloseView = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.panelTop.Controls.Add(this.lblCompany);
            this.panelTop.Controls.Add(this.lblUserInfo);
            this.panelTop.Controls.Add(this.btnLogout);
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelLeft.Controls.Add(this.btnCatalog);
            this.panelLeft.Controls.Add(this.btnShipment);
            this.panelLeft.Controls.Add(this.btnMyShipments);
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Size = new System.Drawing.Size(140, 565);
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnCatalog
            this.btnCatalog.Location = new System.Drawing.Point(5, 10);
            this.btnCatalog.Size = new System.Drawing.Size(128, 30);
            this.btnCatalog.Text = "Каталог товаров";
            this.btnCatalog.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnCatalog.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);

            // btnShipment
            this.btnShipment.Location = new System.Drawing.Point(5, 48);
            this.btnShipment.Size = new System.Drawing.Size(128, 30);
            this.btnShipment.Text = "Отгрузка";
            this.btnShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);

            // btnMyShipments
            this.btnMyShipments.Location = new System.Drawing.Point(5, 86);
            this.btnMyShipments.Size = new System.Drawing.Size(128, 30);
            this.btnMyShipments.Text = "Мои отгрузки";
            this.btnMyShipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyShipments.Click += new System.EventHandler(this.btnMyShipments_Click);

            // panelActions
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.panelActions.Controls.Add(this.btnView);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Location = new System.Drawing.Point(140, 35);
            this.panelActions.Size = new System.Drawing.Size(960, 45);

            // btnView
            this.btnView.Location = new System.Drawing.Point(10, 8);
            this.btnView.Size = new System.Drawing.Size(100, 28);
            this.btnView.Text = "Просмотреть";
            this.btnView.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(118, 8);
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
            this.panelFilters.Controls.Add(this.lblPrice);
            this.panelFilters.Controls.Add(this.txtPriceFrom);
            this.panelFilters.Controls.Add(this.txtPriceTo);
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
            this.cmbAvailability.SelectedIndexChanged += new System.EventHandler(this.cmbAvailability_SelectedIndexChanged);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 8F);
            this.lblPrice.Location = new System.Drawing.Point(505, 8);
            this.lblPrice.Text = "Цена:";

            // txtPriceFrom
            this.txtPriceFrom.Location = new System.Drawing.Point(505, 25);
            this.txtPriceFrom.Size = new System.Drawing.Size(70, 22);
            this.txtPriceFrom.Text = "0";

            // txtPriceTo
            this.txtPriceTo.Location = new System.Drawing.Point(585, 25);
            this.txtPriceTo.Size = new System.Drawing.Size(70, 22);
            this.txtPriceTo.Text = "1000000";

            // lblFound
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFound.Location = new System.Drawing.Point(10, 52);
            this.lblFound.Text = "Найдено: 0 из 0";

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(120, 50);
            this.btnReset.Size = new System.Drawing.Size(80, 22);
            this.btnReset.Text = "Сбросить";
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // dgvProducts
            this.dgvProducts.Location = new System.Drawing.Point(140, 155);
            this.dgvProducts.Size = new System.Drawing.Size(960, 445);
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.EnableHeadersVisualStyles = false;

            // panelView
            this.panelView.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.panelView.Controls.Add(this.lblPanelTitle);
            this.panelView.Controls.Add(this.lblArticleView);
            this.panelView.Controls.Add(this.txtArticleView);
            this.panelView.Controls.Add(this.lblNameView);
            this.panelView.Controls.Add(this.txtNameView);
            this.panelView.Controls.Add(this.lblCategoryView);
            this.panelView.Controls.Add(this.txtCategoryView);
            this.panelView.Controls.Add(this.lblUnitView);
            this.panelView.Controls.Add(this.txtUnitView);
            this.panelView.Controls.Add(this.lblPriceView);
            this.panelView.Controls.Add(this.txtPriceView);
            this.panelView.Controls.Add(this.lblRestView);
            this.panelView.Controls.Add(this.txtRestView);
            this.panelView.Controls.Add(this.btnCloseView);
            this.panelView.Location = new System.Drawing.Point(0, 155);
            this.panelView.Size = new System.Drawing.Size(140, 445);
            this.panelView.Visible = false;

            // lblPanelTitle
            this.lblPanelTitle.AutoSize = false;
            this.lblPanelTitle.ForeColor = System.Drawing.Color.White;
            this.lblPanelTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.Location = new System.Drawing.Point(5, 8);
            this.lblPanelTitle.Size = new System.Drawing.Size(130, 30);
            this.lblPanelTitle.Text = "ПРОСМОТР ТОВАРА";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblArticleView
            this.lblArticleView.AutoSize = true;
            this.lblArticleView.ForeColor = System.Drawing.Color.White;
            this.lblArticleView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblArticleView.Location = new System.Drawing.Point(5, 42);
            this.lblArticleView.Text = "Артикул:";

            // txtArticleView
            this.txtArticleView.Location = new System.Drawing.Point(5, 58);
            this.txtArticleView.Size = new System.Drawing.Size(130, 22);
            this.txtArticleView.ReadOnly = true;
            this.txtArticleView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtArticleView.ForeColor = System.Drawing.Color.White;
            this.txtArticleView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblNameView
            this.lblNameView.AutoSize = true;
            this.lblNameView.ForeColor = System.Drawing.Color.White;
            this.lblNameView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblNameView.Location = new System.Drawing.Point(5, 86);
            this.lblNameView.Text = "Наименование:";

            // txtNameView
            this.txtNameView.Location = new System.Drawing.Point(5, 102);
            this.txtNameView.Size = new System.Drawing.Size(130, 22);
            this.txtNameView.ReadOnly = true;
            this.txtNameView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtNameView.ForeColor = System.Drawing.Color.White;
            this.txtNameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblCategoryView
            this.lblCategoryView.AutoSize = true;
            this.lblCategoryView.ForeColor = System.Drawing.Color.White;
            this.lblCategoryView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblCategoryView.Location = new System.Drawing.Point(5, 130);
            this.lblCategoryView.Text = "Категория:";

            // txtCategoryView
            this.txtCategoryView.Location = new System.Drawing.Point(5, 146);
            this.txtCategoryView.Size = new System.Drawing.Size(130, 22);
            this.txtCategoryView.ReadOnly = true;
            this.txtCategoryView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtCategoryView.ForeColor = System.Drawing.Color.White;
            this.txtCategoryView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblUnitView
            this.lblUnitView.AutoSize = true;
            this.lblUnitView.ForeColor = System.Drawing.Color.White;
            this.lblUnitView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblUnitView.Location = new System.Drawing.Point(5, 174);
            this.lblUnitView.Text = "Ед. измерения:";

            // txtUnitView
            this.txtUnitView.Location = new System.Drawing.Point(5, 190);
            this.txtUnitView.Size = new System.Drawing.Size(130, 22);
            this.txtUnitView.ReadOnly = true;
            this.txtUnitView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtUnitView.ForeColor = System.Drawing.Color.White;
            this.txtUnitView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPriceView
            this.lblPriceView.AutoSize = true;
            this.lblPriceView.ForeColor = System.Drawing.Color.White;
            this.lblPriceView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblPriceView.Location = new System.Drawing.Point(5, 218);
            this.lblPriceView.Text = "Цена закупки:";

            // txtPriceView
            this.txtPriceView.Location = new System.Drawing.Point(5, 234);
            this.txtPriceView.Size = new System.Drawing.Size(130, 22);
            this.txtPriceView.ReadOnly = true;
            this.txtPriceView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtPriceView.ForeColor = System.Drawing.Color.White;
            this.txtPriceView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblRestView
            this.lblRestView.AutoSize = true;
            this.lblRestView.ForeColor = System.Drawing.Color.White;
            this.lblRestView.Font = new System.Drawing.Font("Arial", 8F);
            this.lblRestView.Location = new System.Drawing.Point(5, 262);
            this.lblRestView.Text = "Остаток:";

            // txtRestView
            this.txtRestView.Location = new System.Drawing.Point(5, 278);
            this.txtRestView.Size = new System.Drawing.Size(130, 22);
            this.txtRestView.ReadOnly = true;
            this.txtRestView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.txtRestView.ForeColor = System.Drawing.Color.White;
            this.txtRestView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnCloseView
            this.btnCloseView.Location = new System.Drawing.Point(5, 315);
            this.btnCloseView.Size = new System.Drawing.Size(130, 28);
            this.btnCloseView.Text = "ЗАКРЫТЬ";
            this.btnCloseView.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCloseView.ForeColor = System.Drawing.Color.White;
            this.btnCloseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);

            // StorekeeperCatalogForm
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.dgvProducts);
            this.Text = "Каталог товаров - Кладовщик";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.StorekeeperCatalogForm_Load);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Button btnMyShipments;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.Label lblArticleView;
        private System.Windows.Forms.TextBox txtArticleView;
        private System.Windows.Forms.Label lblNameView;
        private System.Windows.Forms.TextBox txtNameView;
        private System.Windows.Forms.Label lblCategoryView;
        private System.Windows.Forms.TextBox txtCategoryView;
        private System.Windows.Forms.Label lblUnitView;
        private System.Windows.Forms.TextBox txtUnitView;
        private System.Windows.Forms.Label lblPriceView;
        private System.Windows.Forms.TextBox txtPriceView;
        private System.Windows.Forms.Label lblRestView;
        private System.Windows.Forms.TextBox txtRestView;
        private System.Windows.Forms.Button btnCloseView;
    }
}