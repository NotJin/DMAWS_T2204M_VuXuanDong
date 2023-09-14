using DMAWS_T2204M_VuXuanDong.Models;

namespace DMAWS_T2204M_VuXuanDong.DTOs
{
    public class ProjectDTo
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
