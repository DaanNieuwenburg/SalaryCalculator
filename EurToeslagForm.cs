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
    public partial class EurToeslagForm : Form
    {
        public string Addname { get; private set; }
        public string bedrag { get; private set; }
        public EurToeslagForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbToeslagA.Text == "")
            {
                MessageBox.Show("Er is geen naam ingevult voor de toeslag\nVul de waarde aan en probeer het opnieuw", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (mtbToeslagA.Text == "  ,")
            {
                MessageBox.Show("Er is geen waarde ingevult voor het bedrag\nVul de waarde aan en probeer het opnieuw", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Addname = tbToeslagA.Text;
                bedrag = mtbToeslagA.Text;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
