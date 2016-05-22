using Salary_Calculator.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class LoginForm : Form
    {
        public string userinput { get; set; }
        public string passinput { get; set; }
        public Account new_account { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            RegisterForm _register = new RegisterForm();
            _register.ShowDialog();
            if (_register.DialogResult == DialogResult.OK)
            {
                RegisterController reg = new RegisterController();
                new_account = new Account();
                new_account.Username = _register.Username;
                new_account.Password = _register.Password;
                new_account.Voornaam = _register.Voornaam;
                new_account.Achternaam = _register.Password;
                new_account.Bedrijf = _register.Bedrijf;
                reg.Addaccount(new_account);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            RegisterController login = new RegisterController();
            userinput = tbUsername.Text;
            passinput = tbPassword.Text;
            login.CheckAccount(userinput, passinput);
            if (login.validated == true)
            {
                MessageBox.Show(login.validated.ToString(), "Login",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(login.validated.ToString(), "Login",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }
    }
}
