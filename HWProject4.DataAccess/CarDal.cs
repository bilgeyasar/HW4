using HWProject4.Entities;  //Entity olan RentACar'ı kullanmak için referans ekledik.
using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.DataAccess
{
    public class CarDal:IRentACarDal  //interface'e implemente ettik.
    {
        //Arabaları kontrol etmek için önce sahte liste oluşturuyoruz.
        List<RentACar> _cars;

        public CarDal()  //Veri kaynağı varmış gibi sahte bir cars oluşturduk.
        {
            _cars = new List<RentACar> {
                new RentACar {CarId=1, CarColor="Red", CarName="Renault A", CarYear=2021, UnitsInGallery=1 },
                new RentACar {CarId=2, CarColor="Blue", CarName="Renault B", CarYear=2020, UnitsInGallery=2 },
                new RentACar {CarId=3, CarColor="Green", CarName="Renault C", CarYear=2019, UnitsInGallery=3 },
                new RentACar {CarId=4, CarColor="White", CarName="Renault D", CarYear=2018, UnitsInGallery=4 },
                new RentACar {CarId=5, CarColor="Black", CarName="Renault E", CarYear=2017, UnitsInGallery=0 }
            
            };
        }

        public void Add(RentACar car)
        {
            Console.WriteLine("Ado.Net ile eklendi.");
        }

        public void Delete(RentACar entity)
        {
            throw new NotImplementedException();
        }

        public List<RentACar> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RentACar> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentACar> GetRentACars()
        {
            return _cars;  //Sahte listemizi listelemek için return ettik.
        }

        public void Update(RentACar entity)
        {
            throw new NotImplementedException();
        }
    }
}
