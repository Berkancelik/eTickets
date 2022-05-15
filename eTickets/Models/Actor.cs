using System.Collections.Generic;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public int ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
