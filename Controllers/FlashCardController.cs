using FlashCardLearning.Context;
using FlashCardLearning.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlashCardLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardController : ControllerBase
    {
        private FlashCardAppContext _context;
        public FlashCardController(FlashCardAppContext context) {
            _context = context;
        }

        [HttpGet("/scroll")]
        public async Task<ActionResult<List<FlashCard>>> GetCards([FromQuery(Name ="id")] Guid id )
        {
            return Ok(null);
            //IOrderedQueryable<FlashCard> cards = _context.FlashCards.OrderBy(card => card.Id);
            //return Ok(cards);
        }
    }
}
