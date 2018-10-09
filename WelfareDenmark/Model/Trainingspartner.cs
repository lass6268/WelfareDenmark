using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmark.Model
{
    public class Trainingspartner
    {
        public string Name { get; set; }
        public int Location { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public List<Trophies> Trophies { get; set; }
    }
}
