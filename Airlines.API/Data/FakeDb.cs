using Airlines.API.Models;

namespace Airlines.API.Data
{
    public static class FakeDb
    {
        public static List<Airline> GetAllAirlines() {
            return new List<Airline>
            {
                new Airline { Id = 1, Name = "Airline 1" },
            new Airline { Id = 2, Name = "Airline 2" },
            new Airline { Id = 3, Name = "Airline 3" },
            new Airline { Id = 4, Name = "Airline 4" },
            new Airline { Id = 5, Name = "Airline 5" },
            };
            
        }
    }
}
