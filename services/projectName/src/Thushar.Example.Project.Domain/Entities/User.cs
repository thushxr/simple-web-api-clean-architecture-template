using System.ComponentModel.DataAnnotations.Schema;

namespace Thushar.Example.Project.Domain.Entities
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("name")]  public string Name { get; set; } = string.Empty;
    }
}
