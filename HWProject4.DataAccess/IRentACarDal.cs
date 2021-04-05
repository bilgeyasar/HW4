using HWProject4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.DataAccess
{
    public interface IRentACarDal
    {
        List<RentACar> GetRentACars();
       void Add(RentACar car);
    }
}
