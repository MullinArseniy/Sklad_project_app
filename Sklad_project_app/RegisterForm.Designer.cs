
namespace Sklad_project_2
{
    partial class RegisterForm
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
            this.panelReg = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.txtFio = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkStorekeeper = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.panelTop.Controls.Add(this.lblCompany);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Size = new System.Drawing.Size(800, 35);

            // lblCompany
            this.lblCompany.AutoSize = true;
            this.lblCompany.ForeColor = System.Drawing.Color.White;
            this.lblCompany.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompany.Location = new System.Drawing.Point(10, 8);
            this.lblCompany.Text = "ООО \"Птички-тупички\" - система управления складом";

            // panelReg
            this.panelReg.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.panelReg.Controls.Add(this.lblTitle);
            this.panelReg.Controls.Add(this.lblFio);
            this.panelReg.Controls.Add(this.txtFio);
            this.panelReg.Controls.Add(this.lblPassword);
            this.panelReg.Controls.Add(this.txtPassword);
            this.panelReg.Controls.Add(this.lblChoose);
            this.panelReg.Controls.Add(this.chkAdmin);
            this.panelReg.Controls.Add(this.chkStorekeeper);
            this.panelReg.Controls.Add(this.btnRegister);
            this.panelReg.Location = new System.Drawing.Point(270, 100);
            this.panelReg.Size = new System.Drawing.Size(260, 260);

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 12);
            this.lblTitle.Size = new System.Drawing.Size(240, 20);
            this.lblTitle.Text = "РЕГИСТРАЦИЯ В СИСТЕМЕ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblFio
            this.lblFio.AutoSize = true;
            this.lblFio.ForeColor = System.Drawing.Color.White;
            this.lblFio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFio.Location = new System.Drawing.Point(10, 42);
            this.lblFio.Text = "Введите ФИО:";

            // txtFio
            this.txtFio.Location = new System.Drawing.Point(10, 60);
            this.txtFio.Size = new System.Drawing.Size(240, 22);
            this.txtFio.BackColor = System.Drawing.Color.FromArgb(180, 200, 230);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPassword.Location = new System.Drawing.Point(10, 90);
            this.lblPassword.Text = "Введите пароль:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(10, 108);
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(180, 200, 230);

            // lblChoose
            this.lblChoose.AutoSize = true;
            this.lblChoose.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Font = new System.Drawing.Font("Arial", 9F);
            this.lblChoose.Location = new System.Drawing.Point(10, 138);
            this.lblChoose.Text = "Выберите нужное:";

            // chkAdmin
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.ForeColor = System.Drawing.Color.White;
            this.chkAdmin.Font = new System.Drawing.Font("Arial", 9F);
            this.chkAdmin.Location = new System.Drawing.Point(10, 158);
            this.chkAdmin.Text = "Администратор";

            // chkStorekeeper
            this.chkStorekeeper.AutoSize = true;
            this.chkStorekeeper.ForeColor = System.Drawing.Color.White;
            this.chkStorekeeper.Font = new System.Drawing.Font("Arial", 9F);
            this.chkStorekeeper.Location = new System.Drawing.Point(10, 180);
            this.chkStorekeeper.Text = "Кладовщик";

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(10, 215);
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(210, 220, 235);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // RegisterForm
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelReg);
            this.Text = "Регистрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkStorekeeper;
        private System.Windows.Forms.Button btnRegister;
    }
}
