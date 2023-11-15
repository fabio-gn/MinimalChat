

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalChat.Models.Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Roles))]
        public int RoleId { get; set; }
        public Roles Roles { get; set; }

        public string UserName { get; set; }
        public string? Password { get; set; }
        [ForeignKey(nameof(Rooms))]
        public int RoomsId { get; set; }
        public Rooms? Rooms { get; set; }
        public bool isHost { get; set; }

        public bool isGuest { get; set; } = false;
        public DateTime DateOfRegistration { get; set; }
    }
}
