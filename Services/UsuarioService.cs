using RelatoriosWeb.Data;
using Microsoft.EntityFrameworkCore;
using RelatoriosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
using Newtonsoft.Json.Linq;

namespace RelatoriosWeb.Services
{
    public class UsuarioService
    {

        private readonly RelatoriosWebContext _context;

        public UsuarioService(RelatoriosWebContext context)
        {

            _context = context;
        
        }

    }
}
