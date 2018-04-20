﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum ComboBoxParseCase
        {
            None,//아래 모든 경우를 제외한 경우
            Year,//year 파싱불가
            Month, //month 파싱불가
			Day, //day 파싱불가
			Combine //존재하지 않는 날짜
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            for (int i = localDate.Year - 1000; i <= localDate.Year + 1000; i++) cmbYear.Items.Add(i);
            cmbYear.SelectedIndex = cmbYear.Items.Count - 1;

            for (int i = 1; i <= 12; i++) cmbMonth.Items.Add(i);
            for (int i = 1; i <= 31; i++) cmbDay.Items.Add(i);
        }
        public bool IsDate(int year, int month, int day)
        {
            return year >= 0 && month > 0 && month < 13 && day > 0 && day <= DateTime.DaysInMonth(year, month);
        }
        private ComboBoxParseCase GetComboBoxParseCase()
        {
            if (cmbYear.SelectedItem == null) return ComboBoxParseCase.Year;
            else if (cmbMonth.SelectedItem == null) return ComboBoxParseCase.Month;
            else if (cmbDay.SelectedItem == null) return ComboBoxParseCase.Day;
			else if (cmbDay.SelectedItem == null) return ComboBoxParseCase.Day;
			else if (!IsDate((int)cmbYear.SelectedItem,
                (int)cmbMonth.SelectedItem,
                (int)cmbDay.SelectedItem))
                return ComboBoxParseCase.Combine;
            return ComboBoxParseCase.None;
        }
        private void cmb_ItemOrTextChanged(object sender, EventArgs e)
        {
            switch (GetComboBoxParseCase())
            {
                case ComboBoxParseCase.Year:
                    labelToggle.Text = "태어난 년도를 입력하세요.";
                    break;
                case ComboBoxParseCase.Month:
                    labelToggle.Text = "태어난 월을 입력하세요.";
                    break;
                case ComboBoxParseCase.Day:
                    labelToggle.Text = "태어난 일(날짜)를 입력하세요";
                    break;
                case ComboBoxParseCase.Combine:
                    labelToggle.Text = "생년월일을 다시 확인해주세요.";
                    break;
                default://ComboException.None
                    labelToggle.Text = "";
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (GetComboBoxParseCase() != ComboBoxParseCase.None) return;

            int year = (int)cmbYear.SelectedItem;
            int month = (int)cmbMonth.SelectedItem;
            int day = (int)cmbDay.SelectedItem;
            DateTime BirthDay = new DateTime(year, month, day);
            DateTime CurrentDate = DateTime.Now;

            txtNote.Text += "세는나이 : " + (CurrentDate.Year - BirthDay.Year + 1).ToString() + "\r\n";

            int age = CurrentDate.Year - BirthDay.Year;
            if (CurrentDate.Month == BirthDay.Month) age -= 1;
            else if (CurrentDate.Month == BirthDay.Month && CurrentDate.Day < BirthDay.Day) age -= 1;
            txtNote.Text += "만나이 : " + age.ToString() + "\r\n";

        }
    }
}
