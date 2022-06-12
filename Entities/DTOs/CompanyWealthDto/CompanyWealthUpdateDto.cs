using Core.Entities;

namespace Entities.DTOs.CompanyWealthDto
{
    public class CompanyWealthUpdateDto : IDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
    }
}