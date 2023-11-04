﻿using MovieAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAppProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string mName { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public int Stock { get; set; }
    }
}