using MapDAL.Banks;
using MapDAL.Context;
using MapDAL.Entity;
using System;
using System.Collections.Generic;
using System.Xml;

namespace MapBLL.AddBank
{
    public class AddKurses
    {
        private int _counter = 0;
        private string str = "";
        BanksContext db;
        XmlDocument doc;
        Kurs kurs;
        List<Kurs> listofkurs;
        DateTime _date;
        decimal _sell;
        string _name;
        private int a;
        private static bool _bool = false;
        private static bool _bool2 = false;

        public AddKurses(BanksContext _db)
        {
            doc = new XmlDocument();
            db = _db;
            kurs = new Kurs();
            listofkurs = new List<Kurs>();


        }
        public void AddKurs(Bank bank, int bankid)
        {
            using (XmlTextReader reader = new XmlTextReader(@"http://www.obmennik.by/xml/kurs.xml"))
            {
                while (reader.Read())
                {


                    if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "rur"))
                    {
                        _bool2 = false;
                        _counter = 0;
                    }
                    if ((_bool) && (reader.NodeType == XmlNodeType.Element))
                    {
                        _name = reader.Name;
                        _bool = false;
                    }
                    if ((reader.NodeType == XmlNodeType.Text) && (_bool2))
                    {
                        if (_counter == 7)
                        {
                            _counter++;
                            bank.Kurses.Add(new Kurs() { Name = _name, By = Convert.ToDecimal(reader.Value), Date = _date, Sell = _sell });
                        }
                        else if (_counter == 6)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 5)
                        {
                            _counter++;
                            bank.Kurses.Add(new Kurs() { Name = _name, By = Convert.ToDecimal(reader.Value), Date = _date, Sell = _sell });
                            _bool = true;

                        }
                        else if (_counter == 4)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 3)
                        {
                            _counter++;
                           bank.Kurses.Add(new Kurs() { Name = _name, By = Convert.ToDecimal(reader.Value), Date = _date, Sell = _sell });
                            _bool = true;

                        }
                        else if (_counter == 2)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 1)
                        {
                            str += " " + reader.Value;
                            _date = DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            _counter++;
                            _bool = true;
                        }
                        else if (_counter == 0)
                        {
                            str = reader.Value;
                            _counter++;
                        }
                    }
                    int.TryParse(reader.Value, out a);
                    if (a == bankid)
                    {
                        _bool2 = true;
                    }
                }
            }
        }
        public void AddNewKurses(Bank bank, int bankid)
        {
            using (XmlTextReader reader = new XmlTextReader(@"http://www.obmennik.by/xml/kurs.xml"))
            {
                while (reader.Read())
                {


                    if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "rur"))
                    {
                        _bool2 = false;
                        _counter = 0;
                    }
                    if ((_bool) && (reader.NodeType == XmlNodeType.Element))
                    {
                        _name = reader.Name;
                        _bool = false;
                    }
                    if ((reader.NodeType == XmlNodeType.Text) && (_bool2))
                    {
                        if (_counter == 7)
                        {
                            _counter++;
                            foreach (var item in bank.Kurses)
                            {
                                if ((item.Name == _name) && ((item.Sell != _sell) || (item.By != Convert.ToDecimal(reader.Value))))
                                {
                                    item.Sell = _sell;
                                    item.By = Convert.ToDecimal(reader.Value);
                                    item.Date = _date;

                                }
                            }
                        }
                        else if (_counter == 6)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 5)
                        {
                            _counter++;
                            foreach (var item in bank.Kurses)
                            {
                                if ((item.Name == _name) && ((item.Sell != _sell) || (item.By != Convert.ToDecimal(reader.Value))))
                                {
                                    item.Sell = _sell;
                                    item.By = Convert.ToDecimal(reader.Value);
                                    item.Date = _date;

                                }
                            }
                            _bool = true;

                        }
                        else if (_counter == 4)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 3)
                        {
                            _counter++;
                            foreach (var item in bank.Kurses)
                            {
                                if ((item.Name == _name) && ((item.Sell != _sell) || (item.By != Convert.ToDecimal(reader.Value))))
                                {
                                    item.Sell = _sell;
                                    item.By = Convert.ToDecimal(reader.Value);
                                    item.Date = _date;
                                }
                            }
                     

                            _bool = true;

                        }
                        else if (_counter == 2)
                        {
                            _sell = Convert.ToDecimal(reader.Value);
                            _counter++;
                        }
                        else if (_counter == 1)
                        {
                            str += " " + reader.Value;
                            _date = DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            _counter++;
                            _bool = true;
                        }
                        else if (_counter == 0)
                        {
                            str = reader.Value;
                            _counter++;
                        }
                    }
                    int.TryParse(reader.Value, out a);
                    if (a == bankid)
                    {
                        _bool2 = true;
                    }
                }
            }
        }
    }
}