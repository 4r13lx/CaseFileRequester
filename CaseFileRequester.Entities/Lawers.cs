using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseFileRequester.Entities
{
    public class Lawers
    {

        private List<Lawer> lstLawers = new List<Lawer>();

        public List<Lawer> LstLawers
        {
            get { return lstLawers; }
            set { lstLawers = value; }
        }
    }
}
