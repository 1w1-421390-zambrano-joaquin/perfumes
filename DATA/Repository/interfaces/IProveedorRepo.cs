using perfumes.DATA.Models;

namespace perfumes.DATA.Repository.Interfaces
{
    public interface IProveedorRepo
    {
        Task<List<Proveedore>> GetAll();
        Task<Proveedore?> GetById(int id);
        Task<bool> Insert(Proveedore partido);
        Task<bool> Update(Proveedore partido);
        Task<bool> Delete(Proveedore partido);
        
    }
}
