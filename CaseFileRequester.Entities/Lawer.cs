using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseFileRequester.Entities
{
    public class Lawer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cuit { get; set; }
        public string Password { get; set; }
        public bool DefaultUser { get; set; }
    }
}
