using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; // SQL Server 관련
using BoardAPI.Data;
using BoardAPI.Models;

namespace BoardAPI.Repositories
{

    public class BoardRepository : IBoardRepository
    {
        private readonly ApplicationDbContext _context;

        public BoardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Board>> GetAllAsync()
        {
            var 
            return await _context.Boards.ToListAsync();
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            return await _context.Boards.FindAsync(id);
        }

        public async Task<Board> CreateAsync(Board board)
        {
            _context.Boards.Add(board);
            await _context.SaveChangesAsync();
            return board;
        }

        public async Task UpdateAsync(Board board)
        {
            _context.Entry(board).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var board = await _context.Boards.FindAsync(id);
            if (board != null)
            {
                _context.Boards.Remove(board);
                await _context.SaveChangesAsync();
            }
        }
    }
} 