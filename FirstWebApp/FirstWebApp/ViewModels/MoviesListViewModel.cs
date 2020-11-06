using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstWebApp.Models;

namespace FirstWebApp.ViewModels
{
    public class MoviesListViewModel
    {
        public List<Movie> Movies { get; set; }
    }
}