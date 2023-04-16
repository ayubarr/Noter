namespace Noter.Domain.Models.Common
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {LastName}";
            }
        }
    }
}
