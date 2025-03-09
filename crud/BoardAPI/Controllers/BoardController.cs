아 그러며using Microsoft.AspNetCore.Mvc;
using BoardAPI.Models;
using BoardAPI.Services;

namespace BoardAPI.Controllers
{
    [ApiController]
    // [Route("api/[controller]")]
    [Route("api/boards")]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _boardService;

        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Board>>> GetBoards()
        {
            var boards = await _boardService.GetAllBoardsAsync();
            return Ok(boards);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Board>> GetBoard(int id)
        {
            var board = await _boardService.GetBoardByIdAsync(id);
            if (board == null)
            {
                return NotFound();
            }
            return Ok(board);
        }

        [HttpPost]
        public async Task<ActionResult<Board>> CreateBoard(Board board)
        {
            var createdBoard = await _boardService.CreateBoardAsync(board);
            return CreatedAtAction(nameof(GetBoard), new { id = createdBoard.Id }, createdBoard);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBoard(int id, Board board)
        {
            if (id != board.Id)
            {
                return BadRequest();
            }

            await _boardService.UpdateBoardAsync(board);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard(int id)
        {
            await _boardService.DeleteBoardAsync(id);
            return NoContent();
        }
    }
} 