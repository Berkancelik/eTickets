using System.Collections.Generic;

namespace eTickets.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        public List<Movie> Movies  { get; set; }
    }
}
