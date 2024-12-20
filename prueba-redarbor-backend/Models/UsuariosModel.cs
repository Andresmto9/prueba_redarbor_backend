using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_redarbor_backend.Models
{
    public class UsuariosModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Surname { get; set; } = null;

        [Required]
        public DateOnly DateOfBird { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        public int RoleID { get; set; }

        [Required]
        public bool Status { get; set; } = true;

        [Column(TypeName = "varchar(500)")]
        public string? Token { get; set; } = null;
    }
}
