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

        public async Task<int> Crear(PersonaW personaW)
        {
            _appDbContext.Add(personaW);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaW personaW)
        {
            var personawdal = await
            _appDbContext.Clientes.FirstOrDefaultAsync(s=> s.Id == personaW.Id);
            if (personawdal != null)
            {
                personawdal.NombreW = personaW.NombreW;
                personawdal.ApellidoW = personaW.ApellidoW;
                personawdal.FechaNacimientoW = personaW.FechaNacimientoW;
                personawdal.SueldoW = personaW.SueldoW;
                personawdal.EstatusW = personaW.EstatusW;
                personawdal.ComentarioW = personaW.ComentarioW;
                _appDbContext.Update(personawdal);
            }
            return await _appDbContext.SaveChangesAsync();

        }
        public async Task<int> Eliminar(PersonaW personaW)
        {
            var personawdal = await
            _appDbContext.Clientes.FirstOrDefaultAsync(s => s.Id == personaW.Id);
            if (personawdal != null)
                _appDbContext.Remove(personawdal);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaW> ObtenerPorId(PersonaW personaW)
        {
            var clienteData = await _appDbContext.Clientes.FirstOrDefaultAsync(s => s.Id == personaW.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonaW();
        }
        public async Task<List<PersonaW>> ObtenerTodos()
        {
            return await _appDbContext.Clientes.ToListAsync();
        }
        public async Task<List<PersonaW>> Buscar(PersonaW personaw)
        {
            var query = _appDbContext.Clientes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaw.NombreW))
            {
                query = query.Where(s => s.NombreW.Contains(personaw.NombreW));
            }
            if (!string.IsNullOrWhiteSpace(personaw.ApellidoW))
            {
                query = query.Where(s => s.ApellidoW.Contains(personaw.ApellidoW));
            }
            return await query.ToListAsync();
        }

        
    }
}
