using BlazorShop.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService(DataContext context)
        {
            _context = context;
        }
        public async Task<int> GetVisits()
        {
            throw new NotImplementedException();
        }

        public Task IncrementVisits()
        {
            throw new NotImplementedException();
        }
    }
}
