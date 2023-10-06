using Microsoft.EntityFrameworkCore;
using TemperatureSensor.Entities;

namespace TemperatureSensor.Services
{
    public class TemperatureInfoRepository : ITemperatureInfoRepository
    {
        private readonly TemperatureInfoContext context;

        public TemperatureInfoRepository(TemperatureInfoContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<TemperatureInfo?> AddTemperatureInfo(int temperature)
        {
            var coldStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "cold").FirstOrDefault();
            var warmStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "warm").FirstOrDefault();
            var hotStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "hot").FirstOrDefault();
            var temp = new TemperatureInfo(
                temperature, coldStateLimits.Value, warmStateLimits.Value, hotStateLimits.Value);

            context.TemperatureInfos.Add(temp);
            await context.SaveChangesAsync();

            return temp;
        }

        public async Task<IEnumerable<TemperatureInfo>> GetAllAsync()
        {
            return await context.TemperatureInfos.OrderBy(t => t.Id).ToListAsync();
        }

        public async Task<IEnumerable<StateLimit>> GetAllStateLimitsAsync()
        {
            return await context.StateLimits.ToListAsync();
        }

        public async Task<StateLimit?> GetStateLimitByNameAsync(string state)
        {
            return await context.StateLimits.FirstOrDefaultAsync(t => t.Name == state);
        }

        public async Task<TemperatureInfo?> GetTemperatureInfoAsync(int tempId)
        {
            return await context.TemperatureInfos.FirstOrDefaultAsync( t => t.Id == tempId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await context.SaveChangesAsync() >= 0);
        }

        public async Task UpdateStateLimits(int hot, int cold, int warm)
        {
            var coldStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "cold").FirstOrDefault();
            var warmStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "warm").FirstOrDefault();
            var hotStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "hot").FirstOrDefault();
            coldStateLimits.Value = cold;
            warmStateLimits.Value = warm;
            hotStateLimits.Value = hot;

            await context.SaveChangesAsync();
        }
    }
}
