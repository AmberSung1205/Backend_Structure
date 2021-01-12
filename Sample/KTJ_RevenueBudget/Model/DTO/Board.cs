using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTJ_RevenueBudget.Model.DTO
{
    public class Board
    {
        public Guid Guid { get; set; }
        public double M01 { get; set; }
        public double M02 { get; set; }
        public double M03 { get; set; }
        public double M04 { get; set; }
        public double M05 { get; set; }
        public double M06 { get; set; }
        public double M07 { get; set; }
        public double M08 { get; set; }
        public double M09 { get; set; }
        public double M10 { get; set; }
        public double M11 { get; set; }
        public double M12 { get; set; }
        public string Deptid { get; set; }
        public string Year { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
