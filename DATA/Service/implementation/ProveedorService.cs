using perfumes.DATA.DTOs.ProveedoresDTO;
using perfumes.DATA.Models;
using perfumes.DATA.Repository.Interfaces;
using perfumes.DATA.Service.interfaces;

namespace perfumes.DATA.Service.implementation
{
    public class ProveedorService : IProveedorService
    {
        private IProveedorRepo _Repo;
        public ProveedorService(IProveedorRepo proveedorRepo)
        {
            _Repo = proveedorRepo;
        }
        public async Task<bool> Agregar(AgregarDto proveedor)
        {
            var entity = new Proveedore()
            {
                NombreEmpresa = proveedor.NombreEmpresa,
                Telefono = proveedor.Telefono,
                Email = proveedor.Email,
                Estado = true
            };
            return await _Repo.Insert(entity);
        }

        public async Task<bool> Borrar(Proveedore proveedor,int id)
        {
            var entity = await TraerId(id);
            entity.Estado = false;
            return await _Repo.Delete(entity);

        }

        public async Task<bool> Modificar(UpdateDto proveedor, int id)
        {
            var entity = await TraerId(id);
            entity.NombreEmpresa = proveedor.NombreEmpresa;
            entity.Telefono = proveedor.Telefono;
            entity.Email = proveedor.Email;
            entity.Estado = proveedor.Estado;

            return await _Repo.Insert(entity);

        }

        public Task<Proveedore?> TraerId(int id)
        {
            var entity = _Repo.GetById(id);
            if (entity == null)
                throw new ArgumentException($"El Proveedor con el ID {id} no existe");
            return entity;
        }

        public async Task<List<Proveedore>> TraerTodo()
        {
            return await _Repo.GetAll();
        }
    }
}
