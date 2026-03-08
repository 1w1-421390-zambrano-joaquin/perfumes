using perfumes.DATA.DTOs.ProveedoresDTO;
using perfumes.DATA.Models;

namespace perfumes.DATA.Service.interfaces
{
    public interface IProveedorService
    {
        Task<List<Proveedore>> TraerTodo();
        Task<Proveedore?> TraerId(int id);
        Task<bool> Agregar(AgregarDto proveedor);
        Task<bool> Modificar(UpdateDto proveedor, int id);
        Task<bool> Borrar(Proveedore proveedor, int id);
    }
}
