using Microsoft.EntityFrameworkCore;
using PatronesDeDiseñoConsole.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatronesDeDiseñoConsole.PatronRepositorio.Contracts
{
    class EjemploRepositorio : IEemploRepositorio<Ejemplo>
    {
        private PatronesDeDiseñoContext _context;

        public EjemploRepositorio(PatronesDeDiseñoContext context)
        {
            _context = context;
        }

        public async Task<Ejemplo> AddAsync(Ejemplo entity)
        {
            _context.Ejemplos.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Ejemplo entity)
        {
            _context.Ejemplos.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Ejemplo>> GetAsync()
        {
            return await _context.Ejemplos.ToListAsync();
        }

        public Task<Ejemplo> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public Task<Ejemplo> UpdateAsync(Ejemplo entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
