using MovieAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAppProject.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}