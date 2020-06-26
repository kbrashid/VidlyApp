using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyApp.Models;
namespace VidlyApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Ttitle {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
            set { }
        }
    }
}
