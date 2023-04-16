using Noter.Domain.Models.DTO.Common;

namespace Noter.Services.DTO.Update
{
    public class DTOUpdateAdmin : DTOUpdateBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
    }
}
