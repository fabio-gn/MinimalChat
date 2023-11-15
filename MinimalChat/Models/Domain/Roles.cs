using System.ComponentModel.DataAnnotations;

namespace MinimalChat.Models.Domain;

public class Roles
{
    [Key]
    public int Id { get; set; }
    public string RoleName { get; set; }
    public ICollection<Users> users { get; set; }
}
