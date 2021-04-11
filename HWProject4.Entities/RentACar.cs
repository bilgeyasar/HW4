using System;
using System.Collections.Generic;
using System.Text;

namespace HWProject4.Entities
{
    public class RentACar:IEntityCar
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public int CarYear { get; set; }
        public int UnitsInGallery { get; set; }

        //Entities kısmını oluşturduk şimdi Data Access kısmında verileri oluşturacağız.
    }
}
