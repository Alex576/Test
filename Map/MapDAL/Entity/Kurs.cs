using MapDAL.Banks;
using System;

namespace MapDAL.Entity
{
    public class Kurs
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public string Name { get; set; }
        public decimal By { get; set; }
        public decimal Sell { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
