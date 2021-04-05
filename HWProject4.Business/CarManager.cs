using HWProject4.DataAccess;
using HWProject4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.Business
{
    public class CarManager
    {
        IRentACarDal _cardal;
        public CarManager(IRentACarDal cardal)
        {
            _cardal = cardal;
        }

        public List<RentACar> GetRentACars()
        {
            return _cardal.GetRentACars();
        }
    }
}
