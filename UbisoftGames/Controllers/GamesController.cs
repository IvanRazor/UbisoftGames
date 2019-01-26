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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind(include: "Id,Name,Image,Description,IsReleased")] Game game)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                _context.Entry(game).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return View("/Views/Games/Details.cshtml", game);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            var newGame = new Game();
            return View(newGame);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(include: "Id,Name,Image,Description,Description")] Game game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return Redirect("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                return NotFound();

            return View("/Views/Games/Delete.cshtml", game);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(include: "Id,Name,Image,Description,IsReleased")] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gameToDelete = await _context.Games.FindAsync(game.Id);
            if (gameToDelete == null)
            {
                return NotFound();
            }

            _context.Games.Remove(gameToDelete);
            await _context.SaveChangesAsync();

            return Redirect("~/");
        }
        
    }
}