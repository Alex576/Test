using MapDAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapDAL.Banks
{

    public class Bank
    {
        
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public virtual ICollection<Kurs> Kurses { get; set; }
    }
}
