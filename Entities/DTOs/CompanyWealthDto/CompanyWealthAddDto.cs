using Core.Entities;

namespace Entities.DTOs.CompanyWealthDto
{
    public class CompanyWealthAddDto : IDto
    {
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
    }
}