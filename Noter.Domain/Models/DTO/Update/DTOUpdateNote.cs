using Noter.Domain.Models.DTO.Common;

namespace Noter.Services.DTO.Update
{
    public class DTOUpdateNote : DTOUpdateBase
    {
        public string PastReport { get; set; }
        public string CurrentReport { get; set; }
        public string NextReport { get; set; }
        public int UserId { get; set; }

    }
}
