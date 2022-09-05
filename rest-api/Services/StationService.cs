﻿using rest_api.Interfaces.Repositories;
using rest_api.Interfaces.Services;
using rest_api.Models;

namespace rest_api.Services
{
    public class StationService : IStationService
    {
        readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public async Task Add(Station station, int areaId)
        {
            await _stationRepository.Add(station, areaId);
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Station>> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Task<Station> GetEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
