using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CoronaDtailseDto
    {
        public int id { get; set; }
        public DateTime DateReceivingPositiveResult { get; set; }
        public DateTime recoveryDate { get; set; }
        public int user_id { get; set; }
    }
}
