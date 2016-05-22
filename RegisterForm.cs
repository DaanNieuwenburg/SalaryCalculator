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
    public partial class RegisterForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Voornaam { get; private set; }
        public string Achternaam { get; private set; }
        public string Bedrijf { get; set; }
        public Account new_account { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
            RegisterController register = new RegisterController();
        }

        public void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;
            Voornaam = tbVoornaam.Text;
            Achternaam = tbAchternaam.Text;
            Bedrijf = tbBedrijf.Text;
            if(tbPassword.Text == tbConfirm.Text)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("De wachtwoorden komen niet overeen\nProbeer het opnieuw", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
           
        }
    }
}
