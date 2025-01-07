using Airlines.API.Models;

namespace Airlines.API.Data
{
    public static class FakeDb
    {
        public static List<Airline> allFakeAirlines = new List<Airline>
            {
                new Airline { Id = 1, Name = "Airline 1" },
                new Airline { Id = 2, Name = "Airline 2" },
            };

        public static List<Airline> GetAllAirlines() {
            return allFakeAirlines;
        }

        public static void AddNewAirline(Airline newAirline)
        {
            allFakeAirlines.Add(newAirline);
        }
    }
}
