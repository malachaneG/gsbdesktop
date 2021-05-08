using gsbcompta.CONTROLLERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta.VIEWS
{
    public partial class DetailsOffPrice : Form
    {
        String ID;
        String User;
        String Month;
        String Name;
        String Date;
        String Amount;
        String File;
        OffPriceController opController;
        private ListeFiches lt;

        public DetailsOffPrice()
        {
            InitializeComponent();
        }

        public DetailsOffPrice(string id, string user, string month, string name, string date, string amount, string file)
        {

            InitializeComponent();
            this.ID = id;
            this.User = user;
            this.Month = month;
            this.Name = name;
            this.Date = date;
            this.Amount = amount;
            this.File = file;

            this.textBoxUser.Text = this.User;
            this.textBoxMonth.Text = this.Month;
            this.textBoxName.Text = this.Name;
            this.dateTimePicker.Text = this.Date;
            this.textBoxAmount.Text = this.Amount;
            this.textBoxFile.Text = this.File;

            opController = new OffPriceController();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            DateTime dateValue = Convert.ToDateTime(this.dateTimePicker.Value);
            string date = dateValue.ToString("yyyy-MM-dd");

            String name = this.textBoxName.Text;
            String amount = this.textBoxAmount.Text;
            opController.updateOffPrice(this.ID, name, date, amount);

            lt = new ListeFiches();
            lt.Show();
            this.Hide();
        }
    }
}
