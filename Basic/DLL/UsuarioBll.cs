using DAL;
using Model;
using System.Collections.Generic;
namespace BLL
{
    public class UsuarioBll

    {
        public void Inserir()
        {
            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Djackson";
            usuario.Senha = "123";
            usuario.Ativo = true;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(usuario);
        }
        public void excluir()
        {

        }
        public void Alterar()
        {

        }
        public List<Usuario> Buscar()
        {
            return new List<Usuario>();


        }
    }
}
