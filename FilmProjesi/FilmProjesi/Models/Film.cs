using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "isminizi girin.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="yılı girin.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "film kategorisini seçin.")]
        public string Type { get; set; }
        [Required(ErrorMessage = "yönetmeni yazın.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "imdb puanını girin.")]
        public double Imdb { get; set; }
        [Required(ErrorMessage = "filmin konusundan bahsedin.")]
        public string Issue { get; set; }


    }
}
