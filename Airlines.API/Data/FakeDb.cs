using Airlines.API.Models;

namespace Airlines.API.Data
{
    public static class FakeDb
    {
        public static List<Airline> allAirlinesFakeDb = new List<Airline>
            {
                new Airline { Id = 1, Name = "Airline 1" },
                new Airline { Id = 2, Name = "Airline 2" },
            };

        public static List<Airline> GetAllAirlines() {
            return allAirlinesFakeDb;
        }

        public static Airline GetAirlineById(int airlineId)
        {
            return allAirlinesFakeDb.FirstOrDefault(a => a.Id == airlineId) ?? new Airline();
        }

        public static void AddNewAirline(Airline newAirline) {
            allAirlinesFakeDb.Add(newAirline);
        }

        public static void DeleteAirlineById(int airlineId)
        {
            var airline = allAirlinesFakeDb.FirstOrDefault(a => a.Id == airlineId);
            if(airline != null)
            {
                allAirlinesFakeDb.Remove(airline);
            }
        }

        public static void UpdateAirlineById(int airlineId, Airline updatedAirline)
        {
            var airline = allAirlinesFakeDb.FirstOrDefault(a => a.Id == airlineId);
            if (airline != null)
            {
                airline.Name = updatedAirline.Name;
            }
        }
    }
}
