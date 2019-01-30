using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UbisoftGames.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Max length is 50")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Max length is 200")]
        [Display(Name = "Image")]
        public string Image { get; set; }
          
        [Required]
        [MaxLength(500, ErrorMessage = "Max length is 500")]
        public string Description { get; set; }

        [Display(Name = "Released?")]
        public bool IsReleased { get; set; }
    }

    public class HtmlGameContainer
    {
        public Game Game { get; set; }
        public string HtmlOpenTag { get; set; }
        public string HtmlCloseTag { get; set; }
    }
}
