using DoAn.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BLL
{
    class BLL_QLVaccine
    {
        private static BLL_QLVaccine _Instance;
        public static BLL_QLVaccine Intance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLVaccine();
                return _Instance;
            }
            private set { }
        }
        public List<Vaccine> getAllVaccines_BLL()
        {
            return DAL_QLVaccine.Intance.getAllVaccines_DAL();
        }
        public List<Vaccine> getListVaccines_BLL(string _PhanLoai, string _TenVaccine)
        {
            return DAL_QLVaccine.Intance.getListVaccines_DAL(_PhanLoai, _TenVaccine);
        }
        public Vaccine getVaccineByVaccineID(string _Vaccine_ID)
        {
            return DAL_QLVaccine.Intance.getVaccineByVaccineID(_Vaccine_ID);
        }
    }
}
