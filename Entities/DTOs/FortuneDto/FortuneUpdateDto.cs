using Core.Entities;

namespace Entities.DTOs.FortuneDto
{
    public class FortuneUpdateDto : IDto
    {
        public int Id { get; set; }
        public int FortuneId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
