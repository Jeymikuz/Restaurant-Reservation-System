namespace RestaurantDesktop
{
    partial class NewReservation
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ChearsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationDayComboBox = new System.Windows.Forms.ComboBox();
            this.ReservationDayLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 43);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(36, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Stolik:";
            // 
            // ChearsComboBox
            // 
            this.ChearsComboBox.FormattingEnabled = true;
            this.ChearsComboBox.Location = new System.Drawing.Point(75, 40);
            this.ChearsComboBox.Name = "ChearsComboBox";
            this.ChearsComboBox.Size = new System.Drawing.Size(218, 21);
            this.ChearsComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(75, 85);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(218, 20);
            this.FirstNameBox.TabIndex = 3;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(75, 119);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(218, 20);
            this.LastNameBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(11, 122);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Nazwisko:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(75, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 155);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // phoneNumberT
            // 
            this.phoneNumberT.Location = new System.Drawing.Point(75, 184);
            this.phoneNumberT.Name = "phoneNumberT";
            this.phoneNumberT.Size = new System.Drawing.Size(218, 20);
            this.phoneNumberT.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon:";
            // 
            // ReservationDayComboBox
            // 
            this.ReservationDayComboBox.FormattingEnabled = true;
            this.ReservationDayComboBox.Location = new System.Drawing.Point(75, 220);
            this.ReservationDayComboBox.Name = "ReservationDayComboBox";
            this.ReservationDayComboBox.Size = new System.Drawing.Size(218, 21);
            this.ReservationDayComboBox.TabIndex = 10;
            this.ReservationDayComboBox.SelectedIndexChanged += new System.EventHandler(this.ReservationDayComboBox_SelectedIndexChanged);
            // 
            // ReservationDayLabel
            // 
            this.ReservationDayLabel.AutoSize = true;
            this.ReservationDayLabel.Location = new System.Drawing.Point(11, 223);
            this.ReservationDayLabel.Name = "ReservationDayLabel";
            this.ReservationDayLabel.Size = new System.Drawing.Size(40, 13);
            this.ReservationDayLabel.TabIndex = 11;
            this.ReservationDayLabel.Text = "Dzień; ";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(11, 258);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(49, 13);
            this.HourLabel.TabIndex = 13;
            this.HourLabel.Text = "Godzina:";
            // 
            // HourComboBox
            // 
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Location = new System.Drawing.Point(75, 255);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(218, 21);
            this.HourComboBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj Rezerwacje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(11, 291);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(54, 13);
            this.LengthLabel.TabIndex = 15;
            this.LengthLabel.Text = "Długość: ";
            // 
            // LengthComboBox
            // 
            this.LengthComboBox.FormattingEnabled = true;
            this.LengthComboBox.Location = new System.Drawing.Point(75, 291);
            this.LengthComboBox.Name = "LengthComboBox";
            this.LengthComboBox.Size = new System.Drawing.Size(218, 21);
            this.LengthComboBox.TabIndex = 16;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.LengthComboBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.HourComboBox);
            this.Controls.Add(this.ReservationDayLabel);
            this.Controls.Add(this.ReservationDayComboBox);
            this.Controls.Add(this.phoneNumberT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChearsComboBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "NewReservation";
            this.Text = "Nowa Rezerwacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ComboBox ChearsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneNumberT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReservationDayComboBox;
        private System.Windows.Forms.Label ReservationDayLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ComboBox LengthComboBox;
    }
}