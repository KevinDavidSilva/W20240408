using W20240408.AccesoADatos;
using W20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W20240408.LogicaDeNegocio
{
    public class PersonaWBL
    {
        readonly PersonaWDAL _personaWDAL;
        public PersonaWBL(PersonaWDAL personaWDAL)
        {
            _personaWDAL = personaWDAL;
        }
        public async Task<int> Crear(PersonaW personaW)
        {
            return await _personaWDAL.Crear(personaW);
        }
        public async Task<int> Modificar(PersonaW personaW)
        {
            return await _personaWDAL.Modificar(personaW);
        }
        public async Task<int> Eliminar(PersonaW personaW)
        {
            return await _personaWDAL.Eliminar(personaW);
        }
        public async Task<PersonaW> ObtenerPorId(PersonaW personaW)
        {
            return await _personaWDAL.ObtenerPorId(personaW);
        }
        public async Task<List<PersonaW>> ObtenerTodos()
        {
            return await _personaWDAL.ObtenerTodos();
        }
        public async Task<List<PersonaW>> Buscar(PersonaW personaW)
        {
            return await _personaWDAL.Buscar(personaW);
        }
    }
}
