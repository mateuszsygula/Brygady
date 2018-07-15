using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Brygady2.Models
{
    public class Photos
    {
        [Key]
        public int      IdPhoto                 { get; set; }

        [Required]
        [Display(Name = "Nazwa zdj�cia")]
        public string   PhotoName               { get; set; }

        [Required]
        [Display(Name = "Zdj�cie")]
        public string   PhotoURL                  { get; set; }

        public string   PhotoThumbnailURL         { get; set; }

        [Display(Name = "Komentarz")]
        public string   PhotoInfo               { get; set; } 
     }


}
