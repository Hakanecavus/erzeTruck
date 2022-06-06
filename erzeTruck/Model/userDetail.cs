using System.ComponentModel.DataAnnotations;
namespace erzeTruck.Model
{
    public class userDetail
    {
        [Key]
        public string email { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
        public bool? emailVerified { get; set; }

        public User? user { get; set; }
        public string userId { get; set; }
    }
}
