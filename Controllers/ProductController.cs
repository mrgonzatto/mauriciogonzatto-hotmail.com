using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgWeb202.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProgWeb202.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        // O parâmetro definido como Injeção de Dependência
        // e está previamente registrado como serviço do 
        // arquivo Startup.cs
        public ProductController( IProductRepository repo ) {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
        
    }
}
