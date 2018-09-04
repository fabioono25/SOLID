using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Text;

namespace Solid._1_SRP.Example4.Violation
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Save();
    }

    public class Repository<D, T> : IRepository<T> where T : class where D : DbContext, new()
    {
        readonly D entities = new D();

        //two different responsibilities: stores data and logs the error
        //repository is for data access logic
        public void Create(T entity)
        {
            try
            {
                entities.Set<T>().Add(entity);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"error.log", ex.ToString());
            }
            
        }

        public void Save()
        {
            try
            {
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"error.log", ex.ToString());
            }
        }
    }
}
