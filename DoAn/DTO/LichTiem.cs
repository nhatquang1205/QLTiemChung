using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAn
{
    [Table("LichTiem")]
    public class LichTiem
    {
        [Key]
        public int LichTiem_ID { get; set; }
        [StringLength(100)]
        public string DiaDiem { get; set; }
        public DateTime NgayTiem { get; set; }
        public int SoLuongTiem { get; set; }
        public int Vaccine_ID { get; set; }
        [ForeignKey("Vaccine_ID")]
        public virtual Vaccine Vaccine { get; set; }
    }
}
