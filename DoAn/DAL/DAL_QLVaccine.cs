using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    class DAL_QLVaccine
    {
        private QLVaccine_Model db;
        public DAL_QLVaccine()
        {
            db = new QLVaccine_Model();
        }
        private static DAL_QLVaccine _Instance;
        public static DAL_QLVaccine Intance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_QLVaccine();
                return _Instance;
            }
            private set { }
        }
        public List<Vaccine> getAllVaccines_DAL()
        {
            List<Vaccine> data = new List<Vaccine>();
            data = db.Vaccines.ToList();
            return data;
        }
        public List<Vaccine> getListVaccines_DAL(string _PhanLoai, string _TenVaccine)
        {
            List<Vaccine> data = new List<Vaccine>();
            if(_PhanLoai == "All")
            {
                data = db.Vaccines.Where(p => p.TenVaccine.Contains(_TenVaccine)).ToList();
            }
            else
            {
                data = db.Vaccines.Where(p => p.LoaiVaccine == _PhanLoai &&
                                              p.TenVaccine.Contains(_TenVaccine)).ToList();
            }
            return data;
        }
        public Vaccine getVaccineByVaccineID(string _Vaccine_ID)
        {
            int s = Convert.ToInt32(_Vaccine_ID);
            List<Vaccine> data = (db.Vaccines.Where(p => p.Vaccine_ID == s )).ToList();
            return data[0];
        }
    }
}
