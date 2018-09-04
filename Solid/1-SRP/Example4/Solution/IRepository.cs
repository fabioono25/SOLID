using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Text;

namespace Solid._1_SRP.Example4.Solution
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Save();
    }

    public class Repository<D, T> : IRepository<T> where T : class where D : DbContext, new()
    {
        readonly D entities = new D();

        public void Create(T entity)
        {
            try
            {
                entities.Set<T>().Add(entity);
            }
            catch (Exception ex)
            {
                FileLogger.Log(ex.ToString());
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
                FileLogger.Log(ex.ToString());
            }
        }
    }

    internal static class FileLogger
    {
        private static string Path { get; } = @"C:\Temp";

        public static void Log(string message) => File.WriteAllText(Path, message);
    }
}
