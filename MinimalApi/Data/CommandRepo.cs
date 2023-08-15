using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

namespace MinimalApi.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;

        public CommandRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            await _context.commands.AddAsync(command);
        }

        public void DeleteCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.commands.Remove(command);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.commands.ToListAsync();
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
           await _context.SaveChangesAsync();
        }
    }
}
