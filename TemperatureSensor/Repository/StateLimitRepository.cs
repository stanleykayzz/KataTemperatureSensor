using Microsoft.EntityFrameworkCore;
using TemperatureSensor.Entities;
using TemperatureSensor.Models;
using TemperatureSensor.Repository.Interface;

namespace TemperatureSensor.Repository
{
    public class StateLimitRepository : IStateLimitRepository
    {
        private readonly TemperatureInfoContext _context;

        public StateLimitRepository(TemperatureInfoContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<StateLimit?>> GetAllStateLimitsAsync()
        {
            return await _context.StateLimits.ToListAsync();
        }

        public async Task UpdateStateLimit(StateLimit stateLimit)
        {
            _context.Update(stateLimit);
            _context.SaveChanges();
        }
    }
}
