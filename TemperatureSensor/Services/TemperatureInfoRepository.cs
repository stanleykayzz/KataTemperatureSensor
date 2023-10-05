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
        public async Task<IEnumerable<TemperatureInfo>> GetAllAsync()
        {
            return await context.TemperatureInfos.OrderBy(t => t.Id).ToListAsync();
        }

        public async Task<TemperatureInfo?> GetTemperatureInfoAsync(int tempId)
        {
            return await context.TemperatureInfos.FirstOrDefaultAsync( t => t.Id == tempId);
        }

        public Task<TemperatureInfo?> GetTemperatureInfoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
