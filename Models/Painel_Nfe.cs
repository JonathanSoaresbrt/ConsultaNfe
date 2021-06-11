using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Painel_Nfe
    {
        public int id { get; set; }
        public string nr_serie { get; set; }
       
        public String cnpj { get; set; }
        public int tp_nota { get; set; }

        public int nfnumero { get; set; }
        public string serie_nf { get; set; }

        public int modelo_nf { get; set; }
        public String status { get; set; }

        [Key]
        public String retorno { get; set; }
        public String chave_nfe { get; set; }
        public String cxml { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH.mm.ss}")]
        public DateTime dt_termino { get; set; }

        public Painel_Nfe()
        { 
        
        }

        public Painel_Nfe(int id, string nr_serie, string cnpj, int tp_nota, int nfnumero, string serie_nf, int modelo_nf, string status, string retorno, string chave_nfe, string cxml, DateTime dt_termino)
        {
            this.id = id;
            this.nr_serie = nr_serie;
            this.cnpj = cnpj;
            this.tp_nota = tp_nota;
            this.nfnumero = nfnumero;
            this.serie_nf = serie_nf;
            this.modelo_nf = modelo_nf;
            this.status = status;
            this.retorno = retorno;
            this.chave_nfe = chave_nfe;
            this.cxml = cxml;
            this.dt_termino = dt_termino;
        }
       
    }
    
}

