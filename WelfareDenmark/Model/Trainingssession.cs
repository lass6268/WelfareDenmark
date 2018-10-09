using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmark.Model
{
    public class Trainingssession
    {
        public List<Trainingspartner> Traningspartners { get; set; }
        public int ID { get; set; }
        public string TrainingsDescription { get; set; }
    }
}
