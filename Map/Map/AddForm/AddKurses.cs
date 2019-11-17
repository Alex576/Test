using GMap.NET.WindowsForms;
using MapDAL.Banks;
using MapDAL.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Map.AddForm
{
    public partial class AddKurses : Form
    {
        Kurs kurs;
        private DateTime _date;
        private decimal _by;
        private decimal _sell;
        private Bank _bank;
        private GMapOverlay _gMapOverlay;
        private List<Kurs> kurses;
 
        public AddKurses()
        {
            InitializeComponent();
            kurses = new List<Kurs>();
        }
        public AddKurses(Bank bank, GMapOverlay gMapOverlay) : this()
        {
            _bank = bank;
            _gMapOverlay = gMapOverlay;
        }
        public AddKurses(Bank bank):this()
        {
            _bank = bank;
            foreach (var item in _bank.Kurses)
            {
                trvAddKurses.Nodes.Add("Name: " + item.Name + " Date: " + item.Date + " By: " + item.By + " Sell: " + item.Sell);
                kurses.Add(item);
            }
           var test = _bank.Kurses.First();
            tbName.Text = test.Name;
            tbDate.Text = test.Date.ToString();
            tbBy.Text = test.By.ToString();
            tbSell.Text = test.Sell.ToString();

            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((DateTime.TryParse(tbDate.Text, out _date)) && (decimal.TryParse(tbBy.Text, out _by)) && (decimal.TryParse(tbSell.Text, out _sell)))
            {
                kurs = new Kurs
                {
                    Name = tbName.Text,
                    By = _by,
                    Sell = _sell,
                    Date = _date
                };
                kurses.Add(kurs);
                trvAddKurses.Nodes.Add("Name: " + tbName.Text + " Date: " + tbDate.Text + " By: " + tbBy.Text + " Sell: " + tbSell.Text);
            }         
            else
            {
                MessageBox.Show("Field error", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in kurses)
            {
                _bank.Kurses.Add(item);
            }
            this.Close();
          
        }
        public List<Kurs> GetKurses()
        {
            return kurses;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            trvAddKurses.Nodes.Remove(trvAddKurses.SelectedNode);
        }

       
    }
}
