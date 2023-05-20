using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    internal class DTO_Usuario
    {
        private int id;
        private string Nome, usuario, email, senha;

        public int Id { get => id; set => id = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
