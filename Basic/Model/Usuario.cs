using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string nomeUsuario;
        private string senha;
        private bool ativo;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


    }
}
