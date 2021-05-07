using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    [Table("Vaccine")]
    public class Vaccine
    {
        public Vaccine()
        {
            LichTiems = new HashSet<LichTiem>();
        }
        [Key]
        public int Vaccine_ID { get; set; }
        [StringLength(50)]
        public string TenVaccine { get; set; }
        [StringLength(50)]
        public string LoaiVaccine { get; set; }
        public int SoLuong { get; set; }
        public virtual ICollection<LichTiem> LichTiems { get; set; }
    }
}
