using IT_AV6_7_211189.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_AV6_7_211189.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public static Movie movie = new Movie()
        {
            Title = "The Notebook!",
            Rating = 5,
            ImageURL = @"https://m.media-amazon.com/images/M/MV5BN2I3ZmRjODAtMjBiNy00ZmEwLWEzZjItZjM4NGZhNGYyNTA0XkEyXkFqcGdeQXVyMTEwNDU1MzEy._V1_.jpg"
        };
        public static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Damjan", Address = "Hristo Chernopeev", Age = 21, PhoneNum = "071 670 730",
            },
            new Client()
            {
                Name = "Ana",
                Address = "Gege",
                Age = 20,
                PhoneNum = "078 388 923",
            },
            new Client()
            {
                Name = "Marija",
                Address = "Leninova",
                Age = 23,
                PhoneNum = "072 923 234"
            },
            new Client()
            {
                Name = "Angela",
                Address = "Ruzveltova",
                Age = 15,
                PhoneNum = "071 155 293"
            }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() { 
        MovieRentals movierentals = new MovieRentals();
        movierentals.clients = clients;
        movierentals.movie = movie;
        return View(movierentals);
        }
        public ActionResult ShowClient(int Id)
        {
            var model = clients.ElementAt(Id);
            return View(model);

        }
    }
}