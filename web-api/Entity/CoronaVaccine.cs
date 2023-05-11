
namespace Entity
{
    public class CoronaVaccine
    {
        public int id { get; set; }
        public DateTime dateReceiving { get; set; }
        public string manufacturer { get; set; }
        public User user { get; set; }

    }
}
