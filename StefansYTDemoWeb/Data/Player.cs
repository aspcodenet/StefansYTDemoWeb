using System.ComponentModel.DataAnnotations;

namespace StefansYTDemoWeb.Data
{
    public class Player
    {
        public int Id { set; get; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Range(1,100)]
        int JerseyNumber { get; set; }
    }
}