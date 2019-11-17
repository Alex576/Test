using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using MapDAL.Banks;
using MapDAL.Context;
using MapDAL.Entity;
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
    public partial class AddBank : Form
    {
        BanksContext _db;
        Bank bank;
        double _lantitude, _longtitude;
        readonly GMapOverlay _gMapOverlay;
        AddKurses AddKurses;
        private string str = "\n";

        public AddBank()
        {
            InitializeComponent();
        }
        public AddBank(BanksContext db, GMapOverlay gMapOverlay):this()
        {

            _db = db;
            _gMapOverlay = gMapOverlay;
  
            bank = new Bank() { Kurses = new List<Kurs>() };
            AddKurses = new AddKurses(bank, _gMapOverlay);

        }
        public AddBank(BanksContext db, GMapOverlay gMapOverlay, double lantitude,double longtitude):this()
        {
            
            _db = db;
            _gMapOverlay = gMapOverlay;
            bank = new Bank() { Kurses = new List<Kurs>() };

        
            tbLantitude.Text = lantitude.ToString();
            tbLongtitude.Text = longtitude.ToString();
            AddKurses = new AddKurses(bank, _gMapOverlay);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddKurses_Click(object sender, EventArgs e)
        {
            AddKurses.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(tbLantitude.Text,out _lantitude)) && (double.TryParse(tbLongtitude.Text,out _longtitude)))
            {
                bank.BankName = tbBankName.Text;
                bank.Latitude = _lantitude;
                bank.Longitude = _longtitude;
                bank.Address = tbAddress.Text;
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(_lantitude, _longtitude), GMarkerGoogleType.yellow);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                if (bank.Kurses.Count != 0)
                {
                    foreach (var kurs in bank.Kurses)
                    {
                        str += kurs.Name + " Date " + kurs.Date + " By" + kurs.By + " Sell" + kurs.Sell + " " + '\n';
                    }
                }
                else
                {
                    str += "Info not found";
                }
                marker.ToolTipText = bank.BankName + " " + bank.Address + " " + str;
                str = "\n";
                _gMapOverlay.Markers.Add(marker);
                _db.Banks.Add(bank);
                this.Close();
                _db.SaveChanges();

            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
           

           
        }
    }
}
