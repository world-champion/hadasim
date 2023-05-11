using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CoronaVaccineDto
    {
        public int id { get; set; }
        public DateTime dateReceiving { get; set; }
        public string manufacturer { get; set; }

        public int userId { get; set; }
    }
}
