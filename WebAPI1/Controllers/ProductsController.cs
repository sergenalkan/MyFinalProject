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
        //Loosely Coupled - gevşek bağımlılık (soyuta bağlılık) - IProductService bağımlı
        //naming convention - isimlendirme standardı - field için yaptık - field defaultu privatedir
        //IoC Container -- Inversion of Control : bellekteki liste -
        //new PM() new efPD() böyle referanslar olsun kim ihtiyaç duyarsa alsın kullansın
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] // http get request gerçekleştiriyor
        public IActionResult GetAll()
        {
            //object tüm veri tiplerinin atası
            //Swagger araştır
            //Dependency chain -- bağımlılık zinciri
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        //get: getir, post ise gönder demek. Body- raw- JSON
        //güncelleme silme için put ve delete var ama gerçek hayatta da post kullanılıyor
        public IActionResult Add(Product product) 
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
