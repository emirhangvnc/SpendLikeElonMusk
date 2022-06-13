using Core.DataAccess;

namespace Entities.Concrete
{
    public class CompanyWealth:IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
    }
}