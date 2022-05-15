using eTickets.Data;
using System;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<ActorMovie> ActorMovies  { get; set; }
        public int CinemaId { get; set; }
        public Cinema  Cinema { get; set; }
    }
}
