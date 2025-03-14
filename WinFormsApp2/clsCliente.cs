using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class clsCliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public clsCliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }




    }
}
