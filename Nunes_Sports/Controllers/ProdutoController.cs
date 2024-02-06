using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nunes_Sports.Context;
using Nunes_Sports.Models;

namespace Nunes_Sports.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoContext _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }
        
        public IActionResult Criar()
        {
            return View();
        }
        
        [HttpPost] //Envia pra banco
        public IActionResult Criar(Produto produto)
        {
            if(ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }
        public IActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);
            if(produto ==null)
            
             return RedirectToAction(nameof(Index));

             return View(produto);
            
        }
        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.Id);
            produtoBanco.Nome = produto.Nome;
            produtoBanco.Codigo = produto.Codigo;
            produtoBanco.Descricao = produto.Descricao;
            produtoBanco.Preco = produto.Preco;

            _context.Produtos.Update(produtoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detalhes(int id)
        {    var produto = _context.Produtos.Find(id);
                      
            if(produto == null)

            return RedirectToAction(nameof(Index));
            return View(produto);
        }
         public IActionResult Deletar(int id)
         {
             var produto = _context.Produtos.Find(id);

            if(produto == null)
              return RedirectToAction(nameof(Index));

              return View(produto);
         }
          
          [HttpPost]
         public IActionResult Deletar(Produto contato)
         {
            var produtoBanco = _context.Produtos.Find(contato.Id);

            _context.Produtos.Remove(produtoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
         }

    }
}