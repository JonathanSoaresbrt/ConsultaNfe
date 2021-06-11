using Microsoft.EntityFrameworkCore;
using RelatoriosWeb.Data;
using RelatoriosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Services
{
    public class PainelNfe_Service
    {
        private readonly RelatoriosWebContext _context;

        public PainelNfe_Service(RelatoriosWebContext context)
        {

            _context = context;

        }

        public async Task<List<IGrouping<string, Painel_Nfe>>> FindByGrupoAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.painel_nfe select obj;

            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            if (minDate.HasValue && maxDate.HasValue)
            {
                result = result.Where(x => x.dt_termino >= minDate.Value && x.dt_termino <= maxDate.Value);
            }

            return await result.GroupBy(x => x.retorno).OrderByDescending(g => g.Count()).ToListAsync();

        }

        public async Task<IEnumerable<IGrouping<string, Painel_Nfe>>> FindByGrupoAsyncCnpj(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.painel_nfe select obj;

            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            if (minDate.HasValue && maxDate.HasValue)
            {
                result = result.Where(x => x.dt_termino >= minDate.Value && x.dt_termino <= maxDate.Value);
            }

            return await result.GroupBy(x => x.cnpj).OrderByDescending(g => g.Count()).ToListAsync();
        }

        public async Task<List<Painel_Nfe>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate, string ccnpj)
        {
            var result = from obj in _context.painel_nfe select obj;
            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            if (minDate.HasValue)
            {
                result = result.Where(x => x.dt_termino >= minDate.Value && x.cnpj == ccnpj);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.dt_termino <= maxDate.Value && x.cnpj == ccnpj);
            }

            return await result.OrderByDescending(x => x.dt_termino).ToListAsync();

        }

    }
}
