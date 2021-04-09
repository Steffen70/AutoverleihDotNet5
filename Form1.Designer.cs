namespace Autoverleih
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAbrechnen = new System.Windows.Forms.Button();
            this.Ausgeliehen = new System.Windows.Forms.ListBox();
            this.buchungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AutoRemove = new System.Windows.Forms.ListBox();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAutoAdd = new System.Windows.Forms.Button();
            this.BtnAutoRemove = new System.Windows.Forms.Button();
            this.TextPreis = new Autoverleih.HintedTextBox();
            this.TextAutonummer = new Autoverleih.HintedTextBox();
            this.TextTyp = new Autoverleih.HintedTextBox();
            this.TextHersteller = new Autoverleih.HintedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UserRemove = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUserAdd = new System.Windows.Forms.Button();
            this.BtnUserRemove = new System.Windows.Forms.Button();
            this.TextEmail = new Autoverleih.HintedTextBox();
            this.TextVorname = new Autoverleih.HintedTextBox();
            this.TextName = new Autoverleih.HintedTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnBuchen = new System.Windows.Forms.Button();
            this.UserAuswahl = new System.Windows.Forms.ListBox();
            this.AutoAuswahl = new System.Windows.Forms.ListBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.chflabel = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buchungBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAbrechnen);
            this.tabPage4.Controls.Add(this.Ausgeliehen);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(336, 388);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAbrechnen
            // 
            this.btnAbrechnen.Location = new System.Drawing.Point(253, 362);
            this.btnAbrechnen.Name = "btnAbrechnen";
            this.btnAbrechnen.Size = new System.Drawing.Size(75, 23);
            this.btnAbrechnen.TabIndex = 19;
            this.btnAbrechnen.Text = "Abrechnen";
            this.btnAbrechnen.UseVisualStyleBackColor = true;
            this.btnAbrechnen.Click += new System.EventHandler(this.btnAbrechnen_Click);
            // 
            // Ausgeliehen
            // 
            this.Ausgeliehen.DataSource = this.buchungBindingSource;
            this.Ausgeliehen.DisplayMember = "Autonummer";
            this.Ausgeliehen.FormattingEnabled = true;
            this.Ausgeliehen.HorizontalScrollbar = true;
            this.Ausgeliehen.Location = new System.Drawing.Point(6, 9);
            this.Ausgeliehen.Name = "Ausgeliehen";
            this.Ausgeliehen.Size = new System.Drawing.Size(322, 342);
            this.Ausgeliehen.TabIndex = 18;
            this.Ausgeliehen.ValueMember = "Anzeige";
            // 
            // buchungBindingSource
            // 
            this.buchungBindingSource.DataSource = typeof(Autoverleih.Buchung);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chflabel);
            this.tabPage3.Controls.Add(this.AutoRemove);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.BtnAutoAdd);
            this.tabPage3.Controls.Add(this.BtnAutoRemove);
            this.tabPage3.Controls.Add(this.TextPreis);
            this.tabPage3.Controls.Add(this.TextAutonummer);
            this.tabPage3.Controls.Add(this.TextTyp);
            this.tabPage3.Controls.Add(this.TextHersteller);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(336, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AutoRemove
            // 
            this.AutoRemove.DataSource = this.autoBindingSource;
            this.AutoRemove.DisplayMember = "Autonummer";
            this.AutoRemove.FormattingEnabled = true;
            this.AutoRemove.Location = new System.Drawing.Point(8, 169);
            this.AutoRemove.Name = "AutoRemove";
            this.AutoRemove.Size = new System.Drawing.Size(320, 186);
            this.AutoRemove.TabIndex = 16;
            this.AutoRemove.ValueMember = "Autonummer";
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataSource = typeof(Autoverleih.Auto);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Autoverleih.Properties.Resources.Car_Add32;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAutoAdd
            // 
            this.BtnAutoAdd.Location = new System.Drawing.Point(253, 142);
            this.BtnAutoAdd.Name = "BtnAutoAdd";
            this.BtnAutoAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAutoAdd.TabIndex = 15;
            this.BtnAutoAdd.Text = "Add";
            this.BtnAutoAdd.UseVisualStyleBackColor = true;
            this.BtnAutoAdd.Click += new System.EventHandler(this.BtnAutoAdd_Click);
            // 
            // BtnAutoRemove
            // 
            this.BtnAutoRemove.Location = new System.Drawing.Point(253, 362);
            this.BtnAutoRemove.Name = "BtnAutoRemove";
            this.BtnAutoRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnAutoRemove.TabIndex = 17;
            this.BtnAutoRemove.Text = "Remove";
            this.BtnAutoRemove.UseVisualStyleBackColor = true;
            this.BtnAutoRemove.Click += new System.EventHandler(this.BtnAutoRemove_Click);
            // 
            // TextPreis
            // 
            this.TextPreis.HintText = "Kosten / Tag";
            this.TextPreis.Location = new System.Drawing.Point(66, 116);
            this.TextPreis.Name = "TextPreis";
            this.TextPreis.Size = new System.Drawing.Size(262, 20);
            this.TextPreis.TabIndex = 14;
            // 
            // TextAutonummer
            // 
            this.TextAutonummer.HintText = "Autonummer";
            this.TextAutonummer.Location = new System.Drawing.Point(66, 90);
            this.TextAutonummer.Name = "TextAutonummer";
            this.TextAutonummer.Size = new System.Drawing.Size(262, 20);
            this.TextAutonummer.TabIndex = 13;
            // 
            // TextTyp
            // 
            this.TextTyp.HintText = "Typ";
            this.TextTyp.Location = new System.Drawing.Point(66, 64);
            this.TextTyp.Name = "TextTyp";
            this.TextTyp.Size = new System.Drawing.Size(262, 20);
            this.TextTyp.TabIndex = 12;
            // 
            // TextHersteller
            // 
            this.TextHersteller.HintText = "Hersteller";
            this.TextHersteller.Location = new System.Drawing.Point(66, 38);
            this.TextHersteller.Name = "TextHersteller";
            this.TextHersteller.Size = new System.Drawing.Size(264, 20);
            this.TextHersteller.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UserRemove);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.BtnUserAdd);
            this.tabPage2.Controls.Add(this.BtnUserRemove);
            this.tabPage2.Controls.Add(this.TextEmail);
            this.tabPage2.Controls.Add(this.TextVorname);
            this.tabPage2.Controls.Add(this.TextName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserRemove
            // 
            this.UserRemove.DataSource = this.personBindingSource;
            this.UserRemove.DisplayMember = "Name";
            this.UserRemove.FormattingEnabled = true;
            this.UserRemove.Location = new System.Drawing.Point(8, 151);
            this.UserRemove.Name = "UserRemove";
            this.UserRemove.Size = new System.Drawing.Size(320, 199);
            this.UserRemove.TabIndex = 9;
            this.UserRemove.ValueMember = "Email";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Autoverleih.Person);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autoverleih.Properties.Resources.Benutzer_Add32;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.Location = new System.Drawing.Point(253, 116);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnUserAdd.TabIndex = 8;
            this.BtnUserAdd.Text = "Add";
            this.BtnUserAdd.UseVisualStyleBackColor = true;
            this.BtnUserAdd.Click += new System.EventHandler(this.BtnUserAdd_Click);
            // 
            // BtnUserRemove
            // 
            this.BtnUserRemove.Location = new System.Drawing.Point(253, 362);
            this.BtnUserRemove.Name = "BtnUserRemove";
            this.BtnUserRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnUserRemove.TabIndex = 10;
            this.BtnUserRemove.Text = "Remove";
            this.BtnUserRemove.UseVisualStyleBackColor = true;
            this.BtnUserRemove.Click += new System.EventHandler(this.BtnUserRemove_Click);
            // 
            // TextEmail
            // 
            this.TextEmail.HintText = "Email";
            this.TextEmail.Location = new System.Drawing.Point(66, 90);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(262, 20);
            this.TextEmail.TabIndex = 7;
            // 
            // TextVorname
            // 
            this.TextVorname.HintText = "Vorname";
            this.TextVorname.Location = new System.Drawing.Point(66, 64);
            this.TextVorname.Name = "TextVorname";
            this.TextVorname.Size = new System.Drawing.Size(262, 20);
            this.TextVorname.TabIndex = 6;
            // 
            // TextName
            // 
            this.TextName.HintText = "Name";
            this.TextName.Location = new System.Drawing.Point(66, 38);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(262, 20);
            this.TextName.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnBuchen);
            this.tabPage1.Controls.Add(this.UserAuswahl);
            this.tabPage1.Controls.Add(this.AutoAuswahl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnBuchen
            // 
            this.BtnBuchen.Location = new System.Drawing.Point(253, 362);
            this.BtnBuchen.Name = "BtnBuchen";
            this.BtnBuchen.Size = new System.Drawing.Size(75, 23);
            this.BtnBuchen.TabIndex = 3;
            this.BtnBuchen.Text = "Buchen";
            this.BtnBuchen.UseVisualStyleBackColor = true;
            this.BtnBuchen.Click += new System.EventHandler(this.BtnBuchen_Click);
            // 
            // UserAuswahl
            // 
            this.UserAuswahl.DataSource = this.personBindingSource;
            this.UserAuswahl.DisplayMember = "Name";
            this.UserAuswahl.FormattingEnabled = true;
            this.UserAuswahl.Location = new System.Drawing.Point(8, 6);
            this.UserAuswahl.Name = "UserAuswahl";
            this.UserAuswahl.Size = new System.Drawing.Size(320, 160);
            this.UserAuswahl.TabIndex = 1;
            this.UserAuswahl.ValueMember = "Email";
            // 
            // AutoAuswahl
            // 
            this.AutoAuswahl.DataSource = this.autoBindingSource;
            this.AutoAuswahl.DisplayMember = "Hersteller";
            this.AutoAuswahl.FormattingEnabled = true;
            this.AutoAuswahl.Location = new System.Drawing.Point(8, 179);
            this.AutoAuswahl.Name = "AutoAuswahl";
            this.AutoAuswahl.Size = new System.Drawing.Size(320, 173);
            this.AutoAuswahl.TabIndex = 2;
            this.AutoAuswahl.ValueMember = "Autonummer";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Controls.Add(this.tabPage4);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(344, 414);
            this.MainTabControl.TabIndex = 1;
            // 
            // chflabel
            // 
            this.chflabel.AutoSize = true;
            this.chflabel.Location = new System.Drawing.Point(296, 119);
            this.chflabel.Name = "chflabel";
            this.chflabel.Size = new System.Drawing.Size(28, 13);
            this.chflabel.TabIndex = 32;
            this.chflabel.Text = "CHF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 414);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 453);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 453);
            this.Name = "Form1";
            this.Text = "Autoverleih";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buchungBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox Ausgeliehen;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnAutoAdd;
        private System.Windows.Forms.Button BtnAutoRemove;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnUserAdd;
        private System.Windows.Forms.Button BtnUserRemove;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private HintedTextBox TextAutonummer;
        private HintedTextBox TextTyp;
        private HintedTextBox TextHersteller;
        private HintedTextBox TextEmail;
        private HintedTextBox TextVorname;
        private HintedTextBox TextName;
        private HintedTextBox TextPreis;
        private System.Windows.Forms.ListBox AutoRemove;
        private System.Windows.Forms.ListBox UserRemove;
        private System.Windows.Forms.ListBox UserAuswahl;
        private System.Windows.Forms.ListBox AutoAuswahl;
        private System.Windows.Forms.Button btnAbrechnen;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private System.Windows.Forms.BindingSource buchungBindingSource;
        private System.Windows.Forms.Button BtnBuchen;
        private System.Windows.Forms.Label chflabel;
    }
}

