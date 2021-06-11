using RelatoriosWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RelatoriosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RelatoriosWeb.Services
{
    public class PainelService
    {

        private readonly RelatoriosWebContext _context;

        public PainelService(RelatoriosWebContext context)
        {

            _context = context;

        }

        public async Task<List<IGrouping<int, Painel>>> FindByDatePainelGroupingAsync(DateTime? minDate, DateTime? maxDate, string ccnpj, int numnota)
        {

            var result = from obj in _context.painel select obj;

            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            if (minDate.HasValue && maxDate.HasValue)
            {
                result = result.Where(x => x.dt_termino >= minDate.Value && x.dt_termino <= maxDate.Value && x.cnpj == ccnpj && x.nfnumero != 0);
            }
            if (numnota != 0)
            {
                result = result.Where(x => x.cnpj == ccnpj && x.nfnumero == numnota && x.nfnumero != 0);
            }

            return await result.OrderByDescending(x => x.dt_termino).GroupBy(x => x.nfnumero).OrderByDescending(x => x.Key).ToListAsync();
        }


        public async Task<List<Painel>> FindAllAsync()
        {

            return await _context.painel.ToListAsync();
        }

        public async Task<List<Painel_Empresas>> FindByDateEmpresasAsync(DateTime? minDate, DateTime? maxDate, string ccnpj)
        {
            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            var result = from obj in _context.painel_empresas select obj;

            if (ccnpj != null)
            {
                result = result.Where(x => x.cnpj == ccnpj);
            }

            if (minDate.HasValue)
            {
                result = result.Where(x => x.dt_ativacao >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.dt_ativacao <= maxDate.Value);
            }

            return await result.OrderBy(x => x.nome).ToListAsync();
        }
       
        public async Task<List<Painel>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            maxDate = maxDate.Value.Add(new TimeSpan(23, 59, 59));

            var result = from obj in _context.painel select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.dt_termino >= minDate.Value && x.nfnumero != 123456789);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.dt_termino <= maxDate.Value && x.nfnumero != 123456789);
            }

            return await result.OrderByDescending(x => x.dt_termino).ToListAsync();
        }

        public async Task<List<Painel>> FindByCnpj(string cnpj)
        {
            var result = from obj in _context.painel select obj;
            if (cnpj != null)
            {
                result = result.Where(x => x.cnpj == cnpj).OrderByDescending(x => x.dt_termino);
            }

            return await result.ToListAsync();
        }

        public async Task<List<Painel>> FindByNrSerie(string nrserie)
        {
            var result = from obj in _context.painel select obj;
            if (nrserie != null)
            {
                result = result.Where(x => x.nr_serie == nrserie);
            }

            return await result.ToListAsync();
        }
        public async Task<List<Painel_Nfe>> FindByNfNumero(int id)
        {
            var result = from obj in _context.painel_nfe select obj;
            if (id != 0)
            {
                result = result.Where(x => x.nfnumero == id);
            }

            return await result.ToListAsync();
        }
       
    }
}
