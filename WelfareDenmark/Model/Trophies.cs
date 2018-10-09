using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmark.Model
{
    public class Trophies
    {
        public string TrophyName { get; set; }
        public string description { get; set; }
        public int Counter { get; set; }
        public int ID { get; set; }
        public int Goal { get; set; }
        [ForeignKey("TraningspartnerForeignKey")]
        public Trainingspartner Trainingspartner { get; set; }
    }
}
