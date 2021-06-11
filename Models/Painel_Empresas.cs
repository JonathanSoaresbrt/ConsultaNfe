using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Painel_Empresas
    {
        [Key]
        public String cnpj { get; set; }
        public String nr_serie { get; set; }
        public String nome { get; set; }
        public String fone { get; set; }
        public String endereco { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH.mm.ss}")]
        public  DateTime dt_ativacao { get; set; }

        public Painel_Empresas()
        { 
        }

        public Painel_Empresas(string cnpj, string nr_serie, string nome, string fone, string endereco, string bairro, string cidade, string estado, DateTime dt_ativacao)
        {
            this.cnpj = cnpj;
            this.nr_serie = nr_serie;
            this.nome = nome;
            this.fone = fone;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.dt_ativacao = dt_ativacao;
        }
    }

}
