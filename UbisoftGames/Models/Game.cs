using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UbisoftGames.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsReleased { get; set; }
    }

    public class HtmlGameContainer
    {
        public Game Game { get; set; }
        public string HtmlOpenTag { get; set; }
        public string HtmlCloseTag { get; set; }
    }
}
