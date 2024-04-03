using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Tipp
    {
        public int Id { get; set; }
        public int JatekosId { get; set; }
        public int Sz1 { get; set; }
        public int Sz2 { get; set; }
        public int Sz3 { get; set; }
        public int Sz4 { get; set; }
        public int Sz5 { get; set; }
        public int Sz6 { get; set; }

        public Tipp()
        {
        }

        public Tipp(string sor)
        {
            string[] parts = sor.Split(";");
            JatekosId = int.Parse(parts[0]);           
            Sz1 = int.Parse(parts[1]);
            Sz2 = int.Parse(parts[2]);
            Sz3 = int.Parse(parts[3]);
            Sz4 = int.Parse(parts[4]);
            Sz5 = int.Parse(parts[5]);
            Sz6 = int.Parse(parts[6]);
        }

        public override string? ToString()
        {
            return $"({Sz1};{Sz2};{Sz3};{Sz4};{Sz5};{Sz6}) ";
        }
    }
}
