using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RelatoriosWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        [DataMember]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public String Login { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public String Senha { get; set; }

        public Usuario() { 
        
        }

        public Usuario(int id, string nome, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
        }
    }

}
