using FINAL_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public readonly DbSet<T> _dbSet;
        public readonly AirplaneSystemContext _AirplaneSystemContext;

        public GenericRepository(AirplaneSystemContext PharmacyContext)
        {
            _AirplaneSystemContext = PharmacyContext;
            _dbSet = _AirplaneSystemContext.Set<T>();
        }
        #region
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            try
            {
                _AirplaneSystemContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return entity;
        }


        #endregion

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }


        #endregion


        #region Update
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _AirplaneSystemContext.SaveChanges();
            }
            catch
            {

            }
            return entity;
        }
        #endregion

        #region Delete
        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _AirplaneSystemContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
