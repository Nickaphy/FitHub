using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._2._BusinessLogicLayer.ENT_OBJ
{
    public class ClassHistoryDTO
    {
        public string classType { get; set; }
        public string classLocation { get; set; }
        public DateTime classDate { get; set; }
        public string classTime { get; set; }
        public string classCapacity { get; set; }
        public string memberName { get; set; }
        public int memberID { get; set; }
        public int classID { get; set; }
        public int instructorID { get; set; }
        public string instructorName { get; set; }
    }
}
