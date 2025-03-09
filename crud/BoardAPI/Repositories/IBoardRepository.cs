using BoardAPI.Models;

namespace BoardAPI.Repositories
{
    public interface IBoardRepository
    {
        Task<IEnumerable<Board>> GetAllAsync();
        Task<Board> GetByIdAsync(int id);
        Task<Board> CreateAsync(Board board);
        Task UpdateAsync(Board board);
        Task DeleteAsync(int id);
    }
} 