

namespace Entity
{
    public class CoronaDetails
    {
        public int id { get; set; }
        public DateTime DateReceivingPositiveResult { get; set; }
        public DateTime recoveryDate { get; set; }
        public User user { get; set; }
    }
}
