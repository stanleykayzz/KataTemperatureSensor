using Microsoft.EntityFrameworkCore;
using TemperatureSensor.Entities;
using TemperatureSensor.Models;
using TemperatureSensor.Repository.Interface;

namespace TemperatureSensor.Repository
{
    public class TemperatureInfoRepository : ITemperatureInfoRepository
    {
        private readonly TemperatureInfoContext context;

        public TemperatureInfoRepository(TemperatureInfoContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //public async Task<TemperatureInfo?> AddTemperatureInfo(int temperature)
        //{
        //    var coldStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "cold").FirstOrDefault();
        //    var warmStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "warm").FirstOrDefault();
        //    var hotStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "hot").FirstOrDefault();
        //    var temp = new TemperatureInfo(
        //        temperature, coldStateLimits.Value, warmStateLimits.Value, hotStateLimits.Value);

        //    context.TemperatureInfos.Add(temp);
        //    await context.SaveChangesAsync();

        //    return temp;
        //}

        public async Task CreateTemperatureInfoAsync(TemperatureInfo temperatureInfo)
        {
            await context.TemperatureInfos.AddAsync(temperatureInfo);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTemperatureInfoAsync(int id)
        {
            var selected = await context.TemperatureInfos.FindAsync(id);
            if (selected != null)
            {
                context.TemperatureInfos.Remove(selected);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TemperatureInfo>> GetAllTemperatureInfoAsync()
        {
            return await context.TemperatureInfos.ToListAsync();
        }

        public async Task<TemperatureInfo> GetTemperatureInfoByIdAsync(int id)
        {
            return await context.TemperatureInfos.FirstOrDefaultAsync(t => t.Id == id);
        }

        //public async Task UpdateStateLimits(int hot, int cold, int warm)
        //{
        //    var coldStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "cold").FirstOrDefault();
        //    var warmStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "warm").FirstOrDefault();
        //    var hotStateLimits = context.StateLimits.Where(sl => sl.Name.ToLower() == "hot").FirstOrDefault();
        //    coldStateLimits.Value = cold;
        //    warmStateLimits.Value = warm;
        //    hotStateLimits.Value = hot;

        //    await context.SaveChangesAsync();
        //}

        public async Task UpdateTemperatureInfoAsync(TemperatureInfo temperatureInfo)
        {
            //var finded = await context.TemperatureInfos.FirstOrDefaultAsync(t => t.Id == id);
            //context.u
            //if(finded != null)
            //{
            //    finded.Temperature = temperatureInfo.Temperature;
            //    finded.State = temperatureInfo.State;
            //    finded.Date = temperatureInfo.Date;
            //    await context.SaveChangesAsync();
            //}
            context.Update(temperatureInfo);
            await context.SaveChangesAsync();
        }


        //async Task<IEnumerable<TemperatureInfo>> GetAllTemperatureInfoAsync()
        //{
        //    return await context.TemperatureInfos.ToListAsync();
        //    //var listDto = new List<TemperatureInfoDto>();
        //    //var listTemperatureInfo = await context.TemperatureInfos.ToListAsync();
        //    //foreach(var temperature in listTemperatureInfo)
        //    //{
        //    //    var dto = new TemperatureInfoDto();
        //    //    dto.Temperature = temperature.Temperature;
        //    //    dto.State = temperature.State;
        //    //    dto.Date = temperature.Date;
        //    //    listDto.Add(dto);
        //    //}

        //    //return listDto;
        //}
    }
}
