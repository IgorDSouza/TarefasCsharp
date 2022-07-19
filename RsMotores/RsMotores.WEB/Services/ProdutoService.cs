using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.WEB.Models;

namespace RsMotores.WEB.Services
{
    public class ProdutoService
    {
        private Produto _produto = new Produto(); //atributo local

        public static ICollection<Produto> lUsers = new List<Produto>();
        public ProdutoService(Produto objProduto)
        {
            _produto = objProduto;
        }
    }
}
