using Core.Entities;

namespace Entities.DTOs.PersonalWeathDto
{
    public class PersonalWeathUpdateDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Fortune { get; set; }
    }
}
