using Core.DataAccess;

namespace Entities.Concrete
{
    public class Favorite:IEntity
    {
        public int FavoriteId { get; set; }
        public int FortuneId { get; set; }
        public int ProductId { get; set; }
    }
}