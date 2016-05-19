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
    public partial class ResultForm : Form
    {
        private string _voornaam { get; set; }
        private string _achternaam { get; set; }
        private string _bedrijf { get; set; }
        private double[] _verdient { get; set; }
        private string[] _gewerkt { get; set; }
        private string[] _toeslagnaam { get; set; }
        private double[] _toeslagbedrag { get; set; }
        private string[] _kortingnaam { get; set; }
        private double[] _kortingbedrag { get; set; }
        private double[] _kortingpercentage { get; set; }
        private double[] _toeslagpercentage { get; set; }
        private double _totaalbruto { get; set; }
        private double _totaalnetto { get; set; }
        public ResultForm(string voornaam, string achternaam, string bedrijf, double[] verdient, string[] gewerkturen, double[] toeslagbedrag, string[] toeslagnaam, double[] kortingbedrag, string[] kortingnaam, double[] toeslagpercentage, double[] kortingpercentage)
        {
            InitializeComponent();
            _verdient = new double[4];
            _gewerkt = new string[4];
            _toeslagnaam = new string[3];
            _toeslagbedrag = new double[3];
            _kortingbedrag = new double[3];
            _kortingnaam = new string[3];
            _toeslagpercentage = new double[3];
            _kortingpercentage = new double[3];
            _voornaam = voornaam;
            _achternaam = achternaam;
            _kortingnaam = kortingnaam;
            _kortingbedrag = kortingbedrag;
            _bedrijf = bedrijf;
            _verdient = verdient;
            _gewerkt = gewerkturen;
            _toeslagbedrag = toeslagbedrag;
            _toeslagnaam = toeslagnaam;
            _toeslagpercentage = toeslagpercentage;
            lblToeslagA.Text = "";
            lblToeslagB.Text = "";
            lblToeslagC.Text = "";
            lblBedragA.Text = "";
            lblBedragB.Text = "";
            lblBedragC.Text = "";
            lblPerA.Text = "";
            lblPerB.Text = "";
            lblPerC.Text = "";
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            
            lblvoornaam.Text = _voornaam;
            lblachternaam.Text = _achternaam;
            lblbedrijf.Text = _bedrijf;
            lblbedrag1.Text = "€" + String.Format("{0:n2}", _verdient[0]);
            lblbedrag2.Text = "€" + String.Format("{0:n2}", _verdient[1]);
            lblbedrag3.Text = "€" + String.Format("{0:n2}", _verdient[2]);
            lblbedrag4.Text = "€" + String.Format("{0:n2}", _verdient[3]);
            lblTbedrag.Text = "€" + String.Format("{0:n2}", (_verdient.Sum()));
            double totaal1 = _verdient.Sum();
            lbluren1.Text = _gewerkt[0].ToString();
            lbluren2.Text = _gewerkt[1].ToString();
            lbluren3.Text = _gewerkt[2].ToString();
            lbluren4.Text = _gewerkt[3].ToString();
            //SetPictures();
            Set_Toeslagen();
            Set_Kortingen();
            Calculate_toeslag_perc();
            Calculate_toeslag_bedrag();
            Calculate_korting_Perc();
            Calculate_korting_bedrag();
            Calculate_bruto(_verdient.Sum(), _toeslagbedrag.Sum());
            Calculate_netto(_verdient.Sum(), _toeslagbedrag.Sum(), _kortingbedrag.Sum());
        }
            private void SetPictures()
        {
            if (_bedrijf == "Jumbo Supermarkten")
            {
                pblogo.BackgroundImage = Properties.Resources.jumbo_logo;
            }
            else if (_bedrijf == "Albert Heijn")
            {
                pblogo.BackgroundImage = Properties.Resources.ah_logo;
            }
            else if (_bedrijf == "Hoogvliet")
            {
                pblogo.BackgroundImage = Properties.Resources.hoogvliet_logo;
            }
        }
        private void Calculate_bruto(double totaalA, double totaalB)
        {
            _totaalbruto = totaalA + totaalB;
            lblTbruto.Text = "€" + String.Format("{0:n2}", (_totaalbruto));
        }
        private void Calculate_netto(double TotaalA, double TotaalB, double TotaalC)
        {
            _totaalnetto = (TotaalA + TotaalB) - TotaalC;
            lblTnetto.Text = "€" + String.Format("{0:n2}", (_totaalnetto));
        }
        private void Calculate_toeslag_perc()
        {
            if(_toeslagbedrag[0] > 0)
            {
                _toeslagpercentage[0] = (100 * _toeslagbedrag[0] / _verdient.Sum());
                lblPerA.Text = String.Format("{0:n##}", _toeslagpercentage[0] + "%");
                lblBedragA.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[0]));
            }
            if(_toeslagbedrag[1] > 0)
            {
                _toeslagpercentage[1] = (100 * _toeslagbedrag[1] / _verdient.Sum());
                lblPerB.Text = String.Format("{0:n##}", _toeslagpercentage[1] + "%");
                lblBedragB.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[1]));
            }
            if(_toeslagbedrag[2] > 0)
            {
                _toeslagpercentage[2] = (100 * _toeslagbedrag[2] / _verdient.Sum());
                lblPerC.Text = String.Format("{0:n##}", _toeslagpercentage[2] + "%");
                lblBedragC.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[2]));
            }
        }
        private void Calculate_toeslag_bedrag()
        {
            if (_toeslagpercentage[0] > 0)
            {
                _toeslagbedrag[0] = (_toeslagpercentage[0] * _verdient.Sum() / 100);
                lblPerA.Text = String.Format("{0:n##}", _toeslagpercentage[0] + "%");
                lblBedragA.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[0]));
            }
            if (_toeslagpercentage[1] > 0)
            {
                _toeslagbedrag[1] = (_toeslagpercentage[1] * _verdient.Sum() / 100);
                lblPerB.Text = String.Format("{0:n##}", _toeslagpercentage[1] + "%");
                lblBedragB.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[1]));
            }
            if (_toeslagpercentage[2] > 0)
            {
                _toeslagbedrag[2] = (_toeslagpercentage[2] * _verdient.Sum() / 100);
                lblPerC.Text = String.Format("{0:n##}", _toeslagpercentage[2] + "%");
                lblBedragC.Text = "€" + String.Format("{0:n2}", (_toeslagbedrag[2]));
            }
        }
        private void Calculate_korting_Perc()
        {
            if (_kortingbedrag[0] > 0)
            {
                _kortingpercentage[0] = (100 * _kortingbedrag[0] / _verdient.Sum());
                lblKPerA.Text = String.Format("{0:0,##}", _kortingpercentage[0] + "%");
                lblKBedragA.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[0]));
            }
            if (_kortingbedrag[1] > 0)
            {
                _kortingpercentage[1] = (100 * _kortingbedrag[1] / _verdient.Sum());
                lblKPerB.Text = String.Format("{0:0,##}", _kortingpercentage[1] + "%");
                lblKBedragB.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[1]));
            }
            if (_kortingbedrag[2] > 0)
            {
                _kortingpercentage[2] = (100 * _kortingbedrag[2] / _verdient.Sum());
                lblKPerC.Text = String.Format("{0:0,##}", _kortingpercentage[2] + "%");
                lblKBedragC.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[2]));
            }
        }
        private void Calculate_korting_bedrag()
        {
            if (_toeslagpercentage[0] > 0)
            {
                _kortingbedrag[0] = (_kortingpercentage[0] * _verdient.Sum() / 100);
                lblKPerA.Text = String.Format("{0:0,##}", _kortingpercentage[0] + "%");
                lblKBedragA.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[0]));
            }
            if (_toeslagpercentage[1] > 0)
            {
                _kortingbedrag[1] = (_kortingpercentage[1] * _verdient.Sum() / 100);
                lblKPerB.Text = String.Format("{0:0,##}", _kortingpercentage[1] + "%");
                lblKBedragB.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[1]));
            }
            if (_toeslagpercentage[2] > 0)
            {
                _kortingbedrag[2] = (_kortingpercentage[2] * _verdient.Sum() / 100);
                lblKPerC.Text = String.Format("{0:0,##}", _kortingpercentage[2] + "%");
                lblKBedragC.Text = "€" + String.Format("{0:n2}", (_kortingbedrag[2]));
            }
        }
        private void Set_Kortingen()
        {
            if (_kortingnaam[0].Length <= 0)
            {
                lblKortingA.Visible = false;
                lblKortingB.Visible = false;
                lblKortingC.Visible = false;
                lblKBedragA.Visible = false;
                lblKBedragB.Visible = false;
                lblKBedragC.Visible = false;
            }
            else if (_kortingnaam[1].Length == 0)
            {
                lblKortingA.Text = _kortingnaam[0];
                lblKBedragA.Text = _kortingbedrag[0].ToString();
                lblKortingB.Visible = false;
                lblKortingC.Visible = false;
                lblKBedragB.Visible = false;
                lblKBedragC.Visible = false;
            }
            else if (_toeslagnaam[2].Length <= 0)
            {
                lblKortingA.Text = _kortingnaam[0];
                lblKBedragA.Text = _kortingbedrag[0].ToString();
                lblKortingB.Text = _kortingnaam[1];
                lblKBedragB.Text = _kortingbedrag[1].ToString();
                lblKortingC.Visible = false;
                lblKBedragC.Visible = false;
            }
        }
        private void Set_Toeslagen()
        {
            if (_toeslagnaam[0].Length <= 0)
            {
                lblToeslagA.Visible = false;
                lblToeslagB.Visible = false;
                lblToeslagC.Visible = false;
                lblBedragA.Visible = false;
                lblBedragB.Visible = false;
                lblBedragC.Visible = false;
            }
            else if (_toeslagnaam[1].Length == 0)
            {
                lblToeslagA.Text = _toeslagnaam[0];
                lblBedragA.Text = _toeslagbedrag[0].ToString();
                lblToeslagB.Visible = false;
                lblToeslagC.Visible = false;
                lblBedragB.Visible = false;
                lblBedragC.Visible = false;
            }
            else if (_toeslagnaam[2].Length <= 0)
            {
                lblToeslagA.Text = _toeslagnaam[0];
                lblToeslagB.Text = _toeslagnaam[1];
                lblBedragA.Text = _toeslagbedrag[0].ToString();
                lblBedragB.Text = _toeslagbedrag[1].ToString();
                lblToeslagC.Visible = false;
                lblBedragC.Visible = false;
            }
        }
    }
}

