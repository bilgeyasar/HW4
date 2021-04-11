using HWProject4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.DataAccess
{
    public interface IEntityRentCarRepository<T> where T:class,IEntityCar,new()
    {
        List<T> GetRentACars();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
