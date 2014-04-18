using SportsStore.Domain.Abstract;
using SportsStore.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public ActionResult List()
        {
            return View(_repository.Products);
        }

    }
}
