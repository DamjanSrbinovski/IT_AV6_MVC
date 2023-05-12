using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_AV6_7_211189.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }

        public MovieRentals()
        {
            clients = new List<Client>();
        }
    }
}