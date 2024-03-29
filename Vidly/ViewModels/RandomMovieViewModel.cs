﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
    public  class CustomersViewModel
    {
        public List<Customer> Customers { get; set; }
    }
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }
    }
}