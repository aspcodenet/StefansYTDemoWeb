using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StefansYTDemoWeb.Data
{
    public class DataInitializer
    {
        private readonly HockeyContext _context;

        public DataInitializer(HockeyContext context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.Migrate();

            if (_context.Teams.Any(p => p.Name == "Tre Kronor"))
            {
                _context.Teams.Add(new Team { Name = "Tre Kronor"});
                _context.SaveChanges();
            }
        }

    }
}