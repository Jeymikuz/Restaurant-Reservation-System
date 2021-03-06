﻿using RestaurantDesktop.Data;
using RestaurantDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDesktop
{
    public partial class NewReservation : Form
    {
        List<DateTime> days = new List<DateTime>();
        List<DateTime> hours = new List<DateTime>();
        List<DateTime> length = new List<DateTime>();
        List<Reservation> reservations = new List<Reservation>();

        public NewReservation()
        {
            InitializeComponent();
            InitTableComboBox();
            InitDayComboBox();
            InitLengthComboBox();
            reservations = GetAllReservations();    
        }

        private List<Reservation> GetAllReservations()
        {
            var db = new DataAccess();
            var rs = db.GetAllReservations();
            return rs.Where(r => r.ReservationDate >= new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day) && r.Accepted == true).ToList();
        }

        private void InitLengthComboBox()
        {
            var time = new DateTime(2000, 01, 01, 1, 0, 0);
            for (int i = 0; i < 4; i++)
            {
                length.Add(time);
                time = time.AddHours(1);
            }
            LengthComboBox.DataSource = length;
            LengthComboBox.DisplayMember = "Hour";
            LengthComboBox.ValueMember = "Hour";

        }

        private void InitHourComboBox()
        {
            HourComboBox.Items.Clear();
            hours.Clear();
            bool isTaken = false;
            
            var helperValue = days[ReservationDayComboBox.SelectedIndex];
            var checkValue = new DateTime(helperValue.Year, helperValue.Month, helperValue.Day, 12, 0,0);
            
            
            if (helperValue > checkValue)
            {
                var hour = RoundUp(days[ReservationDayComboBox.SelectedIndex], TimeSpan.FromHours(1)); // 14:00:00               
                while (hour <= DateTime.Today.AddHours(20)) // 16:00:00
                {
                    foreach (var r in reservations)
                    {
                        for (int i = 0; i < r.ReservationLength; i++)
                        {
                            if(hour.TimeOfDay == (r.ReservationDate.TimeOfDay + new TimeSpan(i,0,0)) && r.TableID == (int)ChearsComboBox.SelectedValue)
                            {
                                isTaken = true;
                            }
                        }
                    }
                    if (isTaken == false)
                    {
                        HourComboBox.Items.Add(hour.TimeOfDay.ToString(@"hh\:mm"));
                        hours.Add(hour);
                    }
                    isTaken = false;
                    hour = hour.AddMinutes(60);
                }
            }
            else
            {
                var today = DateTime.Now;
                var hour = RoundUp(new DateTime(today.Year,today.Month,today.Day,12,0,0), TimeSpan.FromHours(1)); // 14:00:00                
                while (hour <= DateTime.Today.AddHours(20)) // 16:00:00
                {
                    foreach (var r in reservations)
                    {
                        for (int i = 0; i < r.ReservationLength; i++)
                        {
                            if (hour.TimeOfDay == (r.ReservationDate.TimeOfDay + new TimeSpan(i, 0, 0)) && r.TableID == (int)ChearsComboBox.SelectedValue)
                            {
                                isTaken = true;
                            }
                        }
                    }
                    if (isTaken == false)
                    {
                        HourComboBox.Items.Add(hour.TimeOfDay.ToString(@"hh\:mm"));
                        hours.Add(hour);
                    }
                    hour = hour.AddMinutes(60);
                    isTaken = false;
                }
            }
        }

        private void InitDayComboBox()
        {
            for (double i = 0; i <= 7; i++)
            {
                var day = DateTime.Now;
                if (i > 0)
                {
                    days.Add(day.Date.AddDays(i));
                }
                else
                {
                    days.Add(day);
                }
            }
            ReservationDayComboBox.DataSource = days;
        }

       

        private void InitTableComboBox()
        {
            var db = new DataAccess();

            var tables = db.GetAllTable();
            ChearsComboBox.DataSource = tables;
            ChearsComboBox.DisplayMember = "CharsAndID";
            ChearsComboBox.ValueMember = "TableID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            var resevationDate = new DateTime(days[ReservationDayComboBox.SelectedIndex].Year, days[ReservationDayComboBox.SelectedIndex].Month, days[ReservationDayComboBox.SelectedIndex].Day,
                hours[HourComboBox.SelectedIndex].Hour, hours[HourComboBox.SelectedIndex].Minute, hours[HourComboBox.SelectedIndex].Second);

            db.InsterResevation((int)ChearsComboBox.SelectedValue, FirstNameBox.Text, LastNameBox.Text, emailTextBox.Text,phoneNumberT.Text, resevationDate, (int)LengthComboBox.SelectedValue);


            this.Close();
        }

        DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime((dt.Ticks + d.Ticks - 1) / d.Ticks * d.Ticks, dt.Kind);
        }

        private void ReservationDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitHourComboBox();
        }
    }
}
