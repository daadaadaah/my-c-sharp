using BoardAPI.Models;
using BoardAPI.Repositories;

namespace BoardAPI.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public async Task<IEnumerable<Board>> GetAllBoardsAsync()
        {
            return await _boardRepository.GetAllAsync();
        }

        public async Task<Board> GetBoardByIdAsync(int id)
        {
            return await _boardRepository.GetByIdAsync(id);
        }

        public async Task<Board> CreateBoardAsync(Board board)
        {
            board.CreatedAt = DateTime.UtcNow;

            return await _boardRepository.CreateAsync(board);
        }

        public async Task UpdateBoardAsync(Board board)
        {
            board.UpdatedAt = DateTime.UtcNow;
            await _boardRepository.UpdateAsync(board);
        }

        public async Task DeleteBoardAsync(int id)
        {
            await _boardRepository.DeleteAsync(id);
        }
    }
} 