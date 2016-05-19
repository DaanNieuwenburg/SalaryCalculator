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
    public partial class Week : Form
    {
        public TimeSpan totaalmaandag { get; private set; }
        public TimeSpan totaaldinsdag { get; private set; }
        public TimeSpan totaalwoensdag { get; private set; }
        public TimeSpan totaaldonderdag { get; private set; }
        public TimeSpan totaalvrijdag { get; private set; }
        public TimeSpan totaalzaterdag { get; private set; }
        public TimeSpan totaalzondag { get; private set; }
        private string begintijdma { get; set; }
        private string totaanma { get; set; }
        public Week()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TimeSpan A;
            TimeSpan B;
            TimeSpan C;
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    TimeSpan.TryParse(txtvanma.Text, out A);
                    TimeSpan.TryParse(txttotma.Text, out B);
                    TimeSpan.TryParse(txtpauzema.Text, out C);
                    totaalmaandag = (B - A) - C;
                    if (cbma.CheckState == CheckState.Checked)
                        totaalmaandag = totaalmaandag.Multiply(2);
                }
                else if(i == 1)
                {
                    TimeSpan.TryParse(txtvandi.Text, out A);
                    TimeSpan.TryParse(txttotdi.Text, out B);
                    TimeSpan.TryParse(txtpauzedi.Text, out C);
                    totaaldinsdag = (B - A) - C;
                    if (cbdi.CheckState == CheckState.Checked)
                        totaaldinsdag = totaaldinsdag.Multiply(2);
                }
                else if (i == 2)
                {
                    TimeSpan.TryParse(txtvanwo.Text, out A);
                    TimeSpan.TryParse(txttotwo.Text, out B);
                    TimeSpan.TryParse(txtpauzewo.Text, out C);
                    totaalwoensdag = (B - A) - C;
                    if (cbwo.CheckState == CheckState.Checked)
                        totaalwoensdag = totaalwoensdag.Multiply(2);
                }
                else if (i == 3)
                {
                    TimeSpan.TryParse(txtvando.Text, out A);
                    TimeSpan.TryParse(txttotdo.Text, out B);
                    TimeSpan.TryParse(txtpauzedo.Text, out C);
                    totaaldonderdag = (B - A) - C;
                    if (cbdo.CheckState == CheckState.Checked)
                        totaaldonderdag = totaaldonderdag.Multiply(2);
                }
                else if (i == 4)
                {
                    TimeSpan.TryParse(txtvanvr.Text, out A);
                    TimeSpan.TryParse(txttotvr.Text, out B);
                    TimeSpan.TryParse(txtpauzevr.Text, out C);
                    totaalvrijdag = (B - A) - C;
                    if (cbvr.CheckState == CheckState.Checked)
                        totaalvrijdag = totaalvrijdag.Multiply(2);
                }
                else if (i == 5)
                {
                    TimeSpan.TryParse(txtvanza.Text, out A);
                    TimeSpan.TryParse(txttotza.Text, out B);
                    TimeSpan.TryParse(txtpauzeza.Text, out C);
                    totaalzaterdag = (B - A) - C;
                    if (cbza.CheckState == CheckState.Checked)
                        totaalzaterdag = totaalzaterdag.Multiply(2);
                }
                else if (i == 6)
                {
                    TimeSpan.TryParse(txtvanzo.Text, out A);
                    TimeSpan.TryParse(txttotzo.Text, out B);
                    TimeSpan.TryParse(txtpauzezo.Text, out C);
                    totaalzondag = (B - A) - C;
                    if (cbzo.CheckState == CheckState.Checked)
                        totaalzondag = totaalzondag.Multiply(2);
                }
            }
            
            DialogResult = DialogResult.Yes;
            
        }

        private void txtvanma_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan vanma;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvanma.Text.ToString(), out vanma))
            {
                txtvanma.ForeColor = Color.Black;        
            }
            else
            {
                txtvanma.ForeColor = Color.Red;
            }
        }

        private void txttotma_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totma;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotma.Text.ToString(), out totma))
            {
                txttotma.ForeColor = Color.Black;
            }
            else
            {
                txttotma.ForeColor = Color.Red;
            }
        }

        private void txtvandi_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vandi;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvandi.Text.ToString(), out vandi))
            {
                txtvandi.ForeColor = Color.Black;
            }
            else
            {
                txtvandi.ForeColor = Color.Red;
            }
        }

        private void txttotdi_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totdi;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotdi.Text.ToString(), out totdi))
            {
                txttotdi.ForeColor = Color.Black;
            }
            else
            {
                txttotdi.ForeColor = Color.Red;
            }
        }

        private void txtvanwo_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vanwo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvanwo.Text.ToString(), out vanwo))
            {
                txtvanwo.ForeColor = Color.Black;
            }
            else
            {
                txtvanwo.ForeColor = Color.Red;
            }
        }

        private void txttotwo_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totwo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotwo.Text.ToString(), out totwo))
            {
                txttotwo.ForeColor = Color.Black;
            }
            else
            {
                txttotwo.ForeColor = Color.Red;
            }
        }

        private void txtvando_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vando;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvando.Text.ToString(), out vando))
            {
                txtvando.ForeColor = Color.Black;
            }
            else
            {
                txtvando.ForeColor = Color.Red;
            }
        }

        private void txttotdo_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totdo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotdo.Text.ToString(), out totdo))
            {
                txttotdo.ForeColor = Color.Black;
            }
            else
            {
                txttotdo.ForeColor = Color.Red;
            }
        }

        private void txtvanvr_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vanvr;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvanvr.Text.ToString(), out vanvr))
            {
                txtvanvr.ForeColor = Color.Black;
            }
            else
            {
                txtvanvr.ForeColor = Color.Red;
            }
        }

        private void txttotvr_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totvr;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotvr.Text.ToString(), out totvr))
            {
                txttotvr.ForeColor = Color.Black;
            }
            else
            {
                txttotvr.ForeColor = Color.Red;
            }
        }

        private void txtvanza_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vanza;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvanza.Text.ToString(), out vanza))
            {
                txtvanza.ForeColor = Color.Black;
            }
            else
            {
                txtvanza.ForeColor = Color.Red;
            }
        }

        private void txttotza_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totza;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotza.Text.ToString(), out totza))
            {
                txttotza.ForeColor = Color.Black;
            }
            else
            {
                txttotza.ForeColor = Color.Red;
            }
        }

        private void txtvanzo_TextChanged(object sender, EventArgs e)
        {
            TimeSpan vanzo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtvanzo.Text.ToString(), out vanzo))
            {
                txtvanzo.ForeColor = Color.Black;
            }
            else
            {
                txtvanzo.ForeColor = Color.Red;
            }
        }

        private void txttotzo_TextChanged(object sender, EventArgs e)
        {
            TimeSpan totzo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txttotzo.Text.ToString(), out totzo))
            {
                txttotzo.ForeColor = Color.Black;
            }
            else
            {
                txttotzo.ForeColor = Color.Red;
            }
        }

        private void txtpauzema_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzema;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzema.Text.ToString(), out pauzema))
            {
                txtpauzema.ForeColor = Color.Black;
            }
            else
            {
                txtpauzema.ForeColor = Color.Red;
            }
        }

        private void txtpauzedi_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzedi;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzedi.Text.ToString(), out pauzedi))
            {
                txtpauzedi.ForeColor = Color.Black;
            }
            else
            {
                txtpauzedi.ForeColor = Color.Red;
            }
        }

        private void txtpauzewo_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzewo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzewo.Text.ToString(), out pauzewo))
            {
                txtpauzewo.ForeColor = Color.Black;
            }
            else
            {
                txtpauzewo.ForeColor = Color.Red;
            }
        }
        private void txtpauzedo_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzedo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzedo.Text.ToString(), out pauzedo))
            {
                txtpauzedo.ForeColor = Color.Black;
            }
            else
            {
                txtpauzedo.ForeColor = Color.Red;
            }
        }
        private void txtpauzevr_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzevr;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzevr.Text.ToString(), out pauzevr))
            {
                txtpauzevr.ForeColor = Color.Black;
            }
            else
            {
                txtpauzevr.ForeColor = Color.Red;
            }
        }
        private void txtpauzeza_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzeza;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzeza.Text.ToString(), out pauzeza))
            {
                txtpauzeza.ForeColor = Color.Black;
            }
            else
            {
                txtpauzeza.ForeColor = Color.Red;
            }
        }
        private void txtpauzezo_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan pauzezo;
            //string input = String.Format("{0:HH:mm}");
            if (TimeSpan.TryParse(txtpauzezo.Text.ToString(), out pauzezo))
            {
                txtpauzezo.ForeColor = Color.Black;
            }
            else
            {
                txtpauzezo.ForeColor = Color.Red;
            }
        }

        private void cbma_CheckedChanged(object sender, EventArgs e)
        {
            if(cbma.Checked == true)
            totaalmaandag = totaalmaandag.Multiply(2);
        }

        private void cbdi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaaldinsdag = totaaldinsdag.Multiply(2);
        }

        private void cbwo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaalwoensdag = totaalwoensdag.Multiply(2);
        }

        private void cbdo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaaldonderdag = totaaldonderdag.Multiply(2);
        }

        private void cbvr_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaalvrijdag = totaalvrijdag.Multiply(2);
        }

        private void cbza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaalzaterdag = totaalzaterdag.Multiply(2);
        }

        private void cbzo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbma.Checked)
                totaalzondag = totaalzondag.Multiply(2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
