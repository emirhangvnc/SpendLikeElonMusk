using Core.DataAccess;

namespace Entities.Concrete
{
    public class PersonalWealth:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public decimal Fortune { get; set; }
    }
}
