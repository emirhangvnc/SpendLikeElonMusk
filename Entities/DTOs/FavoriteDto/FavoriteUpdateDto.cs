using Core.Entities;

namespace Entities.DTOs.FavoriteDto
{
    public class FavoriteUpdateDto : IDto
    {
        public int Id { get; set; }
        public int FortuneId { get; set; }
    }
}