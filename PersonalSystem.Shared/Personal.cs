using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSystem.Shared
{
    public class Personal
    {
        public int PersonalId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ManNumber { get; set; }  

        public int AvdelningId { get; set; }    

        public Avdelning Avdelning { get; set; }
    }
}
