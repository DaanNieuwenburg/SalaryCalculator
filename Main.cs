using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Additions;

namespace Salary_Calculator
{
    public partial class Main : Form
    {
        public Week week1 { get; set; }
        public Week week2 { get; set; }
        public Week week3 { get; set; }
        public Week week4 { get; set; }
        private int totaalverdient { get; set; }
        private double minuutloon { get; set; }
        private bool valid { get; set; }
        private string Voornaam { get; set; }
        private string Achternaam { get; set; }
        public bool netto { get; private set; }
        private string bedrijf { get; set; }
        public double verdientweek1 { get; set; }
        public double verdientweek2 { get; set; }
        public double verdientweek3 { get; set; }
        public double verdientweek4 { get; set; }
        public double[] verdient { get; set; }
        public string[] gewerkteuren { get; set; }
        public string[] toeslagnaam { get; set; }
        public double[] toeslagbedrag { get; set; }
        public string[] kortingnaam { get; set; }
        public double[] kortingbedrag { get; set; }
        public string[] kortingen { get; set; }
        public string[] percentage { get; set; }
        public double[] toeslagpercentage { get; set; }
        public double[] kortingpercentage { get; set; }
        public Main()
        {
            InitializeComponent();
            week1 = new Week();
            week2 = new Week();
            week3 = new Week();
            week4 = new Week();
            valid = false;
            rbBruto.Checked = true;
            verdient = new double[4] { 0, 0, 0, 0 };
            gewerkteuren = new string[4] { "00:00", "00:00", "00:00", "00:00" };
            percentage = new string[3];
            toeslagnaam = new string[3] { "", "", "" };
            toeslagpercentage = new double[3] { 0, 0, 0 };
            kortingpercentage = new double[3] { 0, 0, 0 };
            toeslagbedrag = new double[3];
            kortingnaam = new string[3] { "", "", "" };
            kortingbedrag = new double[3];
            tbbedrijf.Visible = false;
        }

        private void btnweek1_Click(object sender, EventArgs e)
        {
            week1.Text = "Week 1";
            week1.ShowDialog();
            if (week1.DialogResult == DialogResult.Yes)
            {
                TimeSpan gewerkt = new TimeSpan(00, 00, 00);
                gewerkt = gewerkt.Add(week1.totaalmaandag);
                gewerkt = gewerkt.Add(week1.totaaldinsdag);
                gewerkt = gewerkt.Add(week1.totaalwoensdag);
                gewerkt = gewerkt.Add(week1.totaaldonderdag);
                gewerkt = gewerkt.Add(week1.totaalvrijdag);
                gewerkt = gewerkt.Add(week1.totaalzaterdag);
                gewerkt = gewerkt.Add(week1.totaalzondag);
                lblgewerkt1.Text = gewerkt.ToString();
                double temp = gewerkt.TotalMinutes;
                double verdientweek1 = temp * minuutloon;
                verdient[0] = verdientweek1;
                gewerkteuren[0] = lblgewerkt1.Text;
                lblverdient1.Text = "€" + String.Format("{0:n2}", verdient[0]);
            }
        }

        private void btnweek2_Click(object sender, EventArgs e)
        {
            week2.Text = "Week 2";
            week2.ShowDialog();
            if (week2.DialogResult == DialogResult.Yes)
            {
                TimeSpan gewerkt = new TimeSpan(00, 00, 00);
                gewerkt = gewerkt.Add(week2.totaalmaandag);
                gewerkt = gewerkt.Add(week2.totaaldinsdag);
                gewerkt = gewerkt.Add(week2.totaalwoensdag);
                gewerkt = gewerkt.Add(week2.totaaldonderdag);
                gewerkt = gewerkt.Add(week2.totaalvrijdag);
                gewerkt = gewerkt.Add(week2.totaalzaterdag);
                gewerkt = gewerkt.Add(week2.totaalzondag);
                lblgewerkt2.Text = gewerkt.ToString();
                double temp = gewerkt.TotalMinutes;
                double verdientweek2 = temp * minuutloon;
                verdient[1] = verdientweek2;
                gewerkteuren[1] = gewerkt.ToString();
                lblverdient2.Text = "€" + String.Format("{0:n2}", verdientweek2);
            }
        }

