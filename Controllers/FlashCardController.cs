using FlashCardLearning.DTOs;
using FlashCardLearning.Model;
using FlashCardLearning.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlashCardLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardController : ControllerBase
    {
        private readonly IFlashCardService _flashCardService;    
        public FlashCardController(IFlashCardService flashCardService) {
            _flashCardService = flashCardService;   
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> CreateCard([FromBody] AddNewCardDTO addNewCardDTO)
        {
            try
            {
                IEnumerable<FlashCardModel> flashCards = await _flashCardService.GetCards(flashCardQueryParams);
                return Ok(flashCards);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> GetCards([FromQuery]FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                IEnumerable<FlashCardModel> flashCards = await _flashCardService.GetCards(flashCardQueryParams);
                return Ok(flashCards);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }
    }
}
