using System.ComponentModel.DataAnnotations.Schema;

namespace RestWhitASPNETUdemy.Model
{
    [Table("users")]
    public class User
    {
        public long? Id { get; set; }
        public string Login { get; set; }
        public string AccessKey { get; set; }
    }
}
