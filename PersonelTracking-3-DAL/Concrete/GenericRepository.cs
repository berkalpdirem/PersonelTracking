using Microsoft.EntityFrameworkCore;
using PersonelTracking_3_DAL.Abstract;
using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_3_DAL.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public GenericRepository(DbContext context)
        {
            DbContext = context;
            DbSet = context.Set<T>();
        }
        /// <summary>
        /// İlgili Entity'i Ekleme
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            DbSet.Add(entity);
            DbContext.SaveChanges();
        }
        /// <summary>
        /// İlgili Entity'i silme
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            DbContext.SaveChanges();
        }
        /// <summary>
        /// İlgili ID'deki Entity'i Seçme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T? Get(int Id)
        {
            return DbSet.Where(t => t.Id ==Id).FirstOrDefault();
        }
        /// <summary>
        /// İlgili Tüm Entity'leri Çağırma
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return DbSet.ToList();
        }
        /// <summary>
        /// İlgili Entity'yi Sorgulanamabilr Yapma
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetQueryable()
        {
            return DbSet.AsQueryable();
        }
        /// <summary>
        /// İŞlgili Entity'i güncelleme
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            var oldEntity = DbSet.Find(entity.Id);
            oldEntity = entity;
            DbContext.SaveChanges();
        }
    }
}
