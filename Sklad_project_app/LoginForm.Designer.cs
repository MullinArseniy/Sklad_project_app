namespace Sklad_project_2
{
    partial class LoginForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelLogin.SuspendLayout();
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

            // panelLogin
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.lblLoginName);
            this.panelLogin.Controls.Add(this.txtLogin);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Location = new System.Drawing.Point(270, 120);
            this.panelLogin.Size = new System.Drawing.Size(260, 230);

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 15);
            this.lblTitle.Size = new System.Drawing.Size(240, 20);
            this.lblTitle.Text = "ВХОД В СИСТЕМУ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLoginName
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Font = new System.Drawing.Font("Arial", 9F);
            this.lblLoginName.Location = new System.Drawing.Point(10, 45);
            this.lblLoginName.Text = "ФИО пользователя:";

            // txtLogin
            this.txtLogin.Location = new System.Drawing.Point(10, 65);
            this.txtLogin.Size = new System.Drawing.Size(240, 22);
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(180, 200, 230);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPassword.Location = new System.Drawing.Point(10, 95);
            this.lblPassword.Text = "Пароль:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(10, 115);
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(180, 200, 230);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(10, 150);
            this.btnLogin.Size = new System.Drawing.Size(80, 28);
            this.btnLogin.Text = "Войти";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(210, 220, 235);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(10, 188);
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(210, 220, 235);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLogin);
            this.Text = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}