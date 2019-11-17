using MapDAL.Banks;
using MapDAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map.AddForm
{
    public partial class EditBank : Form
    {
        BanksContext _db;
        Bank _bank;
        AddKurses addKurses;
         public EditBank(BanksContext db,Bank bank)
        {
            InitializeComponent();
            _db = db;
            _bank = bank;
            tbAddress.Text = _bank.Address;
            tbBankName.Text = _bank.BankName;
            tbLantitude.Text = _bank.Latitude.ToString();
            tbLongtitude.Text = _bank.Longitude.ToString();
            addKurses = new AddKurses(_bank);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in _db.Banks.Where(w=>w.Id == _bank.Id))
            {
                item.Kurses.Clear();
                foreach (var kurses in addKurses.GetKurses())
                {
                    item.Kurses.Add(kurses);
                }
            }
            _db.SaveChanges();
            this.Close();
        }

        private void btnAddKurses_Click(object sender, EventArgs e)
        {
            addKurses.ShowDialog();
        }
    }
}
