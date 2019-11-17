using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Map.AddForm;
using MapBLL.AddBank;
using MapDAL.Banks;
using MapDAL.Context;
using MapDAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Map
{
    public partial class MainForm : Form
    {
        readonly GMapOverlay _gMapOverlay;
        readonly GMapControl _gMapControl;
        private BanksContext db;
        AddBanks addbanks;
        AddBank addbank;
        MapBLL.AddBank.AddKurses AddKurses;
        
        Bank bank;
        Kurs kurs;
        private bool saveFailed;
        string str = "\n";
        private int bankid;

        public MainForm()
        {
            InitializeComponent();
            _gMapOverlay = new GMapOverlay("Markers");
            _gMapControl = new GMapControl();

            _gMapControl.Overlays.Add(_gMapOverlay);

            _gMapControl.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(_gMapControl);
            db = new BanksContext();

            bank = new Bank()
            {
                Kurses = new List<Kurs>()

            };

            kurs = new Kurs();
            addbanks = new AddBanks(db);
            AddKurses = new MapBLL.AddBank.AddKurses(db);
            if (db.Banks.Count() == 0)
            {
                addbanks.AddBank(bank);
                do
                {
                    saveFailed = false;

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        saveFailed = true;

                        ex.Entries.Single().Reload();
                    }

                } while (saveFailed);
            }
            else
            {
                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
             

         
                foreach (var item in db.Banks)
                {
                    if (item.BankName == "Абсолютбанк") { bankid = 1; }
                    else if (item.BankName == "Альфа-Банк") { bankid = 2; }
                    else if (item.BankName == "Банк ВТБ") { bankid = 3; }
                    else if (item.BankName == "БелАгроПромБанк") { bankid = 4; }
                    else if (item.BankName == "БелГазпромБанк") { bankid = 5; }
                    else if (item.BankName == "БелИнвестБанк") { bankid = 6; }
                    else if (item.BankName == "Белорусский Банк Малого Бизнеса") { bankid = 7; }
                    else if (item.BankName == "Белорусский Народный Банк") { bankid = 8; }
                    else if (item.BankName == "БПС-Сбербанк") { bankid = 9; }
                    else if (item.BankName == "БеларусБанк") { bankid = 10; }
                    else if (item.BankName == "БСБ Банк (БелСвиссБанк)") { bankid = 11; }
                    else if (item.BankName == "БТА Банк") { bankid = 12; }
                    else if (item.BankName == "Евробанк") { bankid = 13; }
                    else if (item.BankName == "Международный резервный банк") { bankid = 14; }
                    else if (item.BankName == "МТБанк") { bankid = 15; }
                    else if (item.BankName == "Паритетбанк") { bankid = 16; }
                    else if (item.BankName == "Паритетбанк") { bankid = 17; }
                    else if (item.BankName == "Сберегательный Банк Беларусбанк") { bankid = 18; }
                    else if (item.BankName == "СОМБелБанк") { bankid = 19; }
                    else if (item.BankName == "ТехноБанк") { bankid = 20; }
                    else if (item.BankName == "Хоум Кредит Банк") { bankid = 21; }
                    else if (item.BankName == "Цептер Банк") { bankid = 22; }
                    else if (item.BankName == "Москва-Минск Банк") { bankid = 23; }
                    else if (item.BankName == "ТрастБанк") { bankid = 24; }
                    else if (item.BankName == "Банк БелВЭБ") { bankid = 25; }
                    else if (item.BankName == "ФрансаБанк") { bankid = 26; }
                    else if (item.BankName == "Дельта Банк") { bankid = 27; }
                    else if (item.BankName == "РРБ-Банк") { bankid = 28; }
                    else if (item.BankName == "Кредэксбанк") { bankid = 29; }
                    else if (item.BankName == "ТК Банк") { bankid = 30; }
                    else if (item.BankName == "Онербанк") { bankid = 31; }
                    else if (item.BankName == "Бит-Банк") { bankid = 32; }
                    AddKurses.AddNewKurses(item, bankid);
                }
                Thread.CurrentThread.CurrentCulture = temp_culture;
                db.SaveChanges();

            }

            foreach (var item in db.Banks)
            {

                treeView1.Nodes.Add(item.BankName + " " + item.Address);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            _gMapControl.ShowCenter = false;
            _gMapControl.MaxZoom = 18;
            _gMapControl.MinZoom = 2;
            _gMapControl.Zoom = 17;
            _gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            _gMapControl.CanDragMap = true;
            _gMapControl.Position = new PointLatLng(53.902800, 27.561759);
            _gMapControl.MarkersEnabled = true;
            _gMapControl.MouseClick += MainForm_MouseClick;
            ClearAddMarkers();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                var y = _gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
                var x = _gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;

                addbank = new AddBank(db, _gMapOverlay, x, y);
                addbank.ShowDialog();

                treeView1.Nodes.Clear();
                foreach (var item in db.Banks)
                {
                    treeView1.Nodes.Add(item.BankName + item.Address);
                }


            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _gMapControl.Dispose();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (var item in db.Banks.Where(w => w.Id == treeView1.SelectedNode.Index + 1))
            {
                _gMapControl.Zoom = 17;
                _gMapControl.Position = new PointLatLng(item.Latitude, item.Longitude);
            }

        }


      

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            foreach (var item in db.Banks)
            {
                if (item.BankName.IndexOf(toolStripTextBox1.Text.ToString()) != -1)
                {
                    treeView1.Nodes.Add(item.BankName + item.Address);
                }
            }
            if (toolStripTextBox1.Text.ToString() == "")
            {
                foreach (var item in db.Banks)
                {
                    treeView1.Nodes.Add(item.BankName + item.Address);
                }
            }
        }

        private void addBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbank = new AddBank(db, _gMapOverlay);
            addbank.ShowDialog();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (var item in db.Banks.Where(w => w.Id == treeView1.SelectedNode.Index + 1).ToList())
            {
                EditBank editBank = new EditBank(db, item);
                editBank.ShowDialog();
            }
            treeView1.Nodes.Clear();
            foreach (var item in db.Banks)
            {
                treeView1.Nodes.Add(item.BankName + item.Address);
            }
        }

        private void btnBy_Click(object sender, EventArgs e)
        {
            var NameOfKurs = sender as ToolStripMenuItem;
            decimal a = db.Kurses.Where(w => w.Name == NameOfKurs.OwnerItem.Text).Select(c => c.By).Min();
            _gMapOverlay.Markers.Clear();
            foreach (var item in db.Kurses.Where(w => w.Name == NameOfKurs.OwnerItem.Text))
            {
                if (decimal.Compare(item.By, a) == 0)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(item.Bank.Latitude, item.Bank.Longitude), GMarkerGoogleType.red);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    foreach (var banks in db.Banks.Where(w => w.Id == item.Bank.Id))
                    {
                        if (banks.Kurses.Count != 0)
                        {
                            foreach (var kurs in banks.Kurses)
                            {
                                str += kurs.Name + " Date " + kurs.Date + " By " + kurs.By + " Sell " + kurs.Sell + " " + '\n';
                            }
                        }
                        else
                        {
                            str += "Info not found";
                        }
                        marker.ToolTipText = banks.BankName + " " + banks.Address + " " + str;
                        str = "\n";
                        _gMapOverlay.Markers.Add(marker);

                    }

                }

            }
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            var NameOfKurs = sender as ToolStripMenuItem;
            decimal a = db.Kurses.Where(w => w.Name == NameOfKurs.OwnerItem.Text).Select(c => c.Sell).Max();
            _gMapOverlay.Markers.Clear();
            foreach (var item in db.Kurses.Where(w => w.Name == NameOfKurs.OwnerItem.Text))
            {
                if (item.Sell == a)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(item.Bank.Latitude, item.Bank.Longitude), GMarkerGoogleType.blue);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    foreach (var banks in db.Banks.Where(w => w.Id == item.Bank.Id))
                    {
                        if (banks.Kurses.Count != 0)
                        {
                            foreach (var kurs in banks.Kurses)
                            {
                                str += kurs.Name + " Date " + kurs.Date + " By" + kurs.By + " Sell" + kurs.Sell + " " + '\n';
                            }
                        }
                        else
                        {
                            str += "Info not found";
                        }
                        marker.ToolTipText = banks.BankName + " " + banks.Address + " " + str;
                        str = "\n";
                        _gMapOverlay.Markers.Add(marker);

                    }

                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAddMarkers();
        }

        private void ClearAddMarkers()
        {
            _gMapOverlay.Markers.Clear();
            foreach (var item in db.Banks)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(item.Latitude, item.Longitude), GMarkerGoogleType.green);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                if (item.Kurses.Count != 0)
                {
                    foreach (var kurs in item.Kurses)
                    {
                        str += kurs.Name + " Date: " + kurs.Date + " By: " + kurs.By + " Sell: " + kurs.Sell + " " + '\n';
                    }
                }
                else
                {
                    str += "Info not found";
                }
                marker.ToolTipText = item.BankName + " " + item.Address + " " + str;
                str = "\n";
                _gMapOverlay.Markers.Add(marker);

            }
        }
    }
}
