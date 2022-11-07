using Api.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Xml.Serialization;

namespace Api.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BillingDetail
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(TEntity entity, int id);
        Task Delete(int id);
    }
}