        private void btnweek3_Click(object sender, EventArgs e)
        {
            week3.Text = "Week 3";
            week3.ShowDialog();
            if (week3.DialogResult == DialogResult.Yes)
            {
                TimeSpan gewerkt = new TimeSpan(00, 00, 00);
                gewerkt = gewerkt.Add(week3.totaalmaandag);
                gewerkt = gewerkt.Add(week3.totaaldinsdag);
                gewerkt = gewerkt.Add(week3.totaalwoensdag);
                gewerkt = gewerkt.Add(week3.totaaldonderdag);
                gewerkt = gewerkt.Add(week3.totaalvrijdag);
                gewerkt = gewerkt.Add(week3.totaalzaterdag);
                gewerkt = gewerkt.Add(week3.totaalzondag);
                lblgewerkt3.Text = gewerkt.ToString();
                double temp = gewerkt.TotalMinutes;
                double verdientweek3 = temp * minuutloon;
                verdient[2] = verdientweek3;
                gewerkteuren[2] = gewerkt.ToString();
                lblverdient3.Text = "€" + String.Format("{0:n2}", verdientweek3);
            }
        }

        private void btnweek4_Click(object sender, EventArgs e)
        {
            week4.Text = "Week 4";
            week4.ShowDialog();
            if (week4.DialogResult == DialogResult.Yes)
            {
                TimeSpan gewerkt = new TimeSpan(00, 00, 00);
                gewerkt = gewerkt.Add(week4.totaalmaandag);
                gewerkt = gewerkt.Add(week4.totaaldinsdag);
                gewerkt = gewerkt.Add(week4.totaalwoensdag);
                gewerkt = gewerkt.Add(week4.totaaldonderdag);
                gewerkt = gewerkt.Add(week4.totaalvrijdag);
                gewerkt = gewerkt.Add(week4.totaalzaterdag);
                gewerkt = gewerkt.Add(week4.totaalzondag);
                lblgewerkt4.Text = gewerkt.ToString();
                double temp = gewerkt.TotalMinutes;
                double verdientweek4 = temp * minuutloon;
                verdient[3] = verdientweek4;
                gewerkteuren[3] = gewerkt.ToString();
                lblverdient4.Text = "€" + String.Format("{0:n2}", verdientweek4);

            }
        }

