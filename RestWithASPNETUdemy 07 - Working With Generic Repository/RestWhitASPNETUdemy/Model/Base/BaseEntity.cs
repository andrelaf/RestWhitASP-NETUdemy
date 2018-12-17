using System.ComponentModel.DataAnnotations.Schema;


namespace RestWhitASPNETUdemy.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long? Id { get; set; }
    }
}
