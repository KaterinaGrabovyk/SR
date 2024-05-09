using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }    
        public string Parol {  get; set; }
    }
    public class Zamovlenna
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Ogirki { get; set; }
        public bool Pomidori { get; set; }
        public bool Kapusta { get; set; }
        public bool Buriak { get; set; }
        public bool Morkva { get; set; }
        public bool Prinato {  get; set; }
        public bool Vidpravleno {  get; set; }
    }
    public class Kurer
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public int ZamID {  get; set; }
    }
}
