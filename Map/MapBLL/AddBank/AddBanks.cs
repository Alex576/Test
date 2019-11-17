using MapDAL.Banks;
using MapDAL.Context;
using MapDAL.Entity;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Xml;

namespace MapBLL.AddBank
{
    public class AddBanks
    {
        private int _counter = 0;
        BanksContext db;
        XmlDocument doc;
        XmlDocument doc2;
        int bankid;
        AddKurses addkurses;
        Bank _bank;
    
        public AddBanks(BanksContext _db)
        {
            db = _db;
            doc = new XmlDocument();
            doc2 = new XmlDocument();
            addkurses = new AddKurses(db);

        }

        public void AddBank(Bank bank)
        {
            doc.Load(@"banks.xml");
            AddInBank(doc.DocumentElement, bank);

        }

        void AddInBank(XmlNode node, Bank bank)
        {
            double d;
            if ((node.Value != null) && (node.NodeType == XmlNodeType.Text))
            {
                if ((double.TryParse(node.Value, out d) && (_counter == 3)))
                {
                    bank.Longitude = d;
                    _counter++;

                }
                if ((double.TryParse(node.Value, out d) && (_counter == 2)))
                {
                    bank.Latitude = d;
                    _counter++;
                }
                if (_counter == 1)
                {
                    bank.Address = node.Value;
                    _counter++;
                }
                if (_counter == 0)
                {
                    _counter++;
                }
            }
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    if (attribute.Name == "name")
                    {
                        bank.BankName = attribute.Value;
                    }
                }
            }
            if (_counter == 4)
            {
                if (bank.BankName == "Абсолютбанк") { bankid = 1; }
                else if (bank.BankName == "Альфа-Банк") { bankid = 2; }
                else if (bank.BankName == "Банк ВТБ") { bankid = 3; }
                else if (bank.BankName == "БелАгроПромБанк") { bankid = 4; }
                else if (bank.BankName == "БелГазпромБанк") { bankid = 5; }
                else if (bank.BankName == "БелИнвестБанк") { bankid = 6; }
                else if (bank.BankName == "Белорусский Банк Малого Бизнеса") { bankid = 7; }
                else if (bank.BankName == "Белорусский Народный Банк") { bankid = 8; }
                else if (bank.BankName == "БПС-Сбербанк") { bankid = 9; }
                else if (bank.BankName == "БеларусБанк") { bankid = 10; }
                else if (bank.BankName == "БСБ Банк (БелСвиссБанк)") { bankid = 11; }
                else if (bank.BankName == "БТА Банк") { bankid = 12; }
                else if (bank.BankName == "Евробанк") { bankid = 13; }
                else if (bank.BankName == "Международный резервный банк") { bankid = 14; }
                else if (bank.BankName == "МТБанк") { bankid = 15; }
                else if (bank.BankName == "Паритетбанк") { bankid = 16; }
                else if (bank.BankName == "Паритетбанк") { bankid = 17; }
                else if (bank.BankName == "Сберегательный Банк Беларусбанк") { bankid = 18; }
                else if (bank.BankName == "СОМБелБанк") { bankid = 19; }
                else if (bank.BankName == "ТехноБанк") { bankid = 20; }
                else if (bank.BankName == "Хоум Кредит Банк") { bankid = 21; }
                else if (bank.BankName == "Цептер Банк" ) { bankid = 22; }
                else if (bank.BankName == "Москва-Минск Банк" ) { bankid = 23; }
                else if (bank.BankName == "ТрастБанк") { bankid = 24; }
                else if (bank.BankName == "Банк БелВЭБ") { bankid = 25; }
                else if (bank.BankName == "ФрансаБанк") { bankid = 26; }
                else if (bank.BankName == "Дельта Банк" ){ bankid = 27; }
                else if (bank.BankName == "РРБ-Банк" ) { bankid = 28; }
                else if (bank.BankName == "Кредэксбанк" ) { bankid = 29; }
                else if (bank.BankName == "ТК Банк" ) { bankid = 30; }
                else if (bank.BankName == "Онербанк" ){ bankid = 31; }
                else if (bank.BankName == "Бит-Банк" ) { bankid = 32; }
                _bank = new Bank() { BankName = bank.BankName, Address = bank.Address, Kurses = new List<Kurs>(), Latitude = bank.Latitude, Longitude = bank.Longitude };
                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                addkurses.AddKurs(bank,bankid);
                foreach (var item in bank.Kurses)
                {
                    _bank.Kurses.Add(item);
                }

                db.Banks.Add(_bank);
                bank.Kurses.Clear();


                Thread.CurrentThread.CurrentCulture = temp_culture;


                _counter = 0;
            }
            
            if (node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {
                    AddInBank(item, bank);
                }
            }



        }
    }
}
