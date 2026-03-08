using Microsoft.EntityFrameworkCore;
using perfumes.DATA.Models;
using perfumes.DATA.Repository.Interfaces;

namespace perfumes.DATA.Repository.implementation
{
    public class ProveedorRepo : IProveedorRepo
    {
        private perfumeTestContext _context;
        public ProveedorRepo(perfumeTestContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Proveedore proveedor)
        {
            _context.Update(proveedor);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Proveedore>> GetAll()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<Proveedore?> GetById(int id)
        {
            return await _context.Proveedores.AsNoTracking().FirstOrDefaultAsync(x => x.ProveedorId == id);
        }

        public async Task<bool> Insert(Proveedore proveedor)
        {
            _context.Add(proveedor);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(Proveedore proveedor)
        {
            _context.Update(proveedor);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
