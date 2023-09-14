using DMAWS_T2204M_VuXuanDong.Models;

namespace DMAWS_T2204M_VuXuanDong.DTOs
{
    public class ProjectEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public string Tasks { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Project Projects { get; set; }
    }
}
