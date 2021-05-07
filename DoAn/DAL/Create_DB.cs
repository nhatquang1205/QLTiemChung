using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class Create_DB : CreateDatabaseIfNotExists<QLVaccine_Model>
    {
        protected override void Seed(QLVaccine_Model context)
        {
            context.Vaccines.AddRange(new Vaccine[]
                {
                    new Vaccine { Vaccine_ID = 1, TenVaccine = "Covid-19", 
                                  LoaiVaccine = "Vaccine giải độc tố", SoLuong = 10},
                    new Vaccine { Vaccine_ID = 2, TenVaccine = "ViemGanB", 
                                  LoaiVaccine = "Vaccine sống giảm động lực", SoLuong = 10},
                    new Vaccine { Vaccine_ID = 3, TenVaccine = "Covid-19",
                                  LoaiVaccine = "Vaccine bất hoạt", SoLuong = 10},
                    new Vaccine { Vaccine_ID = 4, TenVaccine = "Covid-19",
                                  LoaiVaccine = "Vaccine tiểu đơn vị", SoLuong = 10},
                });
        }
    }
}
