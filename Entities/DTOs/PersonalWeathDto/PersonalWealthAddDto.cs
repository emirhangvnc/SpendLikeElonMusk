using Core.Entities;

namespace Entities.DTOs.PersonalWealthDto
{
    public class PersonalWealthAddDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Fortune { get; set; }
    }
}