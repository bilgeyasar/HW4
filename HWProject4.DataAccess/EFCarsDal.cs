using HWProject4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.DataAccess
{
    public class EFCarsDal : IRentACarDal
    {
        //Arabaları kontrol etmek için önce sahte liste oluşturuyoruz.
        List<RentACar> _cars;

        public EFCarsDal()  //Veri kaynağı varmış gibi sahte bir cars oluşturduk.
        {
            _cars = new List<RentACar> {
                new RentACar {CarId=1, CarColor="Red", CarName="Renault A EF", CarYear=2021, UnitsInGallery=1 },
                new RentACar {CarId=2, CarColor="Blue", CarName="Renault B EF", CarYear=2020, UnitsInGallery=2 },
                new RentACar {CarId=3, CarColor="Green", CarName="Renault C EF", CarYear=2019, UnitsInGallery=3 },
                new RentACar {CarId=4, CarColor="White", CarName="Renault D EF", CarYear=2018, UnitsInGallery=4 },
                new RentACar {CarId=5, CarColor="Black", CarName="Renault E EF", CarYear=2017, UnitsInGallery=0 }

            };
        }
        public void Add(RentACar car)
        {
            Console.WriteLine("EF ile eklendi");
        }

        public List<RentACar> GetRentACars()
        {
            return _cars;
        }
    }
}
