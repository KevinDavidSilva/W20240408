using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W20240408.EntidadesDeNegocio;

namespace W20240408.AccesoADatos
{
    public class PersonaWDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaWDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaWDAL personaW)
        {
            _appDbContext.Add(personaW);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaW personaW)
        {
            var personawdal = await
            _appDbContext.personaW.FirstOrDefaultAsync(s => s.Id == personaW.Id);
            if (personawdal != null)
            {
                personawdal.NombreW = personawdal.NombreW;
                personawdal.ApellidoW = personawdal.ApellidoW;
                personawdal.FechaNacimientoW =
                personawdal.FechaNacimientoW;
                personawdal.SueldoW = personawdal.SueldoW;
                personawdal.EstatusW = personawdal.EstatusW;
                personawdal.ComentarioW = personawdal.ComentarioW;
                _appDbContext.Update(personawdal);
            }
            return await _appDbContext.SaveChangesAsync();

        }
        public async Task<int> Eliminar(PersonaW personaW)
        {
            var personawdal = await
            _appDbContext.personaW.FirstOrDefaultAsync(s => s.Id == personaW.Id);
            if (personawdal != null)
                _appDbContext.Remove(personawdal);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaW> ObtenerPorId(PersonaW personaW)
        {
            var clienteData = await _appDbContext.personaW.FirstOrDefaultAsync(s => s.Id == personaW.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonaW();
        }
        public async Task<List<PersonaW>> ObtenerTodos()
        {
            return await _appDbContext.personaW.ToListAsync();
        }
        public async Task<List<PersonaW>> Buscar(PersonaW personaW)
        {
            var query = _appDbContext.personaW.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaW.NombreW))
            {
                query = query.Where(s => s.NombreW.Contains(personaW.NombreW));
            }
            if (!string.IsNullOrWhiteSpace(personaW.ApellidoW))
            {
                query = query.Where(s => s.ApellidoW.Contains(personaW.ApellidoW));
            }
            return await query.ToListAsync();
        }

        public Task<int> Crear(PersonaW personaW)
        {
            _appDbContext.Add(personaW);
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