        private void rbBruto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBruto.Checked)
            {
                rbNetto.Checked = false;
                netto = false;
            }
        }

        private void rbNetto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNetto.Checked)
            {
                rbBruto.Checked = false;
                netto = true;
            }
        }

        private void txtuurloon_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtuurloon.TextLength > 1)
                minuutloon = (Convert.ToDouble(txtuurloon.Text) / 60);
        }

        private void txtuurloon_Click(object sender, EventArgs e)
        {
            //txtuurloon.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnEurToeslag_Click(object sender, EventArgs e)
        {
            EurToeslagForm _Add = new EurToeslagForm();
            _Add.ShowDialog();
            if (_Add.DialogResult == DialogResult.OK)
            {
                if (lblToeslagA.Text == "")
                {
                    lblToeslagA.Text = _Add.Addname;
                    lblBedragA.Text = "€" + _Add.bedrag;
                    toeslagbedrag[0] = Convert.ToDouble(_Add.bedrag);
                    toeslagnaam[0] = lblToeslagA.Text;
                }
                else if (lblToeslagB.Text == "")
                {
                    lblToeslagB.Text = _Add.Addname;
                    lblBedragB.Text = "€" + _Add.bedrag;
                    toeslagbedrag[1] = Convert.ToDouble(_Add.bedrag);
                    toeslagnaam[1] = lblToeslagB.Text;
                }
                else if (lblToeslagC.Text == "")
                {
                    lblToeslagC.Text = _Add.Addname;
                    lblBedragC.Text = "€" + _Add.bedrag;
                    toeslagbedrag[2] = Convert.ToDouble(_Add.bedrag);
                    toeslagnaam[2] = lblToeslagC.Text;
                }
            }
        }

        private void btnPercToeslag_Click(object sender, EventArgs e)
        {
            PercToeslagForm _Add = new PercToeslagForm();
            _Add.ShowDialog();
            if (_Add.DialogResult == DialogResult.OK)
            {
                if (lblToeslagA.Text == "")
                {
                    lblToeslagA.Text = _Add.Addname;
                    lblBedragA.Text = _Add.percentage + "%";
                    toeslagbedrag[0] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    toeslagpercentage[0] = Convert.ToDouble(_Add.percentage);
                    toeslagnaam[0] = lblToeslagA.Text;
                }
                else if (lblToeslagB.Text == "")
                {
                    lblToeslagB.Text = _Add.Addname;
                    lblBedragB.Text = _Add.percentage + "%";
                    toeslagbedrag[1] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    toeslagpercentage[1] = Convert.ToDouble(_Add.percentage);
                    toeslagnaam[1] = lblToeslagB.Text;
                }
                else if (lblToeslagC.Text == "")
                {
                    lblToeslagC.Text = _Add.Addname;
                    lblBedragC.Text = _Add.percentage + "%";
                    toeslagbedrag[2] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    toeslagpercentage[2] = Convert.ToDouble(_Add.percentage);
                    toeslagnaam[2] = lblToeslagC.Text;
                }
            }
        }

        private void btnEurKorting_Click(object sender, EventArgs e)
        {
            EurToeslagForm _Add = new EurToeslagForm();
            _Add.ShowDialog();
            if (_Add.DialogResult == DialogResult.OK)
            {
                if (lblKortingA.Text == "")
                {
                    lblKortingA.Text = _Add.Addname;
                    lblKBedragA.Text = "€" + _Add.bedrag;
                    kortingbedrag[0] = Convert.ToDouble(_Add.bedrag);
                    kortingnaam[0] = lblKortingA.Text;
                }
                else if (lblKortingB.Text == "")
                {
                    lblKortingB.Text = _Add.Addname;
                    lblKBedragB.Text = "€" + _Add.bedrag;
                    kortingbedrag[1] = Convert.ToDouble(_Add.bedrag);
                    kortingnaam[1] = lblKortingA.Text;
                }
                else if (lblKortingC.Text == "")
                {
                    lblKortingC.Text = _Add.Addname;
                    lblKBedragC.Text = "€" + _Add.bedrag;
                    kortingbedrag[1] = Convert.ToDouble(_Add.bedrag);
                    kortingnaam[1] = lblKortingA.Text;
                }
            }
        }

        private void btnPercKorting_Click(object sender, EventArgs e)
        {
            PercToeslagForm _Add = new PercToeslagForm();
            _Add.ShowDialog();
            if (_Add.DialogResult == DialogResult.OK)
            {
                if (lblKortingA.Text == "")
                {
                    lblKortingA.Text = _Add.Addname;
                    lblKBedragA.Text = _Add.percentage + "%";
                    kortingbedrag[0] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    kortingpercentage[0] = Convert.ToDouble(_Add.percentage);
                    kortingnaam[0] = lblKortingA.Text;
                }
                else if (lblKortingB.Text == "")
                {
                    lblKortingB.Text = _Add.Addname;
                    lblKBedragB.Text = _Add.percentage + "%";
                    kortingbedrag[1] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    kortingpercentage[1] = Convert.ToDouble(_Add.percentage);
                    kortingnaam[1] = lblKortingB.Text;
                }
                else if (lblKortingC.Text == "")
                {
                    lblKortingC.Text = _Add.Addname;
                    lblKBedragC.Text = _Add.percentage + "%";
                    kortingbedrag[2] = Convert.ToDouble(verdient.Sum() * Convert.ToDouble(_Add.percentage) / 100);
                    kortingpercentage[2] = Convert.ToDouble(_Add.percentage);
                    kortingnaam[2] = lblKortingC.Text;
                }
            }
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            Voornaam = tbVoornaam.Text;
            Achternaam = tbAchternaam.Text;
            if(tbbedrijf.Visible == true)
            {
                bedrijf = tbbedrijf.Text;
            }
            ResultForm _result = new ResultForm(Voornaam, Achternaam, bedrijf, verdient, gewerkteuren, toeslagbedrag, toeslagnaam, kortingbedrag, kortingnaam, toeslagpercentage, kortingpercentage);
            _result.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBedrijf.Text == "Jumbo Supermarkten")
            {
                pbLogo.BackgroundImage = Properties.Resources.jumbo_logo;
                bedrijf = cbBedrijf.Text;
                tbbedrijf.Visible = false;
                pbLogo.Visible = true;
            }
            else if (cbBedrijf.Text == "Albert Heijn")
            {
                pbLogo.BackgroundImage = Properties.Resources.ah_logo;
                bedrijf = cbBedrijf.Text;
                tbbedrijf.Visible = false;
                pbLogo.Visible = true;
            }
            else if (cbBedrijf.Text == "Hoogvliet")
            {
                pbLogo.Visible = true;
                pbLogo.BackgroundImage = Properties.Resources.hoogvliet_logo;
                bedrijf = cbBedrijf.Text;
                tbbedrijf.Visible = false;
            }
            else if (cbBedrijf.Text == "Custom")
            {
                pbLogo.Visible = false;
                tbbedrijf.Visible = true;
                bedrijf = tbbedrijf.Text;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginForm _login = new LoginForm();
            _login.Show();
        }
    }
}

