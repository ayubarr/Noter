using Noter.Domain.Models.Common;

namespace Noter.Domain.Models.Entities
{
    public class Note : BaseNote
    {
        public string PastReport { get; set; }
        public string CurrentReport { get; set; }
        public string NextReport { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
