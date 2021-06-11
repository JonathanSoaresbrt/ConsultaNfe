using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int Empresa { get; set; }
        public String CnpjEmpresa { get; set; }
        public int Lancamento { get; set; }
        public String ClienteNome { get; set; }
        public String VendedorNome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public Venda() { 
        
        }

        public Venda(int id, int empresa, string cnpjEmpresa, int lancamento, string clienteNome, string vendedorNome, double valor, DateTime data)
        {
            Id = id;
            Empresa = empresa;
            CnpjEmpresa = cnpjEmpresa;
            Lancamento = lancamento;
            ClienteNome = clienteNome;
            VendedorNome = vendedorNome;
            Valor = valor;
            Data = data;
        }
    }
}
