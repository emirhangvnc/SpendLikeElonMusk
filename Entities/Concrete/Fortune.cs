using Core.DataAccess;

namespace Entities.Concrete
{
    public class Fortune:IEntity
    {
        public int Id { get; set; }
        public int FortuneId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
