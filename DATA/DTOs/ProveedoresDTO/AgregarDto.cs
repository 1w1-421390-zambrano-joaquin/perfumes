using System.ComponentModel.DataAnnotations;

namespace perfumes.DATA.DTOs.ProveedoresDTO
{
    public class AgregarDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NombreEmpresa { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
