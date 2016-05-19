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
    public partial class PercToeslagForm : Form
    {
        public string Addname { get; private set; }
        public string percentage { get; private set; }
        public PercToeslagForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbToeslagA.Text == "")
            {
                MessageBox.Show("Er is geen naam ingevult voor de toeslag\nVul de waarde aan en probeer het opnieuw", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (tbPercA.Text == "")
            {
                MessageBox.Show("Er is geen waarde ingevult voor het percentage\nVul de waarde aan en probeer het opnieuw", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Addname = tbToeslagA.Text;
                percentage = tbPercA.Text.Replace(".", ",");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void tbPercA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
