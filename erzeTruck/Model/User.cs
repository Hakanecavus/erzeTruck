using System.ComponentModel.DataAnnotations;

namespace erzeTruck.Model
{
    public class User
    {
        [Key]
        public string email { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }

    }
}
