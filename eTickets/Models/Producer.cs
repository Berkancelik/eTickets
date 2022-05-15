using System.Collections.Generic;

namespace eTickets.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public int ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }
        //Relationsships
        public List<Movie> Movies { get; set; }
    }
}
