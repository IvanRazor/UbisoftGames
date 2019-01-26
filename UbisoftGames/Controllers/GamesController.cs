using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UbisoftGames.Data;
using UbisoftGames.Models;

namespace UbisoftGames.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameContext _context;

        public GamesController(GameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = await _context.Games.Select(x => x).ToListAsync();

            //List<HtmlGameContainer> htmlGames = new List<HtmlGameContainer>();

            //int i = 0;
            //foreach (var game in games)
            //{
            //    string htmlOpenTag = "";
            //    string htmlCloseTag = "";

            //    if (i == 0)
            //        htmlOpenTag = "<div class='row'>";
                
            //    if (i == 3 || games.IndexOf(game) == games.Count)
            //    {
            //        i = -1;
            //        htmlCloseTag = "</div>";
            //    }

            //    htmlGames.Add(new HtmlGameContainer() { Game = game, HtmlOpenTag = htmlOpenTag, HtmlCloseTag = htmlCloseTag });
            //    i++;
            //}

            return View(games);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute] int id)
        {
            var game = await _context.Games.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (game == null)
                return NotFound();

            return View("/Views/Games/Details.cshtml", game);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)  
        {
            var game = await _context.Games.Where(x => x.Id == id).FirstOrDefaultAsync();
            return View("/Views/Games/Edit.cshtml", game);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] Game game)
        {
            Game oldGame = await _context.Games.Where(x => x.Id == game.Id).FirstOrDefaultAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            oldGame = game;
            _context.SaveChanges();

            var games = await _context.Games.Select(x => x).ToListAsync();

            return View("/Views/Games/Index.cshtml", games);
            //return RedirectToPage("./Index");
        }




        /*
        // GET: api/Games
        [HttpGet]
        public IEnumerable<Game> GetGames()
        {
            return _context.Games;
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGame([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame([FromRoute] int id, [FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != game.Id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Games
        [HttpPost]
        public async Task<IActionResult> PostGame([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return Ok(game);
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }

    */
    }
}