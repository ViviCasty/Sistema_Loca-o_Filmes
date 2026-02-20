using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locação_Filmes.Models
{
    class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }

        public bool Disponivel { get; set; } = true;
        
    }
}
