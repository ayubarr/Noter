using Noter.Domain.Models.DTO.Common;

namespace Noter.Domain.Models.DTO.Create
{
    public class DTOCreateNote : DTOCreateBase
    {
        public string PastReport { get; set; }
        public string CurrentReport { get; set; }
        public string NextReport { get; set; }
        public int UserId { get; set; }
    }
}
