﻿namespace rest_api.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<ICollection<T>> GetEntities();
        Task<T> GetEntity(int id);
        Task DeleteEntity(int id);
    }
}
