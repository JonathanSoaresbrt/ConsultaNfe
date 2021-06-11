using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Receber
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public Receber()
        { 
        }

        public Receber(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}

