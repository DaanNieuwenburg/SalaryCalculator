namespace Salary_Calculator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnprocess = new System.Windows.Forms.Button();
            this.txtuurloon = new System.Windows.Forms.TextBox();
            this.lbluurloon = new System.Windows.Forms.Label();
            this.btnweek1 = new System.Windows.Forms.Button();
            this.btnweek2 = new System.Windows.Forms.Button();
            this.btnweek3 = new System.Windows.Forms.Button();
            this.btnweek4 = new System.Windows.Forms.Button();
            this.lbluren = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgewerkt1 = new System.Windows.Forms.Label();
            this.lblgewerkt2 = new System.Windows.Forms.Label();
            this.lblgewerkt3 = new System.Windows.Forms.Label();
            this.lblgewerkt4 = new System.Windows.Forms.Label();
            this.lblverdient1 = new System.Windows.Forms.Label();
            this.lblverdient2 = new System.Windows.Forms.Label();
            this.lblverdient3 = new System.Windows.Forms.Label();
            this.lblverdient4 = new System.Windows.Forms.Label();
            this.rbBruto = new System.Windows.Forms.RadioButton();
            this.rbNetto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEurToeslag = new System.Windows.Forms.Button();
            this.btnPercToeslag = new System.Windows.Forms.Button();
            this.lblToeslagA = new System.Windows.Forms.Label();
            this.lblToeslagB = new System.Windows.Forms.Label();
            this.lblToeslagC = new System.Windows.Forms.Label();
            this.lblKBedragC = new System.Windows.Forms.Label();
            this.lblKBedragB = new System.Windows.Forms.Label();
            this.lblKortingC = new System.Windows.Forms.Label();
            this.lblKortingB = new System.Windows.Forms.Label();
            this.lblKortingA = new System.Windows.Forms.Label();
            this.btnPercKorting = new System.Windows.Forms.Button();
            this.btnEurKorting = new System.Windows.Forms.Button();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbbedrijf = new System.Windows.Forms.TextBox();
            this.lblKBedragA = new System.Windows.Forms.Label();
            this.lblBedragC = new System.Windows.Forms.Label();
            this.lblBedragB = new System.Windows.Forms.Label();
            this.lblBedragA = new System.Windows.Forms.Label();
            this.cbBedrijf = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(511, 341);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(130, 65);
            this.btnprocess.TabIndex = 0;
            this.btnprocess.Text = "proces";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // txtuurloon
            // 
            this.txtuurloon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtuurloon.Location = new System.Drawing.Point(82, 60);
            this.txtuurloon.Name = "txtuurloon";
            this.txtuurloon.Size = new System.Drawing.Size(70, 20);
            this.txtuurloon.TabIndex = 1;
            this.txtuurloon.Text = "0,00";
            this.txtuurloon.Click += new System.EventHandler(this.txtuurloon_Click);
            this.txtuurloon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuurloon_KeyDown);
            // 
            // lbluurloon
            // 
            this.lbluurloon.AutoSize = true;
            this.lbluurloon.Location = new System.Drawing.Point(12, 63);
            this.lbluurloon.Name = "lbluurloon";
            this.lbluurloon.Size = new System.Drawing.Size(47, 13);
            this.lbluurloon.TabIndex = 2;
            this.lbluurloon.Text = "Uurloon:";
            // 
            // btnweek1
            // 
            this.btnweek1.Location = new System.Drawing.Point(107, 101);
            this.btnweek1.Name = "btnweek1";
            this.btnweek1.Size = new System.Drawing.Size(75, 23);
            this.btnweek1.TabIndex = 3;
            this.btnweek1.Text = "Week 1";
            this.btnweek1.UseVisualStyleBackColor = true;
            this.btnweek1.Click += new System.EventHandler(this.btnweek1_Click);
            // 
            // btnweek2
            // 
            this.btnweek2.Location = new System.Drawing.Point(225, 101);
            this.btnweek2.Name = "btnweek2";
            this.btnweek2.Size = new System.Drawing.Size(75, 23);
            this.btnweek2.TabIndex = 4;
            this.btnweek2.Text = "Week 2";
            this.btnweek2.UseVisualStyleBackColor = true;
            this.btnweek2.Click += new System.EventHandler(this.btnweek2_Click);
            // 
            // btnweek3
            // 
            this.btnweek3.Location = new System.Drawing.Point(350, 101);
            this.btnweek3.Name = "btnweek3";
            this.btnweek3.Size = new System.Drawing.Size(75, 23);
            this.btnweek3.TabIndex = 5;
            this.btnweek3.Text = "Week 3";
            this.btnweek3.UseVisualStyleBackColor = true;
            this.btnweek3.Click += new System.EventHandler(this.btnweek3_Click);
            // 
            // btnweek4
            // 
            this.btnweek4.Location = new System.Drawing.Point(477, 101);
            this.btnweek4.Name = "btnweek4";
            this.btnweek4.Size = new System.Drawing.Size(75, 23);
            this.btnweek4.TabIndex = 6;
            this.btnweek4.Text = "Week 4";
            this.btnweek4.UseVisualStyleBackColor = true;
            this.btnweek4.Click += new System.EventHandler(this.btnweek4_Click);
            // 
            // lbluren
            // 
            this.lbluren.AutoSize = true;
            this.lbluren.Location = new System.Drawing.Point(12, 152);
            this.lbluren.Name = "lbluren";
            this.lbluren.Size = new System.Drawing.Size(74, 13);
            this.lbluren.TabIndex = 7;
            this.lbluren.Text = "Uren gewerkt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Verdient:";
            // 
            // lblgewerkt1
            // 
            this.lblgewerkt1.AutoSize = true;
            this.lblgewerkt1.Location = new System.Drawing.Point(108, 152);
            this.lblgewerkt1.Name = "lblgewerkt1";
            this.lblgewerkt1.Size = new System.Drawing.Size(34, 13);
            this.lblgewerkt1.TabIndex = 9;
            this.lblgewerkt1.Text = "00:00";
            // 
            // lblgewerkt2
            // 
            this.lblgewerkt2.AutoSize = true;
            this.lblgewerkt2.Location = new System.Drawing.Point(222, 152);
            this.lblgewerkt2.Name = "lblgewerkt2";
            this.lblgewerkt2.Size = new System.Drawing.Size(34, 13);
            this.lblgewerkt2.TabIndex = 10;
            this.lblgewerkt2.Text = "00:00";
            // 
            // lblgewerkt3
            // 
            this.lblgewerkt3.AutoSize = true;
            this.lblgewerkt3.Location = new System.Drawing.Point(351, 152);
            this.lblgewerkt3.Name = "lblgewerkt3";
            this.lblgewerkt3.Size = new System.Drawing.Size(34, 13);
            this.lblgewerkt3.TabIndex = 11;
            this.lblgewerkt3.Text = "00:00";
            // 
            // lblgewerkt4
            // 
            this.lblgewerkt4.AutoSize = true;
            this.lblgewerkt4.Location = new System.Drawing.Point(478, 152);
            this.lblgewerkt4.Name = "lblgewerkt4";
            this.lblgewerkt4.Size = new System.Drawing.Size(34, 13);
            this.lblgewerkt4.TabIndex = 12;
            this.lblgewerkt4.Text = "00:00";
            // 
            // lblverdient1
            // 
            this.lblverdient1.AutoSize = true;
            this.lblverdient1.Location = new System.Drawing.Point(108, 198);
            this.lblverdient1.Name = "lblverdient1";
            this.lblverdient1.Size = new System.Drawing.Size(34, 13);
            this.lblverdient1.TabIndex = 13;
            this.lblverdient1.Text = "€0,00";
            // 
            // lblverdient2
            // 
            this.lblverdient2.AutoSize = true;
            this.lblverdient2.Location = new System.Drawing.Point(222, 198);
            this.lblverdient2.Name = "lblverdient2";
            this.lblverdient2.Size = new System.Drawing.Size(34, 13);
            this.lblverdient2.TabIndex = 14;
            this.lblverdient2.Text = "€0,00";
            // 
            // lblverdient3
            // 
            this.lblverdient3.AutoSize = true;
            this.lblverdient3.Location = new System.Drawing.Point(351, 198);
            this.lblverdient3.Name = "lblverdient3";
            this.lblverdient3.Size = new System.Drawing.Size(34, 13);
            this.lblverdient3.TabIndex = 15;
            this.lblverdient3.Text = "€0,00";
            // 
            // lblverdient4
            // 
            this.lblverdient4.AutoSize = true;
            this.lblverdient4.Location = new System.Drawing.Point(478, 198);
            this.lblverdient4.Name = "lblverdient4";
            this.lblverdient4.Size = new System.Drawing.Size(34, 13);
            this.lblverdient4.TabIndex = 16;
            this.lblverdient4.Text = "€0,00";
            // 
            // rbBruto
            // 
            this.rbBruto.AutoSize = true;
            this.rbBruto.Location = new System.Drawing.Point(455, 343);
            this.rbBruto.Name = "rbBruto";
            this.rbBruto.Size = new System.Drawing.Size(50, 17);
            this.rbBruto.TabIndex = 17;
            this.rbBruto.TabStop = true;
            this.rbBruto.Text = "Bruto";
            this.rbBruto.UseVisualStyleBackColor = true;
            this.rbBruto.CheckedChanged += new System.EventHandler(this.rbBruto_CheckedChanged);
            // 
            // rbNetto
            // 
            this.rbNetto.AutoSize = true;
            this.rbNetto.Location = new System.Drawing.Point(455, 367);
            this.rbNetto.Name = "rbNetto";
            this.rbNetto.Size = new System.Drawing.Size(51, 17);
            this.rbNetto.TabIndex = 18;
            this.rbNetto.TabStop = true;
            this.rbNetto.Text = "Netto";
            this.rbNetto.UseVisualStyleBackColor = true;
            this.rbNetto.CheckedChanged += new System.EventHandler(this.rbNetto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Toeslag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Korting";
            // 
            // btnEurToeslag
            // 
            this.btnEurToeslag.Location = new System.Drawing.Point(11, 291);
            this.btnEurToeslag.Name = "btnEurToeslag";
            this.btnEurToeslag.Size = new System.Drawing.Size(30, 23);
            this.btnEurToeslag.TabIndex = 21;
            this.btnEurToeslag.Text = "€";
            this.btnEurToeslag.UseVisualStyleBackColor = true;
            this.btnEurToeslag.Click += new System.EventHandler(this.btnEurToeslag_Click);
            // 
            // btnPercToeslag
            // 
            this.btnPercToeslag.Location = new System.Drawing.Point(47, 291);
            this.btnPercToeslag.Name = "btnPercToeslag";
            this.btnPercToeslag.Size = new System.Drawing.Size(30, 23);
            this.btnPercToeslag.TabIndex = 22;
            this.btnPercToeslag.Text = "%";
            this.btnPercToeslag.UseVisualStyleBackColor = true;
            this.btnPercToeslag.Click += new System.EventHandler(this.btnPercToeslag_Click);
            // 
            // lblToeslagA
            // 
            this.lblToeslagA.AutoSize = true;
            this.lblToeslagA.Location = new System.Drawing.Point(11, 317);
            this.lblToeslagA.Name = "lblToeslagA";
            this.lblToeslagA.Size = new System.Drawing.Size(0, 13);
            this.lblToeslagA.TabIndex = 23;
            // 
            // lblToeslagB
            // 
            this.lblToeslagB.AutoSize = true;
            this.lblToeslagB.Location = new System.Drawing.Point(11, 343);
            this.lblToeslagB.Name = "lblToeslagB";
            this.lblToeslagB.Size = new System.Drawing.Size(0, 13);
            this.lblToeslagB.TabIndex = 24;
            // 
            // lblToeslagC
            // 
            this.lblToeslagC.AutoSize = true;
            this.lblToeslagC.Location = new System.Drawing.Point(12, 365);
            this.lblToeslagC.Name = "lblToeslagC";
            this.lblToeslagC.Size = new System.Drawing.Size(0, 13);
            this.lblToeslagC.TabIndex = 25;
            // 
            // lblKBedragC
            // 
            this.lblKBedragC.AutoSize = true;
            this.lblKBedragC.Location = new System.Drawing.Point(372, 365);
            this.lblKBedragC.Name = "lblKBedragC";
            this.lblKBedragC.Size = new System.Drawing.Size(0, 13);
            this.lblKBedragC.TabIndex = 35;
            // 
            // lblKBedragB
            // 
            this.lblKBedragB.AutoSize = true;
            this.lblKBedragB.Location = new System.Drawing.Point(372, 343);
            this.lblKBedragB.Name = "lblKBedragB";
            this.lblKBedragB.Size = new System.Drawing.Size(0, 13);
            this.lblKBedragB.TabIndex = 34;
            // 
            // lblKortingC
            // 
            this.lblKortingC.AutoSize = true;
            this.lblKortingC.Location = new System.Drawing.Point(246, 365);
            this.lblKortingC.Name = "lblKortingC";
            this.lblKortingC.Size = new System.Drawing.Size(0, 13);
            this.lblKortingC.TabIndex = 32;
            // 
            // lblKortingB
            // 
            this.lblKortingB.AutoSize = true;
            this.lblKortingB.Location = new System.Drawing.Point(245, 343);
            this.lblKortingB.Name = "lblKortingB";
            this.lblKortingB.Size = new System.Drawing.Size(0, 13);
            this.lblKortingB.TabIndex = 31;
            // 
            // lblKortingA
            // 
            this.lblKortingA.AutoSize = true;
            this.lblKortingA.Location = new System.Drawing.Point(245, 317);
            this.lblKortingA.Name = "lblKortingA";
            this.lblKortingA.Size = new System.Drawing.Size(0, 13);
            this.lblKortingA.TabIndex = 30;
            // 
            // btnPercKorting
            // 
            this.btnPercKorting.Location = new System.Drawing.Point(270, 291);
            this.btnPercKorting.Name = "btnPercKorting";
            this.btnPercKorting.Size = new System.Drawing.Size(30, 23);
            this.btnPercKorting.TabIndex = 37;
            this.btnPercKorting.Text = "%";
            this.btnPercKorting.UseVisualStyleBackColor = true;
            this.btnPercKorting.Click += new System.EventHandler(this.btnPercKorting_Click);
            // 
            // btnEurKorting
            // 
            this.btnEurKorting.Location = new System.Drawing.Point(234, 291);
            this.btnEurKorting.Name = "btnEurKorting";
            this.btnEurKorting.Size = new System.Drawing.Size(30, 23);
            this.btnEurKorting.TabIndex = 36;
            this.btnEurKorting.Text = "€";
            this.btnEurKorting.UseVisualStyleBackColor = true;
            this.btnEurKorting.Click += new System.EventHandler(this.btnEurKorting_Click);
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(82, 8);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(100, 20);
            this.tbVoornaam.TabIndex = 38;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(82, 34);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 20);
            this.tbAchternaam.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Voornaam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Achternaam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Bedrijf:";
            // 
            // tbbedrijf
            // 
            this.tbbedrijf.Location = new System.Drawing.Point(258, 34);
            this.tbbedrijf.Name = "tbbedrijf";
            this.tbbedrijf.Size = new System.Drawing.Size(100, 20);
            this.tbbedrijf.TabIndex = 42;
            // 
            // lblKBedragA
            // 
            this.lblKBedragA.AutoSize = true;
            this.lblKBedragA.Location = new System.Drawing.Point(372, 317);
            this.lblKBedragA.Name = "lblKBedragA";
            this.lblKBedragA.Size = new System.Drawing.Size(0, 13);
            this.lblKBedragA.TabIndex = 33;
            // 
            // lblBedragC
            // 
            this.lblBedragC.AutoSize = true;
            this.lblBedragC.Location = new System.Drawing.Point(138, 365);
            this.lblBedragC.Name = "lblBedragC";
            this.lblBedragC.Size = new System.Drawing.Size(0, 13);
            this.lblBedragC.TabIndex = 29;
            // 
            // lblBedragB
            // 
            this.lblBedragB.AutoSize = true;
            this.lblBedragB.Location = new System.Drawing.Point(138, 343);
            this.lblBedragB.Name = "lblBedragB";
            this.lblBedragB.Size = new System.Drawing.Size(0, 13);
            this.lblBedragB.TabIndex = 28;
            // 
            // lblBedragA
            // 
            this.lblBedragA.AutoSize = true;
            this.lblBedragA.Location = new System.Drawing.Point(138, 317);
            this.lblBedragA.Name = "lblBedragA";
            this.lblBedragA.Size = new System.Drawing.Size(0, 13);
            this.lblBedragA.TabIndex = 26;
            // 
            // cbBedrijf
            // 
            this.cbBedrijf.FormattingEnabled = true;
            this.cbBedrijf.Items.AddRange(new object[] {
            "Jumbo Supermarkten",
            "Albert Heijn",
            "Hoogvliet",
            "Custom"});
            this.cbBedrijf.Location = new System.Drawing.Point(258, 7);
            this.cbBedrijf.Name = "cbBedrijf";
            this.cbBedrijf.Size = new System.Drawing.Size(100, 21);
            this.cbBedrijf.TabIndex = 44;
            this.cbBedrijf.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(406, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(154, 50);
            this.pbLogo.TabIndex = 45;
            this.pbLogo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 485);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbBedrijf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbbedrijf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.btnPercKorting);
            this.Controls.Add(this.btnEurKorting);
            this.Controls.Add(this.lblKBedragC);
            this.Controls.Add(this.lblKBedragB);
            this.Controls.Add(this.lblKBedragA);
            this.Controls.Add(this.lblKortingC);
            this.Controls.Add(this.lblKortingB);
            this.Controls.Add(this.lblKortingA);
            this.Controls.Add(this.lblBedragC);
            this.Controls.Add(this.lblBedragB);
            this.Controls.Add(this.lblBedragA);
            this.Controls.Add(this.lblToeslagC);
            this.Controls.Add(this.lblToeslagB);
            this.Controls.Add(this.lblToeslagA);
            this.Controls.Add(this.btnPercToeslag);
            this.Controls.Add(this.btnEurToeslag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbNetto);
            this.Controls.Add(this.rbBruto);
            this.Controls.Add(this.lblverdient4);
            this.Controls.Add(this.lblverdient3);
            this.Controls.Add(this.lblverdient2);
            this.Controls.Add(this.lblverdient1);
            this.Controls.Add(this.lblgewerkt4);
            this.Controls.Add(this.lblgewerkt3);
            this.Controls.Add(this.lblgewerkt2);
            this.Controls.Add(this.lblgewerkt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluren);
            this.Controls.Add(this.btnweek4);
            this.Controls.Add(this.btnweek3);
            this.Controls.Add(this.btnweek2);
            this.Controls.Add(this.btnweek1);
            this.Controls.Add(this.lbluurloon);
            this.Controls.Add(this.txtuurloon);
            this.Controls.Add(this.btnprocess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.TextBox txtuurloon;
        private System.Windows.Forms.Label lbluurloon;
        private System.Windows.Forms.Button btnweek1;
        private System.Windows.Forms.Button btnweek2;
        private System.Windows.Forms.Button btnweek3;
        private System.Windows.Forms.Button btnweek4;
        private System.Windows.Forms.Label lbluren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgewerkt1;
        private System.Windows.Forms.Label lblgewerkt2;
        private System.Windows.Forms.Label lblgewerkt3;
        private System.Windows.Forms.Label lblgewerkt4;
        private System.Windows.Forms.Label lblverdient1;
        private System.Windows.Forms.Label lblverdient2;
        private System.Windows.Forms.Label lblverdient3;
        private System.Windows.Forms.Label lblverdient4;
        private System.Windows.Forms.RadioButton rbBruto;
        private System.Windows.Forms.RadioButton rbNetto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEurToeslag;
        private System.Windows.Forms.Button btnPercToeslag;
        private System.Windows.Forms.Label lblToeslagA;
        private System.Windows.Forms.Label lblToeslagB;
        private System.Windows.Forms.Label lblToeslagC;
        private System.Windows.Forms.Label lblKBedragC;
        private System.Windows.Forms.Label lblKBedragB;
        private System.Windows.Forms.Label lblKortingC;
        private System.Windows.Forms.Label lblKortingB;
        private System.Windows.Forms.Label lblKortingA;
        private System.Windows.Forms.Button btnPercKorting;
        private System.Windows.Forms.Button btnEurKorting;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbbedrijf;
        private System.Windows.Forms.Label lblKBedragA;
        private System.Windows.Forms.Label lblBedragC;
        private System.Windows.Forms.Label lblBedragB;
        private System.Windows.Forms.Label lblBedragA;
        private System.Windows.Forms.ComboBox cbBedrijf;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

