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
        public FlashCardController(IFlashCardService flashCardService)
        {
            _flashCardService = flashCardService;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> CreateCard([FromBody] AddNewCardDTO addNewCardDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!addNewCardDTO.Type.Equals(FlashCardType.Basic, StringComparison.InvariantCultureIgnoreCase) && !addNewCardDTO.Type.Equals(FlashCardType.Advanced, StringComparison.InvariantCultureIgnoreCase))
            {
                return BadRequest();
            }
            try
            {
                var newCard = await _flashCardService.AddCard(addNewCardDTO);
                return StatusCode(StatusCodes.Status201Created, newCard);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> GetCards([FromQuery] FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                IEnumerable<FlashCardModel> flashCards = await _flashCardService.GetCards(flashCardQueryParams);
                return Ok(flashCards);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> GetSingleCard([FromRoute] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (id <= 0)
                {
                    return BadRequest();
                }
                FlashCardModel returnedFlashCard = await _flashCardService.GetSingleCard(id);
                return Ok(returnedFlashCard);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> UpdateCard([FromBody] UpdateCardDTO updateCardDTO, [FromRoute] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                if (!updateCardDTO.Type.Equals(FlashCardType.Basic, StringComparison.InvariantCultureIgnoreCase) && !updateCardDTO.Type.Equals(FlashCardType.Advanced, StringComparison.InvariantCultureIgnoreCase))
                {
                    return BadRequest();
                }
                if (id <= 0)
                {
                    return BadRequest();
                }
                var updatedCard = await _flashCardService.UpdateCard(id, updateCardDTO);
                return StatusCode(StatusCodes.Status204NoContent, updatedCard);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<IEnumerable<FlashCardModel>>> DeleteCard([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                await _flashCardService.DeleteCard(id);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
