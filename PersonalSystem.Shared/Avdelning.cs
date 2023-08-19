using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSystem.Shared
{
    public class Avdelning
    {
        public int AvdelningId { get; set; }

        public string AvdelningName { get; set; }

        public List<Personal> Personals { get; set; }

    }
}
