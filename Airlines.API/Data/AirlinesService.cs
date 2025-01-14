using Airlines.API.Models;

namespace Airlines.API.Data
{
    public class AirlinesService
    {
        private AppDbContext _context;
        public AirlinesService(AppDbContext context)
        {
            _context = context;
        }

        public List<Airline> GetAllAirlines() {
            return _context.Airlines.ToList();
        }

        public Airline GetAirlineById(int airlineId)
        {
            var airlineDb = _context.Airlines.FirstOrDefault(a => a.Id == airlineId);
            return airlineDb;
        }

        public void AddNewAirline(Airline newAirline) {

            _context.Airlines.Add(newAirline);
            _context.SaveChanges();
        }

        public void DeleteAirlineById(int airlineId)
        {
            var airlineDb = _context.Airlines.FirstOrDefault(a => a.Id == airlineId);
            if (airlineDb != null)
            {
                _context.Airlines.Remove(airlineDb);
                _context.SaveChanges();
            }
        }

        public void UpdateAirlineById(int airlineId, Airline updatedAirline)
        {
            var airlineDb = _context.Airlines.FirstOrDefault(a => a.Id == airlineId);
            if(airlineDb != null)
            {
                airlineDb.Name = updatedAirline.Name;
                _context.Airlines.Update(airlineDb);
                _context.SaveChanges();
            }
        }
    }
}
