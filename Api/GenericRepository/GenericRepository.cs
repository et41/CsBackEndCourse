using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BillingDetail
    {
        private InheritanceMappingContext _context;
        public GenericRepository(InheritanceMappingContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity, int id)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var existing = await GetById(id);
            _context.Set<TEntity>().Remove(existing);
            await _context.SaveChangesAsync();
        }

    }
}
