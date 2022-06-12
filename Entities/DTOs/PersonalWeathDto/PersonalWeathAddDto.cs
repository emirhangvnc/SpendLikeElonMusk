using Core.Entities;

namespace Entities.DTOs.PersonalWeathDto
{
    public class PersonalWeathAddDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Fortune { get; set; }
    }
}
