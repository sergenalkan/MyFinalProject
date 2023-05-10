using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")] //bu isteği yaparken bize nasıl ulaşsınlar?
    [ApiController] //attribute -- Java(annotation) --- bilgi verme imzalama

    public class ProductsController : ControllerBase
    {
        //Loosely Coupled - gevşek bağımlılık (soyuta bağlılık)
        //naminf convention
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
