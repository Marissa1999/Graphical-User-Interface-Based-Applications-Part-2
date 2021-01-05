//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - DateTimePicker

using System;
using System.Windows.Forms;

namespace DateTimePickerTest
{
    public partial class DateTimePickerForm : Form
    {
        public DateTimePickerForm()
        {
            InitializeComponent();
        }

        private void dateTimePickerDropOff_ValueChanged(object sender, EventArgs e)
        {

            DateTime dropOffDate = dateTimePickerDropOff.Value;

            if (dropOffDate.DayOfWeek == DayOfWeek.Friday || dropOffDate.DayOfWeek == DayOfWeek.Saturday || dropOffDate.DayOfWeek == DayOfWeek.Sunday)
            {
                outputLabel.Text = dropOffDate.AddDays(3).ToString("ddddd, MMMM dd, yyyy");
            }

            else
            {
                outputLabel.Text = dropOffDate.AddDays(2).ToString("ddddd, MMMM dd, yyyy");
            }

        }

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDropOff.MinDate = DateTime.Today;
            dateTimePickerDropOff.MaxDate = DateTime.Today.AddYears(1);
        }

    }
}
