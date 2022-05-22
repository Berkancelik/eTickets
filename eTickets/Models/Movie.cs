using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<ActorMovie> ActorMovies  { get; set; }
        // cinema
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema  Cinema { get; set; }

        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
