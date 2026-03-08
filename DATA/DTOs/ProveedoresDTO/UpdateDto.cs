using System.ComponentModel.DataAnnotations;

namespace perfumes.DATA.DTOs.ProveedoresDTO
{
    public class UpdateDto
    {
        public string NombreEmpresa { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
