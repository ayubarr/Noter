using Noter.Domain.Models.Common;

namespace Noter.Domain.Models.Entities
{
    public class User : AccountHolder
    {
        public List<Note> Notes = new List<Note>();
    }
}
