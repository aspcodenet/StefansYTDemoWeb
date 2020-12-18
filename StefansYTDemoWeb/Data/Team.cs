using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StefansYTDemoWeb.Data
{
    public class Team
    {
        public int Id { set; get; }

        [MaxLength(40)]
        public string Name { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }
}