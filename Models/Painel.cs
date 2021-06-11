using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Painel
    {

        public int id { get; set; }
        public String cnpj { get; set; }
        public String nr_serie { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH.mm.ss}")]
        public DateTime dt_termino { get; set; }
        public int nfnumero { get; set; }

        [Key]
        public String retorno { get; set; }
        public String status { get; set; }
        public String movimento { get; set; }

        public Painel()
        {
        }

        public Painel(int id, string cnpj, string nr_serie, DateTime dt_termino, int nfnumero, string retorno, string status, string movimento)
        {
            this.id = id;
            this.cnpj = cnpj;
            this.nr_serie = nr_serie;
            this.dt_termino = dt_termino;
            this.nfnumero = nfnumero;
            this.retorno = retorno;
            this.status = status;
            this.movimento = movimento;
        }

    }
}
