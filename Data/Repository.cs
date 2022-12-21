using Microsoft.EntityFrameworkCore;

namespace TP4.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext? _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(UniversityContext universityContext)
        {
            this._context = universityContext;
            this._dbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
               
        }

        public bool AddRange(IEnumerable<TEntity> entities)
        {
                try
                {
                    _dbSet.AddRange(entities);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                throw ex;
                return false;
                }
            
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
                
            }
           
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex; 
                return false;
                
            }
            
        }
    }
    
    
}
