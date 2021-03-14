using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public static class Repository
    {
        private static List<Film> films = new List<Film>();

        public static List<Film> Films
        {
            get
            {
                return films;
            }
        }
        public static void AddFilm(Film film)
        {
            films.Add(film);
        }
        public static int Counter()
        {
            return films.Count();
        }
    } 
}
